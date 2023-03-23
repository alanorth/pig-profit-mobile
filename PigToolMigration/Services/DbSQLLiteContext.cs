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
            /*
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
                    new Translation() { RowKey = "FilterTranslation", English = "Filter by:", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "RegistrationTranslation", English = "Registration", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "UploadDataTranslation", English = "Upload", Lang1 = "", Lang2 = "" },

                    new Translation() { RowKey = "Costs", English = "Costs", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                    new Translation() { RowKey = "Feed", English = "Feed", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                    new Translation() { RowKey = "Healthcare", English = "Healthcare", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                    new Translation() { RowKey = "Labour", English = "Labour", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                    new Translation() { RowKey = "Housing", English = "Housing", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                    new Translation() { RowKey = "Water", English = "Water", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                    new Translation() { RowKey = "Reproduction", English = "Reproduction", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                    new Translation() { RowKey = "Membership", English = "Co-Operative / Group membership", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                    new Translation() { RowKey = Constants.OTHER, English = "Other, specify", Lang1 = "Other, specify Lang1", Lang2 = "Other, specify Lang2" },
                    new Translation() { RowKey = "OtherCostEvent", English = "Other", Lang1 = "Other", Lang2 = "Other" },
                    new Translation() { RowKey = "AnimalPurchase", English = "Animal Purchase", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                    new Translation() { RowKey = "LoanRepayment", English = "Loan Repayment", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                    new Translation() { RowKey = "Income", English = "Income", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                    new Translation() { RowKey = "PigSale", English = "Sale of Pigs", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                    new Translation() { RowKey = "BreedingServiceSale", English = "Sale of breeding services", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                    new Translation() { RowKey = "ManureSale", English = "Sale of manure", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                    new Translation() { RowKey = "OtherIncome", English = "Other Income", Lang1 = "Home Lang1", Lang2 = "Home Lang2" },
                    new Translation() { RowKey = "Equipment", English = "Equipment", Lang1 = "Equipment Lang1", Lang2 = "Equipment Lang2" },

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

                         new Translation() { RowKey = "StartTranslation", English = "Start", Lang1 = "Start Lang1", Lang2 = "Start Lang2" },
                         new Translation() { RowKey = "FinishTranslation", English = "Finish", Lang1 = "Finish Lang1", Lang2 = "Finish Lang2" },

                    //Add Feed Item Translations
                    new Translation() { RowKey = "FeedItemTitleTranslation", English = "Feed", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "FeedTypeTranslation", English = "Feed Type", Lang1 = "Feed Type Lang1", Lang2 = "Feed Type Lang2" },
                    new Translation() { RowKey = "OtherFeedTypeTranslation", English = "Other Feed Type", Lang1 = "Other Feed Type Lang1", Lang2 = "Other Feed Type Lang2" },
                    new Translation() { RowKey = "AmountPurchasedTranslation", English = "Amount Purchased", Lang1 = "Amount Purchased Lang1", Lang2 = "Amount Purchased Lang2" },
                    new Translation() { RowKey = "AmountPurchasedUnitTranslation", English = "Amount Purchased", Lang1 = "Amount Purchased Lang1", Lang2 = "Amount Purchased Lang2" },
                    new Translation() { RowKey = "OtherAmountPurchasedUnitTranslation", English = "Other Amount Purchased", Lang1 = "Other Amount Purchased Lang1", Lang2 = "Other Amount Purchased Lang2" },
                    new Translation() { RowKey = "PurchasedFromTranslation", English = "Purchased From", Lang1 = "Purchased From Lang1", Lang2 = "Purchased From Lang2" },
                    new Translation() { RowKey = "OtherPurchasedFromTranslation", English = "Other Purchased From", Lang1 = "Purchased From Lang1", Lang2 = "Purchased From Lang2" },

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

                    new Translation() { RowKey = "FeedDurationTranslation", English = "Feed use duration", Lang1 = "Duration Lang1", Lang2 = "Duration Lang2" },

                    //Add HeathCare item Translation
                    new Translation() { RowKey = "HealthCareTitleTranslation", English = "Healthcare", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "HealthCareTypeTranslation", English = "Health Care Type", Lang1 = "Health Care Type Lang1", Lang2 = "Health Care Type Lang2" },
                    new Translation() { RowKey = "OtherHealthCareTypeTranslation", English = "Other Health Care Type", Lang1 = "Other Health Care Type Lang 1", Lang2 = "Other Health Care Type Lang2" },
                    new Translation() { RowKey = "HealthCareCostTranslation", English = "Service Provider Cost", Lang1 = "Service Provider Cost Lang1", Lang2 = "Service Provider Cost Lang2" },
                    new Translation() { RowKey = "ProviderTranslation", English = "Who provided service", Lang1 = "Who provided service: Lang1", Lang2 = "Who provided service: Lang2" },
                    new Translation() { RowKey = "OtherProviderTranslation", English = "Other provided service", Lang1 = "Other provided service: Lang1", Lang2 = "Other provided service: Lang2" },
                    new Translation() { RowKey = "MedicineCostTranslation", English = "Medicine Cost", Lang1 = "Medicine Cost: Lang1", Lang2 = "Medicine Cost: Lang2" },
                    new Translation() { RowKey = "MedicineTypeTranslation", English = "Medicine Type", Lang1 = "Medicine Type: Lang1", Lang2 = "Medicine Type: Lang2" },
                    new Translation() { RowKey = "OtherMedicineTypeTranslation", English = "Other Medicine Type", Lang1 = "Other Medicine Type: Lang1", Lang2 = "Other Medicine Type: Lang2" },

                    new Translation() { RowKey = "CostTranslation", English = "Any other cost:", Lang1 = "Any other cost: Lang1", Lang2 = "Any other cost: Lang2" },

                    //Labour Costs
                    new Translation() { RowKey = "LabourTitleTranslation", English = "Labour", Lang1 = "Labour Cost Lang1", Lang2 = "Labour Cost Lang2" },
                    new Translation() { RowKey = "LabourTypeTranslation", English = "Labour Type", Lang1 = "Labour Type Lang1", Lang2 = "Labour Type Lang2" },
                    new Translation() { RowKey = "OtherLaboutTypeTranslation", English = "Other LabourType", Lang1 = "Other LabourType Lang1", Lang2 = "Other LabourType Lang2" },
                    new Translation() { RowKey = "AmountPaidTranslation", English = "Amount paid over the labour use duration", Lang1 = "Amount paid over the labour use duration Lang1", Lang2 = "Amount paid over the labour use duration Lang2" },
                    new Translation() { RowKey = "OtherCostsTranslation", English = "Any Other Cost", Lang1 = "Any Other Cost Lang1", Lang2 = "Any Other Cost Lang2" },
                    new Translation() { RowKey = "LabourDurationTranslation", English = "Labour use duration", Lang1 = "Duration Lang1", Lang2 = "Duration Lang2" },

                    //Housing Costs
                    new Translation() { RowKey = "HousingTitleTranslation", English = "Housing", Lang1 = "Animal Housing Lang1", Lang2 = "Animal Housing Lang2" },
                    new Translation() { RowKey = "HousingExpenseTranslation", English = "Housing Expense", Lang1 = "Housing Expense Lang1", Lang2 = "Housing Expense Lang2" },
                    new Translation() { RowKey = "OtherHousingExpenseTranslation", English = "Other Housing Expense", Lang1 = "Other Housing Expense Lang1", Lang2 = "Other Housing Expense Lang2" },
                    new Translation() { RowKey = "YearsExpectedTranslation", English = "Expected Housing Lifespan (Years)", Lang1 = "Expected Housing Lifespan (Years)1", Lang2 = "Expected Housing Lifespan (Years)2" },
                    new Translation() { RowKey = "SliderControlTranslation", English = "If new housing built (rather than maintenance) lifespan in years + expected salvage value at end ? ", Lang1 = "If new housing built(rather than maintenance)lifespan in years + expected salvage value at end ? Lang1", Lang2 = "If new housing built(rather than maintenance)lifespan in years + expected salvage value at end ? Lang2" },

                    //Water Costs
                    new Translation() { RowKey = "WatherDurationTranslation", English = "Water Use Duration", Lang1 = "Water Use Duration Lang1", Lang2 = "Water Use Duration Lang2" },
                    new Translation() { RowKey = "WaterCostTitleTranslation", English = "Water", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "WaterPurchasedTranslation", English = "Water Purchased", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "OtherWaterPurchasedTranslation", English = "Other unit", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PurchasedWaterFromTranslation", English = "Who Purchased From", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "OtherPurchasedWaterFromTranslation", English = "Purchased From", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "WaterDurationTranslation", English = "Water use duration", Lang1 = "Duration Lang1", Lang2 = "Duration Lang2" },

                    //Membership
                    new Translation() { RowKey = "MembershipTitleTranslation", English = "Co-Operative / Group membership", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "MembershipTypeTranslation", English = "Membership type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "OtherMembershipTypeTranslation", English = "Other type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "TimePeriodTranslation", English = "Time-period covered", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "MembershipDurationTranslation", English = "Membership duration", Lang1 = "Duration Lang1", Lang2 = "Duration Lang2" },

                    //Other Cost
                    new Translation() { RowKey = "OtherCostTitleTranslation", English = "Other", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "OtherWhatForTranslation", English = "What for", Lang1 = "", Lang2 = "" },

                    //Reproductive
                    new Translation() { RowKey = "ReproductiveTitleTranslation", English = "Reproduction", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "ServiceTypeTranslation", English = "Service type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "OtherServiceTypeTranslation", English = "Other service type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "SowsServicedCostTranslation", English = "Total Service Cost", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "WhoProvidedServiceTranslation", English = "Who Provided Service", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "OtherWhoProvidedServiceTranslation", English = "Who Provided Service", Lang1 = "", Lang2 = "" },

                    //Animal Purchase
                    new Translation() { RowKey = "AnimalPurchaseTitleTranslation", English = "Animal Purchase", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "AnimalTypeTranslation", English = "Animal type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "OtherAnimalTypeTranslation", English = "Animal type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "NumberPurchasedTranslation", English = "Number purchased", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "AnimalPurchasedFromTranslation", English = "Purchased from", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "OtherAnimalPurchasedTranslation", English = "Other Purchased from", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "TotalAnimalCostsTranslation", English = "Total cost for all animals", Lang1 = "", Lang2 = "" },

                    //Loan Repayment
                    new Translation() { RowKey = "LoanRepaymentTitleTranslation", English = "Loan Repayment", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "LoanProviderTranslation", English = "Loan Provider", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "OtherLoanProviderTranslation", English = "Other Loan Provider", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "TotalAmountRepaidTranslation", English = "Total Amount Paid", Lang1 = "", Lang2 = "" },

                    //Equipment
                    new Translation() { RowKey = "EquipmentTitleTranslation", English = "Equipment", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "EquipmentTypeTranslation", English = "Equipment Type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "OtherEquipmentTypeTranslation", English = "Other Equipment Type", Lang1 = "", Lang2 = "" },

                    //Pig Sale
                    new Translation() { RowKey = "PigSaleTitleTranslation", English = "Pig Sales", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PigTypeTranslation", English = "Pig type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "OtherPigTypeTranslation", English = "Other Pig Type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "NumberSoldTranslation", English = "Number Sold", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "SalePriceTranslation", English = "Sale Price", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "SoldToTranslation", English = "Sold To", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "OtherSoldToTranslation", English = "Other Sold To", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "BrokerageTranslation", English = "Brokerage", Lang1 = "", Lang2 = "" },

                    //Breeding Service Sale
                    new Translation() { RowKey = "BreedingServiceSaleTitleTranslation", English = "Sale of Reproductive Services", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "NumberServicesTranslation", English = "Number Services", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "AmountRecievedTranslation", English = "Amount recieved for all services", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "AnyOtherPaymentTranslation", English = "Any Other Payment Recieved", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PaymentTypeTranslation", English = "Type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PaymentValueTranslation", English = "Value", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "ClientTranslation", English = "Client", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "OtherClientTranslation", English = "Other Client", Lang1 = "", Lang2 = "" },

                    //Manure Sale
                    new Translation() { RowKey = "ManureSaleTitleTranslation", English = "Sale of Manure", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "VolumeSoldTranslation", English = "Volume Sold", Lang1 = "", Lang2 = "" },

                    // Other Income
                    new Translation() { RowKey = "OtherIncomeTitleTranslation", English = "Other Income", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "TotalIncomeTranslation", English = "Total Income", Lang1 = "", Lang2 = "" },

                    // Registration
                    new Translation() { RowKey = "RegistrationTitleTranslation", English = "Registration", Lang1 = "Registration Lang 1", Lang2 = "" },
                    new Translation() { RowKey = "UserNameTranslation", English = "Username", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "NameTranslation", English = "Name", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "EmailTranslation", English = "Email", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PhoneNumberTranslation", English = "Phone Number", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "DistrictTranslation", English = "District", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CountyTranslation", English = "County", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "SubCountyTranslation", English = "Sub County", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "ParishTranslation", English = "Parish", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "VillageTranslation", English = "Village", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CountryTranslation", English = "Country", Lang1 = "", Lang2 = "" },

                    new Translation() { RowKey = "ProvinceTranslation", English = "Province", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CommuneTranslation", English = "Commune", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "SectorTranslation", English = "Sector", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CellTranslation", English = "Cell", Lang1 = "", Lang2 = "" },

                    new Translation() { RowKey = "CurrencyTranslation", English = "Currency", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "GenderTranslation", English = "Gender", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "LanguageTranslation", English = "Language", Lang1 = "", Lang2 = "" },

                    // Other Registration Process
                    new Translation() { RowKey = "WhereAreYouLocatedTranslation", English = "Where Are You Located?", Lang1 = "Located Lang 1", Lang2 = "" },
                    new Translation() { RowKey = "LegalDisclaimerTitleTranslation", English = "Legal Disclaimer", Lang1 = "Legal Lang 1", Lang2 = "" },
                    new Translation() { RowKey = "LegalDisclaimerAgreeTranslation", English = "By checking this box you agree to the terms listed above", Lang1 = "Legal check 1", Lang2 = "" },
                    new Translation() { RowKey = "LegalDisclaimerProceedTranslation", English = "Proceed", Lang1 = "Proceed Lang 1", Lang2 = "" },
                    new Translation()
                    {
                        RowKey = "LegalDisclaimerBodyTranslation",
                        English = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Lang1 = "Legal body Lang 1",
                        Lang2 = ""
                    },
                    new Translation() { RowKey = "WebAuthTitleTranslation", English = "Sign Up", Lang1 = "Sign Up Lang 1", Lang2 = "" },
                    new Translation()
                    {
                        RowKey = "WebAuthDescTranslation",
                        English = "The Pig Economic Tool authenticates with Google to securely authenticate your account and keep your data safe.",
                        Lang1 = "Desc Lang 1",
                        Lang2 = ""
                    },
                    new Translation() { RowKey = "GoogleSignUpTranslation", English = "Sign up with Google", Lang1 = "Google Lang 1", Lang2 = "" },
                    new Translation() { RowKey = "RegistrationSuccessfulTitleTranslation", English = "Your Account Has Been Created", Lang1 = "Account Created Lang 1", Lang2 = "" },
                    new Translation() { RowKey = "RegistrationSuccessfulDescTranslation", English = "You can now begin collecting and storing your data", Lang1 = "Begin Lang 1", Lang2 = "" },
                    new Translation() { RowKey = "RegistrationSuccessfulContinueTranslation", English = "Continue", Lang1 = "Continue Lang 1", Lang2 = "" },

                    // PickerTitles
                    new Translation() { RowKey = "PickerUnitTranslation", English = "Unit", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerFeedTypeTranslation", English = "Select a Feed Type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerPurchasedFromTranslation", English = "Select a Provider", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerHealthCareTypeTranslation", English = "Select a Care Type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerProviderTranslation", English = "Select a Provider", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerMedicineTypeTranslation", English = "Select a Medicine Type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerLabourTypeTranslation", English = "Select a Labour Type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerHousingExpenseTranslation", English = "Select an Expense", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerServiceTypeTranslation", English = "Select a Service Type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerMembershipTypeTranslation", English = "Select a Membership", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerAnimalTypeTranslation", English = "Select a Animal Type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerEquipmentTypeTranslation", English = "Select an Equipment Type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerPigTypeTranslation", English = "Select a Pig Type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerSoldToTranslation", English = "Select a Buyer", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerPaymentTypeTranslation", English = "Select a Payment Type", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerClientTranslation", English = "Select a Client", Lang1 = "", Lang2 = "" },

                    new Translation() { RowKey = "PickerGenderTranslation", English = "Select a Gender", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerDistrictTranslation", English = "Select a District", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerCountyTranslation", English = "Select a County", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerSubCountyTranslation", English = "Select a Sub County", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerCountryTranslation", English = "Select a Country", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "PickerCurrencyTranslation", English = "Select a Currency", Lang1 = "", Lang2 = "" },


                   //Drop Down Options
                   new Translation() { RowKey = "DropDownFeedType1", English = "Maize Bran", Lang1 = "Maize Bran Lang1", Lang2 = "Maize Bran Lang2" },
                   new Translation() { RowKey = "DropDownFeedType2", English = "Wheat Bran", Lang1 = "Wheat Bran Lang1", Lang2 = "Wheat Bran Lang2" },
                   new Translation() { RowKey = "DropDownFeedType3", English = "Maize Germ", Lang1 = "Maize Germ Lang1", Lang2 = "Maize Germ Lang2" },
                   new Translation() { RowKey = "DropDownFeedType4", English = "Rice Bran", Lang1 = "Rice Bran Lang1", Lang2 = "Rice Bran Lang2" },
                   new Translation() { RowKey = "DropDownFeedType5", English = "Maize Gluten Feed", Lang1 = "Maize Gluten Feed Lang1", Lang2 = "Maize Gluten Feed Lang2" },
                   new Translation() { RowKey = "DropDownFeedType6", English = "Wheat Gluten Feed", Lang1 = "Wheat Gluten Feed Lang1", Lang2 = "Wheat Gluten Feed Lang2" },
                   new Translation() { RowKey = "DropDownFeedType7", English = "Dried Brewers’ Grain", Lang1 = "Dried Brewers’ Grain Lang1", Lang2 = "Dried Brewers’ Grain Lang2" },
                   new Translation() { RowKey = "DropDownFeedType8", English = "Ground Maize", Lang1 = "Ground Maize Lang1", Lang2 = "Ground Maize Lang2" },
                   new Translation() { RowKey = "DropDownFeedType9", English = "Soybean Seed Cake", Lang1 = "Soybean Seed Cake Lang1", Lang2 = "Soybean Seed Cake Lang2" },
                   new Translation() { RowKey = "DropDownFeedType10", English = "Soybean Meal", Lang1 = "Soybean Meal Lang1", Lang2 = "Soybean Meal Lang2" },
                   new Translation() { RowKey = "DropDownFeedType11", English = "Sunflower Cake", Lang1 = "Sunflower Cake Lang1", Lang2 = "Sunflower Cake Lang2" },
                   new Translation() { RowKey = "DropDownFeedType12", English = "Cotton Seed Cake", Lang1 = "Cotton Seed Cake Lang1", Lang2 = "Cotton Seed Cake Lang2" },
                   new Translation() { RowKey = "DropDownFeedType13", English = "Groundnut Cake", Lang1 = "Groundnut Cake Lang1", Lang2 = "Groundnut Cake Lang2" },
                   new Translation() { RowKey = "DropDownFeedType14", English = "Compounded Feeds (Labelled Feeds)", Lang1 = "Compounded Feeds (Labelled Feeds) Lang1", Lang2 = "Compounded Feeds (Labelled Feeds) Lang2" },
                   new Translation() { RowKey = "DropDownFeedType15", English = "Compounded Feeds (Non-Labelled Feeds)", Lang1 = "Compounded Feeds (Non-Labelled Feeds) Lang1", Lang2 = "Compounded Feeds (Non-Labelled Feeds) Lang2" },
                   new Translation() { RowKey = "DropDownFeedType16", English = "Minerals", Lang1 = "Minerals Lang1", Lang2 = "Minerals Lang2" },
                   new Translation() { RowKey = "DropDownFeedType17", English = "Vitamins", Lang1 = "Vitamins Lang1", Lang2 = "Vitamins Lang2" },
                   new Translation() { RowKey = "DropDownFeedType18", English = "Pre-Mixes", Lang1 = "Pre-Mixes Lang1", Lang2 = "Pre-Mixes Lang2" },
                   new Translation() { RowKey = "DropDownFeedType19", English = "Silage", Lang1 = "Silage Lang1", Lang2 = "Silage Lang2" },

                   new Translation() { RowKey = "DropDownUnitType1", English = "Kg", Lang1 = "Kg Lang1", Lang2 = "Kg Lang2" },
                   new Translation() { RowKey = "DropDownUnitType3", English = "gram", Lang1 = "Kg Lang1", Lang2 = "Kg Lang2" },
                   new Translation() { RowKey = "DropDownUnitType2", English = "Number", Lang1 = "Number Lang1", Lang2 = "Number Lang2" },

                   new Translation() { RowKey = "DropDownPurchaseFrom1", English = "Feed supplier", Lang1 = "Feed supplier Lang1", Lang2 = "Feed supplier Lang2" },
                   new Translation() { RowKey = "DropDownPurchaseFrom2", English = "Agro-vet", Lang1 = "Agro-vet Lang1", Lang2 = "Agro-vet Lang2" },
                   new Translation() { RowKey = "DropDownPurchaseFrom3", English = "Another farmer", Lang1 = "Another farmer Lang1", Lang2 = "Another farmer Lang2" },
                   new Translation() { RowKey = "DropDownPurchaseFrom4", English = "Transporter", Lang1 = "Transporter Lang1", Lang2 = "Transporter Lang2" },

                   new Translation() { RowKey = "HeathCareType1", English = "Curative (treatment of a disease)", Lang1 = "Curative (treatment of a disease) Lang1", Lang2 = "Curative (treatment of a disease) Lang2" },
                   new Translation() { RowKey = "HeathCareType2", English = "Preventative (such as vaccinations)", Lang1 = "Preventative (such as vaccinations) Lang1", Lang2 = "Preventative (such as vaccinations) Lang2" },
                   new Translation() { RowKey = "HeathCareType3", English = "Administration of vitamins", Lang1 = "Administration of vitamins Lang1", Lang2 = "Administration of vitamins Lang2" },
                   new Translation() { RowKey = "HeathCareType4", English = "Deworming", Lang1 = "Deworming Lang1", Lang2 = "Deworming Lang2" },
                   new Translation() { RowKey = "HeathCareType5", English = "Use of disinfectants", Lang1 = "Use of disinfectants Lang1", Lang2 = "Use of disinfectants Lang2" },
                   new Translation() { RowKey = "HeathCareType6", English = "Herd visit/monitoring", Lang1 = "Herd visit/monitoring Lang1", Lang2 = "Herd visit/monitoring Lang2" },

                   new Translation() { RowKey = "HealthProviderType1", English = "Private animal health worker or veterinarian", Lang1 = "Private animal health worker or veterinarian Lang1", Lang2 = "Private animal health worker or veterinarian Lang2" },
                   new Translation() { RowKey = "HealthProviderType2", English = "Government animal health worker veterinarian", Lang1 = "Government animal health worker veterinarian Lang1", Lang2 = "Government animal health worker veterinarian Lang2" },
                   new Translation() { RowKey = "HealthProviderType3", English = "Self", Lang1 = "Self Lang1", Lang2 = "Self Lang2" },
                   new Translation() { RowKey = "HealthProviderType4", English = "Neighbour, friend, or relative", Lang1 = "Neighbour, friend, or relative Lang1", Lang2 = "Neighbour, friend, or relative Lang2" },

                   new Translation() { RowKey = "MedicineType1", English = "Drugs ", Lang1 = "Drugs  Lang1", Lang2 = "Drugs  Lang2" },
                   new Translation() { RowKey = "MedicineType2", English = "Vaccinations", Lang1 = "Vaccinations Lang1", Lang2 = "Vaccinations Lang2" },
                   new Translation() { RowKey = "MedicineType3", English = "Dewormers", Lang1 = "Dewormers Lang1", Lang2 = "Dewormers Lang2" },
                   new Translation() { RowKey = "MedicineType4", English = "Vitamins", Lang1 = "Vitamins Lang1", Lang2 = "Vitamins Lang2" },

                   new Translation() { RowKey = "PruchaseFromType1", English = "Private animal health worker or veterinarian", Lang1 = "Private animal health worker or veterinarian Lang1", Lang2 = "Private animal health worker or veterinarian Lang2" },
                   new Translation() { RowKey = "PruchaseFromType2", English = "Government animal health worker veterinarian", Lang1 = "Government animal health worker veterinarian Lang1", Lang2 = "Government animal health worker veterinarian Lang2" },
                   new Translation() { RowKey = "PruchaseFromType3", English = "Agro-vet store", Lang1 = "Agro-vet store Lang1", Lang2 = "Agro-vet store Lang2" },

                   new Translation() { RowKey = "LabourType1", English = "Permanent hired labourer", Lang1 = "Permanent hired labourer Lang1", Lang2 = "Permanent hired labourer Lang2" },
                   new Translation() { RowKey = "LabourType2", English = "Temporary hired labourer", Lang1 = "Temporary hired labourer Lang1", Lang2 = "Temporary hired labourer Lang2" },

                   new Translation() { RowKey = "HousingExpenseType1", English = "New house construction", Lang1 = "New house construction Lang1", Lang2 = "New house construction Lang2" },
                   new Translation() { RowKey = "HousingExpenseType2", English = "Expansion of existing housing", Lang1 = "Expansion of existing housing Lang1", Lang2 = "Expansion of existing housing Lang2" },
                   new Translation() { RowKey = "HousingExpenseType3", English = "Repairs or maintenance", Lang1 = "Repairs or maintenance Lang1", Lang2 = "Repairs or maintenance Lang2" },

                   new Translation() { RowKey = "WaterPurchasedUnitType1", English = "Litre", Lang1 = "Litre Lang1", Lang2 = "Litre Lang2" },
                   new Translation() { RowKey = "WaterPurchasedUnitType2", English = "Cubic meter", Lang1 = "Cubic meter Lang1", Lang2 = "Cubic meter Lang2" },

                   new Translation() { RowKey = "PurchasedWaterFromType1", English = "Mobile water seller", Lang1 = "Mobile water seller Lang1", Lang2 = "Mobile water seller Lang2" },
                   new Translation() { RowKey = "PurchasedWaterFromType2", English = "Water company", Lang1 = "Water company Lang1", Lang2 = "Water company Lang2" },
                   new Translation() { RowKey = "PurchasedWaterFromType3", English = "Neighbour / friend", Lang1 = "Neighbour / friend Lang1", Lang2 = "Neighbour / friend Lang2" },

                   new Translation() { RowKey = "MembershipType1", English = "Co-operative or group fees", Lang1 = "Co-operative or group fees Lang1", Lang2 = "Co-operative or group fees Lang2" },

                   new Translation() { RowKey = "TimePeriodUnitType1", English = "Months", Lang1 = "Months Lang1", Lang2 = "Months Lang2" },
                   new Translation() { RowKey = "TimePeriodUnitType2", English = "Years", Lang1 = "Years Lang1", Lang2 = "Years Lang2" },

                   new Translation() { RowKey = "ServiceType1", English = "Artificial insemination", Lang1 = "Artificial insemination Lang1", Lang2 = "Artificial insemination Lang2" },
                   new Translation() { RowKey = "ServiceType2", English = "Natural mating", Lang1 = "Natural mating Lang1", Lang2 = "Natural mating Lang2" },

                   new Translation() { RowKey = "WhoProvidedServiceType1", English = "Private artificial insemination service provider", Lang1 = "Private artificial insemination service provider Lang1", Lang2 = "Private artificial insemination service provider Lang2" },
                   new Translation() { RowKey = "WhoProvidedServiceType2", English = "Government artificial insemination service provider", Lang1 = "Government artificial insemination service provider Lang1", Lang2 = "Government artificial insemination service provider Lang2" },
                   new Translation() { RowKey = "WhoProvidedServiceType3", English = "Boar keeper", Lang1 = "Boar keeper Lang1", Lang2 = "Boar keeper Lang2" },

                   new Translation() { RowKey = "AnimalType1", English = "Piglet(s) for fattening", Lang1 = "Piglet(s) for fattening Lang1", Lang2 = "Piglet(s) for fattening Lang2" },
                   new Translation() { RowKey = "AnimalType2", English = "Gilt/Sow for breeding", Lang1 = "Gilt / sow for breeding Lang1", Lang2 = "Gilt / sow for breeding Lang2" },
                   new Translation() { RowKey = "AnimalType3", English = "Young male / boar for breeding", Lang1 = "Young male / boar for breeding Lang1", Lang2 = "Young male / boar for breeding Lang2" },

                   new Translation() { RowKey = "AnimalPurchasedFromType1", English = "Market ", Lang1 = "Market  Lang1", Lang2 = "Market  Lang2" },
                   new Translation() { RowKey = "AnimalPurchasedFromType2", English = "Trader", Lang1 = "Trader Lang1", Lang2 = "Trader Lang2" },
                   new Translation() { RowKey = "AnimalPurchasedFromType3", English = "Pig farmer", Lang1 = "Pig farmer Lang1", Lang2 = "Pig farmer Lang2" },
                   new Translation() { RowKey = "AnimalPurchasedFromType4", English = "Pig breeding company", Lang1 = "Pig breeding company Lang1", Lang2 = "Pig breeding company Lang2" },

                   new Translation() { RowKey = "LoanProviderType1", English = "Micro-credit provider", Lang1 = "Micro-credit provider Lang1", Lang2 = "Micro-credit provider Lang2" },
                   new Translation() { RowKey = "LoanProviderType2", English = "Bank", Lang1 = "Bank Lang1", Lang2 = "Bank Lang2" },
                   new Translation() { RowKey = "LoanProviderType3", English = "Co-operative or group", Lang1 = "Co-operative or group Lang1", Lang2 = "Co-operative or group Lang2" },
                   new Translation() { RowKey = "LoanProviderType4", English = "Self-help group or savings ", Lang1 = "Self-help group or savings  Lang1", Lang2 = "Self-help group or savings  Lang2" },
                   new Translation() { RowKey = "LoanProviderType5", English = "Club", Lang1 = "Club Lang1", Lang2 = "Club Lang2" },
                   new Translation() { RowKey = "LoanProviderType6", English = "Relatives or friends", Lang1 = "Relatives or friends Lang1", Lang2 = "Relatives or friends Lang2" },

                   new Translation() { RowKey = "EquipmentType1", English = "Feeding equipment", Lang1 = "Feeding equipment Lang1", Lang2 = "Feeding equipment Lang2" },
                   new Translation() { RowKey = "EquipmentType2", English = "Watering equipment", Lang1 = "Watering equipment Lang1", Lang2 = "Watering equipment Lang2" },
                   new Translation() { RowKey = "EquipmentType3", English = "Cleaning equipment", Lang1 = "Cleaning equipment Lang1", Lang2 = "Cleaning equipment Lang2" },
                   new Translation() { RowKey = "EquipmentType4", English = "Animal tags", Lang1 = "Animal tags Lang1", Lang2 = "Animal tags Lang2" },

                   new Translation() { RowKey = "PigType1", English = "Piglet (for fattening)", Lang1 = "Piglet (for fattening) Lang1", Lang2 = "Piglet (for fattening) Lang2" },
                   new Translation() { RowKey = "PigType2", English = "Slaughter animal", Lang1 = "Slaughter animal Lang1", Lang2 = "Slaughter animal Lang2" },
                   new Translation() { RowKey = "PigType3", English = "Gilt/Sow for breeding", Lang1 = "Gilt/sow sow for breeding Lang1", Lang2 = "Gilt/sow sow for breeding Lang2" },
                   new Translation() { RowKey = "PigType4", English = "Young male/boar for breeding ", Lang1 = "Young male/boar for breeding  Lang1", Lang2 = "Young male/boar for breeding  Lang2" },

                   new Translation() { RowKey = "SoldToType1", English = "Trader", Lang1 = "Trader Lang1", Lang2 = "Trader Lang2" },
                   new Translation() { RowKey = "SoldToType2", English = "Slaughter-house", Lang1 = "Slaughter-house Lang1", Lang2 = "Slaughter-house Lang2" },
                   new Translation() { RowKey = "SoldToType3", English = "Pig farmer", Lang1 = "Pig farmer Lang1", Lang2 = "Pig farmer Lang2" },

                   new Translation() { RowKey = "BreedingServiceType1", English = "Boar services", Lang1 = "Boar services Lang1", Lang2 = "Boar services Lang2" },
                   new Translation() { RowKey = "BreedingServiceType2", English = "Semen sale (? to include)", Lang1 = "Semen sale (? to include) Lang1", Lang2 = "Semen sale (? to include) Lang2" },

                   new Translation() { RowKey = "PaymentType1", English = "Piglet", Lang1 = "Piglet Lang1", Lang2 = "Piglet Lang2" },

                   new Translation() { RowKey = "ClientType1", English = "Pig farmer", Lang1 = "Pig farmer Lang1", Lang2 = "Pig farmer Lang2" },

                   new Translation() { RowKey = "VolumeUnitType1", English = "Kg", Lang1 = "Kg Lang1", Lang2 = "Kg Lang2" },
                   new Translation() { RowKey = "VolumeUnitType2", English = "Bag", Lang1 = "Bag Lang1", Lang2 = "Bag Lang2" },

                    new Translation() { RowKey = "GenderType1", English = "Male", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "GenderType2", English = "Female", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "GenderType3", English = "Other", Lang1 = "", Lang2 = "" },

                    new Translation() { RowKey = "DistrictType1", English = "DistrictType 1", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "DistrictType2", English = "DistrictType 2", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "DistrictType3", English = "DistrictType 3", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "DistrictType4", English = "DistrictType 4", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "DistrictType5", English = "DistrictType 5", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "DistrictType6", English = "DistrictType 6", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "DistrictType7", English = "DistrictType 7", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "DistrictType8", English = "DistrictType 8", Lang1 = "", Lang2 = "" },

                    new Translation() { RowKey = "CountyType1", English = "CountyType 1", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CountyType2", English = "CountyType 2", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CountyType3", English = "CountyType 3", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CountyType4", English = "CountyType 4", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CountyType5", English = "CountyType 5", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CountyType6", English = "CountyType 6", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CountyType7", English = "CountyType 7", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CountyType8", English = "CountyType 8", Lang1 = "", Lang2 = "" },

                    new Translation() { RowKey = "SubCountyType1", English = "SubCountyType 1", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "SubCountyType2", English = "SubCountyType 2", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "SubCountyType3", English = "SubCountyType 3", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "SubCountyType4", English = "SubCountyType 4", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "SubCountyType5", English = "SubCountyType 5", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "SubCountyType6", English = "SubCountyType 6", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "SubCountyType7", English = "SubCountyType 7", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "SubCountyType8", English = "SubCountyType 8", Lang1 = "", Lang2 = "" },

                    new Translation() { RowKey = "CountryTypeUganda", English = "Uganda", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CountryTypeVietnam", English = "Vietnam", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CountryTypeRwanda", English = "Rwanda", Lang1 = "", Lang2 = "" },

                    new Translation() { RowKey = "CurrencyType1", English = "CurrencyType 1", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CurrencyType2", English = "CurrencyType 2", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CurrencyType3", English = "CurrencyType 3", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CurrencyType4", English = "CurrencyType 4", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CurrencyType5", English = "CurrencyType 5", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CurrencyType6", English = "CurrencyType 6", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CurrencyType7", English = "CurrencyType 7", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "CurrencyType8", English = "CurrencyType 8", Lang1 = "", Lang2 = "" },

                    new Translation() { RowKey = "LanguageType1", English = "Language1", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "LanguageType2", English = "Language2", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "LanguageType3", English = "Language3", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "LanguageType4", English = "Language4", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "LanguageType5", English = "Language5", Lang1 = "", Lang2 = "" },
                    new Translation() { RowKey = "LanguageType6", English = "Language6", Lang1 = "", Lang2 = "" }

                    );
            }
             );*/

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
                   new ControlData() { DisplayOrder = 3, PartitionKey = Constants.PartitionKeyControlData, CreatedBy = "InitialUpload", DropDownControlOption = Constants.SOLDTOTYPE, TranslationRowKey = "SoldToType3" },
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
