using PigTool.Helpers;
using PigTool.Models;
using PigTool.Services;
using PigTool.ViewModels;
using Shared;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static PigTool.Helpers.ChartHelper;

namespace PigTool.Views
{
    public partial class SummaryTab : ContentPage
    {
        SummaryTabViewModel _ViewModel;
        private DateRange _dateRange;
        bool reRender = true;
        bool FirstDislay  = true;

        public SummaryTab(DateRange dateRange)
        {
            
            _dateRange = dateRange;
            InitializeComponent();
            BindingContext = _ViewModel = new SummaryTabViewModel();
            //_ViewModel.StartDate = DateTime.Now.AddDays(-20);
            //startDatePicker.Date = DateTime.Now.AddMonths(-6);
            //endDatePicker.SetBinding(DatePicker.DateProperty, nameof(_ViewModel.EndDate));
            //startDatePicker.SetBinding(DatePicker.DateProperty, nameof(_ViewModel.StartDate));
            DurationLabel.SetBinding(Label.TextProperty,nameof(_ViewModel.ReportingDuration));
            SummaryTableTitle.SetBinding(Label.TextProperty, nameof(_ViewModel.SummaryTableHeading));
            PopulateThePage();
            if (FirstDislay)
            {
                var task = Task.Run(async () => await _ViewModel.ConstructPage());
                task.Wait();
                FirstDislay = false;
            }

            this.Title = _ViewModel.SummaryLabel;
        }

        private async void PopulateThePage()
        {
            //StartYear.ItemsSource = Enumerable.Range(baseYear, DateTime.Now.Year - baseYear + 3).ToList();
            //EndYear.ItemsSource = Enumerable.Range(baseYear, DateTime.Now.Year - baseYear + 3).ToList();

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

            Headergrid.Children.Add(FormattedElementsHelper.ReportTableHeaderLabelField(_ViewModel.MonthTranslation), 0, 0);
            Headergrid.Children.Add(FormattedElementsHelper.ReportTableHeaderLabelField(_ViewModel.YearTranslation), 1, 0);
            Headergrid.Children.Add(FormattedElementsHelper.ReportTableHeaderLabelField(_ViewModel.SummaryIncomeTranslation), 2, 0);
            Headergrid.Children.Add(FormattedElementsHelper.ReportTableHeaderLabelField(_ViewModel.SummaryCostTranslation), 3, 0);
            Headergrid.Children.Add(FormattedElementsHelper.ReportTableHeaderLabelField(_ViewModel.SummaryProfitLossTranslation), 4, 0);

            ListView listvw = new ListView();
            listvw.Header = Headergrid;
            /*listvw.ItemsSource = _ViewModel.FullList.GroupBy(fl => new YearMonth
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
                }).OrderByDescending(fl => fl.YearMonth.Year).ThenByDescending(fl => fl.YearMonth.Month).ToList();*/
            listvw.SetBinding(ListView.ItemsSourceProperty, nameof(_ViewModel.FullListByMonthYear));
            listvw.ItemTemplate = new DataTemplate(typeof(SummaryTableCell));
            
            

            SummaryTable.Children.Add(listvw);

            var TotalCostLabel = new Label() { TextColor = Constants.EntryTextColor };
            TotalCostLabel.SetBinding(Label.TextProperty, nameof(_ViewModel.TotalPeriodCostLabel));
            var TotalRevenueLabel  = new Label() { TextColor = Constants.EntryTextColor };
            TotalRevenueLabel.SetBinding(Label.TextProperty, nameof(_ViewModel.TotalPeriodRevenueLabel));
            var ProfitLossLabel = new Label() { TextColor = Constants.EntryTextColor };
            ProfitLossLabel.SetBinding(Label.TextProperty, nameof(_ViewModel.TotalPeriodDifferenceLabel));
                        
            TotalLabels.Children.Add(TotalCostLabel);
            TotalLabels.Children.Add(TotalRevenueLabel);
            TotalLabels.Children.Add(ProfitLossLabel);
        }

        protected async override void OnAppearing()
        {

            startDatePicker.Date = _ViewModel.StartDate = _dateRange.StartDate;
            endDatePicker.Date = _ViewModel.EndDate = _dateRange.EndDate;
            if (!reRender)
            {
                await _ViewModel.ConstructPage();
                _ViewModel.CalculateSelected();
            }
            else
            {
                reRender = false;
            }
        }


        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            if(startDatePicker.Date <= endDatePicker.Date)
            {
                Recalculate();
            }
        }

        void Recalculate()
        {
            _dateRange.StartDate = _ViewModel.StartDate = startDatePicker.Date;
            _dateRange.EndDate = _ViewModel.EndDate = endDatePicker.Date;
        }

        private async void Refresh_Button_Clicked(object sender, EventArgs e)
        {
            await _ViewModel.ConstructPage();
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

            var monthLabel = new Label() { TextColor = Constants.EntryTextColor};
            var yearLabel = new Label() { TextColor = Constants.EntryTextColor };
            var revenueLabel = new Label() { TextColor = Constants.EntryTextColor };
            var costLabel = new Label() { TextColor = Constants.EntryTextColor };
            var differenceLabel = new Label() { TextColor = Constants.EntryTextColor };

            monthLabel.SetBinding(Label.TextProperty, "YearMonth.Month");
            yearLabel.SetBinding(Label.TextProperty, "YearMonth.Year");
            revenueLabel.SetBinding(Label.TextProperty, new Binding("Revenue") { StringFormat = "{0:N0}" });
            //costLabel.SetBinding(Label.TextProperty, new Binding("Cost") { StringFormat = "{0:"+ symbol + "#,##0.00}" });
            costLabel.SetBinding(Label.TextProperty, new Binding("Cost") { StringFormat = "{0:N0}" });
            differenceLabel.SetBinding(Label.TextProperty, new Binding("Difference") { StringFormat = "{0:N0}" });

            grid.Children.Add(monthLabel);
            grid.Children.Add(yearLabel, 1, 0);
            grid.Children.Add(revenueLabel, 2, 0);
            grid.Children.Add(costLabel, 3, 0);
            grid.Children.Add(differenceLabel, 4, 0);

            View = grid;
        }
    }
}