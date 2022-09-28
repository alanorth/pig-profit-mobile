using PigTool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PigTool.Helpers;

namespace PigTool.ViewModels
{
    public class FeedItemViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        bool isEditMode, isCreationMode;
        private bool editExistingMode;
        private DateTime date;
        private string? feedType;
        private string? otherFeedType;
        private double? amountPurchased;
        private string? amountPurchasedUnit;
        private string? otherAmountPurchasedUnit;
        private double? totalCosts;
        private double? transportationCost;
        private string? purchasedFrom;
        private string? otherPurchasedFrom;
        private string comment;
        List<PickerToolHelper> feedTypeListOfOptions, amountPurchasedUnitListOfOptions, purchasedFromListOfOptions;
        FeedItem _itemForEditing;

        //Button Clicks
        public Command SaveButtonClicked { get; }
        public Command ResetButtonClicked { get; }
        public Command DeleteButtonClicked { get; }
        public Command EditButtonClicked { get; }

        #region Translations
        public string FeedItemTitleTranslation { get; set; }
        public string DateTranslation { get; set; }

        public string FeedTypeTranslation { get; set; }
        public string OtherFeedTypeTranslation { get; set; }
        public string AmountPurchasedUnitTranslation { get; set; }
        public string OtherAmountPurchasedUnitTranslation { get; set; }
        public string PurchasedFromTranslation { get; set; }
        public string OtherPurchasedFromTranslation { get; set; }

        public string AmountPurchasedTranslation { get; set; }
        public string TotalCostTranslation { get; set; }
        public string TransportationCostTranslation { get; set; }
        public string CommentTranslation { get; set; }

        public string SaveTranslation { get; set; }
        public string ResetTranslation { get; set; }
        public string EditTranslation { get; set; }
        public string DeleteTranslation { get; set; }
        #endregion

        #region Feed item fields
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
        public string? FeedType
        {
            get => feedType;
            set
            {
                if (value != feedType)
                {
                    feedType = value;
                    OnPropertyChanged(nameof(FeedType));
                }
            }
        }
        public string? OtherFeedType
        {
            get => otherFeedType;
            set
            {
                if (value != otherFeedType)
                {
                    otherFeedType = value;
                    OnPropertyChanged(nameof(OtherFeedType));
                }
            }
        }
        public double? AmountPurchased
        {
            get => amountPurchased;
            set
            {
                if (value != amountPurchased)
                {
                    amountPurchased = value;
                    OnPropertyChanged(nameof(AmountPurchased));
                }
            }
        }
        public string? AmountPurchasedUnit
        {
            get => amountPurchasedUnit;
            set
            {
                if (value != amountPurchasedUnit)
                {
                    amountPurchasedUnit = value;
                    OnPropertyChanged(nameof(AmountPurchasedUnit));
                }
            }
        }
        public string? OtherAmountPurchasedUnit
        {
            get => otherAmountPurchasedUnit;
            set
            {
                if (value != otherAmountPurchasedUnit)
                {
                    otherAmountPurchasedUnit = value;
                    OnPropertyChanged(nameof(OtherAmountPurchasedUnit));
                }
            }
        }
        public string? PurchasedFrom
        {
            get => purchasedFrom;
            set
            {
                if (value != purchasedFrom)
                {
                    purchasedFrom = value;
                    OnPropertyChanged(nameof(PurchasedFrom));
                }
            }
        }
        public string? OtherPurchasedFrom
        {
            get => otherPurchasedFrom;
            set
            {
                if (value != otherPurchasedFrom)
                {
                    otherPurchasedFrom = value;
                    OnPropertyChanged(nameof(OtherPurchasedFrom));
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

        #endregion

        #region Dropdowns
        public List<PickerToolHelper> FeedTypeListOfOptions
        {
            get { return feedTypeListOfOptions; }
            set
            {
                feedTypeListOfOptions = value;
                OnPropertyChanged(nameof(FeedTypeListOfOptions));
            }
        }
        public List<PickerToolHelper> AmountPurchasedUnitListOfOptions
        {
            get { return amountPurchasedUnitListOfOptions; }
            set
            {
                amountPurchasedUnitListOfOptions = value;
                OnPropertyChanged(nameof(AmountPurchasedUnitListOfOptions));
            }
        }
        public List<PickerToolHelper> PurchasedFromListOfOptions
        {
            get { return purchasedFromListOfOptions; }
            set
            {
                purchasedFromListOfOptions = value;
                OnPropertyChanged(nameof(PurchasedFromListOfOptions));
            }
        }

        private PickerToolHelper selectedFeedType;

        public PickerToolHelper SelectedFeedType
        {
            get { return selectedFeedType; }
            set
            {
                if (selectedFeedType != value)
                {
                    DisplayOtherFeedType = value?.TranslationRowKey == SC.OTHER;
                    selectedFeedType = value;
                    OnPropertyChanged(nameof(SelectedFeedType));
                }
            }
        }

        private PickerToolHelper selectedAmountPurchasedUnit;

        public PickerToolHelper SelectedAmountPurchasedUnit
        {
            get { return selectedAmountPurchasedUnit; }
            set
            {
                if (selectedAmountPurchasedUnit != value)
                {
                    DisplayOtherAmountPurchasedUnit = value?.TranslationRowKey == SC.OTHER;
                    selectedAmountPurchasedUnit = value;
                    OnPropertyChanged(nameof(SelectedAmountPurchasedUnit));
                }
            }
        }
        private PickerToolHelper selectedPurchasedFrom;

        public PickerToolHelper SelectedPurchasedFrom
        {
            get { return selectedPurchasedFrom; }
            set
            {
                if (selectedPurchasedFrom != value)
                {
                    DisplayOtherPurchasedFrom = value?.TranslationRowKey == SC.OTHER;
                    selectedPurchasedFrom = value;
                    OnPropertyChanged(nameof(SelectedPurchasedFrom));
                }
            }
        }
        #endregion

        #region Hidden Fields
        private bool displayOtherFeedType;
        private bool displayOtherAmountPurchasedUnit;
        private bool displayOtherPurchasedFrom;

        public bool DisplayOtherFeedType
        {
            get => displayOtherFeedType;
            set
            {
                if (displayOtherFeedType != value)
                {
                    displayOtherFeedType = value;
                    OnPropertyChanged(nameof(DisplayOtherFeedType));
                }
            }
        }
        public bool DisplayOtherAmountPurchasedUnit
        {
            get => displayOtherAmountPurchasedUnit;
            set
            {
                if (displayOtherAmountPurchasedUnit != value)
                {
                    displayOtherAmountPurchasedUnit = value;
                    OnPropertyChanged(nameof(DisplayOtherAmountPurchasedUnit));
                }
            }
        }
        public bool DisplayOtherPurchasedFrom
        {
            get => displayOtherPurchasedFrom;
            set
            {
                if (displayOtherPurchasedFrom != value)
                {
                    displayOtherPurchasedFrom = value;
                    OnPropertyChanged(nameof(DisplayOtherPurchasedFrom));
                }
            }
        }
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

        public FeedItemViewModel()
        {
            Date = DateTime.Now;

            IsEditMode = true;
            CreationMode = true;

            SaveButtonClicked = (new Command(SaveButtonCreateFeedItem));
            ResetButtonClicked = new Command(ResetButtonPressed);
            DeleteButtonClicked = new Command(DeleteItem);
            EditButtonClicked = new Command(EditItem);
            IsEditMode = true;
            IsCreationMode = !EditExistingMode;

            FeedItemTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(FeedItemTitleTranslation), User.UserLang);
            DateTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateTranslation), User.UserLang) + " *";

            FeedTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(FeedTypeTranslation), User.UserLang);
            AmountPurchasedTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(AmountPurchasedTranslation), User.UserLang);
            OtherFeedTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherFeedTypeTranslation), User.UserLang);
            AmountPurchasedUnitTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(AmountPurchasedUnitTranslation), User.UserLang);
            OtherAmountPurchasedUnitTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherAmountPurchasedUnitTranslation), User.UserLang);
            PurchasedFromTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PurchasedFromTranslation), User.UserLang);
            OtherPurchasedFromTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherPurchasedFromTranslation), User.UserLang);

            TotalCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TotalCostTranslation), User.UserLang) + " *";
            TransportationCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TransportationCostTranslation), User.UserLang) + " *";
            CommentTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CommentTranslation), User.UserLang);

            SaveTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SaveTranslation), User.UserLang);
            ResetTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ResetTranslation), User.UserLang);
            EditTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EditTranslation), User.UserLang);
            DeleteTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DeleteTranslation), User.UserLang);
        }

        public void populatewithData(FeedItem item)
        {
            isEditMode = false;
            CreationMode = false;
            EditExistingMode = !CreationMode;

            _itemForEditing = item;

            Date = item.Date;
            FeedType = item.FeedType;
            OtherFeedType = item.OtherFeedType;
            AmountPurchased = item.AmountPurchased;
            AmountPurchasedUnit = item.AmountPurchasedUnit;
            OtherAmountPurchasedUnit = item.OtherAmountPurchaseUnit;
            PurchasedFrom = item.PurchasedFrom;
            OtherPurchasedFrom = item.OtherPurchasedFrom;
            TotalCosts = item.TotalCosts;
            TransportationCost = item.TransportationCost;
            Comment = item.Comment;
        }

        public void SetPickers()
        {
            if (EditExistingMode)
            {
                SelectedFeedType = FeedTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.FeedType).FirstOrDefault();
                SelectedAmountPurchasedUnit = AmountPurchasedUnitListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.AmountPurchasedUnit).FirstOrDefault();
                SelectedPurchasedFrom = PurchasedFromListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.PurchasedFrom).FirstOrDefault();
            }
        }

        private async void SaveButtonCreateFeedItem(object obj)
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
                _itemForEditing.FeedType = SelectedFeedType != null ? SelectedFeedType.TranslationRowKey : null;
                _itemForEditing.OtherFeedType = OtherFeedType;
                _itemForEditing.AmountPurchased = AmountPurchased;
                _itemForEditing.AmountPurchasedUnit = SelectedAmountPurchasedUnit != null ? SelectedAmountPurchasedUnit.TranslationRowKey : null;
                _itemForEditing.OtherAmountPurchaseUnit = OtherAmountPurchasedUnitTranslation;
                _itemForEditing.PurchasedFrom = SelectedPurchasedFrom != null ? SelectedPurchasedFrom.TranslationRowKey : null;
                _itemForEditing.OtherPurchasedFrom = OtherPurchasedFrom;
                _itemForEditing.TotalCosts = (double)TotalCosts;
                _itemForEditing.TransportationCost = (double)TransportationCost;
                _itemForEditing.Comment = Comment;
                _itemForEditing.LastModified = DateTime.UtcNow;

                await repo.UpdateFeedItem(_itemForEditing);
                await Application.Current.MainPage.DisplayAlert("Updated", "Feed record has been updated", "OK");
                await Shell.Current.Navigation.PopAsync();
            }
            else
            {
                var newFeedItem = new FeedItem
                {
                    Date = Date,
                    FeedType = SelectedFeedType != null ? SelectedFeedType.TranslationRowKey : null,
                    OtherFeedType = OtherFeedType,
                    AmountPurchased = AmountPurchased,
                    AmountPurchasedUnit = SelectedAmountPurchasedUnit != null ? SelectedAmountPurchasedUnit.TranslationRowKey : null,
                    OtherAmountPurchaseUnit = OtherAmountPurchasedUnitTranslation,
                    PurchasedFrom = SelectedPurchasedFrom != null ? SelectedPurchasedFrom.TranslationRowKey : null,
                    OtherPurchasedFrom = OtherPurchasedFrom,
                    TotalCosts = (double)TotalCosts,
                    TransportationCost = (double)TransportationCost,
                    Comment = Comment,
                    LastModified = DateTime.UtcNow,
                    CreatedBy = User.UserName,
                };

                await repo.AddSingleFeedItem(newFeedItem);
                await Application.Current.MainPage.DisplayAlert("Created", "Feed item has been saved", "OK");
            }
        }

        private async void DeleteItem(object obj)
        {
            if (EditExistingMode)
            {
                var confirmDelete = await Application.Current.MainPage.DisplayAlert("Deletion Confirmation", "Are you sure you want to delete this item", "OK", "Cancel");
                if (confirmDelete)
                {
                    repo.DeleteFeedItem(_itemForEditing);
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
            FeedType = null;
            OtherFeedType = null;
            AmountPurchased = null;
            AmountPurchasedUnit = null;
            OtherAmountPurchasedUnit = null;
            PurchasedFrom = null;
            OtherPurchasedFrom = null;
            TotalCosts = null;
            TransportationCost = null;
            Comment = null;
        }

        public async Task PopulateDataDowns()
        {
            var FeedTypeControlData = await repo.GetControlData(SC.FEEDTYPE);
            var PurchasedFromControlData = await repo.GetControlData(SC.FEEDPURCHASEDFROMTYPE);
            var FeedAmountPurchasedUnitControlData = await repo.GetControlData(SC.FEEDAMOUNTPURCHASEDUNITTYPE);

            FeedTypeListOfOptions = LogicHelper.CreatePickerToolOption(FeedTypeControlData, User.UserLang);
            PurchasedFromListOfOptions = LogicHelper.CreatePickerToolOption(PurchasedFromControlData, User.UserLang);
            AmountPurchasedUnitListOfOptions = LogicHelper.CreatePickerToolOption(FeedAmountPurchasedUnitControlData, User.UserLang);

            if (!IsEditMode)
            {
                SelectedFeedType = FeedTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.FeedType).FirstOrDefault();
                SelectedPurchasedFrom = PurchasedFromListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.PurchasedFrom).FirstOrDefault();
                selectedAmountPurchasedUnit = AmountPurchasedUnitListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.AmountPurchasedUnit).FirstOrDefault();
            }
        }

        private string ValidateSave()
        {
            try
            {
                StringBuilder returnString = new StringBuilder();
                if (Date == null) returnString.AppendLine("Date obtained not provided");
                if (TotalCosts == null) returnString.AppendLine("Total Cost Not Provided");
                if (TransportationCost == null) returnString.AppendLine("Transportation Cost Not Provided");


                if (SelectedFeedType != null && SelectedFeedType.TranslationRowKey == SC.OTHER)
                {
                    if (string.IsNullOrWhiteSpace(OtherFeedType)) returnString.AppendLine("Other Feed Type Not Provided");
                }

                if (SelectedAmountPurchasedUnit != null)
                {
                    if (SelectedAmountPurchasedUnit.TranslationRowKey == SC.OTHER)
                    {
                        if (string.IsNullOrWhiteSpace(OtherAmountPurchasedUnit)) returnString.AppendLine("Other Amount Purchased Unit Not Provided");
                    }
                }

                if (SelectedPurchasedFrom != null)
                {
                    if (SelectedPurchasedFrom.TranslationRowKey == SC.OTHER)
                    {
                        if (string.IsNullOrWhiteSpace(OtherPurchasedFrom)) returnString.AppendLine("Other Purchased From Not Provided");
                    }
                }

                if (returnString.Length > 0) return returnString.ToString();


                return returnString.ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }

    }
}
