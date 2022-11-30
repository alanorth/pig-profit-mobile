using Azure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PigTool;
using PigTool.Helpers;
using PigTool.Models;
using PigTool.Services;
using PigTool.ViewModels;
using PigTool.Views;
using Shared;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using static System.Net.WebRequestMethods;

namespace Samples.ViewModel
{
    public class WebAuthenticatorViewModel : LoggedOutViewModel
    {
        //const string authenticationUrl = "https://xamarin-essentials-auth-sample.azurewebsites.net/mobileauth/";
        //const string authenticationUrl = "https://pigprofittool.azurewebsites.net/mobileauth/";
        //const string authenticationUrl = "http://10.0.2.2:5272/Account/mobileauth/"; //for local testing purposes
        const string authenticationUrl = "http://10.0.2.2:5272/Account/SimpleAuthJSON/"; //for local testing purposes
        const string baseURL = "http://10.0.2.2:5272/Account/";
        //const string baseURL = "https://pigprofittool.azurewebsites.net/Account/";
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
            try
            {
                RESTService rest = new RESTService();

                var mobileAuth = await rest.OnAuthenticate(scheme);

                if (mobileAuth != null && mobileAuth.SuccesfulResponse)
                {

                    mobileAuth.ResultProperties.TryGetValue(nameof(MobileUser.AuthorisedToken), out var token);
                    mobileAuth.ResultProperties.TryGetValue(nameof(MobileUser.RefreshToken), out var reToken);
                    mobileAuth.ResultProperties.TryGetValue(nameof(MobileUser.AuthorisedEmail), out var authEmail);
                    mobileAuth.ResultProperties.TryGetValue(nameof(MobileUser.Name), out var name);
                    mobileAuth.ResultProperties.TryGetValue(nameof(MobileUser.RowKey), out var rowKey);
                    mobileAuth.ResultProperties.TryGetValue(nameof(MobileUser.PartitionKey), out var partitionKey);

                    var mobileUser = new MobileUser();
                    mobileUser.AuthorisedEmail = authEmail;
                    mobileUser.UserName = WebUtility.UrlDecode(authEmail);
                    mobileUser.AuthorisedToken = token;
                    mobileUser.RefreshToken = reToken;
                    mobileUser.Name = name;
                    mobileUser.RowKey = rowKey;
                    mobileUser.PartitionKey = partitionKey;

                    await Application.Current.MainPage.Navigation.PushAsync(new RegistrationPage(mobileUser, lang, countryTranslationRowKey));
                }
                else
                {
                    if (mobileAuth != null)
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", mobileAuth.FailMessage, "OK");
                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", "Google Auth Failed", "OK");
                    }

                }

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
            HttpClientHandler insecureHandler = GetInsecureHandler();
            var httpClient = new HttpClient(insecureHandler);

            try
            {


                //var url = baseURL + "SimpleAuthJSON";

                //var url = "https://pigprofittool.azurewebsites.net/Account/SimpleAuthJSON";
                var url = "http://10.0.2.2:5272/Account/SimpleAuthJSON";

                var response = await httpClient.GetAsync(url);

                var responseString = await response.Content.ReadAsStringAsync();



                MobileUser use = JsonConvert.DeserializeObject<MobileUser>(responseString);
                //await Application.Current.MainPage.Navigation.PushAsync(new RegistrationPage(use, true));

                dynamic jsonObject = new JObject();
                jsonObject.access_token = use.AuthorisedToken;
                jsonObject.refresh_token = use.RefreshToken;

                var tokenObject = JsonConvert.SerializeObject(jsonObject);

                var content = new StringContent(tokenObject, Encoding.UTF8, "application/json");
                var responseMessage = await httpClient.PostAsync(baseURL + "RefreshToken", content);

                if (responseMessage.IsSuccessStatusCode)
                {
                    var stringResponse = await responseMessage.Content.ReadAsStringAsync();
                    var authResponse = JsonConvert.DeserializeObject<AuthResponse>(stringResponse);

                    if (authResponse != null && authResponse.Success)
                    {
                        use.AuthorisedToken = authResponse.BearerToken;
                        use.RefreshToken = authResponse.RefreshToken;
                        await Application.Current.MainPage.DisplayAlert("Error", $"We Succeed In Refresfing The Token", "OK");
                    }

                }
                else
                {
                }

                httpClient.Dispose();
                await Application.Current.MainPage.Navigation.PushAsync(new RegistrationPage(use, lang, countryTranslationRowKey));

                


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed: {ex.Message}");
                httpClient.Dispose();
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
