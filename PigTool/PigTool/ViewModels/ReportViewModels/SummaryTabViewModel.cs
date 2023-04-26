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
using System.ComponentModel;

namespace PigTool.ViewModels
{
    public class SummaryTabViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        public List<Row> fullList, fullListByMonthYear;
        public double totalPeriodRevenue;
        public double totalPeriodCost;
        public double totalPeriodDifference;
        private DateTime startDate, endDate;

        private PlotModel simpleGraphModel { get; set; }


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
                    OnPropertyChanged(nameof(TotalPeriodDifferenceLabel));
                }
            }
        }

        private bool calculate;

        public string TotalPeriodDifferenceLabel
        {
            get => String.Format("Profit / Loss: {0:C2}", TotalPeriodDifference);
        }

        public DateTime StartDate
        {
            get => startDate;
            set
            {
                if (value != startDate) 
                { 
                    startDate = value; 
                    OnPropertyChanged(nameof(StartDate)); 
                    Calculate = true; CalculateSelected(); 
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
                    OnPropertyChanged(nameof(EndDate)); Calculate = true; 
                    CalculateSelected(); 
                }
            }
        }

        public bool Calculate
        {
            get => calculate;
            set
            {
                if (calculate != value)
                {
                    calculate = value;
                    OnPropertyChanged(nameof(Calculate));
                }
            }
        }

        public SummaryTabViewModel()
        {
            //StartDate = DateTime.Now.AddMonths(-12);
            //ConstructPage();
        }

        public async void CalculateSelected()
        {
            ChartHelper chartHelper = new ChartHelper();
            Calculate = false;
            var cost = FullList.Where(x => x.YearMonth.Date >= StartDate && x.YearMonth.Date <= EndDate).Sum(x => (double)x.Cost);
            var reveue = FullList.Where(x => x.YearMonth.Date >= StartDate && x.YearMonth.Date <= EndDate).Sum(x => (double)x.Revenue);
            TotalPeriodRevenue = reveue;
            TotalPeriodCost = cost;
            TotalPeriodDifference = reveue - cost;
            FullListByMonthYear = FullList.Where(x => x.YearMonth.Date >= StartDate && x.YearMonth.Date <= EndDate).ToList();

            SimpleGraphModel = await chartHelper.GenerateTotalsGraphModel(
                TotalPeriodRevenue,
                TotalPeriodCost,
                TotalPeriodDifference);
            OnPropertyChanged("GraphModel");
        }

        public async void ConstructPage()
        {
            // Get chart data and load variables
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
                TotalPeriodDifference);
            OnPropertyChanged("GraphModel");
        }

    }
}
