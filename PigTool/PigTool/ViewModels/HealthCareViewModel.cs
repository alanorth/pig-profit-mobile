using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PigTool.Helpers;
using PigTool.Models;
using Xamarin.Forms;

namespace PigTool.ViewModels
{


    public class HealthCareViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        private HealthCareItem _itemForEditing;

        private bool isEditMode;
        public bool IsEditMode
        {
            get => isEditMode;
            set
            {
                if (value != isEditMode)
                {
                    isEditMode = value;
                    OnPropertyChanged(nameof(IsEditMode));
                }

            }
        }

        #region Control Display and Hiding

        private bool displayOtherhealthCareField, displayOtherHeatlhProvidersField, displayOtherMedicineField, displayOtherPurchaseFrom;

        public bool DisplayOtherhealthCareField { get => displayOtherhealthCareField; set { if (displayOtherhealthCareField != value) { displayOtherhealthCareField = value; OnPropertyChanged(nameof(DisplayOtherhealthCareField)); } } }
        public bool DisplayOtherHeatlhProvidersField { get => displayOtherHeatlhProvidersField; set { if (displayOtherHeatlhProvidersField != value) { displayOtherHeatlhProvidersField = value; OnPropertyChanged(nameof(DisplayOtherHeatlhProvidersField)); } } }
        public bool DisplayOtherMedicineField { get => displayOtherMedicineField; set { if (displayOtherMedicineField != value) { displayOtherMedicineField = value; OnPropertyChanged(nameof(DisplayOtherMedicineField)); } } }
        public bool DisplayOtherPurchaseFrom { get => displayOtherPurchaseFrom; set { if (displayOtherPurchaseFrom != value) { displayOtherPurchaseFrom = value; OnPropertyChanged(nameof(DisplayOtherPurchaseFrom)); } } }

        #endregion

        #region Translations
        public string DateTranslation { get; set; }
        public string HealthCareTypeTranslation { get; set; }
        public string OtherHealthCareTypeTranslation { get; set; }
        public string HealthCareCostTranslation { get; set; }
        public string ProviderTranslation { get; set; }
        public string OtherProviderTranslation { get; set; }
        public string MedicineCostTranslation { get; set; }
        public string MedinceTypeTranslation { get; set; }
        public string OtherMedinceTypeTranslation { get; set; }
        public string PurchasedFromTranslation { get; set; }
        public string OtherPurchasedFromTranslation { get; set; }
        public string CostTranslation { get; set; }
        public string TransportationCostTranslation { get; set; }
        public string CommentTranslation { get; set; }
        #endregion

        #region FormVariables
        private PickerToolHelper selectedHealthCareTypeOption, selectedHealthProviderListOfOption,
            selectedPurchaseFromListOfOption, selectedMedicineTypeListOfOption;
        private string healthCareType, otherHealthCareType, provider, medinceType,
            purchasedFrom, otherPurchasedFrom, comment, otherProvider, otherMedinceType;
        private double? healthCareCost, medicineCost, cost, transportationCost;
        private DateTime date;

        public DateTime Date { get => date; set { if (date != value) { date = value; OnPropertyChanged(nameof(Date)); } } }
        public string HealthCareType { get => healthCareType; set { if (healthCareType != value) { healthCareType = value; OnPropertyChanged(nameof(HealthCareType)); } } }
        public string OtherHealthCareType { get => otherHealthCareType; set { if (otherHealthCareType != value) { otherHealthCareType = value; OnPropertyChanged(nameof(OtherHealthCareType)); } } }
        public double? HealthCareCost { get => healthCareCost; set { if (healthCareCost != value) { healthCareCost = value; OnPropertyChanged(nameof(HealthCareCost)); } } }
        public string Provider { get => provider; set { if (provider != value) { provider = value; OnPropertyChanged(nameof(Provider)); } } }
        public string OtherProvider { get => otherProvider; set { if (otherProvider != value) { otherProvider = value; OnPropertyChanged(nameof(OtherProvider)); } } }
        public double? MedicineCost { get => medicineCost; set { if (medicineCost != value) { medicineCost = value; OnPropertyChanged(nameof(MedicineCost)); } } }
        public string MedinceType { get => medinceType; set { if (medinceType != value) { medinceType = value; OnPropertyChanged(nameof(MedinceType)); } } }
        public string OtherMedinceType { get => otherMedinceType; set { if (otherMedinceType != value) { otherMedinceType = value; OnPropertyChanged(nameof(OtherMedinceType)); } } }
        public string PurchasedFrom { get => purchasedFrom; set { if (purchasedFrom != value) { purchasedFrom = value; OnPropertyChanged(nameof(PurchasedFrom)); } } }
        public string OtherPurchasedFrom { get => otherPurchasedFrom; set { if (otherPurchasedFrom != value) { otherPurchasedFrom = value; OnPropertyChanged(nameof(OtherPurchasedFrom)); } } }
        public double? Cost { get => cost; set { if (cost != value) { cost = value; OnPropertyChanged(nameof(Cost)); } } }
        public double? TransportationCost { get => transportationCost; set { if (transportationCost != value) { transportationCost = value; OnPropertyChanged(nameof(TransportationCost)); } } }
        public string Comment { get => comment; set { if (comment != value) { comment = value; OnPropertyChanged(nameof(Comment)); } } }
        #endregion

        #region DropDownControls
        private List<PickerToolHelper> healthCareTypeOptions, healthProviderListOfOptions,
            purchaseFromListOfOptions, medicineTypeListOfOptions;


        public PickerToolHelper SelectedHealthCareTypeOption
        {
            get => selectedHealthCareTypeOption;
            set
            {
                if (selectedHealthCareTypeOption != value)
                {
                    DisplayOtherhealthCareField = value?.TranslationRowKey == SC.OTHER;
                    selectedHealthCareTypeOption = value;
                    OnPropertyChanged(nameof(SelectedHealthCareTypeOption));
                }
            }
        }
        public PickerToolHelper SelectedHealthProviderListOfOption
        {
            get => selectedHealthProviderListOfOption;
            set
            {
                if (selectedHealthProviderListOfOption != value)
                {
                    DisplayOtherHeatlhProvidersField = value?.TranslationRowKey == SC.OTHER;
                    selectedHealthProviderListOfOption = value; OnPropertyChanged(nameof(SelectedHealthProviderListOfOption));
                }
            }
        }
        public PickerToolHelper SelectedPurchaseFromListOfOption
        {
            get => selectedPurchaseFromListOfOption;
            set
            {
                if (selectedPurchaseFromListOfOption != value)
                {
                    DisplayOtherPurchaseFrom = value?.TranslationRowKey == SC.OTHER;
                    selectedPurchaseFromListOfOption = value; OnPropertyChanged(nameof(SelectedPurchaseFromListOfOption));
                }
            }
        }
        public PickerToolHelper SelectedMedicineTypeListOfOption
        {
            get => selectedMedicineTypeListOfOption;
            set
            {
                if (selectedMedicineTypeListOfOption != value)
                {
                    DisplayOtherMedicineField = value?.TranslationRowKey == SC.OTHER;
                    selectedMedicineTypeListOfOption = value; OnPropertyChanged(nameof(SelectedMedicineTypeListOfOption));
                }
            }
        }

        public List<PickerToolHelper> HealthCareTypeOptions
        {

            get { return healthCareTypeOptions; }
            set
            {
                healthCareTypeOptions = value;
                OnPropertyChanged(nameof(HealthCareTypeOptions));
            }
        }
        public List<PickerToolHelper> HealthProviderListOfOptions
        {

            get { return healthProviderListOfOptions; }
            set
            {
                healthProviderListOfOptions = value;
                OnPropertyChanged(nameof(HealthProviderListOfOptions));
            }
        }
        public List<PickerToolHelper> PurchaseFromListOfOptions
        {

            get { return purchaseFromListOfOptions; }
            set
            {
                purchaseFromListOfOptions = value;
                OnPropertyChanged(nameof(PurchaseFromListOfOptions));
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
        #endregion

        #region ButtonControls
        public Command SaveButtonClicked { get; }
        public Command ResetButtonClicked { get; }
        public Command DeleteButtonClicked { get; }
        public Command SwitchToEditMode { get; }
        public bool EditExistingMode { get; private set; }
        public bool CreationMode { get; private set; }
        #endregion

        public HealthCareViewModel()
        {
            SaveButtonClicked = (new Command(SaveButtonCreateFeedItemAsync));
            ResetButtonClicked = new Command(ResetButtonPressed);
            DeleteButtonClicked = new Command(DeleteItem);
            SwitchToEditMode = new Command(EditItemAsync);
            CreationMode = true;
            EditExistingMode = !CreationMode;

            Date = DateTime.Now;
            IsEditMode = true;
            DisplayOtherhealthCareField = false;
            DisplayOtherHeatlhProvidersField = false;
            DisplayOtherMedicineField = false;
            DisplayOtherPurchaseFrom = false;
            DateTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateTranslation), User.UserLang);
            HealthCareTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(HealthCareTypeTranslation), User.UserLang);
            OtherHealthCareTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherHealthCareTypeTranslation), User.UserLang);
            HealthCareCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(HealthCareCostTranslation), User.UserLang);
            ProviderTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ProviderTranslation), User.UserLang);
            OtherProviderTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherProviderTranslation), User.UserLang);
            MedicineCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(MedicineCostTranslation), User.UserLang);
            MedinceTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(MedinceTypeTranslation), User.UserLang);
            OtherMedinceTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherMedinceTypeTranslation), User.UserLang);
            PurchasedFromTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PurchasedFromTranslation), User.UserLang);
            OtherPurchasedFromTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherPurchasedFromTranslation), User.UserLang);
            CostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CostTranslation), User.UserLang);
            TransportationCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TransportationCostTranslation), User.UserLang);
            CommentTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CommentTranslation), User.UserLang);

            ClearFormVariables();
        }

        public void populatewithData(HealthCareItem item)
        {
            isEditMode = false;
            CreationMode = false;
            EditExistingMode = !CreationMode;

            _itemForEditing = item;

            HealthCareType = item.HealthCareType;
            OtherHealthCareType = item.OtherHealthCareType;
            Provider = item.Provider;
            OtherProvider = item.OtherProvider;
            MedinceType = item.MedinceType;
            OtherMedinceType = item.OtherMedinceType;
            PurchasedFrom = item.PurchasedFrom;
            OtherPurchasedFrom = item.OtherPurchasedFrom;
            Comment = item.Comment;
            HealthCareCost = item.HealthCareCost;
            MedicineCost = item.MedicineCost;
            Cost = item.Cost;
            TransportationCost = item.TransportationCost;

        }

        private void EditItemAsync()
        {
            IsEditMode = !IsEditMode;
        }

        private async void DeleteItem(object obj)
        {
            if (EditExistingMode)
            {
                var confirmDelete = await Application.Current.MainPage.DisplayAlert("Deletion Confimration", "Are you sure you want to Delete this item", "OK", "Cancel");
                if (confirmDelete)
                {
                    repo.DeleteHealthCaredItem(_itemForEditing);
                    await Shell.Current.Navigation.PopAsync();
                }
            }
        }

        private void ResetButtonPressed(object obj)
        {
            ClearFormVariables();
        }

        private async void SaveButtonCreateFeedItemAsync(object obj)
        {
            var valid = ValidateSave();

            if (!string.IsNullOrWhiteSpace(valid))
            {
                await Application.Current.MainPage.DisplayAlert("Error", valid, "OK");
            }

            if(_itemForEditing != null)
            {
                _itemForEditing.Date = Date;
                _itemForEditing.HealthCareType = SelectedHealthCareTypeOption.TranslationRowKey;
                _itemForEditing.OtherHealthCareType = OtherHealthCareType;
                _itemForEditing.HealthCareCost = HealthCareCost;
                _itemForEditing.Provider = SelectedHealthProviderListOfOption.TranslationRowKey;
                _itemForEditing.OtherProvider = OtherProvider;
                _itemForEditing.MedicineCost = MedicineCost;
                _itemForEditing.MedinceType = SelectedMedicineTypeListOfOption.TranslationRowKey;
                _itemForEditing.OtherMedinceType = OtherMedinceType;
                _itemForEditing.PurchasedFrom = SelectedPurchaseFromListOfOption.TranslationRowKey;
                _itemForEditing.OtherPurchasedFrom = OtherPurchasedFrom;
                _itemForEditing.Cost = Cost;
                _itemForEditing.TransportationCost = TransportationCost;
                _itemForEditing.Comment = Comment;
                _itemForEditing.LastModified = DateTime.UtcNow;

                await repo.UpdateHealthCareItem(_itemForEditing);
                await Application.Current.MainPage.DisplayAlert("Created", "Health Care Record Update", "OK");
                await Shell.Current.Navigation.PopAsync();

            }
            else
            {
                var newHealthItem = new HealthCareItem
                {
                    CreatedBy = User.UserName,
                    Date = Date,
                    HealthCareType = SelectedHealthCareTypeOption.TranslationRowKey,
                    OtherHealthCareType = OtherHealthCareType,
                    HealthCareCost = HealthCareCost,
                    Provider = SelectedHealthProviderListOfOption.TranslationRowKey,
                    OtherProvider = OtherProvider,
                    MedicineCost = MedicineCost,
                    MedinceType = SelectedMedicineTypeListOfOption.TranslationRowKey,
                    OtherMedinceType = OtherMedinceType,
                    PurchasedFrom = SelectedPurchaseFromListOfOption.TranslationRowKey,
                    OtherPurchasedFrom = OtherPurchasedFrom,
                    Cost = Cost,
                    TransportationCost = TransportationCost,
                    Comment = Comment
                };

                await repo.AddSingleHealthCareItem(newHealthItem);
                await Application.Current.MainPage.DisplayAlert("Created", "Health Care Record Save", "OK");
            }

        }

        public async Task PopulateDataDowns()
        {
            HealthCareTypeOptions = LogicHelper.CreatePickerToolOption(await repo.GetControlData(SC.HEALTHCARETYPE), User.UserLang);
            HealthProviderListOfOptions = LogicHelper.CreatePickerToolOption(await repo.GetControlData(SC.HEALTHSERVICEPROVIDER), User.UserLang);
            MedicineTypeListOfOptions = LogicHelper.CreatePickerToolOption(await repo.GetControlData(SC.HEALTHMEDICETYPE), User.UserLang);
            PurchaseFromListOfOptions = LogicHelper.CreatePickerToolOption(await repo.GetControlData(SC.HEALTHPURCHASEFROMTYPE), User.UserLang);


            if (!IsEditMode)
            {
                SelectedHealthCareTypeOption = HealthCareTypeOptions.Where(x => x.TranslationRowKey == _itemForEditing.HealthCareType).FirstOrDefault();
                SelectedHealthProviderListOfOption = HealthProviderListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.Provider).FirstOrDefault();
                SelectedMedicineTypeListOfOption = MedicineTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.MedinceType).FirstOrDefault();
                SelectedPurchaseFromListOfOption = PurchaseFromListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.PurchasedFrom).FirstOrDefault();
            }

        }

        private void ClearFormVariables()
        {
            SelectedHealthCareTypeOption = null;
            SelectedHealthProviderListOfOption = null;
            SelectedMedicineTypeListOfOption = null;
            SelectedPurchaseFromListOfOption = null;
            HealthCareType = null;
            OtherHealthCareType = null;
            Provider = null;
            OtherProvider = null;
            MedinceType = null;
            OtherMedinceType = null;
            PurchasedFrom = null;
            OtherPurchasedFrom = null;
            Comment = null;
            HealthCareCost = null;
            MedicineCost = null;
            Cost = null;
            TransportationCost = null;
        }

        private string ValidateSave()
        {
            StringBuilder returnString = new StringBuilder();
            returnString.AppendLine(Date == null ? "Date obtained not provided" : "");
            returnString.AppendLine(HealthCareCost == null ? "Cost Not Provided" : "");
            returnString.AppendLine(MedicineCost == null ? "Medicine Cost Not Provided" : "");
            returnString.AppendLine(TransportationCost == null ? "TransportationCost From Not Provided" : "");
            returnString.AppendLine(Cost == null ? "Other Costs Not Provided" : "");

            if (returnString.Length > 0) return returnString.ToString();


            if (selectedHealthCareTypeOption.TranslationRowKey == SC.OTHER)
            {
                returnString.Append(string.IsNullOrWhiteSpace(OtherHealthCareType) ? "Other Health Care Type Not Provided" : "");
            }

            if (selectedHealthProviderListOfOption.TranslationRowKey == SC.OTHER)
            {
                returnString.Append(string.IsNullOrWhiteSpace(OtherProvider) ? "Other Provider Not Provided" : "");
            }

            if (selectedPurchaseFromListOfOption.TranslationRowKey == SC.OTHER)
            {
                returnString.Append(string.IsNullOrWhiteSpace(OtherPurchasedFrom) ? "Other Purchase From Not Provided" : "");
            }

            if (selectedMedicineTypeListOfOption.TranslationRowKey == SC.OTHER)
            {
                returnString.Append(string.IsNullOrWhiteSpace(OtherMedinceType) ? "Other Medicince Type Not Provided" : "");
            }

            return returnString.ToString();
        }

    }
}
