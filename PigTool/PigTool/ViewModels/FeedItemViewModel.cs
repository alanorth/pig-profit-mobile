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
        //Button Clicks
        public Command SaveButtonClicked { get; }
        public Command ResetButtonClicked { get; }
        public Command DeleteButtonClicked { get; }
        public Command SwitchToEditMode { get; }

        //height of hidden grid members
        int otherFeedHeight, otherPurchaseHeight, otherUnitTypeHeight;
        //internal dropdown selections
        PickerToolHelper selectedPurchaseUnitType, selectedPurchaseFrom, selectedFoodType;
        //Internal Lists for pickers
        List<PickerToolHelper> feedTypeListOfOptions, unitTypeListOfOptions, purchaseTypeListOfOptions;

        bool isEditMode, isCreationMode;
        private bool editExistingMode;
        private int? amountPurchased;
        private string otherAmountPurchaseUnit;
        private int? cost;
        private int? transportationCost;
        private string comment;

        public int OtherFeedHeight
        {
            get { return otherFeedHeight; }
            set
            {
                if (otherFeedHeight != value)
                {
                    otherFeedHeight = value;
                    OnPropertyChanged(nameof(OtherFeedHeight));
                }
            }
        }

        public int UnitTypeHeight
        {
            get { return otherUnitTypeHeight; }
            set
            {
                if (otherUnitTypeHeight != value)
                {
                    otherUnitTypeHeight = value;
                    OnPropertyChanged(nameof(UnitTypeHeight));
                }
            }
        }

        public int OtherPurchaseHeight
        {
            get { return otherPurchaseHeight; }
            set
            {
                if (otherPurchaseHeight != value)
                {
                    otherPurchaseHeight = value;
                    OnPropertyChanged(nameof(OtherPurchaseHeight));
                }
            }
        }

        public PickerToolHelper SelectedFeedType
        {
            get { return selectedFoodType; }
            set
            {
                if (value != null && value.CompareTo(selectedFoodType) == 0)
                {
                    if (value.TranslationRowKey == SC.OTHER)
                    {
                        OtherFeedHeight = 50;
                    }
                    selectedFoodType = value;
                    OnPropertyChanged(nameof(SelectedFeedType));
                }
                else if (value == null)
                {
                    selectedFoodType = value;
                }
            }

        }
        public PickerToolHelper SelectedPurchaseUnitType
        {
            get { return selectedPurchaseUnitType; }
            set
            {
                if (value != null && value.CompareTo(selectedPurchaseUnitType) == 0)
                {
                    if (value.TranslationRowKey == "Other")
                    {
                        UnitTypeHeight = 50;
                    }
                    selectedPurchaseUnitType = value;
                    OnPropertyChanged(nameof(SelectedPurchaseUnitType));
                }
                else if (value == null)
                {
                    selectedPurchaseUnitType = value;
                }
            }
        }
        public PickerToolHelper SelectedPurchasedFrom
        {
            get
            {
                return selectedPurchaseFrom;
            }
            set
            {
                if (selectedPurchaseFrom != value)
                {
                    if (value != selectedPurchaseFrom)
                    {
                        selectedPurchaseFrom = value;
                        OnPropertyChanged(nameof(SelectedPurchasedFrom));
                    }
                }
            }
        }

        public List<PickerToolHelper> FeedTypeListOfOptions
        {

            get { return feedTypeListOfOptions; }
            set
            {
                feedTypeListOfOptions = value;
                OnPropertyChanged(nameof(FeedTypeListOfOptions));
            }
        }
        public List<PickerToolHelper> UnitTypeListOfOptions
        {

            get { return unitTypeListOfOptions; }
            set
            {
                unitTypeListOfOptions = value;
                OnPropertyChanged(nameof(UnitTypeListOfOptions));
            }
        }
        public List<PickerToolHelper> PurchaseTypeListOfOptions
        {

            get { return purchaseTypeListOfOptions; }
            set
            {
                purchaseTypeListOfOptions = value;
                OnPropertyChanged(nameof(PurchaseTypeListOfOptions));
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
        FeedItem SelectedFeedItem { get; set; }
        public DateTime DateObtained { get; set; }
        public string OtherFeedType { get; set; }
        public int? AmountPurchased { get => amountPurchased; set { amountPurchased = value; OnPropertyChanged(nameof(AmountPurchased)); } }
        public string OtherAmountPurchaseUnit { get => otherAmountPurchaseUnit; set { otherAmountPurchaseUnit = value; OnPropertyChanged(nameof(OtherAmountPurchaseUnit)); } }
        public int? Cost { get => cost; set { cost = value; OnPropertyChanged(nameof(Cost)); } }
        public int? TransportationCost { get => transportationCost; set { transportationCost = value; OnPropertyChanged(nameof(TransportationCost)); } }
        public string Comment { get => comment; set { comment = value; OnPropertyChanged(nameof(Comment)); } }

        //Translated Title Values
        public string AddFeedItemTrans { get; set; }
        public string DateObtainedTrans { get; set; }
        public string FeedTypeTrans { get; set; }
        public string OtherFeedTypeTrans { get; set; }
        public string AmountPurchasedTrans { get; set; }
        public string UnitTrans { get; set; }
        public string OtherAmountPurchaseTrans { get; set; }
        public string CostTrans { get; set; }
        public string TransportCostTrans { get; set; }
        public string PurchasedFrom { get; set; }
        public string CommentTrans { get; set; }
        public string SaveTranslation { get; set; }
        public string ResetTranslation { get; set; }
        public string EditTranslation { get; set; }
        public string DeleteTranslation { get; set; }
        private FeedItem storedFeedItemd { get; set; }
        public bool EditExistingMode { get => editExistingMode; set { editExistingMode = value; OnPropertyChanged(nameof(EditExistingMode)); } }

        public FeedItemViewModel()
        {
            PopulateDefaultValues();

            SaveButtonClicked = (new Command(SaveButtonCreateFeedItem));
            ResetButtonClicked = new Command<object>(async (o) => await ResetButtonPressed(o));
            DeleteButtonClicked = new Command(DeleteItem);
            SwitchToEditMode = new Command(EditItem);
            IsEditMode = true;
            IsCreationMode = !EditExistingMode;

            AddFeedItemTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(AddFeedItemTrans), User.UserLang);
            DateObtainedTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateObtainedTrans), User.UserLang);
            FeedTypeTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(FeedTypeTrans), User.UserLang);
            OtherFeedTypeTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherFeedTypeTrans), User.UserLang);
            AmountPurchasedTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(AmountPurchasedTrans), User.UserLang);
            UnitTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(UnitTrans), User.UserLang);
            OtherAmountPurchaseTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherAmountPurchaseTrans), User.UserLang);
            CostTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CostTrans), User.UserLang);
            TransportCostTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TransportCostTrans), User.UserLang);
            PurchasedFrom = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PurchasedFrom), User.UserLang);
            CommentTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CommentTrans), User.UserLang);
            SaveTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SaveTranslation), User.UserLang);
            ResetTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ResetTranslation), User.UserLang);
            EditTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EditTranslation), User.UserLang);
            DeleteTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DeleteTranslation), User.UserLang);
        }

        private void PopulateDefaultValues()
        {
            OtherPurchaseHeight = 0;
            UnitTypeHeight = 0;
            DateObtained = DateTime.Now;
            SelectedFeedType = null;
            OtherFeedType = null;
            AmountPurchased = null;
            SelectedPurchaseUnitType = null;
            OtherAmountPurchaseUnit = null;
            Cost = null;
            TransportationCost = null;
            SelectedPurchasedFrom = null;
            Comment = null;
        }

        public void PopulateSelectedFeedItem(FeedItem feed)
        {
            EditExistingMode = true;
            IsEditMode = false;
            IsCreationMode = !EditExistingMode;
            var selectedItem = feed;
            storedFeedItemd = feed;

            // populate string feilds
            DateObtained = selectedItem.DateObtained;
            AmountPurchased = selectedItem.AmountPurchased;
            OtherFeedType = selectedItem.OtherFeedType;
            OtherAmountPurchaseUnit = selectedItem.OtherAmountPurchaseUnit;
            Cost = selectedItem.Cost;
            TransportationCost = selectedItem.TransportationCost;
            Comment = selectedItem.Comment;

            //if other is selected reveral other options and populate
            OtherPurchaseHeight = 0;
            UnitTypeHeight = 0;

        }

        public async Task PopulateListOfOptions()
        {
            var FeedTypeControlData = await repo.GetControlData(SC.FEEDTYPE);
            var UnitTypeControlData = await repo.GetControlData(SC.UNITTYPE);
            var PurchaseTypeControlData = await repo.GetControlData(SC.PURCHASETYPE);

            FeedTypeListOfOptions = LogicHelper.CreatePickerToolOption(FeedTypeControlData, User.UserLang);
            UnitTypeListOfOptions = LogicHelper.CreatePickerToolOption(UnitTypeControlData, User.UserLang);
            PurchaseTypeListOfOptions = LogicHelper.CreatePickerToolOption(PurchaseTypeControlData, User.UserLang);

            if (EditExistingMode)
            {
                //Populate the drop downs
                var feedType = FeedTypeListOfOptions.Where(x => x.TranslationRowKey == storedFeedItemd.FeedType).FirstOrDefault();
                var purchaseFrom = PurchaseTypeListOfOptions.Where(x => x.TranslationRowKey == storedFeedItemd.PurchasedFrom).FirstOrDefault();
                var unitType = UnitTypeListOfOptions.Where(x => x.TranslationRowKey == storedFeedItemd.AmountPurchasedUnit).FirstOrDefault();

                SelectedFeedType = feedType;
                SelectedPurchasedFrom = purchaseFrom;
                SelectedPurchaseUnitType = unitType;
            }
        }

        private async void SaveButtonCreateFeedItem(object obj)
        {
            var LogicText = ValidateSave();

            if (!string.IsNullOrWhiteSpace(LogicText))
            {
                return;
            }
            if (!EditExistingMode)
            {
                var feedItem = new FeedItem
                {
                    DateObtained = DateObtained,
                    FeedType = SelectedFeedType.TranslationRowKey,
                    OtherFeedType = OtherFeedType,
                    AmountPurchased = AmountPurchased ?? (int)AmountPurchased,
                    AmountPurchasedUnit = SelectedPurchaseUnitType.TranslationRowKey,
                    OtherAmountPurchaseUnit = OtherAmountPurchaseUnit,
                    Cost = Cost ?? (int)Cost,
                    TransportationCost = TransportationCost ?? (int)TransportationCost,
                    PurchasedFrom = SelectedPurchasedFrom.TranslationRowKey,
                    Comment = Comment,
                    CreatedBy = User.UserName

                };
                await repo.AddSingleFeedItem(feedItem);
                await Application.Current.MainPage.DisplayAlert("Save Feed Item", "Feed Item Save", "OK");
                PopulateDefaultValues();
            }
            else
            {
                storedFeedItemd.DateObtained = DateObtained;
                storedFeedItemd.FeedType = SelectedFeedType.TranslationRowKey;
                storedFeedItemd.OtherFeedType = OtherFeedType;
                storedFeedItemd.AmountPurchased = AmountPurchased ?? (int)AmountPurchased;
                storedFeedItemd.AmountPurchasedUnit = SelectedPurchaseUnitType.TranslationRowKey;
                storedFeedItemd.OtherAmountPurchaseUnit = OtherAmountPurchaseUnit;
                storedFeedItemd.Cost = Cost ?? (int)Cost;
                storedFeedItemd.TransportationCost = TransportationCost ?? (int)TransportationCost;
                storedFeedItemd.PurchasedFrom = SelectedPurchasedFrom.TranslationRowKey;
                storedFeedItemd.Comment = Comment;
                storedFeedItemd.CreatedBy = User.UserName;

                await repo.UpdateFeedItem(storedFeedItemd);
                await Application.Current.MainPage.DisplayAlert("Updated Feed Item", "Feed Item Updated", "OK");
                await Shell.Current.Navigation.PopAsync();
            }


        }

        private async void DeleteItem()
        {
            if (EditExistingMode)
            {
                var confirmDelete = await Application.Current.MainPage.DisplayAlert("Deletion Confimration", "Are you sure you want to Delete this item", "OK", "Cancel");
                if (confirmDelete)
                {
                    repo.DeleteFeedItem(storedFeedItemd);
                    await Shell.Current.Navigation.PopAsync();
                }
            }
        }

        private void EditItem()
        {
            if (EditExistingMode)
            {
                IsEditMode = true;
            }
        }


        private string ValidateSave()
        {
            StringBuilder returnString = new StringBuilder();
            returnString.AppendLine(DateObtained == null ? "Date obtained not provided" : "");
            returnString.AppendLine(SelectedFeedType == null ? "Selected Feed Type not Provided" : "");
            returnString.AppendLine(AmountPurchased == null ? " Amount Purchased Not Provided" : "");
            returnString.AppendLine(Cost == null ? "Cost Not Provided" : "");
            returnString.AppendLine(TransportationCost == null ? "Transport Cost Not Provided" : "");
            returnString.AppendLine(PurchasedFrom == null ? "Purchase From Not Provided" : "");

            if (returnString.Length > 0) return returnString.ToString();


            if (SelectedFeedType.TranslationRowKey == SC.OTHER)
            {
                returnString.Append(string.IsNullOrWhiteSpace(OtherFeedType) ? "Other Feed Type Not Provided" : "");
            }

            if (SelectedPurchaseUnitType.TranslationRowKey == SC.OTHER)
            {
                returnString.Append(string.IsNullOrWhiteSpace(OtherAmountPurchaseUnit) ? "Other Unit Type Not Provided" : "");
            }

            return returnString.ToString();
        }

        public FeedItemViewModel(string Item, bool editMode)
        {

        }

        private async Task ResetButtonPressed(object obj)
        {
            PopulateDefaultValues();
        }

    }
}
