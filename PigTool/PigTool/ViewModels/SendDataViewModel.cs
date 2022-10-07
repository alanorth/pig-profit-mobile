using Newtonsoft.Json;
using Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PigTool.ViewModels
{
    public class SendDataViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        public bool PageRendered { get; set; }

        public DateTime LastTimeDataUploaded { get => lastTimeDataUploaded; set => lastTimeDataUploaded = value; }

        private ObservableCollection<FeedItem> feedItems;
        private ObservableCollection<HealthCareItem> healthCareItems;
        private ObservableCollection<LabourCostItem> labourCostItems;
        private ObservableCollection<AnimalHouseItem> animalHouseItems;
        private ObservableCollection<WaterCostItem> waterCostItems;
        private ObservableCollection<MembershipItem> membershipItems;
        private ObservableCollection<OtherCostItem> otherCostItems;
        private ObservableCollection<ReproductiveItem> reproductiveItems;
        private ObservableCollection<AnimalPurchaseItem> animalPurchaseItems;
        private ObservableCollection<LoanRepaymentItem> loanRepaymentItems;
        private ObservableCollection<EquipmentItem> equipmentItems;
        private DateTime lastTimeDataUploaded;

        public ObservableCollection<FeedItem> FeedItems
        {

            get { return feedItems; }
            set
            {
                feedItems = new ObservableCollection<FeedItem>(value.Where(x => x.LastModified > LastTimeDataUploaded).ToList());
                OnPropertyChanged(nameof(FeedItems));
            }
        }
        public ObservableCollection<HealthCareItem> HealthCareItems
        {

            get { return healthCareItems; }
            set
            {
                healthCareItems = new ObservableCollection<HealthCareItem>(value.Where(x => x.LastModified > LastTimeDataUploaded).ToList());
                OnPropertyChanged(nameof(HealthCareItems));
            }
        }
        public ObservableCollection<LabourCostItem> LabourCostItems
        {

            get { return labourCostItems; }
            set
            {
                labourCostItems = new ObservableCollection<LabourCostItem>(value.Where(x => x.LastModified > LastTimeDataUploaded).ToList());
                OnPropertyChanged(nameof(LabourCostItems));
            }
        }
        public ObservableCollection<AnimalHouseItem> AnimalHouseItems
        {

            get { return animalHouseItems; }
            set
            {
                animalHouseItems = new ObservableCollection<AnimalHouseItem>(value.Where(x => x.LastModified > LastTimeDataUploaded).ToList());
                OnPropertyChanged(nameof(AnimalHouseItems));
            }
        }
        public ObservableCollection<WaterCostItem> WaterCostItems
        {

            get { return waterCostItems; }
            set
            {
                waterCostItems = new ObservableCollection<WaterCostItem>(value.Where(x => x.LastModified > LastTimeDataUploaded).ToList());
                OnPropertyChanged(nameof(WaterCostItems));
            }
        }
        public ObservableCollection<MembershipItem> MembershipItems
        {

            get { return membershipItems; }
            set
            {
                membershipItems =
                    new ObservableCollection<MembershipItem>(value.Where(x => x.LastModified > LastTimeDataUploaded).ToList());
                OnPropertyChanged(nameof(MembershipItems));
            }
        }
        public ObservableCollection<OtherCostItem> OtherCostItems
        {

            get { return otherCostItems; }
            set
            {
                value.Where(x => x.LastModified > LastTimeDataUploaded);

                otherCostItems = new ObservableCollection<OtherCostItem>(value.Where(x => x.LastModified > LastTimeDataUploaded).ToList());
                OnPropertyChanged(nameof(OtherCostItems));
            }
        }
        public ObservableCollection<ReproductiveItem> ReproductiveItems
        {

            get { return reproductiveItems; }
            set
            {
                reproductiveItems = new ObservableCollection<ReproductiveItem>(value.Where(x => x.LastModified > LastTimeDataUploaded).ToList());
                OnPropertyChanged(nameof(ReproductiveItems));
            }
        }
        public ObservableCollection<AnimalPurchaseItem> AnimalPurchaseItems
        {

            get { return animalPurchaseItems; }
            set
            {
                value.Where(x => x.LastModified > LastTimeDataUploaded);

                animalPurchaseItems = new ObservableCollection<AnimalPurchaseItem>(value.Where(x => x.LastModified > LastTimeDataUploaded).ToList());
                OnPropertyChanged(nameof(AnimalPurchaseItems));
            }
        }
        public ObservableCollection<LoanRepaymentItem> LoanRepaymentItems
        {

            get { return loanRepaymentItems; }
            set
            {
                loanRepaymentItems = new ObservableCollection<LoanRepaymentItem>(value.Where(x => x.LastModified > LastTimeDataUploaded).ToList());
                OnPropertyChanged(nameof(LoanRepaymentItems));
            }
        }
        public ObservableCollection<EquipmentItem> EquipmentItems
        {
            get { return equipmentItems; }
            set
            {
                equipmentItems = new ObservableCollection<EquipmentItem>(value.Where(x => x.LastModified > LastTimeDataUploaded).ToList());
                OnPropertyChanged(nameof(EquipmentItems));
            }
        }

        public int CountOf_FeedItems { 
            get { return countOf_FeedItems; }
            set { 
                countOf_FeedItems = value;
                OnPropertyChanged(nameof(CountOf_FeedItems)); 
            }
        }
        public int CountOf_HealthCareItems
        {
            get { return countOf_HealthCareItems; }
            set
            {
                countOf_HealthCareItems = value;
                OnPropertyChanged(nameof(CountOf_HealthCareItems));
            }
        }
        public int Countof_LabourCostItems
        {
            get { return countof_labourcostitems; }
            set
            {
                countof_labourcostitems = value;
                OnPropertyChanged(nameof(Countof_LabourCostItems));
            }
        }
        public int Countof_AnimalHouseItems
        {
            get { return countof_animalhouseitems; }
            set
            {
                countof_animalhouseitems = value;
                OnPropertyChanged(nameof(Countof_AnimalHouseItems));
            }
        }
        public int Countof_Watercostitems
        {
            get { return countof_watercostitems; }
            set
            {
                countof_watercostitems = value;
                OnPropertyChanged(nameof(Countof_Watercostitems));
            }
        }
        public int Countof_MembershipItems
        {
            get { return countof_MembershipItems; }
            set
            {
                countof_MembershipItems = value;
                OnPropertyChanged(nameof(Countof_MembershipItems));
            }
        }
        public int Countof_OtherCostItems
        {
            get { return countof_othercostitems; }
            set
            {
                countof_othercostitems = value;
                OnPropertyChanged(nameof(Countof_OtherCostItems));
            }
        }
        public int Countof_ReproductiveItems
        {
            get { return countof_reproductiveitems; }
            set
            {
                countof_reproductiveitems = value;
                OnPropertyChanged(nameof(Countof_ReproductiveItems));
            }
        }
        public int Countof_AnimalPurchaseItems
        {
            get { return countof_animalpurchaseitems; }
            set
            {
                countof_animalpurchaseitems = value;
                OnPropertyChanged(nameof(Countof_AnimalPurchaseItems));
            }
        }
        public int Countof_LoanRepaymentItems
        {
            get { return countof_loanrepaymentitems; }
            set
            {
                countof_loanrepaymentitems = value;
                OnPropertyChanged(nameof(Countof_LoanRepaymentItems));
            }
        }
        public int Countof_EquipmentItems
        {
            get { return countof_equipmentitems; }
            set
            {
                countof_equipmentitems = value;
                OnPropertyChanged(nameof(Countof_EquipmentItems));
            }
        }


        private int countOf_FeedItems { get; set; }
        private int countOf_HealthCareItems { get; set; }
        private int countof_labourcostitems { get; set; }
        private int countof_animalhouseitems { get; set; }
        private int countof_watercostitems { get; set; }
        private int countof_MembershipItems { get; set; }
        private int countof_othercostitems { get; set; }
        private int countof_reproductiveitems { get; set; }
        private int countof_animalpurchaseitems { get; set; }
        private int countof_loanrepaymentitems { get; set; }
        private int countof_equipmentitems { get; set; }

        public Command SendDataToApi { get; }

        public SendDataViewModel()
        {
            PageRendered = false;
            LastTimeDataUploaded = User.LastUploadDate.ToUniversalTime();
            SendDataToApi = new Command(PostDataToAPI);
        }

        public async Task PopulateCollections()
        {
            FeedItems = new ObservableCollection<FeedItem>(await repo.GetFeedItemsAndAttachedTranslation(User.UserLang));
            HealthCareItems = new ObservableCollection<HealthCareItem>(await repo.GetHealthCareItems());
            LabourCostItems = new ObservableCollection<LabourCostItem>(await repo.GetLabourCostItems());
            AnimalHouseItems = new ObservableCollection<AnimalHouseItem>(await repo.GetAnimalHouseItems());
            WaterCostItems = new ObservableCollection<WaterCostItem>(await repo.GetWaterCostItems());
            MembershipItems = new ObservableCollection<MembershipItem>(await repo.GetMembershipItems());
            OtherCostItems = new ObservableCollection<OtherCostItem>(await repo.GetOtherCostItems());
            ReproductiveItems = new ObservableCollection<ReproductiveItem>(await repo.GetReproductiveItems());
            AnimalPurchaseItems = new ObservableCollection<AnimalPurchaseItem>(await repo.GetAnimalPurchaseItems());
            LoanRepaymentItems = new ObservableCollection<LoanRepaymentItem>(await repo.GetLoanRepaymentItems());
            EquipmentItems = new ObservableCollection<EquipmentItem>(await repo.GetEquipmentItems());
            CountOf_FeedItems = FeedItems.Count();
            CountOf_HealthCareItems = HealthCareItems.Count();
            Countof_LabourCostItems = LabourCostItems.Count();
            Countof_AnimalHouseItems = AnimalHouseItems.Count();
            Countof_MembershipItems = MembershipItems.Count();
            Countof_Watercostitems = WaterCostItems.Count();
            Countof_OtherCostItems = OtherCostItems.Count();
            Countof_ReproductiveItems = ReproductiveItems.Count();
            Countof_AnimalPurchaseItems = AnimalPurchaseItems.Count();
            Countof_LoanRepaymentItems = LoanRepaymentItems.Count();
            Countof_EquipmentItems = EquipmentItems.Count();
        }


        public async void PostDataToAPI()
        {
            try
            {
                var apiTransfer = new APITransferItem()
                {
                    FeedItems = FeedItems.ToList(),
                    HealthCareItems = HealthCareItems.ToList(),
                    LabourCostItems = LabourCostItems.ToList(),
                    AnimalHouseItems = AnimalHouseItems.ToList(),
                    OtherCostItems = OtherCostItems.ToList(),
                    ReproductiveItems = ReproductiveItems.ToList(),
                    WaterCostItems = WaterCostItems.ToList(),
                    MembershipItems = MembershipItems.ToList(),
                    AnimalPurchaseItems = AnimalPurchaseItems.ToList(),
                    LoanRepaymentItems = LoanRepaymentItems.ToList(),
                    EquipmentItems = EquipmentItems.ToList(),
                };

                User.LastUploadDate = DateTime.Now;
                LastTimeDataUploaded = User.LastUploadDate;

                //await repo.UpdateUserInfo(User);
                var httpClient = new HttpClient();

                httpClient.DefaultRequestHeaders.Add("XApiKey", "ENTER YOUR API KEY HERE");

                var jObject = JsonConvert.SerializeObject(apiTransfer);

                var data = new StringContent(jObject, Encoding.UTF8, "application/json");
                //var url = "https://wsuatapim.azure-api.net/snpit/samples/get";
                var url = "https://localhost:7218/api/data/SubmitData";

                var response = await httpClient.PostAsync(url, data);
                var responseString = await response.Content.ReadAsStringAsync();

                httpClient.Dispose();


                PageRendered = false;

            }
            catch (Exception ex)
            {

            }

        }
    }
}
