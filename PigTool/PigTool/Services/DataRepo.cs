using Microsoft.EntityFrameworkCore;
using Shared;
using SQLLiteDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return _context.UserInfos.FirstOrDefaultAsync();
        }

        public Task<int> GetUserInfoCount()
        {
            return _context.UserInfos.CountAsync();
        }

        public async Task AddSingleUserInfo(UserInfo itemToAdd)
        {
            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public void DeleteUserInfo(UserInfo userItem)
        {
            _context.Remove(userItem);
            _context.SaveChangesAsync();
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
            if (_context.FeedItems.Any(fd => fd.RowKey == itemToAdd.RowKey)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<FeedItem>> GetFeedItems()
        {
            return await _context.FeedItems.ToListAsync();
        }

        public async Task<List<FeedItem>> GetFeedItems(DateTime start, DateTime end)
        {
            return await _context.FeedItems.Where(x => x.Date > start && x.Date < end).ToListAsync();
        }

        public async Task<List<FeedItem>> GetFeedItems(int selectedYear)
        {
            return await _context.FeedItems.Where(x => x.Date.Year == selectedYear).ToListAsync();
        }

        public async Task<List<FeedItem>> GetFeedItemsAndAttachedTranslation(UserLangSettings userLanguage)
        {
            var feedItems = await _context.FeedItems.Include("FeedTypeTranslation").ToListAsync();

            foreach (var feedItem in feedItems)
            {
                feedItem.FeedTypeTranslationString = feedItem.FeedTypeTranslation.getTranslation(userLanguage);
            }

            return feedItems;
        }

        public async Task<FeedItem> GetFeedItem(string RowKey)
        {
            return await _context.FeedItems.SingleOrDefaultAsync(feedItem => feedItem.RowKey == RowKey);
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
        public async Task<List<HealthCareItem>> GetHealthCareItems(int selectedYear)
        {
            return await _context.HealthCareItems.Where(x => x.Date.Year == selectedYear).ToListAsync();
        }

        public async Task<HealthCareItem> GetHealthCareItem(string RowKey)
        {
            return await _context.HealthCareItems.SingleOrDefaultAsync(Item => Item.RowKey == RowKey);
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
            if (_context.HealthCareItems.Any(fd => fd.RowKey == itemToAdd.RowKey)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<LabourCostItem> GetLabourCostItem(string RowKey)
        {
            return await _context.LabourCostItems.SingleOrDefaultAsync(Item => Item.RowKey == RowKey);
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
            if (_context.LabourCostItems.Any(fd => fd.RowKey == itemToAdd.RowKey)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<LabourCostItem>> GetLabourCostItems()
        {
            return await _context.LabourCostItems.ToListAsync();
        }
        public async Task<List<LabourCostItem>> GetLabourCostItems(int selectedYear)
        {
            return await _context.LabourCostItems.Where(x => x.Date.Year == selectedYear).ToListAsync();
        }

        public async Task<List<AnimalHouseItem>> GetAnimalHouseItems()
        {
            return await _context.AnimalHouseItems.ToListAsync();
        }
        public async Task<List<AnimalHouseItem>> GetAnimalHouseItems(int selectedYear)
        {
            return await _context.AnimalHouseItems.Where(x => x.Date.Year == selectedYear).ToListAsync();
        }

        public async Task<AnimalHouseItem> GetAnimalHouseItem(string RowKey)
        {
            return await _context.AnimalHouseItems.SingleOrDefaultAsync(Item => Item.RowKey == RowKey);
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
            if (_context.AnimalHouseItems.Any(fd => fd.RowKey == itemToAdd.RowKey)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<WaterCostItem>> GetWaterCostItems()
        {
            return await _context.WaterCostItems.ToListAsync();
        }
        public async Task<List<WaterCostItem>> GetWaterCostItems(int selectedYear)
        {
            return await _context.WaterCostItems.Where(x => x.Date.Year == selectedYear).ToListAsync();
        }

        public async Task<WaterCostItem> GetWaterCostItem(string RowKey)
        {
            return await _context.WaterCostItems.SingleOrDefaultAsync(Item => Item.RowKey == RowKey);
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
            if (_context.WaterCostItems.Any(fd => fd.RowKey == itemToAdd.RowKey)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<MembershipItem>> GetMembershipItems()
        {
            return await _context.MembershipItems.ToListAsync();
        }
        public async Task<List<MembershipItem>> GetMembershipItems(int selectedYear)
        {
            return await _context.MembershipItems.Where(x => x.Date.Year == selectedYear).ToListAsync();
        }

        public async Task<MembershipItem> GetMembershipItem(string RowKey)
        {
            return await _context.MembershipItems.SingleOrDefaultAsync(Item => Item.RowKey == RowKey);
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
            if (_context.MembershipItems.Any(fd => fd.RowKey == itemToAdd.RowKey)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<OtherCostItem>> GetOtherCostItems()
        {
            return await _context.OtherCostItems.ToListAsync();
        }
        public async Task<List<OtherCostItem>> GetOtherCostItems(int selectedYear)
        {
            return await _context.OtherCostItems.Where(x => x.Date.Year == selectedYear).ToListAsync();
        }

        public async Task<OtherCostItem> GetOtherCostItem(string RowKey)
        {
            return await _context.OtherCostItems.SingleOrDefaultAsync(Item => Item.RowKey == RowKey);
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
            if (_context.OtherCostItems.Any(fd => fd.RowKey == itemToAdd.RowKey)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ReproductiveItem>> GetReproductiveItems()
        {
            return await _context.ReproductiveItems.ToListAsync();
        }
        public async Task<List<ReproductiveItem>> GetReproductiveItems(int selectedYear)
        {
            return await _context.ReproductiveItems.Where(x => x.Date.Year == selectedYear).ToListAsync();
        }

        public async Task<ReproductiveItem> GetReproductiveItem(string RowKey)
        {
            return await _context.ReproductiveItems.SingleOrDefaultAsync(Item => Item.RowKey == RowKey);
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
            if (_context.ReproductiveItems.Any(fd => fd.RowKey == itemToAdd.RowKey)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<AnimalPurchaseItem>> GetAnimalPurchaseItems()
        {
            return await _context.AnimalPurchaseItems.ToListAsync();
        }
        public async Task<List<AnimalPurchaseItem>> GetAnimalPurchaseItems(int selectedYear)
        {
            return await _context.AnimalPurchaseItems.Where(x => x.Date.Year == selectedYear).ToListAsync();
        }

        public async Task<AnimalPurchaseItem> GetAnimalPurchaseItem(string RowKey)
        {
            return await _context.AnimalPurchaseItems.SingleOrDefaultAsync(Item => Item.RowKey == RowKey);
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
            if (_context.AnimalPurchaseItems.Any(fd => fd.RowKey == itemToAdd.RowKey)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<LoanRepaymentItem>> GetLoanRepaymentItems()
        {
            return await _context.LoanRepaymentItems.ToListAsync();
        }
        public async Task<List<LoanRepaymentItem>> GetLoanRepaymentItems(int selectedYear)
        {
            return await _context.LoanRepaymentItems.Where(x => x.Date.Year == selectedYear).ToListAsync();
        }

        public async Task<LoanRepaymentItem> GetLoanRepaymentItem(string RowKey)
        {
            return await _context.LoanRepaymentItems.SingleOrDefaultAsync(Item => Item.RowKey == RowKey);
        }

        public async Task UpdateLoanRepaymentItem(LoanRepaymentItem Item)
        {
            _context.Update(Item);
            await _context.SaveChangesAsync();
        }

        public void DeleteLoanRepaymentItem(LoanRepaymentItem Item)
        {
            _context.Remove(Item);
            _context.SaveChangesAsync();
        }

        public async Task AddSingleLoanRepaymentItem(LoanRepaymentItem itemToAdd)
        {
            if (_context.LoanRepaymentItems.Any(fd => fd.RowKey == itemToAdd.RowKey)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<EquipmentItem>> GetEquipmentItems()
        {
            return await _context.EquipmentItems.ToListAsync();
        }

        public async Task<List<EquipmentItem>> GetEquipmentItems(int selectedYear)
        {
            return await _context.EquipmentItems.Where(x => x.Date.Year == selectedYear).ToListAsync();
        }

        public async Task<EquipmentItem> GetEquipmentItem(string RowKey)
        {
            return await _context.EquipmentItems.SingleOrDefaultAsync(Item => Item.RowKey == RowKey);
        }

        public async Task UpdateEquipmentItem(EquipmentItem Item)
        {
            _context.Update(Item);
            await _context.SaveChangesAsync();
        }

        public void DeleteEquipmentItem(EquipmentItem Item)
        {
            _context.Remove(Item);
            _context.SaveChangesAsync();
        }

        public async Task AddSingleEquipmentItem(EquipmentItem itemToAdd)
        {
            if (_context.EquipmentItems.Any(fd => fd.RowKey == itemToAdd.RowKey)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<PigSaleItem>> GetPigSaleItems()
        {
            return await _context.PigSaleItems.ToListAsync();
        }

        public async Task<List<PigSaleItem>> GetPigSaleItems(int selectedYear)
        {
            return await _context.PigSaleItems.Where(x => x.Date.Year == selectedYear).ToListAsync();
        }

        public async Task<PigSaleItem> GetPigSaleItem(string RowKey)
        {
            return await _context.PigSaleItems.SingleOrDefaultAsync(Item => Item.RowKey == RowKey);
        }

        public async Task UpdatePigSaleItem(PigSaleItem Item)
        {
            _context.Update(Item);
            await _context.SaveChangesAsync();
        }

        public void DeletePigSaleItem(PigSaleItem Item)
        {
            _context.Remove(Item);
            _context.SaveChangesAsync();
        }

        public async Task AddSinglePigSaleItem(PigSaleItem itemToAdd)
        {
            if (_context.PigSaleItems.Any(fd => fd.RowKey == itemToAdd.RowKey)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }
        public async Task<List<BreedingServiceSaleItem>> GetBreedingServiceSaleItems()
        {
            return await _context.BreedingServiceSaleItems.ToListAsync();
        }

        public async Task<List<BreedingServiceSaleItem>> GetBreedingServiceSaleItems(int selectedYear)
        {
            return await _context.BreedingServiceSaleItems.Where(x => x.Date.Year == selectedYear).ToListAsync();
        }

        public async Task<BreedingServiceSaleItem> GetBreedingServiceSaleItem(string RowKey)
        {
            return await _context.BreedingServiceSaleItems.SingleOrDefaultAsync(Item => Item.RowKey == RowKey);
        }

        public async Task UpdateBreedingServiceSaleItem(BreedingServiceSaleItem Item)
        {
            _context.Update(Item);
            await _context.SaveChangesAsync();
        }

        public void DeleteBreedingServiceSaleItem(BreedingServiceSaleItem Item)
        {
            _context.Remove(Item);
            _context.SaveChangesAsync();
        }

        public async Task AddSingleBreedingServiceSaleItem(BreedingServiceSaleItem itemToAdd)
        {
            if (_context.BreedingServiceSaleItems.Any(fd => fd.RowKey == itemToAdd.RowKey)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ManureSaleItem>> GetManureSaleItems()
        {
            return await _context.ManureSaleItems.ToListAsync();
        }

        public async Task<List<ManureSaleItem>> GetManureSaleItems(int selectedYear)
        {
            return await _context.ManureSaleItems.Where(x => x.Date.Year == selectedYear).ToListAsync();
        }

        public async Task<ManureSaleItem> GetManureSaleItem(string RowKey)
        {
            return await _context.ManureSaleItems.SingleOrDefaultAsync(Item => Item.RowKey == RowKey);
        }

        public async Task UpdateManureSaleItem(ManureSaleItem Item)
        {
            _context.Update(Item);
            await _context.SaveChangesAsync();
        }

        public void DeleteManureSaleItem(ManureSaleItem Item)
        {
            _context.Remove(Item);
            _context.SaveChangesAsync();
        }

        public async Task AddSingleManureSaleItem(ManureSaleItem itemToAdd)
        {
            if (_context.ManureSaleItems.Any(fd => fd.RowKey == itemToAdd.RowKey)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<List<OtherIncomeItem>> GetOtherIncomeItems()
        {
            return await _context.OtherIncomeItems.ToListAsync();
        }

        public async Task<List<OtherIncomeItem>> GetOtherIncomeItems(int selectedYear)
        {
            return await _context.OtherIncomeItems.Where(x => x.Date.Year == selectedYear).ToListAsync();
        }

        public async Task<OtherIncomeItem> GetOtherIncomeItem(string RowKey)
        {
            return await _context.OtherIncomeItems.SingleOrDefaultAsync(Item => Item.RowKey == RowKey);
        }

        public async Task UpdateOtherIncomeItem(OtherIncomeItem Item)
        {
            _context.Update(Item);
            await _context.SaveChangesAsync();
        }

        public void DeleteOtherIncomeItem(OtherIncomeItem Item)
        {
            _context.Remove(Item);
            _context.SaveChangesAsync();
        }

        public async Task AddSingleOtherIncomeItem(OtherIncomeItem itemToAdd)
        {
            if (_context.OtherIncomeItems.Any(fd => fd.RowKey == itemToAdd.RowKey)) return;

            await _context.AddAsync(itemToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserInfo(UserInfo userInfo)
        {
            _context.Update(userInfo);
            await _context.SaveChangesAsync();
        }
    }
}
