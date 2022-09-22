using PigTool.Models;
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
        public string Costs { get; set; }
        public string FeedTrans { get; set; }
        public string DateObtainedTrans { get; set; }
        public string FeedTypeTrans { get; set; }
        public string CostTrans { get; set; }
        public string LabourCostTrans { get; set; }

        #endregion



        public bool PageRendered { get; set; }

        private ObservableCollection<FeedItem> feedItems;
        private ObservableCollection<HealthCareItem> healthCareItems;
        private ObservableCollection<LabourCostItem> labourCostItems;
        private ObservableCollection<AnimalHouseItem> animalHouseItems;
        private ObservableCollection<WaterCostItem> waterCostItems;
        private ObservableCollection<MembershipItem> membershipItems;
        private ObservableCollection<OtherCostItem> otherCostItems;

        public ObservableCollection<FeedItem> FeedItems
        {

            get { return feedItems; }
            set
            {
                feedItems = value;
                OnPropertyChanged(nameof(FeedItems));
            }
        }

        public ObservableCollection<HealthCareItem> HealthCareItems
        {

            get { return healthCareItems; }
            set
            {
                healthCareItems = value;
                OnPropertyChanged(nameof(HealthCareItems));
            }
        }

        public ObservableCollection<LabourCostItem> LabourCostItems
        {

            get { return labourCostItems; }
            set
            {
                labourCostItems = value;
                OnPropertyChanged(nameof(LabourCostItems));
            }
        }
        public ObservableCollection<AnimalHouseItem> AnimalHouseItems
        {

            get { return animalHouseItems; }
            set
            {
                animalHouseItems = value;
                OnPropertyChanged(nameof(AnimalHouseItems));
            }
        }

        public ObservableCollection<WaterCostItem> WaterCostItems
        {

            get { return waterCostItems; }
            set
            {
                waterCostItems = value;
                OnPropertyChanged(nameof(WaterCostItems));
            }
        }

        public ObservableCollection<MembershipItem> MembershipItems
        {

            get { return membershipItems; }
            set
            {
                membershipItems = value;
                OnPropertyChanged(nameof(MembershipItems));
            }
        }

        public ObservableCollection<OtherCostItem> OtherCostItems
        {

            get { return otherCostItems; }
            set
            {
                otherCostItems = value;
                OnPropertyChanged(nameof(OtherCostItems));
            }
        }

        public Command EditFeedItem { get; }
        public Command EditHealthCareItem { get; }
        public Command EditLabourCostItem { get; }
        public Command EditAnimalHouseItem { get; }
        public Command EditWaterCostItem { get; }
        public Command EditMembershipItem { get; }
        public Command EditOtherCostItem { get; }

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


            Costs = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(Costs), User.UserLang);
            DateObtainedTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateObtainedTrans), User.UserLang);
            CostTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CostTrans), User.UserLang);
            LabourCostTrans = LogicHelper.GetTranslationFromStore(TranslationStore, "Labour", User.UserLang);
        }


        public async Task PopulateLists()
        {
            //FeedItems = new ObservableCollection<FeedItem>(await repo.GetFeedItems());
            FeedItems = new ObservableCollection<FeedItem>(await repo.GetFeedItemsAndAttachedTranslation(User.UserLang));
            HealthCareItems = new ObservableCollection<HealthCareItem>(await repo.GetHealthCareItems());
            LabourCostItems = new ObservableCollection<LabourCostItem>(await repo.GetLabourCostItems());
            AnimalHouseItems = new ObservableCollection<AnimalHouseItem>(await repo.GetAnimalHouseItems());
            WaterCostItems = new ObservableCollection<WaterCostItem>(await repo.GetWaterCostItems());
            MembershipItems = new ObservableCollection<MembershipItem>(await repo.GetMembershipItems());
            OtherCostItems = new ObservableCollection<OtherCostItem>(await repo.GetOtherCostItems());
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

    }
}
