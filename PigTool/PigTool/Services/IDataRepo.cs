using Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PigTool.Services
{
    public interface IDataRepo
    {
        Task<List<Item>> GetAllItemsAsync();
        Task AddSingleItemAsync(Item itemToAdd);
        Task<Translation> GetTranslationAsync(string Rowkey);
        Task<MobileUser> GetUserInfoAsync();
        Task UpdateUserInfo(MobileUser userInfo);
        Task AddSingleUserInfo(MobileUser itemToAdd);
        void DeleteUserInfo(MobileUser UserItem);
        Task<int> getTranslationItemCount();
        Task<List<ControlData>> GetControlData(string dropDownOption);
        Task AddSingleControlData(ControlData cd);
        Task<List<Translation>> GetAllTranslations();

        // Feed Items
        Task AddSingleFeedItem(FeedItem itemToAdd);
        Task<List<FeedItem>> GetFeedItems();
        Task<List<FeedItem>> GetFeedItems(int selectedYear);
        Task<List<FeedItem>> GetFeedItemsAndAttachedTranslation(int selectedYear,UserLangSettings userLanguage);
        Task<FeedItem> GetFeedItem(string RowKey);
        Task UpdateFeedItem(FeedItem feedItem);
        void DeleteFeedItem(FeedItem feedItem);

        // Health Care
        Task<List<HealthCareItem>> GetHealthCareItems();
        Task<List<HealthCareItem>> GetHealthCareItems(int selectedYear, UserLangSettings userLanguage);
        Task<HealthCareItem> GetHealthCareItem(string RowKey);
        Task UpdateHealthCareItem(HealthCareItem Item);
        void DeleteHealthCareItem(HealthCareItem Item);
        Task AddSingleHealthCareItem(HealthCareItem itemToAdd);

        //Labour Costs
        Task<List<LabourCostItem>> GetLabourCostItems();
        Task<List<LabourCostItem>> GetLabourCostItems(int selectedYear, UserLangSettings userLanguage);
        Task<LabourCostItem> GetLabourCostItem(string RowKey);
        Task UpdateLabourCostItem(LabourCostItem Item);
        void DeleteLabourCostItem(LabourCostItem Item);
        Task AddSingleLabourCostItem(LabourCostItem itemToAdd);

        //Animal Housing
        Task<List<AnimalHouseItem>> GetAnimalHouseItems();
        Task<List<AnimalHouseItem>> GetAnimalHouseItems(int selectedYear, UserLangSettings userLanguage);
        Task<AnimalHouseItem> GetAnimalHouseItem(string RowKey);
        Task UpdateAnimalHouseItem(AnimalHouseItem Item);
        void DeleteAnimalHouseItem(AnimalHouseItem Item);
        Task AddSingleAnimalHouseItem(AnimalHouseItem itemToAdd);

        //Water Cost
        Task<List<WaterCostItem>> GetWaterCostItems();
        Task<List<WaterCostItem>> GetWaterCostItems(int selectedYear);
        Task<WaterCostItem> GetWaterCostItem(string RowKey);
        Task UpdateWaterCostItem(WaterCostItem Item);
        void DeleteWaterCostItem(WaterCostItem Item);
        Task AddSingleWaterCostItem(WaterCostItem itemToAdd);

        //Membership
        Task<List<MembershipItem>> GetMembershipItems();
        Task<List<MembershipItem>> GetMembershipItems(int selectedYear, UserLangSettings userLanguage);
        Task<MembershipItem> GetMembershipItem(string RowKey);
        Task UpdateMembershipItem(MembershipItem Item);
        void DeleteMembershipItem(MembershipItem Item);
        Task AddSingleMembershipItem(MembershipItem itemToAdd);

        //OtherCost
        Task<List<OtherCostItem>> GetOtherCostItems();
        Task<List<OtherCostItem>> GetOtherCostItems(int selectedYear);
        Task<OtherCostItem> GetOtherCostItem(string RowKey);
        Task UpdateOtherCostItem(OtherCostItem Item);
        void DeleteOtherCostItem(OtherCostItem Item);
        Task AddSingleOtherCostItem(OtherCostItem itemToAdd);

        //Reproductive
        Task<List<ReproductiveItem>> GetReproductiveItems();
        Task<List<ReproductiveItem>> GetReproductiveItems(int selectedYear, UserLangSettings userLanguage);
        Task<ReproductiveItem> GetReproductiveItem(string RowKey);
        Task UpdateReproductiveItem(ReproductiveItem Item);
        void DeleteReproductiveItem(ReproductiveItem Item);
        Task AddSingleReproductiveItem(ReproductiveItem itemToAdd);

        //Animal Purchase
        Task<List<AnimalPurchaseItem>> GetAnimalPurchaseItems();
        Task<List<AnimalPurchaseItem>> GetAnimalPurchaseItems(int selectedYear, UserLangSettings userLanguage);
        Task<AnimalPurchaseItem> GetAnimalPurchaseItem(string Rowkey);
        Task UpdateAnimalPurchaseItem(AnimalPurchaseItem Item);
        void DeleteAnimalPurchaseItem(AnimalPurchaseItem Item);
        Task AddSingleAnimalPurchaseItem(AnimalPurchaseItem itemToAdd);

        //Loan Repayment
        Task<List<LoanRepaymentItem>> GetLoanRepaymentItems();
        Task<List<LoanRepaymentItem>> GetLoanRepaymentItems(int selectedYear, UserLangSettings userLanguage);
        Task<LoanRepaymentItem> GetLoanRepaymentItem(string RowKey);
        Task UpdateLoanRepaymentItem(LoanRepaymentItem Item);
        void DeleteLoanRepaymentItem(LoanRepaymentItem Item);
        Task AddSingleLoanRepaymentItem(LoanRepaymentItem itemToAdd);

        //Equipment
        Task<List<EquipmentItem>> GetEquipmentItems();
        Task<List<EquipmentItem>> GetEquipmentItems(int selectedYear, UserLangSettings userLanguage);
        Task<EquipmentItem> GetEquipmentItem(string RowKey);
        Task UpdateEquipmentItem(EquipmentItem Item);
        void DeleteEquipmentItem(EquipmentItem Item);
        Task AddSingleEquipmentItem(EquipmentItem itemToAdd);

        //PigSale
        Task<List<PigSaleItem>> GetPigSaleItems();
        Task<List<PigSaleItem>> GetPigSaleItems(int selectedYear, UserLangSettings userLanguage);
        Task<PigSaleItem> GetPigSaleItem(string RowKey);
        Task UpdatePigSaleItem(PigSaleItem Item);
        void DeletePigSaleItem(PigSaleItem Item);
        Task AddSinglePigSaleItem(PigSaleItem itemToAdd);

        //BreedingServiceSale
        Task<List<BreedingServiceSaleItem>> GetBreedingServiceSaleItems();
        Task<List<BreedingServiceSaleItem>> GetBreedingServiceSaleItems(int selectedYear, UserLangSettings userLanguage);
        Task<BreedingServiceSaleItem> GetBreedingServiceSaleItem(string RowKey);
        Task UpdateBreedingServiceSaleItem(BreedingServiceSaleItem Item);
        void DeleteBreedingServiceSaleItem(BreedingServiceSaleItem Item);
        Task AddSingleBreedingServiceSaleItem(BreedingServiceSaleItem itemToAdd);

        //ManureSale
        Task<List<ManureSaleItem>> GetManureSaleItems();
        Task<List<ManureSaleItem>> GetManureSaleItems(int selectedYear, UserLangSettings userLanguage);
        Task<ManureSaleItem> GetManureSaleItem(string RowKey);
        Task UpdateManureSaleItem(ManureSaleItem Item);
        void DeleteManureSaleItem(ManureSaleItem Item);
        Task AddSingleManureSaleItem(ManureSaleItem itemToAdd);

        //OtherIncome
        Task<List<OtherIncomeItem>> GetOtherIncomeItems();
        Task<List<OtherIncomeItem>> GetOtherIncomeItems(int selectedYear);
        Task<OtherIncomeItem> GetOtherIncomeItem(string RowKey);
        Task UpdateOtherIncomeItem(OtherIncomeItem Item);
        void DeleteOtherIncomeItem(OtherIncomeItem Item);
        Task AddSingleOtherIncomeItem(OtherIncomeItem itemToAdd);
    }
}
