using PigTool.Helpers;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PigTool.ViewModels.DataViewModels
{
    public class EditUserViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        bool isEditMode;
        private bool editExistingMode;
        //private string? userName;
        private string? name;
        private string? gender;
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
        List<PickerToolHelper> genderListOfOptions;
        //List<PickerToolHelper> districtListOfOptions;
        //List<PickerToolHelper> countyListOfOptions;
        //List<PickerToolHelper> subCountyListOfOptions;
        List<PickerToolHelper> countryListOfOptions;
        List<PickerToolHelper> currencyListOfOptions;
        MobileUser _itemForEditing;


        //Button Clicks
        public Command SaveButtonClicked { get; }
        public Command ResetButtonClicked { get; }
        public Command DeleteButtonClicked { get; }
        public Command EditButtonClicked { get; }


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

        //public string? UserName
        //{
        //    get => userName;
        //    set
        //    {
        //        if (userName != value)
        //        {
        //            userName = value;
        //            OnPropertyChanged(nameof(UserName));
        //        }
        //    }
        //}

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
                    OnPropertyChanged(nameof(IsEditMode));
                }

            }
        }
        public bool EditExistingMode { get => editExistingMode; set { if (editExistingMode != value) { editExistingMode = value; OnPropertyChanged(nameof(EditExistingMode)); } } }

        public EditUserViewModel()
        {
            IsEditMode = true;

            SaveButtonClicked = new Command(SaveButtonCreateUser);
            ResetButtonClicked = new Command(ResetButtonPressed);
            DeleteButtonClicked = new Command(DeleteItem);
            EditButtonClicked = new Command(EditItem);

            RegistrationTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(RegistrationTitleTranslation), User.UserLang);
            NameTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(NameTranslation), User.UserLang) + " *";
            //UserNameTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(UserNameTranslation), User.UserLang) + " *";
            GenderTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(GenderTranslation), User.UserLang);
            EmailTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EmailTranslation), User.UserLang);
            DistrictTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DistrictTranslation), User.UserLang);
            CountyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CountyTranslation), User.UserLang);
            SubCountyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SubCountyTranslation), User.UserLang);
            ProvinceTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ProvinceTranslation), User.UserLang);
            CommuneTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CommuneTranslation), User.UserLang);
            SectorTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SectorTranslation), User.UserLang);
            CellTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CellTranslation), User.UserLang);

            CurrencyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CurrencyTranslation), User.UserLang) + " *";

            PhoneNumberTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PhoneNumberTranslation), User.UserLang) + " *";
            DistrictTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DistrictTranslation), User.UserLang);
            ParishTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ParishTranslation), User.UserLang);
            VillageTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(VillageTranslation), User.UserLang);

            SaveTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SaveTranslation), User.UserLang);
            ResetTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ResetTranslation), User.UserLang);
            EditTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EditTranslation), User.UserLang);
            DeleteTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DeleteTranslation), User.UserLang);

            //PickerDistrictTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerDistrictTranslation), User.UserLang);
            PickerGenderTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerGenderTranslation), User.UserLang);
            //PickerCountyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerCountyTranslation), User.UserLang);
            //PickerSubCountyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerSubCountyTranslation), User.UserLang);
            PickerCountryTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerCountryTranslation), User.UserLang);
            PickerCurrencyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerCurrencyTranslation), User.UserLang);

        }

        public void populatewithData()
        {

            _itemForEditing = User;

            //UserName = _itemForEditing.UserName;
            Name = _itemForEditing.Name;
            Gender = _itemForEditing.Gender;
            PhoneNumber = _itemForEditing.PhoneNumber;
            District = _itemForEditing.District;
            County = _itemForEditing.County;
            SubCounty = _itemForEditing.SubCounty;
            Parish = _itemForEditing.Parish;
            Village = _itemForEditing.Village;
            Currency = _itemForEditing.Currency;
            Province = _itemForEditing.Province;
            Commune = _itemForEditing.Commune;
            Sector = _itemForEditing.Sector;
            Cell = _itemForEditing.Cell;


        }

        public void SetPickers()
        {
            SelectedGender = GenderListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.Gender).FirstOrDefault();
            //SelectedDistrict = DistrictListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.District).FirstOrDefault();
            //SelectedCounty = CountyListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.County).FirstOrDefault();
            //SelectedSubCounty = SubCountyListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.SubCounty).FirstOrDefault();
            SelectedCurrency = CurrencyListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.Currency).FirstOrDefault();
        }

        private async void SaveButtonCreateUser(object obj)
        {

            var valid = ValidateSave();

            if (!string.IsNullOrWhiteSpace(valid))
            {
                await Application.Current.MainPage.DisplayAlert("Error", valid, "OK");
                return;
            }

            try
            {
                //_itemForEditing.UserName = UserName;
                _itemForEditing.Name = Name;
                _itemForEditing.PhoneNumber = PhoneNumber;
                _itemForEditing.Gender = SelectedGender != null ? SelectedGender.TranslationRowKey : null;
                //_itemForEditing.District = SelectedDistrict != null ? SelectedDistrict.TranslationRowKey : null;
                //_itemForEditing.County = SelectedCounty != null ? SelectedCounty.TranslationRowKey : null;
                //_itemForEditing.SubCounty = SelectedSubCounty != null ? SelectedSubCounty.TranslationRowKey : null;
                _itemForEditing.District = District;
                _itemForEditing.County = County;
                _itemForEditing.SubCounty = SubCounty;
                _itemForEditing.Parish = Parish;
                _itemForEditing.Village = Village;
                _itemForEditing.Currency = SelectedCurrency != null ? SelectedCurrency.TranslationRowKey : null;
                _itemForEditing.Province = Province;
                _itemForEditing.Commune = Commune;
                _itemForEditing.Sector = Sector;
                _itemForEditing.Cell = Cell;
                _itemForEditing.LastModified = DateTime.UtcNow;
                //_itemForEditing.LastUploadDate = DateTime.UtcNow;
                //_itemForEditing.UserLang = lang;
                //_itemForEditing.Country = SelectedCountry != null ? SelectedCountry.TranslationRowKey : null;

                await repo.UpdateUserInfo(_itemForEditing);
                //await Application.Current.MainPage.DisplayAlert("Upnamed", "Reproduction record has been updated", "OK");
                //await Shell.Current.Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Something went wrong, please try again later", "OK");
            }
            await Application.Current.MainPage.DisplayAlert("Saved", "Your changes have been saved", "OK");
            await Application.Current.MainPage.Navigation.PopAsync();

        }

        private async void DeleteItem(object obj)
        {

        }

        private async void EditItem(object obj)
        {

        }

        private async void ResetButtonPressed(object obj)
        {
            ClearFormVariables();
        }

        private void ClearFormVariables()
        {
            //UserName = null;
            Name = null;
            PhoneNumber = null;
            SelectedGender = null;
            //SelectedDistrict = null;
            //SelectedCounty = null;
            //SelectedSubCounty = null;
            District = null;
            County = null;
            SubCounty = null;
            Parish = null;
            Village = null;
            SelectedCurrency = null;
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

            GenderListOfOptions = LogicHelper.CreatePickerToolOption(GenderControlData, User.UserLang);
            //DistrictListOfOptions = LogicHelper.CreatePickerToolOption(DistrictControlData, lang);
            //CountyListOfOptions = LogicHelper.CreatePickerToolOption(CountyControlData, lang);
            //SubCountyListOfOptions = LogicHelper.CreatePickerToolOption(SubCountyControlData, lang);

            CurrencyListOfOptions = LogicHelper.CreatePickerToolOption(CurrencyControlData, User.UserLang);



            SelectedGender = GenderListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.Gender).FirstOrDefault();
            //SelectedDistrict = DistrictListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.District).FirstOrDefault();
            //SelectedCounty = CountyListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.County).FirstOrDefault();
            //SelectedSubCounty = SubCountyListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.SubCounty).FirstOrDefault();
            SelectedCurrency = CurrencyListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.Currency).FirstOrDefault();

        }

        private string ValidateSave()
        {
            try
            {
                StringBuilder returnString = new StringBuilder();
                //if (UserName == null) returnString.AppendLine("UserName Not provided");
                if (Name == null) returnString.AppendLine("Name Not provided");
                if (PhoneNumber == null) returnString.AppendLine("Phone Number Not Provided");
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
