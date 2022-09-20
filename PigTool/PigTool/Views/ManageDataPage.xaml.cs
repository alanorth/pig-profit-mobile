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
            await _ViewModel.PopulateLists();

            if (!_ViewModel.PageRendered)
            {

                // Fist Attach Feed Items
                var FeedItemsExpander = createExpanderElement(
                      ExpanderTitle: "Feed",
                      ColoumnHeader1: "Feed Type",
                      ColoumnHeader2: "Date",
                      ColoumnHeader3: "Total Cost",
                      BindableColumns1: nameof(FeedItem.FeedType),
                      BindableColumns2: nameof(FeedItem.Date),
                      BindableColumns3: nameof(FeedItem.TotalCosts),
                      BindingList: nameof(_ViewModel.FeedItems),
                      NavigationCommand: _ViewModel.EditFeedItem
                      );


                var HealthItemsExpander = createExpanderElement(
                      ExpanderTitle: "Health Care Items",
                      ColoumnHeader1: "Health Care Type",
                      ColoumnHeader2: "Date",
                      ColoumnHeader3: "Care Cost",
                      BindableColumns1: nameof(HealthCareItem.HealthCareType),
                      BindableColumns2: nameof(HealthCareItem.Date),
                      BindableColumns3: nameof(HealthCareItem.HealthCareCost),
                      BindingList: nameof(_ViewModel.HealthCareItems),
                      NavigationCommand: _ViewModel.EditHealthCareItem
                      );

                var LabourCostItems = createExpanderElement(
                      ExpanderTitle: "Labour Cost Items",
                      ColoumnHeader1: "Labour Cost Tyoe",
                      ColoumnHeader2: "Date",
                      ColoumnHeader3: "Labour Cost",
                      BindableColumns1: nameof(LabourCostItem.LabourType),
                      BindableColumns2: nameof(LabourCostItem.Date),
                      BindableColumns3: nameof(LabourCostItem.AmountPaid),
                      BindingList: nameof(_ViewModel.LabourCostItems),
                      NavigationCommand: _ViewModel.EditLabourCostItem
                      );

                var AnimalHousingItems = createExpanderElement(
                      ExpanderTitle: "Housing",
                      ColoumnHeader1: "Date",
                      ColoumnHeader2: "Housing Expense",
                      ColoumnHeader3: "Cost",
                      BindableColumns1: nameof(AnimalHouseItem.Date),
                      BindableColumns2: nameof(AnimalHouseItem.HousingExpense),
                      BindableColumns3: nameof(AnimalHouseItem.TotalCosts),
                      BindingList: nameof(_ViewModel.AnimalHouseItems),
                      NavigationCommand: _ViewModel.EditAnimalHouseItem
                      );

                var WaterCostItems = createExpanderElement(
                      ExpanderTitle: "Water Cost",
                      ColoumnHeader1: "Date",
                      ColoumnHeader2: "Water",
                      ColoumnHeader3: "Cost",
                      BindableColumns1: nameof(WaterCostItem.Date),
                      BindableColumns2: nameof(WaterCostItem.WaterPurchased),// + " " + nameof(WaterCostItem.WaterPurchasedUnit),
                      BindableColumns3: nameof(WaterCostItem.TotalCosts),
                      BindingList: nameof(_ViewModel.WaterCostItems),
                      NavigationCommand: _ViewModel.EditWaterCostItem
                      );

                var MembershipItems = createExpanderElement(
                      ExpanderTitle: "Memberships",
                      ColoumnHeader1: "Date",
                      ColoumnHeader2: "Type",
                      ColoumnHeader3: "Cost",
                      BindableColumns1: nameof(MembershipItem.Date),
                      BindableColumns2: nameof(MembershipItem.MembershipType),
                      BindableColumns3: nameof(MembershipItem.TotalCosts),
                      BindingList: nameof(_ViewModel.MembershipItems),
                      NavigationCommand: _ViewModel.EditMembershipItem
                      );

                var OtherCostItems = createExpanderElement(
                      ExpanderTitle: "Other Costs",
                      ColoumnHeader1: "Date",
                      ColoumnHeader2: "What for",
                      ColoumnHeader3: "Cost",
                      BindableColumns1: nameof(OtherCostItem.Date),
                      BindableColumns2: nameof(OtherCostItem.OtherWhatFor),
                      BindableColumns3: nameof(OtherCostItem.TotalCosts),
                      BindingList: nameof(_ViewModel.OtherCostItems),
                      NavigationCommand: _ViewModel.EditOtherCostItem
                      );

                ManageStack.Children.Add(FeedItemsExpander);
                ManageStack.Children.Add(HealthItemsExpander);
                ManageStack.Children.Add(LabourCostItems);
                ManageStack.Children.Add(AnimalHousingItems);
                ManageStack.Children.Add(WaterCostItems);
                ManageStack.Children.Add(MembershipItems);
                ManageStack.Children.Add(OtherCostItems);
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
            string BindingList,
            Command NavigationCommand
            )
        {

            var frame = new Frame();
            var headerLabel = new Label
            {
                Text = ExpanderTitle,
                FontAttributes = FontAttributes.Bold,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
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
                    BackgroundColor = Color.FromHex("#404E65"),
                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star }
                    }
                };

                Headergrid.Children.Add(FormattedElementsHelper.ManageDataLabel(ColoumnHeader1), 0, 0);
                Headergrid.Children.Add(FormattedElementsHelper.ManageDataLabel(ColoumnHeader2), 1, 0); 
                Headergrid.Children.Add(FormattedElementsHelper.ManageDataLabel(ColoumnHeader3), 2, 0); 
                Headergrid.Children.Add(FormattedElementsHelper.ManageDataLabel(""), 3, 0);
                
                listvw.Header = Headergrid;
                //listvw.ItemsSource = ObList;
                listvw.SetBinding(ListView.ItemsSourceProperty , BindingList) ;
                
                listvw.ItemTemplate = new DataTemplate(() =>
                {
                    return new CustomVeggieCell(BindableColumns1, BindableColumns2, BindableColumns3, NavigationCommand);
                });
                
                stackHolder.Children.Add(listvw);
                return stackHolder;
            });

            StackLayout stackHolder = new StackLayout();

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
                ColumnSpacing = 0,
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
                TextColor = Color.FromHex("#404e65"),
                BackgroundColor = Color.White,
                TextTransform = TextTransform.None,
                Text = "View",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            button.Command = command;
            //button.CommandParameter = "{Binding .}";
            button.SetBinding(Button.CommandParameterProperty, new Binding("."));

            TemplateContents.Children.Add(column1Data, 0, 0);
            TemplateContents.Children.Add(column2Data, 1, 0);
            TemplateContents.Children.Add(column3Data, 2, 0);
            TemplateContents.Children.Add(button, 3, 0);
            

            horizontalLayout.Children.Add(TemplateContents);

            View = horizontalLayout;
        }
    }
}
