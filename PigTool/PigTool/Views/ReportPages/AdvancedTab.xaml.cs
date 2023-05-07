using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Xamarin.Forms;
using PigTool.ViewModels.ReportViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PigTool.Views
{
    public partial class AdvancedTab : ContentPage
    {
        AdvancedTabViewModel _viewModel;
        public AdvancedTab()
        {
            _viewModel = new AdvancedTabViewModel();
            InitializeComponent();
            this.BindingContext = _viewModel;
            DurationLabel.SetBinding(Label.TextProperty, nameof(_viewModel.ReportingDuration));
            SummaryTitleLabel.SetBinding(Label.TextProperty, nameof(_viewModel.SummaryLabel));
            BreakdownTitleLabel.SetBinding(Label.TextProperty, nameof(_viewModel.BreakdownLabel));
            IncomeBreakdownTitleLabel.SetBinding(Label.TextProperty, nameof(_viewModel.IncomeBreakdownLabel));

            var TotalCostLabel = new Label();
            TotalCostLabel.SetBinding(Label.TextProperty, nameof(_viewModel.TotalPeriodCostLabel));
            var TotalRevenueLabel = new Label();
            TotalRevenueLabel.SetBinding(Label.TextProperty, nameof(_viewModel.TotalPeriodRevenueLabel));
            var ProfitLossLabel = new Label();
            ProfitLossLabel.SetBinding(Label.TextProperty, nameof(_viewModel.TotalPeriodDifferenceLabel));

            TotalLabels.Children.Add(TotalRevenueLabel);
            TotalLabels.Children.Add(TotalCostLabel);
            TotalLabels.Children.Add(ProfitLossLabel);
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
            _viewModel.GetDataForCharts();
            _viewModel.LoadAdvancedBarChart(_viewModel.FullList);
        }

        void Recalculate()
        {
            _viewModel.StartDate = startDatePicker.Date;
            _viewModel.EndDate = endDatePicker.Date;
            _viewModel.filterDataAndReloadBarChart();
        }
    }
}