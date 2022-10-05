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
        Task<UserInfo> GetUserInfoAsync();
        Task UpdateUserInfo(UserInfo userInfo);
        Task<int> getTranslationItemCount();
        Task<List<ControlData>> GetControlData(string dropDownOption);
        Task AddSingleControlData(ControlData cd);
        Task<List<Translation>> GetAllTranslations();

        // Feed Items
        Task AddSingleFeedItem(FeedItem itemToAdd);
        Task<List<FeedItem>> GetFeedItems();
        Task<List<FeedItem>> GetFeedItemsAndAttachedTranslation(UserLangSettings userLanguage);
        Task<FeedItem> GetFeedItem(int Id);
        Task UpdateFeedItem(FeedItem feedItem);
        void DeleteFeedItem(FeedItem feedItem);

        // Health Care
        Task<List<HealthCareItem>> GetHealthCareItems();
        Task<HealthCareItem> GetHealthCareItem(int Id);
        Task UpdateHealthCareItem(HealthCareItem Item);
        void DeleteHealthCareItem(HealthCareItem Item);
        Task AddSingleHealthCareItem(HealthCareItem itemToAdd);

        //Labour Costs
        Task<List<LabourCostItem>> GetLabourCostItems();
        Task<LabourCostItem> GetLabourCostItem(int Id);
        Task UpdateLabourCostItem(LabourCostItem Item);
        void DeleteLabourCostItem(LabourCostItem Item);
        Task AddSingleLabourCostItem(LabourCostItem itemToAdd);

        //Animal Housing
        Task<List<AnimalHouseItem>> GetAnimalHouseItems();
        Task<AnimalHouseItem> GetAnimalHouseItem(int Id);
        Task UpdateAnimalHouseItem(AnimalHouseItem Item);
        void DeleteAnimalHouseItem(AnimalHouseItem Item);
        Task AddSingleAnimalHouseItem(AnimalHouseItem itemToAdd);

        //Water Cost
        Task<List<WaterCostItem>> GetWaterCostItems();
        Task<WaterCostItem> GetWaterCostItem(int Id);
        Task UpdateWaterCostItem(WaterCostItem Item);
        void DeleteWaterCostItem(WaterCostItem Item);
        Task AddSingleWaterCostItem(WaterCostItem itemToAdd);

        //Membership
        Task<List<MembershipItem>> GetMembershipItems();
        Task<MembershipItem> GetMembershipItem(int Id);
        Task UpdateMembershipItem(MembershipItem Item);
        void DeleteMembershipItem(MembershipItem Item);
        Task AddSingleMembershipItem(MembershipItem itemToAdd);

        //OtherCost
        Task<List<OtherCostItem>> GetOtherCostItems();
        Task<OtherCostItem> GetOtherCostItem(int Id);
        Task UpdateOtherCostItem(OtherCostItem Item);
        void DeleteOtherCostItem(OtherCostItem Item);
        Task AddSingleOtherCostItem(OtherCostItem itemToAdd);

        //Reproductive
        Task<List<ReproductiveItem>> GetReproductiveItems();
        Task<ReproductiveItem> GetReproductiveItem(int Id);
        Task UpdateReproductiveItem(ReproductiveItem Item);
        void DeleteReproductiveItem(ReproductiveItem Item);
        Task AddSingleReproductiveItem(ReproductiveItem itemToAdd);

        //Animal Purchase
        Task<List<AnimalPurchaseItem>> GetAnimalPurchaseItems();
        Task<AnimalPurchaseItem> GetAnimalPurchaseItem(int Id);
        Task UpdateAnimalPurchaseItem(AnimalPurchaseItem Item);
        void DeleteAnimalPurchaseItem(AnimalPurchaseItem Item);
        Task AddSingleAnimalPurchaseItem(AnimalPurchaseItem itemToAdd);
    }
}
