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

namespace TestAuthenticateAPI.Controllers;

//[Route("Account/[action]")]
[Route("mobileauth/[action]")]
[ApiController]
public class AccountController : PigToolBaseController
{
    const string Callback = "xamarinapp";
    private readonly SignInManager<AppUser> _signInManager;
    private readonly UserManager<AppUser> _userManager;
    private readonly IConfiguration _configuration;

    public AccountController(
        UserManager<AppUser> userManager,
        SignInManager<AppUser> signInManager,
        IConfiguration configuration
        ) : base(configuration)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _configuration = configuration;
    }

    [HttpGet("CreateUser")]
    public async Task SimpleAuth(string email, string givenName, string surName)
    {
            var appUser = new AppUser
            {
                Email = email,
                FirstName = givenName,
                SecondName = surName
            };

            await CreateOrGetUser(appUser);
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

            // Build the result url
            /*var url = Callback + "://#" + string.Join(
                "&",
                qs.Where(kvp => !string.IsNullOrEmpty(kvp.Value) && kvp.Value != "-1")
                .Select(kvp => $"{WebUtility.UrlEncode(kvp.Key)}={WebUtility.UrlEncode(kvp.Value)}"));

            // Redirect to final url
            Request.HttpContext.Response.Redirect(url);*/
        }



    [HttpGet("{scheme}")]
    public async Task MobileAuth([FromRoute] string scheme)
    {
        //NOTE: see https://docs.microsoft.com/en-us/xamarin/essentials/web-authenticator?tabs=android
        var auth = await Request.HttpContext.AuthenticateAsync(scheme);

        if (!auth.Succeeded
            || auth?.Principal == null
            || !auth.Principal.Identities.Any(id => id.IsAuthenticated)
            || string.IsNullOrEmpty(auth.Properties.GetTokenValue("access_token")))
        {
            // Not authenticated, challenge
            await Request.HttpContext.ChallengeAsync(scheme);
        }
        else
        {
            var claims = auth.Principal.Identities.FirstOrDefault()?.Claims;

            var email = string.Empty;
            email = claims?.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Email)?.Value;
            var givenName = claims?.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.GivenName)?.Value;
            var surName = claims?.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Surname)?.Value;
            var nameIdentifier = claims?.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            var appUser = new AppUser
            {
                Email = email,
                FirstName = givenName,
                SecondName = surName,
            };
                

            await CreateOrGetUser(appUser);
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

            // Build the result url
            var url = Callback + "://#" + string.Join(
                "&",
                qs.Where(kvp => !string.IsNullOrEmpty(kvp.Value) && kvp.Value != "-1")
                .Select(kvp => $"{WebUtility.UrlEncode(kvp.Key)}={WebUtility.UrlEncode(kvp.Value)}"));

            // Redirect to final url
            Request.HttpContext.Response.Redirect(url);
        }
    }

    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [HttpPost, Route(Constants.ROUTE_AUTH_REGISTERUSER)]
    public async Task<ActionResult> RegisterUser()
    {
        var callGUID = Guid.NewGuid().ToString();
        var Connection = GetStorageConnectionString();

        try
        {

            var requestJson = await Parse(Request);
            var unparsedRequest = requestJson.Body;
            var MobileUser = new UserInfo();
            var requeststring = Convert.ToString(unparsedRequest);


            

            //Log request
            await LoggingOperations.LogRequestToBlob("REGISTERUSER", "POST", requeststring, callGUID, Connection);


            //Get the user from the request
            MobileUser = JsonConvert.DeserializeObject<UserInfo>(requeststring);

            var logUser = await _userManager.FindByEmailAsync(MobileUser.AuthorisedEmail);

            if(logUser == null)
            {
                var contentresultFailed = new ContentResult()
                {
                    Content = $"User Not Found",
                    ContentType = "text/plain",
                    StatusCode = 300
                };

                await LoggingOperations.LogRequestToBlob("REGISTERUSER", "RESPONSE", contentresultFailed.Content, callGUID, Connection);

                return contentresultFailed;
            }

            logUser.updateUserFeilds(MobileUser);


            var updateResult  = await _userManager.UpdateAsync(logUser);

            //TODO need to check if user exists before creating....


            // var tableOperations = new TableOperations();
            var opertions = new TableOperations();

            var userlist = new List<UserInfo>();

            userlist.Add(MobileUser);

            var result = opertions.InsertTableEntities(userlist, Constants.TABLEUSERS, Connection);

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
            ContentType = "text/plain"
        };

        await LoggingOperations.LogRequestToBlob("REGISTERUSER", "RESPONSE", contentresult.Content, callGUID, Connection);

        return contentresult;
    }



    [Authorize]
    [HttpGet]
    public IActionResult TestAuth()
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


    private async Task CreateOrGetUser(AppUser appUser)
    {
        var user = await _userManager.FindByEmailAsync(appUser.Email);

        if (user == null)
        {
            //Create a username unique
            appUser.UserName = CreateUniqueUserName($"{appUser.FirstName} {appUser.SecondName}");
            var result = await _userManager.CreateAsync(appUser);
            user = appUser;
        }

        await _signInManager.SignInAsync(user, true);
    }
    string CreateUniqueUserName(string userName)
    {
        var uname = userName.Replace(' ', '-') + "-" + Convert.ToBase64String(Guid.NewGuid().ToByteArray());
        Regex rgx = new Regex("[^a-zA-Z0-9 -]");
        return rgx.Replace(uname, "");
    }

    private (string token, double expirySeconds) GenerateJwtToken(AppUser user)
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
                new Claim(ClaimTypes.Email, user.Email)
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
}
