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
    public class ReproductiveViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        bool isEditMode, isCreationMode;
        private bool editExistingMode;
        private DateTime date;

        private string serviceType;
        private string otherServiceType;
        private int? sowsServiced;
        private string whoProvidedService;
        private string otherWhoProvidedService;
        private double? otherCosts;
        private string comment;
        List<PickerToolHelper> serviceTypeListOfOptions;
        List<PickerToolHelper> whoProvidedServiceListOfOptions;
        ReproductiveItem _itemForEditing;

        //Button Clicks
        public Command SaveButtonClicked { get; }
        public Command ResetButtonClicked { get; }
        public Command DeleteButtonClicked { get; }
        public Command EditButtonClicked { get; }

        #region translations
        public string ReproductiveTitleTranslation { get; set; }
        public string DateTranslation { get; set; }

        public string ServiceTypeTranslation { get; set; }
        public string OtherServiceTypeTranslation { get; set; }
        public string WhoProvidedServiceTranslation { get; set; }
        public string OtherWhoProvidedServiceTranslation { get; set; }

        public string SowsServicedTranslation { get; set; }
        public string OtherCostTranslation { get; set; }
        public string CommentTranslation { get; set; }

        public string SaveTranslation { get; set; }
        public string ResetTranslation { get; set; }
        public string EditTranslation { get; set; }
        public string DeleteTranslation { get; set; }

        public string PickerServiceTypeTranslation { get; set; }
        public string PickerProviderTranslation { get; set; }
        #endregion

        #region Reproductive item fields
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

        public string ServiceType
        {
            get => serviceType;
            set
            {
                if (value != serviceType)
                {
                    serviceType = value;
                    OnPropertyChanged(nameof(ServiceType));
                }
            }
        }
        public string OtherServiceType
        {
            get => otherServiceType;
            set
            {
                if (value != otherServiceType)
                {
                    otherServiceType = value;
                    OnPropertyChanged(nameof(OtherServiceType));
                }
            }
        }
        public int? SowsServiced
        {
            get => sowsServiced;
            set
            {
                if (value != sowsServiced)
                {
                    sowsServiced = value;
                    OnPropertyChanged(nameof(SowsServiced));
                }
            }
        }
        public string WhoProvidedService
        {
            get => whoProvidedService;
            set
            {
                if (value != whoProvidedService)
                {
                    whoProvidedService = value;
                    OnPropertyChanged(nameof(WhoProvidedService));
                }
            }
        }
        public string OtherWhoProvidedService
        {
            get => otherWhoProvidedService;
            set
            {
                if (value != otherWhoProvidedService)
                {
                    otherWhoProvidedService = value;
                    OnPropertyChanged(nameof(OtherWhoProvidedService));
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
        public List<PickerToolHelper> ServiceTypeListOfOptions
        {
            get { return serviceTypeListOfOptions; }
            set
            {
                serviceTypeListOfOptions = value;
                OnPropertyChanged(nameof(ServiceTypeListOfOptions));
            }
        }

        public List<PickerToolHelper> WhoProvidedServiceListOfOptions
        {
            get { return whoProvidedServiceListOfOptions; }
            set
            {
                whoProvidedServiceListOfOptions = value;
                OnPropertyChanged(nameof(WhoProvidedServiceListOfOptions));
            }
        }

        private PickerToolHelper selectedServiceType;

        public PickerToolHelper SelectedServiceType
        {
            get { return selectedServiceType; }
            set
            {
                if (selectedServiceType != value)
                {
                    DisplayOtherServiceType = value?.TranslationRowKey == Constants.OTHER;
                    selectedServiceType = value;
                    OnPropertyChanged(nameof(SelectedServiceType));
                }
            }
        }

        private PickerToolHelper selectedWhoProvidedService;

        public PickerToolHelper SelectedWhoProvidedService
        {
            get { return selectedWhoProvidedService; }
            set
            {
                if (selectedWhoProvidedService != value)
                {
                    DisplayOtherWhoProvidedService = value?.TranslationRowKey == Constants.OTHER;
                    selectedWhoProvidedService = value;
                    OnPropertyChanged(nameof(SelectedWhoProvidedService));
                }
            }
        }
        #endregion

        #region Hidden Fields
        private bool displayOtherServiceType;
        private bool displayOtherWhoProvidedService;

        public bool DisplayOtherServiceType
        {
            get => displayOtherServiceType;
            set
            {
                if (displayOtherServiceType != value)
                {
                    displayOtherServiceType = value;
                    OnPropertyChanged(nameof(DisplayOtherServiceType));
                }
            }
        }
        public bool DisplayOtherWhoProvidedService
        {
            get => displayOtherWhoProvidedService;
            set
            {
                if (displayOtherWhoProvidedService != value)
                {
                    displayOtherWhoProvidedService = value;
                    OnPropertyChanged(nameof(DisplayOtherWhoProvidedService));
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

        public ReproductiveViewModel()
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

            ReproductiveTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ReproductiveTitleTranslation), User.UserLang);
            DateTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateTranslation), User.UserLang) + " *";

            ServiceTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ServiceTypeTranslation), User.UserLang);
            OtherServiceTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherServiceTypeTranslation), User.UserLang);
            WhoProvidedServiceTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(WhoProvidedServiceTranslation), User.UserLang);
            OtherWhoProvidedServiceTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherWhoProvidedServiceTranslation), User.UserLang);

            SowsServicedTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SowsServicedTranslation), User.UserLang) + " *";
            OtherCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherCostTranslation), User.UserLang) + " *";
            CommentTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CommentTranslation), User.UserLang);

            SaveTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SaveTranslation), User.UserLang);
            ResetTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ResetTranslation), User.UserLang);
            EditTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EditTranslation), User.UserLang);
            DeleteTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DeleteTranslation), User.UserLang);

            PickerProviderTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerProviderTranslation), User.UserLang);
            PickerServiceTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerServiceTypeTranslation), User.UserLang);
        }

        public void populatewithData(ReproductiveItem item)
        {
            isEditMode = false;
            CreationMode = false;
            EditExistingMode = !CreationMode;

            _itemForEditing = item;

            Date = item.Date;
            ServiceType = item.ServiceType;
            OtherServiceType = item.OtherServiceType;
            SowsServiced = item.SowsServiced;
            WhoProvidedService = item.WhoProvidedService;
            OtherWhoProvidedService = item.OtherWhoProvidedService;
            OtherCosts = item.OtherCosts;
            Comment = item.Comment;
        }

        public void SetPickers()
        {
            if (EditExistingMode)
            {
                SelectedServiceType = ServiceTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.ServiceType).FirstOrDefault();
                SelectedWhoProvidedService = WhoProvidedServiceListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.WhoProvidedService).FirstOrDefault();
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
                _itemForEditing.SowsServiced = (int)SowsServiced;
                _itemForEditing.ServiceType = SelectedServiceType != null ? SelectedServiceType.TranslationRowKey : null;
                _itemForEditing.OtherServiceType = OtherServiceType;
                _itemForEditing.WhoProvidedService = SelectedWhoProvidedService != null ? SelectedWhoProvidedService.TranslationRowKey : null;
                _itemForEditing.OtherWhoProvidedService = OtherWhoProvidedService;
                _itemForEditing.OtherCosts = (double)OtherCosts;
                _itemForEditing.Comment = Comment;
                _itemForEditing.LastModified = DateTime.UtcNow;

                await repo.UpdateReproductiveItem(_itemForEditing);
                await Application.Current.MainPage.DisplayAlert("Updated", "Reproduction record has been updated", "OK");
                await Shell.Current.Navigation.PopAsync();
            }
            else
            {
                var newReproductiveItem = new ReproductiveItem
                {
                    Date = Date,
                    SowsServiced = (int)SowsServiced,
                    ServiceType = SelectedServiceType != null ? SelectedServiceType.TranslationRowKey : null,
                    OtherServiceType = OtherServiceType,
                    WhoProvidedService = SelectedWhoProvidedService != null ? SelectedWhoProvidedService.TranslationRowKey : null,
                    OtherWhoProvidedService = OtherWhoProvidedService,
                    OtherCosts = (double)OtherCosts,
                    Comment = Comment,
                    LastModified = DateTime.UtcNow,
                    CreatedBy = User.UserName,
                    PartitionKey = Constants.PartitionKeyReporductiveItem,
                };

                await repo.AddSingleReproductiveItem(newReproductiveItem);
                await Application.Current.MainPage.DisplayAlert("Created", "Reproduction record has been saved", "OK");
            }
        }

        private async void DeleteItem(object obj)
        {
            if (EditExistingMode)
            {
                var confirmDelete = await Application.Current.MainPage.DisplayAlert("Deletion Confirmation", "Are you sure you want to delete this item", "OK", "Cancel");
                if (confirmDelete)
                {
                    repo.DeleteReproductiveItem(_itemForEditing);
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
            SowsServiced = null;
            SelectedServiceType = null;
            OtherServiceType = null;
            SelectedWhoProvidedService = null;
            OtherWhoProvidedService = null;
            OtherCosts = null;
            Comment = null;
        }

        public async Task PopulateDataDowns()
        {
            var ServiceTypeControlData = await repo.GetControlData(Constants.SERVICETYPE);
            var WhoProvidedServiceControlData = await repo.GetControlData(Constants.WHOPROVIDEDSERVICETYPE);

            ServiceTypeListOfOptions = LogicHelper.CreatePickerToolOption(ServiceTypeControlData, User.UserLang);
            WhoProvidedServiceListOfOptions = LogicHelper.CreatePickerToolOption(WhoProvidedServiceControlData, User.UserLang);

            if (!IsEditMode)
            {
                SelectedServiceType = ServiceTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.ServiceType).FirstOrDefault();
                SelectedWhoProvidedService = WhoProvidedServiceListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.WhoProvidedService).FirstOrDefault();
            }
        }

        private string ValidateSave()
        {
            try
            {
                StringBuilder returnString = new StringBuilder();
                if (Date == null) returnString.AppendLine("Date obtained not provided");
                if (SowsServiced == null) returnString.AppendLine("Sows Serviced Not Provided");
                if (OtherCosts == null) returnString.AppendLine("Other Cost Not Provided");


                if (SelectedServiceType != null && SelectedServiceType.TranslationRowKey == Constants.OTHER)
                {
                    if (string.IsNullOrWhiteSpace(OtherServiceType)) returnString.AppendLine("Other Service Type Not Provided");
                }

                if (SelectedWhoProvidedService != null && SelectedWhoProvidedService.TranslationRowKey == Constants.OTHER)
                {
                    if (string.IsNullOrWhiteSpace(OtherWhoProvidedService)) returnString.AppendLine("Other Who Provided Service Not Provided");
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
