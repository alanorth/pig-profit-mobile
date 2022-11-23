using PigTool.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PigTool.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command SignUpCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            SignUpCommand = new Command(SignUpClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            //await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
            ((App)Application.Current).MainPage = new AppShell();
        }

        private async void SignUpClicked(object obj)
        {
            //((App)Application.Current).MainPage = new LegalDisclaimer();
        }
    }
}
