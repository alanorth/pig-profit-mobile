using System;
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
    public class CountrySelectViewModel : LoggedOutViewModel, INotifyPropertyChanged
    {
        bool isEditMode, isCreationMode;
        private bool editExistingMode;

        private string? country;
        List<PickerToolHelper> countryListOfOptions;

        private bool canContinue;

        public UserLangSettings lang;

        //Button Clicks
        public Command SaveButtonClicked { get; }
        public Command ResetButtonClicked { get; }
        public Command DeleteButtonClicked { get; }
        public Command EditButtonClicked { get; }

        public Action<bool> ShowSuccess { get; set; }

        #region translations
        public string WhereAreYouLocatedTranslation { get; set; }

        public string CountryTranslation { get; set; }

        public string SaveTranslation { get; set; }
        public string ResetTranslation { get; set; }
        public string EditTranslation { get; set; }
        public string DeleteTranslation { get; set; }


        public string PickerCountryTranslation { get; set; }
        #endregion

        #region CountrySelect item fields

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

        public UserLangSettings Lang
        {
            get => lang;
            set
            {
                if (value != lang)
                {
                    lang = value;
                    OnPropertyChanged(nameof(Lang));
                }
            }
        }

        #endregion

        #region Dropdown Lists

        public List<PickerToolHelper> CountryListOfOptions
        {
            get { return countryListOfOptions; }
            set
            {
                countryListOfOptions = value;
                OnPropertyChanged(nameof(CountryListOfOptions));
            }
        }


        // Selected
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

        public bool CanContinue
        {

            get { return canContinue; }
            set
            {
                if (value != canContinue)
                {
                    canContinue = value;
                    OnPropertyChanged(nameof(CanContinue));
                }
            }
        }
        public bool EditExistingMode { get => editExistingMode; set { if (editExistingMode != value) { editExistingMode = value; OnPropertyChanged(nameof(EditExistingMode)); } } }
        public bool CreationMode { get; private set; }

        public CountrySelectViewModel(UserLangSettings lang)
        {
            this.lang = lang;
            IsEditMode = true;
            CreationMode = true;

            //SaveButtonClicked = new Command(SaveButton);
            ResetButtonClicked = new Command(ResetButtonPressed);
            DeleteButtonClicked = new Command(DeleteItem);
            EditButtonClicked = new Command(EditItem);
            IsEditMode = true;
            IsCreationMode = !EditExistingMode;


            WhereAreYouLocatedTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(WhereAreYouLocatedTranslation), this.lang);

            CountryTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CountryTranslation), this.lang) + " *";

            SaveTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SaveTranslation), this.lang);
            ResetTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ResetTranslation), this.lang);
            EditTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EditTranslation), this.lang);
            DeleteTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DeleteTranslation), this.lang);

            PickerCountryTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerCountryTranslation), this.lang);
        }

        /*
        private async void SaveButton(object obj)
        {

            var valid = ValidateSave();

            if (!string.IsNullOrWhiteSpace(valid))
            {
                await Application.Current.MainPage.DisplayAlert("Error", valid, "OK");
                return;
            }


                Country = SelectedCountry != null ? SelectedCountry.TranslationRowKey : null;
                    

            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new LegalDisclaimer());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        */

        private async void DeleteItem(object obj)
        {
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
            SelectedCountry = null;
        }

        public async Task PopulateDataDowns()
        {
            try
            {
                var CountryControlData = await repo.GetControlData(Constants.COUNTRYTYPE);
                var LanguageControlData = await repo.GetControlData(Constants.CURRENCYTYPE);


                CountryListOfOptions = LogicHelper.CreatePickerToolOption(CountryControlData, UserLangSettings.Eng);
            }
            catch (Exception ex)
            {

            }
        }

        private string ValidateSave()
        {
            try
            {
                StringBuilder returnString = new StringBuilder();

                if (SelectedCountry == null) returnString.AppendLine("Country Not Provided");

                return returnString.ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}
