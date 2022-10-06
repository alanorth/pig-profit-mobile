using Shared;
using PigTool.Services;
using SQLLiteDbContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace PigTool.ViewModels
{
    public  class LoggedInViewModel
    {
        //public DbSQLLiteContext DataConext  => DependencyService.Get<DbSQLLiteContext>();

        public event PropertyChangedEventHandler PropertyChanged;

        public IDataRepo repo;
        public UserInfo User;
        public List<Translation> TranslationStore;

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        public LoggedInViewModel() {
            try { 
            repo = DependencyService.Get<IDataRepo>();
            //users Variables
            User = repo.GetUserInfoAsync().Result;

            TranslationStore = repo.GetAllTranslations().Result;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
