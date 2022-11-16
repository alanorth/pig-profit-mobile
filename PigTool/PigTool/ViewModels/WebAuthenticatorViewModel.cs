using Azure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using PigTool;
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
    public class WebAuthenticatorViewModel
    {
        //const string authenticationUrl = "https://xamarin-essentials-auth-sample.azurewebsites.net/mobileauth/";
        //const string authenticationUrl = "https://pigprofittool.azurewebsites.net/mobileauth/";
        //const string authenticationUrl = "http://10.0.2.2:5272/Account/mobileauth/"; //for local testing purposes
        const string authenticationUrl = "http://10.0.2.2:5272/Account/SimpleAuthJSON/"; //for local testing purposes
        const string baseURL = "http://10.0.2.2:5272/Account/";
        INavigation navigation;
        public WebAuthenticatorViewModel(INavigation navigation)
        {
            GoogleCommand = new Command(async () => await OnAuthenticate("Google"));
            FacebookCommand = new Command(async () => await OnAuthenticate("Facebook"));
            this.navigation = navigation;
        }

        public ICommand MicrosoftCommand { get; }

        public ICommand GoogleCommand { get; }

        public ICommand FacebookCommand { get; }

        public ICommand AppleCommand { get; }

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
                        UserInfo use = JsonConvert.DeserializeObject<UserInfo>(responseString3);
                        await Application.Current.MainPage.Navigation.PushAsync(new AppShell());

                    }
                    else if (response.StatusCode.Equals(HttpStatusCode.NonAuthoritativeInformation))
                    {
                        await navigation.PushAsync(new RegistrationPage(r.AccessToken, email));
                    }
                    else
                    {
                        //something went wrong
                        await Application.Current.MainPage.DisplayAlert("Error", response.StatusCode.ToString(), "OK");
                    }


                    /*
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("https://pigprofittool.azurewebsites.net/");
                        client.DefaultRequestHeaders.Accept.Clear();

                        // New code:
                        HttpResponseMessage response2 = await client.GetAsync("api/data/GetUser?name=" + email);
                        if ((int)response2.StatusCode == 202)
                        {
                            var responseString3 = await response2.Content.ReadAsStringAsync();
                            UserInfo use = JsonConvert.DeserializeObject<UserInfo>(responseString3);
                            await Application.Current.MainPage.Navigation.PushAsync(new AppShell());

                        }
                        else if(response2.StatusCode.Equals(HttpStatusCode.NonAuthoritativeInformation))
                        {
                            await navigation.PushAsync(new RegistrationPage(r.AccessToken, email));
                        }
                        else
                        {
                            //something went wrong
                            await Application.Current.MainPage.DisplayAlert("Error", response2.StatusCode.ToString(), "OK");
                        }
                    }*/

                }

                //await navigation.PushAsync(new RegistrationPage(r.AccessToken, email));
                /*User.AuthorisedToken = r?.AccessToken;
                User.AuthorisedEmail = email;

                await repo.UpdateUserInfo(User);*/

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

                var httpClient = new HttpClient();

                var url = baseURL + "SimpleAuthJSON/Google";

                var response = await httpClient.GetAsync(url);

                var responseString = await response.Content.ReadAsStringAsync();

                httpClient.Dispose();

                UserInfo use = JsonConvert.DeserializeObject<UserInfo>(responseString);
                await Application.Current.MainPage.Navigation.PushAsync(new AppShell());

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed: {ex.Message}");

                AuthToken = string.Empty;
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed: {ex.Message}", "OK");
            }
        }

    }
}
