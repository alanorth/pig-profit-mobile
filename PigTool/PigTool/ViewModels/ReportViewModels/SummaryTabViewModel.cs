using PigTool.Views;
using Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Linq;

namespace PigTool.ViewModels
{
    public class SummaryTabViewModel : LoggedInViewModel
    {
        #region Collections
        private ObservableCollection<FeedItem> feedItems;
        private ObservableCollection<HealthCareItem> healthCareItems;

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
        #endregion

        public SummaryTabViewModel()
        {
            GetData();
        }

        public class Column
        {
            public double Cost {  get; set; }
            public double Profit { get; set; }
        }

        private async void GetData()
        {
            /*
            // Get data between dates
            FeedItems = new ObservableCollection<FeedItem>(await repo.GetFeedItems());
            HealthCareItems = new ObservableCollection<HealthCareItem>(await repo.GetHealthCareItems());

            Dictionary<string, object> data = new Dictionary<string, object>();

            // get start and end month/year
            var StartMonth = 1;
            var EndMonth = 12;
            var StartYear = 2021;
            var EndYear = 2022;

            // generate dictionary for date range
            DateTime date = new DateTime(StartYear, StartMonth, 1);
            var test = (EndMonth + 12 * (EndYear - StartYear));
            for (var i = StartMonth - 1; i < test; i++)
            {
                
                var m = date.Month;
                var y = date.Year;
                data.Add(m+"-"+y, new Column { Cost = 0, Profit = 0 });
                date = date.AddMonths(1);
            }
            
            // sum numbers into data dictionary
            for (int i = 0; i < FeedItems.Count; i++)
            {
                string id = FeedItems[i].Date.Month + "-" + FeedItems[i].Date.Year;
                Column x = (Column)data[id];
                x.Cost += FeedItems[i].TotalCosts;
                x.Cost += FeedItems[i].TransportationCost;
                data[id] = x;
            }

            // calculate totals
            //var Costs = FeedItems.Sum(item => item.TotalCosts) + FeedItems.Sum(item => item.TransportationCost);

            */
        }

    }
}
