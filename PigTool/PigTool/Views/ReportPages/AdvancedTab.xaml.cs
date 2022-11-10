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
    }
}