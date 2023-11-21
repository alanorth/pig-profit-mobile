using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PigTool.Helpers;
using PigTool.Views;
using System.Collections.ObjectModel;

namespace PigTool.ViewModels
{
    public class ManageDataViewModel : LoggedInViewModel, INotifyPropertyChanged
    {

        #region  Translations
        public string Costs { get; private set; }
        public string FeedTrans { get; private set; }
        public string DateObtainedTrans { get; private set; }
        public string FeedTypeTrans { get; private set; }
        public string CostTrans { get; private set; }
        public string LabourCostTrans { get; private set; }
        public string FilterTranslation { get; private set; }
        //shared Translations
        public string TotalCostTranslation { get; private set; }
        public string DateTranslation { get; private set; }
        public string OtherWhatForTranslation { get; private set; }
        public string TotalCostAllUnits { get; private set; }
        //Feed
        public string FeedTypeTranslation { get; private set; }        
        //HeathCare
        public string HealthCareTypeTranslation { get; private set; }
        public string HealthCareCostTranslation { get; private set; }
        //Labour
        public string LabourTypeTranslation { get; private set; }
        public string AmountPaidTranslation { get; private set; }
        //AnimalHousing
        public string HousingExpenseTranslation { get; private set; }
        //Water
        public string WaterPurchasedTranslation { get; private set; }

        //Reproduction
        public string ServiceTypeTranslation { get; private set; }
        public string SowsServicedCostTranslation { get; private set; }
        //Membership
        public string MembershipTypeTranslation { get; private set; }
        //OtherCost
        //Animal Purchase
        public string AnimalTypeTranslation { get; private set; }
        public string TotalAnimalCostsTranslation { get; private set; }
        //loan replayment
        public string TotalAmountRepaidTranslation { get; private set; }
        public string LoanProviderTranslation { get; private set; }
        //equipment
        public string EquipmentTypeTranslation { get; private set; }
        //pig sales
        public string PigTypeTranslation { get; private set; }
        public string SalePriceTranslation { get; private set; }
        //"Breeding Service Sales",
        public string AmountRecievedTranslation { get; private set; }
        //Maure
        public string SoldToTranslation { get; private set; }
        public string ManureAmountRecievedTranslation { get; private set; }
        //Other Income
        public string TotalIncomeTranslation { get; private set;  }
        public string ViewTranslation { get; private set; }
        #endregion



        public bool PageRendered { get; set; }

        private IOrderedEnumerable<FeedItem> feedItems;
        private IOrderedEnumerable<HealthCareItem> healthCareItems;
        private IOrderedEnumerable<LabourCostItem> labourCostItems;
        private IOrderedEnumerable<AnimalHouseItem> animalHouseItems;
        private IOrderedEnumerable<WaterCostItem> waterCostItems;
        private IOrderedEnumerable<MembershipItem> membershipItems;
        private IOrderedEnumerable<OtherCostItem> otherCostItems;
        private IOrderedEnumerable<ReproductiveItem> reproductiveItems;
        private IOrderedEnumerable<AnimalPurchaseItem> animalPurchaseItems;
        private IOrderedEnumerable<LoanRepaymentItem> loanRepaymentItems;
        private IOrderedEnumerable<EquipmentItem> equipmentItems;

        private IOrderedEnumerable<PigSaleItem> pigSaleItems;
        private IOrderedEnumerable<BreedingServiceSaleItem> breedingServiceSaleItems;
        private IOrderedEnumerable<ManureSaleItem> manureSaleItems;
        private IOrderedEnumerable<OtherIncomeItem> otherIncomeItems;

        private int selectedYear = DateTime.Now.Year;

        public IOrderedEnumerable<FeedItem> FeedItems
        {

            get { return feedItems; }
            set
            {
                feedItems = value;
                OnPropertyChanged(nameof(FeedItems));
            }
        }

        public IOrderedEnumerable<HealthCareItem> HealthCareItems
        {

            get { return healthCareItems; }
            set
            {
                healthCareItems = value;
                OnPropertyChanged(nameof(HealthCareItems));
            }
        }

        public IOrderedEnumerable<LabourCostItem> LabourCostItems
        {

            get { return labourCostItems; }
            set
            {
                labourCostItems = value;
                OnPropertyChanged(nameof(LabourCostItems));
            }
        }
        public IOrderedEnumerable<AnimalHouseItem> AnimalHouseItems
        {

            get { return animalHouseItems; }
            set
            {
                animalHouseItems = value;
                OnPropertyChanged(nameof(AnimalHouseItems));
            }
        }

        public IOrderedEnumerable<WaterCostItem> WaterCostItems
        {

            get { return waterCostItems; }
            set
            {
                waterCostItems = value;
                OnPropertyChanged(nameof(WaterCostItems));
            }
        }

        public IOrderedEnumerable<MembershipItem> MembershipItems
        {

            get { return membershipItems; }
            set
            {
                membershipItems = value;
                OnPropertyChanged(nameof(MembershipItems));
            }
        }

        public IOrderedEnumerable<OtherCostItem> OtherCostItems
        {

            get { return otherCostItems; }
            set
            {
                otherCostItems = value;
                OnPropertyChanged(nameof(OtherCostItems));
            }
        }

        public IOrderedEnumerable<ReproductiveItem> ReproductiveItems
        {

            get { return reproductiveItems; }
            set
            {
                reproductiveItems = value;
                OnPropertyChanged(nameof(ReproductiveItems));
            }
        }

        public IOrderedEnumerable<AnimalPurchaseItem> AnimalPurchaseItems
        {

            get { return animalPurchaseItems; }
            set
            {
                animalPurchaseItems = value;
                OnPropertyChanged(nameof(AnimalPurchaseItems));
            }
        }

        public IOrderedEnumerable<LoanRepaymentItem> LoanRepaymentItems
        {

            get { return loanRepaymentItems; }
            set
            {
                loanRepaymentItems = value;
                OnPropertyChanged(nameof(LoanRepaymentItems));
            }
        }

        public IOrderedEnumerable<EquipmentItem> EquipmentItems
        {

            get { return equipmentItems; }
            set
            {
                equipmentItems = value;
                OnPropertyChanged(nameof(EquipmentItems));
            }
        }

        public IOrderedEnumerable<PigSaleItem> PigSaleItems
        {

            get { return pigSaleItems; }
            set
            {
                pigSaleItems = value;
                OnPropertyChanged(nameof(PigSaleItems));
            }
        }

        public IOrderedEnumerable<BreedingServiceSaleItem> BreedingServiceSaleItems
        {

            get { return breedingServiceSaleItems; }
            set
            {
                breedingServiceSaleItems = value;
                OnPropertyChanged(nameof(BreedingServiceSaleItems));
            }
        }

        public IOrderedEnumerable<ManureSaleItem> ManureSaleItems
        {

            get { return manureSaleItems; }
            set
            {
                manureSaleItems = value;
                OnPropertyChanged(nameof(ManureSaleItems));
            }
        }

        public IOrderedEnumerable<OtherIncomeItem> OtherIncomeItems
        {

            get { return otherIncomeItems; }
            set
            {
                otherIncomeItems = value;
                OnPropertyChanged(nameof(OtherIncomeItems));
            }
        }

        public int SelectedYear
        {
            get { return selectedYear; }
            set
            {
                selectedYear = value;
                OnPropertyChanged(nameof(SelectedYear));
                PopulateLists();
            }
        }

        public Command EditFeedItem { get; }
        public Command EditHealthCareItem { get; }
        public Command EditLabourCostItem { get; }
        public Command EditAnimalHouseItem { get; }
        public Command EditWaterCostItem { get; }
        public Command EditMembershipItem { get; }
        public Command EditOtherCostItem { get; }
        public Command EditReproductiveItem { get; }
        public Command EditAnimalPurchaseItem { get; }
        public Command EditLoanRepaymentItem { get; }
        public Command EditEquipmentItem { get; }

        public Command EditPigSaleItem { get; }
        public Command EditBreedingServiceSaleItem { get; }
        public Command EditManureSaleItem { get; }
        public Command EditOtherIncomeItem { get; }

        public ManageDataViewModel()
        {
            PageRendered = false;
            EditFeedItem = new Command<FeedItem>(async (o) => await EditFeedItemDataCommand(o));
            EditHealthCareItem = new Command<HealthCareItem>(async (o) => await EditHealthCareItemCommand(o));
            EditLabourCostItem = new Command<LabourCostItem>(async (o) => await EditLabourCostItemCommand(o));
            EditAnimalHouseItem = new Command<AnimalHouseItem>(async (o) => await EditAnimalHouseItemCommand(o));
            EditWaterCostItem = new Command<WaterCostItem>(async (o) => await EditWaterCostItemCommand(o));
            EditMembershipItem = new Command<MembershipItem>(async (o) => await EditMembershipItemCommand(o));
            EditOtherCostItem = new Command<OtherCostItem>(async (o) => await EditOtherCostItemCommand(o));
            EditReproductiveItem = new Command<ReproductiveItem>(async (o) => await EditReproductiveItemCommand(o));
            EditAnimalPurchaseItem = new Command<AnimalPurchaseItem>(async (o) => await EditAnimalPurchaseItemCommand(o));
            EditLoanRepaymentItem = new Command<LoanRepaymentItem>(async (o) => await EditLoanRepaymentItemCommand(o));
            EditEquipmentItem = new Command<EquipmentItem>(async (o) => await EditEquipmentItemCommand(o));

            EditPigSaleItem = new Command<PigSaleItem>(async (o) => await EditPigSaleItemCommand(o));
            EditBreedingServiceSaleItem = new Command<BreedingServiceSaleItem>(async (o) => await EditBreedingServiceSaleItemCommand(o));
            EditManureSaleItem = new Command<ManureSaleItem>(async (o) => await EditManureSaleItemCommand(o));
            EditOtherIncomeItem = new Command<OtherIncomeItem>(async (o) => await EditOtherIncomeItemCommand(o));

            Costs = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(Costs), User.UserLang);
            DateObtainedTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateObtainedTrans), User.UserLang);
            CostTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CostTrans), User.UserLang);
            LabourCostTrans = LogicHelper.GetTranslationFromStore(TranslationStore, "Labour", User.UserLang);
            FilterTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(FilterTranslation), User.UserLang);

            //shared Translations
            TotalCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TotalCostTranslation), User.UserLang);
            DateTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateTranslation), User.UserLang);
            OtherWhatForTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherWhatForTranslation), User.UserLang);
            //Feed
            FeedTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(FeedTypeTranslation), User.UserLang);
            TotalCostAllUnits = LogicHelper.GetTranslationFromStore(TranslationStore, "TotalCostTranslation", User.UserLang);
            //HeathCare
            HealthCareTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(HealthCareTypeTranslation), User.UserLang);
            HealthCareCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(HealthCareCostTranslation), User.UserLang);
            //Labour
            LabourTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LabourTypeTranslation), User.UserLang);
            AmountPaidTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(AmountPaidTranslation), User.UserLang);
            //AnimalHousing
            HousingExpenseTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(HousingExpenseTranslation), User.UserLang);
            //Water
            WaterPurchasedTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(WaterPurchasedTranslation), User.UserLang);

            //Reproduction
            ServiceTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ServiceTypeTranslation), User.UserLang);
            SowsServicedCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SowsServicedCostTranslation), User.UserLang);
            //Membership
            MembershipTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(MembershipTypeTranslation), User.UserLang);
            //OtherCost
            OtherWhatForTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(OtherWhatForTranslation), User.UserLang);
            //Animal Purchase
            AnimalTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(AnimalTypeTranslation), User.UserLang);
            TotalAnimalCostsTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TotalAnimalCostsTranslation), User.UserLang);
            //loan replayment
            TotalAmountRepaidTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TotalAmountRepaidTranslation), User.UserLang);
            LoanProviderTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LoanProviderTranslation), User.UserLang);
            //equipment
            EquipmentTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(EquipmentTypeTranslation), User.UserLang);
            //pig sales
            PigTypeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PigTypeTranslation), User.UserLang);
            SalePriceTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SalePriceTranslation), User.UserLang);
            //"Breeding Service Sales",
            AmountRecievedTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(AmountRecievedTranslation), User.UserLang);
            //Maure
            SoldToTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SoldToTranslation), User.UserLang);
            ManureAmountRecievedTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ManureAmountRecievedTranslation), User.UserLang);
            //Other Income
            TotalIncomeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(TotalIncomeTranslation), User.UserLang);

            //ViewButtonTransaltion
            ViewTranslation =  LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ViewTranslation), User.UserLang);


        }


        public async Task PopulateLists()
        {
            //Cost Items
            FeedItems = new ObservableCollection<FeedItem>(await repo.GetFeedItemsAndAttachedTranslation(selectedYear, User.UserLang)).OrderByDescending(x => x.Date);//GetFeedItemsAndAttachedTranslation(selectedYear,User.UserLang) to fix dropdown translation
            HealthCareItems = new ObservableCollection<HealthCareItem>(await repo.GetHealthCareItems(selectedYear, User.UserLang)).OrderByDescending(x => x.Date); 
            LabourCostItems = new ObservableCollection<LabourCostItem>(await repo.GetLabourCostItems(selectedYear, User.UserLang)).OrderByDescending(x => x.Date);
            AnimalHouseItems = new ObservableCollection<AnimalHouseItem>(await repo.GetAnimalHouseItems(selectedYear, User.UserLang)).OrderByDescending(x => x.Date);
            WaterCostItems = new ObservableCollection<WaterCostItem>(await repo.GetWaterCostItems(selectedYear)).OrderByDescending(x => x.Date);
            MembershipItems = new ObservableCollection<MembershipItem>(await repo.GetMembershipItems(selectedYear, User.UserLang)).OrderByDescending(x => x.Date);
            OtherCostItems = new ObservableCollection<OtherCostItem>(await repo.GetOtherCostItems(selectedYear)).OrderByDescending(x => x.Date);
            ReproductiveItems = new ObservableCollection<ReproductiveItem>(await repo.GetReproductiveItems(selectedYear, User.UserLang)).OrderByDescending(x => x.Date);
            AnimalPurchaseItems = new ObservableCollection<AnimalPurchaseItem>(await repo.GetAnimalPurchaseItems(selectedYear, User.UserLang)).OrderByDescending(x => x.Date);
            LoanRepaymentItems = new ObservableCollection<LoanRepaymentItem>(await repo.GetLoanRepaymentItems(selectedYear, User.UserLang)).OrderByDescending(x => x.Date);
            EquipmentItems = new ObservableCollection<EquipmentItem>(await repo.GetEquipmentItems(selectedYear, User.UserLang)).OrderByDescending(x => x.Date);
            //Revenue Items
            PigSaleItems = new ObservableCollection<PigSaleItem>(await repo.GetPigSaleItems(selectedYear, User.UserLang)).OrderByDescending(x => x.Date);
            BreedingServiceSaleItems = new ObservableCollection<BreedingServiceSaleItem>(await repo.GetBreedingServiceSaleItems(selectedYear, User.UserLang)).OrderByDescending(x => x.Date);
            ManureSaleItems = new ObservableCollection<ManureSaleItem>(await repo.GetManureSaleItems(selectedYear, User.UserLang)).OrderByDescending(x => x.Date);
            OtherIncomeItems = new ObservableCollection<OtherIncomeItem>(await repo.GetOtherIncomeItems(selectedYear)).OrderByDescending(x => x.Date);
        }
        private async Task EditFeedItemDataCommand(FeedItem feed)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new FeedItemPage(feed));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task EditHealthCareItemCommand(HealthCareItem item)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new HealthCarePage(item));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task EditLabourCostItemCommand(LabourCostItem item)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new LabourCostPage(item));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task EditAnimalHouseItemCommand(AnimalHouseItem item)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new AnimalHousingPage(item));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task EditWaterCostItemCommand(WaterCostItem item)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new WaterCostPage(item));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task EditMembershipItemCommand(MembershipItem item)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new MembershipPage(item));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task EditOtherCostItemCommand(OtherCostItem item)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new OtherCostPage(item));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task EditReproductiveItemCommand(ReproductiveItem item)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new ReproductivePage(item));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task EditAnimalPurchaseItemCommand(AnimalPurchaseItem item)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new AnimalPurchasePage(item));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task EditLoanRepaymentItemCommand(LoanRepaymentItem item)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new LoanRepaymentPage(item));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task EditEquipmentItemCommand(EquipmentItem item)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new EquipmentPage(item));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task EditPigSaleItemCommand(PigSaleItem item)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new PigSalePage(item));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task EditBreedingServiceSaleItemCommand(BreedingServiceSaleItem item)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new BreedingServiceSalePage(item));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task EditManureSaleItemCommand(ManureSaleItem item)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new ManureSalePage(item));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task EditOtherIncomeItemCommand(OtherIncomeItem item)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new OtherIncomePage(item));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
