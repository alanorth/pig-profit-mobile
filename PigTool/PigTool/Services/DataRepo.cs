using PigTool.Models;
using SQLLiteDbContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PigTool.Services
{
    public class DataRepo : IDataRepo
    {
        public DbSQLLiteContext _context { get; }

        public DataRepo()
        {
            _context = new DbSQLLiteContext();
        }

        public Task AddSingleItemAsync(Item itemToAdd)
        {
            _context.AddAsync(itemToAdd);

            _context.SaveChanges();

            return Task.CompletedTask;
        }

        public async Task<List<Item>> GetAllItemsAsync()
        {
            return await _context.Items.ToListAsync();
        }

        public async Task<int> getTranslationItemCount()
        {
            return await _context.Translations.CountAsync();
        }

        public async Task<Translation> GetTranslationAsync(string Rowkey)
        {
            return await _context.Translations.SingleOrDefaultAsync(a => a.RowKey == Rowkey);
        }

        public Task<UserInfo> GetUserInfoAsync()
        {
            return _context.UserInfos.FirstAsync();
        }

        public async Task<List<ControlData>> GetControlData(string dropDownOption)
        {
           return await _context.ControlDataOptions.Where(x => x.DropDownControlOption == dropDownOption).Include(cd => cd.Translation).ToListAsync();
        }

        public async Task AddSingleControlData(ControlData cd)
        {
            await _context.AddAsync(cd);

            await _context.SaveChangesAsync();
        }

        public async Task<List<Translation>> GetAllTranslations()
        {
           return await _context.Translations.ToListAsync();
        }

        public async Task AddSingleFeedItem(FeedItem itemToAdd)
        {
            if (_context.FeedItems.Any(fd => fd.Id == itemToAdd.Id)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<FeedItem>> GetFeedItems()
        {
            return await _context.FeedItems.ToListAsync();
        }

        public async Task<FeedItem> GetFeedItem(int Id)
        {
           return await _context.FeedItems.SingleOrDefaultAsync(feedItem => feedItem.Id == Id);
        }

        public async Task UpdateFeedItem(FeedItem feedItem)
        {
            _context.Update(feedItem);
            await _context.SaveChangesAsync();
        }

        public void DeleteFeedItem(FeedItem feedItem)
        {
            _context.Remove(feedItem);
            _context.SaveChangesAsync();
        }
    }
}
