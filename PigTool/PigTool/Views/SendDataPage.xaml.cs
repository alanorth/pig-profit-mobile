using PigTool.Helpers;
using PigTool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace PigTool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SendDataPage : ContentPage
    {

        SendDataViewModel _ViewModel;

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


            if (!_ViewModel.PageRendered)
            {

                SendDataGrid.RowDefinitions = new RowDefinitionCollection {
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

                createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.FeedItems),
                    nameof(_ViewModel.CountOf_FeedItems), 0, 0);
                createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.HealthCareItems),
                    nameof(_ViewModel.CountOf_HealthCareItems), 0, 1);
                createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.LabourCostItems),
                    nameof(_ViewModel.Countof_LabourCostItems), 0, 2);
                createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.AnimalHouseItems),
                    nameof(_ViewModel.Countof_AnimalHouseItems), 0, 3);
                createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.WaterCostItems),
                    nameof(_ViewModel.Countof_Watercostitems), 0, 4);
                createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.MembershipItems),
                    nameof(_ViewModel.Countof_MembershipItems), 0, 5);
                createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.OtherCostItems),
                    nameof(_ViewModel.Countof_OtherCostItems), 0, 6);
                createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.AnimalPurchaseItems),
                    nameof(_ViewModel.Countof_AnimalPurchaseItems), 0, 7);
                createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.LoanRepaymentItems),
                    nameof(_ViewModel.Countof_LoanRepaymentItems), 0, 8);
                createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.EquipmentItems),
                    nameof(_ViewModel.Countof_EquipmentItems), 0, 9);
                createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.PigSaleItems),
                    nameof(_ViewModel.Countof_PigSaleItems), 0, 10);
                createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.BreedingServiceSaleItems),
                    nameof(_ViewModel.Countof_BreedingServiceSaleItems), 0, 11);
                createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.ManureSaleItems),
                    nameof(_ViewModel.Countof_ManureSaleItems), 0, 12);
                createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.OtherIncomeItems),
                    nameof(_ViewModel.Countof_OtherIncomeItems), 0, 13);

                _ViewModel.PageRendered = true;
            }
        }

        private void createTableRowandDataLabel(Grid grid, string LabelText, string countOfRecords, int colNum, int rowNum)
        {
            grid.Children.Add(new Label { Text = LabelText }, colNum, rowNum);

            var amountOfRecordsLabel = new Label();
            //var amountOfRecordsLabel = new Label() { Text = "Testing"};
            var t = FormattedElementsHelper.FormDataLabel(nameof(_ViewModel.CountOf_FeedItems));

            amountOfRecordsLabel.SetBinding(Label.TextProperty, new Binding(countOfRecords));
            grid.Children.Add(amountOfRecordsLabel, colNum + 1, rowNum);
        }
    }
}