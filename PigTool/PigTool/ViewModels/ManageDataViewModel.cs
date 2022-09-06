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
        public string Feed { get; set; }
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

        public Command AddFeedItem { get; }
        public Command EditHealthCareItem { get; }
        public Command EditLabourCostItem { get; }
        public Command EditAnimalHouseItem { get; }

        public ManageDataViewModel()
        {
            PageRendered = false;
            AddFeedItem = new Command<FeedItem>(async (o) => await AddFeedItemDataCommand(o));
            EditHealthCareItem = new Command<HealthCareItem>(async (o) => await EditHealthCareItemCommand(o));
            EditLabourCostItem = new Command<LabourCostItem>(async (o) => await EditLabourCostItemCommand(o));
            EditAnimalHouseItem = new Command<AnimalHouseItem>(async (o) => await EditAnimalHouseItemCommand(o));

            Costs = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(Costs), User.UserLang);
            Feed = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(Feed), User.UserLang);
            DateObtainedTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateObtainedTrans), User.UserLang);
            FeedTypeTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(FeedTypeTrans), User.UserLang);
            CostTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CostTrans), User.UserLang);
            LabourCostTrans = LogicHelper.GetTranslationFromStore(TranslationStore, "Labour", User.UserLang);
            //AnimalHouseTrans = LogicHelper.GetTranslationFromStore(TranslationStore, "Housing", User.UserLang);

        }


        public async Task PopulateLists()
        {
            FeedItems = new ObservableCollection <FeedItem>(await repo.GetFeedItems());
            HealthCareItems =  new ObservableCollection<HealthCareItem>(await repo.GetHealthCareItems());
            LabourCostItems = new ObservableCollection<LabourCostItem>(await repo.GetLabourCostItems());
            AnimalHouseItems = new ObservableCollection<AnimalHouseItem>(await repo.GetAnimalHouseItems());
        }

        private async Task AddFeedItemDataCommand(FeedItem feed)
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

    }
}
