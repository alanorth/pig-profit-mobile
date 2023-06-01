using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shared;
using Shared.Configurations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SQLLiteDbContext
{
    public class DbSQLLiteContext : DbContext
    {
        const string DatabaseName = "Pigs.db3";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DatabaseName}");
        }


        public DbSet<Item> Items { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<MobileUser> UserInfos { get; set; }
        public DbSet<FeedItem> FeedItems { get; set; }
        public DbSet<ControlData> ControlDataOptions { get; set; }
        public DbSet<HealthCareItem> HealthCareItems { get; set; }
        public DbSet<LabourCostItem> LabourCostItems { get; set; }
        public DbSet<AnimalHouseItem> AnimalHouseItems { get; set; }
        public DbSet<WaterCostItem> WaterCostItems { get; set; }
        public DbSet<MembershipItem> MembershipItems { get; set; }
        public DbSet<OtherCostItem> OtherCostItems { get; set; }
        public DbSet<ReproductiveItem> ReproductiveItems { get; set; }
        public DbSet<AnimalPurchaseItem> AnimalPurchaseItems { get; set; }
        public DbSet<LoanRepaymentItem> LoanRepaymentItems { get; set; }
        public DbSet<EquipmentItem> EquipmentItems { get; set; }
        public DbSet<PigSaleItem> PigSaleItems { get; set; }
        public DbSet<BreedingServiceSaleItem> BreedingServiceSaleItems { get; set; }
        public DbSet<ManureSaleItem> ManureSaleItems { get; set; }
        public DbSet<OtherIncomeItem> OtherIncomeItems { get; set; }
        public DbSet<BaseItem> BaseItems { get; set; }


        public DbSQLLiteContext()
        {
            //SQLitePCL.Batteries_V2.Init();
            //this.Database.EnsureCreated();

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaseItem>().HasKey(x => x.RowKey);
            modelBuilder.Entity<BaseItem>().Ignore(x => x.ETag);
            modelBuilder.Entity<BaseItem>().Property(bi => bi.CreatedTimeStamp).HasDefaultValueSql("datetime()");
            modelBuilder.Entity<BaseItem>().Property(bi => bi.IsEnable).HasDefaultValue(true);
            modelBuilder.Entity<BaseItem>().Property(bi => bi.IsDeleted).HasDefaultValue(false);
            modelBuilder.Entity<BaseItem>().Property(bi => bi.IsModified).HasDefaultValue(true);
            modelBuilder.Entity<BaseItem>().Property(bi => bi.LastModified).HasDefaultValueSql("datetime()");

            //modelBuilder.Entity<Translation>().HasKey(x => x.RowKey);
            modelBuilder.ApplyConfiguration(new TranslationConfigurations());
            //modelBuilder.Entity<UserInfo>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyUserInfo);
            modelBuilder.Entity<MobileUser>().HasKey(x => x.RowKey);
            modelBuilder.Entity<MobileUser>().Ignore(x => x.ETag);

            modelBuilder.Entity<FeedItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyFeed);
            //modelBuilder.Entity<FeedItem>().Property(bi => bi.CreatedTimeStamp).ValueGeneratedOnAddOrUpdate();
            //modelBuilder.Entity<ControlData>().ToTable("ControlDataOptions");
            modelBuilder.Entity<ControlData>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyControlData);
            modelBuilder.Entity<ControlData>().HasKey(cd => new { cd.TranslationRowKey, cd.DropDownControlOption });
            modelBuilder.Entity<ControlData>().Property(cd => cd.RowKey).HasComputedColumnSql("[DropDownControlOption] + '-' + [TranslationRowKey]");
            //modelBuilder.Entity<ControlData>().Property(bi => bi.LastModified).HasDefaultValue(DateTime.UtcNow);
            //modelBuilder.Entity<ControlData>().Property(bi => bi.CreatedTimeStamp).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<HealthCareItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyHealthCareItem);
            //modelBuilder.Entity<HealthCareItem>().Property(bi => bi.CreatedTimeStamp).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<LabourCostItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyLabourCostItem);
            //modelBuilder.Entity<LabourCostItem>().Property(bi => bi.CreatedTimeStamp).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<AnimalHouseItem>().ToTable("AnimalHouseItems");
            modelBuilder.Entity<AnimalHouseItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyAnimalHouse);
            //modelBuilder.Entity<AnimalHouseItem>().Property(bi => bi.CreatedTimeStamp).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<WaterCostItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyWaterCostItem);
            //modelBuilder.Entity<WaterCostItem>().Property(bi => bi.CreatedTimeStamp).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<MembershipItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyMembershipItem);
            //modelBuilder.Entity<MembershipItem>().Property(bi => bi.CreatedTimeStamp).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<OtherCostItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyOtherCostItem);
            //modelBuilder.Entity<OtherCostItem>().Property(bi => bi.CreatedTimeStamp).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<ReproductiveItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyReproductiveItem);
            //modelBuilder.Entity<ReproductiveItem>().Property(bi => bi.CreatedTimeStamp).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<AnimalPurchaseItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyAnimalPurchaseItem);
            //modelBuilder.Entity<AnimalPurchaseItem>().Property(bi => bi.CreatedTimeStamp).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<LoanRepaymentItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyLoanRepaymentItem);
            //modelBuilder.Entity<LoanRepaymentItem>().Property(bi => bi.CreatedTimeStamp).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<EquipmentItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyEquipmentItem);
            //modelBuilder.Entity<EquipmentItem>().Property(bi => bi.CreatedTimeStamp).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<PigSaleItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyPigSaleItem);
            //modelBuilder.Entity<PigSaleItem>().Property(bi => bi.CreatedTimeStamp).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<BreedingServiceSaleItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyBreedingServiceSaleItem);
            //modelBuilder.Entity<BreedingServiceSaleItem>().Property(bi => bi.CreatedTimeStamp).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<ManureSaleItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyManureSaleItem);
            //modelBuilder.Entity<ManureSaleItem>().Property(bi => bi.CreatedTimeStamp).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<OtherIncomeItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyOtherIncomeItem);
            //modelBuilder.Entity<OtherIncomeItem>().Property(bi => bi.CreatedTimeStamp).ValueGeneratedOnAddOrUpdate();

            modelBuilder.Entity<ControlData>()
            .HasOne(cd => cd.Translation).WithMany(t => t.ControlDatas).HasForeignKey(cd => cd.TranslationRowKey);

            modelBuilder.Entity<FeedItem>().HasOne(fi => fi.FeedTypeTranslation).WithMany(trans => trans.FeedItems).HasForeignKey(fi => fi.FeedType).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<AnimalHouseItem>().HasOne(En => En.AnimalExpenseTranslation).WithMany(trans => trans.AnimalHouseItems).HasForeignKey(fi => fi.HousingExpense).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<AnimalPurchaseItem>().HasOne(En => En.DisplayTypeTranslation).WithMany(trans => trans.AnimalPurchaseItems).HasForeignKey(fi => fi.AnimalType).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<BreedingServiceSaleItem>().HasOne(En => En.DisplayTypeTranslation).WithMany(trans => trans.BreedingServiceSaleItems).HasForeignKey(fi => fi.ServiceType).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<EquipmentItem>().HasOne(En => En.DisplayTypeTranslation).WithMany(trans => trans.EquipmentItems).HasForeignKey(fi => fi.EquipmentType).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<HealthCareItem>().HasOne(En => En.DisplayTypeTranslation).WithMany(trans => trans.HealthCareItems).HasForeignKey(fi => fi.HealthCareType).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<LabourCostItem>().HasOne(En => En.DisplayTypeTranslation).WithMany(trans => trans.LabourCostItems).HasForeignKey(fi => fi.LabourType).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<LoanRepaymentItem>().HasOne(En => En.DisplayTypeTranslation).WithMany(trans => trans.LoanRepaymentItems).HasForeignKey(fi => fi.LoanProvider).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<MembershipItem>().HasOne(En => En.DisplayTypeTranslation).WithMany(trans => trans.MembershipItems).HasForeignKey(fi => fi.MembershipType).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<PigSaleItem>().HasOne(En => En.DisplayTypeTranslation).WithMany(trans => trans.PigSaleItems).HasForeignKey(fi => fi.PigType).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ReproductiveItem>().HasOne(En => En.DisplayTypeTranslation).WithMany(trans => trans.ReproductiveItems).HasForeignKey(fi => fi.ServiceType).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ManureSaleItem>().HasOne(En => En.DisplayTypeTranslation).WithMany(trans => trans.ManureSaleItems).HasForeignKey(fi => fi.SoldTo).OnDelete(DeleteBehavior.NoAction);
        
            modelBuilder.Entity<ControlData>(async x =>
            {
                x.HasData(
                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType3" },
                   new ControlData() { DisplayOrder = 4, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType4" },
                   new ControlData() { DisplayOrder = 5, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType5" },
                   new ControlData() { DisplayOrder = 6, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType6" },
                   new ControlData() { DisplayOrder = 7, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType7" },
                   new ControlData() { DisplayOrder = 8, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType8" },
                   new ControlData() { DisplayOrder = 9, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType9" },
                   new ControlData() { DisplayOrder = 10, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType10" },
                   new ControlData() { DisplayOrder = 11, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType11" },
                   new ControlData() { DisplayOrder = 12, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType12" },
                   new ControlData() { DisplayOrder = 13, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType13" },
                   new ControlData() { DisplayOrder = 14, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType14" },
                   new ControlData() { DisplayOrder = 15, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType15" },
                   new ControlData() { DisplayOrder = 16, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType16" },
                   new ControlData() { DisplayOrder = 17, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType17" },
                   new ControlData() { DisplayOrder = 18, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType18" },
                   new ControlData() { DisplayOrder = 19, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType19" },
                   new ControlData() { DisplayOrder = 20, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDAMOUNTPURCHASEDUNITTYPE, TranslationRowKey = "DropDownUnitType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDAMOUNTPURCHASEDUNITTYPE, TranslationRowKey = "DropDownUnitType3" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDAMOUNTPURCHASEDUNITTYPE, TranslationRowKey = "DropDownUnitType2" },
                   new ControlData() { DisplayOrder = 5, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDAMOUNTPURCHASEDUNITTYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDPURCHASEDFROMTYPE, TranslationRowKey = "DropDownPurchaseFrom1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDPURCHASEDFROMTYPE, TranslationRowKey = "DropDownPurchaseFrom2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDPURCHASEDFROMTYPE, TranslationRowKey = "DropDownPurchaseFrom3" },
                   new ControlData() { DisplayOrder = 4, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDPURCHASEDFROMTYPE, TranslationRowKey = "DropDownPurchaseFrom4" },
                   new ControlData() { DisplayOrder = 5, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.FEEDPURCHASEDFROMTYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType3" },
                   new ControlData() { DisplayOrder = 4, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType4" },
                   new ControlData() { DisplayOrder = 5, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType5" },
                   new ControlData() { DisplayOrder = 6, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType6" },
                   new ControlData() { DisplayOrder = 11, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType2" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType3" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType4" },
                   new ControlData() { DisplayOrder = 11, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType3" },
                   new ControlData() { DisplayOrder = 4, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType4" },
                   new ControlData() { DisplayOrder = 5, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType5" },
                   new ControlData() { DisplayOrder = 11, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType3" },
                   new ControlData() { DisplayOrder = 11, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.LABOURTYPE, TranslationRowKey = "LabourType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.LABOURTYPE, TranslationRowKey = "LabourType2" },
                   new ControlData() { DisplayOrder = 7, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.LABOURTYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HOUSINGTYPE, TranslationRowKey = "HousingExpenseType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HOUSINGTYPE, TranslationRowKey = "HousingExpenseType2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HOUSINGTYPE, TranslationRowKey = "HousingExpenseType3" },
                   new ControlData() { DisplayOrder = 6, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.HOUSINGTYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.WATERPURCHASEDUNITTYPE, TranslationRowKey = "WaterPurchasedUnitType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.WATERPURCHASEDUNITTYPE, TranslationRowKey = "WaterPurchasedUnitType2" },
                   new ControlData() { DisplayOrder = 6, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.WATERPURCHASEDUNITTYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType3" },
                   new ControlData() { DisplayOrder = 11, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = "MembershipType1" },
                   new ControlData() { DisplayOrder = 9, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.TIMEPERIODUNITTYPE, TranslationRowKey = "TimePeriodUnitType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.TIMEPERIODUNITTYPE, TranslationRowKey = "TimePeriodUnitType2" },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = "ServiceType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = "ServiceType2" },
                   new ControlData() { DisplayOrder = 9, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType3" },
                   new ControlData() { DisplayOrder = 9, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType3" },
                   new ControlData() { DisplayOrder = 9, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType3" },
                   new ControlData() { DisplayOrder = 4, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType4" },
                   new ControlData() { DisplayOrder = 9, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.LOANPROVIDERTYPE, TranslationRowKey = "LoanProviderType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.LOANPROVIDERTYPE, TranslationRowKey = "LoanProviderType2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.LOANPROVIDERTYPE, TranslationRowKey = "LoanProviderType3" },
                   new ControlData() { DisplayOrder = 4, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.LOANPROVIDERTYPE, TranslationRowKey = "LoanProviderType4" },
                   new ControlData() { DisplayOrder = 5, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.LOANPROVIDERTYPE, TranslationRowKey = "LoanProviderType5" },
                   new ControlData() { DisplayOrder = 6, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.LOANPROVIDERTYPE, TranslationRowKey = "LoanProviderType6" },
                   new ControlData() { DisplayOrder = 9, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.LOANPROVIDERTYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.EQUIPMENTTYPE, TranslationRowKey = "EquipmentType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.EQUIPMENTTYPE, TranslationRowKey = "EquipmentType2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.EQUIPMENTTYPE, TranslationRowKey = "EquipmentType3" },
                   new ControlData() { DisplayOrder = 4, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.EQUIPMENTTYPE, TranslationRowKey = "EquipmentType4" },
                   new ControlData() { DisplayOrder = 9, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.EQUIPMENTTYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.PIGTYPE, TranslationRowKey = "PigType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.PIGTYPE, TranslationRowKey = "PigType2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.PIGTYPE, TranslationRowKey = "PigType3" },
                   new ControlData() { DisplayOrder = 4, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.PIGTYPE, TranslationRowKey = "PigType4" },
                   new ControlData() { DisplayOrder = 9, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.PIGTYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.SOLDTOTYPE, TranslationRowKey = "SoldToType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.SOLDTOTYPE, TranslationRowKey = "SoldToType2" },
                   new ControlData() { DisplayOrder = 9, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.SOLDTOTYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.BREEDINGSERVICETYPE, TranslationRowKey = "BreedingServiceType1" },
                   //new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.BREEDINGSERVICETYPE, TranslationRowKey = "BreedingServiceType2" },
                   new ControlData() { DisplayOrder = 9, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.BREEDINGSERVICETYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.OTHERPAYMENTTYPE, TranslationRowKey = "PaymentType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.OTHERPAYMENTTYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.CLIENTTYPE, TranslationRowKey = "ClientType1" },
                   new ControlData() { DisplayOrder = 9, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.CLIENTTYPE, TranslationRowKey = Constants.OTHER },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.VOLUMEUNITTYPE, TranslationRowKey = "VolumeUnitType1" },
                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.VOLUMEUNITTYPE, TranslationRowKey = "VolumeUnitType2" },
                   new ControlData() { DisplayOrder = 9, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.VOLUMEUNITTYPE, TranslationRowKey = Constants.OTHER },

                    new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.GENDERTYPE, TranslationRowKey = "GenderType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.GENDERTYPE, TranslationRowKey = "GenderType2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.GENDERTYPE, TranslationRowKey = "GenderType3" },

                     new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.DISTRICTTYPE, TranslationRowKey = "DistrictType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.DISTRICTTYPE, TranslationRowKey = "DistrictType2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.DISTRICTTYPE, TranslationRowKey = "DistrictType3" },
                   new ControlData() { DisplayOrder = 4, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.DISTRICTTYPE, TranslationRowKey = "DistrictType4" },
                   new ControlData() { DisplayOrder = 5, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.DISTRICTTYPE, TranslationRowKey = "DistrictType5" },
                   new ControlData() { DisplayOrder = 6, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.DISTRICTTYPE, TranslationRowKey = "DistrictType6" },
                   new ControlData() { DisplayOrder = 7, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.DISTRICTTYPE, TranslationRowKey = "DistrictType7" },
                   new ControlData() { DisplayOrder = 8, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.DISTRICTTYPE, TranslationRowKey = "DistrictType8" },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.COUNTYTYPE, TranslationRowKey = "CountyType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.COUNTYTYPE, TranslationRowKey = "CountyType2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.COUNTYTYPE, TranslationRowKey = "CountyType3" },
                   new ControlData() { DisplayOrder = 4, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.COUNTYTYPE, TranslationRowKey = "CountyType4" },
                   new ControlData() { DisplayOrder = 5, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.COUNTYTYPE, TranslationRowKey = "CountyType5" },
                   new ControlData() { DisplayOrder = 6, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.COUNTYTYPE, TranslationRowKey = "CountyType6" },
                   new ControlData() { DisplayOrder = 7, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.COUNTYTYPE, TranslationRowKey = "CountyType7" },
                   new ControlData() { DisplayOrder = 8, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.COUNTYTYPE, TranslationRowKey = "CountyType8" },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.COUNTRYTYPE, TranslationRowKey = "CountryTypeUganda" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.COUNTRYTYPE, TranslationRowKey = "CountryTypeVietnam" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.COUNTRYTYPE, TranslationRowKey = "CountryTypeRwanda" },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.SUBCOUNTYTYPE, TranslationRowKey = "SubCountyType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.SUBCOUNTYTYPE, TranslationRowKey = "SubCountyType2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.SUBCOUNTYTYPE, TranslationRowKey = "SubCountyType3" },
                   new ControlData() { DisplayOrder = 4, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.SUBCOUNTYTYPE, TranslationRowKey = "SubCountyType4" },
                   new ControlData() { DisplayOrder = 5, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.SUBCOUNTYTYPE, TranslationRowKey = "SubCountyType5" },
                   new ControlData() { DisplayOrder = 6, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.SUBCOUNTYTYPE, TranslationRowKey = "SubCountyType6" },
                   new ControlData() { DisplayOrder = 7, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.SUBCOUNTYTYPE, TranslationRowKey = "SubCountyType7" },
                   new ControlData() { DisplayOrder = 8, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.SUBCOUNTYTYPE, TranslationRowKey = "SubCountyType8" },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.CURRENCYTYPE, TranslationRowKey = "CurrencyType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.CURRENCYTYPE, TranslationRowKey = "CurrencyType2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.CURRENCYTYPE, TranslationRowKey = "CurrencyType3" },
                   new ControlData() { DisplayOrder = 4, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.CURRENCYTYPE, TranslationRowKey = "CurrencyType4" },
                   new ControlData() { DisplayOrder = 5, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.CURRENCYTYPE, TranslationRowKey = "CurrencyType5" },
                   new ControlData() { DisplayOrder = 6, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.CURRENCYTYPE, TranslationRowKey = "CurrencyType6" },
                   new ControlData() { DisplayOrder = 7, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.CURRENCYTYPE, TranslationRowKey = "CurrencyType7" },
                   new ControlData() { DisplayOrder = 8, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.CURRENCYTYPE, TranslationRowKey = "CurrencyType8" },

                   new ControlData() { DisplayOrder = 1, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.LANGUAGETYPE, TranslationRowKey = "LanguageType1" },
                   new ControlData() { DisplayOrder = 2, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.LANGUAGETYPE, TranslationRowKey = "LanguageType2" },
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.LANGUAGETYPE, TranslationRowKey = "LanguageType3" },
                   new ControlData() { DisplayOrder = 4, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.LANGUAGETYPE, TranslationRowKey = "LanguageType4" },
                   new ControlData() { DisplayOrder = 5, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.LANGUAGETYPE, TranslationRowKey = "LanguageType5" },
                   new ControlData() { DisplayOrder = 6, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.LANGUAGETYPE, TranslationRowKey = "LanguageType6" }


                   );
            }
            );

            //Convert Enum To String
            modelBuilder.Entity<MobileUser>().Property(x => x.UserLang)
                .HasConversion(
                v => v.ToString(),
                v => (UserLangSettings)Enum.Parse(typeof(UserLangSettings), v)
                );



            /*
            modelBuilder.Entity<MobileUser>(x =>
            {
                x.HasData(
                    new MobileUser()
                    {
                        LastUploadDate = DateTime.Now,
                        UserName = "Marty",
                        Village = "Dunedin",
                        Name = "Marty Haigh",
                        Gender = "Male",
                        County = "New Zealand",
                        District = "Otago",
                        Email = "Email@email.com",
                        UserLang = UserLangSettings.Eng,
                        RowKey = Guid.NewGuid().ToString(),
                        PartitionKey = "User",
                        Currency = "test",
                        Country = "test",
                        SubCounty = "test",
                        PhoneNumber = "test",
                        Parish = "test",
                        LastModified = DateTime.UtcNow,
                        Timestamp = DateTime.UtcNow
                        Timestamp = DateTime.UtcNow,
                        AuthorisedToken = "",
                        AuthorisedEmail = ""
                    }
                ) ;
            }
            
            
           );
            
*/
        }

    }
}
