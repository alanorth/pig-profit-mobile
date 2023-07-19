using Newtonsoft.Json;
using PigTool.Services;
using PigTool.Views.Popups;
using Rg.Plugins.Popup.Services;
using Shared;
using Shared.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PigTool.ViewModels
{
    public class SendDataViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        public bool PageRendered { get; set; }

        public DateTime LastTimeDataUploaded
        {
            get => lastTimeDataUploaded;
            set
            {
                lastTimeDataUploaded = value;
                TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
                LastUploadTime = TimeZoneInfo.ConvertTimeFromUtc(lastTimeDataUploaded, localTimeZone).ToString();
                OnPropertyChanged(nameof(LastTimeDataUploaded));
            }
        }
        public string uploadDataTranslation { get; set; }

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
        private ObservableCollection<BreedingServiceSaleItem> breedingServiceSaleItems;
        private ObservableCollection<ManureSaleItem> manureSaleItems;
        private ObservableCollection<OtherIncomeItem> otherIncomeItems;

        private DateTime lastTimeDataUploaded;
        private string lastUploadTime;
        private string sendDataUploadTimeLabel;

        public ObservableCollection<FeedItem> FeedItems
        {

            get { return feedItems; }
            set
            {
                feedItems = new ObservableCollection<FeedItem>(value.Where(x => x.LastModified > LastTimeDataUploaded.ToUniversalTime()).ToList());
                OnPropertyChanged(nameof(FeedItems));
            }
        }
        public ObservableCollection<HealthCareItem> HealthCareItems
        {

            get { return healthCareItems; }
            set
            {
                healthCareItems = new ObservableCollection<HealthCareItem>(value.Where(x => x.LastModified > LastTimeDataUploaded.ToUniversalTime()).ToList());
                OnPropertyChanged(nameof(HealthCareItems));
            }
        }
        public ObservableCollection<LabourCostItem> LabourCostItems
        {

            get { return labourCostItems; }
            set
            {
                labourCostItems = new ObservableCollection<LabourCostItem>(value.Where(x => x.LastModified > LastTimeDataUploaded.ToUniversalTime()).ToList());
                OnPropertyChanged(nameof(LabourCostItems));
            }
        }
        public ObservableCollection<AnimalHouseItem> AnimalHouseItems
        {

            get { return animalHouseItems; }
            set
            {
                animalHouseItems = new ObservableCollection<AnimalHouseItem>(value.Where(x => x.LastModified > LastTimeDataUploaded.ToUniversalTime()).ToList());
                OnPropertyChanged(nameof(AnimalHouseItems));
            }
        }
        public ObservableCollection<WaterCostItem> WaterCostItems
        {

            get { return waterCostItems; }
            set
            {
                waterCostItems = new ObservableCollection<WaterCostItem>(value.Where(x => x.LastModified > LastTimeDataUploaded.ToUniversalTime()).ToList());
                OnPropertyChanged(nameof(WaterCostItems));
            }
        }
        public ObservableCollection<MembershipItem> MembershipItems
        {

            get { return membershipItems; }
            set
            {
                membershipItems =
                    new ObservableCollection<MembershipItem>(value.Where(x => x.LastModified > LastTimeDataUploaded.ToUniversalTime()).ToList());
                OnPropertyChanged(nameof(MembershipItems));
            }
        }
        public ObservableCollection<OtherCostItem> OtherCostItems
        {

            get { return otherCostItems; }
            set
            {
                value.Where(x => x.LastModified > LastTimeDataUploaded);

                otherCostItems = new ObservableCollection<OtherCostItem>(value.Where(x => x.LastModified > LastTimeDataUploaded.ToUniversalTime()).ToList());
                OnPropertyChanged(nameof(OtherCostItems));
            }
        }
        public ObservableCollection<ReproductiveItem> ReproductiveItems
        {

            get { return reproductiveItems; }
            set
            {
                reproductiveItems = new ObservableCollection<ReproductiveItem>(value.Where(x => x.LastModified > LastTimeDataUploaded.ToUniversalTime()).ToList());
                OnPropertyChanged(nameof(ReproductiveItems));
            }
        }
        public ObservableCollection<AnimalPurchaseItem> AnimalPurchaseItems
        {

            get { return animalPurchaseItems; }
            set
            {
                value.Where(x => x.LastModified > LastTimeDataUploaded);

                animalPurchaseItems = new ObservableCollection<AnimalPurchaseItem>(value.Where(x => x.LastModified > LastTimeDataUploaded.ToUniversalTime()).ToList());
                OnPropertyChanged(nameof(AnimalPurchaseItems));
            }
        }
        public ObservableCollection<LoanRepaymentItem> LoanRepaymentItems
        {

            get { return loanRepaymentItems; }
            set
            {
                loanRepaymentItems = new ObservableCollection<LoanRepaymentItem>(value.Where(x => x.LastModified > LastTimeDataUploaded.ToUniversalTime()).ToList());
                OnPropertyChanged(nameof(LoanRepaymentItems));
            }
        }
        public ObservableCollection<EquipmentItem> EquipmentItems
        {
            get { return equipmentItems; }
            set
            {
                equipmentItems = new ObservableCollection<EquipmentItem>(value.Where(x => x.LastModified > LastTimeDataUploaded.ToUniversalTime()).ToList());
                OnPropertyChanged(nameof(EquipmentItems));
            }
        }
        public ObservableCollection<PigSaleItem> PigSaleItems
        {
            get { return pigSaleItems; }
            set
            {
                pigSaleItems = new ObservableCollection<PigSaleItem>(value.Where(x => x.LastModified > LastTimeDataUploaded.ToUniversalTime()).ToList());
                OnPropertyChanged(nameof(PigSaleItems));
            }
        }

        public ObservableCollection<BreedingServiceSaleItem> BreedingServiceSaleItems
        {
            get { return breedingServiceSaleItems; }
            set
            {
                breedingServiceSaleItems = new ObservableCollection<BreedingServiceSaleItem>(value.Where(x => x.LastModified > LastTimeDataUploaded.ToUniversalTime()).ToList());
                OnPropertyChanged(nameof(BreedingServiceSaleItems));
            }
        }

        public ObservableCollection<ManureSaleItem> ManureSaleItems
        {
            get { return manureSaleItems; }
            set
            {
                manureSaleItems = new ObservableCollection<ManureSaleItem>(value.Where(x => x.LastModified > LastTimeDataUploaded.ToUniversalTime()).ToList());
                OnPropertyChanged(nameof(ManureSaleItems));
            }
        }

        public ObservableCollection<OtherIncomeItem> OtherIncomeItems
        {
            get { return otherIncomeItems; }
            set
            {
                otherIncomeItems = new ObservableCollection<OtherIncomeItem>(value.Where(x => x.LastModified > LastTimeDataUploaded.ToUniversalTime()).ToList());
                OnPropertyChanged(nameof(OtherIncomeItems));
            }
        }

        public string UploadDataTranslation
        {
            get { return uploadDataTranslation; }
            set
            {
                uploadDataTranslation = value;
                OnPropertyChanged(nameof(UploadDataTranslation));
            }
        }

        public string SendDataUploadTimeLabel {
            get { return sendDataUploadTimeLabel; }
            set
            {
                sendDataUploadTimeLabel = value;
                OnPropertyChanged(nameof(SendDataUploadTimeLabel));
            }
        }

        public string SendingData { get; private set; }

        public int CountOf_FeedItems
        {
            get { return countOf_FeedItems; }
            set
            {
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
        public int Countof_PigSaleItems
        {
            get { return countof_pigsaleitems; }
            set
            {
                countof_pigsaleitems = value;
                OnPropertyChanged(nameof(Countof_PigSaleItems));
            }
        }

        public int Countof_BreedingServiceSaleItems
        {
            get { return countof_breedingservicesaleitems; }
            set
            {
                countof_breedingservicesaleitems = value;
                OnPropertyChanged(nameof(Countof_BreedingServiceSaleItems));
            }
        }

        public int Countof_ManureSaleItems
        {
            get { return countof_manuresaleitems; }
            set
            {
                countof_manuresaleitems = value;
                OnPropertyChanged(nameof(Countof_ManureSaleItems));
            }
        }

        public int Countof_OtherIncomeItems
        {
            get { return countof_otherincomeitems; }
            set
            {
                countof_otherincomeitems = value;
                OnPropertyChanged(nameof(Countof_OtherIncomeItems));
            }
        }

        public int Countof_TotalItems
        {
            get { return countof_totalitems; }
            set
            {
                countof_totalitems = value;
                OnPropertyChanged(nameof(Countof_TotalItems));
            }
        }

        public string LastUploadTime
        {
            get { return lastUploadTime; }
            set
            {
                lastUploadTime = value;
                OnPropertyChanged(nameof(LastUploadTime));
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

        private int countof_pigsaleitems { get; set; }
        private int countof_breedingservicesaleitems { get; set; }
        private int countof_manuresaleitems { get; set; }
        private int countof_otherincomeitems { get; set; }

        private int countof_totalitems { get; set; }

        public Command SendDataToApi { get; }

        public SendDataViewModel()
        {

            PageRendered = false;
            LastTimeDataUploaded = User.LastUploadDate.ToUniversalTime();
            SendDataToApi = new Command(PostDataToAPI);
        }

        public async Task PopulateCollections()
        {
            UploadDataTranslation = repo.GetTranslationAsync(nameof(UploadDataTranslation)).Result.getTranslation(User.UserLang);
            SendDataUploadTimeLabel = repo.GetTranslationAsync(nameof(SendDataUploadTimeLabel)).Result.getTranslation(User.UserLang);
            SendingData = repo.GetTranslationAsync(nameof(SendingData)).Result.getTranslation(User.UserLang);

            //FeedItems = new ObservableCollection<FeedItem>(await repo.GetFeedItemsAndAttachedTranslation(User.UserLang));
            FeedItems = new ObservableCollection<FeedItem>(await repo.GetFeedItems());
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
            BreedingServiceSaleItems = new ObservableCollection<BreedingServiceSaleItem>(await repo.GetBreedingServiceSaleItems());
            ManureSaleItems = new ObservableCollection<ManureSaleItem>(await repo.GetManureSaleItems());
            OtherIncomeItems = new ObservableCollection<OtherIncomeItem>(await repo.GetOtherIncomeItems());
            Countof_TotalItems = 0;
            Countof_TotalItems += CountOf_FeedItems = FeedItems.Count();
            Countof_TotalItems += CountOf_HealthCareItems = HealthCareItems.Count();
            Countof_TotalItems += Countof_LabourCostItems = LabourCostItems.Count();
            Countof_TotalItems += Countof_AnimalHouseItems = AnimalHouseItems.Count();
            Countof_TotalItems += Countof_MembershipItems = MembershipItems.Count();
            Countof_TotalItems += Countof_Watercostitems = WaterCostItems.Count();
            Countof_TotalItems += Countof_OtherCostItems = OtherCostItems.Count();
            Countof_TotalItems += Countof_ReproductiveItems = ReproductiveItems.Count();
            Countof_TotalItems += Countof_AnimalPurchaseItems = AnimalPurchaseItems.Count();
            Countof_TotalItems += Countof_LoanRepaymentItems = LoanRepaymentItems.Count();
            Countof_TotalItems += Countof_EquipmentItems = EquipmentItems.Count();
            Countof_TotalItems += Countof_PigSaleItems = PigSaleItems.Count();
            Countof_TotalItems += Countof_BreedingServiceSaleItems = BreedingServiceSaleItems.Count();
            Countof_TotalItems += Countof_ManureSaleItems = ManureSaleItems.Count();
            Countof_TotalItems += Countof_OtherIncomeItems = OtherIncomeItems.Count();
        }


        public async void PostDataToAPI()
        {
            LoadingOverlay overlay = new LoadingOverlay(SendingData);
            await PopupNavigation.Instance.PushAsync(overlay);
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
                    BreedingServiceSaleItems = BreedingServiceSaleItems.ToList(),
                    ManureSaleItems = ManureSaleItems.ToList(),
                    OtherIncomeItems = OtherIncomeItems.ToList(),
                };
                var SerialisedData = JsonConvert.SerializeObject(apiTransfer, new JsonSerializerSettings
                {
                    DateTimeZoneHandling = DateTimeZoneHandling.Utc
                });

                var rest = new RESTService(User);

                //go save to database  
                //maybe check to see if there are under data coverage
               var details = await rest.ExecuteWithRetryAsync(async () =>
                {
                    using (var client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Add("Authorization", $"bearer {User.AuthorisedToken}");
                        var mobUser = JsonConvert.SerializeObject(User, new JsonSerializerSettings
                        {
                            DateTimeZoneHandling = DateTimeZoneHandling.Utc
                        });
                        var content = new StringContent(SerialisedData, Encoding.UTF8, "application/json");
                        var responseMessage = await client.PostAsync(Constants.BASEURL + Constants.ROUTE_API_SUBMITDATA, content);
                        responseMessage.EnsureSuccessStatusCode();

                        var jsonResponse = await responseMessage.Content.ReadAsStringAsync();

                        //var response = JsonConvert.DeserializeObject<MobileUser>(jsonResponse);
                        return jsonResponse;
                    }
                });

                var res = JsonConvert.DeserializeObject<DataUploadResponse>(details);

                if (res.Success)
                {
                    User.LastUploadDate = DateTime.UtcNow;
                    LastTimeDataUploaded = User.LastUploadDate;
                    await repo.UpdateUserInfo(User);
                    await PopulateCollections();
                    await Application.Current.MainPage.DisplayAlert("Data Uploaded!", "The Data has been uploaded", OK);
                    Countof_TotalItems = 0;

                }
                else
                {
                    try
                    {
                        var stringBuilder = new StringBuilder();
                        stringBuilder.Append(res.Message.Replace("'",""));
                        await Application.Current.MainPage.DisplayAlert(Error, stringBuilder.ToString(), OK);
                    }catch(Exception ex)
                    {
                        await Application.Current.MainPage.DisplayAlert(Error, "Upload Failed", OK);
                    }
                }

                await PopupNavigation.Instance.PopAsync();

                PageRendered = false;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                await Application.Current.MainPage.DisplayAlert(Error, ex.Message.ToString(), OK);
                await PopupNavigation.Instance.PopAsync();
            }

        }
    }
}
