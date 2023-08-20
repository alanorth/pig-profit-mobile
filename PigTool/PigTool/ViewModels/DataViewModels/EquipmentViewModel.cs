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
    public class EquipmentViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        bool isEditMode, isCreationMode;
        private bool editExistingMode;
        private DateTime date;
        private double? totalCosts;
        private string equipmentType;
        private string otherEquipmentType;
        private double? transportationCost;
        private double? otherCosts;
        private string comment;
        List<PickerToolHelper> equipmentTypeListOfOptions;
        EquipmentItem _itemForEditing;

        //Button Clicks
        public Command SaveButtonClicked { get; }
        public Command ResetButtonClicked { get; }
        public Command DeleteButtonClicked { get; }
        public Command EditButtonClicked { get; }

        #region translations
        public string EquipmentTitleTranslation { get; set; }
        public string DateTranslation { get; set; }

        public string EquipmentTypeTranslation { get; set; }
        public string OtherEquipmentTypeTranslation { get; set; }


        public string TotalCostTranslation { get; set; }
        public string TransportationCostTranslation { get; set; }
        public string OtherCostTranslation { get; set; }
        public string CommentTranslation { get; set; }

        public string SaveTranslation { get; set; }
        public string ResetTranslation { get; set; }
        public string EditTranslation { get; set; }
        public string DeleteTranslation { get; set; }

        public string PickerEquipmentTypeTranslation { get; set; }
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
        public string EquipmentType
        {
            get => equipmentType;
            set
            {
                if (value != equipmentType)
                {
                    equipmentType = value;
                    OnPropertyChanged(nameof(EquipmentType));
                }
            }
        }
        public string OtherEquipmentType
        {
            get => otherEquipmentType;
            set
            {
                if (value != otherEquipmentType)
                {
                    otherEquipmentType = value;
                    OnPropertyChanged(nameof(OtherEquipmentType));
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
        public List<PickerToolHelper> EquipmentTypeListOfOptions
        {
            get { return equipmentTypeListOfOptions; }
            set
            {
                equipmentTypeListOfOptions = value;
                OnPropertyChanged(nameof(EquipmentTypeListOfOptions));
            }
        }

        private PickerToolHelper selectedEquipmentType;

        public PickerToolHelper SelectedEquipmentType
        {
            get { return selectedEquipmentType; }
            set
            {
                if (selectedEquipmentType != value)
                {
                    DisplayOtherEquipmentType = value?.TranslationRowKey == Constants.OTHER;
                    selectedEquipmentType = value;
                    OnPropertyChanged(nameof(SelectedEquipmentType));
                }
            }
        }

        #endregion

        #region Hidden Fields
        private bool displayEquipmentType;

        public bool DisplayOtherEquipmentType
        {
            get => displayEquipmentType;
            set
            {
                if (displayEquipmentType != value)
                {
                    displayEquipmentType = value;
                    OnPropertyChanged(nameof(DisplayOtherEquipmentType));
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

        public EquipmentViewModel()
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

            EquipmentTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EquipmentTitleTranslation), User.UserLang);
            DateTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateTranslation), User.UserLang) + " *";

            EquipmentTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EquipmentTypeTranslation), User.UserLang);
            OtherEquipmentTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherEquipmentTypeTranslation), User.UserLang);


            TotalCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TotalCostTranslation), User.UserLang) + " *";
            TransportationCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TransportationCostTranslation), User.UserLang) + " *";
            OtherCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherCostTranslation), User.UserLang);
            CommentTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CommentTranslation), User.UserLang);

            SaveTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SaveTranslation), User.UserLang);
            ResetTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ResetTranslation), User.UserLang);
            EditTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EditTranslation), User.UserLang);
            DeleteTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DeleteTranslation), User.UserLang);

            PickerEquipmentTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerEquipmentTypeTranslation), User.UserLang);
        }

        public void populatewithData(EquipmentItem item)
        {
            isEditMode = false;
            CreationMode = false;
            EditExistingMode = !CreationMode;

            _itemForEditing = item;

            Date = item.Date;
            EquipmentType = item.EquipmentType;
            OtherEquipmentType = item.OtherEquipmentType;
            TotalCosts = item.TotalCosts;
            TransportationCost = item.TransportationCost;
            OtherCosts = item.OtherCosts;
            Comment = item.Comment;
        }

        public void SetPickers()
        {
            if (EditExistingMode)
            {
                SelectedEquipmentType = EquipmentTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.EquipmentType).FirstOrDefault();
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
                _itemForEditing.EquipmentType = EquipmentType;
                _itemForEditing.EquipmentType = SelectedEquipmentType != null ? SelectedEquipmentType.TranslationRowKey : null;
                _itemForEditing.OtherEquipmentType = OtherEquipmentType;
                _itemForEditing.TotalCosts = (double)TotalCosts;
                _itemForEditing.TransportationCost = (double)TransportationCost;
                _itemForEditing.OtherCosts = OtherCosts == null ? 0 : (double)OtherCosts;
                _itemForEditing.Comment = Comment;
                _itemForEditing.LastModified = DateTime.UtcNow;

                await repo.UpdateEquipmentItem(_itemForEditing);
                await Application.Current.MainPage.DisplayAlert(Updated, LogicHelper.GetTranslationFromStore(TranslationStore, "EquipmentUpdated", User.UserLang), OK);
                await Shell.Current.Navigation.PopAsync();
            }
            else
            {
                var newEquipment = new EquipmentItem
                {
                    Date = Date,
                    EquipmentType = SelectedEquipmentType != null ? SelectedEquipmentType.TranslationRowKey : null,
                    OtherEquipmentType = OtherEquipmentType,
                    TotalCosts = (double)TotalCosts,
                    TransportationCost = (double)TransportationCost,
                    OtherCosts = OtherCosts == null ? 0 : (double)OtherCosts,
                    Comment = Comment,
                    LastModified = DateTime.UtcNow,
                    CreatedBy = User.UserName,
                    PartitionKey = Constants.PartitionKeyEquipmentItem,
                };
                try
                {
                    await repo.AddSingleEquipmentItem(newEquipment);
                    await Application.Current.MainPage.DisplayAlert(Created, LogicHelper.GetTranslationFromStore(TranslationStore, "EquipmentSaved", User.UserLang), OK);
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
                    repo.DeleteEquipmentItem(_itemForEditing);
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
            EquipmentType = null;
            EquipmentType = null;
            SelectedEquipmentType = null;
            OtherEquipmentType = null;
            TotalCosts = null;
            TransportationCost = null;
            OtherCosts = null;
            Comment = null;
        }

        public async Task PopulateDataDowns()
        {
            var EquipmentTypeControlData = await repo.GetControlData(Constants.EQUIPMENTTYPE);

            EquipmentTypeListOfOptions = LogicHelper.CreatePickerToolOption(EquipmentTypeControlData, User.UserLang);

            if (!IsEditMode)
            {
                SelectedEquipmentType = EquipmentTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.EquipmentType).FirstOrDefault();
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


                if (SelectedEquipmentType != null && SelectedEquipmentType.TranslationRowKey == Constants.OTHER)
                { 
                    if (string.IsNullOrWhiteSpace(OtherEquipmentType)) returnString.AppendLine(LogicHelper.GetTranslationFromStore(TranslationStore, Constants.OtherEqNotProvided, User.UserLang));
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
