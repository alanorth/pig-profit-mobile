using PigTool.ViewModels;
using Shared;
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
        private LegalDisclaimerViewModel _viewModel;
        private UserLangSettings lang;
        private string translationRowKey;

        public LegalDisclaimer(UserLangSettings lang, string translationRowKey)
        {
            this.lang = lang;
            this.translationRowKey = translationRowKey;
            InitializeComponent();
            BindingContext = _viewModel = new LegalDisclaimerViewModel(Navigation, lang);
            LegalDisclaimerLabel.Text = _viewModel.LegalDisclaimerTitleTranslation;
            LegalBodyLabel.Text = _viewModel.LegalDisclaimerBodyTranslation;
            LegalAgreeLabel.Text = _viewModel.LegalDisclaimerAgreeTranslation;
            ProceedButton.Text = _viewModel.LegalDisclaimerProceedTranslation;
        }

        async void Continue(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WebAuthenticatorPage(lang, translationRowKey));
            //await Shell.Current.GoToAsync("//Registration");
        }
    }
}