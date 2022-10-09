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

        private ObservableCollection<PigSaleItem> pigSaleItems;

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

        public ObservableCollection<PigSaleItem> PigSaleItems
        {
            get { return pigSaleItems; }
            set
            {
                pigSaleItems = new ObservableCollection<PigSaleItem>(value.Where(x => x.LastModified > LastTimeDataUploaded).ToList());
                OnPropertyChanged(nameof(PigSaleItems));
            }
        }


        public Command SendDataToApi { get; }

        public SendDataViewModel()
        {
            PageRendered = false;
            LastTimeDataUploaded = User.LastUploadDate.ToUniversalTime();
            SendDataToApi = new Command(PostDataToAPI);
        }

        public async Task PopulateCollections()
        {
            if (!PageRendered)
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

                PigSaleItems = new ObservableCollection<PigSaleItem>(await repo.GetPigSaleItems());
            }

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

                    PigSaleItems = PigSaleItems.ToList(),
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


            }
            catch(Exception ex)
            {

            }
           
        }
    }
}
