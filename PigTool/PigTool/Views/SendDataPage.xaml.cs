using PigTool.Helpers;
using PigTool.ViewModels;
using PigTool.Views.Popups;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PigTool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SendDataPage : ContentPage
    {

        SendDataViewModel _ViewModel;
        Grid grid { get; set; }

        public SendDataPage()
        {
            InitializeComponent();
            BindingContext = _ViewModel = new SendDataViewModel();
            UserLabel.Text = _ViewModel.User.UserName;
            LastUpdateDateLabel.Text = _ViewModel.User.LastUploadDate.ToString();

            SendDataButton.Command = _ViewModel.SendDataToApi;

        }


        protected async override void OnAppearing()
        {
            await _ViewModel.PopulateCollections();
            //TotalItemsLabel.Text = _ViewModel.Countof_TotalItems.ToString();
            TotalItemsLabel.SetBinding(Label.TextProperty, nameof(_ViewModel.Countof_TotalItems));
            _ViewModel.PageRendered = true;
        }

        async void OnViewDetailsClicked(object sender, EventArgs e)
        {
            grid = GetItemsGrid();
            //var result = await App.Current.MainPage.Navigation.ShowPopupAsync(new SendDataDetails(grid));
            SendDataDetails detailsView = new SendDataDetails(grid);
            await PopupNavigation.Instance.PushAsync(detailsView);
        }

        private void createTableRowandDataLabel(Grid grid, string LabelText, int countOfRecords, int colNum, int rowNum)
        {
            grid.Children.Add(new Label { Text = LabelText }, colNum, rowNum);

            var amountOfRecordsLabel = new Label();
            amountOfRecordsLabel.Text = countOfRecords.ToString();
            grid.Children.Add(amountOfRecordsLabel, colNum + 1, rowNum);
        }

        Grid GetItemsGrid()
        {
            var ReturnGrid = new Grid
            {
                Margin = new Thickness(0, 20, 0, 20),
                ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = new GridLength(0.75, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(0.25, GridUnitType.Star) }
                    }
            };

            ReturnGrid.RowDefinitions = new RowDefinitionCollection {
                new RowDefinition (),
                new RowDefinition (),
                new RowDefinition (),
                new RowDefinition (),
                new RowDefinition (),
                new RowDefinition (),
                new RowDefinition (),
                new RowDefinition (),
                new RowDefinition (),
                new RowDefinition (),
                new RowDefinition (),
                new RowDefinition (),
                new RowDefinition (),
                new RowDefinition (),
                new RowDefinition ()
                };

            createTableRowandDataLabel(ReturnGrid, _ViewModel.Feed,
                _ViewModel.CountOf_FeedItems, 0, 0);
            createTableRowandDataLabel(ReturnGrid, _ViewModel.Healthcare,
                _ViewModel.CountOf_HealthCareItems, 0, 1);
            createTableRowandDataLabel(ReturnGrid, _ViewModel.Labour,
                _ViewModel.Countof_LabourCostItems, 0, 2);
            createTableRowandDataLabel(ReturnGrid, _ViewModel.Housing,
                _ViewModel.Countof_AnimalHouseItems, 0, 3);
            createTableRowandDataLabel(ReturnGrid, _ViewModel.Water,
                _ViewModel.Countof_Watercostitems, 0, 4);
            createTableRowandDataLabel(ReturnGrid, _ViewModel.Reproduction,
                _ViewModel.Countof_ReproductiveItems, 0, 5);
            createTableRowandDataLabel(ReturnGrid, _ViewModel.Membership,
                _ViewModel.Countof_MembershipItems, 0, 6);
            createTableRowandDataLabel(ReturnGrid, _ViewModel.Other,
                _ViewModel.Countof_OtherCostItems, 0, 7);
            createTableRowandDataLabel(ReturnGrid, _ViewModel.AnimalPurchase,
                _ViewModel.Countof_AnimalPurchaseItems, 0, 8);
            createTableRowandDataLabel(ReturnGrid, _ViewModel.LoanRepayment,
                _ViewModel.Countof_LoanRepaymentItems, 0, 9);
            createTableRowandDataLabel(ReturnGrid, _ViewModel.Equipment,
                _ViewModel.Countof_EquipmentItems, 0, 10);
            createTableRowandDataLabel(ReturnGrid, _ViewModel.PigSale,
                _ViewModel.Countof_PigSaleItems, 0, 11);
            createTableRowandDataLabel(ReturnGrid, _ViewModel.BreedingServiceSale,
                _ViewModel.Countof_BreedingServiceSaleItems, 0, 12);
            createTableRowandDataLabel(ReturnGrid, _ViewModel.ManureSale,
                _ViewModel.Countof_ManureSaleItems, 0, 13);
            createTableRowandDataLabel(ReturnGrid, _ViewModel.OtherIncome,
                _ViewModel.Countof_OtherIncomeItems, 0, 14);

            return ReturnGrid;
        }
    }
}