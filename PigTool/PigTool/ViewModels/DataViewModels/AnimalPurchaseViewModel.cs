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

namespace PigTool.ViewModels.DataViewModels
{
    public class AnimalPurchaseViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        bool isEditMode, isCreationMode;
        private bool editExistingMode;
        private DateTime date;
        private string animalType { get; set; }
        private string otherAnimalType { get; set; }
        private int? numberPurchased { get; set; }
        private double? totalCosts { get; set; }
        private string animalPurchasedFrom { get; set; }
        private string otherAnimalPurchasedFrom { get; set; }
        private double? transportationCost { get; set; }
        private double? otherCosts { get; set; }
        private string comment { get; set; }
        List<PickerToolHelper> animalTypeListOfOptions;
        List<PickerToolHelper> animalPurchasedFromListOfOptions;
        AnimalPurchaseItem _itemForEditing;

        //Button Clicks
        public Command SaveButtonClicked { get; }
        public Command ResetButtonClicked { get; }
        public Command DeleteButtonClicked { get; }
        public Command EditButtonClicked { get; }

        #region translations
        public string AnimalPurchaseTitleTranslation { get; set; }
        public string DateTranslation { get; set; }

        public string AnimalTypeTranslation { get; set; }
        public string OtherAnimalTypeTranslation { get; set; }
        public string AnimalPurchasedFromTranslation { get; set; }
        public string OtherAnimalPurchasedTranslation { get; set; }

        public string NumberPurchasedTranslation { get; set; }

        public string TotalAnimalCostsTranslation { get; set; }
        public string TransportationCostTranslation { get; set; }
        public string OtherCostTranslation { get; set; }
        public string CommentTranslation { get; set; }

        public string SaveTranslation { get; set; }
        public string ResetTranslation { get; set; }
        public string EditTranslation { get; set; }
        public string DeleteTranslation { get; set; }

        public string PickerAnimalTypeTranslation { get; set; }
        public string PickerPurchasedFromTranslation { get; set; }
        #endregion

        #region Animal purchase item fields
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
        public string AnimalType
        {
            get => animalType;
            set
            {
                if (value != animalType)
                {
                    animalType = value;
                    OnPropertyChanged(nameof(AnimalType));
                }
            }
        }
        public string OtherAnimalType
        {
            get => otherAnimalType;
            set
            {
                if (value != otherAnimalType)
                {
                    otherAnimalType = value;
                    OnPropertyChanged(nameof(OtherAnimalType));
                }
            }
        }
        public int? NumberPurchased
        {
            get => numberPurchased;
            set
            {
                if (value != numberPurchased)
                {
                    numberPurchased = value;
                    OnPropertyChanged(nameof(NumberPurchased));
                }
            }
        }
        public string AnimalPurchasedFrom
        {
            get => animalPurchasedFrom;
            set
            {
                if (value != animalPurchasedFrom)
                {
                    animalPurchasedFrom = value;
                    OnPropertyChanged(nameof(AnimalPurchasedFrom));
                }
            }
        }
        public string OtherAnimalPurchasedFrom
        {
            get => otherAnimalPurchasedFrom;
            set
            {
                if (value != otherAnimalPurchasedFrom)
                {
                    otherAnimalPurchasedFrom = value;
                    OnPropertyChanged(nameof(OtherAnimalPurchasedFrom));
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
        public List<PickerToolHelper> AnimalTypeListOfOptions
        {
            get { return animalTypeListOfOptions; }
            set
            {
                animalTypeListOfOptions = value;
                OnPropertyChanged(nameof(AnimalTypeListOfOptions));
            }
        }

        public List<PickerToolHelper> AnimalPurchasedFromListOfOptions
        {
            get { return animalPurchasedFromListOfOptions; }
            set
            {
                animalPurchasedFromListOfOptions = value;
                OnPropertyChanged(nameof(AnimalPurchasedFromListOfOptions));
            }
        }

        private PickerToolHelper selectedAnimalType;

        public PickerToolHelper SelectedAnimalType
        {
            get { return selectedAnimalType; }
            set
            {
                if (selectedAnimalType != value)
                {
                    DisplayOtherAnimalType = value?.TranslationRowKey == Constants.OTHER;
                    selectedAnimalType = value;
                    OnPropertyChanged(nameof(SelectedAnimalType));
                }
            }
        }

        private PickerToolHelper selectedAnimalPurchasedFrom;

        public PickerToolHelper SelectedAnimalPurchasedFrom
        {
            get { return selectedAnimalPurchasedFrom; }
            set
            {
                if (selectedAnimalPurchasedFrom != value)
                {
                    DisplayOtherAnimalPurchasedFrom = value?.TranslationRowKey == Constants.OTHER;
                    selectedAnimalPurchasedFrom = value;
                    OnPropertyChanged(nameof(SelectedAnimalPurchasedFrom));
                }
            }
        }
        #endregion

        #region Hidden Fields
        private bool displayOtherAnimalType;
        private bool displayOtherAnimalPurchasedFrom;

        public bool DisplayOtherAnimalType
        {
            get => displayOtherAnimalType;
            set
            {
                if (displayOtherAnimalType != value)
                {
                    displayOtherAnimalType = value;
                    OnPropertyChanged(nameof(DisplayOtherAnimalType));
                }
            }
        }
        public bool DisplayOtherAnimalPurchasedFrom
        {
            get => displayOtherAnimalPurchasedFrom;
            set
            {
                if (displayOtherAnimalPurchasedFrom != value)
                {
                    displayOtherAnimalPurchasedFrom = value;
                    OnPropertyChanged(nameof(DisplayOtherAnimalPurchasedFrom));
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

        public AnimalPurchaseViewModel()
        {
            Date = DateTime.Now;

            IsEditMode = true;
            CreationMode = true;

            SaveButtonClicked = new Command(SaveButtonCreateHousingItem);
            ResetButtonClicked = new Command(ResetButtonPressed);
            DeleteButtonClicked = new Command(DeleteItem);
            EditButtonClicked = new Command(EditItem);
            IsEditMode = true;
            IsCreationMode = !EditExistingMode;

            AnimalPurchaseTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(AnimalPurchaseTitleTranslation), User.UserLang);
            DateTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateTranslation), User.UserLang) + " *";

            AnimalTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(AnimalTypeTranslation), User.UserLang);
            OtherAnimalTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherAnimalTypeTranslation), User.UserLang);
            AnimalPurchasedFromTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(AnimalPurchasedFromTranslation), User.UserLang);
            OtherAnimalPurchasedTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherAnimalPurchasedTranslation), User.UserLang);

            NumberPurchasedTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(NumberPurchasedTranslation), User.UserLang);

            TotalAnimalCostsTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TotalAnimalCostsTranslation), User.UserLang) + " *";
            TransportationCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TransportationCostTranslation), User.UserLang) + " *";
            OtherCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherCostTranslation), User.UserLang);
            CommentTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CommentTranslation), User.UserLang);

            SaveTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SaveTranslation), User.UserLang);
            ResetTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ResetTranslation), User.UserLang);
            EditTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EditTranslation), User.UserLang);
            DeleteTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DeleteTranslation), User.UserLang);

            PickerAnimalTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerAnimalTypeTranslation), User.UserLang);
            PickerPurchasedFromTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerPurchasedFromTranslation), User.UserLang);
        }

        public void populatewithData(AnimalPurchaseItem item)
        {
            isEditMode = false;
            CreationMode = false;
            EditExistingMode = !CreationMode;

            _itemForEditing = item;

            Date = item.Date;
            AnimalType = item.AnimalType;
            OtherAnimalType = item.OtherAnimalType;
            NumberPurchased = item.NumberPurchased;
            animalPurchasedFrom = item.AnimalPurchasedFrom;
            OtherAnimalPurchasedFrom = item.OtherAnimalPurchasedFrom;
            TotalCosts = item.TotalCosts;
            TransportationCost = item.TransportationCost;
            OtherCosts = item.OtherCosts;
            Comment = item.Comment;
        }

        public void SetPickers()
        {
            if (EditExistingMode)
            {
                SelectedAnimalType = AnimalTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.AnimalType).FirstOrDefault();
                SelectedAnimalPurchasedFrom = AnimalPurchasedFromListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.AnimalPurchasedFrom).FirstOrDefault();
            }
        }

        private async void SaveButtonCreateHousingItem(object obj)
        {
            var valid = ValidateSave();

            if (!string.IsNullOrWhiteSpace(valid))
            {
                await Application.Current.MainPage.DisplayAlert(Error, valid, OK);
                return;
            }

            if (_itemForEditing != null)
            {

                _itemForEditing.Date = Date;
                _itemForEditing.AnimalType = SelectedAnimalType != null ? SelectedAnimalType.TranslationRowKey : null;
                _itemForEditing.OtherAnimalType = OtherAnimalType;
                _itemForEditing.NumberPurchased = NumberPurchased;
                _itemForEditing.AnimalPurchasedFrom = SelectedAnimalPurchasedFrom != null ? SelectedAnimalPurchasedFrom.TranslationRowKey : null;
                _itemForEditing.OtherAnimalPurchasedFrom = OtherAnimalPurchasedFrom;
                _itemForEditing.TotalCosts = (double)TotalCosts;
                _itemForEditing.TransportationCost = (double)TransportationCost;
                _itemForEditing.OtherCosts = OtherCosts;
                _itemForEditing.Comment = Comment;
                _itemForEditing.LastModified = DateTime.UtcNow;

                await repo.UpdateAnimalPurchaseItem(_itemForEditing);
                await Application.Current.MainPage.DisplayAlert(Updated, LogicHelper.GetTranslationFromStore(TranslationStore, "AnimalUpdated", User.UserLang), OK);
                await Shell.Current.Navigation.PopAsync();
            }
            else
            {
                var newAnimalPurchase = new AnimalPurchaseItem
                {
                    Date = Date,
                    AnimalType = SelectedAnimalType != null ? SelectedAnimalType.TranslationRowKey : null,
                    OtherAnimalType = OtherAnimalType,
                    NumberPurchased = NumberPurchased,
                    AnimalPurchasedFrom = SelectedAnimalPurchasedFrom != null ? SelectedAnimalPurchasedFrom.TranslationRowKey : null,
                    OtherAnimalPurchasedFrom = OtherAnimalPurchasedFrom,
                    TotalCosts = (double)TotalCosts,
                    TransportationCost = (double)TransportationCost,
                    OtherCosts = OtherCosts,
                    Comment = Comment,
                    LastModified = DateTime.UtcNow,
                    CreatedBy = User.UserName,
                    PartitionKey = Constants.PartitionKeyAnimalPurchaseItem
                };
                try
                {
                    await repo.AddSingleAnimalPurchaseItem(newAnimalPurchase);
                    await Application.Current.MainPage.DisplayAlert(Created, LogicHelper.GetTranslationFromStore(TranslationStore, "AnimalSaved", User.UserLang), OK);
                    await Shell.Current.Navigation.PopAsync();
                }
                catch (Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert(Error, ex.InnerException.Message, OK);
                }
            }
        }

        private async void DeleteItem(object obj)
        {
            if (EditExistingMode)
            {
                var confirmDelete = await Application.Current.MainPage.DisplayAlert(DeleteConfirmation, DeleteVerify, OK, Cancel);
                if (confirmDelete)
                {
                    repo.DeleteAnimalPurchaseItem(_itemForEditing);
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
            AnimalType = null;
            OtherAnimalType = null;
            SelectedAnimalType = null;
            NumberPurchased = null;
            SelectedAnimalPurchasedFrom = null;
            OtherAnimalPurchasedFrom = null;
            TotalCosts = null;
            TransportationCost = null;
            OtherCosts = null;
            Comment = null;
        }

        public async Task PopulateDataDowns()
        {
            var AnimalTypeControlData = await repo.GetControlData(Constants.ANIMALTYPE);
            var AnimalPurchasedromControlData = await repo.GetControlData(Constants.ANIMALPURCHASEDFROMTYPE);

            AnimalTypeListOfOptions = LogicHelper.CreatePickerToolOption(AnimalTypeControlData, User.UserLang);
            AnimalPurchasedFromListOfOptions = LogicHelper.CreatePickerToolOption(AnimalPurchasedromControlData, User.UserLang);

            if (!IsEditMode)
            {
                SelectedAnimalType = AnimalTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.AnimalType).FirstOrDefault();
                SelectedAnimalPurchasedFrom = AnimalPurchasedFromListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.AnimalPurchasedFrom).FirstOrDefault();
            }
        }

        private string ValidateSave()
        {
            try
            {
                StringBuilder returnString = new StringBuilder();
                if (Date == null) returnString.AppendLine(LogicHelper.GetTranslationFromStore(TranslationStore, Constants.NoDate, User.UserLang));
                if (TotalCosts == null) returnString.AppendLine(LogicHelper.GetTranslationFromStore(TranslationStore, Constants.NoTotalCost, User.UserLang));
                if (TransportationCost == null) returnString.AppendLine(LogicHelper.GetTranslationFromStore(TranslationStore, Constants.NoTransportationCost, User.UserLang));
                //if (OtherCosts == null) returnString.AppendLine("Other Cost Not Provided");


                if (SelectedAnimalType != null && SelectedAnimalType.TranslationRowKey == Constants.OTHER)
                {
                    if (string.IsNullOrWhiteSpace(OtherAnimalType))  returnString.AppendLine(LogicHelper.GetTranslationFromStore(TranslationStore, Constants.NoAnimalType, User.UserLang));
                }

                if (SelectedAnimalPurchasedFrom != null && SelectedAnimalPurchasedFrom.TranslationRowKey == Constants.OTHER)
                {
                    if (string.IsNullOrWhiteSpace(OtherAnimalPurchasedFrom)) returnString.AppendLine(LogicHelper.GetTranslationFromStore(TranslationStore, Constants.NoPurchasedFrom, User.UserLang));
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
