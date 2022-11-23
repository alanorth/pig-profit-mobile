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
using PigTool.ViewModels;

namespace PigTool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationSuccessfulPage : ContentPage
    {
        RegistrationSuccessfulViewModel _viewModel;

        public RegistrationSuccessfulPage()
        {
            BindingContext = _viewModel = new RegistrationSuccessfulViewModel();
            InitializeComponent();
            TitleLabel.Text = _viewModel.RegistrationSuccessfulTitleTranslation;
            DescLabel.Text = _viewModel.RegistrationSuccessfulDescTranslation;
            ContinueBtn.Text = _viewModel.RegistrationSuccessfulContinueTranslation;
        }

        async void Continue(object sender, EventArgs e)
        {
            try
            {
               // await Shell.Current.GoToAsync("//main");
                Application.Current.MainPage = new AppShell();
               
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}