using PigTool.Helpers;
using PigTool.Services;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace PigTool.ViewModels
{
    public class LoggedInViewModel
    {
        //public DbSQLLiteContext DataConext  => DependencyService.Get<DbSQLLiteContext>();

        public event PropertyChangedEventHandler PropertyChanged;

        public IDataRepo repo;
        public MobileUser User;
        public List<Translation> TranslationStore;
        public string DeleteConfirmation;
        public string OK;
        public string Cancel;
        public string DeleteVerify;
        public string Updated;
        public string Error;
        public string Created;


        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        public LoggedInViewModel()
        {
            try
            {
                repo = DependencyService.Get<IDataRepo>();
                //users Variables
                User = repo.GetUserInfoAsync().Result;

                if (TranslationStore == null)
                {
                    TranslationStore = repo.GetAllTranslations().Result;
                    DeleteConfirmation = LogicHelper.GetTranslationFromStore(TranslationStore, Constants.DeleteVerify, User.UserLang);
                    OK = LogicHelper.GetTranslationFromStore(TranslationStore, Constants.OK, User.UserLang);
                    Cancel = LogicHelper.GetTranslationFromStore(TranslationStore, Constants.Cancel, User.UserLang);
                    DeleteVerify = LogicHelper.GetTranslationFromStore(TranslationStore, Constants.DeleteVerify, User.UserLang);
                    Updated = LogicHelper.GetTranslationFromStore(TranslationStore, Constants.Updated, User.UserLang);
                    Error = LogicHelper.GetTranslationFromStore(TranslationStore, Constants.Error, User.UserLang);
                    Created = LogicHelper.GetTranslationFromStore(TranslationStore, Constants.Created, User.UserLang);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public async Task DisplaySavedMessage(string successMessage)
        {
            await Application.Current.MainPage.DisplayAlert(Created, successMessage, OK);  
        }

        public async Task DisplayUpdateMessage(string updateMessage)
        {
            await Application.Current.MainPage.DisplayAlert(Created, updateMessage, OK);
        }


        protected bool SetProperty<T>(ref T backingStore, T value,
           [CallerMemberName] string propertyName = "",
           Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }



        #region INotifyPropertyChanged
        // public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion



    }
}
