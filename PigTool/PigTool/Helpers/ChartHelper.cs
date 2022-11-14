using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using PigTool.Services;
using Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PigTool.Helpers
{
    public class ChartHelper
    {
        public IDataRepo repo;
        public List<Translation> TranslationStore;
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Row> fullList;
        public double totalPeriodRevenue;
        public double totalPeriodCost;
        public double totalPeriodDifference;

        private ObservableCollection<FeedItem> feedItems;
        private ObservableCollection<HealthCareItem> healthCareItems;
        private ObservableCollection<PigSaleItem> pigSaleItems;

        #region Variables
        public List<Row> FullList
        {
            get { return fullList; }
            set
            {
                fullList = value;
                OnPropertyChanged(nameof(FullList));
            }
        }
        
        #endregion

        #region Collections
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

        public ObservableCollection<PigSaleItem> PigSaleItems
        {

            get { return pigSaleItems; }
            set
            {
                pigSaleItems = value;
                OnPropertyChanged(nameof(PigSaleItems));
            }
        }
        #endregion

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
            public double Cost { get; set; }
            public double Revenue { get; set; }
            public double Difference { get; set; }
        }

        public ChartHelper()
        {
            repo = DependencyService.Get<IDataRepo>();
            TranslationStore = repo.GetAllTranslations().Result;
        }

        public async Task<(List<Row>, double, double, double)> GetData()
        {
            // Initial grouping for Feed items
            FeedItems = new ObservableCollection<FeedItem>(await repo.GetFeedItems());
            fullList = feedItems.GroupBy(fi => new YearMonth
            {
                Year = fi.Date.Year,
                Month = fi.Date.Month
            }).Select(fi => new Row
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
                Year = fi.Date.Year,
                Month = fi.Date.Month
            }).Select(fi => new Row
            {
                YearMonth = fi.Key,
                Cost = fi.Sum(i => i.MedicineCost) + fi.Sum(i => i.TransportationCost) + fi.Sum(i => i.OtherCosts),
                Revenue = 0,
                Difference = 0
            }).ToList()).ToList();

            PigSaleItems = new ObservableCollection<PigSaleItem>(await repo.GetPigSaleItems());
            fullList = fullList.Concat(PigSaleItems.GroupBy(fi => new YearMonth
            {
                Year = fi.Date.Year,
                Month = fi.Date.Month
            }).Select(fi => new Row
            {
                YearMonth = fi.Key,
                Cost = fi.Sum(i => i.Brokerage) + fi.Sum(i => i.TransportationCost) + fi.Sum(i => i.OtherCosts),
                Revenue = fi.Sum(i => i.SalePrice),
                Difference = 0
            }).ToList()).ToList();

            // Group fulllist once more into YearMonths and sort by year then month to get most recent first
            fullList = fullList.GroupBy(fl => new YearMonth
            {
                Year = fl.YearMonth.Year,
                Month = fl.YearMonth.Month
            })
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

            return (FullList, totalPeriodRevenue, totalPeriodCost, totalPeriodDifference);
        }


        public async Task<PlotModel> GenerateTotalsGraphModel(
                double totalPeriodRevenue,
                double totalPeriodCost,
                double totalPeriodDifference
            )
        {
            OnPropertyChanged("SimpleGraphModel");
            var model = new PlotModel { };

            #region Series 1
            var barSeries = new ColumnSeries();

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(totalPeriodCost),
                Color = OxyColor.Parse("#bc4749")
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(totalPeriodRevenue),
                Color = OxyColor.Parse("#a7c957")
            });

            model.Series.Add(barSeries);
            #endregion

            String[] strNames = new String[] { "Total Cost", "Total Profit" };
            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Key = "Simple Sample Data",
                ItemsSource = strNames,
                IsPanEnabled = false,
                IsZoomEnabled = false,
                Selectable = false,
            });

            return model;
        }

        #region INotifyPropertyChanged
        // public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
