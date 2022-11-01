using PigTool.Helpers;
using PigTool.Services;
using PigTool.ViewModels;
using Shared;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PigTool.Views
{
    public partial class SummaryTab : ContentPage
    {
        SummaryTabViewModel _ViewModel;


        public SummaryTab()
        {
            InitializeComponent();
            BindingContext = _ViewModel = new SummaryTabViewModel();
            PopulateThePage();
        }

        private async void PopulateThePage()
        {
            var baseYear = 2015;
            StartYear.ItemsSource = Enumerable.Range(baseYear, DateTime.Now.Year - baseYear + 3).ToList();
            EndYear.ItemsSource = Enumerable.Range(baseYear, DateTime.Now.Year - baseYear + 3).ToList();

            Grid Headergrid = new Grid
            {
                BackgroundColor = Color.FromHex("#682622"),
                ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = new GridLength(0.8, GridUnitType.Star) },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star }
                    }
            };

            Headergrid.Children.Add(FormattedElementsHelper.ReportTableHeaderLabelField("Month"), 0, 0);
            Headergrid.Children.Add(FormattedElementsHelper.ReportTableHeaderLabelField("Year"), 1, 0);
            Headergrid.Children.Add(FormattedElementsHelper.ReportTableHeaderLabelField("Income"), 2, 0);
            Headergrid.Children.Add(FormattedElementsHelper.ReportTableHeaderLabelField("Costs"), 3, 0);
            Headergrid.Children.Add(FormattedElementsHelper.ReportTableHeaderLabelField("Profit / Loss"), 4, 0);


            ListView listvw = new ListView();
            listvw.Header = Headergrid;
            listvw.ItemsSource = _ViewModel.FullList;
            listvw.ItemTemplate = new DataTemplate(typeof(SummaryTableCell));

            SummaryTable.Children.Add(listvw);


            TotalLabels.Children.Add(new Label { Text = String.Format("Income: {0:C2}", _ViewModel.TotalPeriodRevenue) });
            TotalLabels.Children.Add(new Label { Text = String.Format("Costs: {0:C2}", _ViewModel.TotalPeriodCost) });
            TotalLabels.Children.Add(new Label { Text = String.Format("Profit / Loss: {0:C2}", _ViewModel.TotalPeriodDifference) });
        }
    }

    public class SummaryTableCell : ViewCell
    {
        public SummaryTableCell()
        {
            var grid = new Grid
            {
                ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = new GridLength(0.8, GridUnitType.Star) },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star }
                    }
            };

            var monthLabel = new Label();
            var yearLabel = new Label();
            var revenueLabel = new Label();
            var costLabel = new Label();
            var differenceLabel = new Label();

            monthLabel.SetBinding(Label.TextProperty, "YearMonth.Month");
            yearLabel.SetBinding(Label.TextProperty, "YearMonth.Year");
            revenueLabel.SetBinding(Label.TextProperty, new Binding("Revenue") { StringFormat = "{0:C2}" });
            costLabel.SetBinding(Label.TextProperty, new Binding("Cost") { StringFormat = "{0:C2}" });
            differenceLabel.SetBinding(Label.TextProperty, new Binding("Difference") { StringFormat = "{0:C2}" });

            grid.Children.Add(monthLabel);
            grid.Children.Add(yearLabel, 1, 0);
            grid.Children.Add(revenueLabel, 2, 0);
            grid.Children.Add(costLabel, 3, 0);
            grid.Children.Add(differenceLabel, 4, 0);

            View = grid;
        }
    }
}