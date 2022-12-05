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
            _viewModel = new SettingsViewModel();

        }


        protected async override void OnAppearing()
        {



        }

        private async void EditUser_Tapped(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EditUserPage());
        }

        private async void ChangeLanguage_Tapped(object sender, System.EventArgs e)
        {
            //await Application.Current.MainPage.DisplayAlert("Language", "To be added", "OK");
            string action = await DisplayActionSheet("Change Language", "Cancel", null, "English", "Swahili", "Vietnamese", "Kinyarwanda");
            Console.WriteLine(action);
            bool answer = await DisplayAlert("Are you sure?", "Are you sure you want to change your language to " + action + "?", "Yes", "No");
            if (answer)
            {
                Console.WriteLine("this");

                //change language
                _viewModel.ChangeUserLanguage(action);
                //refresh page
            }
        }
    }
}