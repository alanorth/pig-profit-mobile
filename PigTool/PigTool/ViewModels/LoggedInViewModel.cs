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

        #region Translations Titles
        public string Costs { get; set; }
        public string Feed { get; set; }
        public string Healthcare { get; set; }
        public string Labour { get; set; }
        public string Housing { get; set; }
        public string Water { get; set; }
        public string Reproduction { get; set; }
        public string Membership { get; set; }
        public string Other { get; set; }
        public string AnimalPurchase { get; set; }
        public string LoanRepayment { get; set; }
        public string Equipment { get; set; }
        public string Income { get; set; }
        public string PigSale { get; set; }
        public string BreedingServiceSale { get; set; }
        public string ManureSale { get; set; }
        public string OtherIncome { get; set; }
        #endregion


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
                    Costs = LogicHelper.getTranslation(repo, nameof(Costs), User.UserLang).Result;
                    Feed = LogicHelper.getTranslation(repo, nameof(Feed), User.UserLang).Result;
                    Healthcare = LogicHelper.getTranslation(repo, nameof(Healthcare), User.UserLang).Result;
                    Labour = LogicHelper.getTranslation(repo, nameof(Labour), User.UserLang).Result;
                    Housing = LogicHelper.getTranslation(repo, nameof(Housing), User.UserLang).Result;
                    Water = LogicHelper.getTranslation(repo, nameof(Water), User.UserLang).Result;
                    Reproduction = LogicHelper.getTranslation(repo, nameof(Reproduction), User.UserLang).Result;
                    Membership = LogicHelper.getTranslation(repo, nameof(Membership), User.UserLang).Result;
                    Other = LogicHelper.getTranslation(repo, "OtherCostEvent", User.UserLang).Result;
                    AnimalPurchase = LogicHelper.getTranslation(repo, nameof(AnimalPurchase), User.UserLang).Result;
                    LoanRepayment = LogicHelper.getTranslation(repo, nameof(LoanRepayment), User.UserLang).Result;
                    Equipment = LogicHelper.getTranslation(repo, nameof(Equipment), User.UserLang).Result;
                    Income = LogicHelper.getTranslation(repo, nameof(Income), User.UserLang).Result;
                    PigSale = LogicHelper.getTranslation(repo, nameof(PigSale), User.UserLang).Result;
                    BreedingServiceSale = LogicHelper.getTranslation(repo, nameof(BreedingServiceSale), User.UserLang).Result;
                    ManureSale = LogicHelper.getTranslation(repo, nameof(ManureSale), User.UserLang).Result;
                    OtherIncome = LogicHelper.getTranslation(repo, nameof(OtherIncome), User.UserLang).Result;
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
