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

namespace PigTool.ViewModels
{
    public class PigSaleViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        bool isEditMode, isCreationMode;
        private bool editExistingMode;
        private DateTime date;
        private double? numberSold;
        private string? pigType;
        private string? otherPigType;
        private double? salePrice;
        private string? soldTo;
        private string? otherSoldTo;
        private double? brokerage;
        private double? transportationCost;
        private double? otherCosts;
        private string? comment;
        List<PickerToolHelper> pigTypeListOfOptions;
        List<PickerToolHelper> soldToListOfOptions;
        PigSaleItem _itemForEditing;

        //Button Clicks
        public Command SaveButtonClicked { get; }
        public Command ResetButtonClicked { get; }
        public Command DeleteButtonClicked { get; }
        public Command EditButtonClicked { get; }

        #region translations
        public string PigSaleTitleTranslation { get; set; }
        public string DateTranslation { get; set; }

        public string NumberSoldTranslation { get; set; }

        public string PigTypeTranslation { get; set; }
        public string OtherPigTypeTranslation { get; set; }
        public string SoldToTranslation { get; set; }
        public string OtherSoldToTranslation { get; set; }

        public string SalePriceTranslation { get; set; }
        public string BrokerageTranslation { get; set; }
        public string TransportationCostTranslation { get; set; }
        public string OtherCostTranslation { get; set; }
        public string CommentTranslation { get; set; }

        public string SaveTranslation { get; set; }
        public string ResetTranslation { get; set; }
        public string EditTranslation { get; set; }
        public string DeleteTranslation { get; set; }
        #endregion

        #region Pig Sale item fields
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
        public double? NumberSold
        {
            get => numberSold;
            set
            {
                if (value != numberSold)
                {
                    numberSold = value;
                    OnPropertyChanged(nameof(NumberSold));
                }
            }
        }
        public string? PigType
        {
            get => pigType;
            set
            {
                if (value != pigType)
                {
                    pigType = value;
                    OnPropertyChanged(nameof(PigType));
                }
            }
        }
        public string? OtherPigType
        {
            get => otherPigType;
            set
            {
                if (value != otherPigType)
                {
                    otherPigType = value;
                    OnPropertyChanged(nameof(OtherPigType));
                }
            }
        }
        public string? SoldTo
        {
            get => soldTo;
            set
            {
                if (value != soldTo)
                {
                    soldTo = value;
                    OnPropertyChanged(nameof(SoldTo));
                }
            }
        }
        public string? OtherSoldTo
        {
            get => otherSoldTo;
            set
            {
                if (value != otherSoldTo)
                {
                    otherSoldTo = value;
                    OnPropertyChanged(nameof(OtherSoldTo));
                }
            }
        }
        public double? SalePrice
        {
            get => salePrice;
            set
            {
                if (value != salePrice)
                {
                    salePrice = value;
                    OnPropertyChanged(nameof(SalePrice));
                }
            }
        }
        public double? Brokerage
        {
            get => brokerage;
            set
            {
                if (value != brokerage)
                {
                    brokerage = value;
                    OnPropertyChanged(nameof(Brokerage));
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

        #endregion

        #region Dropdown Lists
        public List<PickerToolHelper> PigTypeListOfOptions
        {
            get { return pigTypeListOfOptions; }
            set
            {
                pigTypeListOfOptions = value;
                OnPropertyChanged(nameof(PigTypeListOfOptions));
            }
        }

        public List<PickerToolHelper> SoldToListOfOptions
        {
            get { return soldToListOfOptions; }
            set
            {
                soldToListOfOptions = value;
                OnPropertyChanged(nameof(SoldToListOfOptions));
            }
        }

        private PickerToolHelper selectedPigType;

        public PickerToolHelper SelectedPigType
        {
            get { return selectedPigType; }
            set
            {
                if (selectedPigType != value)
                {
                    DisplayOtherPigType = value?.TranslationRowKey == Constants.OTHER;
                    selectedPigType = value;
                    OnPropertyChanged(nameof(SelectedPigType));
                }
            }
        }

        private PickerToolHelper selectedSoldTo;

        public PickerToolHelper SelectedSoldTo
        {
            get { return selectedSoldTo; }
            set
            {
                if (selectedSoldTo != value)
                {
                    DisplayOtherSoldTo = value?.TranslationRowKey == Constants.OTHER;
                    selectedSoldTo = value;
                    OnPropertyChanged(nameof(SelectedSoldTo));
                }
            }
        }
        #endregion

        #region Hidden Fields
        private bool displayOtherPigType;
        private bool displayOtherSoldTo;

        public bool DisplayOtherPigType
        {
            get => displayOtherPigType;
            set
            {
                if (displayOtherPigType != value)
                {
                    displayOtherPigType = value;
                    OnPropertyChanged(nameof(DisplayOtherPigType));
                }
            }
        }
        public bool DisplayOtherSoldTo
        {
            get => displayOtherSoldTo;
            set
            {
                if (displayOtherSoldTo != value)
                {
                    displayOtherSoldTo = value;
                    OnPropertyChanged(nameof(DisplayOtherSoldTo));
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

        public PigSaleViewModel()
        {
            Date = DateTime.Now;

            IsEditMode = true;
            CreationMode = true;

            SaveButtonClicked = (new Command(SaveButtonCreateHousingItem));
            ResetButtonClicked = new Command(ResetButtonPressed);
            DeleteButtonClicked = new Command(DeleteItem);
            EditButtonClicked = new Command(EditItem);
            IsEditMode = true;
            IsCreationMode = !EditExistingMode;

            PigSaleTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PigSaleTitleTranslation), User.UserLang);
            DateTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateTranslation), User.UserLang) + " *";
            
            NumberSoldTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(NumberSoldTranslation), User.UserLang);

            PigTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PigTypeTranslation), User.UserLang);
            OtherPigTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherPigTypeTranslation), User.UserLang);
            SoldToTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SoldToTranslation), User.UserLang);
            OtherSoldToTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherSoldToTranslation), User.UserLang);

            SalePriceTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SalePriceTranslation), User.UserLang) + " *";
            BrokerageTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(BrokerageTranslation), User.UserLang) + " *";
            TransportationCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TransportationCostTranslation), User.UserLang) + " *";
            OtherCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherCostTranslation), User.UserLang) + " *";
            CommentTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CommentTranslation), User.UserLang);
            
            SaveTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SaveTranslation), User.UserLang);
            ResetTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ResetTranslation), User.UserLang);
            EditTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EditTranslation), User.UserLang);
            DeleteTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DeleteTranslation), User.UserLang);
        }

        public void populatewithData(PigSaleItem item)
        {
            isEditMode = false;
            CreationMode = false;
            EditExistingMode = !CreationMode;

            _itemForEditing = item;

            Date = item.Date;
            NumberSold = item.NumberSold;
            PigType = item.PigType;
            OtherPigType = item.OtherPigType;
            SoldTo = item.SoldTo;
            OtherSoldTo = item.OtherSoldTo;
            SalePrice = item.SalePrice;
            Brokerage = item.Brokerage;
            TransportationCost = item.TransportationCost;
            OtherCosts = item.OtherCosts; 
            Comment = item.Comment;
        }

        public void SetPickers()
        {
            if (EditExistingMode)
            {
                SelectedPigType = PigTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.PigType).FirstOrDefault();
                SelectedSoldTo = SoldToListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.SoldTo).FirstOrDefault();
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
                _itemForEditing.NumberSold = (int)NumberSold;
                _itemForEditing.PigType = SelectedPigType != null ? SelectedPigType.TranslationRowKey : null;
                _itemForEditing.OtherPigType = OtherPigType;
                _itemForEditing.SoldTo = SelectedSoldTo != null ? SelectedSoldTo.TranslationRowKey : null;
                _itemForEditing.OtherSoldTo = OtherSoldTo;
                _itemForEditing.SalePrice = (double)SalePrice;
                _itemForEditing.Brokerage = (double)Brokerage;
                _itemForEditing.TransportationCost = (double)TransportationCost;
                _itemForEditing.OtherCosts = (double)OtherCosts;
                _itemForEditing.Comment = Comment;
                _itemForEditing.LastModified = DateTime.UtcNow;

                await repo.UpdatePigSaleItem(_itemForEditing);
                await Application.Current.MainPage.DisplayAlert("Updated", "Pig sale record has been updated", "OK");
                await Shell.Current.Navigation.PopAsync();
            }
            else
            {
                var newPigSale = new PigSaleItem
                {
                    Date = Date,
                    NumberSold = (int)NumberSold,
                    PigType = SelectedPigType != null ? SelectedPigType.TranslationRowKey : null,
                    OtherPigType = OtherPigType,
                    SoldTo = SelectedSoldTo != null ? SelectedSoldTo.TranslationRowKey : null,
                    OtherSoldTo = OtherSoldTo,
                    SalePrice = (double)SalePrice,
                    Brokerage = (double)Brokerage,
                    TransportationCost = (double)TransportationCost,
                    OtherCosts = (double)OtherCosts,
                    Comment = Comment,
                    LastModified = DateTime.UtcNow,
                    CreatedBy = User.UserName,
                    PartitionKey = Constants.PartitionKeyPigSaleItem,
                };

                await repo.AddSinglePigSaleItem(newPigSale);
                await Application.Current.MainPage.DisplayAlert("Created", "Pig sale has been saved", "OK");
            }
        }

        private async void DeleteItem(object obj)
        {
            if (EditExistingMode)
            {
                var confirmDelete = await Application.Current.MainPage.DisplayAlert("Deletion Confirmation", "Are you sure you want to delete this item", "OK", "Cancel");
                if (confirmDelete)
                {
                    repo.DeletePigSaleItem(_itemForEditing);
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
            NumberSold = null;
            PigType = null;
            SelectedPigType = null;
            OtherPigType = null;
            SelectedSoldTo = null;
            OtherSoldTo = null;
            SalePrice = null;
            Brokerage = null;
            TransportationCost = null;
            OtherCosts = null;
            Comment = null;
        }

        public async Task PopulateDataDowns()
        {
            var PigTypeControlData = await repo.GetControlData(Constants.PIGTYPE);
            var SoldToControlData = await repo.GetControlData(Constants.SOLDTOTYPE);

            PigTypeListOfOptions = LogicHelper.CreatePickerToolOption(PigTypeControlData, User.UserLang);
            SoldToListOfOptions = LogicHelper.CreatePickerToolOption(SoldToControlData, User.UserLang);

            if (!IsEditMode)
            {
                SelectedPigType = PigTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.PigType).FirstOrDefault();
                selectedSoldTo = PigTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.SoldTo).FirstOrDefault();
            }
        }

        private string ValidateSave()
        {
            try
            {
                StringBuilder returnString = new StringBuilder();
                if (Date == null) returnString.AppendLine("Date obtained not provided");
                if (SalePrice == null) returnString.AppendLine("Sale Price Not Provided");
                if (Brokerage == null) returnString.AppendLine("Brokerage Not Provided");
                if (TransportationCost == null) returnString.AppendLine("Transportation Cost Not Provided");
                if (OtherCosts == null) returnString.AppendLine("Other Cost Not Provided");

                
                if (SelectedPigType != null && SelectedPigType.TranslationRowKey == Constants.OTHER)
                {
                    if (string.IsNullOrWhiteSpace(OtherPigType)) returnString.AppendLine("Other Pig Type Not Provided");
                }

                if (SelectedSoldTo != null && SelectedSoldTo.TranslationRowKey == Constants.OTHER)
                {
                    if (string.IsNullOrWhiteSpace(OtherSoldTo)) returnString.AppendLine("Other Sold To Not Provided");
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
