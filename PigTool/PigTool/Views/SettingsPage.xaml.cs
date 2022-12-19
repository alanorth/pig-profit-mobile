using PigTool.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PigTool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        private SettingsViewModel _viewModel;
        public SettingsPage()
        {
            InitializeComponent();
            this.BindingContext = _viewModel = new SettingsViewModel();
            UserLanguage.Detail = _viewModel.GetUserLanguage();
        }

        private async void EditUser_Tapped(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EditUserPage());
        }

        private async void ChangeLanguage_Tapped(object sender, System.EventArgs e)
        {
            //await Application.Current.MainPage.DisplayAlert("Language", "To be added", "OK");
            string action = await DisplayActionSheet("Change Language", null, null, "English", "Swahili", "Vietnamese", "Kinyarwanda");
            if (action != null)
            {
                Console.WriteLine(action);
                bool answer = await DisplayAlert("Are you sure?", "Are you sure you want to change your language to " + action + "? Doing so will close the application.", "Yes", "No");
                if (answer)
                {
                    //change language
                    _viewModel.ChangeUserLanguage(action);

                    //Close app
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
            }

        }
    }
}