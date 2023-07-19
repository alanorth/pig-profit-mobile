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
    public class LoanRepaymentViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        bool isEditMode, isCreationMode;
        private bool editExistingMode;
        private DateTime date, durationStart, durationFinish;
        private double? totalAmountRepaid;
        private string loanProvider;
        private string otherLoanProvider;
        private double? otherCosts, transportCosts;
        private string comment;
        List<PickerToolHelper> loanProviderListOfOptions;
        LoanRepaymentItem _itemForEditing;

        //Button Clicks
        public Command SaveButtonClicked { get; }
        public Command ResetButtonClicked { get; }
        public Command DeleteButtonClicked { get; }
        public Command EditButtonClicked { get; }

        #region translations
        public string LoanRepaymentTitleTranslation { get; set; }
        public string DateTranslation { get; set; }
        public string LoanProviderTranslation { get; set; }
        public string OtherLoanProviderTranslation { get; set; }
        public string TotalAmountRepaidTranslation { get; set; }
        public string OtherCostTranslation { get; set; }
        public string TransportCostTrans { get; set; }
        public string CommentTranslation { get; set; }
        public string SaveTranslation { get; set; }
        public string ResetTranslation { get; set; }
        public string EditTranslation { get; set; }
        public string DeleteTranslation { get; set; }
        public string StartTranslation { get; set; }
        public string FinishTranslation { get; set; }
        public string LoanDurationTranslation { get; set; }

        public string PickerProviderTranslation { get; set; }
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

        public double? TotalAmountRepaid
        {
            get => totalAmountRepaid;
            set
            {
                if (value != totalAmountRepaid)
                {
                    totalAmountRepaid = value;
                    OnPropertyChanged(nameof(TotalAmountRepaid));
                }
            }
        }
        public string LoanProvider
        {
            get => loanProvider;
            set
            {
                if (value != loanProvider)
                {
                    loanProvider = value;
                    OnPropertyChanged(nameof(LoanProvider));
                }
            }
        }
        public string OtherLoanProvider
        {
            get => otherLoanProvider;
            set
            {
                if (value != otherLoanProvider)
                {
                    otherLoanProvider = value;
                    OnPropertyChanged(nameof(OtherLoanProvider));
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
        public double? TransportCosts
        {
            get => transportCosts;
            set
            {
                if (value != transportCosts)
                {
                    transportCosts = value;
                    OnPropertyChanged(nameof(TransportCosts));
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
        public List<PickerToolHelper> LoanProviderListOfOptions
        {
            get { return loanProviderListOfOptions; }
            set
            {
                loanProviderListOfOptions = value;
                OnPropertyChanged(nameof(LoanProviderListOfOptions));
            }
        }

        private PickerToolHelper selectedLoanProvider;

        public PickerToolHelper SelectedLoanProvider
        {
            get { return selectedLoanProvider; }
            set
            {
                if (selectedLoanProvider != value)
                {
                    DisplayOtherLoanProvider = value?.TranslationRowKey == Constants.OTHER;
                    selectedLoanProvider = value;
                    OnPropertyChanged(nameof(SelectedLoanProvider));
                }
            }
        }
        #endregion

        #region Hidden Fields
        private bool displayOtherLoanProvider;

        public bool DisplayOtherLoanProvider
        {
            get => displayOtherLoanProvider;
            set
            {
                if (displayOtherLoanProvider != value)
                {
                    displayOtherLoanProvider = value;
                    OnPropertyChanged(nameof(DisplayOtherLoanProvider));
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

        public LoanRepaymentViewModel()
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

            LoanRepaymentTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LoanRepaymentTitleTranslation), User.UserLang);
            DateTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateTranslation), User.UserLang) + " *";

            TotalAmountRepaidTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TotalAmountRepaidTranslation), User.UserLang) + " *";
            LoanProviderTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LoanProviderTranslation), User.UserLang);
            OtherLoanProviderTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherLoanProviderTranslation), User.UserLang);

            OtherCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherCostTranslation), User.UserLang);
            TransportCostTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TransportCostTrans), User.UserLang);
            CommentTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CommentTranslation), User.UserLang);
            StartTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(StartTranslation), User.UserLang) + " *";
            FinishTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(FinishTranslation), User.UserLang) + " *";
            LoanDurationTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LoanDurationTranslation), User.UserLang);

            SaveTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SaveTranslation), User.UserLang);
            ResetTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ResetTranslation), User.UserLang);
            EditTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EditTranslation), User.UserLang);
            DeleteTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DeleteTranslation), User.UserLang);

            PickerProviderTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerProviderTranslation), User.UserLang);
        }

        public void populatewithData(LoanRepaymentItem item)
        {
            isEditMode = false;
            CreationMode = false;
            EditExistingMode = !CreationMode;

            _itemForEditing = item;

            Date = item.Date;
            TotalAmountRepaid = item.TotalAmountRepaid;
            LoanProvider = item.LoanProvider;
            OtherLoanProvider = item.OtherLoanProvider;
            OtherCosts = item.OtherCosts;
            TransportCosts = item.TransportCosts;
            Comment = item.Comment;
            DurationStart = (DateTime)item.DurationStart;
            DurationFinish = (DateTime)item.DurationFinish;

        }

        public void SetPickers()
        {
            if (EditExistingMode)
            {
                SelectedLoanProvider = LoanProviderListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.LoanProvider).FirstOrDefault();
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
                _itemForEditing.TotalAmountRepaid = (double)TotalAmountRepaid;
                _itemForEditing.LoanProvider = SelectedLoanProvider != null ? SelectedLoanProvider.TranslationRowKey : null;
                _itemForEditing.OtherLoanProvider = OtherLoanProvider;
                _itemForEditing.OtherCosts = OtherCosts;
                _itemForEditing.TransportCosts = TransportCosts;
                _itemForEditing.Comment = Comment;
                _itemForEditing.LastModified = DateTime.UtcNow;
                _itemForEditing.DurationStart = DurationStart;
                _itemForEditing.DurationFinish = DurationFinish;

                await repo.UpdateLoanRepaymentItem(_itemForEditing);
                await Application.Current.MainPage.DisplayAlert(Updated,LogicHelper.GetTranslationFromStore(TranslationStore, "LoanUpdated", User.UserLang), OK);
                await Shell.Current.Navigation.PopAsync();
            }
            else
            {
                var newLoanRepayment = new LoanRepaymentItem
                {
                    Date = Date,
                    TotalAmountRepaid = (double)TotalAmountRepaid,
                    LoanProvider = SelectedLoanProvider != null ? SelectedLoanProvider.TranslationRowKey : null,
                    OtherLoanProvider = OtherLoanProvider,
                    OtherCosts = OtherCosts,
                    TransportCosts = TransportCosts,
                    Comment = Comment,
                    LastModified = DateTime.UtcNow,
                    CreatedBy = User.UserName,
                    PartitionKey = Constants.PartitionKeyLoanRepaymentItem,
                    DurationStart = DurationStart,
                    DurationFinish = DurationFinish
                };

                try
                {
                    await repo.AddSingleLoanRepaymentItem(newLoanRepayment);
                    await Application.Current.MainPage.DisplayAlert(Created, LogicHelper.GetTranslationFromStore(TranslationStore, "LoanSaved", User.UserLang), OK);
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
                    repo.DeleteLoanRepaymentItem(_itemForEditing);
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
            TotalAmountRepaid = null;
            LoanProvider = null;
            SelectedLoanProvider = null;
            OtherLoanProvider = null;
            OtherCosts = null;
            TransportCosts = null;
            Comment = null;
        }

        public async Task PopulateDataDowns()
        {
            var LoanProviderControlData = await repo.GetControlData(Constants.LOANPROVIDERTYPE);

            LoanProviderListOfOptions = LogicHelper.CreatePickerToolOption(LoanProviderControlData, User.UserLang);

            if (!IsEditMode)
            {
                SelectedLoanProvider = LoanProviderListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.LoanProvider).FirstOrDefault();
            }
        }

        private string ValidateSave()
        {
            try
            {
                StringBuilder returnString = new StringBuilder();
                if (Date == null) returnString.AppendLine(LogicHelper.GetTranslationFromStore(TranslationStore, Constants.NoDate, User.UserLang));
                if (TotalAmountRepaid == null) returnString.AppendLine(LogicHelper.GetTranslationFromStore(TranslationStore, Constants.NoTotalAmount, User.UserLang));
                if (DurationStart == null) returnString.AppendLine(LogicHelper.GetTranslationFromStore(TranslationStore, Constants.NoDurationStart, User.UserLang));
                if (DurationFinish == null) returnString.AppendLine(LogicHelper.GetTranslationFromStore(TranslationStore, Constants.NoDurationEnd, User.UserLang));
                if (DurationStart > DurationFinish) returnString.AppendLine(LogicHelper.GetTranslationFromStore(TranslationStore, Constants.DurIsbefore, User.UserLang));
                //if (OtherCosts == null) returnString.AppendLine("Other Cost Not Provided");

                if (SelectedLoanProvider != null && SelectedLoanProvider.TranslationRowKey == Constants.OTHER)
                {
                    if (string.IsNullOrWhiteSpace(OtherLoanProvider)) returnString.AppendLine(LogicHelper.GetTranslationFromStore(TranslationStore, Constants.OtherUnitNotProvided, User.UserLang));
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
