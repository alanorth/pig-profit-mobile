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
            await Shell.Current.GoToAsync("//Registration");
        }
    }
}