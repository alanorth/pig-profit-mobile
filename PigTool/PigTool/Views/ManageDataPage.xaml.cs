using PigTool.Helpers;
using PigTool.Models;
using PigTool.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PigTool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManageDataPage : ContentPage
    {
        ManageDataViewModel _ViewModel;

        public ObservableCollection<string> Items { get; set; }
       

        public ManageDataPage()
        {
            InitializeComponent();
            BindingContext = _ViewModel = new ManageDataViewModel();
        }


        protected async override void OnAppearing()
        {

            _ViewModel.FeedItems = new ObservableCollection<FeedItem>(await _ViewModel.PopulateFeedItemList());

            if (!_ViewModel.PageRendered)
            {

                //MyListView2.ItemsSource = Items;
                //MyListView.ItemsSource = FeedItems;

                var FeedItemsExpander = createExpanderElement(
                      ExpanderTitle: "Feed Items Trans",
                      ColoumnHeader1: "Feed Type",
                      ColoumnHeader2: "Date Obtained",
                      ColoumnHeader3: "Cost",
                      BindableColumns1: nameof(FeedItem.FeedType),
                      BindableColumns2: nameof(FeedItem.DateObtained),
                      BindableColumns3: nameof(FeedItem.Cost),
                      NavigationCommand: _ViewModel.AddFeedItem,
                      _ViewModel.FeedItems
                      );

                ManageStack.Children.Add(FeedItemsExpander);

                _ViewModel.PageRendered = true;
            }

            base.OnAppearing();
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        private Expander createExpanderElement(
            string ExpanderTitle,
            string ColoumnHeader1,
            string ColoumnHeader2,
            string ColoumnHeader3,
            string BindableColumns1,
            string BindableColumns2,
            string BindableColumns3,
            Command NavigationCommand,
            ObservableCollection<FeedItem> ObList)
        {

            var frame = new Frame();
            var headerLabel = new Label
            {
                Text = ExpanderTitle,
                FontAttributes = FontAttributes.Bold,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            frame.Content = headerLabel;

            Expander expander = new Expander
            {
                Header = frame
            };


            expander.ContentTemplate = new DataTemplate(() =>
            {
                StackLayout stackHolder = new StackLayout();

                ListView listvw = new ListView();

                Grid Headergrid = new Grid
                {
                    BackgroundColor = Color.Black,
                    ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star }
                }
                };

                Headergrid.Children.Add(FormattedElementsHelper.ManageDataLabel(ColoumnHeader1), 0, 0); ;
                Headergrid.Children.Add(FormattedElementsHelper.ManageDataLabel(ColoumnHeader2), 1, 0); 
                Headergrid.Children.Add(FormattedElementsHelper.ManageDataLabel(ColoumnHeader3), 2, 0); 
                Headergrid.Children.Add(FormattedElementsHelper.ManageDataLabel(""), 3, 0);

                listvw.Header = Headergrid;
                //listvw.ItemsSource = ObList;
                listvw.SetBinding(ListView.ItemsSourceProperty , new Binding("FeedItems")) ;

                listvw.ItemTemplate = new DataTemplate(() =>
                {
                    return new CustomVeggieCell(BindableColumns1, BindableColumns2, BindableColumns3, NavigationCommand);
                });
                stackHolder.Children.Add(listvw);
                return stackHolder;
            });

            StackLayout stackHolder = new StackLayout();

            //ListView listvw = new ListView();

            //Grid Headergrid = new Grid
            //{
            //    BackgroundColor = Color.Black,
            //    ColumnDefinitions =
            //    {
            //        new ColumnDefinition { Width = GridLength.Star },
            //        new ColumnDefinition { Width = GridLength.Star },
            //        new ColumnDefinition { Width = GridLength.Star },
            //        new ColumnDefinition { Width = GridLength.Star }
            //    }
            //};

            //Headergrid.Children.Add(new Label
            //{
            //    Text = "Feed",
            //    HorizontalOptions = LayoutOptions.FillAndExpand,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    BackgroundColor = Color.Red,
            //}, 0, 0);
            //Headergrid.Children.Add(new Label
            //{
            //    Text = "Feed",
            //    HorizontalOptions = LayoutOptions.FillAndExpand,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    BackgroundColor = Color.Red,
            //}, 1, 0); Headergrid.Children.Add(new Label
            //{
            //    Text = "Feed",
            //    HorizontalOptions = LayoutOptions.FillAndExpand,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    BackgroundColor = Color.Red,
            //}, 2, 0); Headergrid.Children.Add(new Label
            //{
            //    Text = "Feed",
            //    HorizontalOptions = LayoutOptions.FillAndExpand,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    BackgroundColor = Color.Red,
            //}, 3, 0);

            //listvw.Header = Headergrid;


            ////listvw.ItemTemplate = new DataTemplate(() => { var x = new CustomVeggieCell("FeedType", "FeedType", "FeedType");
            ////    return new ViewCell { View = x }; });

            ////listvw.ItemTemplate = new DataTemplate(() => { return new CustomVeggieCell(nameof(FeedItem.FeedType), nameof(FeedItem.Cost), nameof(FeedItem.DateObtained)); });

            ////listvw.ItemTemplate = new DataTemplate(typeof(CustomVeggieCell));

            //stackHolder.Children.Add(listvw);

            //listvw.ItemsSource = FeedItems;

            // var x =    (DataTemplate)new CustomVeggieCell("", "", "");
            // new ListView { ItemTemplate = (DataTemplate)Resources["personTemplate"], ItemsSource = people };

            //new ListView { ItemTemplate = new DataTemplate(typeof(PersonCellCS)), ItemsSource = people, Margin = new Thickness(0, 20, 0, 0) }


            /*expander.ContentTemplate = new DataTemplate(() =>
            {

                try
                {
                    var x =  new CustomVeggieCell(nameof(FeedItem.FeedType), nameof(FeedItem.Cost), nameof(FeedItem.DateObtained));

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return new CustomVeggieCell(nameof(FeedItem.FeedType), nameof(FeedItem.Cost), nameof(FeedItem.DateObtained));
                }

                return new CustomVeggieCell(nameof(FeedItem.FeedType), nameof(FeedItem.Cost), nameof(FeedItem.DateObtained));

            }
            );*/

            // expander.Content = stackHolder;
            return expander;
        }

    }

    public class CustomVeggieCell : ViewCell
    {
        public CustomVeggieCell(string var1, string var2, string var3, Command command)
        {
            var x = this;

            

            var horizontalLayout = new StackLayout() { BackgroundColor = Color.White };
            horizontalLayout.Orientation = StackOrientation.Horizontal;
            horizontalLayout.HorizontalOptions = LayoutOptions.Fill;

            Grid TemplateContents = new Grid
            {
                BackgroundColor = Color.Black,
                ColumnDefinitions = {
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star }
                    }
            };

            Label column1Data = FormattedElementsHelper.ManageDataDetailsLableField(var1);
            Label column2Data = FormattedElementsHelper.ManageDataDetailsLableField(var2);
            Label column3Data = FormattedElementsHelper.ManageDataDetailsLableField(var3);
            Button button = new Button() { 
                BackgroundColor = Color.Gray, 
                Text = "Edit",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            button.Command = command;
            //button.CommandParameter = "{Binding .}";
            button.SetBinding(Button.CommandParameterProperty, new Binding("."));

            TemplateContents.Children.Add(column1Data, 0, 0);
            TemplateContents.Children.Add(column2Data, 1, 0);
            TemplateContents.Children.Add(button, 3, 0);
            TemplateContents.Children.Add(column3Data, 2, 0);

            horizontalLayout.Children.Add(TemplateContents);

            View = horizontalLayout;
        }
    }
}
