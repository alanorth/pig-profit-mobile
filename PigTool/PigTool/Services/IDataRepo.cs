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
        Task<FeedItem> GetFeedItem(string RowKey);
        Task UpdateFeedItem(FeedItem feedItem);
        void DeleteFeedItem(FeedItem feedItem);

        // Health Care
        Task<List<HealthCareItem>> GetHealthCareItems();
        Task<HealthCareItem> GetHealthCareItem(string RowKey);
        Task UpdateHealthCareItem(HealthCareItem Item);
        void DeleteHealthCareItem(HealthCareItem Item);
        Task AddSingleHealthCareItem(HealthCareItem itemToAdd);

        //Labour Costs
        Task<List<LabourCostItem>> GetLabourCostItems();
        Task<LabourCostItem> GetLabourCostItem(string RowKey);
        Task UpdateLabourCostItem(LabourCostItem Item);
        void DeleteLabourCostItem(LabourCostItem Item);
        Task AddSingleLabourCostItem(LabourCostItem itemToAdd);

        //Animal Housing
        Task<List<AnimalHouseItem>> GetAnimalHouseItems();
        Task<AnimalHouseItem> GetAnimalHouseItem(string RowKey);
        Task UpdateAnimalHouseItem(AnimalHouseItem Item);
        void DeleteAnimalHouseItem(AnimalHouseItem Item);
        Task AddSingleAnimalHouseItem(AnimalHouseItem itemToAdd);

        //Water Cost
        Task<List<WaterCostItem>> GetWaterCostItems();
        Task<WaterCostItem> GetWaterCostItem(string RowKey);
        Task UpdateWaterCostItem(WaterCostItem Item);
        void DeleteWaterCostItem(WaterCostItem Item);
        Task AddSingleWaterCostItem(WaterCostItem itemToAdd);

        //Membership
        Task<List<MembershipItem>> GetMembershipItems();
        Task<MembershipItem> GetMembershipItem(string RowKey);
        Task UpdateMembershipItem(MembershipItem Item);
        void DeleteMembershipItem(MembershipItem Item);
        Task AddSingleMembershipItem(MembershipItem itemToAdd);

        //OtherCost
        Task<List<OtherCostItem>> GetOtherCostItems();
        Task<OtherCostItem> GetOtherCostItem(string RowKey);
        Task UpdateOtherCostItem(OtherCostItem Item);
        void DeleteOtherCostItem(OtherCostItem Item);
        Task AddSingleOtherCostItem(OtherCostItem itemToAdd);

        //OtherCost
        Task<List<ReproductiveItem>> GetReproductiveItems();
        Task<ReproductiveItem> GetReproductiveItem(string RowKey);
        Task UpdateReproductiveItem(ReproductiveItem Item);
        void DeleteReproductiveItem(ReproductiveItem Item);
        Task AddSingleReproductiveItem(ReproductiveItem itemToAdd);
    }
}
