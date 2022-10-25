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


            Random rnd = new Random();

            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(rnd.Next(1000, 10000)); // returns random integers >= 10 and < 20
            }

            ObservableCollection<Profit> profits = new ObservableCollection<Profit>();
            profits.Add(new Profit { month = "Jan 22", cost = rnd.Next(1000, 10000), revenue = rnd.Next(1000, 10000), difference = rnd.Next(1000, 10000) });
            profits.Add(new Profit { month = "Feb 22", cost = rnd.Next(1000, 10000), revenue = rnd.Next(1000, 10000), difference = rnd.Next(1000, 10000) });
            profits.Add(new Profit { month = "Mar 22", cost = rnd.Next(1000, 10000), revenue = rnd.Next(1000, 10000), difference = rnd.Next(1000, 10000) });
            profits.Add(new Profit { month = "Apr 22", cost = rnd.Next(1000, 10000), revenue = rnd.Next(1000000, 10000000), difference = rnd.Next(1000, 10000) });
            profits.Add(new Profit { month = "May 22", cost = rnd.Next(1000, 10000), revenue = rnd.Next(1000, 10000), difference = rnd.Next(1000, 10000) });
            profits.Add(new Profit { month = "Jun 22", cost = rnd.Next(1000, 10000), revenue = rnd.Next(1000, 10000), difference = rnd.Next(1000, 10000) });
            profits.Add(new Profit { month = "Jul 22", cost = rnd.Next(1000, 10000), revenue = rnd.Next(1000, 10000), difference = rnd.Next(1000, 10000) });
            profits.Add(new Profit { month = "Aug 22", cost = rnd.Next(1000, 10000), revenue = rnd.Next(1000, 10000), difference = rnd.Next(1000, 10000) });
            profits.Add(new Profit { month = "Sep 22", cost = rnd.Next(1000, 10000), revenue = rnd.Next(1000, 10000), difference = rnd.Next(1000, 10000) });
            profits.Add(new Profit { month = "Oct 22", cost = rnd.Next(1000, 10000), revenue = rnd.Next(1000, 10000), difference = rnd.Next(1000, 10000) });


            Grid Headergrid = new Grid
            {
                BackgroundColor = Color.FromHex("#682622"),
                ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star }
                    }
            };

            Headergrid.Children.Add(FormattedElementsHelper.ReportTableHeaderLabelField("Month"), 0, 0);
            Headergrid.Children.Add(FormattedElementsHelper.ReportTableHeaderLabelField("Income"), 1, 0);
            Headergrid.Children.Add(FormattedElementsHelper.ReportTableHeaderLabelField("Costs"), 2, 0);
            Headergrid.Children.Add(FormattedElementsHelper.ReportTableHeaderLabelField("Profit / Loss"), 3, 0);


            ListView listvw = new ListView();
            listvw.Header = Headergrid;
            listvw.ItemsSource = profits;
            listvw.ItemTemplate = new DataTemplate(() =>
            {
                return new CustomSummaryTableCell(nameof(Profit.month), nameof(Profit.revenue), nameof(Profit.cost), nameof(Profit.difference));
            });

            SummaryTable.Children.Add(listvw);

        }
    }


    public class Profit {
        public string month { get; set; }
        public double cost { get; set; }
        public double revenue { get; set; }
        public double difference { get; set; }
    }

    public class CustomSummaryTableCell : ViewCell
    {
        public CustomSummaryTableCell(string var1, string var2, string var3, string var4)
        {

            var horizontalLayout = new StackLayout() { BackgroundColor = Color.White };
            horizontalLayout.Orientation = StackOrientation.Horizontal;
            horizontalLayout.HorizontalOptions = LayoutOptions.Fill;

            Grid TemplateContents = new Grid
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                ColumnSpacing = 0,
                ColumnDefinitions = {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star }
                    }
            };

            Label column1Data = FormattedElementsHelper.ReportTableLabelField(var1);
            Label column2Data = FormattedElementsHelper.ReportTableLabelField(var2);
            Label column3Data = FormattedElementsHelper.ReportTableLabelField(var3);
            Label column4Data = FormattedElementsHelper.ReportTableLabelField(var4);

            TemplateContents.Children.Add(column1Data, 0, 0);
            TemplateContents.Children.Add(column2Data, 1, 0);
            TemplateContents.Children.Add(column3Data, 2, 0);
            TemplateContents.Children.Add(column4Data, 3, 0);

            horizontalLayout.Children.Add(TemplateContents);

            View = horizontalLayout;
        }
    }
}