using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PigTool.Helpers;
using PigTool.Models;
using PigTool.Views;
using Xamarin.Forms;

namespace PigTool.ViewModels
{
    public class HealthCareViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        bool isEditMode, isCreationMode;
        private bool editExistingMode;
        private DateTime date;
        private string? healthCareType;
        private string? otherHealthCareType;
        private double? healthCareCost;
        private string? provider;
        private string? otherProvider;
        private double? medicineCost;
        private string? medicineType;
        private string? otherMedicineType;
        private string? purchasedFrom;
        private string? otherPurchasedFrom;
        private double? transportationCost;
        private double? otherCosts;
        private string? comment;
        List<PickerToolHelper> healthCareTypeListOfOptions;
        List<PickerToolHelper> providerListOfOptions;
        List<PickerToolHelper> medicineTypeListOfOptions;
        List<PickerToolHelper> purchasedFromListOfOptions;
        HealthCareItem _itemForEditing;

        //Button Clicks
        public Command SaveButtonClicked { get; }
        public Command ResetButtonClicked { get; }
        public Command DeleteButtonClicked { get; }
        public Command EditButtonClicked { get; }

        #region translations
        public string HealthCareTitleTranslation { get; set; }
        public string DateTranslation { get; set; }

        public string HealthCareTypeTranslation { get; set; }
        public string OtherHealthCareTypeTranslation { get; set; }
        public string ProviderTranslation { get; set; }
        public string OtherProviderTranslation { get; set; }
        public string MedicineTypeTranslation { get; set; }
        public string OtherMedicineTypeTranslation { get; set; }
        public string PurchasedFromTranslation { get; set; }
        public string OtherPurchasedFromTranslation { get; set; }

        public string HealthCareCostTranslation { get; set; }
        public string MedicineCostTranslation { get; set; }

        public string TotalCostTranslation { get; set; }
        public string TransportationCostTranslation { get; set; }
        public string OtherCostTranslation { get; set; }
        public string CommentTranslation { get; set; }

        public string SaveTranslation { get; set; }
        public string ResetTranslation { get; set; }
        public string EditTranslation { get; set; }
        public string DeleteTranslation { get; set; }
        #endregion

        #region Health care item fields
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
        public string? HealthCareType
        {
            get => healthCareType;
            set
            {
                if (value != healthCareType)
                {
                    healthCareType = value;
                    OnPropertyChanged(nameof(HealthCareType));
                }
            }
        }
        public string? OtherHealthCareType
        {
            get => otherHealthCareType;
            set
            {
                if (value != otherHealthCareType)
                {
                    otherHealthCareType = value;
                    OnPropertyChanged(nameof(OtherHealthCareType));
                }
            }
        }
        public double? HealthCareCost
        {
            get => healthCareCost;
            set
            {
                if (value != healthCareCost)
                {
                    healthCareCost = value;
                    OnPropertyChanged(nameof(HealthCareCost));
                }
            }
        }
        public string? Provider
        {
            get => provider;
            set
            {
                if (value != provider)
                {
                    provider = value;
                    OnPropertyChanged(nameof(Provider));
                }
            }
        }
        public string? OtherProvider
        {
            get => otherProvider;
            set
            {
                if (value != otherProvider)
                {
                    otherProvider = value;
                    OnPropertyChanged(nameof(OtherProvider));
                }
            }
        }
        public double? MedicineCost
        {
            get => medicineCost;
            set
            {
                if (value != medicineCost)
                {
                    medicineCost = value;
                    OnPropertyChanged(nameof(MedicineCost));
                }
            }
        }
        public string? MedicineType
        {
            get => medicineType;
            set
            {
                if (value != medicineType)
                {
                    medicineType = value;
                    OnPropertyChanged(nameof(MedicineType));
                }
            }
        }
        public string? OtherMedicineType
        {
            get => otherMedicineType;
            set
            {
                if (value != otherMedicineType)
                {
                    otherMedicineType = value;
                    OnPropertyChanged(nameof(OtherMedicineType));
                }
            }
        }
        public string? PurchasedFrom
        {
            get => purchasedFrom;
            set
            {
                if (value != purchasedFrom)
                {
                    purchasedFrom = value;
                    OnPropertyChanged(nameof(PurchasedFrom));
                }
            }
        }
        public string? OtherPurchasedFrom
        {
            get => otherPurchasedFrom;
            set
            {
                if (value != otherPurchasedFrom)
                {
                    otherPurchasedFrom = value;
                    OnPropertyChanged(nameof(OtherPurchasedFrom));
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
        public List<PickerToolHelper> HealthCareTypeListOfOptions
        {
            get { return healthCareTypeListOfOptions; }
            set
            {
                healthCareTypeListOfOptions = value;
                OnPropertyChanged(nameof(HealthCareTypeListOfOptions));
            }
        }

        public List<PickerToolHelper> ProviderListOfOptions
        {
            get { return providerListOfOptions; }
            set
            {
                providerListOfOptions = value;
                OnPropertyChanged(nameof(ProviderListOfOptions));
            }
        }

        public List<PickerToolHelper> MedicineTypeListOfOptions
        {
            get { return medicineTypeListOfOptions; }
            set
            {
                medicineTypeListOfOptions = value;
                OnPropertyChanged(nameof(MedicineTypeListOfOptions));
            }
        }

        public List<PickerToolHelper> PurchasedFromListOfOptions
        {
            get { return purchasedFromListOfOptions; }
            set
            {
                purchasedFromListOfOptions = value;
                OnPropertyChanged(nameof(PurchasedFromListOfOptions));
            }
        }

        private PickerToolHelper selectedHealthCareType;

        public PickerToolHelper SelectedHealthCareType
        {
            get { return selectedHealthCareType; }
            set
            {
                if (selectedHealthCareType != value)
                {
                    DisplayOtherHealthCareType = value?.TranslationRowKey == SC.OTHER;
                    selectedHealthCareType = value;
                    OnPropertyChanged(nameof(SelectedHealthCareType));
                }
            }
        }

        private PickerToolHelper selectedProvider;

        public PickerToolHelper SelectedProvider
        {
            get { return selectedProvider; }
            set
            {
                if (selectedProvider != value)
                {
                    DisplayOtherProvider = value?.TranslationRowKey == SC.OTHER;
                    selectedProvider = value;
                    OnPropertyChanged(nameof(SelectedProvider));
                }
            }
        }

        private PickerToolHelper selectedMedicineType;

        public PickerToolHelper SelectedMedicineType
        {
            get { return selectedMedicineType; }
            set
            {
                if (selectedMedicineType != value)
                {
                    DisplayOtherMedicineType = value?.TranslationRowKey == SC.OTHER;
                    selectedMedicineType = value;
                    OnPropertyChanged(nameof(SelectedMedicineType));
                }
            }
        }

        private PickerToolHelper selectedPurchasedFrom;

        public PickerToolHelper SelectedPurchasedFrom
        {
            get { return selectedPurchasedFrom; }
            set
            {
                if (selectedPurchasedFrom != value)
                {
                    DisplayOtherPurchasedFrom = value?.TranslationRowKey == SC.OTHER;
                    selectedPurchasedFrom = value;
                    OnPropertyChanged(nameof(SelectedPurchasedFrom));
                }
            }
        }
        #endregion

        #region Hidden Fields
        private bool displayOtherHealthCareType;
        private bool displayOtherProvider;
        private bool displayOtherMedicineType;
        private bool displayOtherPurchasedFrom;

        public bool DisplayOtherHealthCareType
        {
            get => displayOtherHealthCareType;
            set
            {
                if (displayOtherHealthCareType != value)
                {
                    displayOtherHealthCareType = value;
                    OnPropertyChanged(nameof(DisplayOtherHealthCareType));
                }
            }
        }
        public bool DisplayOtherProvider
        {
            get => displayOtherProvider;
            set
            {
                if (displayOtherProvider != value)
                {
                    displayOtherProvider = value;
                    OnPropertyChanged(nameof(DisplayOtherProvider));
                }
            }
        }
        public bool DisplayOtherMedicineType
        {
            get => displayOtherMedicineType;
            set
            {
                if (displayOtherMedicineType != value)
                {
                    displayOtherMedicineType = value;
                    OnPropertyChanged(nameof(DisplayOtherMedicineType));
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

        public HealthCareViewModel()
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

            HealthCareTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(HealthCareTitleTranslation), User.UserLang);
            DateTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateTranslation), User.UserLang) + " *";

            HealthCareTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(HealthCareTypeTranslation), User.UserLang);
            OtherHealthCareTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherHealthCareTypeTranslation), User.UserLang);
            ProviderTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ProviderTranslation), User.UserLang);
            OtherProviderTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherProviderTranslation), User.UserLang);
            MedicineTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(MedicineTypeTranslation), User.UserLang);
            OtherMedicineTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherMedicineTypeTranslation), User.UserLang);
            PurchasedFromTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PurchasedFromTranslation), User.UserLang);
            OtherPurchasedFromTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherPurchasedFromTranslation), User.UserLang);

            HealthCareCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(HealthCareCostTranslation), User.UserLang) + " *";
            MedicineCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(MedicineCostTranslation), User.UserLang) + " *";

            TransportationCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TransportationCostTranslation), User.UserLang) + " *";
            OtherCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherCostTranslation), User.UserLang) + " *";
            CommentTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CommentTranslation), User.UserLang);

            SaveTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SaveTranslation), User.UserLang);
            ResetTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ResetTranslation), User.UserLang);
            EditTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EditTranslation), User.UserLang);
            DeleteTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DeleteTranslation), User.UserLang);
        }

        public void populatewithData(HealthCareItem item)
        {
            isEditMode = false;
            CreationMode = false;
            EditExistingMode = !CreationMode;

            _itemForEditing = item;

            Date = item.Date;
            HealthCareType = item.HealthCareType;
            OtherHealthCareType = item.OtherHealthCareType;
            HealthCareCost = item.HealthCareCost;
            Provider = item.Provider;
            OtherProvider = item.OtherProvider;
            MedicineCost = item.MedicineCost;
            MedicineType = item.MedicineType;
            OtherMedicineType = item.OtherMedicineType;
            PurchasedFrom = item.PurchasedFrom;
            OtherPurchasedFrom = item.OtherPurchasedFrom;
            TransportationCost = item.TransportationCost;
            OtherCosts = item.OtherCosts;
            Comment = item.Comment;
        }

        public void SetPickers()
        {
            if (EditExistingMode)
            {
                SelectedHealthCareType = HealthCareTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.HealthCareType).FirstOrDefault();
                SelectedProvider = ProviderListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.Provider).FirstOrDefault();
                SelectedMedicineType = MedicineTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.MedicineType).FirstOrDefault();
                SelectedPurchasedFrom = PurchasedFromListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.PurchasedFrom).FirstOrDefault();
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

                _itemForEditing.HealthCareType = SelectedHealthCareType != null ? SelectedHealthCareType.TranslationRowKey : null;
                _itemForEditing.OtherHealthCareType = OtherHealthCareType;
                _itemForEditing.HealthCareCost = (double)HealthCareCost;
                _itemForEditing.Provider = SelectedProvider != null ? SelectedProvider.TranslationRowKey : null;
                _itemForEditing.OtherProvider = OtherProvider;
                _itemForEditing.MedicineCost = (double)MedicineCost;
                _itemForEditing.MedicineType = SelectedMedicineType != null ? SelectedMedicineType.TranslationRowKey : null;
                _itemForEditing.OtherMedicineType = OtherMedicineType;
                _itemForEditing.PurchasedFrom = SelectedPurchasedFrom != null ? SelectedPurchasedFrom.TranslationRowKey : null;
                _itemForEditing.OtherPurchasedFrom = OtherPurchasedFrom;

                _itemForEditing.TransportationCost = (double)TransportationCost;
                _itemForEditing.OtherCosts = (double)OtherCosts;
                _itemForEditing.Comment = Comment;
                _itemForEditing.LastModified = DateTime.UtcNow;

                await repo.UpdateHealthCareItem(_itemForEditing);
                await Application.Current.MainPage.DisplayAlert("Updated", "Health care record has been updated", "OK");
                await Shell.Current.Navigation.PopAsync();
            }
            else
            {

                var newHealthCare = new HealthCareItem();
                try
                {
                    newHealthCare = new HealthCareItem
                    {
                        Date = Date,
                        HealthCareType = SelectedHealthCareType != null ? SelectedHealthCareType.TranslationRowKey : null,
                        OtherHealthCareType = OtherHealthCareType,
                        HealthCareCost = (double)HealthCareCost,
                        Provider = SelectedProvider != null ? SelectedProvider.TranslationRowKey : null,
                        OtherProvider = OtherProvider,
                        MedicineCost = (double)MedicineCost,
                        MedicineType = SelectedMedicineType != null ? SelectedMedicineType.TranslationRowKey : null,
                        OtherMedicineType = OtherMedicineType,
                        PurchasedFrom = SelectedPurchasedFrom != null ? SelectedPurchasedFrom.TranslationRowKey : null,
                        OtherPurchasedFrom = OtherPurchasedFrom,
                        TransportationCost = (double)TransportationCost,
                        OtherCosts = (double)OtherCosts,
                        Comment = Comment,
                        LastModified = DateTime.UtcNow,
                        CreatedBy = User.UserName,
                    };
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                

                await repo.AddSingleHealthCareItem(newHealthCare);
                await Application.Current.MainPage.DisplayAlert("Created", "Health care record has been saved", "OK");
            }
        }

        private async void DeleteItem(object obj)
        {
            if (EditExistingMode)
            {
                var confirmDelete = await Application.Current.MainPage.DisplayAlert("Deletion Confirmation", "Are you sure you want to delete this item", "OK", "Cancel");
                if (confirmDelete)
                {
                    repo.DeleteHealthCareItem(_itemForEditing);
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
            SelectedHealthCareType = null;
            OtherHealthCareType = null;
            HealthCareCost = null;
            SelectedProvider = null;
            OtherProvider = null;
            MedicineCost = null;
            SelectedMedicineType = null;
            OtherMedicineType = null;
            SelectedPurchasedFrom = null;
            OtherPurchasedFrom = null;
            TransportationCost = null;
            OtherCosts = null;
            Comment = null;
        }

        public async Task PopulateDataDowns()
        {
            var HealthCareTypeControlData = await repo.GetControlData(SC.HEALTHCARETYPE);
            var ProviderControlData = await repo.GetControlData(SC.HEALTHSERVICEPROVIDER);
            var MedicineTypeControlData = await repo.GetControlData(SC.HEALTHMEDICETYPE);
            var PurchasedFromControlData = await repo.GetControlData(SC.HEALTHPURCHASEFROMTYPE);

            HealthCareTypeListOfOptions = LogicHelper.CreatePickerToolOption(HealthCareTypeControlData, User.UserLang);
            ProviderListOfOptions = LogicHelper.CreatePickerToolOption(ProviderControlData, User.UserLang);
            MedicineTypeListOfOptions = LogicHelper.CreatePickerToolOption(MedicineTypeControlData, User.UserLang);
            PurchasedFromListOfOptions = LogicHelper.CreatePickerToolOption(PurchasedFromControlData, User.UserLang);

            if (!IsEditMode)
            {
                SelectedHealthCareType = HealthCareTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.HealthCareType).FirstOrDefault();
                SelectedProvider = ProviderListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.Provider).FirstOrDefault();
                SelectedMedicineType = MedicineTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.MedicineType).FirstOrDefault();
                SelectedPurchasedFrom = PurchasedFromListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.PurchasedFrom).FirstOrDefault();
            }
        }

        private string ValidateSave()
        {
            try
            {
                StringBuilder returnString = new StringBuilder();
                if (Date == null) returnString.AppendLine("Date not provided");
                if (HealthCareCost == null) returnString.AppendLine("Health Care Cost Not Provided");
                if (MedicineCost == null) returnString.AppendLine("Medicine Cost Not Provided");
                if (TransportationCost == null) returnString.AppendLine("Transportation Cost Not Provided");
                if (OtherCosts == null) returnString.AppendLine("Other Cost Not Provided");


                if (SelectedHealthCareType != null && SelectedHealthCareType.TranslationRowKey == SC.OTHER)
                {
                    if (string.IsNullOrWhiteSpace(OtherHealthCareType)) returnString.AppendLine("Other Health Care Type Not Provided");
                }

                if (SelectedProvider != null && SelectedProvider.TranslationRowKey == SC.OTHER)
                {
                    if (string.IsNullOrWhiteSpace(OtherProvider)) returnString.AppendLine("Other Provider Not Provided");
                }

                if (SelectedMedicineType != null && SelectedMedicineType.TranslationRowKey == SC.OTHER)
                {
                    if (string.IsNullOrWhiteSpace(OtherMedicineType)) returnString.AppendLine("Other Medicine Type Not Provided");
                }

                if (SelectedPurchasedFrom != null && SelectedPurchasedFrom.TranslationRowKey == SC.OTHER)
                {
                    if (string.IsNullOrWhiteSpace(OtherPurchasedFrom)) returnString.AppendLine("Other Purchased From Not Provided");
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
