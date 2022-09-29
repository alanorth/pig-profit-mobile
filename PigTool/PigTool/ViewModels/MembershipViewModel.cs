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
    public class MembershipViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        bool isEditMode, isCreationMode;
        private bool editExistingMode;
        private DateTime date;
        private double? totalCosts;
        private string? membershipType;
        private string? otherMembershipType;
        private int? timePeriod;
        private string? timePerdiodUnit;
        private double? otherCosts;
        private string? comment;
        List<PickerToolHelper> membershipTypeListOfOptions;
        List<PickerToolHelper> timePeriodUnitListOfOptions;
        MembershipItem _itemForEditing;

        //Button Clicks
        public Command SaveButtonClicked { get; }
        public Command ResetButtonClicked { get; }
        public Command DeleteButtonClicked { get; }
        public Command EditButtonClicked { get; }

        #region translations
        public string MembershipTitleTranslation { get; set; }
        public string DateTranslation { get; set; }
        public string TotalCostTranslation { get; set; }
        public string MembershipTypeTranslation { get; set; }
        public string OtherMembershipTypeTranslation { get; set; }
        public string TimePeriodTranslation { get; set; }
        public string OtherCostTranslation { get; set; }
        public string CommentTranslation { get; set; }

        public string SaveTranslation { get; set; }
        public string ResetTranslation { get; set; }
        public string EditTranslation { get; set; }
        public string DeleteTranslation { get; set; }
        #endregion

        #region Membership item fields
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
        public string MemberhipType
        {
            get => membershipType;
            set
            {
                if (value != membershipType)
                {
                    membershipType = value;
                    OnPropertyChanged(nameof(MemberhipType));
                }
            }
        }
        public string OtherMembershipType
        {
            get => otherMembershipType;
            set
            {
                if (value != otherMembershipType)
                {
                    otherMembershipType = value;
                    OnPropertyChanged(nameof(OtherMembershipType));
                }
            }
        }
        public int? TimePeriod
        {
            get => timePeriod;
            set
            {
                if (value != timePeriod)
                {
                    timePeriod = value;
                    OnPropertyChanged(nameof(TimePeriod));
                }
            }
        }
        public string TimePerdiodUnit
        {
            get => timePerdiodUnit;
            set
            {
                if (value != timePerdiodUnit)
                {
                    timePerdiodUnit = value;
                    OnPropertyChanged(nameof(TimePerdiodUnit));
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
        public List<PickerToolHelper> MembershipTypeListOfOptions
        {
            get { return membershipTypeListOfOptions; }
            set
            {
                membershipTypeListOfOptions = value;
                OnPropertyChanged(nameof(MembershipTypeListOfOptions));
            }
        }

        public List<PickerToolHelper> TimePeriodUnitListOfOptions
        {
            get { return timePeriodUnitListOfOptions; }
            set
            {
                timePeriodUnitListOfOptions = value;
                OnPropertyChanged(nameof(TimePeriodUnitListOfOptions));
            }
        }

        private PickerToolHelper selectedMembershipType;

        public PickerToolHelper SelectedMembershipType
        {
            get { return selectedMembershipType; }
            set
            {
                if (selectedMembershipType != value)
                {
                    DisplayOtherMembershipType = value?.TranslationRowKey == Constants.OTHER;
                    selectedMembershipType = value;
                    OnPropertyChanged(nameof(SelectedMembershipType));
                }
            }
        }

        private PickerToolHelper selectedTimePeriodUnit;

        public PickerToolHelper SelectedTimePeriodUnit
        {
            get { return selectedTimePeriodUnit; }
            set
            {
                if (selectedTimePeriodUnit != value)
                {
                    selectedTimePeriodUnit = value;
                    OnPropertyChanged(nameof(SelectedTimePeriodUnit));
                }
            }
        }
        #endregion

        #region Hidden Fields
        private bool displayOtherMembershipType;

        public bool DisplayOtherMembershipType
        {
            get => displayOtherMembershipType;
            set
            {
                if (displayOtherMembershipType != value)
                {
                    displayOtherMembershipType = value;
                    OnPropertyChanged(nameof(DisplayOtherMembershipType));
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

        public MembershipViewModel()
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

            MembershipTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(MembershipTitleTranslation), User.UserLang);
            DateTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateTranslation), User.UserLang) + " *";
            
            MembershipTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(MembershipTypeTranslation), User.UserLang);
            OtherMembershipTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherMembershipTypeTranslation), User.UserLang);
            TimePeriodTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TimePeriodTranslation), User.UserLang) + " *";

            TotalCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TotalCostTranslation), User.UserLang) + " *";
            OtherCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherCostTranslation), User.UserLang) + " *";
            CommentTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CommentTranslation), User.UserLang);
            
            SaveTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SaveTranslation), User.UserLang);
            ResetTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ResetTranslation), User.UserLang);
            EditTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EditTranslation), User.UserLang);
            DeleteTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DeleteTranslation), User.UserLang);
        }

        public void populatewithData(MembershipItem item)
        {
            isEditMode = false;
            CreationMode = false;
            EditExistingMode = !CreationMode;

            _itemForEditing = item;

            Date = item.Date;
            MemberhipType = item.MembershipType;
            OtherMembershipType = item.OtherMembershipType;
            TimePeriod = item.TimePeriod;
            TimePerdiodUnit = item.TimePeriodUnit;
            TotalCosts = item.TotalCosts;
            OtherCosts = item.OtherCosts; 
            Comment = item.Comment;
        }

        public void SetPickers()
        {
            if (EditExistingMode)
            {
                SelectedMembershipType = MembershipTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.MembershipType).FirstOrDefault();
                SelectedTimePeriodUnit = TimePeriodUnitListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.TimePeriodUnit).FirstOrDefault();
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
                _itemForEditing.MembershipType = SelectedMembershipType != null ? SelectedMembershipType.TranslationRowKey : null;
                _itemForEditing.OtherMembershipType = OtherMembershipType;
                _itemForEditing.TimePeriod = (int)TimePeriod;
                _itemForEditing.TimePeriodUnit = SelectedTimePeriodUnit.TranslationRowKey;
                _itemForEditing.TotalCosts = (double)TotalCosts;
                _itemForEditing.OtherCosts = (double)OtherCosts;
                _itemForEditing.Comment = Comment;
                _itemForEditing.LastModified = DateTime.UtcNow;

                await repo.UpdateMembershipItem(_itemForEditing);
                await Application.Current.MainPage.DisplayAlert("Updated", "Water cost record has been updated", "OK");
                await Shell.Current.Navigation.PopAsync();
            }
            else
            {
                var newMembership = new MembershipItem
                {
                    Date = Date,
                    MembershipType = SelectedMembershipType != null ? SelectedMembershipType.TranslationRowKey : null,
                    OtherMembershipType = OtherMembershipType,
                    TimePeriod = (int)TimePeriod,
                    TimePeriodUnit = SelectedTimePeriodUnit.TranslationRowKey,
                    TotalCosts = (double)TotalCosts,
                    OtherCosts = (double)OtherCosts,
                    Comment = Comment,
                    LastModified = DateTime.UtcNow,
                    CreatedBy = User.UserName,
                };

                await repo.AddSingleMembershipItem(newMembership);
                await Application.Current.MainPage.DisplayAlert("Created", "Membership has been saved", "OK");
            }
        }

        private async void DeleteItem(object obj)
        {
            if (EditExistingMode)
            {
                var confirmDelete = await Application.Current.MainPage.DisplayAlert("Deletion Confirmation", "Are you sure you want to delete this item", "OK", "Cancel");
                if (confirmDelete)
                {
                    repo.DeleteMembershipItem(_itemForEditing);
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
            SelectedMembershipType = null;
            OtherMembershipType = null;
            TimePeriod = 0;
            SelectedTimePeriodUnit = null;
            TotalCosts = null;
            OtherCosts = null;
            Comment = null;
        }

        public async Task PopulateDataDowns()
        {
            var MembershipTypeControlData = await repo.GetControlData(Constants.MEMBERSHIPTYPE);
            var TimeperdiodUnitControlData = await repo.GetControlData(Constants.TIMEPERIODUNITTYPE);

            MembershipTypeListOfOptions = LogicHelper.CreatePickerToolOption(MembershipTypeControlData, User.UserLang);
            TimePeriodUnitListOfOptions = LogicHelper.CreatePickerToolOption(TimeperdiodUnitControlData, User.UserLang);

            if (!IsEditMode)
            {
                selectedMembershipType = MembershipTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.MembershipType).FirstOrDefault();
                selectedTimePeriodUnit = TimePeriodUnitListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.TimePeriodUnit).FirstOrDefault();
            }
        }

        private string ValidateSave()
        {
            try
            {
                StringBuilder returnString = new StringBuilder();
                if (Date == null) returnString.AppendLine("Date obtained not provided");
                if (TotalCosts == null) returnString.AppendLine("Total Cost Not Provided");
                if (TimePeriod == null) returnString.AppendLine("Time Period Not Provided");
                if (SelectedTimePeriodUnit == null) returnString.AppendLine("Time Period Unit Not Provided");
                if (OtherCosts == null) returnString.AppendLine("Other Cost Not Provided");

                if (selectedMembershipType != null && selectedMembershipType.TranslationRowKey == Constants.OTHER)
                {
                    if (string.IsNullOrWhiteSpace(OtherMembershipType)) returnString.AppendLine("Other Membership Type Not Provided");
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
