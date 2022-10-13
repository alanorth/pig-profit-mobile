using PigTool.Services;
using PigTool.Views;
using SQLLiteDbContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PigTool.ViewModels
{
    public class HomePageViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
        DateTime dateTime;

        public event PropertyChangedEventHandler PropertyChanged;

        //Navigation Commands
        public Command AddDataNavigation { get; }
        public Command ManageDataNavigation { get; }
        public Command ReportsNavigation { get; }

        //Translation Strings
        public string AddData { get; set; }
        public string EditData { get; set; }
        public string ViewReports { get; set; }
        public string Home { get; set; }

        //strings that can change
        string nameOfUser, villageOfUser, userLastUpdatedTime;
        int numberOfTranslations;

        public string NameOfUser
        {
            set
            {
                if (nameOfUser != value)
                {
                    nameOfUser = "Name: " + value;
                    OnPropertyChanged(nameof(NameOfUser));
                }
            }
            get
            {
                return nameOfUser;
            }
        }

        public string VillageOfUser
        {
            set
            {
                if (villageOfUser != value)
                {
                    villageOfUser = "Village: " + value;
                    OnPropertyChanged(nameof(VillageOfUser));
                }
            }
            get
            {
                return villageOfUser;
            }
        }

        public string UserLastUpdatedTime
        {
            set
            {
                if (userLastUpdatedTime != value)
                {
                    userLastUpdatedTime = "Last Data Update: " + value;
                    OnPropertyChanged("UserLastUpdatedTime");
                }
            }
            get
            {
                return userLastUpdatedTime;
            }
        }

        public int NumberOfTranslations
        {
            set
            {
                if (numberOfTranslations != value)
                {
                    numberOfTranslations = value;
                    OnPropertyChanged("NumberOfTranslations");
                }
            }
            get
            {
                return numberOfTranslations;
            }
        }

        private async void AddDataCommand(object obj)
        {
            try
            {
                await Shell.Current.GoToAsync("//AddDatePage");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public HomePageViewModel()
        {
            NameOfUser = User.UserName;
            VillageOfUser = User.Village;
            UserLastUpdatedTime = User.LastUploadDate.ToString();
            
            NumberOfTranslations = 60;
            //String translation
            AddData = repo.GetTranslationAsync(nameof(AddData)).Result.getTranslation(User.UserLang);
            EditData = repo.GetTranslationAsync(nameof(EditData)).Result.getTranslation(User.UserLang);
            ViewReports = repo.GetTranslationAsync(nameof(ViewReports)).Result.getTranslation(User.UserLang);
            Home = repo.GetTranslationAsync(nameof(Home)).Result.getTranslation(User.UserLang);
            //Button Commands
            AddDataNavigation = new Command(AddDataCommand);
            ManageDataNavigation = new Command(ManageDataCommand);

            DateTime = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                DateTime = DateTime.Now;
                return true;
            });
        }

        private async void ManageDataCommand(object obj)
        {
            try
            {
                await Shell.Current.GoToAsync("//ManageDataPage");
                //await Shell.Current.GoToAsync(nameof(ManageDataPage));
                //await Application.Current.MainPage.Navigation.PushModalAsync(new ManageDataPage());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public DateTime DateTime
        {
            set
            {
                if (dateTime != value)
                {
                    dateTime = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("DateTime"));
                    }
                }
            }
            get
            {
                return dateTime;
            }
        }


        public async Task GetTranslationCountAsync()
        {
            numberOfTranslations = await repo.getTranslationItemCount();
        }


        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
