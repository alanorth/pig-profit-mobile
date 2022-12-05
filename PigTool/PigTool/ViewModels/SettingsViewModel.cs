using Shared;
using System.ComponentModel;

namespace PigTool.ViewModels
{
    public class SettingsViewModel : LoggedInViewModel, INotifyPropertyChanged
    {

        public SettingsViewModel()
        {


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
