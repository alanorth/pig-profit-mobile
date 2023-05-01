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
                if (value != startDate) { startDate = value; OnPropertyChanged(nameof(StartDate));}
            }
        }

        public DateTime EndDate
        {
            get => endDate;
            set
            {
                if (value != endDate) { endDate = value; OnPropertyChanged(nameof(EndDate)); }
            }
        }
        
        private PlotModel graphModel { get; set; }

        public PlotModel GraphModel
        {
            get
            {
                return graphModel;
            }
            set
            {
                graphModel = value;
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
            GraphModel = new PlotModel();
            //GetDataForCharts();
            //LoadBasicChart();
            
        }

        public void filterDataAndReloadBarChart()
        {

            GraphModel = null;

            var providedData = FullList.Where(x => x.YearMonth.Date >= StartDate && x.YearMonth.Date <= EndDate).ToList();

            List<string> MonthNameList = GetMonthNamesUsed(providedData);
            PlotModel model = CreateAdvanceChart(providedData, MonthNameList);

            GraphModel = model;
            OnPropertyChanged("GraphModel");


            ChartHelper chartHelper = new ChartHelper();

            SimpleGraphModel = chartHelper.GenerateTotalsGraphModel(
                (double)FullList.Where(x => x.YearMonth.Date >= StartDate && x.YearMonth.Date <= EndDate).Sum(x => x.Revenue),
                (double)FullList.Where(x => x.YearMonth.Date >= StartDate && x.YearMonth.Date <= EndDate).Sum(x => x.Cost) ,
                (double)FullList.Where(x => x.YearMonth.Date >= StartDate && x.YearMonth.Date <= EndDate).Sum(x => x.Difference),
                SummaryChartCostGroup,
                SummaryChartIncomeGroup,
                SummaryChartProfitLoss).Result;
            OnPropertyChanged("GraphModel");

        }

        public void LoadAdvancedBarChart(List<Row> providedData)
        {
            GraphModel = null;

            CalculateSelected();

            List<string> MonthNameList = GetMonthNamesUsed(providedData);
            PlotModel model = CreateAdvanceChart(providedData, MonthNameList);

            GraphModel = model;
            OnPropertyChanged(nameof(GraphModel));

            /*
            #region Series 1
            var barSeries = new ColumnSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}",
                IsStacked = true,
                Title = "Water Cost"
            };

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(33),
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(196),
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(152),
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(62),
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(68),
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(101),
            });

            model.Series.Add(barSeries);
            #endregion

            #region Series 2
            var barSeries2 = new ColumnSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}",
                IsStacked = true,
                Title = "Housing",
            };

            barSeries2.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(120),
            });

            barSeries2.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(130),
            });

            barSeries2.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(70),
            });

            barSeries2.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(50),
            });

            barSeries2.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(170),
            });

            barSeries2.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(100),
            });

            model.Series.Add(barSeries2);
            #endregion

            #region Series 3
            var barSeries3 = new ColumnSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}",
                IsStacked = true,
                Title = "Labour",
            };

            barSeries3.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(100),
            });

            barSeries3.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(130),
            });

            barSeries3.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(100),
            });

            barSeries3.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(230),
            });

            barSeries3.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(50),
            });

            barSeries3.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(100),
            });

            model.Series.Add(barSeries3);
            #endregion

            #region Series 4
            var barSeries4 = new ColumnSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}",
                IsStacked = true,
                Title = "Health Care",
            };

            barSeries4.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(20),
            });

            barSeries4.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(30),
            });

            barSeries4.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(40),
            });

            barSeries4.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(45),
            });

            barSeries4.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(40),
            });

            barSeries4.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(25),

            });

            model.Series.Add(barSeries4);
            #endregion
            
            String[] strNames = new String[] { "Apr", "May", "Jun", "Jul", "Aug", "Sep" };
            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Key = "Sample Data",
                ItemsSource = MonthNameList,
                IsPanEnabled = false,
                IsZoomEnabled = false,
                Selectable = false,
            });

            GraphModel = model;
            OnPropertyChanged("GraphModel");*/
        }

        private static PlotModel CreateAdvanceChart(List<Row> providedData, List<string> MonthNameList)
        {
            var groupedData = providedData.GroupBy(d => d.YearMonth.Grouping);

            var model = new PlotModel { };
            model.LegendOrientation = LegendOrientation.Vertical;
            model.LegendPlacement = LegendPlacement.Outside;
            model.LegendPosition = LegendPosition.RightMiddle;

            /*model.DefaultColors = new List<OxyColor>
            {
                OxyColor.Parse("#3498db"),
                OxyColor.Parse("#e56b65"),
                OxyColor.Parse("#efca58"),
                OxyColor.Parse("#5fc091")
            };*/
            foreach (var group in groupedData)
            {
                var groupList = group.ToList();
                var groupedMonths = groupList.GroupBy(d => d.YearMonth.Date.ToString("MMM/yyyy"));

                var bSeries = new ColumnSeries
                {
                    LabelPlacement = LabelPlacement.Inside,
                    LabelFormatString = "{0}",
                    IsStacked = true,
                    Title = group.Key,
                };

                foreach (var xy in groupedMonths)
                {
                    bSeries.Items.Add(new ColumnItem
                    {
                        Value = (double)xy.Sum(p => p.Cost),
                        CategoryIndex = MonthNameList.IndexOf(xy.Key)
                    });
                }

                model.Series.Add(bSeries);
                
            }

            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Key = "Sample Data",
                ItemsSource = MonthNameList,
                IsPanEnabled = false,
                IsZoomEnabled = false,
                Selectable = false,
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
                dictTest.Add(month.Key,month.First().YearMonth.Date);
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
