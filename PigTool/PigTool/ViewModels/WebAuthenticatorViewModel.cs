using Azure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using PigTool;
using PigTool.Helpers;
using PigTool.ViewModels;
using PigTool.Views;
using Shared;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Samples.ViewModel
{
    public class WebAuthenticatorViewModel : LoggedOutViewModel
    {
        //const string authenticationUrl = "https://xamarin-essentials-auth-sample.azurewebsites.net/mobileauth/";
        //const string authenticationUrl = "https://pigprofittool.azurewebsites.net/mobileauth/";
        //const string authenticationUrl = "http://10.0.2.2:5272/Account/mobileauth/"; //for local testing purposes
        const string authenticationUrl = "http://10.0.2.2:5272/Account/SimpleAuthJSON/"; //for local testing purposes
        const string baseURL = "http://10.0.2.2:5272/Account/";
        INavigation navigation;
        UserLangSettings lang;
        string countryTranslationRowKey;

        public string WebAuthTitleTranslation { get; set; }
        public string WebAuthDescTranslation { get; set; }
        public string GoogleSignUpTranslation { get; set; }


        public WebAuthenticatorViewModel(INavigation navigation, UserLangSettings lang, string countryTranslationRowKey)
        {
            GoogleCommand = new Command(async () => await OnAuthenticateTest("Google"));
            this.navigation = navigation;
            this.lang = lang;
            this.countryTranslationRowKey = countryTranslationRowKey;
            WebAuthTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(WebAuthTitleTranslation), lang);
            WebAuthDescTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(WebAuthDescTranslation), lang);
            GoogleSignUpTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(GoogleSignUpTranslation), lang);
        }

        public ICommand GoogleCommand { get; }

        string accessToken = string.Empty;

        public string AuthToken
        {
            get => accessToken;
            set { accessToken = value; }
        }

        async Task OnAuthenticate(string scheme)
        {
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
                    var authUrl = new Uri(authenticationUrl + scheme);
                    var callbackUrl = new Uri("pigprofittool://");
                    //var callbackUrl = new Uri("xamarinessentials://");

                    r = await WebAuthenticator.AuthenticateAsync(authUrl, callbackUrl);
                }

                AuthToken = string.Empty;
                if (r.Properties.TryGetValue("name", out var name) && !string.IsNullOrEmpty(name))
                    AuthToken += $"Name: {name}{Environment.NewLine}";
                if (r.Properties.TryGetValue("email", out var email) && !string.IsNullOrEmpty(email))
                    AuthToken += $"Email: {email}{Environment.NewLine}";
                AuthToken += r?.AccessToken ?? r?.IdToken;


                /*
                 * { "access_token", auth.Properties.GetTokenValue("access_token") },
                    { "refresh_token", auth.Properties.GetTokenValue("refresh_token") ?? string.Empty },
                    { "expires", (auth.Properties.ExpiresUtc?.ToUnixTimeSeconds() ?? -1).ToString() },
                    { "email", email }
                 */

                //get user if,  null  create, otherwise  proceed.

                if (r?.AccessToken != null)
                {
                    var httpClient = new HttpClient();

                    //httpClient.DefaultRequestHeaders.Add("XApiKey", "ENTER YOUR API KEY HERE");
                    //httpClient.DefaultRequestHeaders.Authorization =
                    //new AuthenticationHeaderValue("Google", User.AuthorisedToken);
                    var url = baseURL + "TestAuth";

                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", r.AccessToken);

                    var response = await httpClient.GetAsync(url);
                    //var response = await httpClient.GetAsync(url);
                    var responseString = await response.Content.ReadAsStringAsync();

                    httpClient.Dispose();

                    if ((int)response.StatusCode == 202)
                    {
                        var responseString3 = await response.Content.ReadAsStringAsync();
                        MobileUser use = JsonConvert.DeserializeObject<MobileUser>(responseString3);
                        await Application.Current.MainPage.Navigation.PushAsync(new AppShell());

                    }
                    else if (response.StatusCode.Equals(HttpStatusCode.NonAuthoritativeInformation))
                    {
                        await navigation.PushAsync(new RegistrationPage(r.AccessToken, email, lang, countryTranslationRowKey));
                    }
                    else
                    {
                        //something went wrong
                        await Application.Current.MainPage.DisplayAlert("Error", response.StatusCode.ToString(), "OK");
                    }

                }

            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Login cancelled.");

                AuthToken = string.Empty;
                await Application.Current.MainPage.DisplayAlert("Error", "Login cancelled.", "OK");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed: {ex.Message}");

                AuthToken = string.Empty;
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed: {ex.Message}", "OK");
            }
        }


        async Task OnAuthenticateTest(string scheme)
        {
            try
            {
                HttpClientHandler insecureHandler = GetInsecureHandler();
                var httpClient = new HttpClient(insecureHandler);

                var url = baseURL + "SimpleAuthJSON";

                var response = await httpClient.GetAsync(url);

                var responseString = await response.Content.ReadAsStringAsync();

                httpClient.Dispose();

                MobileUser use = JsonConvert.DeserializeObject<MobileUser>(responseString);
                //await Application.Current.MainPage.Navigation.PushAsync(new RegistrationPage(use, true));

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed: {ex.Message}");

                AuthToken = string.Empty;
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed: {ex.Message}", "OK");
            }
        }


        public HttpClientHandler GetInsecureHandler()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                if (cert.Issuer.Equals("CN=localhost"))
                    return true;
                return errors == System.Net.Security.SslPolicyErrors.None;
            };
            return handler;
        }

    }


}
