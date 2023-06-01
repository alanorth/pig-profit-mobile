using PigTool.Helpers;
using PigTool.Views;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PigTool.Services;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using PigTool.Models;
using System.Xml.Linq;
using PigTool.Views.Popups;
using Rg.Plugins.Popup.Services;

namespace PigTool.ViewModels.DataViewModels
{
    public class RegistrationViewModel : LoggedOutViewModel, INotifyPropertyChanged
    {
        bool isEditMode, isCreationMode;
        private bool editExistingMode, newUser;
        private string? userName;
        private string? name;
        private string? gender;
        private string? email;
        private string? phoneNumber;
        private string? district;
        private string? county;
        private string? subCounty;
        private string? parish;
        private string? village;
        private string? currency;
        private string? province;
        private string? commune;
        private string? sector;
        private string? cell;
        public string? accessToken;
        public string? registeredEmail;
        List<PickerToolHelper> genderListOfOptions;
        //List<PickerToolHelper> districtListOfOptions;
        //List<PickerToolHelper> countyListOfOptions;
        //List<PickerToolHelper> subCountyListOfOptions;
        List<PickerToolHelper> countryListOfOptions;
        List<PickerToolHelper> currencyListOfOptions;
        MobileUser _itemForEditing;

        UserLangSettings lang;
        string countryTranslationRowKey;

        //Button Clicks
        public Command SaveButtonClicked { get; }
        public Command ResetButtonClicked { get; }
        public Command DeleteButtonClicked { get; }
        public Command EditButtonClicked { get; }

        public Action<bool> ShowSuccess { get; set; }

        #region translations
        public string RegistrationTitleTranslation { get; set; }
        public string UserNameTranslation { get; set; }
        public string NameTranslation { get; set; }
        public string GenderTranslation { get; set; }
        public string EmailTranslation { get; set; }
        public string PhoneNumberTranslation { get; set; }
        public string DistrictTranslation { get; set; }
        public string CountyTranslation { get; set; }
        public string SubCountyTranslation { get; set; }
        public string CountryTranslation { get; set; }
        public string CurrencyTranslation { get; set; }
        public string ParishTranslation { get; set; }
        public string VillageTranslation { get; set; }
        public string ProvinceTranslation { get; set; }
        public string CommuneTranslation { get; set; }
        public string SectorTranslation { get; set; }
        public string CellTranslation { get; set; }

        public string SaveTranslation { get; set; }
        public string ResetTranslation { get; set; }
        public string EditTranslation { get; set; }
        public string DeleteTranslation { get; set; }

        public string PickerGenderTranslation { get; set; }
        //public string PickerDistrictTranslation { get; set; }
        //public string PickerCountyTranslation { get; set; }
        //public string PickerSubCountyTranslation { get; set; }
        public string PickerCountryTranslation { get; set; }
        public string PickerCurrencyTranslation { get; set; }
        public string SendingData { get; private set; }
        #endregion

        #region Registration item fields
        public string? Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string? UserName
        {
            get => userName;
            set
            {
                if (userName != value)
                {
                    userName = value;
                    OnPropertyChanged(nameof(UserName));
                }
            }
        }

        public string? Gender
        {
            get => gender;
            set
            {
                if (value != gender)
                {
                    gender = value;
                    OnPropertyChanged(nameof(Gender));
                }
            }
        }
        public string? Email
        {
            get => email;
            set
            {
                if (value != email)
                {
                    email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }
        public string? PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (value != phoneNumber)
                {
                    phoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }
        public string? District
        {
            get => district;
            set
            {
                if (value != district)
                {
                    district = value;
                    OnPropertyChanged(nameof(District));
                }
            }
        }
        public string? County
        {
            get => county;
            set
            {
                if (value != county)
                {
                    county = value;
                    OnPropertyChanged(nameof(County));
                }
            }
        }

        public string? SubCounty
        {
            get => subCounty;
            set
            {
                if (value != subCounty)
                {
                    subCounty = value;
                    OnPropertyChanged(nameof(SubCounty));
                }
            }
        }


        public string? Currency
        {
            get => currency;
            set
            {
                if (value != currency)
                {
                    currency = value;
                    OnPropertyChanged(nameof(Currency));
                }
            }
        }
        public string Parish
        {
            get => parish;
            set
            {
                if (value != parish)
                {
                    parish = value;
                    OnPropertyChanged(nameof(Parish));
                }
            }
        }

        public string Village
        {
            get => village;
            set
            {
                if (value != village)
                {
                    village = value;
                    OnPropertyChanged(nameof(Village));
                }
            }
        }

        public string? Province
        {
            get => province;
            set
            {
                if (value != province)
                {
                    province = value;
                    OnPropertyChanged(nameof(Province));
                }
            }
        }

        public string? Commune
        {
            get => commune;
            set
            {
                if (value != commune)
                {
                    commune = value;
                    OnPropertyChanged(nameof(Commune));
                }
            }
        }


        public string? Sector
        {
            get => sector;
            set
            {
                if (value != sector)
                {
                    sector = value;
                    OnPropertyChanged(nameof(Sector));
                }
            }
        }
        public string? Cell
        {
            get => cell;
            set
            {
                if (value != cell)
                {
                    cell = value;
                    OnPropertyChanged(nameof(Cell));
                }
            }
        }

        #endregion

        #region Dropdown Lists
        public List<PickerToolHelper> GenderListOfOptions
        {
            get { return genderListOfOptions; }
            set
            {
                genderListOfOptions = value;
                OnPropertyChanged(nameof(GenderListOfOptions));
            }
        }
        /*
        public List<PickerToolHelper> DistrictListOfOptions
        {
            get { return districtListOfOptions; }
            set
            {
                districtListOfOptions = value;
                OnPropertyChanged(nameof(DistrictListOfOptions));
            }
        }

        public List<PickerToolHelper> CountyListOfOptions
        {
            get { return countyListOfOptions; }
            set
            {
                countyListOfOptions = value;
                OnPropertyChanged(nameof(CountyListOfOptions));
            }
        }

        public List<PickerToolHelper> SubCountyListOfOptions
        {
            get { return subCountyListOfOptions; }
            set
            {
                subCountyListOfOptions = value;
                OnPropertyChanged(nameof(SubCountyListOfOptions));
            }
        }
        */
        public List<PickerToolHelper> CountryListOfOptions
        {
            get { return countryListOfOptions; }
            set
            {
                countryListOfOptions = value;
                OnPropertyChanged(nameof(CountryListOfOptions));
            }
        }

        public List<PickerToolHelper> CurrencyListOfOptions
        {
            get { return currencyListOfOptions; }
            set
            {
                currencyListOfOptions = value;
                OnPropertyChanged(nameof(CurrencyListOfOptions));
            }
        }

        // Selected

        private PickerToolHelper selectedGender;

        public PickerToolHelper SelectedGender
        {
            get { return selectedGender; }
            set
            {
                if (selectedGender != value)
                {
                    selectedGender = value;
                    OnPropertyChanged(nameof(SelectedGender));
                }
            }
        }
        /*
        private PickerToolHelper selectedDistrict;

        public PickerToolHelper SelectedDistrict
        {
            get { return selectedDistrict; }
            set
            {
                if (selectedDistrict != value)
                {
                    selectedDistrict = value;
                    OnPropertyChanged(nameof(SelectedDistrict));
                }
            }
        }

        private PickerToolHelper selectedCounty;

        public PickerToolHelper SelectedCounty
        {
            get { return selectedCounty; }
            set
            {
                if (selectedCounty != value)
                {
                    selectedCounty = value;
                    OnPropertyChanged(nameof(SelectedCounty));
                }
            }
        }

        private PickerToolHelper selectedSubCounty;

        public PickerToolHelper SelectedSubCounty
        {
            get { return selectedSubCounty; }
            set
            {
                if (selectedSubCounty != value)
                {
                    selectedSubCounty = value;
                    OnPropertyChanged(nameof(SelectedSubCounty));
                }
            }
        }
        */
        private PickerToolHelper selectedCountry;

        public PickerToolHelper SelectedCountry
        {
            get { return selectedCountry; }
            set
            {
                if (selectedCountry != value)
                {
                    selectedCountry = value;
                    OnPropertyChanged(nameof(SelectedCountry));
                }
            }
        }

        private PickerToolHelper selectedCurrency;

        /*public PickerToolHelper SelectedCurrency
        {
            get { return selectedCurrency; }
            set
            {
                if (selectedCurrency != value)
                {
                    selectedCurrency = value;
                    OnPropertyChanged(nameof(SelectedCurrency));
                }
            }
        }*/
        #endregion

        #region Hidden Fields

        #endregion

        public bool IsEditMode
        {

            get { return isEditMode; }
            set
            {
                if (value != isEditMode)
                {
                    isEditMode = value;
                    IsCreationMode = !value;
                    OnPropertyChanged(nameof(IsEditMode));
                }

            }
        }
        public bool IsCreationMode
        {

            get { return isCreationMode; }
            set
            {
                if (value != isCreationMode)
                {
                    isCreationMode = value;
                    OnPropertyChanged(nameof(IsCreationMode));
                }
            }
        }
        public bool EditExistingMode { get => editExistingMode; set { if (editExistingMode != value) { editExistingMode = value; OnPropertyChanged(nameof(EditExistingMode)); } } }
        public bool CreationMode { get; private set; }

        public RegistrationViewModel(UserLangSettings lang, string countryTranslationRowKey, bool newUser)
        {
            this.lang = lang;
            this.countryTranslationRowKey = countryTranslationRowKey;
            IsEditMode = true;
            CreationMode = newUser;
            this.newUser = newUser;

            SaveButtonClicked = new Command(SaveButtonCreateUser);
            ResetButtonClicked = new Command(ResetButtonPressed);
            DeleteButtonClicked = new Command(DeleteItem);
            EditButtonClicked = new Command(EditItem);

            RegistrationTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(RegistrationTitleTranslation), lang);
            NameTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(NameTranslation), lang) + " *";
            UserNameTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(UserNameTranslation), lang) + " *";
            GenderTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(GenderTranslation), lang);
            EmailTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EmailTranslation), lang);
            DistrictTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DistrictTranslation), lang);
            CountyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CountyTranslation), lang);
            SubCountyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SubCountyTranslation), lang);
            ProvinceTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ProvinceTranslation), lang);
            CommuneTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CommuneTranslation), lang);
            SectorTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SectorTranslation), lang);
            CellTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CellTranslation), lang);

            CurrencyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CurrencyTranslation), lang) + " *";

            PhoneNumberTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PhoneNumberTranslation), lang) + " *";
            DistrictTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DistrictTranslation), lang);
            ParishTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ParishTranslation), lang);
            VillageTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(VillageTranslation), lang);

            SaveTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SaveTranslation), lang);
            ResetTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ResetTranslation), lang);
            EditTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EditTranslation), lang);
            DeleteTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DeleteTranslation), lang);

            //PickerDistrictTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerDistrictTranslation), lang);
            PickerGenderTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerGenderTranslation), lang);
            //PickerCountyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerCountyTranslation), lang);
            //PickerSubCountyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerSubCountyTranslation), lang);
            PickerCountryTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerCountryTranslation), lang);
            PickerCurrencyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerCurrencyTranslation), lang);
            SendingData = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SendingData), lang);


        }

        public void populatewithData(MobileUser item)
        {
            _itemForEditing = item;

            UserName = item.UserName;
            Name = item.Name;
            Gender = item.Gender;
            Email = item.Email;
            PhoneNumber = item.PhoneNumber;
            District = item.District;
            County = item.County;
            SubCounty = item.SubCounty;
            Parish = item.Parish;
            Village = item.Village;
            //Currency = item.Currency;
            Province = item.Province;
            Commune = item.Commune;
            Sector = item.Sector;
            Cell = item.Cell;

            if(!string.IsNullOrWhiteSpace(Gender))
            {
               // SelectedGender = GenderListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.Gender).FirstOrDefault();
            }
        }

        public void SetPickers()
        {
            if (EditExistingMode || (IsEditMode && _itemForEditing != null && !string.IsNullOrEmpty(_itemForEditing.Gender)))
            {
                SelectedGender = GenderListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.Gender).FirstOrDefault();
            }
        }

        private async void SaveButtonCreateUser(object obj)
        {

            LoadingOverlay overlay = new LoadingOverlay(SendingData);
            await PopupNavigation.Instance.PushAsync(overlay);

            try
            {

                var valid = ValidateSave();

                if (!string.IsNullOrWhiteSpace(valid))
                {
                    await Application.Current.MainPage.DisplayAlert("Error", valid, "OK");
                    await PopupNavigation.Instance.PopAsync();
                    return;
                }


                if (_itemForEditing != null)
                {
                    _itemForEditing.UserName = UserName;
                    _itemForEditing.Name = Name;
                    _itemForEditing.PhoneNumber = PhoneNumber;
                    _itemForEditing.Gender = SelectedGender != null ? SelectedGender.TranslationRowKey : null;
                    _itemForEditing.Email = Email;
                    //_itemForEditing.District = SelectedDistrict != null ? SelectedDistrict.TranslationRowKey : null;
                    //_itemForEditing.County = SelectedCounty != null ? SelectedCounty.TranslationRowKey : null;
                    //_itemForEditing.SubCounty = SelectedSubCounty != null ? SelectedSubCounty.TranslationRowKey : null;
                    _itemForEditing.District = District;
                    _itemForEditing.County = County;
                    _itemForEditing.SubCounty = SubCounty;
                    _itemForEditing.Parish = Parish;
                    _itemForEditing.Village = Village;
                    //_itemForEditing.Currency = SelectedCurrency != null ? SelectedCurrency.TranslationRowKey : null;
                    _itemForEditing.Province = Province;
                    _itemForEditing.Commune = Commune;
                    _itemForEditing.Sector = Sector;
                    _itemForEditing.Cell = Cell;
                    _itemForEditing.LastModified = DateTime.UtcNow;
                    _itemForEditing.LastUploadDate = DateTime.UtcNow;
                    _itemForEditing.UserLang = lang;
                    _itemForEditing.Country = countryTranslationRowKey;
                    //_itemForEditing.Country = SelectedCountry != null ? SelectedCountry.TranslationRowKey : null;

                    if (newUser)
                    {
                        try
                        {
                            var rest = new RESTService(_itemForEditing);

                            HttpClientHandler handlert = GetInsecureHandler();
                            //var cli = new HttpClient(handlert);
                            //cli.DefaultRequestHeaders.Authorization =
                            //new AuthenticationHeaderValue("Bearer", _itemForEditing.AuthorisedToken);

                            //go save to database  
                            //maybe check to see if there are under data coverage
                            var MobileUser = await rest.ExecuteWithRetryAsync(async () =>
                            {
                                HttpClientHandler handler = GetInsecureHandler();
                                using (var client = new HttpClient(handler))
                                {
                                    client.DefaultRequestHeaders.Add("Authorization", $"bearer {_itemForEditing.AuthorisedToken}");
                                    var mobUser = JsonConvert.SerializeObject(_itemForEditing, new JsonSerializerSettings
                                    {
                                        DateTimeZoneHandling = DateTimeZoneHandling.Utc
                                    });
                                    var content = new StringContent(mobUser, Encoding.UTF8, "application/json");
                                    var responseMessage = await client.PostAsync("https://pigprofittool.azurewebsites.net/Account/RegisterMobileUser", content);

                                    var responseMessage21 = await client.GetAsync("https://pigprofittool.azurewebsites.net/Account/TestAuth");
                                    //_itemForEditing.SavedToDatabase = true; 
                                    responseMessage.EnsureSuccessStatusCode();

                                    var jsonResponse = await responseMessage.Content.ReadAsStringAsync();

                                    //var response = JsonConvert.DeserializeObject<MobileUser>(jsonResponse);

                                    return jsonResponse;


                                }
                            });

                            await repo.AddSingleUserInfo(_itemForEditing);



                            await Application.Current.MainPage.Navigation.PushAsync(new RegistrationSuccessfulPage());

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());
                        }


                    }
                    else
                    {
                        await repo.UpdateUserInfo(_itemForEditing);
                        //await Application.Current.MainPage.DisplayAlert("Upnamed", "Reproduction record has been updated", "OK");

                        //await Shell.Current.Navigation.PopAsync();
                        Application.Current.MainPage = new AppShell();
                    }

                }
                else
                {
                    var newUserInfo = new MobileUser
                    {
                        UserName = UserName,
                        Name = Name,
                        PhoneNumber = PhoneNumber,
                        Gender = SelectedGender != null ? SelectedGender.TranslationRowKey : null,
                        Email = Email,
                        //District = SelectedDistrict != null ? SelectedDistrict.TranslationRowKey : null,
                        //County = SelectedCounty != null ? SelectedCounty.TranslationRowKey : null,
                        //SubCounty = SelectedSubCounty != null ? SelectedSubCounty.TranslationRowKey : null,
                        District = District,
                        County = County,
                        SubCounty = SubCounty,
                        Parish = Parish,
                        Village = Village,
                        //Currency = SelectedCurrency != null ? SelectedCurrency.TranslationRowKey : null,
                        Province = Province,
                        Commune = Commune,
                        Sector = Sector,
                        Cell = Cell,
                        LastModified = DateTime.UtcNow,
                        LastUploadDate = DateTime.UtcNow,
                        PartitionKey = Constants.PartitionKeyUserInfo,
                        UserLang = lang,
                        Timestamp = DateTime.UtcNow,
                        RowKey = registeredEmail,
                        AuthorisedEmail = registeredEmail,
                        AuthorisedToken = accessToken,
                        Country = countryTranslationRowKey
                    };


                    //await Shell.Current.GoToAsync(nameof(RegistrationSuccessfulPage));
                    try
                    {
                        await repo.AddSingleUserInfo(newUserInfo);
                        await Application.Current.MainPage.Navigation.PushAsync(new RegistrationSuccessfulPage());



                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                await PopupNavigation.Instance.PopAsync();
            }
            await PopupNavigation.Instance.PopAsync();
        }

        private async void DeleteItem(object obj)
        {
            if (EditExistingMode)
            {
                var confirmDelete = await Application.Current.MainPage.DisplayAlert("Deletion Confirmation", "Are you sure you want to delete this item", "OK", "Cancel");
                if (confirmDelete)
                {
                    repo.DeleteUserInfo(_itemForEditing);
                    await Shell.Current.Navigation.PopAsync();
                }
            }
        }

        private async void EditItem(object obj)
        {
            IsEditMode = !IsEditMode;
        }

        private async void ResetButtonPressed(object obj)
        {
            ClearFormVariables();
        }

        private void ClearFormVariables()
        {
            UserName = null;
            Name = null;
            PhoneNumber = null;
            SelectedGender = null;
            Email = null;
            //SelectedDistrict = null;
            //SelectedCounty = null;
            //SelectedSubCounty = null;
            District = null;
            County = null;
            SubCounty = null;
            Parish = null;
            Village = null;
            //SelectedCurrency = null;
            Province = null;
            Commune = null;
            Sector = null;
            Cell = null;
        }

        public async Task PopulateDataDowns()
        {
            var GenderControlData = await repo.GetControlData(Constants.GENDERTYPE);
            var DistrictControlData = await repo.GetControlData(Constants.DISTRICTTYPE);
            var CountyControlData = await repo.GetControlData(Constants.COUNTYTYPE);
            var SubCountyControlData = await repo.GetControlData(Constants.SUBCOUNTYTYPE);

            var CurrencyControlData = await repo.GetControlData(Constants.CURRENCYTYPE);

            GenderListOfOptions = LogicHelper.CreatePickerToolOption(GenderControlData, lang);
            //DistrictListOfOptions = LogicHelper.CreatePickerToolOption(DistrictControlData, lang);
            //CountyListOfOptions = LogicHelper.CreatePickerToolOption(CountyControlData, lang);
            //SubCountyListOfOptions = LogicHelper.CreatePickerToolOption(SubCountyControlData, lang);

            CurrencyListOfOptions = LogicHelper.CreatePickerToolOption(CurrencyControlData, lang);
        }

        private string ValidateSave()
        {
            try
            {
                StringBuilder returnString = new StringBuilder();
                if (UserName == null) returnString.AppendLine("UserName Not provided");
                if (Name == null) returnString.AppendLine("Name Not provided");
                if (PhoneNumber == null) returnString.AppendLine("Phone Number Not Provided");
                //if (SelectedCurrency == null) returnString.AppendLine("Currency Not Provided");

                return returnString.ToString();
            }
            catch (Exception ex)
            {
                return "";
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
