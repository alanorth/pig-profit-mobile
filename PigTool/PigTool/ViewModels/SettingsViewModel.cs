using Newtonsoft.Json;
using PigTool.Helpers;
using Shared;
using System.ComponentModel;

namespace PigTool.ViewModels
{
    public class SettingsViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        public string SettingsPageTranslation { get; private set; }
        public string ChangeProfileTranslation { get; private set; }
        public string LanguageTranslation { get; private set; }
        public string LogoutTranslation { get; private set; }
        public string ConfirmLogoutTranslation { get; private set; }
        public string LogoutWarningTransaltion { get; private set; }
        public string LogoutWarningTransaltion2 { get; private set; }
        public string ChangeLanguageTrasnlation { get; private set; }
        public string SureTranslation { get; private set; }
        public string AppRestartTranslation { get; private set; }
        public string YesTranslation { get; private set; }
        public string NoTranslation { get; private set; }
        public string AcceptTranslation { get; private set; }
        public string VersionTranslation { get; private set; }
        public string LegalDisclaimerTitleTranslation { get; private set; }

        public SettingsViewModel()
        {
            SettingsPageTranslation = LogicHelper.GetTranslationFromStore(TranslationStore,nameof(SettingsPageTranslation), User.UserLang);
            ChangeProfileTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ChangeProfileTranslation), User.UserLang);
            LanguageTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LanguageTranslation), User.UserLang);
            LogoutTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LogoutTranslation), User.UserLang);
            VersionTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(VersionTranslation), User.UserLang);
            LegalDisclaimerTitleTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LegalDisclaimerTitleTranslation), User.UserLang);
            ConfirmLogoutTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ConfirmLogoutTranslation), User.UserLang);
            LogoutWarningTransaltion = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LogoutWarningTransaltion), User.UserLang);
            LogoutWarningTransaltion2 = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(LogoutWarningTransaltion2), User.UserLang);
            ChangeLanguageTrasnlation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(ChangeLanguageTrasnlation), User.UserLang);
            SureTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(SureTranslation), User.UserLang);
            AppRestartTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(AppRestartTranslation), User.UserLang);
            YesTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(YesTranslation), User.UserLang);
            NoTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(NoTranslation), User.UserLang);
            AcceptTranslation = LogicHelper.GetTranslationFromStore(TranslationStore, nameof(AcceptTranslation), User.UserLang);
        }

        public string GetUserLanguage()
        {
            var lang = User.UserLang;
            var langName = "";
            switch (lang)
            {
                case UserLangSettings.Eng:
                    langName = "English";
                    break;
                case UserLangSettings.Lang1:
                    langName = "Luganda";
                    break;
                case UserLangSettings.Lang2:
                    langName = "Tiếng Việt";
                    break;
                case UserLangSettings.Lang3:
                    langName = "Kinyarwanda";
                    break;
                /*
                case UserLangSettings.Eng:
                    langName = "Kinyarwanda";
                    break;
                */
                default:
                    break;
            }

            return langName;
        }

        public async void ChangeUserLanguage(string language)
        {
            var user = User;

            switch (language)
            {
                case "English":
                    user.UserLang = UserLangSettings.Eng;
                    break;
                case "Luganda":
                    user.UserLang = UserLangSettings.Lang1;
                    break;
                case "Tiếng Việt":
                    user.UserLang = UserLangSettings.Lang2;
                    break;
                case "Kinyarwanda":
                    user.UserLang = UserLangSettings.Lang3;
                    break;
                default:
                    break;
            }
            await repo.UpdateUserInfo(user);
        }
    }
}
