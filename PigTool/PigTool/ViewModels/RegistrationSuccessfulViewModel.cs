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
    public class RegistrationSuccessfulViewModel : LoggedInViewModel
    {
        public string RegistrationSuccessfulTitleTranslation { get; set; }
        public string RegistrationSuccessfulDescTranslation { get; set; }
        public string RegistrationSuccessfulContinueTranslation { get; set; }

        public RegistrationSuccessfulViewModel()
        {
            RegistrationSuccessfulTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(RegistrationSuccessfulTitleTranslation), User.UserLang);
            RegistrationSuccessfulDescTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(RegistrationSuccessfulDescTranslation), User.UserLang);
            RegistrationSuccessfulContinueTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(RegistrationSuccessfulContinueTranslation), User.UserLang);
        }
    }
}
