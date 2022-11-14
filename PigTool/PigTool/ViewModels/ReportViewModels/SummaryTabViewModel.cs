using PigTool.Views;
using Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Linq;
using OxyPlot.Series;
using OxyPlot;
using OxyPlot.Axes;
using PigTool.Helpers;
using static PigTool.Helpers.ChartHelper;

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
            ConstructPage();
            
        }

        public async void ConstructPage()
        {
            // Get chart data and load variables
            ChartHelper chartHelper = new ChartHelper();
            var result = await chartHelper.GetData();
            FullList = result.Item1; // used by list view
            TotalPeriodRevenue = result.Item2;
            TotalPeriodCost = result.Item3;
            TotalPeriodDifference = result.Item4;

            GenerateGraph();
        }

        private PlotModel simpleGraphModel { get; set; }

        public PlotModel SimpleGraphModel
        {
            get
            {
                return simpleGraphModel;
            }
            set
            {
                simpleGraphModel = value;
            }
        }

        public async void GenerateGraph() {
            OnPropertyChanged("SimpleGraphModel");
            var model = new PlotModel { };

            #region Series 1
            var barSeries = new ColumnSeries
            {
                // LabelPlacement = LabelPlacement.,
                //LabelFormatString = "{0}",
                //Title = "Water Cost"
            };

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(TotalPeriodCost),
                Color = OxyColor.Parse("#bc4749")
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(TotalPeriodRevenue),
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

            SimpleGraphModel = model;
            OnPropertyChanged("GraphModel");
        }

    }
}
