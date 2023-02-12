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
    public class OtherCostViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        bool isEditMode, isCreationMode;
        private bool editExistingMode;
        private DateTime date;
        private double? totalCosts;
        private string otherWhatFor;
        private double? transportationCosts;
        private double? otherCosts;
        private string comment;
        OtherCostItem _itemForEditing;

        //Button Clicks
        public Command SaveButtonClicked { get; }
        public Command ResetButtonClicked { get; }
        public Command DeleteButtonClicked { get; }
        public Command EditButtonClicked { get; }

        #region translations
        public string OtherCostTitleTranslation { get; set; }
        public string DateTranslation { get; set; }
        public string TotalCostTranslation { get; set; }
        public string OtherWhatForTranslation { get; set; }
        public string TransportationCostTranslation { get; set; }
        public string OtherCostTranslation { get; set; }
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

        public OtherCostViewModel()
        {
            Date = DateTime.Now;

            IsEditMode = true;
            CreationMode = true;

            SaveButtonClicked = new Command(SaveButtonCreateOtherCostItem);
            ResetButtonClicked = new Command(ResetButtonPressed);
            DeleteButtonClicked = new Command(DeleteItem);
            EditButtonClicked = new Command(EditItem);
            IsEditMode = true;
            IsCreationMode = !EditExistingMode;

            OtherCostTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherCostTitleTranslation), User.UserLang);
            DateTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateTranslation), User.UserLang) + " *";

            OtherWhatForTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherWhatForTranslation), User.UserLang);

            TotalCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TotalCostTranslation), User.UserLang) + " *";
            TransportationCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TransportationCostTranslation), User.UserLang) + " *";
            OtherCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherCostTranslation), User.UserLang);
            CommentTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CommentTranslation), User.UserLang);

            SaveTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SaveTranslation), User.UserLang);
            ResetTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ResetTranslation), User.UserLang);
            EditTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EditTranslation), User.UserLang);
            DeleteTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DeleteTranslation), User.UserLang);
        }

        public void populatewithData(OtherCostItem item)
        {
            isEditMode = false;
            CreationMode = false;
            EditExistingMode = !CreationMode;

            _itemForEditing = item;

            Date = item.Date;
            OtherWhatFor = item.OtherWhatFor;
            TransportationCosts = item.TransportationCosts;
            TotalCosts = item.TotalCosts;
            OtherCosts = item.OtherCosts;
            Comment = item.Comment;
        }

        public void SetPickers()
        {
            if (EditExistingMode)
            {

            }
        }

        private async void SaveButtonCreateOtherCostItem(object obj)
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
                _itemForEditing.OtherWhatFor = OtherWhatFor;
                _itemForEditing.TransportationCosts = (double)TransportationCosts;
                _itemForEditing.TotalCosts = (double)TotalCosts;
                _itemForEditing.OtherCosts = (double)OtherCosts;
                _itemForEditing.Comment = Comment;
                _itemForEditing.LastModified = DateTime.UtcNow;

                await repo.UpdateOtherCostItem(_itemForEditing);
                await Application.Current.MainPage.DisplayAlert("Updated", "Other cost record has been updated", "OK");
                await Shell.Current.Navigation.PopAsync();
            }
            else
            {
                var newOtherCost = new OtherCostItem
                {
                    Date = Date,
                    OtherWhatFor = OtherWhatFor,
                    TransportationCosts = TransportationCosts,
                    TotalCosts = (double)TotalCosts,
                    OtherCosts = (double)OtherCosts,
                    Comment = Comment,
                    LastModified = DateTime.UtcNow,
                    CreatedBy = User.UserName,
                    PartitionKey = Constants.PartitionKeyOtherCostItem,
                };

                try
                {
                    await repo.AddSingleOtherCostItem(newOtherCost);
                    await Application.Current.MainPage.DisplayAlert("Created", "Other Cost has been saved", "OK");
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
                    repo.DeleteOtherCostItem(_itemForEditing);
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
            TotalCosts = null;
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
                if (Date == null) returnString.AppendLine("Date obtained not provided");
                if (TotalCosts == null) returnString.AppendLine("Total cost not provided");
                if (TransportationCosts == null) returnString.AppendLine("Transportation Costs is required");
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
