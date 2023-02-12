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
    public class WaterCostViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        bool isEditMode, isCreationMode;
        private bool editExistingMode;
        private DateTime date, durationStart, durationFinish;
        private double? waterPurchased;
        private string waterPurchasedUnit;
        private string otherWaterPurchasedUnit;
        private double? totalCosts;
        private string purchasedWaterFrom;
        private string otherPurchasedWaterFrom;
        private double? transportationCost;
        private double? otherCosts;
        private string comment;
        List<PickerToolHelper> waterPurchasedUnitListOfOptions;
        List<PickerToolHelper> purchasedWaterFromListOfOptions;
        WaterCostItem _itemForEditing;

        //Button Clicks
        public Command SaveButtonClicked { get; }
        public Command ResetButtonClicked { get; }
        public Command DeleteButtonClicked { get; }
        public Command EditButtonClicked { get; }

        #region translations
        public string WaterCostTitleTranslation { get; set; }
        public string DateTranslation { get; set; }

        public string WaterPurchasedTranslation { get; set; }
        public string OtherWaterPurchasedTranslation { get; set; }
        public string PurchasedWaterFromTranslation { get; set; }
        public string OtherPurchasedWaterFromTranslation { get; set; }

        public string TotalCostTranslation { get; set; }
        public string TransportationCostTranslation { get; set; }
        public string OtherCostTranslation { get; set; }
        public string CommentTranslation { get; set; }

        public string SaveTranslation { get; set; }
        public string ResetTranslation { get; set; }
        public string EditTranslation { get; set; }
        public string DeleteTranslation { get; set; }

        public string PickerUnitTranslation { get; set; }
        public string PickerPurchasedFromTranslation { get; set; }

        public string StartTranslation { get; set; }
        public string FinishTranslation { get; set; }
        public string WaterDurationTranslation { get; set; }
        #endregion

        #region Water cost item fields
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
        public DateTime DurationStart
        {
            get => durationStart;
            set
            {
                if (durationStart != value)
                {
                    durationStart = value;
                    OnPropertyChanged(nameof(DurationStart));
                }
            }
        }
        public DateTime DurationFinish
        {
            get => durationFinish;
            set
            {
                if (durationFinish != value)
                {
                    durationFinish = value;
                    OnPropertyChanged(nameof(DurationFinish));
                }
            }
        }
        public double? WaterPurchased
        {
            get => waterPurchased;
            set
            {
                if (value != waterPurchased)
                {
                    waterPurchased = value;
                    OnPropertyChanged(nameof(WaterPurchased));
                }
            }
        }
        public string WaterPurchasedUnit
        {
            get => waterPurchasedUnit;
            set
            {
                if (value != waterPurchasedUnit)
                {
                    waterPurchasedUnit = value;
                    OnPropertyChanged(nameof(WaterPurchasedUnit));
                }
            }
        }
        public string OtherWaterPurchasedUnit
        {
            get => otherWaterPurchasedUnit;
            set
            {
                if (value != otherWaterPurchasedUnit)
                {
                    otherWaterPurchasedUnit = value;
                    OnPropertyChanged(nameof(OtherWaterPurchasedUnit));
                }
            }
        }
        public string PurchasedWaterFrom
        {
            get => purchasedWaterFrom;
            set
            {
                if (value != purchasedWaterFrom)
                {
                    purchasedWaterFrom = value;
                    OnPropertyChanged(nameof(PurchasedWaterFrom));
                }
            }
        }
        public string OtherPurchasedWaterFrom
        {
            get => otherPurchasedWaterFrom;
            set
            {
                if (value != otherPurchasedWaterFrom)
                {
                    otherPurchasedWaterFrom = value;
                    OnPropertyChanged(nameof(OtherPurchasedWaterFrom));
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
        public string Comment
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

        #region Dropdown Lists
        public List<PickerToolHelper> WaterPurchasedUnitListOfOptions
        {
            get { return waterPurchasedUnitListOfOptions; }
            set
            {
                waterPurchasedUnitListOfOptions = value;
                OnPropertyChanged(nameof(WaterPurchasedUnitListOfOptions));
            }
        }

        public List<PickerToolHelper> PurchasedWaterFromListOfOptions
        {
            get { return purchasedWaterFromListOfOptions; }
            set
            {
                purchasedWaterFromListOfOptions = value;
                OnPropertyChanged(nameof(PurchasedWaterFromListOfOptions));
            }
        }

        private PickerToolHelper selectedWaterPurchasedUnit;

        public PickerToolHelper SelectedWaterPurchasedUnit
        {
            get { return selectedWaterPurchasedUnit; }
            set
            {
                if (selectedWaterPurchasedUnit != value)
                {
                    DisplayOtherWaterUnit = value?.TranslationRowKey == Constants.OTHER;
                    selectedWaterPurchasedUnit = value;
                    OnPropertyChanged(nameof(SelectedWaterPurchasedUnit));
                }
            }
        }

        private PickerToolHelper selectedPurchasedWaterFrom;

        public PickerToolHelper SelectedPurchasedWaterFrom
        {
            get { return selectedPurchasedWaterFrom; }
            set
            {
                if (selectedPurchasedWaterFrom != value)
                {
                    DisplayOtherPurchasedFrom = value?.TranslationRowKey == Constants.OTHER;
                    selectedPurchasedWaterFrom = value;
                    OnPropertyChanged(nameof(SelectedPurchasedWaterFrom));
                }
            }
        }
        #endregion

        #region Hidden Fields
        private bool displayOtherWaterUnit;
        private bool displayOtherPurchasedFrom;

        public bool DisplayOtherWaterUnit
        {
            get => displayOtherWaterUnit;
            set
            {
                if (displayOtherWaterUnit != value)
                {
                    displayOtherWaterUnit = value;
                    OnPropertyChanged(nameof(DisplayOtherWaterUnit));
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

        public WaterCostViewModel()
        {
            Date = DateTime.Now;
            DurationStart = DateTime.Now;
            DurationFinish = DateTime.Now;
            IsEditMode = true;
            CreationMode = true;

            SaveButtonClicked = new Command(SaveButtonCreateHousingItem);
            ResetButtonClicked = new Command(ResetButtonPressed);
            DeleteButtonClicked = new Command(DeleteItem);
            EditButtonClicked = new Command(EditItem);
            IsEditMode = true;
            IsCreationMode = !EditExistingMode;

            WaterCostTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(WaterCostTitleTranslation), User.UserLang);
            DateTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateTranslation), User.UserLang) + " *";

            WaterPurchasedTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(WaterPurchasedTranslation), User.UserLang);
            OtherWaterPurchasedTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherWaterPurchasedTranslation), User.UserLang);
            PurchasedWaterFromTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PurchasedWaterFromTranslation), User.UserLang);
            OtherPurchasedWaterFromTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherPurchasedWaterFromTranslation), User.UserLang);

            TotalCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TotalCostTranslation), User.UserLang) + " *";
            TransportationCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TransportationCostTranslation), User.UserLang) + " *";
            OtherCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherCostTranslation), User.UserLang);
            CommentTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CommentTranslation), User.UserLang);

            SaveTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SaveTranslation), User.UserLang);
            ResetTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ResetTranslation), User.UserLang);
            EditTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EditTranslation), User.UserLang);
            DeleteTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DeleteTranslation), User.UserLang);

            StartTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(StartTranslation), User.UserLang) + " *";
            FinishTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(FinishTranslation), User.UserLang) + " *";
            WaterDurationTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(WaterDurationTranslation), User.UserLang);

            PickerUnitTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerUnitTranslation), User.UserLang);
            PickerPurchasedFromTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerPurchasedFromTranslation), User.UserLang);
        }

        public void populatewithData(WaterCostItem item)
        {
            isEditMode = false;
            CreationMode = false;
            EditExistingMode = !CreationMode;

            _itemForEditing = item;

            Date = item.Date;
            WaterPurchased = item.WaterPurchased;
            WaterPurchasedUnit = item.WaterPurchasedUnit;
            OtherWaterPurchasedUnit = item.OtherWaterPurchasedUnit;
            PurchasedWaterFrom = item.PurchasedWaterFrom;
            OtherPurchasedWaterFrom = item.OtherPurchasedWaterFrom;
            TotalCosts = item.TotalCosts;
            TransportationCost = item.TransportationCost;
            OtherCosts = item.OtherCosts;
            Comment = item.Comment;
            DurationStart = item.DurationStart;
            DurationFinish = item.DurationFinish;
        }

        public void SetPickers()
        {
            if (EditExistingMode)
            {
                SelectedWaterPurchasedUnit = WaterPurchasedUnitListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.WaterPurchasedUnit).FirstOrDefault();
                SelectedPurchasedWaterFrom = PurchasedWaterFromListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.PurchasedWaterFrom).FirstOrDefault();
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
                _itemForEditing.WaterPurchased = WaterPurchased;
                _itemForEditing.WaterPurchasedUnit = SelectedWaterPurchasedUnit != null ? SelectedWaterPurchasedUnit.TranslationRowKey : null;
                _itemForEditing.OtherWaterPurchasedUnit = OtherWaterPurchasedUnit;
                _itemForEditing.PurchasedWaterFrom = SelectedPurchasedWaterFrom != null ? SelectedPurchasedWaterFrom.TranslationRowKey : null;
                _itemForEditing.OtherPurchasedWaterFrom = OtherPurchasedWaterFrom;
                _itemForEditing.TotalCosts = (double)TotalCosts;
                _itemForEditing.TransportationCost = (double)TransportationCost;
                _itemForEditing.OtherCosts = (double)OtherCosts;
                _itemForEditing.Comment = Comment;
                _itemForEditing.LastModified = DateTime.UtcNow;
                _itemForEditing.DurationStart = DurationStart;
                _itemForEditing.DurationFinish = DurationFinish;

                await repo.UpdateWaterCostItem(_itemForEditing);
                await Application.Current.MainPage.DisplayAlert("Updated", "Water cost record has been updated", "OK");
                await Shell.Current.Navigation.PopAsync();
            }
            else
            {
                var newWaterCost = new WaterCostItem
                {
                    Date = Date,
                    WaterPurchased = WaterPurchased,
                    WaterPurchasedUnit = SelectedWaterPurchasedUnit != null ? SelectedWaterPurchasedUnit.TranslationRowKey : null,
                    OtherWaterPurchasedUnit = OtherWaterPurchasedUnit,
                    PurchasedWaterFrom = SelectedPurchasedWaterFrom != null ? SelectedPurchasedWaterFrom.TranslationRowKey : null,
                    OtherPurchasedWaterFrom = OtherPurchasedWaterFrom,
                    TotalCosts = (double)TotalCosts,
                    TransportationCost = (double)TransportationCost,
                    OtherCosts = (double)OtherCosts,
                    Comment = Comment,
                    LastModified = DateTime.UtcNow,
                    CreatedBy = User.UserName,
                    PartitionKey = Constants.PartitionKeyWaterCostItem,
                    DurationStart = DurationStart,
                    DurationFinish = DurationFinish
                };
                try
                {
                    await repo.AddSingleWaterCostItem(newWaterCost);
                    await Application.Current.MainPage.DisplayAlert("Created", "Water record has been saved", "OK");
                    await Shell.Current.Navigation.PopAsync();
                }
                catch (Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", ex.InnerException.Message, "OK");
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
                    repo.DeleteWaterCostItem(_itemForEditing);
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
            WaterPurchased = null;
            WaterPurchasedUnit = null;
            SelectedWaterPurchasedUnit = null;
            OtherWaterPurchasedUnit = null;
            SelectedPurchasedWaterFrom = null;
            OtherWaterPurchasedUnit = null;
            TotalCosts = null;
            TransportationCost = null;
            OtherCosts = null;
            Comment = null;
        }

        public async Task PopulateDataDowns()
        {
            var WaterPurchasedUnitControlData = await repo.GetControlData(Constants.WATERPURCHASEDUNITTYPE);
            var PurchasedWaterFromControlData = await repo.GetControlData(Constants.PURCHASEDWATERFROMTYPE);

            WaterPurchasedUnitListOfOptions = LogicHelper.CreatePickerToolOption(WaterPurchasedUnitControlData, User.UserLang);
            PurchasedWaterFromListOfOptions = LogicHelper.CreatePickerToolOption(PurchasedWaterFromControlData, User.UserLang);

            if (!IsEditMode)
            {
                SelectedWaterPurchasedUnit = WaterPurchasedUnitListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.WaterPurchasedUnit).FirstOrDefault();
                selectedPurchasedWaterFrom = WaterPurchasedUnitListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.PurchasedWaterFrom).FirstOrDefault();
            }
        }

        private string ValidateSave()
        {
            try
            {
                StringBuilder returnString = new StringBuilder();
                if (Date == null) returnString.AppendLine("Date obtained not provided");
                if (DurationStart == null) returnString.AppendLine("Duration Start Not Provided");
                if (DurationFinish == null) returnString.AppendLine("Duration Finish Not Provided");
                if (TotalCosts == null) returnString.AppendLine("Total Cost Not Provided");
                if (TransportationCost == null) returnString.AppendLine("Transportation Cost Not Provided");
                if (DurationFinish < DurationStart) returnString.AppendLine("Duration Finish is before Duration Start");
                //if (OtherCosts == null) returnString.AppendLine("Other Cost Not Provided");

                if (SelectedWaterPurchasedUnit != null && SelectedWaterPurchasedUnit.TranslationRowKey == Constants.OTHER)
                {
                    if (string.IsNullOrWhiteSpace(OtherWaterPurchasedUnit)) returnString.AppendLine("Other Unit Not Provided");
                }

                if (SelectedPurchasedWaterFrom != null && SelectedPurchasedWaterFrom.TranslationRowKey == Constants.OTHER)
                {
                    if (string.IsNullOrWhiteSpace(OtherPurchasedWaterFrom)) returnString.AppendLine("Other Person Purchased From Not Provided");
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
