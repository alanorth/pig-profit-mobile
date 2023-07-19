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
    public class OtherIncomeViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        bool isEditMode, isCreationMode;
        private bool editExistingMode;
        private DateTime date;
        private double? totalIncome;
        private string otherWhatFor;
        private double? transportationCosts;
        private double? otherCosts;
        private string comment;
        OtherIncomeItem _itemForEditing;

        //Button Clicks
        public Command SaveButtonClicked { get; }
        public Command ResetButtonClicked { get; }
        public Command DeleteButtonClicked { get; }
        public Command EditButtonClicked { get; }

        #region translations
        public string OtherIncomeTitleTranslation { get; set; }
        public string DateTranslation { get; set; }
        public string TotalIncomeTranslation { get; set; }
        public string OtherWhatForTranslation { get; set; }
        public string TransportationCostTranslation { get; set; }
        public string OtherCostsTranslation { get; set; }
        public string CommentTranslation { get; set; }

        public string SaveTranslation { get; set; }
        public string ResetTranslation { get; set; }
        public string EditTranslation { get; set; }
        public string DeleteTranslation { get; set; }
        #endregion

        #region Other cost item fields
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
        public string OtherWhatFor
        {
            get => otherWhatFor;
            set
            {
                if (value != otherWhatFor)
                {
                    otherWhatFor = value;
                    OnPropertyChanged(nameof(OtherWhatFor));
                }
            }
        }
        public double? TransportationCosts
        {
            get => transportationCosts;
            set
            {
                if (value != transportationCosts)
                {
                    transportationCosts = value;
                    OnPropertyChanged(nameof(TransportationCosts));
                }
            }
        }

        public double? TotalIncome
        {
            get => totalIncome;
            set
            {
                if (value != totalIncome)
                {
                    totalIncome = value;
                    OnPropertyChanged(nameof(TotalIncome));
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

        public OtherIncomeViewModel()
        {
            Date = DateTime.Now;

            IsEditMode = true;
            CreationMode = true;

            SaveButtonClicked = new Command(SaveButtonCreateOtherCostsItem);
            ResetButtonClicked = new Command(ResetButtonPressed);
            DeleteButtonClicked = new Command(DeleteItem);
            EditButtonClicked = new Command(EditItem);
            IsEditMode = true;
            IsCreationMode = !EditExistingMode;

            OtherIncomeTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherIncomeTitleTranslation), User.UserLang);
            DateTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateTranslation), User.UserLang) + " *";

            OtherWhatForTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherWhatForTranslation), User.UserLang);

            TotalIncomeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TotalIncomeTranslation), User.UserLang) + " *";
            TransportationCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TransportationCostTranslation), User.UserLang) + " *";
            OtherCostsTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherCostsTranslation), User.UserLang);
            CommentTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CommentTranslation), User.UserLang);

            SaveTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SaveTranslation), User.UserLang);
            ResetTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ResetTranslation), User.UserLang);
            EditTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EditTranslation), User.UserLang);
            DeleteTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DeleteTranslation), User.UserLang);
        }

        public void populatewithData(OtherIncomeItem item)
        {
            isEditMode = false;
            CreationMode = false;
            EditExistingMode = !CreationMode;

            _itemForEditing = item;

            Date = item.Date;
            OtherWhatFor = item.OtherWhatFor;
            TransportationCosts = item.TransportationCosts;
            TotalIncome = item.TotalIncome;
            OtherCosts = item.OtherCosts;
            Comment = item.Comment;
        }

        public void SetPickers()
        {
            if (EditExistingMode)
            {

            }
        }

        private async void SaveButtonCreateOtherCostsItem(object obj)
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
                _itemForEditing.OtherWhatFor = OtherWhatFor;
                _itemForEditing.TransportationCosts = (double)TransportationCosts;
                _itemForEditing.TotalIncome = (double)TotalIncome;
                _itemForEditing.OtherCosts = OtherCosts;
                _itemForEditing.Comment = Comment;
                _itemForEditing.LastModified = DateTime.UtcNow;

                await repo.UpdateOtherIncomeItem(_itemForEditing);
                await Application.Current.MainPage.DisplayAlert(Updated, LogicHelper.GetTranslationFromStore(TranslationStore, "OtherIncomeUpdated", User.UserLang), OK);
                await Shell.Current.Navigation.PopAsync();
            }
            else
            {
                var newOtherCosts = new OtherIncomeItem
                {
                    Date = Date,
                    OtherWhatFor = OtherWhatFor,
                    TransportationCosts = (double)TransportationCosts,
                    TotalIncome = (double)TotalIncome,
                    OtherCosts = OtherCosts,
                    Comment = Comment,
                    LastModified = DateTime.UtcNow,
                    CreatedBy = User.UserName,
                    PartitionKey = Constants.PartitionKeyOtherIncomeItem,
                };

                try { 
                await repo.AddSingleOtherIncomeItem(newOtherCosts);
                await Application.Current.MainPage.DisplayAlert(Created, LogicHelper.GetTranslationFromStore(TranslationStore, "OtherIncomeSaved", User.UserLang), OK);
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
                    repo.DeleteOtherIncomeItem(_itemForEditing);
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
            OtherWhatFor = null;
            TransportationCosts = null;
            TotalIncome = null;
            OtherCosts = null;
            Comment = null;
        }

        public async Task PopulateDataDowns()
        {

        }

        private string ValidateSave()
        {
            try
            {
                StringBuilder returnString = new StringBuilder();
                if (Date == null) returnString.AppendLine(LogicHelper.GetTranslationFromStore(TranslationStore, Constants.NoDate, User.UserLang));
                if (TotalIncome == null) returnString.AppendLine(LogicHelper.GetTranslationFromStore(TranslationStore, Constants.NoTotalCost, User.UserLang));
                if (TransportationCosts == null) returnString.AppendLine(LogicHelper.GetTranslationFromStore(TranslationStore,  Constants.NoTransportationCost, User.UserLang));
                //if (OtherCosts == null) returnString.AppendLine("Other cost not provided");

                return returnString.ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}
