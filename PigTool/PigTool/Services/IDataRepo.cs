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
    }
}
