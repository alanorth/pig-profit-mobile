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

        private async void GetData()
        {
            // Initial grouping for Feed items
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

            // Appending Health care items to the full list grouped by YearMonth
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
            
            // Group fulllist once more into YearMonths and sort by year then month to get most recent first
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

        }

    }
}
