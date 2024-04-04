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

        public LegalDisclaimer(UserLangSettings lang, string translationRowKey, bool displayFromSettings = false)
        {

            this.lang = lang;
            this.translationRowKey = translationRowKey;
            InitializeComponent();
            BindingContext = _viewModel = new LegalDisclaimerViewModel(Navigation, lang);
            LegalDisclaimerLabel.Text = _viewModel.LegalDisclaimerTitleTranslation;
            //LegalBodyLabel.Text = _viewModel.LegalDisclaimerBodyTranslation;
            LegalAgreeLabel.Text = _viewModel.LegalDisclaimerAgreeTranslation;
            ProceedButton.Text = _viewModel.LegalDisclaimerProceedTranslation;
            TermsAndConditions.Text = _viewModel.TermsAndConditionsTranslation;

            PP1.Text = _viewModel.PP1;
            PP2.Text = _viewModel.PP2;
            PP3.Text = _viewModel.PP3;
            PP4.Text = _viewModel.PP4;
            PP5.Text = _viewModel.PP5;
            PP6.Text = _viewModel.PP6;
            PP7.Text = _viewModel.PP7;
            PP8.Text = _viewModel.PP8;
            PP9.Text = _viewModel.PP9;
            PP10.Text = _viewModel.PP10;
            PP11.Text = _viewModel.PP11;
            PP12.Text = _viewModel.PP12;
            PP13.Text = _viewModel.PP13;
            PP14.Text = _viewModel.PP14;
            PP15.Text = _viewModel.PP15;
            PP16.Text = _viewModel.PP16;
            PP17.Text = _viewModel.PP17;
            PP18.Text = _viewModel.PP18;
            PP19.Text = _viewModel.PP19;
            PP20.Text = _viewModel.PP20;
            PP21.Text = _viewModel.PP21;
            PP22.Text = _viewModel.PP22;
            PP23.Text = _viewModel.PP23;
            PP24.Text = _viewModel.PP24;
            PP25.Text = _viewModel.PP25;
            PP26.Text = _viewModel.PP26;
            PP27.Text = _viewModel.PP27;
            PP28.Text = _viewModel.PP28;
            PP29.Text = _viewModel.PP29;
            PP30.Text = _viewModel.PP30;
            PP31.Text = _viewModel.PP31;
            PP32.Text = _viewModel.PP32;
            PP33.Text = _viewModel.PP33;

            var listOfNormaltext = new List<Label>
            {
                PP1,
                PP5,
                PP7,
                PP9,
                PP11,
                PP13,
                PP15,
                PP17,
                PP18,
                PP20,
                PP23,
                PP25,
                PP27,
                PP29,
                PP31,
                PP33

            };

            foreach (var item in listOfNormaltext)
            {
                item.StyleClass = new List<string> { "PrivacyPolicyText" };
            }

            var ListOfHeaders1 = new List<Label>
            {
                PP2,
                PP28,
                PP30,
                PP32,
            };

            foreach (var item in ListOfHeaders1)
            {
                item.StyleClass = new List<string> { "PrivacyPolicyHeaders1" };
            }


            var ListOfHeaders2 = new List<Label>
            {
                PP3,
                PP10,
                PP12,
                PP14,
                PP16,
                PP19,
                PP21,
                PP24,
                PP26,
            };
            foreach (var item in ListOfHeaders2)
            {
                item.StyleClass = new List<string> { "PrivacyPolicyHeaders2" };
            }

            var ListOfHeaders3 = new List<Label>
            {
                PP4,
                PP6,
                PP8,
                PP22,
            };
            foreach (var item in ListOfHeaders3)
            {
                item.StyleClass = new List<string> { "PrivacyPolicyHeaders3" };
            }

            if (displayFromSettings)
            {
                LegalAgreeLabel.IsVisible = false;
                checkBox.IsVisible = false;
                ProceedButton.IsVisible = false;
            }


        }

        async void Continue(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WebAuthenticatorPage(lang, translationRowKey));
            //await Shell.Current.GoToAsync("//Registration");
        }
    }
}