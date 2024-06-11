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
        public List<RowOfGroupedData> fullList, fullListByMonthYear;
        public double totalPeriodRevenue;
        public double totalPeriodCost;
        public double totalPeriodDifference;
        private DateTime startDate, endDate;

        private PlotModel simpleGraphModel { get; set; }


        //translations
        public string ReportingDuration { get; set; }
        public string ProfitTranslation { get; set; }
        public string LossTranslation { get; set; }
        public string SummaryChartTile { get; set; }
        public string SummaryChartCostGroup { get; set; }
        public string SummaryChartIncomeGroup { get; set; }
        public string SummaryChartProfitLoss { get; set; }
        public string SummaryTableHeading { get; set; }
        public string MonthTranslation { get; set; }
        public string YearTranslation { get; set; }
        public string SummaryIncomeTranslation { get; set; }
        public string SummaryCostTranslation { get; set; }
        public string SummaryProfitLossTranslation { get; set; }
        public string SummaryLabel { get; set; }
        public string BreakdownLabel { get; set; }
        public string IncomeBreakdownLabel { get; set; }
        public string AdvanceTabLable { get; private set; }
        public string BenchmarkingTabLable { get; private set; }

        public List<RowOfGroupedData> FullList
        {
            get { return fullList; }
            set
            {
                fullList = value;
                OnPropertyChanged(nameof(FullList));
            }
        }

        public List<RowOfGroupedData> FullListByMonthYear
        {
            get
            {
                if (fullListByMonthYear != null)
                {
                    return fullListByMonthYear.OrderByDescending(fl => fl.YearMonth.Year).ThenByDescending(fl => fl.YearMonth.Month).ToList();
                }
                else
                {
                    return fullListByMonthYear;
                }

            }
            set
            {
                fullListByMonthYear = value.GroupBy(fl => new YearMonth
                {
                    Year = fl.YearMonth.Year,
                    Month = fl.YearMonth.Month,
                })
                .Select(fl => new RowOfGroupedData
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
            get => string.Format("{1}: {0:N0} {2}", TotalPeriodRevenue, SummaryIncomeTranslation, User.CurrencySymbol());
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
            get => string.Format("{1}: {0:N0} {2}", TotalPeriodCost, SummaryCostTranslation, User.CurrencySymbol());
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
            get => string.Format("{1}: {0:N0} {2}", TotalPeriodDifference, SummaryProfitLossTranslation, User.CurrencySymbol());
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
            ReportingDuration = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ReportingDuration), User.UserLang);
            ProfitTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ProfitTranslation), User.UserLang);
            LossTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LossTranslation), User.UserLang);
            SummaryChartTile = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SummaryChartTile), User.UserLang);
            SummaryChartCostGroup = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SummaryChartCostGroup), User.UserLang);
            SummaryChartIncomeGroup = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SummaryChartIncomeGroup), User.UserLang);
            SummaryChartProfitLoss = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SummaryChartProfitLoss), User.UserLang);
            SummaryTableHeading = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SummaryTableHeading), User.UserLang);
            MonthTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(MonthTranslation), User.UserLang);
            YearTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(YearTranslation), User.UserLang);
            SummaryIncomeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SummaryIncomeTranslation), User.UserLang);
            SummaryCostTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SummaryCostTranslation), User.UserLang);
            SummaryProfitLossTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SummaryProfitLossTranslation), User.UserLang);
            SummaryLabel = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SummaryLabel), User.UserLang);
            BreakdownLabel = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(BreakdownLabel), User.UserLang);
            IncomeBreakdownLabel = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(IncomeBreakdownLabel), User.UserLang);
            AdvanceTabLable = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(AdvanceTabLable), User.UserLang);
            BenchmarkingTabLable = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(BenchmarkingTabLable), User.UserLang);
        }

        public async void CalculateSelected()
        {
            ChartHelper chartHelper = new ChartHelper();
            Calculate = false;
            var cost = FullList.Where(x => x.YearMonth.Date >= StartDate && x.YearMonth.Date <= EndDate).Sum(x => (double)x.Cost);
            var reveue = FullList.Where(x => x.YearMonth.Date >= StartDate && x.YearMonth.Date <= EndDate).Sum(x => (double)x.Revenue);
            //var cost = (double)FullList.Sum(x => x.Cost);
            //var reveue = (double)FullList.Sum(x => x.Revenue);
            TotalPeriodRevenue = reveue;
            TotalPeriodCost = cost;
            TotalPeriodDifference = reveue - cost;
            FullListByMonthYear = FullList.Where(x => x.YearMonth.Date >= StartDate && x.YearMonth.Date <= EndDate).ToList();

            SimpleGraphModel = await chartHelper.GenerateTotalsGraphModel(
                TotalPeriodRevenue,
                TotalPeriodCost,
                TotalPeriodDifference,
                SummaryChartCostGroup,
                SummaryChartIncomeGroup,
                SummaryChartProfitLoss,
                User.CurrencySymbol());
            OnPropertyChanged("GraphModel");
        }

        public async Task ConstructPage()
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
                TotalPeriodDifference,
                SummaryChartCostGroup,
                SummaryChartIncomeGroup,
                SummaryChartProfitLoss,
                User.CurrencySymbol());
            OnPropertyChanged("GraphModel");
        }

    }
}
