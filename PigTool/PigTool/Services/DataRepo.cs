using PigTool.Models;
using SQLLiteDbContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
            return _context.userInfos.FirstAsync();
        }
    }
}
