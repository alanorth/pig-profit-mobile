using Newtonsoft.Json;
using PigTool;
using PigTool.Helpers;
using PigTool.ViewModels;
using PigTool.Views;
using PigTool.Views.Popups;
using Rg.Plugins.Popup.Services;
using Shared;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Samples.ViewModel
{
    public class WebAuthenticatorViewModel : LoggedOutViewModel
    {
        //const string authenticationUrl = "https://xamarin-essentials-auth-sample.azurewebsites.net/mobileauth/";
        const string authenticationUrl = "https://pigprofittool.azurewebsites.net/mobileauth/";
        INavigation navigation;
        UserLangSettings lang;
        string countryTranslationRowKey;

        public string WebAuthTitleTranslation { get; set; }
        public string WebAuthDescTranslation { get; set; }
        public string GoogleSignUpTranslation { get; set; }


        public WebAuthenticatorViewModel(INavigation navigation, UserLangSettings lang, string countryTranslationRowKey)
        {
            GoogleCommand = new Command(async () => await OnAuthenticate("Google"));
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

            // Display Overlay for sending data
            LoadingOverlay overlay = new LoadingOverlay("Please Wait");
            await PopupNavigation.Instance.PushAsync(overlay);
            //await Task.Delay(5000);

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

                foreach (var pro in r.Properties)
                {
                    Console.WriteLine(pro.Key);
                    Console.WriteLine(pro.Value);
                }

                //get user if,  null  create, otherwise  proceed.

                if (r?.AccessToken != null)
                {
                    var httpClient = new HttpClient();

                    //httpClient.DefaultRequestHeaders.Add("XApiKey", "ENTER YOUR API KEY HERE");
                    //httpClient.DefaultRequestHeaders.Authorization =
                    //new AuthenticationHeaderValue("Google", User.AuthorisedToken);
                    var url = "https://pigprofittool.azurewebsites.net/api/data/GetUser?name=" + email;
                    var response1 = await httpClient.GetAsync("https://pigprofittool.azurewebsites.net/api/storage");

                    var response = await httpClient.GetAsync(url);
                    //var response = await httpClient.GetAsync(url);
                    var responseString = await response.Content.ReadAsStringAsync();

                    httpClient.Dispose();



                    // Remove Overlay
                    await PopupNavigation.Instance.PopAsync();




                    if ((int)response.StatusCode == 202)
                    {
                        var responseString3 = await response.Content.ReadAsStringAsync();
                        UserInfo use = JsonConvert.DeserializeObject<UserInfo>(responseString3);
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
                // Remove Overlay
                await PopupNavigation.Instance.PopAsync();

                Console.WriteLine("Login cancelled.");

                AuthToken = string.Empty;
                await Application.Current.MainPage.DisplayAlert("Error", "Login cancelled.", "OK");
            }
            catch (Exception ex)
            {
                // Remove Overlay
                await PopupNavigation.Instance.PopAsync();

                Console.WriteLine($"Failed: {ex.Message}");

                AuthToken = string.Empty;
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed: {ex.Message}", "OK");
            }
        }
    }
}
