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
    public partial class LegalDisclaimer : ContentPage
    {
        public LegalDisclaimer()
        {            
            InitializeComponent();
            BindingContext = new LegalDisclaimerViewModel(Navigation);
        }

        async void Continue(object sender, EventArgs e)
        {
            var ran = new Random();
            ran.Next(99999);
            await Navigation.PushAsync(new WebAuthenticatorPage());
            //await Navigation.PushAsync(new RegistrationPage("Token", "Email" + ran.Next(99999).ToString()));
            if (1 == 2)
            {
                await Navigation.PushAsync(new WebAuthenticatorPage());
            }
            //await Navigation.PushAsync(new WebAuthenticatorPage());
            //await Shell.Current.GoToAsync("//Registration");
        }
    }
}