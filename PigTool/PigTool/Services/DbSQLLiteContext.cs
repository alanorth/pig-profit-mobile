﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PigTool.Helpers;
using Shared;
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
        public DbSet<HealthCareItem> HealthCareItems { get; set; }
        public DbSet<LabourCostItem> LabourCostItems { get; set; }
        public DbSet<AnimalHouseItem> AnimalHouseItems { get; set; }
        public DbSet<WaterCostItem> WaterCostItems { get; set; }
        public DbSet<MembershipItem> MembershipItems { get; set; }
        public DbSet<OtherCostItem> OtherCostItems { get; set; }
        public DbSet<ReproductiveItem> ReproductiveItems { get; set; }
        public DbSet<AnimalPurchaseItem> AnimalPurchaseItems { get; set; }

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

            modelBuilder.Entity<BaseItem>().HasKey(x => x.RowKey);
            modelBuilder.Entity<UserInfo>().HasKey(x => x.RowKey);
            modelBuilder.Entity<BaseItem>().Property(bi => bi.RowKey).HasDefaultValue(Guid.NewGuid().ToString());

            modelBuilder.Entity<FeedItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyFeed);
            modelBuilder.Entity<ControlData>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyControlData);
            modelBuilder.Entity<HealthCareItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyHealthCareItem);
            modelBuilder.Entity<LabourCostItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyLabourCostItem);
            modelBuilder.Entity<AnimalHouseItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyAnimalHouse);
            modelBuilder.Entity<WaterCostItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyWaterCostItem);
            modelBuilder.Entity<MembershipItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyMembershipItem);
            modelBuilder.Entity<OtherCostItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyOtherCostItem);
            modelBuilder.Entity<ReproductiveItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyReporductiveItem);

            modelBuilder.Entity<ControlData>()
            .HasOne(cd => cd.Translation).WithMany(t => t.ControlDatas).HasForeignKey(cd => cd.TranslationRowKey);

            modelBuilder.Entity<FeedItem>().HasOne(fi => fi.FeedTypeTranslation).WithMany(trans => trans.FeedItems).HasForeignKey(fi => fi.FeedType);

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
                         new Translation() { RowKey = Constants.OTHER, English = "Other", Lang1 = "Other Lang1", Lang2 = "Other Lang2" },
                         new Translation() { RowKey = "AnimalPurchase", English = "Animal Purchase", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                         new Translation() { RowKey = "LoanRepayment", English = "Loan Repayment", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                         new Translation() { RowKey = "Income", English = "Income", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                         new Translation() { RowKey = "Saleofpigs", English = "Sale of Pigs", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                         new Translation() { RowKey = "Saleofbreedingservices", English = "Sale of breeding services", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                         new Translation() { RowKey = "OtherIncome", English = "Other Income", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                         new Translation() { RowKey = "Equipment", English = "Home", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },

                         new Translation() { RowKey = "DateTranslation", English = "Date", Lang1 = "Date Lang1", Lang2 = "Date Lang 2" },
                         new Translation() { RowKey = "TotalCostTranslation", English = "Total Cost", Lang1 = "Total Cost Lang1", Lang2 = "Total Cost Lang2" },
                         new Translation() { RowKey = "TransportationCostTranslation", English = "Transport Cost", Lang1 = "Transport Cost Lang1", Lang2 = "Transport Cost Lang2" },
                         new Translation() { RowKey = "OtherCostTranslation", English = "Any Other Cost", Lang1 = "Any Other Cost Lang1", Lang2 = "Any Other Cost Lang2" },
                         new Translation() { RowKey = "CommentTranslation", English = "Comment", Lang1 = "Comment Lang1", Lang2 = "Comment Lang2" },

                         //Core Button Translations
                         new Translation() { RowKey = "SaveTranslation", English = "Save", Lang1 = "Save Lang1", Lang2 = "Save Lang2" },
                         new Translation() { RowKey = "ResetTranslation", English = "Reset", Lang1 = "Reset Lang1", Lang2 = "Reset Lang2" },
                         new Translation() { RowKey = "EditTranslation", English = "Edit", Lang1 = "Edit Lang1", Lang2 = "Edit Lang2" },
                         new Translation() { RowKey = "DeleteTranslation", English = "Delete", Lang1 = "Delete Lang1", Lang2 = "Delete Lang2" },

                         //Add Feed Item Translations
                         new Translation() { RowKey = "FeedItemTitleTranslation", English = "Feed Cost", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "FeedTypeTranslation", English = "Feed Type", Lang1 = "Feed Type Lang1", Lang2 = "Feed Type Lang2" },
                         new Translation() { RowKey = "OtherFeedTypeTranslation", English = "Other Feed Type", Lang1 = "Other Feed Type Lang1", Lang2 = "Other Feed Type Lang2" },
                         new Translation() { RowKey = "AmountPurchasedTranslation", English = "Amount Purchased", Lang1 = "Amount Purchased Lang1", Lang2 = "Amount Purchased Lang2" },
                         new Translation() { RowKey = "AmountPurchasedUnitTranslation", English = "Amount Purchased", Lang1 = "Amount Purchased Lang1", Lang2 = "Amount Purchased Lang2" },
                         new Translation() { RowKey = "OtherAmountPurchasedUnitTranslation", English = "Other Amount Purchased", Lang1 = "Other Amount Purchased Lang1", Lang2 = "Other Amount Purchased Lang2" },
                         new Translation() { RowKey = "PurchasedFromTranslation", English = "Purchased From", Lang1 = "Purchased From Lang1", Lang2 = "Purchased From Lang2" },
                         new Translation() { RowKey = "OtherPurchasedFromTranslation", English = "Purchased From", Lang1 = "Purchased From Lang1", Lang2 = "Purchased From Lang2" },

                         new Translation() { RowKey = "AddFeedItemTrans", English = "Add Feed Cost", Lang1 = "Add Feed Cost Lang1", Lang2 = "Add Feed Cost Lang2", },
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

                         //Add HeathCare item Translation
                         new Translation() { RowKey = "HealthCareTitleTranslation", English = "Health Care", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "HealthCareTypeTranslation", English = "Health Care Type", Lang1 = "Health Care Type Lang1", Lang2 = "Health Care Type Lang2" },
                         new Translation() { RowKey = "OtherHealthCareTypeTranslation", English = "Other Health Care Type", Lang1 = "Other Health Care Type Lang 1", Lang2 = "Other Health Care Type Lang2" },
                         new Translation() { RowKey = "HealthCareCostTranslation", English = "Care Cost", Lang1 = "Care Cost", Lang2 = "" },
                         new Translation() { RowKey = "ProviderTranslation", English = "Who provided service", Lang1 = "Who provided service: Lang1", Lang2 = "Who provided service: Lang2" },
                         new Translation() { RowKey = "OtherProviderTranslation", English = "Other provided service", Lang1 = "Other provided service: Lang1", Lang2 = "Other provided service: Lang2" },
                         new Translation() { RowKey = "MedicineCostTranslation", English = "Medicine Cost", Lang1 = "Medicine Cost: Lang1", Lang2 = "Medicine Cost: Lang2" },
                         new Translation() { RowKey = "MedicineTypeTranslation", English = "Medicine Type", Lang1 = "Medicine Type: Lang1", Lang2 = "Medicine Type: Lang2" },
                         new Translation() { RowKey = "OtherMedicineTypeTranslation", English = "Other Medicine Type", Lang1 = "Other Medicine Type: Lang1", Lang2 = "Other Medicine Type: Lang2" },

                         new Translation() { RowKey = "CostTranslation", English = "Any other cost:", Lang1 = "Any other cost: Lang1", Lang2 = "Any other cost: Lang2" },

                         //Labour Costs
                         new Translation() { RowKey = "LabourTitleTranslation", English = "Labour Cost", Lang1 = "Labour Cost Lang1", Lang2 = "Labour Cost Lang2" },
                         new Translation() { RowKey = "LabourTypeTranslation", English = "Labour Type", Lang1 = "Labour Type Lang1", Lang2 = "Labour Type Lang2" },
                         new Translation() { RowKey = "OtherLaboutTypeTranslation", English = "Other LabourType", Lang1 = "Other LabourType Lang1", Lang2 = "Other LabourType Lang2" },
                         new Translation() { RowKey = "AmountPaidTranslation", English = "Amount Paid", Lang1 = "Amount Paid Lang1", Lang2 = "Amount Paid Lang2" },
                         new Translation() { RowKey = "OtherCostsTranslation", English = "Any Other Cost", Lang1 = "Any Other Cost Lang1", Lang2 = "Any Other Cost Lang2" },

                         //Housing Costs
                         new Translation() { RowKey = "HousingTitleTranslation", English = "Animal Housing", Lang1 = "Animal Housing Lang1", Lang2 = "Animal Housing Lang2" },
                         new Translation() { RowKey = "HousingExpenseTranslation", English = "Housing Expense", Lang1 = "Housing Expense Lang1", Lang2 = "Housing Expense Lang2" },
                         new Translation() { RowKey = "OtherHousingExpenseTranslation", English = "Other Housing Expense", Lang1 = "Other Housing Expense Lang1", Lang2 = "Other Housing Expense Lang2" },
                         new Translation() { RowKey = "YearsExpectedTranslation", English = "Expected Housing Lifespan (Years)", Lang1 = "Expected Housing Lifespan (Years)1", Lang2 = "Expected Housing Lifespan (Years)2" },
                         new Translation() { RowKey = "SliderControlTranslation", English = "If new housing built (rather than maintenance) lifespan in years + expected salvage value at end ? ", Lang1 = "If new housing built(rather than maintenance)lifespan in years + expected salvage value at end ? Lang1", Lang2 = "If new housing built(rather than maintenance)lifespan in years + expected salvage value at end ? Lang2" },

                         //Water Costs
                         new Translation() { RowKey = "WaterCostTitleTranslation", English = "Water Cost", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "WaterPurchasedTranslation", English = "Water Purchased", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "OtherWaterPurchasedTranslation", English = "Other unit", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PurchasedWaterFromTranslation", English = "Who Purchased From", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "OtherPurchasedWaterFromTranslation", English = "Purchased From", Lang1 = "", Lang2 = "" },

                         //Membership
                         new Translation() { RowKey = "MembershipTitleTranslation", English = "Co-Operative / Group membership", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "MembershipTypeTranslation", English = "Membership type", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "OtherMembershipTypeTranslation", English = "Other type", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "TimePeriodTranslation", English = "Time-period covered", Lang1 = "", Lang2 = "" },

                         //Other Cost
                         new Translation() { RowKey = "OtherCostTitleTranslation", English = "Other Cost", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "OtherWhatForTranslation", English = "What for", Lang1 = "", Lang2 = "" },

                         //Reproductive
                         new Translation() { RowKey = "ReproductiveTitleTranslation", English = "Reproduction", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "ServiceTypeTranslation", English = "Service type", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "OtherServiceTypeTranslation", English = "Other service type", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "SowsServicedTranslation", English = "Sows Serviced", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "WhoProvidedServiceTranslation", English = "Who Provided Service", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "OtherWhoProvidedServiceTranslation", English = "Who Provided Service", Lang1 = "", Lang2 = "" },

                         //Animal Purchase
                         new Translation() { RowKey = "AnimalPurchaseTitleTranslation", English = "Animal Purchase", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "AnimalTypeTranslation", English = "Animal type", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "OtherAnimalTypeTranslation", English = "Animal type", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "NumberPurchasedTranslation", English = "Number purchased", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "AnimalPurchasedFromTranslation", English = "Purchased from", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "OtherAnimalPurchasedTranslation", English = "Purchased from", Lang1 = "", Lang2 = "" },



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
                         new Translation() { RowKey = "DropDownPurchaseFrom5", English = "Puchase From 5", Lang1 = "Puchase From 5 Lang1", Lang2 = "Puchase From 5 lang 2" },


                         new Translation() { RowKey = "HeathCareType1", English = "Health Care Type 1", Lang1 = "Health Care Type 1 Lang1", Lang2 = "Health Care Type 1 Lang2" },
                         new Translation() { RowKey = "HeathCareType2", English = "Health Care Type 2", Lang1 = "Health Care Type 2 Lang1", Lang2 = "Health Care Type 2 Lang2" },
                         new Translation() { RowKey = "HeathCareType3", English = "Health Care Type 3", Lang1 = "Health Care Type 3 Lang1", Lang2 = "Health Care Type 3 Lang2" },
                         new Translation() { RowKey = "HeathCareType4", English = "Health Care Type 4", Lang1 = "Health Care Type 4 Lang1", Lang2 = "Health Care Type 4 Lang2" },
                         new Translation() { RowKey = "HeathCareType5", English = "Health Care Type 5", Lang1 = "Health Care Type 5 Lang1", Lang2 = "Health Care Type 5 Lang2" },
                         new Translation() { RowKey = "HeathCareType6", English = "Health Care Type 6", Lang1 = "Health Care Type 6 Lang1", Lang2 = "Health Care Type 6 Lang2" },
                         new Translation() { RowKey = "HeathCareType7", English = "Health Care Type 7", Lang1 = "Health Care Type 7 Lang1", Lang2 = "Health Care Type 7 Lang2" },
                         new Translation() { RowKey = "HeathCareType8", English = "Health Care Type 8", Lang1 = "Health Care Type 8 Lang1", Lang2 = "Health Care Type 8 Lang2" },
                         new Translation() { RowKey = "HeathCareType9", English = "Health Care Type 9", Lang1 = "Health Care Type 9 Lang1", Lang2 = "Health Care Type 9 Lang2" },
                         new Translation() { RowKey = "HeathCareType10", English = "Health Care Type 10", Lang1 = "Health Care Type 10 Lang1", Lang2 = "Health Care Type 10 Lang2" },

                         new Translation() { RowKey = "HealthProviderType1", English = "Health Provider Type 1", Lang1 = "Health Provider Type 1 Lang1", Lang2 = "Health Provider Type 1 Lang2" },
                         new Translation() { RowKey = "HealthProviderType2", English = "Health Provider Type 2", Lang1 = "Health Provider Type 2 Lang1", Lang2 = "Health Provider Type 2 Lang2" },
                         new Translation() { RowKey = "HealthProviderType3", English = "Health Provider Type 3", Lang1 = "Health Provider Type 3 Lang1", Lang2 = "Health Provider Type 3 Lang2" },
                         new Translation() { RowKey = "HealthProviderType4", English = "Health Provider Type 4", Lang1 = "Health Provider Type 4 Lang1", Lang2 = "Health Provider Type 4 Lang2" },
                         new Translation() { RowKey = "HealthProviderType5", English = "Health Provider Type 5", Lang1 = "Health Provider Type 5 Lang1", Lang2 = "Health Provider Type 5 Lang2" },
                         new Translation() { RowKey = "HealthProviderType6", English = "Health Provider Type 6", Lang1 = "Health Provider Type 6 Lang1", Lang2 = "Health Provider Type 6 Lang2" },
                         new Translation() { RowKey = "HealthProviderType7", English = "Health Provider Type 7", Lang1 = "Health Provider Type 7 Lang1", Lang2 = "Health Provider Type 7 Lang2" },
                         new Translation() { RowKey = "HealthProviderType8", English = "Health Provider Type 8", Lang1 = "Health Provider Type 8 Lang1", Lang2 = "Health Provider Type 8 Lang2" },
                         new Translation() { RowKey = "HealthProviderType9", English = "Health Provider Type 9", Lang1 = "Health Provider Type 9 Lang1", Lang2 = "Health Provider Type 9 Lang2" },
                         new Translation() { RowKey = "HealthProviderType10", English = "Health Provider Type 10", Lang1 = "Health Provider Type 10 Lang1", Lang2 = "Health Provider Type 10 Lang2" },

                         new Translation() { RowKey = "MedicineType1", English = "Medicine Type 1", Lang1 = "Medicine Type 1 Lang1", Lang2 = "Medicine Type 1 Lang2" },
                         new Translation() { RowKey = "MedicineType2", English = "Medicine Type 2", Lang1 = "Medicine Type 2 Lang1", Lang2 = "Medicine Type 2 Lang2" },
                         new Translation() { RowKey = "MedicineType3", English = "Medicine Type 3", Lang1 = "Medicine Type 3 Lang1", Lang2 = "Medicine Type 3 Lang2" },
                         new Translation() { RowKey = "MedicineType4", English = "Medicine Type 4", Lang1 = "Medicine Type 4 Lang1", Lang2 = "Medicine Type 4 Lang2" },
                         new Translation() { RowKey = "MedicineType5", English = "Medicine Type 5", Lang1 = "Medicine Type 5 Lang1", Lang2 = "Medicine Type 5 Lang2" },
                         new Translation() { RowKey = "MedicineType6", English = "Medicine Type 6", Lang1 = "Medicine Type 6 Lang1", Lang2 = "Medicine Type 6 Lang2" },
                         new Translation() { RowKey = "MedicineType7", English = "Medicine Type 7", Lang1 = "Medicine Type 7 Lang1", Lang2 = "Medicine Type 7 Lang2" },
                         new Translation() { RowKey = "MedicineType8", English = "Medicine Type 8", Lang1 = "Medicine Type 8 Lang1", Lang2 = "Medicine Type 8 Lang2" },
                         new Translation() { RowKey = "MedicineType9", English = "Medicine Type 9", Lang1 = "Medicine Type 9 Lang1", Lang2 = "Medicine Type 9 Lang2" },
                         new Translation() { RowKey = "MedicineType10", English = "Medicine Type 10", Lang1 = "Medicine Type 10 Lang1", Lang2 = "Medicine Type 10 Lang2" },

                         new Translation() { RowKey = "PruchaseFromType1", English = "Purchase From Type 1", Lang1 = "Purchase From Type 1 Lang1", Lang2 = "Purchase From Type 1 Lang2" },
                         new Translation() { RowKey = "PruchaseFromType2", English = "Purchase From Type 2", Lang1 = "Purchase From Type 2 Lang1", Lang2 = "Purchase From Type 2 Lang2" },
                         new Translation() { RowKey = "PruchaseFromType3", English = "Purchase From Type 3", Lang1 = "Purchase From Type 3 Lang1", Lang2 = "Purchase From Type 3 Lang2" },
                         new Translation() { RowKey = "PruchaseFromType4", English = "Purchase From Type 4", Lang1 = "Purchase From Type 4 Lang1", Lang2 = "Purchase From Type 4 Lang2" },
                         new Translation() { RowKey = "PruchaseFromType5", English = "Purchase From Type 5", Lang1 = "Purchase From Type 5 Lang1", Lang2 = "Purchase From Type 5 Lang2" },
                         new Translation() { RowKey = "PruchaseFromType6", English = "Purchase From Type 6", Lang1 = "Purchase From Type 6 Lang1", Lang2 = "Purchase From Type 6 Lang2" },
                         new Translation() { RowKey = "PruchaseFromType7", English = "Purchase From Type 7", Lang1 = "Purchase From Type 7 Lang1", Lang2 = "Purchase From Type 7 Lang2" },
                         new Translation() { RowKey = "PruchaseFromType8", English = "Purchase From Type 8", Lang1 = "Purchase From Type 8 Lang1", Lang2 = "Purchase From Type 8 Lang2" },
                         new Translation() { RowKey = "PruchaseFromType9", English = "Purchase From Type 9", Lang1 = "Purchase From Type 9 Lang1", Lang2 = "Purchase From Type 9 Lang2" },
                         new Translation() { RowKey = "PruchaseFromType10", English = "Purchase From Type 10", Lang1 = "Purchase From Type 10 Lang1", Lang2 = "Purchase From Type 10 Lang2" },

                         new Translation() { RowKey = "LabourType1", English = "Labour Type 1", Lang1 = "Labour Type 1 Lang1", Lang2 = "Labour Type 1 Lang2" },
                         new Translation() { RowKey = "LabourType2", English = "Labour Type 2", Lang1 = "Labour Type 2 Lang1", Lang2 = "Labour Type 2 Lang2" },
                         new Translation() { RowKey = "LabourType3", English = "Labour Type 3", Lang1 = "Labour Type 3 Lang1", Lang2 = "Labour Type 3 Lang2" },
                         new Translation() { RowKey = "LabourType4", English = "Labour Type 4", Lang1 = "Labour Type 4 Lang1", Lang2 = "Labour Type 4 Lang2" },
                         new Translation() { RowKey = "LabourType5", English = "Labour Type 5", Lang1 = "Labour Type 5 Lang1", Lang2 = "Labour Type 5 Lang2" },
                         new Translation() { RowKey = "LabourType6", English = "Labour Type 6", Lang1 = "Labour Type 6 Lang1", Lang2 = "Labour Type 6 Lang2" },

                         new Translation() { RowKey = "HousingExpenseType1", English = "Housing Expense Type 1", Lang1 = "Housing Expense Type 1 Lang1", Lang2 = "Housing Expense Type 1 Lang2" },
                         new Translation() { RowKey = "HousingExpenseType2", English = "Housing Expense Type 2", Lang1 = "Housing Expense Type 2 Lang1", Lang2 = "Housing Expense Type 2 Lang2" },
                         new Translation() { RowKey = "HousingExpenseType3", English = "Housing Expense Type 3", Lang1 = "Housing Expense Type 3 Lang1", Lang2 = "Housing Expense Type 3 Lang2" },
                         new Translation() { RowKey = "HousingExpenseType4", English = "Housing Expense Type 4", Lang1 = "Housing Expense Type 4 Lang1", Lang2 = "Housing Expense Type 4 Lang2" },
                         new Translation() { RowKey = "HousingExpenseType5", English = "Housing Expense Type 5", Lang1 = "Housing Expense Type 5 Lang1", Lang2 = "Housing Expense Type 5 Lang2" },

                         new Translation() { RowKey = "WaterPurchasedUnitType1", English = "Unit 1", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "WaterPurchasedUnitType2", English = "Unit 2", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "WaterPurchasedUnitType3", English = "Unit 3", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "WaterPurchasedUnitType4", English = "Unit 4", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "WaterPurchasedUnitType5", English = "Unit 5", Lang1 = "", Lang2 = "" },

                         new Translation() { RowKey = "PurchasedWaterFromType1", English = "Purchased From 1", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PurchasedWaterFromType2", English = "Purchased From 2", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PurchasedWaterFromType3", English = "Purchased From 3", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PurchasedWaterFromType4", English = "Purchased From 4", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PurchasedWaterFromType5", English = "Purchased From 5", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PurchasedWaterFromType6", English = "Purchased From 6", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PurchasedWaterFromType7", English = "Purchased From 7", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PurchasedWaterFromType8", English = "Purchased From 8", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PurchasedWaterFromType9", English = "Purchased From 9", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PurchasedWaterFromType10", English = "Purchased From 10", Lang1 = "", Lang2 = "" },

                         new Translation() { RowKey = "MembershipType1", English = "Type 1", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "MembershipType2", English = "Type 2", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "MembershipType3", English = "Type 3", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "MembershipType4", English = "Type 4", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "MembershipType5", English = "Type 5", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "MembershipType6", English = "Type 6", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "MembershipType7", English = "Type 7", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "MembershipType8", English = "Type 8", Lang1 = "", Lang2 = "" },

                         new Translation() { RowKey = "TimePeriodUnitType1", English = "Weeks", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "TimePeriodUnitType2", English = "Months", Lang1 = "", Lang2 = "" },

                         new Translation() { RowKey = "ServiceType1", English = "Type 1", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "ServiceType2", English = "Type 2", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "ServiceType3", English = "Type 3", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "ServiceType4", English = "Type 4", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "ServiceType5", English = "Type 5", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "ServiceType6", English = "Type 6", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "ServiceType7", English = "Type 7", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "ServiceType8", English = "Type 8", Lang1 = "", Lang2 = "" },

                         new Translation() { RowKey = "WhoProvidedServiceType1", English = "Type 1", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "WhoProvidedServiceType2", English = "Type 2", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "WhoProvidedServiceType3", English = "Type 3", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "WhoProvidedServiceType4", English = "Type 4", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "WhoProvidedServiceType5", English = "Type 5", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "WhoProvidedServiceType6", English = "Type 6", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "WhoProvidedServiceType7", English = "Type 7", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "WhoProvidedServiceType8", English = "Type 8", Lang1 = "", Lang2 = "" },

                         new Translation() { RowKey = "AnimalType1", English = "Type 1", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "AnimalType2", English = "Type 2", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "AnimalType3", English = "Type 3", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "AnimalType4", English = "Type 4", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "AnimalType5", English = "Type 5", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "AnimalType6", English = "Type 6", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "AnimalType7", English = "Type 7", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "AnimalType8", English = "Type 8", Lang1 = "", Lang2 = "" },

                         new Translation() { RowKey = "AnimalPurchasedFromType1", English = "Type 1", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "AnimalPurchasedFromType2", English = "Type 2", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "AnimalPurchasedFromType3", English = "Type 3", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "AnimalPurchasedFromType4", English = "Type 4", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "AnimalPurchasedFromType5", English = "Type 5", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "AnimalPurchasedFromType6", English = "Type 6", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "AnimalPurchasedFromType7", English = "Type 7", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "AnimalPurchasedFromType8", English = "Type 8", Lang1 = "", Lang2 = "" }


                         );
                 }
             );

            modelBuilder.Entity<ControlData>(async x =>
                {
                    x.HasData(
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 1, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType1" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 2, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType2" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 3, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType3" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 4, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType4" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 5, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType5" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 6, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 7, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDAMOUNTPURCHASEDUNITTYPE, TranslationRowKey = "DropDownUnitType1" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 8, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDAMOUNTPURCHASEDUNITTYPE, TranslationRowKey = "DropDownUnitType2" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 9, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDAMOUNTPURCHASEDUNITTYPE, TranslationRowKey = "DropDownUnitType3" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 10, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDAMOUNTPURCHASEDUNITTYPE, TranslationRowKey = "DropDownUnitType4" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 11, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDAMOUNTPURCHASEDUNITTYPE, TranslationRowKey = "DropDownUnitType5" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 12, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDAMOUNTPURCHASEDUNITTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 13, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDPURCHASEDFROMTYPE, TranslationRowKey = "DropDownPurchaseFrom1" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 14, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDPURCHASEDFROMTYPE, TranslationRowKey = "DropDownPurchaseFrom2" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 15, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDPURCHASEDFROMTYPE, TranslationRowKey = "DropDownPurchaseFrom3" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 16, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDPURCHASEDFROMTYPE, TranslationRowKey = "DropDownPurchaseFrom4" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 17, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDPURCHASEDFROMTYPE, TranslationRowKey = "DropDownPurchaseFrom5" },

                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 18, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType1" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 19, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType2" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 20, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType3" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 21, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType4" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 22, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType5" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 23, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType6" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 24, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType7" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 25, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType8" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 26, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType9" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 27, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType10" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 28, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 29, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType1" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 30, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType2" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 31, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType3" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 32, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType4" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 33, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType5" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 34, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType6" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 35, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType7" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 36, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType8" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 37, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType9" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 38, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType10" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 39, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = Constants.OTHER },

                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 40, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType1" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 41, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType2" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 42, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType3" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 43, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType4" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 44, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType5" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 45, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType6" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 46, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType7" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 47, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType8" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 48, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType9" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 49, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType10" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 50, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 51, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType1" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 52, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType2" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 53, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType3" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 54, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType4" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 55, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType5" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 56, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType6" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 57, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType7" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 58, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType8" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 59, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType9" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 60, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType10" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 61, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 62, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LABOURTYPE, TranslationRowKey = "LabourType1" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 63, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LABOURTYPE, TranslationRowKey = "LabourType2" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 64, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LABOURTYPE, TranslationRowKey = "LabourType3" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 65, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LABOURTYPE, TranslationRowKey = "LabourType4" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 66, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LABOURTYPE, TranslationRowKey = "LabourType5" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 67, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LABOURTYPE, TranslationRowKey = "LabourType6" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 68, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LABOURTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 69, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HOUSINGTYPE, TranslationRowKey = "HousingExpenseType1" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 70, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HOUSINGTYPE, TranslationRowKey = "HousingExpenseType2" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 71, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HOUSINGTYPE, TranslationRowKey = "HousingExpenseType3" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 72, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HOUSINGTYPE, TranslationRowKey = "HousingExpenseType4" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 73, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HOUSINGTYPE, TranslationRowKey = "HousingExpenseType5" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 74, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HOUSINGTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 75, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WATERPURCHASEDUNITTYPE, TranslationRowKey = "WaterPurchasedUnitType1" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 76, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WATERPURCHASEDUNITTYPE, TranslationRowKey = "WaterPurchasedUnitType2" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 77, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WATERPURCHASEDUNITTYPE, TranslationRowKey = "WaterPurchasedUnitType3" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 78, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WATERPURCHASEDUNITTYPE, TranslationRowKey = "WaterPurchasedUnitType4" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 79, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WATERPURCHASEDUNITTYPE, TranslationRowKey = "WaterPurchasedUnitType5" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 80, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WATERPURCHASEDUNITTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 81, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType1" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 82, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType2" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 83, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType3" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 84, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType4" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 85, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType5" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 86, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType6" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 87, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType7" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 88, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType8" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 89, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType9" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 90, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType10" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 91, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 92, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = "MembershipType1" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 93, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = "MembershipType2" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 94, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = "MembershipType3" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 95, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = "MembershipType4" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 96, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = "MembershipType5" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 97, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = "MembershipType6" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 98, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = "MembershipType7" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 99, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = "MembershipType8" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 100, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 101, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.TIMEPERIODUNITTYPE, TranslationRowKey = "TimePeriodUnitType1" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 102, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.TIMEPERIODUNITTYPE, TranslationRowKey = "TimePeriodUnitType2" },

                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 103, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = "ServiceType1" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 104, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = "ServiceType2" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 105, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = "ServiceType3" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 106, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = "ServiceType4" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 107, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = "ServiceType5" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 108, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = "ServiceType6" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 109, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = "ServiceType7" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 110, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = "ServiceType8" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 111, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 112, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType1" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 113, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType2" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 114, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType3" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 115, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType4" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 116, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType5" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 117, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType6" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 118, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType7" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 119, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType8" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 120, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 121, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType1" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 122, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType2" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 123, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType3" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 124, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType4" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 125, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType5" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 126, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType6" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 127, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType7" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 128, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType8" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 129, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 130, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType1" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 131, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType2" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 132, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType3" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 133, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType4" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 134, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType5" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 135, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType6" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 136, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType7" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 137, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType8" },
                       new ControlData() { RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", Id = 138, CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = Constants.OTHER }
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
                    new UserInfo()
                    {
                        LastUploadDate = DateTime.Now,
                        UserName = "Marty",
                        Village = "Dunedin",
                        Name = "Marty Haigh",
                        County = "New Zealand",
                        District = "Otago",
                        Email = "Email@email.com",
                        UserLang = UserLangSettings.Eng,
                        RowKey = Guid.NewGuid().ToString(),
                        PartitionKey = "User",
                        Timestamp = DateTime.UtcNow
                    }
                );
            }
           );


        }

    }
}
