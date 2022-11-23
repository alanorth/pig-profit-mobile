using Microsoft.EntityFrameworkCore;
using PigTool.Services;
using PigTool.Views;
using Shared;
using SQLLiteDbContext;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public Command PopulateDB { get; }

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
            PopulateDB = new Command(PopulateDBCommand);

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



        private async void PopulateDBCommand(object obj)
        {
            Random random = new Random();
            DateTime start = new DateTime(2020, 1, 1);
            int range = (DateTime.Today - start).Days;
           
            try
            {
                // Feed Items 
                
                for (int i = 0; i < 20; i++)
                {
                    var newFeedItem = new FeedItem
                    {
                        Date = start.AddDays(random.Next(range)),
                        FeedType = "DropDownFeedType3",
                        TotalCosts = Math.Round(random.NextDouble() * (2000 - 0) + 0, 2),
                        TransportationCost = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        LastModified = DateTime.UtcNow,
                        CreatedBy = User.UserName,
                        PartitionKey = Constants.PartitionKeyFeed,
                    };
                    await repo.AddSingleFeedItem(newFeedItem);
                } 
                // HealthCare
                for (int i = 0; i < 20; i++)
                {
                    var newHealthCare = new HealthCareItem
                    {
                        Date = start.AddDays(random.Next(range)),
                        HealthCareType = "HealthCareType2",
                        HealthCareCost = Math.Round(random.NextDouble() * (2000 - 0) + 0, 2),
                        TransportationCost = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        OtherCosts = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        LastModified = DateTime.UtcNow,
                        CreatedBy = User.UserName,
                        PartitionKey = Constants.PartitionKeyHealthCareItem,
                    };
                    await repo.AddSingleHealthCareItem(newHealthCare);
                }
                // Labour
                for (int i = 0; i < 20; i++)
                {
                    var newLabourCost = new LabourCostItem
                    {
                        Date = start.AddDays(random.Next(range)),
                        LabourType = "LabourCostType2",
                        AmountPaid = Math.Round(random.NextDouble() * (2000 - 0) + 0, 2),
                        OtherCost = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        LastModified = DateTime.UtcNow,
                        CreatedBy = User.UserName,
                        PartitionKey = Constants.PartitionKeyEquipmentItem,
                    };
                    await repo.AddSingleLabourCostItem(newLabourCost);
                }

                
                // AnimalHousing
                for (int i = 0; i < 20; i++)
                {
                    var newAnimalHousing = new AnimalHouseItem
                    {
                        Date = start.AddDays(random.Next(range)),
                        HousingExpense = "HousingExpenseType2",
                        TotalCosts = Math.Round(random.NextDouble() * (2000 - 0) + 0, 2),
                        TransportationCost = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        OtherCosts = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        LastModified = DateTime.UtcNow,
                        CreatedBy = User.UserName,
                        PartitionKey = Constants.PartitionKeyAnimalHouse,
                    };
                    await repo.AddSingleAnimalHouseItem(newAnimalHousing);
                }
                // WaterCost
                for (int i = 0; i < 20; i++)
                {
                    var newWaterCost = new WaterCostItem
                    {
                        Date = start.AddDays(random.Next(range)),
                        WaterPurchased = Math.Round(random.NextDouble() * (300 - 0) + 0, 2),
                        TotalCosts = Math.Round(random.NextDouble() * (1000 - 0) + 0, 2),
                        TransportationCost = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        OtherCosts = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        LastModified = DateTime.UtcNow,
                        CreatedBy = User.UserName,
                        PartitionKey = Constants.PartitionKeyWaterCostItem,
                    };
                    await repo.AddSingleWaterCostItem(newWaterCost);
                }
                // Membership
                for (int i = 0; i < 20; i++)
                {
                    var newMembership = new MembershipItem
                    {
                        Date = start.AddDays(random.Next(range)),
                        MembershipType = "MembershipType2",
                        TotalCosts = Math.Round(random.NextDouble() * (2000 - 0) + 0, 2),
                        OtherCosts = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        LastModified = DateTime.UtcNow,
                        CreatedBy = User.UserName,
                        PartitionKey = Constants.PartitionKeyMembershipItem,
                    };
                    await repo.AddSingleMembershipItem(newMembership);
                }
                // OtherCost
                for (int i = 0; i < 20; i++)
                {
                    var newOtherCost = new OtherCostItem
                    {
                        Date = start.AddDays(random.Next(range)),
                        TotalCosts = Math.Round(random.NextDouble() * (2000 - 0) + 0, 2),
                        TransportationCosts = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        OtherCosts = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        LastModified = DateTime.UtcNow,
                        CreatedBy = User.UserName,
                        PartitionKey = Constants.PartitionKeyOtherCostItem,
                    };
                    await repo.AddSingleOtherCostItem(newOtherCost);
                }
                // Reproductive
                for (int i = 0; i < 20; i++)
                {
                    var newReproductive = new ReproductiveItem
                    {
                        Date = start.AddDays(random.Next(range)),
                        ServiceType = "ReproductiveType2",
                        SowsServiced = random.Next() * (200 - 0) + 0,
                        OtherCosts = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        LastModified = DateTime.UtcNow,
                        CreatedBy = User.UserName,
                        PartitionKey = Constants.PartitionKeyReproductiveItem,
                    };
                    await repo.AddSingleReproductiveItem(newReproductive);
                }
                // AnimalPurchase
                for (int i = 0; i < 20; i++)
                {
                    var newAnimalPurchase = new AnimalPurchaseItem
                    {
                        Date = start.AddDays(random.Next(range)),
                        AnimalType = "AnimalType2",
                        TotalCosts = Math.Round(random.NextDouble() * (2000 - 0) + 0, 2),
                        TransportationCost = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        OtherCosts = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        LastModified = DateTime.UtcNow,
                        CreatedBy = User.UserName,
                        PartitionKey = Constants.PartitionKeyAnimalPurchaseItem,
                    };
                    await repo.AddSingleAnimalPurchaseItem(newAnimalPurchase);
                }
                // LoanRepayment
                for (int i = 0; i < 20; i++)
                {
                    var newLoanRepayment = new LoanRepaymentItem
                    {
                        Date = start.AddDays(random.Next(range)),
                        LoanProvider = "LoanProviderType2",
                        TotalAmountRepaid = Math.Round(random.NextDouble() * (2000 - 0) + 0, 2),
                        OtherCosts = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        LastModified = DateTime.UtcNow,
                        CreatedBy = User.UserName,
                        PartitionKey = Constants.PartitionKeyLoanRepaymentItem,
                    };
                    await repo.AddSingleLoanRepaymentItem(newLoanRepayment);
                }
                
                // Equipment
                for (int i = 0; i < 20; i++)
                {
                    var newEquipment = new EquipmentItem
                    {
                        Date = start.AddDays(random.Next(range)),
                        EquipmentType = "EquipmentType2",
                        TotalCosts = Math.Round(random.NextDouble() * (2000 - 0) + 0, 2),
                        TransportationCost = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        OtherCosts = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        LastModified = DateTime.UtcNow,
                        CreatedBy = User.UserName,
                        PartitionKey = Constants.PartitionKeyEquipmentItem,
                    };
                    await repo.AddSingleEquipmentItem(newEquipment);
                }

                // PigSale
                for (int i = 0; i < 20; i++)
                {
                    var newPigSale = new PigSaleItem
                    {
                        Date = start.AddDays(random.Next(range)),
                        PigType = "PigType2",
                        SalePrice = Math.Round(random.NextDouble() * (2000 - 0) + 0, 2),
                        Brokerage = Math.Round(random.NextDouble() * (500 - 0) + 0, 2),
                        TransportationCost = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        OtherCosts = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        LastModified = DateTime.UtcNow,
                        CreatedBy = User.UserName,
                        PartitionKey = Constants.PartitionKeyPigSaleItem,
                    };
                    await repo.AddSinglePigSaleItem(newPigSale);
                }

                // BreedingServiceSale
                for (int i = 0; i < 20; i++)
                {
                    var newBreedingServiceSale = new BreedingServiceSaleItem
                    {
                        Date = start.AddDays(random.Next(range)),
                        ServiceType = "ServiceType2",
                        AmountRecieved = Math.Round(random.NextDouble() * (2000 - 0) + 0, 2),
                        PaymentValue = Math.Round(random.NextDouble() * (2000 - 0) + 0, 2),
                        TransportationCost = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        OtherCosts = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        LastModified = DateTime.UtcNow,
                        CreatedBy = User.UserName,
                        PartitionKey = Constants.PartitionKeyBreedingServiceSaleItem,
                    };
                    await repo.AddSingleBreedingServiceSaleItem(newBreedingServiceSale);
                }

                // ManureSale
                for (int i = 0; i < 20; i++)
                {
                    var newManureSale = new ManureSaleItem
                    {
                        Date = start.AddDays(random.Next(range)),
                        AmountRecieved = Math.Round(random.NextDouble() * (2000 - 0) + 0, 2),
                        PaymentValue = Math.Round(random.NextDouble() * (2000 - 0) + 0, 2),
                        TransportationCost = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        OtherCosts = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        LastModified = DateTime.UtcNow,
                        CreatedBy = User.UserName,
                        PartitionKey = Constants.PartitionKeyManureSaleItem,
                    };
                    await repo.AddSingleManureSaleItem(newManureSale);
                }

                // OtherIncome
                for (int i = 0; i < 20; i++)
                {
                    var newOtherIncome = new OtherIncomeItem
                    {
                        Date = start.AddDays(random.Next(range)),
                        
                        TotalIncome = Math.Round(random.NextDouble() * (2000 - 0) + 0, 2),
                        TransportationCosts = Math.Round(random.NextDouble() * (100 - 0) + 0, 2),
                        OtherCosts = Math.Round(random.NextDouble() * (200 - 0) + 0, 2),
                        LastModified = DateTime.UtcNow,
                        CreatedBy = User.UserName,
                        PartitionKey = Constants.PartitionKeyOtherIncomeItem,
                    };
                    await repo.AddSingleOtherIncomeItem(newOtherIncome);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
