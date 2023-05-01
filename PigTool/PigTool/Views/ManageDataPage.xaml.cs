using PigTool.Helpers;
using Shared;
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
                var YearPickerVerticalStack = FormattedElementsHelper.TableRowStack(stackOrientation: StackOrientation.Vertical);
                YearPickerVerticalStack.Padding = 0;
                var YearPickerTypeStack = FormattedElementsHelper.TableRowStack();
                YearPickerTypeStack.Children.Add(FormattedElementsHelper.FormDataLabel(nameof(_ViewModel.FilterTranslation)));

                int baseYear = 2015;
                var yearPicker = new Picker()
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    ItemsSource = Enumerable.Range(baseYear, DateTime.Now.Year - baseYear + 3).ToList()
                    //ItemsSource = new List<int>() { 2017, 2018, 2019, 2020, 2021, 2022, 2023 }
                };

                yearPicker.SetBinding(Picker.SelectedItemProperty, new Binding(nameof(_ViewModel.SelectedYear)));
                YearPickerTypeStack.Children.Add(yearPicker);
                YearPickerVerticalStack.Children.Add(YearPickerTypeStack);
                

                // Fist Attach Feed Items
                var FeedItemsExpander = createExpanderElement(
                      ExpanderTitle: _ViewModel.Feed,
                      ColoumnHeader1: "Feed Type",
                      ColoumnHeader2: "Date",
                      ColoumnHeader3: "Total Cost",
                      BindableColumns1: nameof(FeedItem.FeedTypeTranslationString),
                      BindableColumns2: nameof(FeedItem),
                      BindableColumns3: nameof(FeedItem.TotalCosts),
                      BindingList: nameof(_ViewModel.FeedItems),
                      NavigationCommand: _ViewModel.EditFeedItem
                      );


                var HealthItemsExpander = createExpanderElement(
                      ExpanderTitle: _ViewModel.Healthcare,
                      ColoumnHeader1: "Health Care Type",
                      ColoumnHeader2: "Date",
                      ColoumnHeader3: "Care Cost",
                      BindableColumns1: nameof(HealthCareItem.DisplayTypeTranslationString),
                      BindableColumns2: nameof(HealthCareItem.DateNiceFormat),
                      BindableColumns3: nameof(HealthCareItem.HealthCareCost),
                      BindingList: nameof(_ViewModel.HealthCareItems),
                      NavigationCommand: _ViewModel.EditHealthCareItem
                      );

                var LabourCostItems = createExpanderElement(
                      ExpanderTitle: "Labour Cost Items",
                      ColoumnHeader1: "Labour Cost Type",
                      ColoumnHeader2: "Date",
                      ColoumnHeader3: "Labour Cost",
                      BindableColumns1: nameof(LabourCostItem.DisplayTypeTranslationString),
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
                      BindableColumns2: nameof(AnimalHouseItem.AnimalExpenseTranslationString),
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

                var ReproductiveItems = createExpanderElement(
                      ExpanderTitle: "Reproduction",
                      ColoumnHeader1: "Date",
                      ColoumnHeader2: "Type",
                      ColoumnHeader3: "Sows Serviced",
                      BindableColumns1: nameof(ReproductiveItem.Date),
                      BindableColumns2: nameof(ReproductiveItem.DisplayTypeTranslationString),
                      BindableColumns3: nameof(ReproductiveItem.SowsServicedCost),
                      BindingList: nameof(_ViewModel.ReproductiveItems),
                      NavigationCommand: _ViewModel.EditReproductiveItem
                      );

                var MembershipItems = createExpanderElement(
                      ExpanderTitle: "Memberships",
                      ColoumnHeader1: "Date",
                      ColoumnHeader2: "Type",
                      ColoumnHeader3: "Cost",
                      BindableColumns1: nameof(MembershipItem.Date),
                      BindableColumns2: nameof(MembershipItem.DisplayTypeTranslationString),
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

                var AnimalPurchaseItems = createExpanderElement(
                      ExpanderTitle: "Animal Purchase",
                      ColoumnHeader1: "Date",
                      ColoumnHeader2: "Animal Type",
                      ColoumnHeader3: "Cost",
                      BindableColumns1: nameof(AnimalPurchaseItem.Date),
                      BindableColumns2: nameof(AnimalPurchaseItem.DisplayTypeTranslationString),
                      BindableColumns3: nameof(AnimalPurchaseItem.TotalCosts),
                      BindingList: nameof(_ViewModel.AnimalPurchaseItems),
                      NavigationCommand: _ViewModel.EditAnimalPurchaseItem
                      );

                var LoanRepaymentItems = createExpanderElement(
                      ExpanderTitle: "Loan Repayment",
                      ColoumnHeader1: "Date",
                      ColoumnHeader2: "Repaid",
                      ColoumnHeader3: "Provider",
                      BindableColumns1: nameof(LoanRepaymentItem.Date),
                      BindableColumns2: nameof(LoanRepaymentItem.TotalAmountRepaid),
                      BindableColumns3: nameof(LoanRepaymentItem.DisplayTypeTranslationString),
                      BindingList: nameof(_ViewModel.LoanRepaymentItems),
                      NavigationCommand: _ViewModel.EditLoanRepaymentItem
                      );

                var EquipmentItems = createExpanderElement(
                      ExpanderTitle: "Equipment",
                      ColoumnHeader1: "Date",
                      ColoumnHeader2: "Equipment Type",
                      ColoumnHeader3: "Total Cost",
                      BindableColumns1: nameof(EquipmentItem.Date),
                      BindableColumns2: nameof(EquipmentItem.DisplayTypeTranslationString),
                      BindableColumns3: nameof(EquipmentItem.TotalCosts),
                      BindingList: nameof(_ViewModel.EquipmentItems),
                      NavigationCommand: _ViewModel.EditEquipmentItem
                      );

                var PigSaleItems = createExpanderElement(
                      ExpanderTitle: "Pig Sales",
                      ColoumnHeader1: "Date",
                      ColoumnHeader2: "Pig Type",
                      ColoumnHeader3: "Sale Price",
                      BindableColumns1: nameof(PigSaleItem.Date),
                      BindableColumns2: nameof(PigSaleItem.DisplayTypeTranslationString),
                      BindableColumns3: nameof(PigSaleItem.SalePrice),
                      BindingList: nameof(_ViewModel.PigSaleItems),
                      NavigationCommand: _ViewModel.EditPigSaleItem
                      );

                var BreedingServiceSaleItems = createExpanderElement(
                      ExpanderTitle: "Breeding Service Sales",
                      ColoumnHeader1: "Date",
                      ColoumnHeader2: "Service Type",
                      ColoumnHeader3: "Amount Recieved",
                      BindableColumns1: nameof(BreedingServiceSaleItem.Date),
                      BindableColumns2: nameof(BreedingServiceSaleItem.DisplayTypeTranslationString),
                      BindableColumns3: nameof(BreedingServiceSaleItem.AmountRecieved),
                      BindingList: nameof(_ViewModel.BreedingServiceSaleItems),
                      NavigationCommand: _ViewModel.EditBreedingServiceSaleItem
                      );

                var ManureSaleItems = createExpanderElement(
                      ExpanderTitle: "Manure Sales",
                      ColoumnHeader1: "Date",
                      ColoumnHeader2: "Sold To",
                      ColoumnHeader3: "Amount Recieved",
                      BindableColumns1: nameof(ManureSaleItem.Date),
                      BindableColumns2: nameof(ManureSaleItem.DisplayTypeTranslationString),
                      BindableColumns3: nameof(ManureSaleItem.AmountRecieved),
                      BindingList: nameof(_ViewModel.ManureSaleItems),
                      NavigationCommand: _ViewModel.EditManureSaleItem
                      );

                var OtherIncomeItems = createExpanderElement(
                      ExpanderTitle: "Other Income",
                      ColoumnHeader1: "Date",
                      ColoumnHeader2: "What for",
                      ColoumnHeader3: "Income",
                      BindableColumns1: nameof(OtherIncomeItem.Date),
                      BindableColumns2: nameof(OtherIncomeItem.OtherWhatFor),
                      BindableColumns3: nameof(OtherIncomeItem.TotalIncome),
                      BindingList: nameof(_ViewModel.OtherIncomeItems),
                      NavigationCommand: _ViewModel.EditOtherIncomeItem
                      );

                ManageStack.Children.Add(YearPickerVerticalStack);
                ManageStack.Children.Add(FeedItemsExpander);
                ManageStack.Children.Add(HealthItemsExpander);
                ManageStack.Children.Add(LabourCostItems);
                ManageStack.Children.Add(AnimalHousingItems);
                ManageStack.Children.Add(WaterCostItems);
                ManageStack.Children.Add(ReproductiveItems);
                ManageStack.Children.Add(MembershipItems);
                ManageStack.Children.Add(OtherCostItems);
                ManageStack.Children.Add(AnimalPurchaseItems);
                ManageStack.Children.Add(LoanRepaymentItems);
                ManageStack.Children.Add(EquipmentItems);
                ManageStack.Children.Add(PigSaleItems);
                ManageStack.Children.Add(BreedingServiceSaleItems);
                ManageStack.Children.Add(ManureSaleItems);
                ManageStack.Children.Add(OtherIncomeItems);
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
                Header = frame,
                BackgroundColor = Color.White,
                Margin = 0
            };


            expander.ContentTemplate = new DataTemplate(() =>
            {
                StackLayout stackHolder = new StackLayout();

                ListView listvw = new ListView();
                listvw.HeightRequest = 300;
                
                Grid Headergrid = new Grid
                {
                    BackgroundColor = Color.FromHex("#682622"),
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
                    return new CustomManageDataCell(BindableColumns1, BindableColumns2, BindableColumns3, NavigationCommand);
                });
                
                stackHolder.Children.Add(listvw);
                return stackHolder;
            });

            StackLayout stackHolder = new StackLayout();

            return expander;
        }

    }

    public class CustomManageDataCell : ViewCell
    {
        public CustomManageDataCell(string var1, string var2, string var3, Command command)
        {

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

            Label column1Data = FormattedElementsHelper.ManageDataDetailsLabelField(var1);
            Label column2Data = FormattedElementsHelper.ManageDataDetailsLabelField(var2);
            Label column3Data = FormattedElementsHelper.ManageDataDetailsLabelField(var3);
            Button button = new Button() { 
                TextColor = Color.FromHex("#682622"),
                BackgroundColor = Color.White,
                TextTransform = TextTransform.None,
                Text = "View",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            button.Command = command;
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
