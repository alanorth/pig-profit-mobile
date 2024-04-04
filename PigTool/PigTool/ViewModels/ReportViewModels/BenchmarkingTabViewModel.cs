using Newtonsoft.Json;
using PigTool.Helpers;
using PigTool.Services;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace PigTool.ViewModels.ReportViewModels
{
    public class BenchmarkingTabViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        private bool _displayLoading;

        public bool DisplayLoading
        {
            get { return _displayLoading; }
            set
            {
                if (_displayLoading != value)
                {
                    _displayLoading = value;
                    OnPropertyChanged(nameof(DisplayLoading));
                }
            }
        }

        public string BenchmarkingTabLable { get; set; }

        public BenchmarkingTabViewModel()
        {
            BenchmarkingTabLable = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(BenchmarkingTabLable), User.UserLang);
            var rest = new RESTService(User);
        }

        public async Task<string> RefreshStroageConnectonString()
        {
            var rest = new RESTService(User);
            var details = await rest.ExecuteWithRetryAsync(async () =>
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"bearer {User.AuthorisedToken}");
                    var responseMessage = await client.GetAsync(Constants.ROUTE_CONNECTIONSRING);
                    responseMessage.EnsureSuccessStatusCode();

                    var jsonResponse = await responseMessage.Content.ReadAsStringAsync();

                    //var response = JsonConvert.DeserializeObject<MobileUser>(jsonResponse);
                    return jsonResponse;
                }
            });

            //store the details in xamarin essentials secure storage
            await SecureStorage.SetAsync("BlobStorageConnectionString", details);
            return details;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
