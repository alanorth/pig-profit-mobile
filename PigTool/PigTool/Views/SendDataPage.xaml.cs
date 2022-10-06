using PigTool.ViewModels;
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
    public partial class SendDataPage : ContentPage
    {

        SendDataViewModel _ViewModel;

        public SendDataPage()
        {
            InitializeComponent();
            _ViewModel = new SendDataViewModel();
            UserLabel.Text = _ViewModel.User.UserName;
            LastUpdateDateLabel.Text = _ViewModel.User.LastUploadDate.ToString();

            SendDataButton.Command =_ViewModel.SendDataToApi;
        }


        protected async override void OnAppearing()
        {
            await _ViewModel.PopulateCollections();
            _ViewModel.PageRendered = true;

           /* SendDataGrid.ColumnDefinitions = new ColumnDefinitionCollection {
                new ColumnDefinition { Width = GridLength.Star },
                new ColumnDefinition { Width = GridLength.Star } 
            };*/

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
                new RowDefinition ()
            };

            createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.FeedItems),_ViewModel.FeedItems.Count(), 0 , 0);
            createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.HealthCareItems), _ViewModel.HealthCareItems.Count(), 0, 1);
            createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.LabourCostItems), _ViewModel.LabourCostItems.Count(), 0, 2);
            createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.AnimalHouseItems), _ViewModel.AnimalHouseItems.Count(), 0, 3);
            createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.WaterCostItems), _ViewModel.WaterCostItems.Count(), 0, 4);
            createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.MembershipItems), _ViewModel.MembershipItems.Count(), 0, 5);
            createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.OtherCostItems), _ViewModel.OtherCostItems.Count(), 0, 6);
            createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.AnimalPurchaseItems), _ViewModel.AnimalPurchaseItems.Count(), 0, 7);
            createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.LoanRepaymentItems), _ViewModel.LoanRepaymentItems.Count(), 0, 8);
            createTableRowandDataLabel(SendDataGrid, nameof(_ViewModel.EquipmentItems), _ViewModel.EquipmentItems.Count(), 0, 9);
        }

        private void createTableRowandDataLabel(Grid grid, string LabelText, int NumberOfRecords, int colNum, int rowNum)
        {
            grid.Children.Add(new Label { Text = LabelText }, colNum, rowNum);
            grid.Children.Add(new Label { 
                Text = NumberOfRecords.ToString(), 
                HorizontalTextAlignment = TextAlignment.Center 
            }, colNum +1, rowNum);
        }
    }
}