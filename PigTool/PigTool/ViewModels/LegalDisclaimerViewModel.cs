using PigTool.Helpers;
using PigTool.Views;
using Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PigTool.ViewModels
{
    public class LegalDisclaimerViewModel : LoggedOutViewModel
    {
        INavigation _Nav;
        public bool ButtonEnable { get; set; }

        public Command ProceedClicked { get; }

        public string LegalDisclaimerTitleTranslation { get; set; }
        public string LegalDisclaimerBodyTranslation { get; set; }
        public string LegalDisclaimerAgreeTranslation { get; set; }
        public string LegalDisclaimerProceedTranslation { get; set; }

        public LegalDisclaimerViewModel(INavigation Nav, UserLangSettings lang)
        {
            _Nav = Nav;
            ButtonEnable = false;
            ProceedClicked = new Command(ProceedClickAsync);
            LegalDisclaimerTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LegalDisclaimerTitleTranslation), lang);
            LegalDisclaimerBodyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LegalDisclaimerBodyTranslation), lang);
            LegalDisclaimerAgreeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LegalDisclaimerAgreeTranslation), lang);
            LegalDisclaimerProceedTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LegalDisclaimerProceedTranslation), lang);
        }
        public void DisclaimerAcknowlegde()
        {
            ButtonEnable = !ButtonEnable;
        }

        private void ProceedClickAsync()
        {
            if (ButtonEnable)
            {
                //_Nav.PushAsync(new WebAuthenticatorPage());   
            }
        }
    }
}
