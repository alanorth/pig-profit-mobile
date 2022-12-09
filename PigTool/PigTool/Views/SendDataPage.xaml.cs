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
        Grid grid;

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

            TotalItemsLabel.Text = _ViewModel.Countof_TotalItems.ToString();



            grid = new Grid
            {
                Margin = new Thickness(0, 20, 0, 20),
                ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = new GridLength(0.75, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(0.25, GridUnitType.Star) }
                    }
            };

            grid.RowDefinitions = new RowDefinitionCollection {
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

            createTableRowandDataLabel(grid, nameof(_ViewModel.FeedItems),
                _ViewModel.CountOf_FeedItems, 0, 0);
            createTableRowandDataLabel(grid, nameof(_ViewModel.HealthCareItems),
                _ViewModel.CountOf_HealthCareItems, 0, 1);
            createTableRowandDataLabel(grid, nameof(_ViewModel.LabourCostItems),
                _ViewModel.Countof_LabourCostItems, 0, 2);
            createTableRowandDataLabel(grid, nameof(_ViewModel.AnimalHouseItems),
                _ViewModel.Countof_AnimalHouseItems, 0, 3);
            createTableRowandDataLabel(grid, nameof(_ViewModel.WaterCostItems),
                _ViewModel.Countof_Watercostitems, 0, 4);
            createTableRowandDataLabel(grid, nameof(_ViewModel.ReproductiveItems),
                _ViewModel.Countof_ReproductiveItems, 0, 5);
            createTableRowandDataLabel(grid, nameof(_ViewModel.MembershipItems),
                _ViewModel.Countof_MembershipItems, 0, 6);
            createTableRowandDataLabel(grid, nameof(_ViewModel.OtherCostItems),
                _ViewModel.Countof_OtherCostItems, 0, 7);
            createTableRowandDataLabel(grid, nameof(_ViewModel.AnimalPurchaseItems),
                _ViewModel.Countof_AnimalPurchaseItems, 0, 8);
            createTableRowandDataLabel(grid, nameof(_ViewModel.LoanRepaymentItems),
                _ViewModel.Countof_LoanRepaymentItems, 0, 9);
            createTableRowandDataLabel(grid, nameof(_ViewModel.EquipmentItems),
                _ViewModel.Countof_EquipmentItems, 0, 10);
            createTableRowandDataLabel(grid, nameof(_ViewModel.PigSaleItems),
                _ViewModel.Countof_PigSaleItems, 0, 11);
            createTableRowandDataLabel(grid, nameof(_ViewModel.BreedingServiceSaleItems),
                _ViewModel.Countof_BreedingServiceSaleItems, 0, 12);
            createTableRowandDataLabel(grid, nameof(_ViewModel.ManureSaleItems),
                _ViewModel.Countof_ManureSaleItems, 0, 13);
            createTableRowandDataLabel(grid, nameof(_ViewModel.OtherIncomeItems),
                _ViewModel.Countof_OtherIncomeItems, 0, 14);

            _ViewModel.PageRendered = true;



        }

        async void OnViewDetailsClicked(object sender, EventArgs e)
        {
            //var result = await App.Current.MainPage.Navigation.ShowPopupAsync(new SendDataDetails(grid));
            SendDataDetails detailsView = new SendDataDetails(grid);
            await PopupNavigation.Instance.PushAsync(detailsView);
        }

        private void createTableRowandDataLabel(Grid grid, string LabelText, int countOfRecords, int colNum, int rowNum)
        {
            grid.Children.Add(new Label { Text = LabelText }, colNum, rowNum);

            var amountOfRecordsLabel = new Label();
            //var amountOfRecordsLabel = new Label() { Text = "Testing"};
            var t = FormattedElementsHelper.FormDataLabel(nameof(_ViewModel.CountOf_FeedItems));

            //amountOfRecordsLabel.SetBinding(Label.TextProperty, new Binding(countOfRecords));
            amountOfRecordsLabel.Text = countOfRecords.ToString();
            grid.Children.Add(amountOfRecordsLabel, colNum + 1, rowNum);
        }
    }
}