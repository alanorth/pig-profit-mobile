using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PigTool.Models;
using PigTool.Views;
using Shared;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace PigTool.Services
{

    /// <summary>
    /// Responsible for handle Restful calls based on JWT and Refresh-tokens.
    /// </summary>
    public class RESTService : IRESTService
    {
        private MobileUser user;
        const string baseURL = "https://pigprofittool.azurewebsites.net/Account/";

        public RESTService(MobileUser user)
        {
            this.user = user;
            Preferences.Set(bearerToken, user.AuthorisedToken);
            Preferences.Set(refreshToken, user.RefreshToken);
        }

        public RESTService()
        {
        }


        string bearerToken = "BearerToken";
        string refreshToken = "RefreshToken";
        private HttpClient client = new HttpClient();

        private static int _refreshTokenEntered = 0;
        public string BearerToken => Preferences.Get(bearerToken, string.Empty);
        public string RefreshToken => Preferences.Get(refreshToken, string.Empty);

        //private const string REFRESH_TOKEN_URL = "https://localhost:47629/auth/refreshtoken";
        //private const string AUTH_URL = "https://localhost:47629/auth";



        /// <summary>
        /// Attempts to execute  <paramref name="webApiCallMethod"/> and return its results.
        /// Case the <see cref="BearerToken"/> provided in <paramref name="webApiCallMethod"/> is expired,
        /// attempts to renew it by using the current Refresh-Token, and after that runs the method <paramref name="webApiCallMethod"/> again.
        /// </summary>
        /// <typeparam name="TResponse">The expected response object</typeparam>
        /// <param name="webApiCallMethod">task which contains an httpclient call using the current <see cref="BearerToken"/>.</param>
        /// <returns></returns>
        public async Task<TResponse> ExecuteWithRetryAsync<TResponse>(Func<Task<TResponse>> webApiCallMethod)
        {
            var tryForceRefreshToken = false;
            var attemptsCounter = 1;
            while (true)
            {
                if (tryForceRefreshToken)
                {
                    var success = await TryAuthWithRefreshTokenAsync();
                    //try force sigin via google to authenticate
                    if (!success)
                    {
                        var diction = await OnAuthenticate("Google");
                    }
                }
                try
                {
                    attemptsCounter++;

                    var response = await webApiCallMethod.Invoke();
                    return response;
                }
                catch (HttpRequestException)
                {
                    if (attemptsCounter > 2)
                    {
                        throw;
                    }
                    tryForceRefreshToken = true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public async Task<AuthResponse> AuthWithCredentialsAsync(string username, string password)
        {
            dynamic jsonObject = new JObject();
            jsonObject.access_token = user.AuthorisedToken;
            jsonObject.refresh_token = user.RefreshToken;

            var tokenObject = JsonConvert.SerializeObject(jsonObject);

            var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("AUTH_URL", content);

            if (responseMessage.IsSuccessStatusCode)
            {
                var stringResponse = await responseMessage.Content.ReadAsStringAsync();
                var authResponse = JsonConvert.DeserializeObject<AuthResponse>(stringResponse);

                Preferences.Set(bearerToken, authResponse.BearerToken);
                Preferences.Set(refreshToken, authResponse.RefreshToken);

                return authResponse;
            }
            else
            {
               return new AuthResponse();
               
            }
        }


        private async Task<bool> TryAuthWithRefreshTokenAsync()
        {
            try
            {
                //Try to execute for refreshtoken as soon as the first thread that requested it...
                // For the other threads, make sure they wait for the renewal of the token.
                if (Interlocked.CompareExchange(ref _refreshTokenEntered, 1, 0) == 0)
                {

                    Console.WriteLine("Refresh Token Renewing...");
                    //tenta renovar
                    var authResponse = await AuthWithRefreshTokenAsync();

                    Interlocked.Exchange(ref _refreshTokenEntered, 0);
                    Console.WriteLine("Refresh Token Renewed");
                    return authResponse;
                }
                else
                {
                    Console.WriteLine("Refresh Token Renewal is Waiting...");

                    while (_refreshTokenEntered == 1)
                    {
                        await Task.Delay(100);
                    }
                    Console.WriteLine("Refresh Token Renewal done!");
                    return true;
                }
            }

            catch (Exception)
            {
                Interlocked.Exchange(ref _refreshTokenEntered, 0);
                throw;
            }

        }

        private async Task<bool> AuthWithRefreshTokenAsync()
        {
            dynamic jsonObject = new JObject();
            jsonObject.access_token = user.AuthorisedToken;
            jsonObject.refresh_token = user.RefreshToken;

            var tokenObject = JsonConvert.SerializeObject(jsonObject);

            var content = new StringContent(tokenObject, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync(baseURL + "RefreshToken", content);

            if (responseMessage.IsSuccessStatusCode)
            {
                var stringResponse = await responseMessage.Content.ReadAsStringAsync();
                var authResponse = JsonConvert.DeserializeObject<AuthResponse>(stringResponse);

                if (authResponse != null && authResponse.Success)
                {
                    user.AuthorisedToken = authResponse.BearerToken;
                    user.RefreshToken = authResponse.RefreshToken;
                }

                Preferences.Set(bearerToken, authResponse.BearerToken);
                Preferences.Set(refreshToken, authResponse.RefreshToken);

                return true;
            }
            else
            {
                return false;
            }

        }

        public async Task<MobileAuthModelData>OnAuthenticate(string scheme)
        {
            var authRepsponse = new MobileAuthModelData();
            authRepsponse.SuccesfulResponse = false;

            try
            {
                WebAuthenticatorResult r = null;

                if (scheme.Equals("Apple")
                    && DeviceInfo.Platform == DevicePlatform.iOS
                    && DeviceInfo.Version.Major >= 13)
                {
                    // Make sure to enable Apple Sign In in both the
                    // entitlements and the provisioning profile.
                    var options = new AppleSignInAuthenticator.Options
                    {
                        IncludeEmailScope = true,
                        IncludeFullNameScope = true,
                    };
                    r = await AppleSignInAuthenticator.AuthenticateAsync(options);
                }
                else
                {
                    //var authUrl = new Uri("http://10.0.2.2:5272/Account/mobileauth/" + scheme);
                    var authUrl = new Uri("https://pigprofittool.azurewebsites.net/Account/GoogleLoginNewUser");
                    var callbackUrl = new Uri("pigprofittool://");

                    r = await WebAuthenticator.AuthenticateAsync(authUrl, callbackUrl);
                }

                /*var AuthToken = string.Empty;
                if (r.Properties.TryGetValue(nameof(MobileUser.Name), out var name) && !string.IsNullOrEmpty(name))
                    AuthToken += $"Name: {name}{Environment.NewLine}";
                if (r.Properties.TryGetValue("email", out var email) && !string.IsNullOrEmpty(email))
                    AuthToken += $"Email: {email}{Environment.NewLine}";
                AuthToken += r?.AccessToken ?? r?.IdToken;*/

                
                authRepsponse.SuccesfulResponse = true;
                authRepsponse.ResultProperties = r.Properties;

                return authRepsponse;
                /*var qs = new Dictionary<string, string>
                {
                    { nameof(MobileUser.AuthorisedToken), authToken.token },
                    { nameof(MobileUser.RefreshToken),  refreshToken },
                    //{ nameof(MobileUser.RefreshTokenExpiryTime), authToken.expirySeconds.ToString() },
                    { nameof(MobileUser.AuthorisedEmail), email },
                    { nameof(MobileUser.Name), givenName },
                    { nameof(MobileUser.RowKey), appUser.RowKey },
                    { nameof(MobileUser.PartitionKey), appUser.PartitionKey },
                };*/

               

            }
            catch (OperationCanceledException)
            {
                authRepsponse.FailMessage = "Login cancelled.";

                return authRepsponse;
            }
            catch (Exception ex)
            {
                authRepsponse.FailMessage = ex.Message;

                return authRepsponse;
            }
        }

    }

}
