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
        public List<Row> fullList;
        public double totalPeriodRevenue;
        public double totalPeriodCost;
        public double totalPeriodDifference;

        private Dictionary<string, object> data;
        private ObservableCollection<FeedItem> feedItems;
        private ObservableCollection<HealthCareItem> healthCareItems;

        public List<Row> FullList
        {
            get { return fullList; }
            set
            {
                fullList = value;
                OnPropertyChanged(nameof(FullList));
            }
        }
        public double TotalPeriodRevenue
        {
            get => totalPeriodRevenue;
            set
            {
                if (value != totalPeriodRevenue)
                {
                    totalPeriodRevenue = value;
                    OnPropertyChanged(nameof(TotalPeriodRevenue));
                }
            }
        }
        public double TotalPeriodCost
        {
            get => totalPeriodCost;
            set
            {
                if (value != totalPeriodCost)
                {
                    totalPeriodCost = value;
                    OnPropertyChanged(nameof(TotalPeriodCost));
                }
            }
        }
        public double TotalPeriodDifference
        {
            get => totalPeriodDifference;
            set
            {
                if (value != totalPeriodDifference)
                {
                    totalPeriodDifference = value;
                    OnPropertyChanged(nameof(TotalPeriodDifference));
                }
            }
        }
        /*
        public Dictionary<string, object> Data
        {
            get { return data; }
            set
            {
                data = value;
                OnPropertyChanged(nameof(Data));
            }
        }
        */
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
        public class YearMonth : IEquatable<YearMonth>
        {
            public int Year { get; set; }
            public int Month { get; set; }

            public override bool Equals(object other)
            {
                if (ReferenceEquals(null, other)) return false;
                if (ReferenceEquals(this, other)) return true;
                if (this.GetType() != other.GetType())
                    return false;
                return Equals((YearMonth)other);
            }

            public override int GetHashCode()
            {
                return Year.GetHashCode() + Month.GetHashCode();
            }

            public bool Equals(YearMonth other)
            {
                var result =
                other.Month == Month &&
                other.Year == Year
                ;
                return result;
            }
        }

        public class Row
        {
            public YearMonth YearMonth { get; set; }
            public double Cost {  get; set; }
            public double Revenue { get; set; }
            public double Difference { get; set; }
        }
        /*
        public class Column
        {
            public double Cost { get; set; }
            public double Profit { get; set; }
            public double Difference { get; set; }
        }
        */
        private async void GetData()
        {

            FeedItems = new ObservableCollection<FeedItem>(await repo.GetFeedItems());
            fullList = feedItems.GroupBy(fi => new YearMonth
            { 
                Year = fi.Date.Year, Month = fi.Date.Month }).Select(fi => new Row
                {
                    YearMonth = fi.Key, 
                    Cost = fi.Sum(i => i.TotalCosts) + fi.Sum(i => i.TransportationCost),
                    Revenue = 0,
                    Difference = 0
                }).ToList();

            HealthCareItems = new ObservableCollection<HealthCareItem>(await repo.GetHealthCareItems());
            fullList = fullList.Concat(HealthCareItems.GroupBy(fi => new YearMonth
            {
                Year = fi.Date.Year, Month = fi.Date.Month }).Select(fi => new Row
                {
                    YearMonth = fi.Key,
                    Cost = fi.Sum(i => i.MedicineCost) + fi.Sum(i => i.TransportationCost) + fi.Sum(i => i.OtherCosts),
                    Revenue = 0,
                    Difference = 0
                }).ToList()).ToList();
            
            fullList = fullList.GroupBy(fl => new YearMonth{
                Year = fl.YearMonth.Year, Month = fl.YearMonth.Month })
                .Select(fl => new Row
                {
                    YearMonth = fl.Key,
                    Cost = fl.Sum(i => i.Cost),
                    Revenue = fl.Sum(i => i.Revenue),
                    Difference = fl.Sum(i => i.Revenue) - fl.Sum(i => i.Cost)
                }).OrderByDescending(fl => fl.YearMonth.Year).ThenByDescending(fl => fl.YearMonth.Month).ToList();

            //Calculate totals
            totalPeriodCost = fullList.Sum(fl => fl.Cost);
            totalPeriodRevenue = fullList.Sum(fl => fl.Revenue);
            totalPeriodDifference = totalPeriodRevenue - totalPeriodCost;


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

            // calculate difference in revenue - cost
            foreach(KeyValuePair<string, object> item in data)
            {
                Column x = (Column)item.Value;
                x.Difference = x.Profit - x.Cost;
                //item.Value = x;
            }

            */

        }

    }
}
