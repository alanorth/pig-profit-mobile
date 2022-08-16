using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PigTool.Helpers;
using PigTool.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Essentials;

namespace SQLLiteDbContext
{
    public class DbSQLLiteContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<FeedItem> FeedItems { get; set; }
        public DbSet<ControlData> ControlDataOptions { get; set; }


        public DbSQLLiteContext()
        {
            SQLitePCL.Batteries_V2.Init();
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "Pigs.db3");

            optionsBuilder.UseSqlite($"Filename={dbPath}");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Translation>().HasKey(x => x.RowKey);

            modelBuilder.Entity<ControlData>()
            .HasOne(cd => cd.Translation).WithMany(t => t.ControlDatas).HasForeignKey(cd => cd.TranslationRowKey);

            modelBuilder.Entity<BaseItem>().Property(bi => bi.CreatedTimeStamp).HasDefaultValue(DateTime.UtcNow);
            modelBuilder.Entity<BaseItem>().Property(bi => bi.IsEnable).HasDefaultValue(true);
            modelBuilder.Entity<BaseItem>().Property(bi => bi.IsDeleted).HasDefaultValue(false);
            modelBuilder.Entity<BaseItem>().Property(bi => bi.IsModified).HasDefaultValue(true);
            modelBuilder.Entity<BaseItem>().Property(bi => bi.LastModified).HasDefaultValue(DateTime.UtcNow);

#if DEBUG
            modelBuilder.Entity<Translation>(x =>
                {
                    x.HasData(
                        new Translation() { RowKey = "LoginButton", English = "Login", Lang1 = "SignUP", Lang2 = "OverHere" },
                        new Translation() { RowKey = "Name", English = "Name", Lang1 = "NameLang1", Lang2 = "NameLang2" },
                        new Translation() { RowKey = "Village", English = "Village", Lang1 = "VillageLang1", Lang2 = "VillageLang2" },
                        new Translation() { RowKey = "DateLastUploaded", English = "Data last uploaded", Lang1 = "Data last uploaded lang1", Lang2 = "Data last uploaded lang2" },
                        new Translation() { RowKey = "AddData", English = "Add Data", Lang1 = "Add Data lang1", Lang2 = "Add Data lang2" },
                        new Translation() { RowKey = "EditData", English = "View / Edit / Delete data", Lang1 = "View / Edit / Delete data lang1", Lang2 = "View / Edit / Delete data lang2" },
                        new Translation() { RowKey = "ViewReports", English = "Reports", Lang1 = "Reports Lang1", Lang2 = "Reports Lang2" },
                        new Translation() { RowKey = "Home", English = "Home", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },

                        new Translation() { RowKey = "Costs", English = "Costs", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                        new Translation() { RowKey = "Feed", English = "Feed", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                        new Translation() { RowKey = "Healthcare", English = "Healthcare", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                        new Translation() { RowKey = "Labour", English = "Labour", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                        new Translation() { RowKey = "Housing", English = "Housing", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                        new Translation() { RowKey = "Water", English = "Water", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                        new Translation() { RowKey = "Reproduction", English = "Reproduction", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                        new Translation() { RowKey = "Membership", English = "Co-Operative / Group membership", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                        new Translation() { RowKey = SC.OTHER, English = "Other", Lang1 = "Other Lang1", Lang2 = "Other Lang2" },
                        new Translation() { RowKey = "AnimalPurchase", English = "Animal Purchase", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                        new Translation() { RowKey = "LoanRepayment", English = "Loan Repayment", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                        new Translation() { RowKey = "Income", English = "Income", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                        new Translation() { RowKey = "Saleofpigs", English = "Sale of Pigs", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                        new Translation() { RowKey = "Saleofbreedingservices", English = "Sale of breeding services", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                        new Translation() { RowKey = "OtherIncome", English = "Other Income", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                        new Translation() { RowKey = "Equipment", English = "Home", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },

                        //Add Feed Item Translations
                        new Translation() { RowKey = "AddFeedItemTrans", English = "Add Feed Cost", Lang1 = "Add Feed Cost Lang1", Lang2 = "Add Feed Cost Lang2",   },
                        new Translation() { RowKey = "DateObtainedTrans", English = "Date Obtained", Lang1 = "Date Obtained Lang1", Lang2 = "Date Obtained Lang2" },
                        new Translation() { RowKey = "FeedTypeTrans", English = "Feed Type", Lang1 = "Feed Type Lang1", Lang2 = "Feed Type Lang2" },
                        new Translation() { RowKey = "OtherFeedTypeTrans", English = "Other Feed Type", Lang1 = "Other Feed Type Lang1", Lang2 = "Other Feed Type Lang2" },
                        new Translation() { RowKey = "AmountPurchasedTrans", English = "Amount Purchased", Lang1 = "Amount Purchased Lang1", Lang2 = "Amount Purchased Lang2" },
                        new Translation() { RowKey = "UnitTrans", English = "Unit", Lang1 = "Unit Lang1", Lang2 = "Unit Lang2" },
                        new Translation() { RowKey = "OtherAmountPurchaseTrans", English = "Other Amount Purchased", Lang1 = "Other Amount Purchased Lang1", Lang2 = "Other Amount Purchased Lang2" },
                        new Translation() { RowKey = "CostTrans", English = "Cost", Lang1 = "Cost Lang1", Lang2 = "Cost Lang2" },
                        new Translation() { RowKey = "TransportCostTrans", English = "Transportation Cost", Lang1 = "Transportation Cost Lang1", Lang2 = "Transportation Cost Lang2" },
                        new Translation() { RowKey = "PurchasedFrom", English = "Purchased From", Lang1 = "Purchased From Lang1", Lang2 = "Purchased From Lang2" },
                        new Translation() { RowKey = "CommentTrans", English = "Comment", Lang1 = "Comment Lang1", Lang2 = "Comment Lang2" },
                        new Translation() { RowKey = "Save", English = "Save", Lang1 = "Save Lang1", Lang2 = "Save Lang2" },
                        new Translation() { RowKey = "Reset", English = "Reset", Lang1 = "Reset Lang1", Lang2 = "Reset Lang2" },

                        //Drop Down Options
                        new Translation() { RowKey = "DropDownFeedType1", English = "Feed Type 1", Lang1 = "Feed Type 1 Lang 1", Lang2 = "Feed Type 1 Lang 2" },
                        new Translation() { RowKey = "DropDownFeedType2", English = "Feed Type 2", Lang1 = "Feed Type 2 Lang 1", Lang2 = "Feed Type 2 Lang 2" },
                        new Translation() { RowKey = "DropDownFeedType3", English = "Feed Type 3", Lang1 = "Feed Type 3 Lang 1", Lang2 = "Feed Type 3 Lang 2" },
                        new Translation() { RowKey = "DropDownFeedType4", English = "Feed Type 4", Lang1 = "Feed Type 4 Lang 1", Lang2 = "Feed Type 4 Lang 2" },
                        new Translation() { RowKey = "DropDownFeedType5", English = "Feed Type 5", Lang1 = "Feed Type 5 Lang 1", Lang2 = "Feed Type 5 Lang 2" },

                        new Translation() { RowKey = "DropDownUnitType1", English = "Unit Type 1", Lang1 = "lang 1", Lang2 = "Lang 2" },
                        new Translation() { RowKey = "DropDownUnitType2", English = "Unit Type 2", Lang1 = "Unit Type 2 lang 1", Lang2 = "Unit Type 2 Lang 2" },
                        new Translation() { RowKey = "DropDownUnitType3", English = "Unit Type 3", Lang1 = "Unit Type 3 lang 1", Lang2 = "Unit Type 3 Lang 2" },
                        new Translation() { RowKey = "DropDownUnitType4", English = "Unit Type 4", Lang1 = "Unit Type 4 lang 1", Lang2 = "Unit Type 4 Lang 2" },
                        new Translation() { RowKey = "DropDownUnitType5", English = "Unit Type 5", Lang1 = "Unit Type 5 lang 1", Lang2 = "Unit Type 5 Lang 2" },

                        new Translation() { RowKey = "DropDownPurchaseFrom1", English = "Puchase From 1", Lang1 = "Puchase From 1 Lang1", Lang2 = "Puchase From 1 lang 2" },
                        new Translation() { RowKey = "DropDownPurchaseFrom2", English = "Puchase From 2", Lang1 = "Puchase From 2 Lang1", Lang2 = "Puchase From 2 lang 2" },
                        new Translation() { RowKey = "DropDownPurchaseFrom3", English = "Puchase From 3", Lang1 = "Puchase From 3 Lang1", Lang2 = "Puchase From 3 lang 2" },
                        new Translation() { RowKey = "DropDownPurchaseFrom4", English = "Puchase From 4", Lang1 = "Puchase From 4 Lang1", Lang2 = "Puchase From 4 lang 2" },
                        new Translation() { RowKey = "DropDownPurchaseFrom5", English = "Puchase From 5", Lang1 = "Puchase From 5 Lang1", Lang2 = "Puchase From 5 lang 2" }

                    );
                }
            );

            modelBuilder.Entity<ControlData>(async x =>
                {
                    x.HasData(
                       new ControlData() { Id = 1, CreatedTimeStamp = new DateTime(), DropDownControlOption = SC.FEEDTYPE, TranslationRowKey = "DropDownFeedType1" },
                       new ControlData() { Id = 2, CreatedTimeStamp = new DateTime(), DropDownControlOption = SC.FEEDTYPE, TranslationRowKey = "DropDownFeedType2" },
                       new ControlData() { Id = 3, CreatedTimeStamp = new DateTime(), DropDownControlOption = SC.FEEDTYPE, TranslationRowKey = "DropDownFeedType3" },
                       new ControlData() { Id = 4, CreatedTimeStamp = new DateTime(), DropDownControlOption = SC.FEEDTYPE, TranslationRowKey = "DropDownFeedType4" },
                       new ControlData() { Id = 5, CreatedTimeStamp = new DateTime(), DropDownControlOption = SC.FEEDTYPE, TranslationRowKey = "DropDownFeedType5" },
                       new ControlData() { Id = 6, CreatedTimeStamp = new DateTime(), DropDownControlOption = SC.FEEDTYPE, TranslationRowKey = SC.OTHER },

                       new ControlData() { Id = 7, CreatedTimeStamp = new DateTime(), DropDownControlOption = SC.UNITTYPE, TranslationRowKey = "DropDownUnitType1" },
                       new ControlData() { Id = 8, CreatedTimeStamp = new DateTime(), DropDownControlOption = SC.UNITTYPE, TranslationRowKey = "DropDownUnitType2" },
                       new ControlData() { Id = 9, CreatedTimeStamp = new DateTime(), DropDownControlOption = SC.UNITTYPE, TranslationRowKey = "DropDownUnitType3" },
                       new ControlData() { Id = 10, CreatedTimeStamp = new DateTime(), DropDownControlOption = SC.UNITTYPE, TranslationRowKey = "DropDownUnitType4" },
                       new ControlData() { Id = 11, CreatedTimeStamp = new DateTime(), DropDownControlOption = SC.UNITTYPE, TranslationRowKey = "DropDownUnitType5" },
                       new ControlData() { Id = 12, CreatedTimeStamp = new DateTime(), DropDownControlOption = SC.UNITTYPE, TranslationRowKey = SC.OTHER },

                       new ControlData() { Id = 13, CreatedTimeStamp = new DateTime(), DropDownControlOption = SC.PURCHASETYPE, TranslationRowKey = "DropDownPurchaseFrom1" },
                       new ControlData() { Id = 14, CreatedTimeStamp = new DateTime(), DropDownControlOption = SC.PURCHASETYPE, TranslationRowKey = "DropDownPurchaseFrom2" },
                       new ControlData() { Id = 15, CreatedTimeStamp = new DateTime(), DropDownControlOption = SC.PURCHASETYPE, TranslationRowKey = "DropDownPurchaseFrom3" },
                       new ControlData() { Id = 16, CreatedTimeStamp = new DateTime(), DropDownControlOption = SC.PURCHASETYPE, TranslationRowKey = "DropDownPurchaseFrom4" },
                       new ControlData() { Id = 17, CreatedTimeStamp = new DateTime(), DropDownControlOption = SC.PURCHASETYPE, TranslationRowKey = "DropDownPurchaseFrom5" }
                    );
                }
            );
# endif
            //Convert Enum To String
            modelBuilder.Entity<UserInfo>().Property(x => x.UserLang)
                .HasConversion(
                v => v.ToString(),
                v => (UserLangSettings)Enum.Parse(typeof(UserLangSettings), v)
                );


            modelBuilder.Entity<UserInfo>(x =>
            {
                x.HasData(
                    new UserInfo() { Id = "1", LastUploadDate = DateTime.Now, UserName = "Marty", Village = "Dunedin", UserLang = UserLangSettings.Eng }
                );
            }
           );


        }

    }
}
