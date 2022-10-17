using Microsoft.EntityFrameworkCore;
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
        public DbSet<LoanRepaymentItem> LoanRepaymentItems { get; set; }
        public DbSet<EquipmentItem> EquipmentItems { get; set; }
        public DbSet<PigSaleItem> PigSaleItems { get; set; }
        public DbSet<BreedingServiceSaleItem> BreedingServiceSaleItems { get; set; }
        public DbSet<ManureSaleItem> ManureSaleItems { get; set; }
        public DbSet<OtherIncomeItem> OtherIncomeItems { get; set; }

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
            //modelBuilder.Entity<UserInfo>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyUserInfo);
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
            modelBuilder.Entity<AnimalPurchaseItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyAnimalPurchaseItem);
            modelBuilder.Entity<LoanRepaymentItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyLoanRepaymentItem);
            modelBuilder.Entity<EquipmentItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyEquipmentItem);
            modelBuilder.Entity<PigSaleItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyPigSaleItem);
            modelBuilder.Entity<BreedingServiceSaleItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyBreedingServiceSaleItem);
            modelBuilder.Entity<ManureSaleItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyManureSaleItem);
            modelBuilder.Entity<OtherIncomeItem>().Property(bi => bi.PartitionKey).HasDefaultValue(Constants.PartitionKeyOtherIncomeItem);

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
                         new Translation() { RowKey = "FilterTranslation", English = "Filter by:", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "RegistrationTranslation", English = "Registration", Lang1 = "", Lang2 = "" },

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

                         //Loan Repayment
                         new Translation() { RowKey = "LoanRepaymentTitleTranslation", English = "Loan Repayment", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "LoanProviderTranslation", English = "Loan Provider", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "OtherLoanProviderTranslation", English = "Other Loan Provider", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "TotalAmountRepaidTranslation", English = "Total Amount Paid", Lang1 = "", Lang2 = "" },

                         //Equipment
                         new Translation() { RowKey = "EquipmentTitleTranslation", English = "Loan Repayment", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "EquipmentTypeTranslation", English = "Loan Provider", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "OtherEquipmentTypeTranslation", English = "Other Loan Provider", Lang1 = "", Lang2 = "" },

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
                         new Translation() { RowKey = "RegistrationTitleTranslation", English = "Registration", Lang1 = "", Lang2 = "" },
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
                         new Translation() { RowKey = "CurrencyTranslation", English = "Currency", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "GenderTranslation", English = "Gender", Lang1 = "", Lang2 = "" },


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
                         new Translation() { RowKey = "AnimalPurchasedFromType8", English = "Type 8", Lang1 = "", Lang2 = "" },

                         new Translation() { RowKey = "LoanProviderType1", English = "Provider 1", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "LoanProviderType2", English = "Provider 2", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "LoanProviderType3", English = "Provider 3", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "LoanProviderType4", English = "Provider 4", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "LoanProviderType5", English = "Provider 5", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "LoanProviderType6", English = "Provider 6", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "LoanProviderType7", English = "Provider 7", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "LoanProviderType8", English = "Provider 8", Lang1 = "", Lang2 = "" },

                         new Translation() { RowKey = "EquipmentType1", English = "EquipmentType 1", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "EquipmentType2", English = "EquipmentType 2", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "EquipmentType3", English = "EquipmentType 3", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "EquipmentType4", English = "EquipmentType 4", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "EquipmentType5", English = "EquipmentType 5", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "EquipmentType6", English = "EquipmentType 6", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "EquipmentType7", English = "EquipmentType 7", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "EquipmentType8", English = "EquipmentType 8", Lang1 = "", Lang2 = "" },

                         new Translation() { RowKey = "PigType1", English = "PigType 1", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PigType2", English = "PigType 2", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PigType3", English = "PigType 3", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PigType4", English = "PigType 4", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PigType5", English = "PigType 5", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PigType6", English = "PigType 6", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PigType7", English = "PigType 7", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PigType8", English = "PigType 8", Lang1 = "", Lang2 = "" },

                         new Translation() { RowKey = "SoldToType1", English = "SoldToType 1", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "SoldToType2", English = "SoldToType 2", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "SoldToType3", English = "SoldToType 3", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "SoldToType4", English = "SoldToType 4", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "SoldToType5", English = "SoldToType 5", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "SoldToType6", English = "SoldToType 6", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "SoldToType7", English = "SoldToType 7", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "SoldToType8", English = "SoldToType 8", Lang1 = "", Lang2 = "" },

                         new Translation() { RowKey = "BreedingServiceType1", English = "ServiceType 1", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "BreedingServiceType2", English = "ServiceType 2", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "BreedingServiceType3", English = "ServiceType 3", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "BreedingServiceType4", English = "ServiceType 4", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "BreedingServiceType5", English = "ServiceType 5", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "BreedingServiceType6", English = "ServiceType 6", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "BreedingServiceType7", English = "ServiceType 7", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "BreedingServiceType8", English = "ServiceType 8", Lang1 = "", Lang2 = "" },

                         new Translation() { RowKey = "PaymentType1", English = "PaymentType 1", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PaymentType2", English = "PaymentType 2", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PaymentType3", English = "PaymentType 3", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PaymentType4", English = "PaymentType 4", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PaymentType5", English = "PaymentType 5", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PaymentType6", English = "PaymentType 6", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PaymentType7", English = "PaymentType 7", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "PaymentType8", English = "PaymentType 8", Lang1 = "", Lang2 = "" },

                         new Translation() { RowKey = "ClientType1", English = "ClientType 1", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "ClientType2", English = "ClientType 2", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "ClientType3", English = "ClientType 3", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "ClientType4", English = "ClientType 4", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "ClientType5", English = "ClientType 5", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "ClientType6", English = "ClientType 6", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "ClientType7", English = "ClientType 7", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "ClientType8", English = "ClientType 8", Lang1 = "", Lang2 = "" },

                         new Translation() { RowKey = "VolumeUnitType1", English = "VolumeUnitType 1", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "VolumeUnitType2", English = "VolumeUnitType 2", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "VolumeUnitType3", English = "VolumeUnitType 3", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "VolumeUnitType4", English = "VolumeUnitType 4", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "VolumeUnitType5", English = "VolumeUnitType 5", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "VolumeUnitType6", English = "VolumeUnitType 6", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "VolumeUnitType7", English = "VolumeUnitType 7", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "VolumeUnitType8", English = "VolumeUnitType 8", Lang1 = "", Lang2 = "" },


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

                         new Translation() { RowKey = "CountryType1", English = "CountryType 1", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "CountryType2", English = "CountryType 2", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "CountryType3", English = "CountryType 3", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "CountryType4", English = "CountryType 4", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "CountryType5", English = "CountryType 5", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "CountryType6", English = "CountryType 6", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "CountryType7", English = "CountryType 7", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "CountryType8", English = "CountryType 8", Lang1 = "", Lang2 = "" },

                         new Translation() { RowKey = "CurrencyType1", English = "CurrencyType 1", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "CurrencyType2", English = "CurrencyType 2", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "CurrencyType3", English = "CurrencyType 3", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "CurrencyType4", English = "CurrencyType 4", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "CurrencyType5", English = "CurrencyType 5", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "CurrencyType6", English = "CurrencyType 6", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "CurrencyType7", English = "CurrencyType 7", Lang1 = "", Lang2 = "" },
                         new Translation() { RowKey = "CurrencyType8", English = "CurrencyType 8", Lang1 = "", Lang2 = "" }

                         );
                 }
             );



            modelBuilder.Entity<ControlData>(async x =>
                {
                    x.HasData(
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = "DropDownFeedType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDAMOUNTPURCHASEDUNITTYPE, TranslationRowKey = "DropDownUnitType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDAMOUNTPURCHASEDUNITTYPE, TranslationRowKey = "DropDownUnitType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDAMOUNTPURCHASEDUNITTYPE, TranslationRowKey = "DropDownUnitType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDAMOUNTPURCHASEDUNITTYPE, TranslationRowKey = "DropDownUnitType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDAMOUNTPURCHASEDUNITTYPE, TranslationRowKey = "DropDownUnitType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDAMOUNTPURCHASEDUNITTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDPURCHASEDFROMTYPE, TranslationRowKey = "DropDownPurchaseFrom1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDPURCHASEDFROMTYPE, TranslationRowKey = "DropDownPurchaseFrom2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDPURCHASEDFROMTYPE, TranslationRowKey = "DropDownPurchaseFrom3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDPURCHASEDFROMTYPE, TranslationRowKey = "DropDownPurchaseFrom4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.FEEDPURCHASEDFROMTYPE, TranslationRowKey = "DropDownPurchaseFrom5" },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType8" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType9" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = "HeathCareType10" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHCARETYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType8" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType9" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = "HealthProviderType10" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHSERVICEPROVIDER, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType8" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType9" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = "MedicineType10" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHMEDICETYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType8" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType9" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = "PruchaseFromType10" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HEALTHPURCHASEFROMTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LABOURTYPE, TranslationRowKey = "LabourType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LABOURTYPE, TranslationRowKey = "LabourType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LABOURTYPE, TranslationRowKey = "LabourType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LABOURTYPE, TranslationRowKey = "LabourType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LABOURTYPE, TranslationRowKey = "LabourType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LABOURTYPE, TranslationRowKey = "LabourType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LABOURTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HOUSINGTYPE, TranslationRowKey = "HousingExpenseType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HOUSINGTYPE, TranslationRowKey = "HousingExpenseType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HOUSINGTYPE, TranslationRowKey = "HousingExpenseType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HOUSINGTYPE, TranslationRowKey = "HousingExpenseType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HOUSINGTYPE, TranslationRowKey = "HousingExpenseType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.HOUSINGTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WATERPURCHASEDUNITTYPE, TranslationRowKey = "WaterPurchasedUnitType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WATERPURCHASEDUNITTYPE, TranslationRowKey = "WaterPurchasedUnitType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WATERPURCHASEDUNITTYPE, TranslationRowKey = "WaterPurchasedUnitType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WATERPURCHASEDUNITTYPE, TranslationRowKey = "WaterPurchasedUnitType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WATERPURCHASEDUNITTYPE, TranslationRowKey = "WaterPurchasedUnitType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WATERPURCHASEDUNITTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType8" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType9" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = "PurchasedWaterFromType10" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PURCHASEDWATERFROMTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = "MembershipType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = "MembershipType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = "MembershipType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = "MembershipType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = "MembershipType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = "MembershipType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = "MembershipType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = "MembershipType8" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.MEMBERSHIPTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.TIMEPERIODUNITTYPE, TranslationRowKey = "TimePeriodUnitType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.TIMEPERIODUNITTYPE, TranslationRowKey = "TimePeriodUnitType2" },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = "ServiceType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = "ServiceType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = "ServiceType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = "ServiceType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = "ServiceType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = "ServiceType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = "ServiceType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = "ServiceType8" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SERVICETYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = "WhoProvidedServiceType8" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.WHOPROVIDEDSERVICETYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = "AnimalType8" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = "AnimalPurchasedFromType8" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.ANIMALPURCHASEDFROMTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LOANPROVIDERTYPE, TranslationRowKey = "LoanProviderType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LOANPROVIDERTYPE, TranslationRowKey = "LoanProviderType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LOANPROVIDERTYPE, TranslationRowKey = "LoanProviderType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LOANPROVIDERTYPE, TranslationRowKey = "LoanProviderType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LOANPROVIDERTYPE, TranslationRowKey = "LoanProviderType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LOANPROVIDERTYPE, TranslationRowKey = "LoanProviderType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LOANPROVIDERTYPE, TranslationRowKey = "LoanProviderType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LOANPROVIDERTYPE, TranslationRowKey = "LoanProviderType8" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.LOANPROVIDERTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.EQUIPMENTTYPE, TranslationRowKey = "EquipmentType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.EQUIPMENTTYPE, TranslationRowKey = "EquipmentType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.EQUIPMENTTYPE, TranslationRowKey = "EquipmentType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.EQUIPMENTTYPE, TranslationRowKey = "EquipmentType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.EQUIPMENTTYPE, TranslationRowKey = "EquipmentType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.EQUIPMENTTYPE, TranslationRowKey = "EquipmentType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.EQUIPMENTTYPE, TranslationRowKey = "EquipmentType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.EQUIPMENTTYPE, TranslationRowKey = "EquipmentType8" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.EQUIPMENTTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PIGTYPE, TranslationRowKey = "PigType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PIGTYPE, TranslationRowKey = "PigType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PIGTYPE, TranslationRowKey = "PigType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PIGTYPE, TranslationRowKey = "PigType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PIGTYPE, TranslationRowKey = "PigType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PIGTYPE, TranslationRowKey = "PigType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PIGTYPE, TranslationRowKey = "PigType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PIGTYPE, TranslationRowKey = "PigType8" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.PIGTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SOLDTOTYPE, TranslationRowKey = "SoldToType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SOLDTOTYPE, TranslationRowKey = "SoldToType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SOLDTOTYPE, TranslationRowKey = "SoldToType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SOLDTOTYPE, TranslationRowKey = "SoldToType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SOLDTOTYPE, TranslationRowKey = "SoldToType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SOLDTOTYPE, TranslationRowKey = "SoldToType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SOLDTOTYPE, TranslationRowKey = "SoldToType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SOLDTOTYPE, TranslationRowKey = "SoldToType8" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SOLDTOTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.BREEDINGSERVICETYPE, TranslationRowKey = "BreedingServiceType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.BREEDINGSERVICETYPE, TranslationRowKey = "BreedingServiceType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.BREEDINGSERVICETYPE, TranslationRowKey = "BreedingServiceType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.BREEDINGSERVICETYPE, TranslationRowKey = "BreedingServiceType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.BREEDINGSERVICETYPE, TranslationRowKey = "BreedingServiceType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.BREEDINGSERVICETYPE, TranslationRowKey = "BreedingServiceType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.BREEDINGSERVICETYPE, TranslationRowKey = "BreedingServiceType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.BREEDINGSERVICETYPE, TranslationRowKey = "BreedingServiceType8" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.BREEDINGSERVICETYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.OTHERPAYMENTTYPE, TranslationRowKey = "PaymentType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.OTHERPAYMENTTYPE, TranslationRowKey = "PaymentType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.OTHERPAYMENTTYPE, TranslationRowKey = "PaymentType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.OTHERPAYMENTTYPE, TranslationRowKey = "PaymentType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.OTHERPAYMENTTYPE, TranslationRowKey = "PaymentType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.OTHERPAYMENTTYPE, TranslationRowKey = "PaymentType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.OTHERPAYMENTTYPE, TranslationRowKey = "PaymentType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.OTHERPAYMENTTYPE, TranslationRowKey = "PaymentType8" },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.CLIENTTYPE, TranslationRowKey = "ClientType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.CLIENTTYPE, TranslationRowKey = "ClientType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.CLIENTTYPE, TranslationRowKey = "ClientType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.CLIENTTYPE, TranslationRowKey = "ClientType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.CLIENTTYPE, TranslationRowKey = "ClientType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.CLIENTTYPE, TranslationRowKey = "ClientType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.CLIENTTYPE, TranslationRowKey = "ClientType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.CLIENTTYPE, TranslationRowKey = "ClientType8" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.CLIENTTYPE, TranslationRowKey = Constants.OTHER },

                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.VOLUMEUNITTYPE, TranslationRowKey = "VolumeUnitType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.VOLUMEUNITTYPE, TranslationRowKey = "VolumeUnitType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.VOLUMEUNITTYPE, TranslationRowKey = "VolumeUnitType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.VOLUMEUNITTYPE, TranslationRowKey = "VolumeUnitType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.VOLUMEUNITTYPE, TranslationRowKey = "VolumeUnitType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.VOLUMEUNITTYPE, TranslationRowKey = "VolumeUnitType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.VOLUMEUNITTYPE, TranslationRowKey = "VolumeUnitType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.VOLUMEUNITTYPE, TranslationRowKey = "VolumeUnitType8" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.VOLUMEUNITTYPE, TranslationRowKey = Constants.OTHER },

                                              new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.GENDERTYPE, TranslationRowKey = "GenderType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.GENDERTYPE, TranslationRowKey = "GenderType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.GENDERTYPE, TranslationRowKey = "GenderType3" },

                                              new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.DISTRICTTYPE, TranslationRowKey = "DistrictType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.DISTRICTTYPE, TranslationRowKey = "DistrictType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.DISTRICTTYPE, TranslationRowKey = "DistrictType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.DISTRICTTYPE, TranslationRowKey = "DistrictType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.DISTRICTTYPE, TranslationRowKey = "DistrictType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.DISTRICTTYPE, TranslationRowKey = "DistrictType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.DISTRICTTYPE, TranslationRowKey = "DistrictType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.DISTRICTTYPE, TranslationRowKey = "DistrictType8" },

                                              new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.COUNTYTYPE, TranslationRowKey = "CountyType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.COUNTYTYPE, TranslationRowKey = "CountyType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.COUNTYTYPE, TranslationRowKey = "CountyType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.COUNTYTYPE, TranslationRowKey = "CountyType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.COUNTYTYPE, TranslationRowKey = "CountyType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.COUNTYTYPE, TranslationRowKey = "CountyType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.COUNTYTYPE, TranslationRowKey = "CountyType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.COUNTYTYPE, TranslationRowKey = "CountyType8" },

                                              new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.COUNTRYTYPE, TranslationRowKey = "CountryType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.COUNTRYTYPE, TranslationRowKey = "CountryType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.COUNTRYTYPE, TranslationRowKey = "CountryType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.COUNTRYTYPE, TranslationRowKey = "CountryType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.COUNTRYTYPE, TranslationRowKey = "CountryType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.COUNTRYTYPE, TranslationRowKey = "CountryType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.COUNTRYTYPE, TranslationRowKey = "CountryType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.COUNTRYTYPE, TranslationRowKey = "CountryType8" },

                                              new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SUBCOUNTYTYPE, TranslationRowKey = "SubCountyType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SUBCOUNTYTYPE, TranslationRowKey = "SubCountyType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SUBCOUNTYTYPE, TranslationRowKey = "SubCountyType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SUBCOUNTYTYPE, TranslationRowKey = "SubCountyType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SUBCOUNTYTYPE, TranslationRowKey = "SubCountyType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SUBCOUNTYTYPE, TranslationRowKey = "SubCountyType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SUBCOUNTYTYPE, TranslationRowKey = "SubCountyType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.SUBCOUNTYTYPE, TranslationRowKey = "SubCountyType8" },

                                              new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.CURRENCYTYPE, TranslationRowKey = "CurrencyType1" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.CURRENCYTYPE, TranslationRowKey = "CurrencyType2" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.CURRENCYTYPE, TranslationRowKey = "CurrencyType3" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.CURRENCYTYPE, TranslationRowKey = "CurrencyType4" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.CURRENCYTYPE, TranslationRowKey = "CurrencyType5" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.CURRENCYTYPE, TranslationRowKey = "CurrencyType6" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.CURRENCYTYPE, TranslationRowKey = "CurrencyType7" },
                       new ControlData() { PartitionKey = Constants.PartitionKeyControlData, RowKey = Guid.NewGuid().ToString(), CreatedBy = "InitialUpload", CreatedTimeStamp = new DateTime(), DropDownControlOption = Constants.CURRENCYTYPE, TranslationRowKey = "CurrencyType8" }

                       );
                }
            );

#endif
            //Convert Enum To String
            modelBuilder.Entity<UserInfo>().Property(x => x.UserLang)
                .HasConversion(
                v => v.ToString(),
                v => (UserLangSettings)Enum.Parse(typeof(UserLangSettings), v)
                );


            /*
            modelBuilder.Entity<UserInfo>(x =>
            {
                x.HasData(
                    new UserInfo()
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
                    }
                ) ;
            }
            
            
           );
            
*/
        }

    }
    }
