using PigTool.ViewModels;
using Shared;
using System;
using System.Diagnostics;
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
            this.Title = _viewModel.SettingsPageTranslation;
            UserProfile.Text = _viewModel.ChangeProfileTranslation;
            UserLanguage.Text = _viewModel.LanguageTranslation;
            Logout.Text = _viewModel.LogoutTranslation;
        }

        private async void EditUser_Tapped(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EditUserPage());
        }

        private async void ChangeLanguage_Tapped(object sender, System.EventArgs e)
        {
            //await Application.Current.MainPage.DisplayAlert("Language", "To be added", "OK");
            string action = await DisplayActionSheet(_viewModel.ChangeLanguageTrasnlation, null, null, "English", "Luganda", "Tiếng Việt", "Kinyarwanda");
            if (action != null)
            {
                Console.WriteLine(action);
                bool answer = await DisplayAlert(_viewModel.SureTranslation, _viewModel.AppRestartTranslation, _viewModel.YesTranslation, _viewModel.NoTranslation);
                if (answer)
                {
                    //change language
                    _viewModel.ChangeUserLanguage(action);

                    //Close app
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
            }

        }

        private async void LogUserOut(object sender, System.EventArgs e)
        {
            //logout
            var logout = await DisplayAlert(_viewModel.ConfirmLogoutTranslation, _viewModel.LogoutWarningTransaltion, _viewModel.AcceptTranslation, _viewModel.Cancel); ;

            if (logout)
            {
                await _viewModel.repo.LogoutOfDatabase();
                Process.GetCurrentProcess().Kill();
            }
        }
    }
}