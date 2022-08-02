using PigTool.Services;
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

        string nameOfUser, villageOfUser, userLastUpdatedTime;
        int numberOfTranslations;

        public string NameOfUser
        {
            set
            {
                if (nameOfUser != value)
                {
                    nameOfUser = "Name: " + value;
                    OnPropertyChanged("NameOfUser");
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
                    OnPropertyChanged("TitleOfUser");
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



        public HomePageViewModel()
        {
            repo = DependencyService.Get<IDataRepo>();
            var User = repo.GetUserInfoAsync().Result;
            NameOfUser = User.UserName;
            VillageOfUser = User.Village;
            UserLastUpdatedTime = User.LastUploadDate.ToString();
            NumberOfTranslations = 60;

            this.DateTime = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.DateTime = DateTime.Now;
                return true;
            });
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
            NameOfUser = "Luca Barsi";
            villageOfUser = "Enforcer";
        }


        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
