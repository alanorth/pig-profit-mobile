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
    public partial class AddDataPage : ContentPage
    {
        AddDataViewModel _viewModel;

        public AddDataPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new AddDataViewModel();
        }
    }
}