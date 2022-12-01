using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Text;
using TestAuthenticateAPI.Models;
using Newtonsoft.Json;
using Shared;
using TestAuthenticateAPI.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Security.Cryptography;
using Shared.Models;
using System.Security.Policy;
using Azure.Storage.Blobs.Models;
using Azure.Core;
using Microsoft.EntityFrameworkCore;

namespace TestAuthenticateAPI.Controllers;

//[Route("Account/[action]")]
[Route("[Controller]/[action]")]
[ApiController]
public class AccountController : PigToolBaseController
{
    const string Callback = "pigprofittool";
    private readonly SignInManager<APIUser> _signInManager;
    private readonly UserManager<APIUser> _userManager;
    private readonly IConfiguration _configuration;
    protected ILookupNormalizer _normalizer;

    public AccountController(
        UserManager<APIUser> userManager,
        SignInManager<APIUser> signInManager,
        IConfiguration configuration,
        ILookupNormalizer normalizer
        ) : base(configuration)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _configuration = configuration;
        _normalizer = normalizer;
    }

    [HttpGet("{scheme}")]
    public async Task SimpleAuth()
    {
        var email = "MyMan@Gmail.Test";
        var givenName = "GMan";
        var surName = "SurMan";


        var appUser = await CreateOrGetUser(email, givenName, surName);
        var authToken = GenerateJwtToken(appUser);

        // Get parameters to send back to the callback
        var qs = new Dictionary<string, string>
                {
                    { "access_token", authToken.token },
                    { "refresh_token",  string.Empty },
                    { "jwt_token_expires", authToken.expirySeconds.ToString() },
                    { "email", email },
                    { "firstName", givenName },
                    { "secondName", surName },
                };

        //Build the result url
        var url = Callback + "://#" + string.Join(
            "&",
            qs.Where(kvp => !string.IsNullOrEmpty(kvp.Value) && kvp.Value != "-1")
            .Select(kvp => $"{WebUtility.UrlEncode(kvp.Key)}={WebUtility.UrlEncode(kvp.Value)}"));

        //Redirect to final url
        Request.HttpContext.Response.Redirect(url);
    }


    [HttpGet]
    public async Task<ActionResult> SimpleAuthJSON()
    {
        var email = "MyMan@Gmail.Test";
        var givenName = "GMan";
        var surName = "SurMan";

        try
        {
            var appUser = await CreateOrGetUser(email, givenName, surName);
            var authToken = GenerateJwtToken(appUser);
            var refreshToken = GenerateRefreshToken();

            _ = int.TryParse(_configuration["JWT-RefreshTokenValidityInDays"], out int refreshTokenValidityInDays);

            appUser.RefreshToken = refreshToken;
            appUser.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(refreshTokenValidityInDays);

            await _userManager.UpdateAsync(appUser);

            // Get parameters to send back to the callback
            var qs = new Dictionary<string, string>
                {
                    { nameof(MobileUser.AuthorisedToken), authToken.token },
                    { nameof(MobileUser.RefreshToken),  refreshToken },
                    //{ nameof(MobileUser.RefreshTokenExpiryTime), authToken.expirySeconds.ToString() },
                    { nameof(MobileUser.AuthorisedEmail), email },
                    { nameof(MobileUser.Name), givenName },
                    { nameof(MobileUser.RowKey), appUser.RowKey },
                    { nameof(MobileUser.PartitionKey), appUser.PartitionKey },
                };

            // build url with previously calculated info to send back to app
            var url = Callback + "://#" + string.Join(
                "&",
                qs.Where(kvp => !string.IsNullOrEmpty(kvp.Value) && kvp.Value != "-1")
                .Select(kvp => $"{WebUtility.UrlEncode(kvp.Key)}={WebUtility.UrlEncode(kvp.Value)}"));

            // Redirect to final url (back to the app)
            //Request.HttpContext.Response.Redirect(url);

            try
            {
                var compressedQs = JsonConvert.SerializeObject(appUser);

                var suucessfullResult = new ContentResult()
                {
                    StatusCode = 200,
                    Content = compressedQs,
                    ContentType = "application/json",
                };

                return suucessfullResult;
            }
            catch (Exception ex)
            {
                var failedResult = new ContentResult()
                {
                    StatusCode = 500,
                    Content = "Something went wrong " + ex.Message,
                    ContentType = "application/json",
                };

                return failedResult;
            }
        }
        catch (Exception ex)
        {
            var failedResult = new ContentResult()
            {
                StatusCode = 500,
                Content = "Something went wrong " + ex.Message,
                ContentType = "application/json",
            };

            return failedResult;
        }




    }

    [HttpPost]
    public async Task<IActionResult> RefreshToken(TokenModel tokenModel)
    {
        var res = new RefreshTokenResponse
        {
            Success = false
        };

        try
        {
            if (tokenModel is null)
            {
                return BadRequest("Invalid client request");
            }

            string? accessToken = tokenModel.access_token;
            string? refreshToken = tokenModel.refresh_token;

            var principal = GetPrincipalFromExpiredToken(accessToken);
            if (principal == null)
            {
                return BadRequest("Invalid access token or refresh token");
            }

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            string username = principal.Identity.Name;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            //var user = await _userManager.FindByNameAsync(username);

            var user =  _userManager.Users.FirstOrDefault(u => u.Email == username);

            if (user == null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
            {
                return BadRequest("Invalid access token or refresh token");
            }

            var newAccessToken = GenerateJwtToken(user);
            var newRefreshToken = GenerateRefreshToken();

            user.RefreshToken = newRefreshToken;
            _ = int.TryParse(_configuration["JWT-RefreshTokenValidityInDays"], out int refreshTokenValidityInDays);
            user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(refreshTokenValidityInDays);
            await _userManager.UpdateAsync(user);

            return new ObjectResult(new
            {
                Success = true,
                bearerToken = newAccessToken.token,
                refreshToken = newRefreshToken
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new ObjectResult(new
            {
                Success = false,
                bearerToken = ex.Message,
                refreshToken = ""
            });
        }
    }


    [HttpGet]
    public async Task MobileAuthChallenge()
    {
        await Request.HttpContext.ChallengeAsync("Google");
    }

    [HttpGet]
    public async Task MobileAuth(string? UserSignedIn = null)
    {
        //NOTE: see https://docs.microsoft.com/en-us/xamarin/essentials/web-authenticator?tabs=android
        var auth = await Request.HttpContext.AuthenticateAsync("Google");

        if (!auth.Succeeded
            || auth?.Principal == null
            || !auth.Principal.Identities.Any(id => id.IsAuthenticated)
            || string.IsNullOrEmpty(auth.Properties.GetTokenValue("access_token")))
        {
            // Not authenticated, challenge
            await Request.HttpContext.ChallengeAsync("Google");
        }
        else
        {
            var claims = auth.Principal.Identities.FirstOrDefault()?.Claims;

            var email = string.Empty;
            email = claims?.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Email)?.Value;
            var givenName = claims?.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.GivenName)?.Value;
            var surName = claims?.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Surname)?.Value;
            var nameIdentifier = claims?.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            // create the user
            var appUser = await CreateOrGetUser(email, givenName, surName);

            // create tokens
            var authToken = GenerateJwtToken(appUser);
            var refreshToken = GenerateRefreshToken();

            var qs = new Dictionary<string, string>
                {
                    { nameof(MobileUser.AuthorisedToken), authToken.token },
                    { nameof(MobileUser.RefreshToken),  refreshToken },
                    //{ nameof(MobileUser.RefreshTokenExpiryTime), authToken.expirySeconds.ToString() },
                    { nameof(MobileUser.AuthorisedEmail), email },
                    { nameof(MobileUser.Name), givenName },
                    { nameof(MobileUser.RowKey), appUser.RowKey },
                    { nameof(MobileUser.PartitionKey), appUser.PartitionKey },
                };

            // build url with previously calculated info to send back to app
            var url = Callback + "://#" + string.Join(
                "&",
                qs.Where(kvp => !string.IsNullOrEmpty(kvp.Value) && kvp.Value != "-1")
                .Select(kvp => $"{WebUtility.UrlEncode(kvp.Key)}={WebUtility.UrlEncode(kvp.Value)}"));

            // Redirect to final url (back to the app)
            Request.HttpContext.Response.Redirect(url);
        }
    }

    [Authorize]
    [HttpPost]
    public async Task<ActionResult> RegisterMobileUser()
    {
        /*ExternalLoginInfo info = await _signInManager.GetExternalLoginInfoAsync();*/
        var callGUID = Guid.NewGuid().ToString();
        var Connection = GetStorageConnectionString();

        try
        {
            var requestJson = await Parse(Request);
            var unparsedRequest = requestJson.Body;
            var MobileUser = new MobileUser();
            var requeststring = Convert.ToString(unparsedRequest);

           


            //Log request
            await LoggingOperations.LogRequestToBlob("REGISTERUSER", "POST", requeststring, callGUID, Connection);

            //Get the user from the request
            MobileUser = JsonConvert.DeserializeObject<MobileUser>(requeststring);
            //var logUser = await _userManager.FindByEmailAsync(MobileUser.AuthorisedEmail);
            var logUser = _userManager.Users.First(u => u.Email == MobileUser.AuthorisedEmail);

            if (logUser == null)
            {
                var contentresultFailed = new ContentResult()
                {
                    Content = $"User Not Found",
                    ContentType = "text/plain",
                    StatusCode = 377
                };

                await LoggingOperations.LogRequestToBlob("REGISTERUSER", "RESPONSE", contentresultFailed.Content, callGUID, Connection);

                return contentresultFailed;
            }

            logUser.updateUserFeilds(MobileUser);


            var updateResult = await _userManager.UpdateAsync(logUser);

        }
        catch (Exception ex)
        {

            var result = new ContentResult()
            {
                Content = $"Error creating user" + Constants.APICALLID + callGUID,
                ContentType = "text/plain"
            };

            await LoggingOperations.LogRequestToBlob("REGISTERUSER", "RESPONSE", result.Content, callGUID, Connection);

            return result;
        }

        var contentresult = new ContentResult()
        {
            Content = $"User Created",
            ContentType = "text/plain",
            StatusCode = 200
        };

        await LoggingOperations.LogRequestToBlob("REGISTERUSER", "RESPONSE", contentresult.Content, callGUID, Connection);

        return contentresult;
    }


    [HttpGet]
    public IActionResult GoogleLogin(string authenticatedEmail)
    {
        string redirectUrl = Url.Action($"GoogleResponseId", "Account", new { testId = authenticatedEmail });
        var properties = _signInManager.ConfigureExternalAuthenticationProperties("Google", redirectUrl);
        return new ChallengeResult("Google", properties);
    }


    [HttpGet]
    public IActionResult GoogleLoginNewUser()
    {
        string redirectUrl = Url.Action("GoogleResponse", "Account");
        var properties = _signInManager.ConfigureExternalAuthenticationProperties("Google", redirectUrl);
        return new ChallengeResult("Google", properties);
    }

    [HttpGet]
    public async Task GoogleResponse()
    {
        ExternalLoginInfo info = await _signInManager.GetExternalLoginInfoAsync();
        if (info == null) { 
            var url = Callback + "://#";
            // Redirect to final url (back to the app)
            Request.HttpContext.Response.StatusCode = 401;
            Request.HttpContext.Response.Redirect(url);
        }

        var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false);
        string[] userInfo = { info.Principal.FindFirst(ClaimTypes.Name).Value, info.Principal.FindFirst(ClaimTypes.Email).Value };
        if (result.Succeeded)
        {
            var user = await _userManager.FindByLoginAsync(info.LoginProvider, info.ProviderKey);

            var authToken = GenerateJwtToken(user);
            var refreshToken = GenerateRefreshToken();

            _ = int.TryParse(_configuration["JWT-RefreshTokenValidityInDays"], out int refreshTokenValidityInDays);

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(refreshTokenValidityInDays);

            await _userManager.UpdateAsync(user);

            var qs = new Dictionary<string, string>
                {
                    { nameof(MobileUser.AuthorisedToken), authToken.token },
                    { nameof(MobileUser.RefreshToken),  refreshToken },
                    //{ nameof(MobileUser.RefreshTokenExpiryTime), authToken.expirySeconds.ToString() },
                    { nameof(MobileUser.AuthorisedEmail), user.Email },
                    { nameof(MobileUser.RowKey), user.RowKey },
                    { nameof(MobileUser.PartitionKey), user.PartitionKey },
                };

            // build url with previously calculated info to send back to app
            var url = Callback + "://#" + string.Join(
                "&",
                qs.Where(kvp => !string.IsNullOrEmpty(kvp.Value) && kvp.Value != "-1")
                .Select(kvp => $"{WebUtility.UrlEncode(kvp.Key)}={WebUtility.UrlEncode(kvp.Value)}"));

            // Redirect to final url (back to the app)
            Request.HttpContext.Response.Redirect(url);

        }

        else
        {
            APIUser user = new APIUser
            {
                Email = info.Principal.FindFirst(ClaimTypes.Email).Value,
                UserName = info.Principal.FindFirst(ClaimTypes.Email).Value,
                LastModified = DateTime.UtcNow,
                LastUploadDate = DateTime.UtcNow,
                NormalizedEmail = info.Principal.FindFirst(ClaimTypes.Email).Value.Normalize(),
            };

            IdentityResult identResult = await _userManager.CreateAsync(user);
            if (identResult.Succeeded)
            {
                identResult = await _userManager.AddLoginAsync(user, info);

                if (identResult.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    var authToken = GenerateJwtToken(user);
                    var refreshToken = GenerateRefreshToken();

                    _ = int.TryParse(_configuration["JWT-RefreshTokenValidityInDays"], out int refreshTokenValidityInDays);

                    user.RefreshToken = refreshToken;
                    user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(refreshTokenValidityInDays);
                    user.EmailConfirmed = true;
                    await _userManager.UpdateAsync(user);

                    var qs = new Dictionary<string, string>
                        {
                            { nameof(MobileUser.AuthorisedToken), authToken.token },
                            { nameof(MobileUser.RefreshToken),  refreshToken },
                            //{ nameof(MobileUser.RefreshTokenExpiryTime), authToken.expirySeconds.ToString() },
                            { nameof(MobileUser.AuthorisedEmail), user.Email },
                            { nameof(MobileUser.RowKey), user.RowKey },
                            { nameof(MobileUser.PartitionKey), user.PartitionKey },
                        };

                    /*var pUSer = new MobileUser()
                    {
                        AuthorisedToken = authToken.token,
                        RefreshToken = refreshToken,
                        //{ nameof(MobileUser.RefreshTokenExpiryTime), authToken.expirySeconds.ToString() },
                        AuthorisedEmail = user.Email,
                        RowKey = user.RowKey,
                        PartitionKey = user.PartitionKey,
                    };

                    var p = JsonConvert.SerializeObject(pUSer);*/

                    // build url with previously calculated info to send back to app
                    var url = Callback + "://#" + string.Join(
                        "&",
                        qs.Where(kvp => !string.IsNullOrEmpty(kvp.Value) && kvp.Value != "-1")
                        .Select(kvp => $"{WebUtility.UrlEncode(kvp.Key)}={WebUtility.UrlEncode(kvp.Value)}"));

                    // Redirect to final url (back to the app)
                    Request.HttpContext.Response.Redirect(url);
                }
            }
        }
    }

    [HttpGet]
    public async Task GoogleResponseId(string verifiedEmail)
    {
        ExternalLoginInfo info = await _signInManager.GetExternalLoginInfoAsync();
        if (info == null)
        {
            var url = Callback + "://#";
            Request.HttpContext.Response.StatusCode = 401;
            Request.HttpContext.Response.Redirect(url);
        }

        var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false);
        string[] userInfo = { info.Principal.FindFirst(ClaimTypes.Name).Value, info.Principal.FindFirst(ClaimTypes.Email).Value };
        if (result.Succeeded)
            if (info.Principal.FindFirst(ClaimTypes.Email).Value == verifiedEmail)
            {

                var user = await _userManager.FindByLoginAsync(info.LoginProvider, info.ProviderKey);
                var authToken = GenerateJwtToken(user);
                var refreshToken = GenerateRefreshToken();

                _ = int.TryParse(_configuration["JWT-RefreshTokenValidityInDays"], out int refreshTokenValidityInDays);

                user.RefreshToken = refreshToken;
                user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(refreshTokenValidityInDays);

                await _userManager.UpdateAsync(user);

                var qs = new Dictionary<string, string>
                {
                    { nameof(MobileUser.AuthorisedToken), authToken.token },
                    { nameof(MobileUser.RefreshToken),  refreshToken },
                    //{ nameof(MobileUser.RefreshTokenExpiryTime), authToken.expirySeconds.ToString() },
                    { nameof(MobileUser.AuthorisedEmail), user.Email },
                    { nameof(MobileUser.RowKey), user.RowKey },
                    { nameof(MobileUser.PartitionKey), user.PartitionKey },
                };

                // build url with previously calculated info to send back to app
                var url = Callback + "://#" + string.Join(
                    "&",
                    qs.Where(kvp => !string.IsNullOrEmpty(kvp.Value) && kvp.Value != "-1")
                    .Select(kvp => $"{WebUtility.UrlEncode(kvp.Key)}={WebUtility.UrlEncode(kvp.Value)}"));

                // Redirect to final url (back to the app)
                Request.HttpContext.Response.Redirect(url);

            }
            else
            {
                var url = Callback + "://#";
                Request.HttpContext.Response.StatusCode = 350;
                Request.HttpContext.Response.Redirect(url);

            }
        else
        {

            var url = Callback + "://#";
            Request.HttpContext.Response.StatusCode = 401;
            Request.HttpContext.Response.Redirect(url);
        }
    }


    [Authorize]
    [HttpGet]
    public IActionResult TestAuth()
    {
        return Ok("Success");
    }


    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [HttpGet]
    public IActionResult TestAuth1()
    {
        return Ok("Success");
    }
    
    [HttpGet]
    public IActionResult TestAuth12()
    {
        return Ok("Success");
    }


    [Authorize]
    [HttpGet]
    public async Task Signout()
    {
        await Request.HttpContext.SignOutAsync();
        await _signInManager.SignOutAsync();
    }


    private async Task<APIUser> CreateOrGetUser(string appUserEmail, string firstName, string surName)
    {
        //var userList = _userManager.Users.First();
        //var yes = _userManager.Users.First(x => x.NormalizedEmail == appUserEmail.ToUpper().Normalize());
        var user = await _userManager.FindByEmailAsync(appUserEmail);

        //var user2 = await _userManager.FindByNameAsync(firstName + "-" + surName);
        //var norm = appUserEmail.Normalize();
        if (user == null)
        {
            user = new APIUser
            {
                Email = appUserEmail,
                FirstName = firstName,
                SecondName = surName,
                LastModified = DateTime.UtcNow,
                LastUploadDate = DateTime.UtcNow

            };
            user.EmailConfirmed = true;

            //Create a username unique
            //user.UserName = CreateUniqueUserName($"{user.FirstName} {user.SecondName}");
            user.UserName = user.FirstName + "-" + user.SecondName;
            var result = await _userManager.CreateAsync(user);
        }

        await _signInManager.SignInAsync(user, true);

        return user;
    }
    string CreateUniqueUserName(string userName)
    {
        var uname = userName.Replace(' ', '-') + "-" + Convert.ToBase64String(Guid.NewGuid().ToByteArray());
        Regex rgx = new Regex("[^a-zA-Z0-9 -]");
        return rgx.Replace(uname, "");
    }

    private (string token, double expirySeconds) GenerateJwtToken(APIUser user)
    {
        var issuedAt = DateTimeOffset.UtcNow;

        //Learn more about JWT claims at: https://tools.ietf.org/html/rfc7519#section-4
        var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()), //Subject, should be unique in this scope
                new Claim(JwtRegisteredClaimNames.Iat, //Issued at, when the token is issued
                    issuedAt.ToUnixTimeMilliseconds().ToString(), ClaimValueTypes.Integer64),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), //Unique identifier for this specific token

                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.UserName),
            };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expires = issuedAt.AddMinutes(Convert.ToDouble(_configuration["JwtExpire"]));
        var expirySeconds = (long)TimeSpan.FromSeconds(Convert.ToDouble(_configuration["JwtExpire"])).TotalSeconds;

        var token = new JwtSecurityToken(
            _configuration["JwtIssuer"],
            _configuration["JwtIssuer"],
            claims,
            expires: expires.DateTime,
            signingCredentials: creds
        );

        return (new JwtSecurityTokenHandler().WriteToken(token), expirySeconds);
    }

    private ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token)
    {
        var tokenValidationParameters = new TokenValidationParameters
        {
            ValidateAudience = false,
            ValidateIssuer = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"])),
            ValidateLifetime = false
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
        if (securityToken is not JwtSecurityToken jwtSecurityToken || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            throw new SecurityTokenException("Invalid token");

        return principal;

    }

    private static string GenerateRefreshToken()
    {
        var randomNumber = new byte[64];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomNumber);
        return Convert.ToBase64String(randomNumber);
    }
}
