using PigTool.ViewModels;
using PigTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PigTool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReportsPage : TabbedPage
    {
        private DateRange _dateRange;
        public ReportsPage()
        {
            _dateRange = new DateRange { StartDate = DateTime.Today.AddYears(-1), EndDate = DateTime.Today };

            InitializeComponent();
            // Create the content pages and pass the date variables
            ContentPage SumTab = new SummaryTab(_dateRange);
            ContentPage AdvanceTab = new AdvancedTab(_dateRange);
            ContentPage BenchTab = new BenchmarkingTab();

            // Set the title and icon for each content page
            SumTab.Title = "Summary";
            AdvanceTab.Title = "Advanced";
            BenchTab.Title = "Benchmark";

            // Add the content pages to the tabbed page
            Children.Add(SumTab);
            Children.Add(AdvanceTab);
            Children.Add(BenchTab);
        }
    }
}