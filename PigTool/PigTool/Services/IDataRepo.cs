using PigTool.Models;
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
        Task<int> getTranslationItemCount();
        Task<List<ControlData>> GetControlData(string dropDownOption);
        Task AddSingleControlData(ControlData cd);
        Task<List<Translation>> GetAllTranslations();
        Task AddSingleFeedItem(FeedItem itemToAdd);
        Task<List<FeedItem>> GetFeedItems();
        Task<FeedItem> GetFeedItem(int Id);
        Task UpdateFeedItem(FeedItem feedItem);
        void DeleteFeedItem(FeedItem feedItem);
        Task<List<HealthCareItem>> GetHealthCareItems();
        Task<HealthCareItem> GetHealthCareItem(int Id);
        Task UpdateHealthCareItem(HealthCareItem Item);
        void DeleteHealthCaredItem(HealthCareItem Item);
        Task AddSingleHealthCareItem(HealthCareItem itemToAdd);
        //Labour Costs
        Task<List<LabourCostItem>> GetLabourCostItems();
        Task<LabourCostItem> GetLabourCostItem(int Id);
        Task UpdateLabourCostItem(LabourCostItem Item);
        void DeleteLabourCostItem(LabourCostItem Item);
        Task AddSingleLabourCostItem(LabourCostItem itemToAdd);
    }
}
