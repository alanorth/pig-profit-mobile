using PigTool.Models;
using PigTool.ViewModels.ReportViewModels;
using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PigTool.Views
{
    public partial class AdvancedTab : ContentPage
    {
        AdvancedTabViewModel _viewModel;
        private DateRange _dateRange;
        bool firstRender = true;
        private bool FirstDislay = true;

        public AdvancedTab(DateRange daterange)
        {
            _dateRange = daterange;
            _viewModel = new AdvancedTabViewModel();
            InitializeComponent();
            this.BindingContext = _viewModel;
            DurationLabel.SetBinding(Label.TextProperty, nameof(_viewModel.ReportingDuration));
            SummaryTitleLabel.SetBinding(Label.TextProperty, nameof(_viewModel.SummaryChartTile));
            BreakdownTitleLabel.SetBinding(Label.TextProperty, nameof(_viewModel.BreakdownLabel));
            IncomeBreakdownTitleLabel.SetBinding(Label.TextProperty, nameof(_viewModel.IncomeBreakdownLabel));

            var TotalCostLabel = new Label();
            TotalCostLabel.SetBinding(Label.TextProperty, nameof(_viewModel.TotalPeriodCostLabel));
            var TotalRevenueLabel = new Label();
            TotalRevenueLabel.SetBinding(Label.TextProperty, nameof(_viewModel.TotalPeriodRevenueLabel));
            var ProfitLossLabel = new Label();
            ProfitLossLabel.SetBinding(Label.TextProperty, nameof(_viewModel.TotalPeriodDifferenceLabel));

            TotalLabels.Children.Add(TotalCostLabel);
            TotalLabels.Children.Add(TotalRevenueLabel);
            TotalLabels.Children.Add(ProfitLossLabel);

            if (FirstDislay)
            {
                var task = Task.Run(async () => await _viewModel.GetDataForCharts());
                var result = task.IsCompleted;

                while (!result)
                {
                    Thread.Sleep(100);
                    result = task.IsCompleted;
                }
                //task.RunSynchronously();
                _viewModel.LoadAdvancedBarChart(_viewModel.FullList);
                /*foreach (var chart in _viewModel.listOfColoumnRevenueSeries)
                {
                    var costLabel = new Label();
                    costLabel.Text = chart.Title + " " + chart.ColorField;
                    //I need a hex code from FillColor
                    var tttt = chart.FillColor;
                    //var tttt1 = tttt.ToString();
                    var yyyy = chart.ColorField;
                    //var yyyy2 = chart.ColorField?.ToString();
                    var uuuu = chart.ColorField;
                    //var uuuuu = chart?.ColorField?.ToString();
                    var uuuu2 = chart.ActualFillColor;
                    //var uuuu22 = chart?.ActualFillColor.ToString();
                    var uuuu3 = chart.StrokeColor;
                    //var uuuu33 = chart?.StrokeColor.ToString();

                    //costLabel.BackgroundColor = chart.ColorField;
                    //costLabel.BackgroundColor = new Color(chart.ActualFillColor.R, chart.ActualFillColor.G, chart.ActualFillColor.B);
                    MyNameNedIncomeStack.Children.Add(costLabel);
                }*/
                FirstDislay = false;
            }

            this.Title = _viewModel.AdvanceTabLable;
        }

        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            if (startDatePicker.Date <= endDatePicker.Date)
            {
                Recalculate();
            }
        }

        protected async override void OnAppearing()
        {
            startDatePicker.Date = _viewModel.StartDate = _dateRange.StartDate;
            endDatePicker.Date = _viewModel.EndDate = _dateRange.EndDate;
            if (!firstRender)
            {
                await _viewModel.GetDataForCharts();
                _viewModel.CalculateSelected();
                _viewModel.LoadAdvancedBarChart(_viewModel.FullListByMonthYear);
                _viewModel.filterDataAndReloadBarChart();
            }
            else
            {
                firstRender = false;
            }
        }

        void Recalculate()
        {
            _dateRange.StartDate = _viewModel.StartDate = startDatePicker.Date;
            _dateRange.EndDate = _viewModel.EndDate = endDatePicker.Date;
            _viewModel.filterDataAndReloadBarChart();
        }
    }
}