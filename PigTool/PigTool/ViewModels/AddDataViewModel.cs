using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using PigTool.Helpers;
using PigTool.Views;
using Xamarin.Forms;

namespace PigTool.ViewModels
{
    public class AddDataViewModel : LoggedInViewModel, INotifyPropertyChanged
    {
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
        public string Saleofbreedingservices { get; set; }
        public string Saleofmaure { get; set; }
        public string OtherIncome { get; set; }
        #endregion

        public Command AddFeedItem { get; }
        public Command AddHealthCareItem { get; }
        public Command AddLabourCostItem { get; }
        public Command AddHousingItem { get; }
        public Command AddWaterCostItem { get; }
        public Command AddMembershipItem { get; }
        public Command AddOtherCostItem { get; }
        public Command AddReproductiveItem { get; }
        public Command AddAnimalPurchaseItem { get; }
        public Command AddLoanRepaymentItem { get; }
        public Command AddEquipmentItem { get; }

        public Command AddPigSaleItem { get; }

        public AddDataViewModel()
        {

            AddFeedItem = (new Command(AddFeedItemDataCommand));
            AddHealthCareItem = (new Command(AddHealthCareItemDataCommand));
            AddLabourCostItem = (new Command(AddLabourCostItemCommand));
            AddHousingItem = (new Command(AddHousingItemCommand));
            AddWaterCostItem = (new Command(AddWaterCostItemCommand));
            AddMembershipItem = (new Command(AddMembershipItemCommand));
            AddOtherCostItem = (new Command(AddOtherCostItemCommand));
            AddReproductiveItem = (new Command(AddReproductiveItemCommand));
            AddAnimalPurchaseItem = (new Command(AddAnimalPurchaseItemCommand));
            AddLoanRepaymentItem = (new Command(AddLoanRepaymentItemCommand));
            AddEquipmentItem = (new Command(AddEquipmentItemCommand));

            AddPigSaleItem = (new Command(AddPigSaleItemCommand));

            Costs = LogicHelper.getTranslation(repo, nameof(Costs), User.UserLang).Result;
            Feed = LogicHelper.getTranslation(repo, nameof(Feed), User.UserLang).Result;
            Healthcare = LogicHelper.getTranslation(repo, nameof(Healthcare), User.UserLang).Result;
            Labour = LogicHelper.getTranslation(repo, nameof(Labour), User.UserLang).Result;
            Housing = LogicHelper.getTranslation(repo, nameof(Housing), User.UserLang).Result;
            Water = LogicHelper.getTranslation(repo, nameof(Water), User.UserLang).Result;
            Reproduction = LogicHelper.getTranslation(repo, nameof(Reproduction), User.UserLang).Result;
            Membership = LogicHelper.getTranslation(repo, nameof(Membership), User.UserLang).Result;
            Other = LogicHelper.getTranslation(repo, nameof(Other), User.UserLang).Result;
            AnimalPurchase = LogicHelper.getTranslation(repo, nameof(AnimalPurchase), User.UserLang).Result;
            LoanRepayment = LogicHelper.getTranslation(repo, nameof(LoanRepayment), User.UserLang).Result;
            Equipment = LogicHelper.getTranslation(repo, nameof(Equipment), User.UserLang).Result;
            Income = LogicHelper.getTranslation(repo, nameof(Income), User.UserLang).Result;
            PigSale = LogicHelper.getTranslation(repo, nameof(PigSale), User.UserLang).Result;
            Saleofbreedingservices = LogicHelper.getTranslation(repo, nameof(Saleofbreedingservices), User.UserLang).Result;
            Saleofmaure = LogicHelper.getTranslation(repo, nameof(Saleofmaure), User.UserLang).Result;
            OtherIncome = LogicHelper.getTranslation(repo, nameof(OtherIncome), User.UserLang).Result;

        }

        private async void AddFeedItemDataCommand(object obj)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new FeedItemPage());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void AddHealthCareItemDataCommand(object obj)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new HealthCarePage());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void AddLabourCostItemCommand(object obj)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new LabourCostPage());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void AddHousingItemCommand(object obj)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new AnimalHousingPage());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        private async void AddWaterCostItemCommand(object obj)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new WaterCostPage());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void AddMembershipItemCommand(object obj)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new MembershipPage());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void AddOtherCostItemCommand(object obj)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new OtherCostPage());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void AddReproductiveItemCommand(object obj)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new ReproductivePage());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void AddAnimalPurchaseItemCommand(object obj)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new AnimalPurchasePage());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void AddLoanRepaymentItemCommand(object obj)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new LoanRepaymentPage());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void AddEquipmentItemCommand(object obj)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new EquipmentPage());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private async void AddPigSaleItemCommand(object obj)
        {
            try
            {
                await Application.Current.MainPage.Navigation.PushAsync(new PigSalePage());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
