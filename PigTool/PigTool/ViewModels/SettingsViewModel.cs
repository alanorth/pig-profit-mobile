using Shared;
using System.ComponentModel;

namespace PigTool.ViewModels
{
    public class SettingsViewModel : LoggedInViewModel, INotifyPropertyChanged
    {

        public SettingsViewModel()
        {


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
                    langName = "Swahili";
                    break;
                case UserLangSettings.Lang2:
                    langName = "Vietnamese";
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
                case "Swahili":
                    user.UserLang = UserLangSettings.Lang1;
                    break;
                case "Vietnamese":
                    user.UserLang = UserLangSettings.Lang2;
                    break;
                case "Kinyarwanda":
                    user.UserLang = UserLangSettings.Eng;
                    break;
                default:
                    break;
            }
            await repo.UpdateUserInfo(user);
        }
    }
}
