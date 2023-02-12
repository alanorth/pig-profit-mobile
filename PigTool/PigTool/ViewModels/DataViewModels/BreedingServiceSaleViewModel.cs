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
    public class BreedingServiceSaleViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        bool isEditMode, isCreationMode;
        private bool editExistingMode;
        private DateTime date;
        private int? numberServices;
        private string serviceType;
        private string otherServiceType;
        private double? amountRecieved;
        private string client;
        private string otherClient;
        private string paymentType;
        private double? paymentValue;
        private double? transportationCost;
        private double? otherCosts;
        private string comment;
        List<PickerToolHelper> serviceTypeListOfOptions;
        List<PickerToolHelper> clientListOfOptions;
        List<PickerToolHelper> paymentTypeListOfOptions;
        BreedingServiceSaleItem _itemForEditing;

        //Button Clicks
        public Command SaveButtonClicked { get; }
        public Command ResetButtonClicked { get; }
        public Command DeleteButtonClicked { get; }
        public Command EditButtonClicked { get; }

        #region translations
        public string BreedingServiceSaleTitleTranslation { get; set; }
        public string DateTranslation { get; set; }

        public string NumberServicesTranslation { get; set; }

        public string ServiceTypeTranslation { get; set; }
        public string OtherServiceTypeTranslation { get; set; }
        public string ClientTranslation { get; set; }
        public string OtherClientTranslation { get; set; }

        public string AmountRecievedTranslation { get; set; }
        public string AnyOtherPaymentTranslation { get; set; }
        public string PaymentTypeTranslation { get; set; }
        public string PaymentValueTranslation { get; set; }
        public string TransportationCostTranslation { get; set; }
        public string OtherCostTranslation { get; set; }
        public string CommentTranslation { get; set; }

        public string SaveTranslation { get; set; }
        public string ResetTranslation { get; set; }
        public string EditTranslation { get; set; }
        public string DeleteTranslation { get; set; }

        public string PickerServiceTypeTranslation { get; set; }
        public string PickerPaymentTypeTranslation { get; set; }
        public string PickerClientTranslation { get; set; }
        #endregion

        #region Pig Sale item fields
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
        public int? NumberServices
        {
            get => numberServices;
            set
            {
                if (value != numberServices)
                {
                    numberServices = value;
                    OnPropertyChanged(nameof(NumberServices));
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
        public string Client
        {
            get => client;
            set
            {
                if (value != client)
                {
                    client = value;
                    OnPropertyChanged(nameof(Client));
                }
            }
        }
        public string OtherClient
        {
            get => otherClient;
            set
            {
                if (value != otherClient)
                {
                    otherClient = value;
                    OnPropertyChanged(nameof(OtherClient));
                }
            }
        }
        public double? AmountRecieved
        {
            get => amountRecieved;
            set
            {
                if (value != amountRecieved)
                {
                    amountRecieved = value;
                    OnPropertyChanged(nameof(AmountRecieved));
                }
            }
        }
        public string PaymentType
        {
            get => paymentType;
            set
            {
                if (value != paymentType)
                {
                    paymentType = value;
                    OnPropertyChanged(nameof(PaymentType));
                }
            }
        }
        public double? PaymentValue
        {
            get => paymentValue;
            set
            {
                if (value != paymentValue)
                {
                    paymentValue = value;
                    OnPropertyChanged(nameof(PaymentValue));
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
        public List<PickerToolHelper> ServiceTypeListOfOptions
        {
            get { return serviceTypeListOfOptions; }
            set
            {
                serviceTypeListOfOptions = value;
                OnPropertyChanged(nameof(ServiceTypeListOfOptions));
            }
        }

        public List<PickerToolHelper> ClientListOfOptions
        {
            get { return clientListOfOptions; }
            set
            {
                clientListOfOptions = value;
                OnPropertyChanged(nameof(ClientListOfOptions));
            }
        }

        public List<PickerToolHelper> PaymentTypeListOfOptions
        {
            get { return paymentTypeListOfOptions; }
            set
            {
                paymentTypeListOfOptions = value;
                OnPropertyChanged(nameof(PaymentTypeListOfOptions));
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

        private PickerToolHelper selectedClient;

        public PickerToolHelper SelectedClient
        {
            get { return selectedClient; }
            set
            {
                if (selectedClient != value)
                {
                    DisplayOtherClient = value?.TranslationRowKey == Constants.OTHER;
                    selectedClient = value;
                    OnPropertyChanged(nameof(SelectedClient));
                }
            }
        }

        private PickerToolHelper selectedPaymentType;

        public PickerToolHelper SelectedPaymentType
        {
            get { return selectedPaymentType; }
            set
            {
                if (selectedPaymentType != value)
                {
                    selectedPaymentType = value;
                    OnPropertyChanged(nameof(SelectedPaymentType));
                }
            }
        }
        #endregion

        #region Hidden Fields
        private bool displayOtherServiceType;
        private bool displayOtherClient;

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
        public bool DisplayOtherClient
        {
            get => displayOtherClient;
            set
            {
                if (displayOtherClient != value)
                {
                    displayOtherClient = value;
                    OnPropertyChanged(nameof(DisplayOtherClient));
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

        public BreedingServiceSaleViewModel()
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

            BreedingServiceSaleTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(BreedingServiceSaleTitleTranslation), User.UserLang);
            DateTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateTranslation), User.UserLang) + " *";

            NumberServicesTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(NumberServicesTranslation), User.UserLang);

            ServiceTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ServiceTypeTranslation), User.UserLang);
            OtherServiceTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherServiceTypeTranslation), User.UserLang);
            ClientTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ClientTranslation), User.UserLang);
            OtherClientTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherClientTranslation), User.UserLang);

            AmountRecievedTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(AmountRecievedTranslation), User.UserLang) + " *";
            AnyOtherPaymentTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(AnyOtherPaymentTranslation), User.UserLang);
            PaymentTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PaymentTypeTranslation), User.UserLang);
            PaymentValueTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PaymentValueTranslation), User.UserLang) + " *";
            TransportationCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TransportationCostTranslation), User.UserLang) + " *";
            OtherCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherCostTranslation), User.UserLang);
            CommentTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CommentTranslation), User.UserLang);

            SaveTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SaveTranslation), User.UserLang);
            ResetTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ResetTranslation), User.UserLang);
            EditTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EditTranslation), User.UserLang);
            DeleteTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DeleteTranslation), User.UserLang);

            PickerServiceTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerServiceTypeTranslation), User.UserLang);
            PickerPaymentTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerPaymentTypeTranslation), User.UserLang);
            PickerClientTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PickerClientTranslation), User.UserLang);
        }

        public void populatewithData(BreedingServiceSaleItem item)
        {
            isEditMode = false;
            CreationMode = false;
            EditExistingMode = !CreationMode;

            _itemForEditing = item;

            Date = item.Date;
            NumberServices = item.NumberServices;
            ServiceType = item.ServiceType;
            OtherServiceType = item.OtherServiceType;
            Client = item.Client;
            OtherClient = item.OtherClient;
            AmountRecieved = item.AmountRecieved;
            PaymentType = item.PaymentType;
            PaymentValue = item.PaymentValue;
            TransportationCost = item.TransportationCost;
            OtherCosts = item.OtherCosts;
            Comment = item.Comment;
        }

        public void SetPickers()
        {
            if (EditExistingMode)
            {
                SelectedServiceType = ServiceTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.ServiceType).FirstOrDefault();
                SelectedClient = ClientListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.Client).FirstOrDefault();
                SelectedPaymentType = PaymentTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.PaymentType).FirstOrDefault();
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
                _itemForEditing.NumberServices = NumberServices;
                _itemForEditing.ServiceType = SelectedServiceType != null ? SelectedServiceType.TranslationRowKey : null;
                _itemForEditing.OtherServiceType = OtherServiceType;
                _itemForEditing.Client = SelectedClient != null ? SelectedClient.TranslationRowKey : null;
                _itemForEditing.OtherClient = OtherClient;
                _itemForEditing.AmountRecieved = (double)AmountRecieved;
                _itemForEditing.PaymentType = SelectedPaymentType != null ? SelectedPaymentType.TranslationRowKey : null;
                _itemForEditing.PaymentValue = PaymentValue;
                _itemForEditing.TransportationCost = (double)TransportationCost;
                _itemForEditing.OtherCosts = (double)OtherCosts;
                _itemForEditing.Comment = Comment;
                _itemForEditing.LastModified = DateTime.UtcNow;

                await repo.UpdateBreedingServiceSaleItem(_itemForEditing);
                await Application.Current.MainPage.DisplayAlert("Updated", "Sale of reproductive services has been saved", "OK");
                await Shell.Current.Navigation.PopAsync();
            }
            else
            {
                var newBreedingServiceSale = new BreedingServiceSaleItem
                {
                    Date = Date,
                    NumberServices = NumberServices,
                    ServiceType = SelectedServiceType != null ? SelectedServiceType.TranslationRowKey : null,
                    OtherServiceType = OtherServiceType,
                    Client = SelectedClient != null ? SelectedClient.TranslationRowKey : null,
                    OtherClient = OtherClient,
                    AmountRecieved = (double)AmountRecieved,
                    PaymentType = SelectedPaymentType != null ? SelectedPaymentType.TranslationRowKey : null,
                    PaymentValue = PaymentValue,
                    TransportationCost = (double)TransportationCost,
                    OtherCosts = (double)OtherCosts,
                    Comment = Comment,
                    LastModified = DateTime.UtcNow,
                    CreatedBy = User.UserName,
                    PartitionKey = Constants.PartitionKeyBreedingServiceSaleItem,
                };
                try
                {
                    await repo.AddSingleBreedingServiceSaleItem(newBreedingServiceSale);
                    await Application.Current.MainPage.DisplayAlert("Created", "Breeding service sale has been saved", "OK");
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
                    repo.DeleteBreedingServiceSaleItem(_itemForEditing);
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
            NumberServices = null;
            ServiceType = null;
            SelectedServiceType = null;
            OtherServiceType = null;
            SelectedClient = null;
            OtherClient = null;
            AmountRecieved = null;
            PaymentValue = null;
            SelectedPaymentType = null;
            TransportationCost = null;
            OtherCosts = null;
            Comment = null;
        }

        public async Task PopulateDataDowns()
        {
            var ServiceTypeControlData = await repo.GetControlData(Constants.BREEDINGSERVICETYPE);
            var ClientControlData = await repo.GetControlData(Constants.CLIENTTYPE);
            var PaymentTypeControlData = await repo.GetControlData(Constants.OTHERPAYMENTTYPE);

            ServiceTypeListOfOptions = LogicHelper.CreatePickerToolOption(ServiceTypeControlData, User.UserLang);
            ClientListOfOptions = LogicHelper.CreatePickerToolOption(ClientControlData, User.UserLang);
            PaymentTypeListOfOptions = LogicHelper.CreatePickerToolOption(PaymentTypeControlData, User.UserLang);

            if (!IsEditMode)
            {
                selectedServiceType = ServiceTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.ServiceType).FirstOrDefault();
                selectedClient = ServiceTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.Client).FirstOrDefault();
                selectedPaymentType = PaymentTypeListOfOptions.Where(x => x.TranslationRowKey == _itemForEditing.PaymentType).FirstOrDefault();
            }
        }

        private string ValidateSave()
        {
            try
            {
                StringBuilder returnString = new StringBuilder();
                if (Date == null) returnString.AppendLine("Date obtained not provided");
                if (AmountRecieved == null) returnString.AppendLine("Amount Recieved Not Provided");
                if (PaymentType != null && PaymentValue == null) returnString.AppendLine("Payment Value Not Provided");
                if (TransportationCost == null) returnString.AppendLine("Transportation Cost Not Provided");
                //if (OtherCosts == null) returnString.AppendLine("Other Cost Not Provided");


                if (SelectedServiceType != null && SelectedServiceType.TranslationRowKey == Constants.OTHER)
                {
                    if (string.IsNullOrWhiteSpace(OtherServiceType)) returnString.AppendLine("Other Service Type Not Provided");
                }

                if (SelectedClient != null && SelectedClient.TranslationRowKey == Constants.OTHER)
                {
                    if (string.IsNullOrWhiteSpace(OtherClient)) returnString.AppendLine("Other Client Not Provided");
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
