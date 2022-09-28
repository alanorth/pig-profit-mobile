﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PigTool.Helpers;
using PigTool.Models;
using PigTool.Views;
using Xamarin.Forms;

namespace PigTool.ViewModels
{
    public class AnimalHousingViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        bool isEditMode, isCreationMode;
        private bool editExistingMode;
        private string? housingExpense;
        private string? otherHousingExpense;
        private string? comment;
        private double? totalCosts;
        private double? transportationCost;
        private double? otherCosts;
        private int? yearsExpected;
        private DateTime date;
        List<PickerToolHelper> housingTypeListOfOptions;
        AnimalHouseItem _itemForEditing;

        //Button Clicks
        public Command SaveButtonClicked { get; }
        public Command ResetButtonClicked { get; }
        public Command DeleteButtonClicked { get; }
        public Command EditButtonClicked { get; }


        #region translation
        public string DateTranslation { get; set; }
        public string HousingExpenseTranslation { get; set; }
        public string OtherHousingExpenseTranslation { get; set; }
        public string TotalCostTranslation { get; set; }
        public string TransportationCostTranslation { get; set; }
        public string OtherCostTranslation { get; set; }
        public string YearsExpectedTranslation { get; set; }
        public string CommentTranslation { get; set; }
        public string HousingTitleTranslation { get; set; }
        public string SaveTranslation { get; set; }
        public string ResetTranslation { get; set; }
        public string EditTranslation { get; set; }
        public string DeleteTranslation { get; set; }
        #endregion


        #region housing item fields
        public DateTime Date
        {
            get => date;
            set
            {
                if (date != value)
                {
                    date = value;
                    OnPropertyChanged(nameof(Date));
                }
            }
        }
        public string? HousingExpense
        {
            get => housingExpense;
            set
            {
                if (value != housingExpense)
                {
                    housingExpense = value;
                    OnPropertyChanged(nameof(HousingExpense));
                }
            }
        }
        public string? OtherHousingExpense
        {
            get => otherHousingExpense;
            set
            {
                if (value != otherHousingExpense)
                {
                    otherHousingExpense = value;
                    OnPropertyChanged(nameof(OtherHousingExpense));
                }
            }
        }
        public double? TotalCosts
        {
            get => totalCosts;
            set
            {
                if (value != totalCosts)
                {
                    totalCosts = value;
                    OnPropertyChanged(nameof(TotalCosts));
                }
            }
        }
        public double? TransportationCost
        {
            get => transportationCost;
            set
            {
                if (value != transportationCost)
                {
                    transportationCost = value;
                    OnPropertyChanged(nameof(TransportationCost));
                }
            }
        }
        public double? OtherCosts
        {
            get => otherCosts;
            set
            {
                if (value != otherCosts)
                {
                    otherCosts = value;
                    OnPropertyChanged(nameof(OtherCosts));
                }
            }
        }
        public string? Comment
        {
            get => comment;
            set
            {
                if (value != comment)
                {
                    comment = value;
                    OnPropertyChanged(nameof(Comment));
                }
            }
        }
        public int? YearsExpected
        {
            get => yearsExpected;
            set
            {
                if (value != yearsExpected)
                {
                    yearsExpected = value;
                    OnPropertyChanged(nameof(YearsExpected));
                }
            }
        }

        #endregion

        public List<PickerToolHelper> HousingTypeListOfOptions
        {

            get { return housingTypeListOfOptions; }
            set
            {
                housingTypeListOfOptions = value;
                OnPropertyChanged(nameof(HousingTypeListOfOptions));
            }
        }
        private bool displayOtherHouseType;

        public bool DisplayOtherHouseType
        {
            get => displayOtherHouseType;
            set
            {
                if (displayOtherHouseType != value)
                {
                    displayOtherHouseType = value;
                    OnPropertyChanged(nameof(DisplayOtherHouseType));
                }
            }
        }

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

        private PickerToolHelper selectedHousingType;

        public PickerToolHelper SelectedHousingType
        {
            get { return selectedHousingType; }
            set
            {
                /*if (value != null && value.CompareTo(selectedHousingType) == 0)
                {
                    if (value.TranslationRowKey == SC.OTHER)
                    {
                        DisplayOtherHouseType = true;
                    }
                    selectedHousingType = value;
                    OnPropertyChanged(nameof(SelectedHousingType));
                }
                else if (value == null)
                {
                    selectedHousingType = value;
                }*/
                if (selectedHousingType != value)
                {
                    DisplayOtherHouseType = value?.TranslationRowKey == SC.OTHER;
                    selectedHousingType = value;
                    OnPropertyChanged(nameof(SelectedHousingType));
                }
            }
        }

        public bool EditExistingMode { get => editExistingMode; set { if (editExistingMode != value) { editExistingMode = value; OnPropertyChanged(nameof(EditExistingMode)); } } }
        public bool CreationMode { get; private set; }

        public AnimalHousingViewModel()
        {
            /*
                private string housingExpense;
                private string otherHousingExpense;
                private double? totalCosts;
                private double? transportationCost;
                private double? otherCosts;
                private int yearsExpected;
                private DateTime date;
            */
            Date = DateTime.Now;

            IsEditMode = true;
            CreationMode = true;

            SaveButtonClicked = (new Command(SaveButtonCreateHousingItem));
            ResetButtonClicked = new Command(ResetButtonPressed);
            DeleteButtonClicked = new Command(DeleteItem);
            EditButtonClicked = new Command(EditItem);
            IsEditMode = true;
            IsCreationMode = !EditExistingMode;

            TransportationCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TransportationCostTranslation), User.UserLang);
            DateTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateTranslation), User.UserLang) + " *";
            HousingExpenseTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(HousingExpenseTranslation), User.UserLang);
            OtherHousingExpenseTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherHousingExpenseTranslation), User.UserLang);
            TotalCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TotalCostTranslation), User.UserLang) + " *";
            TransportationCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TransportationCostTranslation), User.UserLang) + " *";
            OtherCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherCostTranslation), User.UserLang) + " *";
            YearsExpectedTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(YearsExpectedTranslation), User.UserLang);
            CommentTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CommentTranslation), User.UserLang);
            SaveTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SaveTranslation), User.UserLang);
            ResetTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ResetTranslation), User.UserLang);
            EditTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EditTranslation), User.UserLang);
            DeleteTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DeleteTranslation), User.UserLang);
            HousingTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(HousingTitleTranslation), User.UserLang);
        }

        public void populatewithData(AnimalHouseItem item)
        {
            isEditMode = false;
            CreationMode = false;
            EditExistingMode = !CreationMode;

            _itemForEditing = item;

            Date = item.Date;
            HousingExpense = item.HousingExpense;
            OtherHousingExpense = item.OtherHousingExpense;
            TotalCosts = item.TotalCosts;
            TransportationCost = item.TransportationCost;
            OtherCosts = item.OtherCosts; 
            yearsExpected = item.YearsExpected;
            Comment = item.Comment;
        }

        public void SetPickers()
        {
            if (EditExistingMode)
            {
                SelectedHousingType = HousingTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.HousingExpense).FirstOrDefault();

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

                _itemForEditing.Date = Date;
                _itemForEditing.HousingExpense = SelectedHousingType != null ? SelectedHousingType.TranslationRowKey : null;
                _itemForEditing.OtherHousingExpense = OtherHousingExpense;
                _itemForEditing.TotalCosts = (double)TotalCosts;
                _itemForEditing.TransportationCost = (double)TransportationCost;
                _itemForEditing.OtherCosts = (double)OtherCosts;
                _itemForEditing.YearsExpected = YearsExpected;
                _itemForEditing.Comment = Comment;
                _itemForEditing.LastModified = DateTime.UtcNow;

                await repo.UpdateAnimalHouseItem(_itemForEditing);
                await Application.Current.MainPage.DisplayAlert("Updated", "Animal housing record has been updated", "OK");
                await Shell.Current.Navigation.PopAsync();
            }
            else
            {
                var newHousingCost = new AnimalHouseItem
                {
                    Date = Date,
                    HousingExpense = SelectedHousingType != null ? SelectedHousingType.TranslationRowKey : null,
                    OtherHousingExpense = OtherHousingExpense,
                    TotalCosts = (double)TotalCosts,
                    TransportationCost = (double)TransportationCost,
                    OtherCosts = (double)OtherCosts,
                    YearsExpected = YearsExpected,
                    Comment = Comment,
                    LastModified = DateTime.UtcNow,
                    CreatedBy = User.UserName,
                };

                await repo.AddSingleAnimalHouseItem(newHousingCost);
                await Application.Current.MainPage.DisplayAlert("Created", "Housing record has been saved", "OK");
            }
        }

        private async void DeleteItem(object obj)
        {
            if (EditExistingMode)
            {
                var confirmDelete = await Application.Current.MainPage.DisplayAlert("Deletion Confirmation", "Are you sure you want to Delete this item", "OK", "Cancel");
                if (confirmDelete)
                {
                    repo.DeleteAnimalHouseItem(_itemForEditing);
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
            SelectedHousingType = null;
            HousingExpense = null;
            OtherHousingExpense = null;
            TotalCosts = null;
            TransportationCost = null;
            OtherCosts = null;
            YearsExpected = 1;
            Comment = null;

        }

        public async Task PopulateDataDowns()
        {
            var HousingTypeControlData = await repo.GetControlData(SC.HOUSINGTYPE);

            HousingTypeListOfOptions = LogicHelper.CreatePickerToolOption(HousingTypeControlData, User.UserLang);

            if (!IsEditMode)
            {
                SelectedHousingType = HousingTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.HousingExpense).FirstOrDefault();
            }
        }

        private string ValidateSave()
        {
            try
            {
                StringBuilder returnString = new StringBuilder();
                if (Date == null ) returnString.AppendLine("Date obtained not provided");
                if (TotalCosts == null ) returnString.AppendLine("Total Cost Not Provided");
                if (TransportationCost == null ) returnString.AppendLine("Transportation Cost Not Provided");
                if (OtherCosts == null ) returnString.AppendLine("Other Cost Not Provided");

                if (SelectedHousingType != null)
                {
                    if (SelectedHousingType.TranslationRowKey == SC.OTHER)
                    {
                        if (string.IsNullOrWhiteSpace(OtherHousingExpense)) returnString.AppendLine("Other Housing Expense Not Provided");
                    }
                    else
                    {
                        OtherHousingExpense = null;
                    }
                }
                
                return returnString.ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}
