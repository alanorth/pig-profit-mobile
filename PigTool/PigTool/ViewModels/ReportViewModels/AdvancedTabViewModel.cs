using System;
using Xamarin.Forms;
using System.Linq;
using System.Windows.Input;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.ComponentModel;
using System.Collections.Generic;
using PigTool.Helpers;
using static PigTool.Helpers.ChartHelper;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Collections;
using Shared;
using OxyPlot.Xamarin.Forms;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;

namespace PigTool.ViewModels.ReportViewModels
{
    public class AdvancedTabViewModel : SummaryTabViewModel, INotifyPropertyChanged
    {
        private DateTime startDate, endDate;
       
        public DateTime StartDate
        {
            get => startDate;
            set
            {
                if (value != startDate)
                {
                    startDate = value;
                    OnPropertyChanged(nameof(StartDate));
                    //CalculateSelected();
                }
            }
        }

        public DateTime EndDate
        {
            get => endDate;
            set
            {
                if (value != endDate)
                {
                    endDate = value;
                    OnPropertyChanged(nameof(EndDate));
                    //CalculateSelected();
                }
            }
        }

        private PlotModel legendGraph, incomeLegendGraph, costGraphModel;

        public PlotModel CostGraphModel
        {
            get
            {
                return costGraphModel;
            }
            set
            {
                costGraphModel = value;
            }
        }

        public PlotModel LegendGraph
        {
            get
            {
                return legendGraph;
            }
            set
            {
                legendGraph = value;
            }
        }

        public PlotModel IncomeLegendGraph
        {
            get
            {
                return incomeLegendGraph;
            }
            set
            {
                incomeLegendGraph = value;
            }
        }
        private PlotModel incomeGraphModel { get; set; }

        public PlotModel IncomeGraphModel
        {
            get
            {
                return incomeGraphModel;
            }
            set
            {
                incomeGraphModel = value;
            }
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
                OnPropertyChanged(nameof(SimpleGraphModel));
            }
        }

        public AdvancedTabViewModel()
        {
            CostGraphModel = new PlotModel();
            IncomeGraphModel = new PlotModel();

        }

        public void filterDataAndReloadBarChart()
        {
            CostGraphModel = null;
            IncomeGraphModel = null;

            var providedData = FullList.Where(x => x.YearMonth.Date >= StartDate && x.YearMonth.Date <= EndDate).ToList();

            List<string> MonthNameList = GetMonthNamesUsed(providedData);
            PlotModel model = CreateAdvanceChart(providedData, MonthNameList, true);
            PlotModel Incomemodel = CreateAdvanceChart(providedData, MonthNameList, false);
            PlotModel LegendHolder = CreateLegendHolder(providedData, MonthNameList, true);
            PlotModel IncomeLegHolder = CreateLegendHolder(providedData, MonthNameList, false);

            CostGraphModel = model;
            IncomeGraphModel = Incomemodel;
            LegendGraph = LegendHolder;
            IncomeLegendGraph = IncomeLegHolder;

            OnPropertyChanged(nameof(CostGraphModel));
            OnPropertyChanged(nameof(IncomeGraphModel));
            OnPropertyChanged(nameof(LegendGraph));
            OnPropertyChanged(nameof(IncomeLegendGraph));


            ChartHelper chartHelper = new ChartHelper();
            //GetDataForCharts();
            TotalPeriodCost = (double)FullList.Where(x => x.YearMonth.Date >= StartDate && x.YearMonth.Date <= EndDate).Sum(x => x.Cost);
            TotalPeriodRevenue = (double)FullList.Where(x => x.YearMonth.Date >= StartDate && x.YearMonth.Date <= EndDate).Sum(x => x.Revenue);
            TotalPeriodDifference = TotalPeriodRevenue - TotalPeriodCost;

            SimpleGraphModel = chartHelper.GenerateTotalsGraphModel(
                TotalPeriodRevenue,
                TotalPeriodCost,
                TotalPeriodDifference,
                SummaryChartCostGroup,
                SummaryChartIncomeGroup,
                SummaryChartProfitLoss,
                User.CurrencySymbol()).Result;
            OnPropertyChanged(nameof(SimpleGraphModel));

        }

        public void LoadAdvancedBarChart(List<Row> providedData)
        {
            CostGraphModel = null;

            //CalculateSelected();

            List<string> MonthNameList = GetMonthNamesUsed(providedData);
            PlotModel model = CreateAdvanceChart(providedData, MonthNameList, true);
            PlotModel incomeModel = CreateAdvanceChart(providedData, MonthNameList, false);
            PlotModel LegendHolder = CreateLegendHolder(providedData, MonthNameList, true);
            PlotModel IncomeLegHolder = CreateLegendHolder(providedData, MonthNameList, false);

            CostGraphModel = model;
            IncomeGraphModel = incomeModel;
            LegendGraph = LegendHolder;
            IncomeLegendGraph = IncomeLegHolder;

            OnPropertyChanged(nameof(CostGraphModel));
            OnPropertyChanged(nameof(IncomeGraphModel));
            OnPropertyChanged(nameof(LegendGraph));
            OnPropertyChanged(nameof(IncomeLegendGraph));
        }

        private PlotModel CreateAdvanceChart(List<Row> providedData, List<string> MonthNameList, bool costChart)
        {
            var groupedData = providedData.GroupBy(d => d.YearMonth.Grouping);

            var model = new PlotModel { };
            model.IsLegendVisible = false;

            foreach (var group in groupedData)
            {
                var groupList = group.ToList();
                var groupedMonths = groupList.GroupBy(d => d.YearMonth.Date.ToString("MMM/yyyy"));

                var CostSeries = new ColumnSeries
                {
                    IsStacked = true,
                    Title = GetTitleTranslation(group.Key),
                    StackGroup = "Cost",
                };

                //cost chart
                if (costChart)
                {
                    foreach (var xy in groupedMonths)
                    {
                        CostSeries.Items.Add(new ColumnItem
                        {
                            Value = (double)xy.Sum(p => p.Cost),
                            CategoryIndex = MonthNameList.IndexOf(xy.Key)
                        });
                    }
                    model.Series.Add(CostSeries);
                }
                else //Income Chart
                {
                    //do not include if revenu sums to 0
                    if((double)groupList.Sum(p => p.Revenue) != 0) { 
                        foreach (var xy in groupedMonths)
                        {
                            CostSeries.Items.Add(new ColumnItem
                            {
                                Value = (double)xy.Sum(p => p.Revenue),
                                CategoryIndex = MonthNameList.IndexOf(xy.Key)
                            });
                        }
                        model.Series.Add(CostSeries);
                    }
                }
            }

            var yAxis = new LinearAxis
            {
                StringFormat = "0", // Specify the format string without scientific notation
                Position = AxisPosition.Left, // Position the Y-axis on the left side
                Title = User.CurrencySymbol(),
            };

            model.Axes.Add(yAxis);

            var xAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Key = "Sample Data",
                ItemsSource = MonthNameList,
                IsPanEnabled = false,
                IsZoomEnabled = false,
                Angle = 75,
            };

            //xAxis.LabelFormatter = x => RotateText(x, -90);

            model.Axes.Add(xAxis);
            return model;
        }

        private PlotModel CreateLegendHolder(List<Row> providedData, List<string> MonthNameList, bool costChart)
        {
            var plotModel = new PlotModel();

            var groupedData = providedData.GroupBy(d => d.YearMonth.Grouping);


            foreach (var group in groupedData)
            {
                var groupList = group.ToList();
                var groupedMonths = groupList.GroupBy(d => d.YearMonth.Date.ToString("MMM/yyyy"));

                var costSum = (double)(groupList.Sum(x => x.Cost));
                var costSumRound = string.Format("{0:N0}", Math.Round(costSum).ToString());

                if (!costChart) {
                    costSum = (double)(groupList.Sum(x => x.Revenue));
                    costSumRound = string.Format("{0:N0}", Math.Round(costSum).ToString());
                }
                //string.Format("{0:N0}",  Math.Round(costSum).ToString())
                var CostSeries = new ColumnSeries
                {
                    LabelPlacement = LabelPlacement.Middle,
                    LabelFormatString = "{0:0.00}",                   
                    IsStacked = true,
                    Title = GetTitleTranslation(group.Key) + " " + costSumRound +" "+ User.CurrencySymbol(),
                    StackGroup = "Cost",
                    IsVisible = costSum == 0 ? false : true,                   
                };
                plotModel.Series.Add(CostSeries);
            }

            plotModel.LegendPosition = LegendPosition.TopCenter;
            plotModel.LegendPlacement = LegendPlacement.Inside;
            plotModel.LegendOrientation = LegendOrientation.Vertical;

            // Set the Title and IsLegendVisible properties
            plotModel.IsLegendVisible = true;
            plotModel.LegendFontSize = 11;
            plotModel.PlotAreaBackground = OxyColors.Transparent;

            var xAxis = new CategoryAxis
            {
                AxislineColor = OxyColors.White,
            };

            var yAxis = new LinearAxis
            {
                AxislineColor = OxyColors.White,
                TextColor = OxyColors.White,
                ExtraGridlineColor = OxyColors.White,
                MajorGridlineColor = OxyColors.White,
                MinorGridlineColor = OxyColors.White,
                MinorTicklineColor = OxyColors.White,
                TicklineColor = OxyColors.White,
                TitleColor = OxyColors.White,
            };

            plotModel.Axes.Add(xAxis);
            plotModel.Axes.Add(yAxis);
            plotModel.PlotAreaBorderColor = OxyColors.White;

            return plotModel;
        }


        private static List<string> GetMonthNamesUsed(List<Row> providedData)
        {
            var groupedData23 = providedData.GroupBy(d => d.YearMonth.Date.ToString("MMM/yyyy"));
            var MonthNameList = new List<string>();
            var dictTest = new Dictionary<string, DateTime>();

            foreach (var month in groupedData23)
            {
                dictTest.Add(month.Key, month.First().YearMonth.Date);
            }

            dictTest.Keys.ToList();

            var myList = dictTest.ToList();

            myList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

            myList.ForEach(x => MonthNameList.Add(x.Key));

            return MonthNameList;
        }

        public async Task GetDataForCharts()
        {
            ChartHelper chartHelper = new ChartHelper();
            var result = await chartHelper.GetData();
            FullList = result.Item1; // used by list view
            FullListByMonthYear = result.Item1;
            TotalPeriodRevenue = result.Item2;
            TotalPeriodCost = result.Item3;
            TotalPeriodDifference = result.Item4;

            SimpleGraphModel = await chartHelper.GenerateTotalsGraphModel(
                TotalPeriodRevenue,
                TotalPeriodCost,
                TotalPeriodDifference,
                SummaryChartCostGroup,
                SummaryChartIncomeGroup,
                SummaryChartProfitLoss,
                User.CurrencySymbol());
            OnPropertyChanged(nameof(SimpleGraphModel));

        }

        private string RotateText(double text, double angle)
        {
            return $"<span style='writing-mode: vertical-rl; transform: rotate({angle}deg);'>{text}</span>";
        }

    }
}
