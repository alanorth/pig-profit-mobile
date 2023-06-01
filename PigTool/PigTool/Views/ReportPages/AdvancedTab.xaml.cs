﻿using PigTool.Models;
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
        private DateRange _dateRange;
        public AdvancedTab(DateRange daterange)
        {
            _dateRange = daterange;
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
            _viewModel.GetDataForCharts();
            _viewModel.LoadAdvancedBarChart(_viewModel.FullList);
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
        }

        void Recalculate()
        {
            _dateRange.StartDate = _viewModel.StartDate = startDatePicker.Date;
            _dateRange.EndDate = _viewModel.EndDate = endDatePicker.Date;
            _viewModel.filterDataAndReloadBarChart();
        }
    }
}