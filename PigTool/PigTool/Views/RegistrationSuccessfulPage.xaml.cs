using PigTool.Helpers;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PigTool.ViewModels.DataViewModels;

namespace PigTool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationSuccessfulPage : ContentPage
    {

        public RegistrationSuccessfulPage()
        {
            InitializeComponent();
        }

        async void Continue(object sender, EventArgs e)
        {
            try
            {
                await Shell.Current.GoToAsync("//main");
               
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}