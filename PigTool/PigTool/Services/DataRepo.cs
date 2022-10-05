using Shared;
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

        public async Task<List<FeedItem>> GetFeedItemsAndAttachedTranslation(UserLangSettings userLanguage)
        {
            var feedItems =  await _context.FeedItems.Include("FeedTypeTranslation").ToListAsync();

            foreach (var feedItem in feedItems)
            {
                feedItem.FeedTypeTranslationString = feedItem.FeedTypeTranslation.getTranslation(userLanguage);
            }

            return feedItems;
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

        public async Task<List<HealthCareItem>> GetHealthCareItems()
        {
            return await _context.HealthCareItems.ToListAsync();
        }

        public async Task<HealthCareItem> GetHealthCareItem(int Id)
        {
            return await _context.HealthCareItems.SingleOrDefaultAsync(Item => Item.Id == Id);
        }

        public async Task UpdateHealthCareItem(HealthCareItem Item)
        {
            _context.Update(Item);
            await _context.SaveChangesAsync();
        }

        public void DeleteHealthCareItem(HealthCareItem Item)
        {
            _context.Remove(Item);
            _context.SaveChangesAsync();
        }

        public async Task AddSingleHealthCareItem(HealthCareItem itemToAdd)
        {
            if (_context.HealthCareItems.Any(fd => fd.Id == itemToAdd.Id)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<LabourCostItem> GetLabourCostItem(int Id)
        {
            return await _context.LabourCostItems.SingleOrDefaultAsync(Item => Item.Id == Id);
        }

        public async Task UpdateLabourCostItem(LabourCostItem Item)
        {
            _context.Update(Item);
            await _context.SaveChangesAsync();
        }

        public void DeleteLabourCostItem(LabourCostItem Item)
        {
            _context.Remove(Item);
            _context.SaveChangesAsync();
        }

        public async Task AddSingleLabourCostItem(LabourCostItem itemToAdd)
        {
            if (_context.LabourCostItems.Any(fd => fd.Id == itemToAdd.Id)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<LabourCostItem>> GetLabourCostItems()
        {
            return await _context.LabourCostItems.ToListAsync();
        }

        public async Task<List<AnimalHouseItem>> GetAnimalHouseItems()
        {
            return await _context.AnimalHouseItems.ToListAsync();
        }

        public async Task<AnimalHouseItem> GetAnimalHouseItem(int Id)
        {
            return await _context.AnimalHouseItems.SingleOrDefaultAsync(Item => Item.Id == Id);
        }

        public async Task UpdateAnimalHouseItem(AnimalHouseItem Item)
        {
            _context.Update(Item);
            await _context.SaveChangesAsync();
        }

        public void DeleteAnimalHouseItem(AnimalHouseItem Item)
        {
            _context.Remove(Item);
            _context.SaveChangesAsync();
        }

        public async Task AddSingleAnimalHouseItem(AnimalHouseItem itemToAdd)
        {
            if (_context.AnimalHouseItems.Any(fd => fd.Id == itemToAdd.Id)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<WaterCostItem>> GetWaterCostItems()
        {
            return await _context.WaterCostItems.ToListAsync();
        }

        public async Task<WaterCostItem> GetWaterCostItem(int Id)
        {
            return await _context.WaterCostItems.SingleOrDefaultAsync(Item => Item.Id == Id);
        }

        public async Task UpdateWaterCostItem(WaterCostItem Item)
        {
            _context.Update(Item);
            await _context.SaveChangesAsync();
        }

        public void DeleteWaterCostItem(WaterCostItem Item)
        {
            _context.Remove(Item);
            _context.SaveChangesAsync();
        }

        public async Task AddSingleWaterCostItem(WaterCostItem itemToAdd)
        {
            if (_context.WaterCostItems.Any(fd => fd.Id == itemToAdd.Id)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<MembershipItem>> GetMembershipItems()
        {
            return await _context.MembershipItems.ToListAsync();
        }

        public async Task<MembershipItem> GetMembershipItem(int Id)
        {
            return await _context.MembershipItems.SingleOrDefaultAsync(Item => Item.Id == Id);
        }

        public async Task UpdateMembershipItem(MembershipItem Item)
        {
            _context.Update(Item);
            await _context.SaveChangesAsync();
        }

        public void DeleteMembershipItem(MembershipItem Item)
        {
            _context.Remove(Item);
            _context.SaveChangesAsync();
        }

        public async Task AddSingleMembershipItem(MembershipItem itemToAdd)
        {
            if (_context.MembershipItems.Any(fd => fd.Id == itemToAdd.Id)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<OtherCostItem>> GetOtherCostItems()
        {
            return await _context.OtherCostItems.ToListAsync();
        }

        public async Task<OtherCostItem> GetOtherCostItem(int Id)
        {
            return await _context.OtherCostItems.SingleOrDefaultAsync(Item => Item.Id == Id);
        }

        public async Task UpdateOtherCostItem(OtherCostItem Item)
        {
            _context.Update(Item);
            await _context.SaveChangesAsync();
        }

        public void DeleteOtherCostItem(OtherCostItem Item)
        {
            _context.Remove(Item);
            _context.SaveChangesAsync();
        }

        public async Task AddSingleOtherCostItem(OtherCostItem itemToAdd)
        {
            if (_context.OtherCostItems.Any(fd => fd.Id == itemToAdd.Id)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ReproductiveItem>> GetReproductiveItems()
        {
            return await _context.ReproductiveItems.ToListAsync();
        }

        public async Task<ReproductiveItem> GetReproductiveItem(int Id)
        {
            return await _context.ReproductiveItems.SingleOrDefaultAsync(Item => Item.Id == Id);
        }

        public async Task UpdateReproductiveItem(ReproductiveItem Item)
        {
            _context.Update(Item);
            await _context.SaveChangesAsync();
        }

        public void DeleteReproductiveItem(ReproductiveItem Item)
        {
            _context.Remove(Item);
            _context.SaveChangesAsync();
        }

        public async Task AddSingleReproductiveItem(ReproductiveItem itemToAdd)
        {
            if (_context.ReproductiveItems.Any(fd => fd.Id == itemToAdd.Id)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<AnimalPurchaseItem>> GetAnimalPurchaseItems()
        {
            return await _context.AnimalPurchaseItems.ToListAsync();
        }

        public async Task<AnimalPurchaseItem> GetAnimalPurchaseItem(int Id)
        {
            return await _context.AnimalPurchaseItems.SingleOrDefaultAsync(Item => Item.Id == Id);
        }

        public async Task UpdateAnimalPurchaseItem(AnimalPurchaseItem Item)
        {
            _context.Update(Item);
            await _context.SaveChangesAsync();
        }

        public void DeleteAnimalPurchaseItem(AnimalPurchaseItem Item)
        {
            _context.Remove(Item);
            _context.SaveChangesAsync();
        }

        public async Task AddSingleAnimalPurchaseItem(AnimalPurchaseItem itemToAdd)
        {
            if (_context.AnimalPurchaseItems.Any(fd => fd.Id == itemToAdd.Id)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }
    }
}
