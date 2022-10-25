﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PigTool.Helpers;
using Shared;
using PigTool.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PigTool.Services;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net;

namespace PigTool.ViewModels.DataViewModels
{
    public class RegistrationViewModel : LoggedOutViewModel, INotifyPropertyChanged
    {
        bool isEditMode, isCreationMode;
        private bool editExistingMode;
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
        private string? country;
        private string? currency;
        public string? accessToken;
        public string? registeredEmail;
        List<PickerToolHelper> genderListOfOptions;
        List<PickerToolHelper> districtListOfOptions;
        List<PickerToolHelper> countyListOfOptions;
        List<PickerToolHelper> subCountyListOfOptions;
        List<PickerToolHelper> countryListOfOptions;
        List<PickerToolHelper> currencyListOfOptions;
        UserInfo _itemForEditing;

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

        public string SaveTranslation { get; set; }
        public string ResetTranslation { get; set; }
        public string EditTranslation { get; set; }
        public string DeleteTranslation { get; set; }

        public string PickerGenderTranslation { get; set; }
        public string PickerDistrictTranslation { get; set; }
        public string PickerCountyTranslation { get; set; }
        public string PickerSubCountyTranslation { get; set; }
        public string PickerCountryTranslation { get; set; }
        public string PickerCurrencyTranslation { get; set; }
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

        public string? Country
        {
            get => country;
            set
            {
                if (value != country)
                {
                    country = value;
                    OnPropertyChanged(nameof(Country));
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

        public PickerToolHelper SelectedCurrency
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
        }
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

        public RegistrationViewModel()
        {
            IsEditMode = true;
            CreationMode = true;

            SaveButtonClicked = new Command(SaveButtonCreateHousingItem);
            ResetButtonClicked = new Command(ResetButtonPressed);
            DeleteButtonClicked = new Command(DeleteItem);
            EditButtonClicked = new Command(EditItem);
            IsEditMode = true;
            IsCreationMode = !EditExistingMode;

            RegistrationTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(RegistrationTitleTranslation), UserLangSettings.Eng);
            NameTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(NameTranslation), UserLangSettings.Eng) + " *";
            UserNameTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(UserNameTranslation), UserLangSettings.Eng) + " *";
            GenderTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(GenderTranslation), UserLangSettings.Eng);
            EmailTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EmailTranslation), UserLangSettings.Eng);
            DistrictTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DistrictTranslation), UserLangSettings.Eng);
            CountyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CountyTranslation), UserLangSettings.Eng);
            SubCountyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SubCountyTranslation), UserLangSettings.Eng);
            CountryTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CountryTranslation), UserLangSettings.Eng) + " *";
            CurrencyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CurrencyTranslation), UserLangSettings.Eng) + " *";

            PhoneNumberTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PhoneNumberTranslation), UserLangSettings.Eng) + " *";
            DistrictTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DistrictTranslation), UserLangSettings.Eng);
            ParishTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ParishTranslation), UserLangSettings.Eng);
            VillageTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(VillageTranslation), UserLangSettings.Eng);

            SaveTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SaveTranslation), UserLangSettings.Eng);
            ResetTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ResetTranslation), UserLangSettings.Eng);
            EditTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EditTranslation), UserLangSettings.Eng);
            DeleteTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DeleteTranslation), UserLangSettings.Eng);

            PickerDistrictTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerDistrictTranslation), UserLangSettings.Eng);
            PickerGenderTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerGenderTranslation), UserLangSettings.Eng);
            PickerCountyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerCountyTranslation), UserLangSettings.Eng);
            PickerSubCountyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerSubCountyTranslation), UserLangSettings.Eng);
            PickerCountryTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerCountryTranslation), UserLangSettings.Eng);
            PickerCurrencyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerCurrencyTranslation), UserLangSettings.Eng);
        }

        public void populatewithData(UserInfo item)
        {
            isEditMode = false;
            CreationMode = false;
            EditExistingMode = !CreationMode;

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
            Country = item.Country;
            Currency = item.Currency;
        }

        public void SetPickers()
        {
            if (EditExistingMode)
            {
                SelectedGender = GenderListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.Gender).FirstOrDefault();
                SelectedDistrict = DistrictListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.District).FirstOrDefault();
                SelectedCounty = CountyListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.County).FirstOrDefault();
                SelectedSubCounty = SubCountyListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.SubCounty).FirstOrDefault();
                SelectedCountry = CountryListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.Country).FirstOrDefault();
                SelectedCurrency = CurrencyListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.Currency).FirstOrDefault();
            }
        }

        private async void SaveButtonCreateHousingItem(object obj)
        {

            var valid = ValidateSave();

            if (!string.IsNullOrWhiteSpace(valid))
            {
                await Application.Current.MainPage.DisplayAlert("Error", valid, "OK");
                return;
            }

            if (_itemForEditing != null)
            {
                _itemForEditing.UserName = UserName;
                _itemForEditing.Name = Name;
                _itemForEditing.PhoneNumber = PhoneNumber;
                _itemForEditing.Gender = SelectedGender != null ? SelectedGender.TranslationRowKey : null;
                _itemForEditing.Email = Email;
                _itemForEditing.District = SelectedDistrict != null ? SelectedDistrict.TranslationRowKey : null;
                _itemForEditing.County = SelectedCounty != null ? SelectedCounty.TranslationRowKey : null;
                _itemForEditing.SubCounty = SelectedSubCounty != null ? SelectedSubCounty.TranslationRowKey : null;
                _itemForEditing.Parish = Parish;
                _itemForEditing.Village = Village;
                _itemForEditing.Country = SelectedCountry != null ? SelectedCountry.TranslationRowKey : null;
                _itemForEditing.Currency = SelectedCurrency !=null ? SelectedCurrency.TranslationRowKey : null;
                _itemForEditing.LastModified = DateTime.UtcNow;
                //_itemForEditing.LastUploadDate = DateTime.UtcNow;
                _itemForEditing.UserLang = UserLangSettings.Eng;

                await repo.UpdateUserInfo(_itemForEditing);
                //await Application.Current.MainPage.DisplayAlert("Upnamed", "Reproduction record has been updated", "OK");
                await Shell.Current.Navigation.PopAsync();
            }
            else
            {
                var newUserInfo = new UserInfo
                {
                    UserName = UserName,
                    Name = Name,
                    PhoneNumber = PhoneNumber,
                    Gender = SelectedGender != null ? SelectedGender.TranslationRowKey : null,
                    Email = Email,
                    District = SelectedDistrict != null ? SelectedDistrict.TranslationRowKey : null,
                    County = SelectedCounty != null ? SelectedCounty.TranslationRowKey : null,
                    SubCounty = SelectedSubCounty != null ? SelectedSubCounty.TranslationRowKey : null,
                    Parish = Parish,
                    Village = Village,
                    Country = SelectedCountry != null ? SelectedCountry.TranslationRowKey : null,
                    Currency = SelectedCurrency != null ? SelectedCurrency.TranslationRowKey : null,
                    LastModified = DateTime.UtcNow,
                    LastUploadDate = DateTime.UtcNow,
                    PartitionKey = Constants.PartitionKeyUserInfo,
                    UserLang = UserLangSettings.Eng,
                    Timestamp = DateTime.UtcNow,
                    RowKey = registeredEmail,
                    AuthorisedEmail = registeredEmail,
                    AuthorisedToken = accessToken,
                };

                //go and save the user in the database;


               
                //await Shell.Current.GoToAsync(nameof(RegistrationSuccessfulPage));
                try
                {
                    await repo.AddSingleUserInfo(newUserInfo);
                    await Application.Current.MainPage.Navigation.PushAsync(new RegistrationSuccessfulPage());
                    //ShowSuccess?.Invoke(true);

                    /*using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("https://pigprofittool.azurewebsites.net/");
                        client.DefaultRequestHeaders.Accept.Clear();

                        var jObject2 = JsonConvert.SerializeObject(newUserInfo);

                        var data1 = new StringContent(jObject2, Encoding.UTF8, "application/json");

                        // New code:
                        HttpResponseMessage response2 = await client.PostAsync("api/data/AddUser", data1);
                        if ((int)response2.StatusCode == 202)
                        {
                            var responseString3 = await response2.Content.ReadAsStringAsync();
                            UserInfo use = JsonConvert.DeserializeObject<UserInfo>(responseString3);
                            await Application.Current.MainPage.Navigation.PushAsync(new AppShell());

                        }
                        else
                        {
                            //something went wrong
                            await Application.Current.MainPage.DisplayAlert("Error", response2.StatusCode.ToString(), "OK");
                        }

                    }*/



                    //await repo.UpdateUserInfo(User);
                    //var httpClient = new HttpClient();

                    //httpClient.DefaultRequestHeaders.Add("XApiKey", "ENTER YOUR API KEY HERE");
                    //httpClient.DefaultRequestHeaders.Authorization =
                    //new AuthenticationHeaderValue("Google", User.AuthorisedToken);

                    //var response1 = await httpClient.GetAsync("https://pigprofittool.azurewebsites.net/api/storage");

                    //var jObject = JsonConvert.SerializeObject(newUserInfo);

                    //var data = new StringContent(jObject, Encoding.UTF8, "application/json");
                    //var url = "https://pigprofittool.azurewebsites.net/api/data/AddUser";

                    //var response = await httpClient.PostAsync(url, data);
                    //var response = await httpClient.GetAsync(url);
                    //var responseString = await response.Content.ReadAsStringAsync();

                    //httpClient.Dispose();
                    /*
                    if (response1.IsSuccessStatusCode)
                    {
                        newUserInfo.LastUploadDate = DateTime.Now;
                        await repo.UpdateUserInfo(newUserInfo);
                        await Shell.Current.GoToAsync(nameof(RegistrationSuccessfulPage));
                    }
                    else
                    {
                        //something failed;
                        await Application.Current.MainPage.DisplayAlert("Error", response1.StatusCode.ToString(), "OK");
                    }*/
                    

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
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
            SelectedDistrict = null;
            SelectedCounty = null;
            SelectedSubCounty = null;
            Parish = null;
            Village = null;
            SelectedCurrency = null;
            SelectedCountry = null;
        }

        public async Task PopulateDataDowns()
        {
            var GenderControlData = await repo.GetControlData(Constants.GENDERTYPE);
            var DistrictControlData = await repo.GetControlData(Constants.DISTRICTTYPE);
            var CountyControlData = await repo.GetControlData(Constants.COUNTYTYPE);
            var SubCountyControlData = await repo.GetControlData(Constants.SUBCOUNTYTYPE);
            var CountryControlData = await repo.GetControlData(Constants.COUNTRYTYPE);
            var CurrencyControlData = await repo.GetControlData(Constants.CURRENCYTYPE);

            GenderListOfOptions = LogicHelper.CreatePickerToolOption(GenderControlData, UserLangSettings.Eng);
            DistrictListOfOptions = LogicHelper.CreatePickerToolOption(DistrictControlData, UserLangSettings.Eng);
            CountyListOfOptions = LogicHelper.CreatePickerToolOption(CountyControlData, UserLangSettings.Eng);
            SubCountyListOfOptions = LogicHelper.CreatePickerToolOption(SubCountyControlData, UserLangSettings.Eng);
            CountryListOfOptions = LogicHelper.CreatePickerToolOption(CountryControlData, UserLangSettings.Eng);
            CurrencyListOfOptions = LogicHelper.CreatePickerToolOption(CurrencyControlData, UserLangSettings.Eng);

            if (!IsEditMode)
            {
                SelectedGender = GenderListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.Gender).FirstOrDefault();
                SelectedDistrict = DistrictListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.District).FirstOrDefault();
                SelectedCounty = CountyListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.County).FirstOrDefault();
                SelectedSubCounty = SubCountyListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.SubCounty).FirstOrDefault();
                SelectedCountry = CountryListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.Country).FirstOrDefault();
                SelectedCurrency = CurrencyListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.Currency).FirstOrDefault();
            }
        }

        private string ValidateSave()
        {
            try
            {
                StringBuilder returnString = new StringBuilder();
                if (UserName == null) returnString.AppendLine("UserName Not provided");
                if (Name == null) returnString.AppendLine("Name Not provided");
                if (PhoneNumber == null) returnString.AppendLine("Phone Number Not Provided");
                if (SelectedCountry == null) returnString.AppendLine("Country Not Provided");
                if (SelectedCurrency == null) returnString.AppendLine("Currency Not Provided");

                return returnString.ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}