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

namespace PigTool.ViewModels.ReportViewModels
{
    public class AdvancedTabViewModel : SummaryTabViewModel, INotifyPropertyChanged
    {
        private DateTime startDate, endDate;
        /*public List<Row> fullList, fullListByMonthYear;
        public double totalPeriodRevenue;
        public double totalPeriodCost;
        public double totalPeriodDifference;
        
        public List<Row> FullList
        {
            get { return fullList; }
            set
            {
                fullList = value;
                OnPropertyChanged(nameof(FullList));
            }
        }

        public List<Row> FullListByMonthYear
        {
            get { return fullListByMonthYear; }
            set
            {
                fullListByMonthYear = value.GroupBy(fl => new YearMonth
                {
                    Year = fl.YearMonth.Year,
                    Month = fl.YearMonth.Month,
                })
                .Select(fl => new Row
                {
                    YearMonth = fl.Key,
                    Cost = fl.Sum(i => i.Cost),
                    Revenue = fl.Sum(i => i.Revenue),
                    Difference = fl.Sum(i => i.Revenue) - fl.Sum(i => i.Cost)
                }).OrderByDescending(fl => fl.YearMonth.Year).ThenByDescending(fl => fl.YearMonth.Month).ToList();

                OnPropertyChanged(nameof(FullListByMonthYear));
            }//set
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
                    OnPropertyChanged(nameof(TotalPeriodRevenueLabel));
                }
            }
        }
        public string TotalPeriodRevenueLabel
        {
            get => String.Format("Income: {0:C2}", TotalPeriodRevenue);
        }

        public double TotalPeriodCost
        {
            get => totalPeriodCost;
            set
            {
                if (value != totalPeriodCost)
                {
                    totalPeriodCost = value;
                    OnPropertyChanged(nameof(TotalPeriodCostLabel));
                    OnPropertyChanged(nameof(TotalPeriodCost));
                }
            }
        }
        public string TotalPeriodCostLabel
        {
            get => String.Format("Cost: {0:C2}", TotalPeriodCost);
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
        */
        public DateTime StartDate
        {
            get => startDate;
            set
            {
                if (value != startDate) { 
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
                if (value != endDate) { endDate = value; 
                    OnPropertyChanged(nameof(EndDate));
                    //CalculateSelected();
                }
            }
        }

        private PlotModel costGraphModel { get; set; }

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
            //GetDataForCharts();
            //LoadBasicChart();

        }

        public void filterDataAndReloadBarChart()
        {

            CostGraphModel = null;
            IncomeGraphModel = null;

            var providedData = FullList.Where(x => x.YearMonth.Date >= StartDate && x.YearMonth.Date <= EndDate).ToList();

            List<string> MonthNameList = GetMonthNamesUsed(providedData);
            PlotModel model = CreateAdvanceChart(providedData, MonthNameList, true);
            PlotModel Incomemodel = CreateAdvanceChart(providedData, MonthNameList, false);

            CostGraphModel = model;
            IncomeGraphModel = Incomemodel;

            OnPropertyChanged(nameof(CostGraphModel));
            OnPropertyChanged(nameof(IncomeGraphModel));


            ChartHelper chartHelper = new ChartHelper();
            //GetDataForCharts();
            TotalPeriodCost = (double)FullList.Where(x => x.YearMonth.Date >= StartDate && x.YearMonth.Date <= EndDate).Sum(x => x.Cost);
            TotalPeriodRevenue = (double)FullList.Where(x => x.YearMonth.Date >= StartDate && x.YearMonth.Date <= EndDate).Sum(x => x.Revenue);
            TotalPeriodDifference = TotalPeriodRevenue - TotalPeriodCost;

            SimpleGraphModel = chartHelper.GenerateTotalsGraphModel(
                TotalPeriodCost,
                TotalPeriodRevenue,
                TotalPeriodDifference,
                SummaryChartCostGroup,
                SummaryChartIncomeGroup,
                SummaryChartProfitLoss).Result;
            OnPropertyChanged(nameof(SimpleGraphModel));

        }

        public void LoadAdvancedBarChart(List<Row> providedData)
        {
            CostGraphModel = null;

            //CalculateSelected();

            List<string> MonthNameList = GetMonthNamesUsed(providedData);
            PlotModel model = CreateAdvanceChart(providedData, MonthNameList, true);
            PlotModel incomeModel = CreateAdvanceChart(providedData, MonthNameList, false);

            CostGraphModel = model;
            IncomeGraphModel = incomeModel;
            OnPropertyChanged(nameof(CostGraphModel));
            OnPropertyChanged(nameof(IncomeGraphModel));
        }

        private PlotModel CreateAdvanceChart(List<Row> providedData, List<string> MonthNameList, bool costChart)
        {
            var groupedData = providedData.GroupBy(d => d.YearMonth.Grouping);

            var model = new PlotModel { };
            model.LegendOrientation = LegendOrientation.Vertical;
            model.LegendPlacement = LegendPlacement.Outside;
            model.LegendPosition = LegendPosition.RightMiddle;

            foreach (var group in groupedData)
            {
                var groupList = group.ToList();
                var groupedMonths = groupList.GroupBy(d => d.YearMonth.Date.ToString("MMM/yyyy"));

                var CostSeries = new ColumnSeries
                {
                    LabelPlacement = LabelPlacement.Inside,
                    LabelFormatString = "{0}",
                    IsStacked = true,
                    Title = GetTitleTranslation(group.Key),
                    StackGroup = "Cost",

                };
                /*var IncomeSeries = new ColumnSeries
                {
                    LabelPlacement = LabelPlacement.Inside,
                    LabelFormatString = "{0}",
                    IsStacked = true,
                    Title = GetTitleTranslation(group.Key),
                    StackGroup = "Income",
                    FillColor = CostSeries.FillColor,
                    RenderInLegend = false
                };

                foreach (var xy in groupedMonths)
                {
                    CostSeries.Items.Add(new ColumnItem
                    {
                        Value = (double)xy.Sum(p => p.Cost),
                        CategoryIndex = MonthNameList.IndexOf(xy.Key)
                    });
                    IncomeSeries.Items.Add(new ColumnItem
                    {
                        Value = (double)xy.Sum(p => p.Revenue),
                        CategoryIndex = MonthNameList.IndexOf(xy.Key)
                    });
                }
                model.Series.Add(CostSeries);
                model.Series.Add(IncomeSeries);*/


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

            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Key = "Sample Data",
                ItemsSource = MonthNameList,
                IsPanEnabled = false,
                IsZoomEnabled = true,
                Selectable = true,
            });
            return model;
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

        public async void GetDataForCharts()
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
                SummaryChartProfitLoss);
            OnPropertyChanged(nameof(SimpleGraphModel));

        }



    }
}
