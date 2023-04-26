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