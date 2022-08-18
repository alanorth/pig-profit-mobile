using PigTool.Models;
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
    public partial class HealthCarePage : ContentPage
    {
        HealthCareViewModel _ViewModel;

        public HealthCarePage()
        {
            BindingContext = _ViewModel = new HealthCareViewModel();

            InitializeComponent();
        }

        public HealthCarePage(HealthCareItem HCI)
        {
            BindingContext = _ViewModel = new HealthCareViewModel();
            _ViewModel.populatewithData(HCI);
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            await _ViewModel.PopulateDataDowns();

            
            base.OnAppearing();
        }

        public void IndexHasBeenChangedCheckTheValue(object sender, EventArgs e)
        {
            Console.WriteLine("Something Has Changed");
        }


    }
}