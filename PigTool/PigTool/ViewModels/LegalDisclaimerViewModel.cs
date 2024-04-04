using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        UserLangSettings lang;

        public Command ProceedClicked { get; }

        public string LegalDisclaimerTitleTranslation { get; set; }
        public string TermsAndConditionsTranslation { get; set; }
        public string LegalDisclaimerBodyTranslation { get; set; }
        public string LegalDisclaimerAgreeTranslation { get; set; }
        public string LegalDisclaimerProceedTranslation { get; set; }
        public string PP1 { get; set; }
        public string PP2 { get; set; }
        public string PP3 { get; set; }
        public string PP4 { get; set; }
        public string PP5 { get; set; }
        public string PP6 { get; set; }
        public string PP7 { get; set; }
        public string PP8 { get; set; }
        public string PP9 { get; set; }
        public string PP10 { get; set; }
        public string PP11 { get; set; }
        public string PP12 { get; set; }
        public string PP13 { get; set; }
        public string PP14 { get; set; }
        public string PP15 { get; set; }
        public string PP16 { get; set; }
        public string PP17 { get; set; }
        public string PP18 { get; set; }
        public string PP19 { get; set; }
        public string PP20 { get; set; }
        public string PP21 { get; set; }
        public string PP22 { get; set; }
        public string PP23 { get; set; }
        public string PP24 { get; set; }
        public string PP25 { get; set; }
        public string PP26 { get; set; }
        public string PP27 { get; set; }
        public string PP28 { get; set; }
        public string PP29 { get; set; }
        public string PP30 { get; set; }
        public string PP31 { get; set; }
        public string PP32 { get; set; }
        public string PP33 { get; set; }


        public LegalDisclaimerViewModel(INavigation Nav, UserLangSettings lang)
        {
            _Nav = Nav;
            this.lang = lang;
            ButtonEnable = false;
            LegalDisclaimerTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LegalDisclaimerTitleTranslation), lang);
            LegalDisclaimerBodyTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LegalDisclaimerBodyTranslation), lang);
            LegalDisclaimerAgreeTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LegalDisclaimerAgreeTranslation), lang);
            LegalDisclaimerProceedTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LegalDisclaimerProceedTranslation), lang);
            TermsAndConditionsTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, "TermsAndCondtions", lang);
            PP1 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP1), lang);
            PP2 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP2), lang);
            PP3 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP3), lang);
            PP4 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP4), lang);
            PP5 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP5), lang);
            PP6 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP6), lang);
            PP7 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP7), lang);
            PP8 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP8), lang);
            PP9 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP9), lang);
            PP10 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP10), lang);
            PP11 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP11), lang);
            PP12 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP12), lang);
            PP13 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP13), lang);
            PP14 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP14), lang);
            PP15 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP15), lang);
            PP16 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP16), lang);
            PP17 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP17), lang);
            PP18 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP18), lang);
            PP19 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP19), lang);
            PP20 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP20), lang);
            PP21 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP21), lang);
            PP22 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP22), lang);
            PP23 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP23), lang);
            PP24 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP24), lang);
            PP25 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP25), lang);
            PP26 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP26), lang);
            PP27 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP27), lang);
            PP28 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP28), lang);
            PP29 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP29), lang);
            PP30 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP30), lang);
            PP31 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP31), lang);
            PP32 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP32), lang);
            PP33 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(PP33), lang);

        }
        public void DisclaimerAcknowlegde()
        {
            ButtonEnable = !ButtonEnable;
        }
    }
}
