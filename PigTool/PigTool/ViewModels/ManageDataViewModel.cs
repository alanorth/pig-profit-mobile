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

        public Command AddFeedItem 
        { 
            get; 
        }

        public ManageDataViewModel()
        {
            PageRendered = false;
            AddFeedItem = new Command<FeedItem>(async (o) => await AddFeedItemDataCommand(o));
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
