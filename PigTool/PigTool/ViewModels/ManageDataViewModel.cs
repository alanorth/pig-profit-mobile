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

        #endregion



        public bool PageRendered { get; set; }

        public ObservableCollection<FeedItem> feedItems;

        public ObservableCollection<FeedItem> FeedItems
        {

            get { return feedItems; }
            set
            {
                feedItems = value;
                OnPropertyChanged(nameof(FeedItems));
            }
        }

        public Command AddFeedItem { get; }

        public ManageDataViewModel()
        {
            PageRendered = false;
            AddFeedItem = new Command<FeedItem>(async (o) => await AddFeedItemDataCommand(o));

            Costs = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(Costs), User.UserLang);
            Feed = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(Feed), User.UserLang);
            DateObtainedTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(DateObtainedTrans), User.UserLang);
            FeedTypeTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(FeedTypeTrans), User.UserLang);
            CostTrans = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(CostTrans), User.UserLang);


        }


        public async Task<List <FeedItem>> PopulateFeedItemList()
        {
            var feedItemList = await repo.GetFeedItems();

            return feedItemList;
        }

        private async Task AddFeedItemDataCommand(FeedItem feed)
        {
            try
            {
                Console.WriteLine(feed.GetType()?.ToString());
                await Application.Current.MainPage.Navigation.PushAsync(new FeedItemPage(feed));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
