using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class IntialStandup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimalHouseItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: true),
                    IsModified = table.Column<bool>(nullable: false, defaultValue: true),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedTimeStamp = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false, defaultValueSql: "date()"),
                    PartitionKey = table.Column<string>(nullable: true, defaultValue: "AnimalHouse"),
                    Timestamp = table.Column<DateTimeOffset>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    HousingExpense = table.Column<string>(nullable: true),
                    OtherHousingExpense = table.Column<string>(nullable: true),
                    TotalCosts = table.Column<double>(nullable: false),
                    TransportationCost = table.Column<double>(nullable: false),
                    OtherCosts = table.Column<double>(nullable: false),
                    YearsExpected = table.Column<int>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalHouseItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "AnimalPurchaseItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: true),
                    IsModified = table.Column<bool>(nullable: false, defaultValue: true),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedTimeStamp = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false, defaultValueSql: "date()"),
                    PartitionKey = table.Column<string>(nullable: true, defaultValue: "AnimalPurchase"),
                    Timestamp = table.Column<DateTimeOffset>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    AnimalType = table.Column<string>(nullable: true),
                    OtherAnimalType = table.Column<string>(nullable: true),
                    NumberPurchased = table.Column<int>(nullable: true),
                    TotalCosts = table.Column<double>(nullable: false),
                    AnimalPurchasedFrom = table.Column<string>(nullable: true),
                    OtherAnimalPurchasedFrom = table.Column<string>(nullable: true),
                    TransportationCost = table.Column<double>(nullable: false),
                    OtherCosts = table.Column<double>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalPurchaseItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "BreedingServiceSaleItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: true),
                    IsModified = table.Column<bool>(nullable: false, defaultValue: true),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedTimeStamp = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false, defaultValueSql: "date()"),
                    PartitionKey = table.Column<string>(nullable: true, defaultValue: "BreedingServiceSale"),
                    Timestamp = table.Column<DateTimeOffset>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    ServiceType = table.Column<string>(nullable: true),
                    OtherServiceType = table.Column<string>(nullable: true),
                    NumberServices = table.Column<int>(nullable: true),
                    AmountRecieved = table.Column<double>(nullable: false),
                    PaymentType = table.Column<string>(nullable: true),
                    PaymentValue = table.Column<double>(nullable: false),
                    Client = table.Column<string>(nullable: true),
                    OtherClient = table.Column<string>(nullable: true),
                    TransportationCost = table.Column<double>(nullable: false),
                    OtherCosts = table.Column<double>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreedingServiceSaleItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: true),
                    IsModified = table.Column<bool>(nullable: false, defaultValue: true),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedTimeStamp = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false, defaultValueSql: "date()"),
                    PartitionKey = table.Column<string>(nullable: true, defaultValue: "Equipment"),
                    Timestamp = table.Column<DateTimeOffset>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    TotalCosts = table.Column<double>(nullable: false),
                    EquipmentType = table.Column<string>(nullable: true),
                    OtherEquipmentType = table.Column<string>(nullable: true),
                    TransportationCost = table.Column<double>(nullable: false),
                    OtherCosts = table.Column<double>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "HealthCareItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: true),
                    IsModified = table.Column<bool>(nullable: false, defaultValue: true),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedTimeStamp = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false, defaultValueSql: "date()"),
                    PartitionKey = table.Column<string>(nullable: true, defaultValue: "HealthCare"),
                    Timestamp = table.Column<DateTimeOffset>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    HealthCareType = table.Column<string>(nullable: true),
                    OtherHealthCareType = table.Column<string>(nullable: true),
                    HealthCareCost = table.Column<double>(nullable: false),
                    Provider = table.Column<string>(nullable: true),
                    OtherProvider = table.Column<string>(nullable: true),
                    MedicineCost = table.Column<double>(nullable: false),
                    MedicineType = table.Column<string>(nullable: true),
                    OtherMedicineType = table.Column<string>(nullable: true),
                    PurchasedFrom = table.Column<string>(nullable: true),
                    OtherPurchasedFrom = table.Column<string>(nullable: true),
                    TransportationCost = table.Column<double>(nullable: false),
                    OtherCosts = table.Column<double>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCareItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "LabourCostItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: true),
                    IsModified = table.Column<bool>(nullable: false, defaultValue: true),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedTimeStamp = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false, defaultValueSql: "date()"),
                    PartitionKey = table.Column<string>(nullable: true, defaultValue: "Labour"),
                    Timestamp = table.Column<DateTimeOffset>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    LabourType = table.Column<string>(nullable: true),
                    OtherLabourType = table.Column<string>(nullable: true),
                    AmountPaid = table.Column<double>(nullable: false),
                    OtherCost = table.Column<double>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabourCostItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "LoanRepaymentItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: true),
                    IsModified = table.Column<bool>(nullable: false, defaultValue: true),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedTimeStamp = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false, defaultValueSql: "date()"),
                    PartitionKey = table.Column<string>(nullable: true, defaultValue: "LoanRepayment"),
                    Timestamp = table.Column<DateTimeOffset>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    TotalAmountRepaid = table.Column<double>(nullable: false),
                    LoanProvider = table.Column<string>(nullable: true),
                    OtherLoanProvider = table.Column<string>(nullable: true),
                    OtherCosts = table.Column<double>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanRepaymentItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "ManureSaleItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: true),
                    IsModified = table.Column<bool>(nullable: false, defaultValue: true),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedTimeStamp = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false, defaultValueSql: "date()"),
                    PartitionKey = table.Column<string>(nullable: true, defaultValue: "ManureSale"),
                    Timestamp = table.Column<DateTimeOffset>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    VolumeSold = table.Column<double>(nullable: true),
                    VolumeUnitType = table.Column<string>(nullable: true),
                    AmountRecieved = table.Column<double>(nullable: false),
                    PaymentType = table.Column<string>(nullable: true),
                    PaymentValue = table.Column<double>(nullable: false),
                    SoldTo = table.Column<string>(nullable: true),
                    OtherSoldTo = table.Column<string>(nullable: true),
                    TransportationCost = table.Column<double>(nullable: false),
                    OtherCosts = table.Column<double>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManureSaleItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "MembershipItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: true),
                    IsModified = table.Column<bool>(nullable: false, defaultValue: true),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedTimeStamp = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false, defaultValueSql: "date()"),
                    PartitionKey = table.Column<string>(nullable: true, defaultValue: "MemberShip"),
                    Timestamp = table.Column<DateTimeOffset>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    TotalCosts = table.Column<double>(nullable: false),
                    MembershipType = table.Column<string>(nullable: true),
                    OtherMembershipType = table.Column<string>(nullable: true),
                    TimePeriod = table.Column<int>(nullable: false),
                    TimePeriodUnit = table.Column<string>(nullable: true),
                    OtherCosts = table.Column<double>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "OtherCostItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: true),
                    IsModified = table.Column<bool>(nullable: false, defaultValue: true),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedTimeStamp = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false, defaultValueSql: "date()"),
                    PartitionKey = table.Column<string>(nullable: true, defaultValue: "OtherCost"),
                    Timestamp = table.Column<DateTimeOffset>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    TotalCosts = table.Column<double>(nullable: false),
                    OtherWhatFor = table.Column<string>(nullable: true),
                    TransportationCosts = table.Column<double>(nullable: true),
                    OtherCosts = table.Column<double>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherCostItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "OtherIncomeItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: true),
                    IsModified = table.Column<bool>(nullable: false, defaultValue: true),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedTimeStamp = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false, defaultValueSql: "date()"),
                    PartitionKey = table.Column<string>(nullable: true, defaultValue: "OtherIncome"),
                    Timestamp = table.Column<DateTimeOffset>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    TotalIncome = table.Column<double>(nullable: false),
                    OtherWhatFor = table.Column<string>(nullable: true),
                    TransportationCosts = table.Column<double>(nullable: false),
                    OtherCosts = table.Column<double>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherIncomeItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "PigSaleItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: true),
                    IsModified = table.Column<bool>(nullable: false, defaultValue: true),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedTimeStamp = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false, defaultValueSql: "date()"),
                    PartitionKey = table.Column<string>(nullable: true, defaultValue: "PigSale"),
                    Timestamp = table.Column<DateTimeOffset>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    PigType = table.Column<string>(nullable: true),
                    OtherPigType = table.Column<string>(nullable: true),
                    NumberSold = table.Column<int>(nullable: true),
                    SalePrice = table.Column<double>(nullable: false),
                    SoldTo = table.Column<string>(nullable: true),
                    OtherSoldTo = table.Column<string>(nullable: true),
                    Brokerage = table.Column<double>(nullable: false),
                    TransportationCost = table.Column<double>(nullable: false),
                    OtherCosts = table.Column<double>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PigSaleItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "ReproductiveItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: true),
                    IsModified = table.Column<bool>(nullable: false, defaultValue: true),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedTimeStamp = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false, defaultValueSql: "date()"),
                    PartitionKey = table.Column<string>(nullable: true, defaultValue: "Reproductive"),
                    Timestamp = table.Column<DateTimeOffset>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    ServiceType = table.Column<string>(nullable: true),
                    OtherServiceType = table.Column<string>(nullable: true),
                    SowsServiced = table.Column<int>(nullable: false),
                    WhoProvidedService = table.Column<string>(nullable: true),
                    OtherWhoProvidedService = table.Column<string>(nullable: true),
                    OtherCosts = table.Column<double>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReproductiveItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    RowKey = table.Column<string>(nullable: false),
                    English = table.Column<string>(nullable: true),
                    Lang1 = table.Column<string>(nullable: true),
                    Lang2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    RowKey = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    SubCounty = table.Column<string>(nullable: true),
                    Parish = table.Column<string>(nullable: true),
                    Village = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    Commune = table.Column<string>(nullable: true),
                    Sector = table.Column<string>(nullable: true),
                    Cell = table.Column<string>(nullable: true),
                    Currency = table.Column<string>(nullable: true),
                    LastUploadDate = table.Column<DateTime>(nullable: false),
                    UserLang = table.Column<string>(nullable: false),
                    AuthorisedToken = table.Column<string>(nullable: true),
                    AuthorisedEmail = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false, defaultValueSql: "date()"),
                    PartitionKey = table.Column<string>(nullable: true),
                    Timestamp = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "WaterCostItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: true),
                    IsModified = table.Column<bool>(nullable: false, defaultValue: true),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedTimeStamp = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false, defaultValueSql: "date()"),
                    PartitionKey = table.Column<string>(nullable: true, defaultValue: "Water"),
                    Timestamp = table.Column<DateTimeOffset>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    WaterPurchased = table.Column<double>(nullable: true),
                    WaterPurchasedUnit = table.Column<string>(nullable: true),
                    OtherWaterPurchasedUnit = table.Column<string>(nullable: true),
                    TotalCosts = table.Column<double>(nullable: false),
                    PurchasedWaterFrom = table.Column<string>(nullable: true),
                    OtherPurchasedWaterFrom = table.Column<string>(nullable: true),
                    TransportationCost = table.Column<double>(nullable: false),
                    OtherCosts = table.Column<double>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterCostItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "ControlDataOptions",
                columns: table => new
                {
                    RowKey = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: true),
                    IsModified = table.Column<bool>(nullable: false, defaultValue: true),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedTimeStamp = table.Column<DateTime>(nullable: false, defaultValueSql: "date()"),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false, defaultValueSql: "date()"),
                    PartitionKey = table.Column<string>(nullable: true, defaultValue: "ControlData"),
                    Timestamp = table.Column<DateTimeOffset>(nullable: true),
                    DropDownControlOption = table.Column<string>(nullable: true),
                    TranslationRowKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlDataOptions", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_ControlDataOptions_Translations_TranslationRowKey",
                        column: x => x.TranslationRowKey,
                        principalTable: "Translations",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FeedItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: true),
                    IsModified = table.Column<bool>(nullable: false, defaultValue: true),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedTimeStamp = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false, defaultValueSql: "date()"),
                    PartitionKey = table.Column<string>(nullable: true, defaultValue: "Feed"),
                    Timestamp = table.Column<DateTimeOffset>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    FeedType = table.Column<string>(nullable: true),
                    OtherFeedType = table.Column<string>(nullable: true),
                    AmountPurchased = table.Column<double>(nullable: true),
                    AmountPurchasedUnit = table.Column<string>(nullable: true),
                    OtherAmountPurchaseUnit = table.Column<string>(nullable: true),
                    TotalCosts = table.Column<double>(nullable: false),
                    TransportationCost = table.Column<double>(nullable: false),
                    PurchasedFrom = table.Column<string>(nullable: true),
                    OtherPurchasedFrom = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    FeedTypeTranslationString = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedItems", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_FeedItems_Translations_FeedType",
                        column: x => x.FeedType,
                        principalTable: "Translations",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoginButton", "Login", "SignUP", "OverHere" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WhoProvidedServiceType2", "Type 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WhoProvidedServiceType1", "Type 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ServiceType8", "Type 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ServiceType7", "Type 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ServiceType6", "Type 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ServiceType5", "Type 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ServiceType4", "Type 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ServiceType3", "Type 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ServiceType2", "Type 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ServiceType1", "Type 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TimePeriodUnitType2", "Months", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TimePeriodUnitType1", "Weeks", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MembershipType8", "Type 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MembershipType7", "Type 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MembershipType6", "Type 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MembershipType5", "Type 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MembershipType4", "Type 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MembershipType3", "Type 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MembershipType2", "Type 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MembershipType1", "Type 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PurchasedWaterFromType10", "Purchased From 10", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WhoProvidedServiceType3", "Type 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WhoProvidedServiceType4", "Type 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WhoProvidedServiceType5", "Type 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WhoProvidedServiceType6", "Type 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanProviderType4", "Provider 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanProviderType3", "Provider 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanProviderType2", "Provider 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanProviderType1", "Provider 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchasedFromType8", "Type 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchasedFromType7", "Type 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchasedFromType6", "Type 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchasedFromType5", "Type 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchasedFromType4", "Type 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchasedFromType3", "Type 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PurchasedWaterFromType9", "Purchased From 9", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchasedFromType2", "Type 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalType8", "Type 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalType7", "Type 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalType6", "Type 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalType5", "Type 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalType4", "Type 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalType3", "Type 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalType2", "Type 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalType1", "Type 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WhoProvidedServiceType8", "Type 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WhoProvidedServiceType7", "Type 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchasedFromType1", "Type 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanProviderType5", "Provider 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PurchasedWaterFromType8", "Purchased From 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PurchasedWaterFromType6", "Purchased From 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PruchaseFromType5", "Purchase From Type 5", "Purchase From Type 5 Lang1", "Purchase From Type 5 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PruchaseFromType4", "Purchase From Type 4", "Purchase From Type 4 Lang1", "Purchase From Type 4 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PruchaseFromType3", "Purchase From Type 3", "Purchase From Type 3 Lang1", "Purchase From Type 3 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PruchaseFromType2", "Purchase From Type 2", "Purchase From Type 2 Lang1", "Purchase From Type 2 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PruchaseFromType1", "Purchase From Type 1", "Purchase From Type 1 Lang1", "Purchase From Type 1 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MedicineType10", "Medicine Type 10", "Medicine Type 10 Lang1", "Medicine Type 10 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MedicineType9", "Medicine Type 9", "Medicine Type 9 Lang1", "Medicine Type 9 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MedicineType8", "Medicine Type 8", "Medicine Type 8 Lang1", "Medicine Type 8 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MedicineType7", "Medicine Type 7", "Medicine Type 7 Lang1", "Medicine Type 7 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MedicineType6", "Medicine Type 6", "Medicine Type 6 Lang1", "Medicine Type 6 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MedicineType5", "Medicine Type 5", "Medicine Type 5 Lang1", "Medicine Type 5 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MedicineType4", "Medicine Type 4", "Medicine Type 4 Lang1", "Medicine Type 4 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MedicineType3", "Medicine Type 3", "Medicine Type 3 Lang1", "Medicine Type 3 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MedicineType2", "Medicine Type 2", "Medicine Type 2 Lang1", "Medicine Type 2 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MedicineType1", "Medicine Type 1", "Medicine Type 1 Lang1", "Medicine Type 1 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthProviderType10", "Health Provider Type 10", "Health Provider Type 10 Lang1", "Health Provider Type 10 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthProviderType9", "Health Provider Type 9", "Health Provider Type 9 Lang1", "Health Provider Type 9 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthProviderType8", "Health Provider Type 8", "Health Provider Type 8 Lang1", "Health Provider Type 8 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthProviderType7", "Health Provider Type 7", "Health Provider Type 7 Lang1", "Health Provider Type 7 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthProviderType6", "Health Provider Type 6", "Health Provider Type 6 Lang1", "Health Provider Type 6 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthProviderType5", "Health Provider Type 5", "Health Provider Type 5 Lang1", "Health Provider Type 5 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PruchaseFromType6", "Purchase From Type 6", "Purchase From Type 6 Lang1", "Purchase From Type 6 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PruchaseFromType7", "Purchase From Type 7", "Purchase From Type 7 Lang1", "Purchase From Type 7 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PruchaseFromType8", "Purchase From Type 8", "Purchase From Type 8 Lang1", "Purchase From Type 8 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PruchaseFromType9", "Purchase From Type 9", "Purchase From Type 9 Lang1", "Purchase From Type 9 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PurchasedWaterFromType5", "Purchased From 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PurchasedWaterFromType4", "Purchased From 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PurchasedWaterFromType3", "Purchased From 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PurchasedWaterFromType2", "Purchased From 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PurchasedWaterFromType1", "Purchased From 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WaterPurchasedUnitType5", "Unit 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WaterPurchasedUnitType4", "Unit 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WaterPurchasedUnitType3", "Unit 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WaterPurchasedUnitType2", "Unit 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WaterPurchasedUnitType1", "Unit 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PurchasedWaterFromType7", "Purchased From 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HousingExpenseType5", "Housing Expense Type 5", "Housing Expense Type 5 Lang1", "Housing Expense Type 5 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HousingExpenseType3", "Housing Expense Type 3", "Housing Expense Type 3 Lang1", "Housing Expense Type 3 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HousingExpenseType2", "Housing Expense Type 2", "Housing Expense Type 2 Lang1", "Housing Expense Type 2 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HousingExpenseType1", "Housing Expense Type 1", "Housing Expense Type 1 Lang1", "Housing Expense Type 1 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LabourType6", "Labour Type 6", "Labour Type 6 Lang1", "Labour Type 6 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LabourType5", "Labour Type 5", "Labour Type 5 Lang1", "Labour Type 5 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LabourType4", "Labour Type 4", "Labour Type 4 Lang1", "Labour Type 4 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LabourType3", "Labour Type 3", "Labour Type 3 Lang1", "Labour Type 3 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LabourType2", "Labour Type 2", "Labour Type 2 Lang1", "Labour Type 2 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LabourType1", "Labour Type 1", "Labour Type 1 Lang1", "Labour Type 1 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PruchaseFromType10", "Purchase From Type 10", "Purchase From Type 10 Lang1", "Purchase From Type 10 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HousingExpenseType4", "Housing Expense Type 4", "Housing Expense Type 4 Lang1", "Housing Expense Type 4 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthProviderType4", "Health Provider Type 4", "Health Provider Type 4 Lang1", "Health Provider Type 4 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanProviderType6", "Provider 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanProviderType8", "Provider 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType5", "CountyType 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType4", "CountyType 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType3", "CountyType 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType2", "CountyType 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType1", "CountyType 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType8", "DistrictType 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType7", "DistrictType 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType6", "DistrictType 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType5", "DistrictType 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType4", "DistrictType 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType3", "DistrictType 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType2", "DistrictType 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType1", "DistrictType 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "GenderType3", "Other", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "GenderType2", "Female", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "GenderType1", "Male", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "VolumeUnitType8", "VolumeUnitType 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "VolumeUnitType7", "VolumeUnitType 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "VolumeUnitType6", "VolumeUnitType 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "VolumeUnitType5", "VolumeUnitType 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "VolumeUnitType4", "VolumeUnitType 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType6", "CountyType 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType7", "CountyType 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType8", "CountyType 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SubCountyType1", "SubCountyType 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LanguageType4", "Language4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LanguageType3", "Language3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LanguageType2", "Language2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LanguageType1", "Language1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CurrencyType8", "CurrencyType 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CurrencyType7", "CurrencyType 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CurrencyType6", "CurrencyType 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CurrencyType5", "CurrencyType 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CurrencyType4", "CurrencyType 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CurrencyType3", "CurrencyType 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "VolumeUnitType3", "VolumeUnitType 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CurrencyType2", "CurrencyType 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountryTypeRwanda", "Rwanda", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountryTypeVietnam", "Vietnam", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountryTypeUganda", "Uganda", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SubCountyType8", "SubCountyType 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SubCountyType7", "SubCountyType 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SubCountyType6", "SubCountyType 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SubCountyType5", "SubCountyType 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SubCountyType4", "SubCountyType 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SubCountyType3", "SubCountyType 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SubCountyType2", "SubCountyType 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CurrencyType1", "CurrencyType 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanProviderType7", "Provider 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "VolumeUnitType2", "VolumeUnitType 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ClientType8", "ClientType 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SoldToType5", "SoldToType 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SoldToType4", "SoldToType 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SoldToType3", "SoldToType 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SoldToType2", "SoldToType 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SoldToType1", "SoldToType 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PigType8", "PigType 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PigType7", "PigType 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PigType6", "PigType 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PigType5", "PigType 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PigType4", "PigType 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PigType3", "PigType 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PigType2", "PigType 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PigType1", "PigType 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentType8", "EquipmentType 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentType7", "EquipmentType 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentType6", "EquipmentType 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentType5", "EquipmentType 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentType4", "EquipmentType 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentType3", "EquipmentType 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentType2", "EquipmentType 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentType1", "EquipmentType 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SoldToType6", "SoldToType 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SoldToType7", "SoldToType 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SoldToType8", "SoldToType 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BreedingServiceType1", "ServiceType 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ClientType7", "ClientType 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ClientType6", "ClientType 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ClientType5", "ClientType 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ClientType4", "ClientType 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ClientType3", "ClientType 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ClientType2", "ClientType 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ClientType1", "ClientType 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PaymentType8", "PaymentType 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PaymentType7", "PaymentType 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PaymentType6", "PaymentType 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "VolumeUnitType1", "VolumeUnitType 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PaymentType5", "PaymentType 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PaymentType3", "PaymentType 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PaymentType2", "PaymentType 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PaymentType1", "PaymentType 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BreedingServiceType8", "ServiceType 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BreedingServiceType7", "ServiceType 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BreedingServiceType6", "ServiceType 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BreedingServiceType5", "ServiceType 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BreedingServiceType4", "ServiceType 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BreedingServiceType3", "ServiceType 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BreedingServiceType2", "ServiceType 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PaymentType4", "PaymentType 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LanguageType5", "Language5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthProviderType3", "Health Provider Type 3", "Health Provider Type 3 Lang1", "Health Provider Type 3 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthProviderType1", "Health Provider Type 1", "Health Provider Type 1 Lang1", "Health Provider Type 1 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherHousingExpenseTranslation", "Other Housing Expense", "Other Housing Expense Lang1", "Other Housing Expense Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HousingExpenseTranslation", "Housing Expense", "Housing Expense Lang1", "Housing Expense Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HousingTitleTranslation", "Animal Housing", "Animal Housing Lang1", "Animal Housing Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherCostsTranslation", "Any Other Cost", "Any Other Cost Lang1", "Any Other Cost Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AmountPaidTranslation", "Amount Paid", "Amount Paid Lang1", "Amount Paid Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherLaboutTypeTranslation", "Other LabourType", "Other LabourType Lang1", "Other LabourType Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LabourTypeTranslation", "Labour Type", "Labour Type Lang1", "Labour Type Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LabourTitleTranslation", "Labour Cost", "Labour Cost Lang1", "Labour Cost Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CostTranslation", "Any other cost:", "Any other cost: Lang1", "Any other cost: Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherMedicineTypeTranslation", "Other Medicine Type", "Other Medicine Type: Lang1", "Other Medicine Type: Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MedicineTypeTranslation", "Medicine Type", "Medicine Type: Lang1", "Medicine Type: Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MedicineCostTranslation", "Medicine Cost", "Medicine Cost: Lang1", "Medicine Cost: Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherProviderTranslation", "Other provided service", "Other provided service: Lang1", "Other provided service: Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ProviderTranslation", "Who provided service", "Who provided service: Lang1", "Who provided service: Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthCareCostTranslation", "Care Cost", "Care Cost", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherHealthCareTypeTranslation", "Other Health Care Type", "Other Health Care Type Lang 1", "Other Health Care Type Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthCareTypeTranslation", "Health Care Type", "Health Care Type Lang1", "Health Care Type Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthCareTitleTranslation", "Health Care", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CommentTrans", "Comment", "Comment Lang1", "Comment Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PurchasedFrom", "Purchased From", "Purchased From Lang1", "Purchased From Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TransportCostTrans", "Transportation Cost", "Transportation Cost Lang1", "Transportation Cost Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "YearsExpectedTranslation", "Expected Housing Lifespan (Years)", "Expected Housing Lifespan (Years)1", "Expected Housing Lifespan (Years)2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SliderControlTranslation", "If new housing built (rather than maintenance) lifespan in years + expected salvage value at end ? ", "If new housing built(rather than maintenance)lifespan in years + expected salvage value at end ? Lang1", "If new housing built(rather than maintenance)lifespan in years + expected salvage value at end ? Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WaterCostTitleTranslation", "Water Cost", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WaterPurchasedTranslation", "Water Purchased", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanRepaymentTitleTranslation", "Loan Repayment", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherAnimalPurchasedTranslation", "Purchased from", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchasedFromTranslation", "Purchased from", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NumberPurchasedTranslation", "Number purchased", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherAnimalTypeTranslation", "Animal type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalTypeTranslation", "Animal type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchaseTitleTranslation", "Animal Purchase", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherWhoProvidedServiceTranslation", "Who Provided Service", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WhoProvidedServiceTranslation", "Who Provided Service", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SowsServicedTranslation", "Sows Serviced", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CostTrans", "Cost", "Cost Lang1", "Cost Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherServiceTypeTranslation", "Other service type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ReproductiveTitleTranslation", "Reproduction", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherWhatForTranslation", "What for", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherCostTitleTranslation", "Other Cost", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TimePeriodTranslation", "Time-period covered", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherMembershipTypeTranslation", "Other type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MembershipTypeTranslation", "Membership type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MembershipTitleTranslation", "Co-Operative / Group membership", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherPurchasedWaterFromTranslation", "Purchased From", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PurchasedWaterFromTranslation", "Who Purchased From", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherWaterPurchasedTranslation", "Other unit", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ServiceTypeTranslation", "Service type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanProviderTranslation", "Loan Provider", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherAmountPurchaseTrans", "Other Amount Purchased", "Other Amount Purchased Lang1", "Other Amount Purchased Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AmountPurchasedTrans", "Amount Purchased", "Amount Purchased Lang1", "Amount Purchased Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Income", "Income", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanRepayment", "Loan Repayment", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchase", "Animal Purchase", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Other", "Other", "Other Lang1", "Other Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Membership", "Co-Operative / Group membership", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Reproduction", "Reproduction", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Water", "Water", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Housing", "Housing", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Labour", "Labour", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Healthcare", "Healthcare", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Feed", "Feed", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Costs", "Costs", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "RegistrationTranslation", "Registration", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "FilterTranslation", "Filter by:", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Home", "Home", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ViewReports", "Reports", "Reports Lang1", "Reports Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EditData", "View / Edit / Delete data", "View / Edit / Delete data lang1", "View / Edit / Delete data lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AddData", "Add Data", "Add Data lang1", "Add Data lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DateLastUploaded", "Data last uploaded", "Data last uploaded lang1", "Data last uploaded lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Village", "Village", "VillageLang1", "VillageLang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Name", "Name", "NameLang1", "NameLang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PigSale", "Sale of Pigs", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BreedingServiceSale", "Sale of breeding services", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ManureSale", "Sale of manure", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherIncome", "Other Income", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherFeedTypeTrans", "Other Feed Type", "Other Feed Type Lang1", "Other Feed Type Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "FeedTypeTrans", "Feed Type", "Feed Type Lang1", "Feed Type Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DateObtainedTrans", "Date Obtained", "Date Obtained Lang1", "Date Obtained Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AddFeedItemTrans", "Add Feed Cost", "Add Feed Cost Lang1", "Add Feed Cost Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherPurchasedFromTranslation", "Purchased From", "Purchased From Lang1", "Purchased From Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PurchasedFromTranslation", "Purchased From", "Purchased From Lang1", "Purchased From Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherAmountPurchasedUnitTranslation", "Other Amount Purchased", "Other Amount Purchased Lang1", "Other Amount Purchased Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AmountPurchasedUnitTranslation", "Amount Purchased", "Amount Purchased Lang1", "Amount Purchased Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AmountPurchasedTranslation", "Amount Purchased", "Amount Purchased Lang1", "Amount Purchased Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherFeedTypeTranslation", "Other Feed Type", "Other Feed Type Lang1", "Other Feed Type Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "UnitTrans", "Unit", "Unit Lang1", "Unit Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "FeedTypeTranslation", "Feed Type", "Feed Type Lang1", "Feed Type Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DeleteTranslation", "Delete", "Delete Lang1", "Delete Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EditTranslation", "Edit", "Edit Lang1", "Edit Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ResetTranslation", "Reset", "Reset Lang1", "Reset Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SaveTranslation", "Save", "Save Lang1", "Save Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CommentTranslation", "Comment", "Comment Lang1", "Comment Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherCostTranslation", "Any Other Cost", "Any Other Cost Lang1", "Any Other Cost Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TransportationCostTranslation", "Transport Cost", "Transport Cost Lang1", "Transport Cost Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TotalCostTranslation", "Total Cost", "Total Cost Lang1", "Total Cost Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DateTranslation", "Date", "Date Lang1", "Date Lang 2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Equipment", "Equipment", "Equipment Lang1", "Equipment Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "FeedItemTitleTranslation", "Feed Cost", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthProviderType2", "Health Provider Type 2", "Health Provider Type 2 Lang1", "Health Provider Type 2 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherLoanProviderTranslation", "Other Loan Provider", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentTitleTranslation", "Loan Repayment", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerCountryTranslation", "Select a Country", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerSubCountyTranslation", "Select a Sub County", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerCountyTranslation", "Select a County", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerDistrictTranslation", "Select a District", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerGenderTranslation", "Select a Gender", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerClientTranslation", "Select a Client", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerPaymentTypeTranslation", "Select a Payment Type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerSoldToTranslation", "Select a Buyer", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerPigTypeTranslation", "Select a Pig Type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerEquipmentTypeTranslation", "Select an Equipment Type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerAnimalTypeTranslation", "Select a Animal Type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerMembershipTypeTranslation", "Select a Membership", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerServiceTypeTranslation", "Select a Service Type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerHousingExpenseTranslation", "Select an Expense", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerLabourTypeTranslation", "Select a Labour Type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerMedicineTypeTranslation", "Select a Medicine Type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerProviderTranslation", "Select a Provider", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerHealthCareTypeTranslation", "Select a Care Type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerPurchasedFromTranslation", "Select a Provider", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerFeedTypeTranslation", "Select a Feed Type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerUnitTranslation", "Unit", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerCurrencyTranslation", "Select a Currency", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType1", "Feed Type 1", "Feed Type 1 Lang 1", "Feed Type 1 Lang 2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType2", "Feed Type 2", "Feed Type 2 Lang 1", "Feed Type 2 Lang 2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType3", "Feed Type 3", "Feed Type 3 Lang 1", "Feed Type 3 Lang 2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HeathCareType10", "Health Care Type 10", "Health Care Type 10 Lang1", "Health Care Type 10 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HeathCareType9", "Health Care Type 9", "Health Care Type 9 Lang1", "Health Care Type 9 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HeathCareType8", "Health Care Type 8", "Health Care Type 8 Lang1", "Health Care Type 8 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HeathCareType7", "Health Care Type 7", "Health Care Type 7 Lang1", "Health Care Type 7 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HeathCareType6", "Health Care Type 6", "Health Care Type 6 Lang1", "Health Care Type 6 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HeathCareType5", "Health Care Type 5", "Health Care Type 5 Lang1", "Health Care Type 5 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HeathCareType4", "Health Care Type 4", "Health Care Type 4 Lang1", "Health Care Type 4 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HeathCareType3", "Health Care Type 3", "Health Care Type 3 Lang1", "Health Care Type 3 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HeathCareType2", "Health Care Type 2", "Health Care Type 2 Lang1", "Health Care Type 2 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HeathCareType1", "Health Care Type 1", "Health Care Type 1 Lang1", "Health Care Type 1 Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "RegistrationSuccessfulContinueTranslation", "Continue", "Continue Lang 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownPurchaseFrom5", "Puchase From 5", "Puchase From 5 Lang1", "Puchase From 5 lang 2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownPurchaseFrom3", "Puchase From 3", "Puchase From 3 Lang1", "Puchase From 3 lang 2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownPurchaseFrom2", "Puchase From 2", "Puchase From 2 Lang1", "Puchase From 2 lang 2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownPurchaseFrom1", "Puchase From 1", "Puchase From 1 Lang1", "Puchase From 1 lang 2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownUnitType5", "Unit Type 5", "Unit Type 5 lang 1", "Unit Type 5 Lang 2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownUnitType4", "Unit Type 4", "Unit Type 4 lang 1", "Unit Type 4 Lang 2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownUnitType3", "Unit Type 3", "Unit Type 3 lang 1", "Unit Type 3 Lang 2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownUnitType2", "Unit Type 2", "Unit Type 2 lang 1", "Unit Type 2 Lang 2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownUnitType1", "Unit Type 1", "lang 1", "Lang 2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType5", "Feed Type 5", "Feed Type 5 Lang 1", "Feed Type 5 Lang 2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType4", "Feed Type 4", "Feed Type 4 Lang 1", "Feed Type 4 Lang 2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownPurchaseFrom4", "Puchase From 4", "Puchase From 4 Lang1", "Puchase From 4 lang 2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TotalAmountRepaidTranslation", "Total Amount Paid", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "RegistrationSuccessfulDescTranslation", "You can now begin collecting and storing your data", "Begin Lang 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "GoogleSignUpTranslation", "Sign up with Google", "Google Lang 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherIncomeTitleTranslation", "Other Income", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "VolumeSoldTranslation", "Volume Sold", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ManureSaleTitleTranslation", "Sale of Manure", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherClientTranslation", "Other Client", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ClientTranslation", "Client", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PaymentValueTranslation", "Value", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PaymentTypeTranslation", "Type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnyOtherPaymentTranslation", "Any Other Payment Recieved", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AmountRecievedTranslation", "Amount recieved for all services", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NumberServicesTranslation", "Number Services", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BreedingServiceSaleTitleTranslation", "Sale of Reproductive Services", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BrokerageTranslation", "Brokerage", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherSoldToTranslation", "Other Sold To", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SoldToTranslation", "Sold To", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SalePriceTranslation", "Sale Price", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NumberSoldTranslation", "Number Sold", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherPigTypeTranslation", "Other Pig Type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PigTypeTranslation", "Pig type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PigSaleTitleTranslation", "Pig Sales", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherEquipmentTypeTranslation", "Other Loan Provider", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentTypeTranslation", "Loan Provider", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TotalIncomeTranslation", "Total Income", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "RegistrationTitleTranslation", "Registration", "Registration Lang 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "UserNameTranslation", "Username", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NameTranslation", "Name", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WebAuthDescTranslation", "The Pig Economic Tool authenticates with Google to securely authenticate your account and keep your data safe.", "Desc Lang 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WebAuthTitleTranslation", "Sign Up", "Sign Up Lang 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LegalDisclaimerBodyTranslation", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Legal body Lang 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LegalDisclaimerProceedTranslation", "Proceed", "Proceed Lang 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LegalDisclaimerAgreeTranslation", "By checking this box you agree to the terms listed above", "Legal check 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LegalDisclaimerTitleTranslation", "Legal Disclaimer", "Legal Lang 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WhereAreYouLocatedTranslation", "Where Are You Located?", "Located Lang 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LanguageTranslation", "Language", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "GenderTranslation", "Gender", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CurrencyTranslation", "Currency", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "RegistrationSuccessfulTitleTranslation", "Your Account Has Been Created", "Account Created Lang 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CellTranslation", "Cell", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CommuneTranslation", "Commune", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ProvinceTranslation", "Province", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountryTranslation", "Country", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "VillageTranslation", "Village", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ParishTranslation", "Parish", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SubCountyTranslation", "Sub County", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyTranslation", "County", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictTranslation", "District", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PhoneNumberTranslation", "Phone Number", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EmailTranslation", "Email", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SectorTranslation", "Sector", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LanguageType6", "Language6", "", "" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "33dd6696-ff0b-4e7b-ab7e-ad457a268ea5", "InitialUpload", "FeedType", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "731878be-1e52-438f-bb8d-97a0f48c92a5", "InitialUpload", "EquipmentType", false, false, false, "ControlData", null, "EquipmentType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "455a470d-c896-406c-9ecd-83100d2b910f", "InitialUpload", "PigSaleType", false, false, false, "ControlData", null, "PigType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "725e6cc9-e79e-4c9b-af08-4b732215b827", "InitialUpload", "PigSaleType", false, false, false, "ControlData", null, "PigType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9338e787-fa87-4b72-9feb-ff5dd09159de", "InitialUpload", "PigSaleType", false, false, false, "ControlData", null, "PigType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "532a9cf0-aada-4662-9715-1b1fb402e610", "InitialUpload", "PigSaleType", false, false, false, "ControlData", null, "PigType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4bb0054e-e5cf-4ff0-a5b6-c3c6fd83b021", "InitialUpload", "PigSaleType", false, false, false, "ControlData", null, "PigType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7e5e4d11-4de1-4110-8703-15fee6e812d3", "InitialUpload", "PigSaleType", false, false, false, "ControlData", null, "PigType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a8e31078-b6a5-45a2-9a56-3d24d54abce0", "InitialUpload", "PigSaleType", false, false, false, "ControlData", null, "PigType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c1be9444-030b-4140-9e02-1133f1b14be3", "InitialUpload", "PigSaleType", false, false, false, "ControlData", null, "PigType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "96390684-6c43-4ae9-8fb5-e47f6c826bd0", "InitialUpload", "SoldToType", false, false, false, "ControlData", null, "SoldToType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "489ecd39-2de3-449f-86b4-82e5de635c0b", "InitialUpload", "SoldToType", false, false, false, "ControlData", null, "SoldToType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ffb0d7ab-592a-4667-86ef-1a4c931e27e9", "InitialUpload", "SoldToType", false, false, false, "ControlData", null, "SoldToType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b389ae86-f366-4f98-909a-f375cfe83c8d", "InitialUpload", "SoldToType", false, false, false, "ControlData", null, "SoldToType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "bb22866c-4a3b-4c14-89d2-e86373e925f0", "InitialUpload", "SoldToType", false, false, false, "ControlData", null, "SoldToType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "aedca1a9-23a6-47a5-9b0f-5aa991980ae6", "InitialUpload", "SoldToType", false, false, false, "ControlData", null, "SoldToType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0cc8957f-b940-4cbc-a07c-15891e32f35c", "InitialUpload", "SoldToType", false, false, false, "ControlData", null, "SoldToType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "65fcd8ad-49eb-467a-b517-0fb4efbb8491", "InitialUpload", "SoldToType", false, false, false, "ControlData", null, "SoldToType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c8a31408-cd84-4a83-846c-a0924c9cf3a9", "InitialUpload", "BreedingServiceType", false, false, false, "ControlData", null, "BreedingServiceType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a63e28db-756b-4d7e-82b6-14b5358ed10a", "InitialUpload", "BreedingServiceType", false, false, false, "ControlData", null, "BreedingServiceType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b471d517-febd-4675-9f90-104436f8a2c2", "InitialUpload", "BreedingServiceType", false, false, false, "ControlData", null, "BreedingServiceType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e216480c-97b0-49e3-9c93-a9dce8a0f463", "InitialUpload", "BreedingServiceType", false, false, false, "ControlData", null, "BreedingServiceType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "484facc7-305f-4ef6-91d6-f5e3f7aaf3ba", "InitialUpload", "BreedingServiceType", false, false, false, "ControlData", null, "BreedingServiceType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d79efa83-390a-4d9b-ae04-c3322b042d1c", "InitialUpload", "BreedingServiceType", false, false, false, "ControlData", null, "BreedingServiceType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2e7ec4aa-bb8d-4908-b0fb-8dc9e72be4cc", "InitialUpload", "BreedingServiceType", false, false, false, "ControlData", null, "BreedingServiceType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c653f8ff-95a6-485d-bbf5-0ad21458c130", "InitialUpload", "BreedingServiceType", false, false, false, "ControlData", null, "BreedingServiceType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "40a22c8b-b2ce-4a85-b5de-aac1242928d1", "InitialUpload", "OtherPaymentType", false, false, false, "ControlData", null, "PaymentType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "36b63c5c-210b-4b98-8e0b-6f900f1124b3", "InitialUpload", "OtherPaymentType", false, false, false, "ControlData", null, "PaymentType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "18440a2d-a7aa-4df6-9dd5-8b408863487d", "InitialUpload", "EquipmentType", false, false, false, "ControlData", null, "EquipmentType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "968ce3af-a275-457f-a3e0-4d9118b10296", "InitialUpload", "EquipmentType", false, false, false, "ControlData", null, "EquipmentType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "500932b2-8bd3-4b03-b437-99f8b6ad2ea3", "InitialUpload", "EquipmentType", false, false, false, "ControlData", null, "EquipmentType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6fe0a19c-600f-48c0-aa2f-76d9dcd86b4c", "InitialUpload", "EquipmentType", false, false, false, "ControlData", null, "EquipmentType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b3b13bc6-cac9-4f6b-a54c-697d807eb62d", "InitialUpload", "WhoProvidedServiceUnit", false, false, false, "ControlData", null, "WhoProvidedServiceType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "022db153-1387-49dd-90c4-b47356a870ae", "InitialUpload", "AnimalType", false, false, false, "ControlData", null, "AnimalType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f8be0d6b-94a0-4c91-8b7f-35641d92993a", "InitialUpload", "AnimalType", false, false, false, "ControlData", null, "AnimalType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "504f3ed5-0e97-4676-a3e5-8831b6956be4", "InitialUpload", "AnimalType", false, false, false, "ControlData", null, "AnimalType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5696bd2b-4ae4-409a-88e9-3a9321db4d35", "InitialUpload", "AnimalType", false, false, false, "ControlData", null, "AnimalType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "46090bc7-f6f3-4ab9-8437-47528c9d8dcd", "InitialUpload", "AnimalType", false, false, false, "ControlData", null, "AnimalType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a3c6283d-2b9e-46ea-895f-f5aab0a61d8c", "InitialUpload", "AnimalType", false, false, false, "ControlData", null, "AnimalType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b8eafa32-e74d-4a89-8f6e-391009eb3981", "InitialUpload", "AnimalType", false, false, false, "ControlData", null, "AnimalType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "794c2cd5-6dad-4eb8-ab5a-a9b7e285e779", "InitialUpload", "AnimalType", false, false, false, "ControlData", null, "AnimalType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2b93f016-d455-4596-8046-d2bbe2f5b921", "InitialUpload", "AnimalPurchasedFrom", false, false, false, "ControlData", null, "AnimalPurchasedFromType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4111dd0c-d08a-4ea1-a464-f8cd020a51b7", "InitialUpload", "AnimalPurchasedFrom", false, false, false, "ControlData", null, "AnimalPurchasedFromType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b1b517b4-3f36-486d-95cd-da00f02464cd", "InitialUpload", "AnimalPurchasedFrom", false, false, false, "ControlData", null, "AnimalPurchasedFromType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "84a79d41-9315-46c5-b91e-3624871d941e", "InitialUpload", "AnimalPurchasedFrom", false, false, false, "ControlData", null, "AnimalPurchasedFromType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "19941bc4-a493-467f-9911-2daff9970877", "InitialUpload", "OtherPaymentType", false, false, false, "ControlData", null, "PaymentType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "fc4aec32-38d3-409e-a444-fdbffec9b58c", "InitialUpload", "AnimalPurchasedFrom", false, false, false, "ControlData", null, "AnimalPurchasedFromType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "905951d7-7f86-46db-9916-599e21d07e30", "InitialUpload", "AnimalPurchasedFrom", false, false, false, "ControlData", null, "AnimalPurchasedFromType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "17e44b9d-3fb5-45bc-af31-f8978d836ecc", "InitialUpload", "AnimalPurchasedFrom", false, false, false, "ControlData", null, "AnimalPurchasedFromType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c5b1aaa4-0494-4d2d-9e7b-dcb034ea67ff", "InitialUpload", "LoanProvider", false, false, false, "ControlData", null, "LoanProviderType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ad34f5fe-0fd7-4b7d-866d-f0be6c506f3a", "InitialUpload", "LoanProvider", false, false, false, "ControlData", null, "LoanProviderType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "aae1e9c7-e678-4735-a73d-06a26b0395a9", "InitialUpload", "LoanProvider", false, false, false, "ControlData", null, "LoanProviderType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2430d837-2579-4ea3-b346-7a7f2f29e992", "InitialUpload", "LoanProvider", false, false, false, "ControlData", null, "LoanProviderType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c8e3589b-4894-49c7-af06-c1cdc72d3780", "InitialUpload", "LoanProvider", false, false, false, "ControlData", null, "LoanProviderType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ad2736c3-0fb6-489d-ac67-55d1c734ceef", "InitialUpload", "LoanProvider", false, false, false, "ControlData", null, "LoanProviderType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9d270deb-ec6e-4aa3-827d-06bec5e98ce2", "InitialUpload", "LoanProvider", false, false, false, "ControlData", null, "LoanProviderType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "cce2487f-ab0f-496e-9b55-b819afdfade9", "InitialUpload", "LoanProvider", false, false, false, "ControlData", null, "LoanProviderType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5ee0861c-f202-4d50-ac12-a00bdd59b86f", "InitialUpload", "EquipmentType", false, false, false, "ControlData", null, "EquipmentType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e1d12c0c-eac4-48e1-a431-83dba23aa681", "InitialUpload", "EquipmentType", false, false, false, "ControlData", null, "EquipmentType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5783fb33-966a-4fad-88f3-4a94e0a8bf9c", "InitialUpload", "EquipmentType", false, false, false, "ControlData", null, "EquipmentType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "549387a2-6276-4f8b-b312-1fda4f624da0", "InitialUpload", "AnimalPurchasedFrom", false, false, false, "ControlData", null, "AnimalPurchasedFromType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4e2c4824-86b1-457d-8b39-c0e40c636003", "InitialUpload", "OtherPaymentType", false, false, false, "ControlData", null, "PaymentType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "48c63c9a-b064-4298-b3df-ad668c83975c", "InitialUpload", "OtherPaymentType", false, false, false, "ControlData", null, "PaymentType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6bdc9e9b-9439-4990-914f-7ef5620a4fc9", "InitialUpload", "OtherPaymentType", false, false, false, "ControlData", null, "PaymentType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c3bcea91-8097-41ae-bd98-c6f89b554e8d", "InitialUpload", "CountyType", false, false, false, "ControlData", null, "CountyType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3c27c560-eb3d-49e8-83e6-25271dca6106", "InitialUpload", "CountyType", false, false, false, "ControlData", null, "CountyType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "df8dc15d-1210-46b4-b004-e9599965a209", "InitialUpload", "CountyType", false, false, false, "ControlData", null, "CountyType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7d1ad303-3baf-4e98-ba5d-8b578fa5461e", "InitialUpload", "CountyType", false, false, false, "ControlData", null, "CountyType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2339590e-dfbe-45da-92ac-810f6b924398", "InitialUpload", "CountyType", false, false, false, "ControlData", null, "CountyType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "96d3a2c5-3edf-4e63-b224-456604e5c3d4", "InitialUpload", "SubCountyType", false, false, false, "ControlData", null, "SubCountyType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f0029cf6-8ce1-4204-ba07-657904e56870", "InitialUpload", "SubCountyType", false, false, false, "ControlData", null, "SubCountyType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e7af62e8-a9fe-4309-8e8e-75bb9ac67f6b", "InitialUpload", "SubCountyType", false, false, false, "ControlData", null, "SubCountyType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9330b9a3-7354-4957-a4db-061954dccba8", "InitialUpload", "SubCountyType", false, false, false, "ControlData", null, "SubCountyType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a85981d6-aa48-41ee-a789-15bcda61657e", "InitialUpload", "SubCountyType", false, false, false, "ControlData", null, "SubCountyType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e8a2599b-db81-47e2-9e8e-b2155865b2a5", "InitialUpload", "SubCountyType", false, false, false, "ControlData", null, "SubCountyType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "cc145455-326b-4348-8993-c4d3553839e9", "InitialUpload", "SubCountyType", false, false, false, "ControlData", null, "SubCountyType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8c7db5ee-6866-43db-9218-1b2d2b67b31b", "InitialUpload", "SubCountyType", false, false, false, "ControlData", null, "SubCountyType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5f4a2a5e-bf1c-4efb-8393-eb1c431a4bb8", "InitialUpload", "CountyType", false, false, false, "ControlData", null, "CountyType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "be42c552-280b-452d-b69c-bc687273ea63", "InitialUpload", "CountryType", false, false, false, "ControlData", null, "CountryTypeUganda" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e91d3227-155d-4cd3-9d18-62b696dedc1f", "InitialUpload", "CountryType", false, false, false, "ControlData", null, "CountryTypeRwanda" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c92a5ba1-41fc-4d0a-af34-e06d8f6292b7", "InitialUpload", "CurrencyType", false, false, false, "ControlData", null, "CurrencyType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "aed38e79-1e3a-4091-b290-b45bf8a79b48", "InitialUpload", "CurrencyType", false, false, false, "ControlData", null, "CurrencyType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "26ae3cb0-0e8d-43c5-aa9d-45f03338278b", "InitialUpload", "CurrencyType", false, false, false, "ControlData", null, "CurrencyType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "dc9303be-9a28-4130-b634-613b938da323", "InitialUpload", "CurrencyType", false, false, false, "ControlData", null, "CurrencyType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8bf4615f-b330-4810-b06d-81601e46f10a", "InitialUpload", "CurrencyType", false, false, false, "ControlData", null, "CurrencyType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "50e23128-200e-4d4c-81f7-58fb9f9b096a", "InitialUpload", "CurrencyType", false, false, false, "ControlData", null, "CurrencyType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f05b9332-4717-4dae-9bdf-329fd71d950b", "InitialUpload", "CurrencyType", false, false, false, "ControlData", null, "CurrencyType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "fefaf63c-6b89-480e-b4ae-e58f25b6d8a9", "InitialUpload", "CurrencyType", false, false, false, "ControlData", null, "CurrencyType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "bc0cebc4-bee1-4c15-906f-11052d035df4", "InitialUpload", "LanguageType", false, false, false, "ControlData", null, "LanguageType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "51707e76-c8ba-41a3-b49c-477858610ccf", "InitialUpload", "LanguageType", false, false, false, "ControlData", null, "LanguageType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f3cbff03-f854-4f12-8eda-9ba99e224757", "InitialUpload", "LanguageType", false, false, false, "ControlData", null, "LanguageType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b57246a9-9f63-4872-ad4f-7acd2c56e680", "InitialUpload", "LanguageType", false, false, false, "ControlData", null, "LanguageType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "bb4af57c-e3b7-41b9-80c4-37744b5f0808", "InitialUpload", "CountryType", false, false, false, "ControlData", null, "CountryTypeVietnam" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "32e5a815-e9a4-4a28-a64d-2e83eb8d6277", "InitialUpload", "WhoProvidedServiceUnit", false, false, false, "ControlData", null, "WhoProvidedServiceType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "35bb48d1-0af4-4780-8988-2781f0d9417a", "InitialUpload", "CountyType", false, false, false, "ControlData", null, "CountyType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9d8affcd-9acd-46a2-bea8-3ef176ce6caf", "InitialUpload", "DistrictType", false, false, false, "ControlData", null, "DistrictType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "da009a24-818a-4b73-ad09-d795443f920a", "InitialUpload", "OtherPaymentType", false, false, false, "ControlData", null, "PaymentType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2aa4083f-7e48-4f25-b6a0-e21dab077257", "InitialUpload", "OtherPaymentType", false, false, false, "ControlData", null, "PaymentType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3a897bee-e43e-4ea1-9758-81771fbb0b2e", "InitialUpload", "ClientType", false, false, false, "ControlData", null, "ClientType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1c86169f-280a-4c88-a98b-7b0c2b894830", "InitialUpload", "ClientType", false, false, false, "ControlData", null, "ClientType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "76146892-90c5-4349-ad4c-d4ebd69c4001", "InitialUpload", "ClientType", false, false, false, "ControlData", null, "ClientType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1abbc9e6-1503-46fc-88bb-0e8dade2b973", "InitialUpload", "ClientType", false, false, false, "ControlData", null, "ClientType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "85d32d7d-a83c-4397-87b6-b32e20ff4527", "InitialUpload", "ClientType", false, false, false, "ControlData", null, "ClientType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3b043a6a-5c6c-4c3d-863c-db720604fbb2", "InitialUpload", "ClientType", false, false, false, "ControlData", null, "ClientType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a34ed11d-43a4-4faa-9edf-b006bf0d3aa5", "InitialUpload", "ClientType", false, false, false, "ControlData", null, "ClientType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f7049639-5b18-4067-bee9-331b04440f25", "InitialUpload", "ClientType", false, false, false, "ControlData", null, "ClientType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8c21da81-a509-47db-a0ee-5407b76214dc", "InitialUpload", "VolumeUnitType", false, false, false, "ControlData", null, "VolumeUnitType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "06c5ff82-f4f0-46a4-91ec-265a727d077a", "InitialUpload", "VolumeUnitType", false, false, false, "ControlData", null, "VolumeUnitType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1dd70f74-5c69-40b9-9591-77e095802ce4", "InitialUpload", "VolumeUnitType", false, false, false, "ControlData", null, "VolumeUnitType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ecbf7900-5854-4bee-90d1-7bcecea5e4a1", "InitialUpload", "CountyType", false, false, false, "ControlData", null, "CountyType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2f2a212d-55c8-4ea4-a98f-d2bc8be2e048", "InitialUpload", "VolumeUnitType", false, false, false, "ControlData", null, "VolumeUnitType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "fa73fe90-8905-4d22-aa89-596c059cab10", "InitialUpload", "VolumeUnitType", false, false, false, "ControlData", null, "VolumeUnitType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6fb6b880-ed52-478a-b7f4-e39342fbcc82", "InitialUpload", "VolumeUnitType", false, false, false, "ControlData", null, "VolumeUnitType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b0856c7e-d860-4d2d-8696-85879b1c9680", "InitialUpload", "VolumeUnitType", false, false, false, "ControlData", null, "VolumeUnitType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a2d22c15-128a-41c2-a678-81b5ac99a5b6", "InitialUpload", "GenderType", false, false, false, "ControlData", null, "GenderType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "57a462ac-7090-4950-a023-af822ae18aea", "InitialUpload", "GenderType", false, false, false, "ControlData", null, "GenderType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "67a63cac-872c-439e-9c14-8bbae659537a", "InitialUpload", "GenderType", false, false, false, "ControlData", null, "GenderType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a93f52d4-3dec-4c78-ab66-860128541c71", "InitialUpload", "DistrictType", false, false, false, "ControlData", null, "DistrictType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "abf966e9-24c7-4849-b554-51d45aabd2d9", "InitialUpload", "DistrictType", false, false, false, "ControlData", null, "DistrictType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c040fa68-5653-4857-8086-ab4dd3a05696", "InitialUpload", "DistrictType", false, false, false, "ControlData", null, "DistrictType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "def3815c-bd5c-48ef-a2b3-5d5ef5073fdd", "InitialUpload", "DistrictType", false, false, false, "ControlData", null, "DistrictType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3f122529-f65f-4bdb-be83-4481b6dc7c01", "InitialUpload", "DistrictType", false, false, false, "ControlData", null, "DistrictType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a4aa9aeb-e1a0-4272-bd4e-79136a01e99d", "InitialUpload", "DistrictType", false, false, false, "ControlData", null, "DistrictType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8354fb27-40f6-49c4-a724-ca89bb281593", "InitialUpload", "DistrictType", false, false, false, "ControlData", null, "DistrictType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f0754927-9d18-4ef7-b36b-470437ff63b3", "InitialUpload", "VolumeUnitType", false, false, false, "ControlData", null, "VolumeUnitType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "db6c29aa-8acd-4694-a45c-d794825adfdc", "InitialUpload", "LanguageType", false, false, false, "ControlData", null, "LanguageType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f5f6138f-af60-40c5-98e8-b253f3cf0f3c", "InitialUpload", "WhoProvidedServiceUnit", false, false, false, "ControlData", null, "WhoProvidedServiceType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "90bfdbba-1952-4cce-a326-3f11a5045c20", "InitialUpload", "WhoProvidedServiceUnit", false, false, false, "ControlData", null, "WhoProvidedServiceType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "553ebfda-0d6e-4ef1-aa6d-82f7d51b0a33", "InitialUpload", "FeedPurchasedType", false, false, false, "ControlData", null, "DropDownPurchaseFrom2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2b5bb41d-7103-4a8b-8088-fc84a0c10313", "InitialUpload", "FeedPurchasedType", false, false, false, "ControlData", null, "DropDownPurchaseFrom3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7998ad1f-81be-4bc7-b87f-4df55e6686d8", "InitialUpload", "FeedPurchasedType", false, false, false, "ControlData", null, "DropDownPurchaseFrom4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "65ff722a-b1f1-4daa-9732-96ba1acd4f05", "InitialUpload", "FeedPurchasedType", false, false, false, "ControlData", null, "DropDownPurchaseFrom5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7adbfc32-6d5f-4a26-96f1-84fcc58ffe5d", "InitialUpload", "HealthCareType", false, false, false, "ControlData", null, "HeathCareType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6940997c-e88f-4d13-b7eb-858eb0b5238b", "InitialUpload", "HealthCareType", false, false, false, "ControlData", null, "HeathCareType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4cef8282-c6ce-40f0-956f-6c2c9dd70bd6", "InitialUpload", "HealthCareType", false, false, false, "ControlData", null, "HeathCareType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1bb10e8d-7dc2-4f91-907a-ffe676f17a02", "InitialUpload", "HealthCareType", false, false, false, "ControlData", null, "HeathCareType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c7609635-aa82-41ff-9419-9359ed64cc0c", "InitialUpload", "HealthCareType", false, false, false, "ControlData", null, "HeathCareType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "589bce87-c6b9-497f-b623-aea9846369c8", "InitialUpload", "HealthCareType", false, false, false, "ControlData", null, "HeathCareType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d2871851-29b7-4c01-8abf-2b2181b31a23", "InitialUpload", "HealthCareType", false, false, false, "ControlData", null, "HeathCareType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3bb1a211-a40f-4416-ad9d-6a6b74faf5cc", "InitialUpload", "HealthCareType", false, false, false, "ControlData", null, "HeathCareType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "cf047d03-dda7-45b9-95aa-c697812c8de1", "InitialUpload", "HealthCareType", false, false, false, "ControlData", null, "HeathCareType9" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "55b318b1-b016-4fe9-a485-2ed9d83b4e97", "InitialUpload", "HealthCareType", false, false, false, "ControlData", null, "HeathCareType10" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7681e671-cfd7-4d1c-ae82-0ad4656662f8", "InitialUpload", "HealthServivceProivderType", false, false, false, "ControlData", null, "HealthProviderType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b6f5e60a-5e4e-44f9-a871-036a5f9efd3d", "InitialUpload", "HealthServivceProivderType", false, false, false, "ControlData", null, "HealthProviderType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8801c920-ab84-4716-8876-059af0c6fba2", "InitialUpload", "HealthServivceProivderType", false, false, false, "ControlData", null, "HealthProviderType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "81b996d1-2870-4f8a-8927-019aa1564478", "InitialUpload", "HealthServivceProivderType", false, false, false, "ControlData", null, "HealthProviderType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2322fd0e-6c35-41c8-bca5-37a8c63897a2", "InitialUpload", "HealthServivceProivderType", false, false, false, "ControlData", null, "HealthProviderType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "bee5e4b6-09cb-4b83-9712-439bc2b265e3", "InitialUpload", "HealthServivceProivderType", false, false, false, "ControlData", null, "HealthProviderType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "41404c13-71ca-44a7-8a2a-1c65b9ea223f", "InitialUpload", "HealthServivceProivderType", false, false, false, "ControlData", null, "HealthProviderType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d191f6ef-e5df-4584-9e07-f7b8555d3176", "InitialUpload", "HealthServivceProivderType", false, false, false, "ControlData", null, "HealthProviderType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c029e39e-6990-4ff8-9d73-70f64871b917", "InitialUpload", "HealthServivceProivderType", false, false, false, "ControlData", null, "HealthProviderType9" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "631a749a-d236-4666-822f-87446453acce", "InitialUpload", "HealthServivceProivderType", false, false, false, "ControlData", null, "HealthProviderType10" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e2a6e0a3-0b6f-4c61-af84-19c7c902b4f6", "InitialUpload", "HealthMedicineType", false, false, false, "ControlData", null, "MedicineType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0de07c69-9ae5-44c5-8128-f08f97d5d5b6", "InitialUpload", "HealthMedicineType", false, false, false, "ControlData", null, "MedicineType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7ec4c589-9b22-4901-b70f-754de4417d66", "InitialUpload", "HealthMedicineType", false, false, false, "ControlData", null, "MedicineType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "641da57a-3a79-4b1d-a22a-8796ec910d6b", "InitialUpload", "FeedPurchasedType", false, false, false, "ControlData", null, "DropDownPurchaseFrom1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "eed360b2-4897-4ba7-8cf0-240d7a4afc48", "InitialUpload", "FeedAmountPurchasedUnitType", false, false, false, "ControlData", null, "DropDownUnitType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "12345833-755c-43ce-b43c-a1a68827c415", "InitialUpload", "FeedAmountPurchasedUnitType", false, false, false, "ControlData", null, "DropDownUnitType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e5644835-1c84-47b5-9709-c7af1695eb1f", "InitialUpload", "FeedAmountPurchasedUnitType", false, false, false, "ControlData", null, "DropDownUnitType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a0a7107f-5e10-4616-b625-f5e98c84b048", "InitialUpload", "FeedAmountPurchasedUnitType", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5f101b4b-4423-468a-bc8b-5e5e0a2b071b", "InitialUpload", "HealthCareType", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9bfbb686-151f-4de7-a175-f60ddf7647a4", "InitialUpload", "HealthServivceProivderType", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ad8412a2-22a7-4360-bb43-2ef0fc38202a", "InitialUpload", "HealthMedicineType", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f5214926-0d05-4927-ab93-b116b009655c", "InitialUpload", "HealthPurchaseFromType", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8b36bd11-2ea5-4d2f-85b2-9e8fe082f805", "InitialUpload", "LabourType", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "eefc18f8-0b0b-4865-9aba-be28129bf4b1", "InitialUpload", "HousingType", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8e345f4c-2419-40cd-b577-fc5728516817", "InitialUpload", "WaterPurchasedUnit", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "eac345af-1e4f-47d8-936a-465dd36c199d", "InitialUpload", "PurchasedWaterFrom", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7ae23d90-56f5-433c-a463-6fadc6e7ca29", "InitialUpload", "MembershipType", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e17ca62c-7869-48ff-ae8d-1ad1d5f798b2", "InitialUpload", "ServiceUnit", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "459dc4fe-ebe2-4ea1-9424-da4ec84b7b5b", "InitialUpload", "WhoProvidedServiceUnit", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f5ae3d33-ed9c-465e-a357-9635987ef857", "InitialUpload", "AnimalType", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d8b4b3df-1124-415e-8b7e-2ff363140653", "InitialUpload", "HealthMedicineType", false, false, false, "ControlData", null, "MedicineType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "70906284-417a-44f1-8257-f007b442498e", "InitialUpload", "AnimalPurchasedFrom", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4dd982a3-41f7-4f2b-ac87-22bae7afe8ce", "InitialUpload", "EquipmentType", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1eb04dad-4ba6-4b47-b102-63d4dd3aac7f", "InitialUpload", "PigSaleType", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "53eac784-5c1a-4ada-891b-15e15d62ffb3", "InitialUpload", "SoldToType", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "42838363-a487-4d24-87f9-eb4156fedf10", "InitialUpload", "BreedingServiceType", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7ccb272a-0691-4d9e-b7e8-38b9c0b193bd", "InitialUpload", "ClientType", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9e78c3a8-0535-4729-ae4c-060e8163fa95", "InitialUpload", "VolumeUnitType", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "110707a0-8a83-4ca5-9a3b-48e219422f1c", "InitialUpload", "FeedType", false, false, false, "ControlData", null, "DropDownFeedType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3f550a6c-b389-4639-9577-d863dcae03dc", "InitialUpload", "FeedType", false, false, false, "ControlData", null, "DropDownFeedType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "78a69590-ab81-4802-b98b-0b9d8878dde3", "InitialUpload", "FeedType", false, false, false, "ControlData", null, "DropDownFeedType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e5538d36-eee6-4c59-9cf0-1048d8ed9101", "InitialUpload", "FeedType", false, false, false, "ControlData", null, "DropDownFeedType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6af2f9cd-3963-4400-a61b-db75033ca639", "InitialUpload", "FeedType", false, false, false, "ControlData", null, "DropDownFeedType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a56cc8ba-239c-4542-bb3c-6b5ea5aca3e2", "InitialUpload", "FeedAmountPurchasedUnitType", false, false, false, "ControlData", null, "DropDownUnitType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "82b81faf-fd43-4947-abb9-d11e5066e88d", "InitialUpload", "FeedAmountPurchasedUnitType", false, false, false, "ControlData", null, "DropDownUnitType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4af79cc1-333d-4612-a072-024c76fe1ec1", "InitialUpload", "LoanProvider", false, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e66b5b2c-b96e-4a4b-aff9-c8e2b19c08ef", "InitialUpload", "HealthMedicineType", false, false, false, "ControlData", null, "MedicineType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "43b618aa-22f5-4da7-aa01-b449775195d0", "InitialUpload", "HealthMedicineType", false, false, false, "ControlData", null, "MedicineType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "93b326e4-bf8c-4cb4-9b09-dfc457d76f40", "InitialUpload", "HealthMedicineType", false, false, false, "ControlData", null, "MedicineType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e33917df-21bd-4329-bba2-66ddf9a93b10", "InitialUpload", "PurchasedWaterFrom", false, false, false, "ControlData", null, "PurchasedWaterFromType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "102c537a-6eb8-46ac-aacf-3d1ed000fa05", "InitialUpload", "PurchasedWaterFrom", false, false, false, "ControlData", null, "PurchasedWaterFromType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3dcb0775-f933-4d11-909f-f14e735d71fd", "InitialUpload", "PurchasedWaterFrom", false, false, false, "ControlData", null, "PurchasedWaterFromType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3e078f73-d2d4-452d-b5ec-f2ea74abf582", "InitialUpload", "PurchasedWaterFrom", false, false, false, "ControlData", null, "PurchasedWaterFromType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "49be1dfe-4e57-4dec-a2a9-ac5ad757d208", "InitialUpload", "PurchasedWaterFrom", false, false, false, "ControlData", null, "PurchasedWaterFromType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7e242b21-cd01-4a09-a5f4-1ad316533a61", "InitialUpload", "PurchasedWaterFrom", false, false, false, "ControlData", null, "PurchasedWaterFromType9" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6de118bc-c326-4c79-96ca-7d383cc14067", "InitialUpload", "PurchasedWaterFrom", false, false, false, "ControlData", null, "PurchasedWaterFromType10" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "dfa5be08-e422-4a79-a388-7304dd984089", "InitialUpload", "MembershipType", false, false, false, "ControlData", null, "MembershipType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5a1832ea-e986-438f-9d87-b2cfd5d1fe2a", "InitialUpload", "MembershipType", false, false, false, "ControlData", null, "MembershipType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7c84e78a-e30d-47fd-aade-ecd3d83eb131", "InitialUpload", "MembershipType", false, false, false, "ControlData", null, "MembershipType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e874f451-847f-420a-9249-bf35ff91931b", "InitialUpload", "MembershipType", false, false, false, "ControlData", null, "MembershipType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e7ab013e-24b9-4822-b5c2-e96be6e9ffc0", "InitialUpload", "MembershipType", false, false, false, "ControlData", null, "MembershipType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "03431c4a-7254-468a-a25a-6dca8a472e8b", "InitialUpload", "MembershipType", false, false, false, "ControlData", null, "MembershipType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7bf477d6-a834-405f-b3ed-8b294eb99957", "InitialUpload", "PurchasedWaterFrom", false, false, false, "ControlData", null, "PurchasedWaterFromType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9493f8f6-2b26-4131-af92-33c72dd88baa", "InitialUpload", "MembershipType", false, false, false, "ControlData", null, "MembershipType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b6ab98ab-a3f7-41cc-9d72-4bbcdd0afd57", "InitialUpload", "TimePeriodUnitType", false, false, false, "ControlData", null, "TimePeriodUnitType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c02abbf3-469f-4386-adcb-da07a4aec368", "InitialUpload", "TimePeriodUnitType", false, false, false, "ControlData", null, "TimePeriodUnitType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6962a35b-b962-45ef-96cf-c96f7898b956", "InitialUpload", "ServiceUnit", false, false, false, "ControlData", null, "ServiceType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "34554b0a-ff01-41ec-b6f2-6a8d39dfef39", "InitialUpload", "ServiceUnit", false, false, false, "ControlData", null, "ServiceType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7f1a5a1f-a545-4982-9ae9-f0275934596d", "InitialUpload", "ServiceUnit", false, false, false, "ControlData", null, "ServiceType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d0c8bbd6-f87e-48ad-badf-92956855c8f4", "InitialUpload", "ServiceUnit", false, false, false, "ControlData", null, "ServiceType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "04467d82-5a53-44e8-a556-475cb3805bea", "InitialUpload", "ServiceUnit", false, false, false, "ControlData", null, "ServiceType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d96cde38-80c8-49a1-aa2e-3f8b2668fd23", "InitialUpload", "ServiceUnit", false, false, false, "ControlData", null, "ServiceType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f9177553-4569-4ef6-b357-a0d783c5ddce", "InitialUpload", "ServiceUnit", false, false, false, "ControlData", null, "ServiceType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b5986512-9e68-44b2-ac63-6c10c21c80d1", "InitialUpload", "ServiceUnit", false, false, false, "ControlData", null, "ServiceType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7be5a8eb-ee91-4afd-93f5-e7e195992eca", "InitialUpload", "WhoProvidedServiceUnit", false, false, false, "ControlData", null, "WhoProvidedServiceType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "659c230c-b0fe-4122-83f6-14fa9d03e8c6", "InitialUpload", "WhoProvidedServiceUnit", false, false, false, "ControlData", null, "WhoProvidedServiceType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2b442b07-3069-4e35-8e38-f4a78d4c9993", "InitialUpload", "WhoProvidedServiceUnit", false, false, false, "ControlData", null, "WhoProvidedServiceType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "339209a8-b4d6-4af1-97f4-64b9c7f85a7e", "InitialUpload", "MembershipType", false, false, false, "ControlData", null, "MembershipType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "248a0df9-db32-4bc2-8952-c5558133fcd5", "InitialUpload", "WhoProvidedServiceUnit", false, false, false, "ControlData", null, "WhoProvidedServiceType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a122bf03-2b88-4a25-ba43-b40cff64319f", "InitialUpload", "PurchasedWaterFrom", false, false, false, "ControlData", null, "PurchasedWaterFromType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7dc46730-9dd3-4419-a840-214844a7af4c", "InitialUpload", "WaterPurchasedUnit", false, false, false, "ControlData", null, "WaterPurchasedUnitType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e8c930db-3f2e-47ff-9684-19965f23a301", "InitialUpload", "HealthMedicineType", false, false, false, "ControlData", null, "MedicineType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "50f5913e-02cc-494d-8ac5-abb768030611", "InitialUpload", "HealthMedicineType", false, false, false, "ControlData", null, "MedicineType9" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c746f11c-d277-4ded-a3a4-1548efe52654", "InitialUpload", "HealthMedicineType", false, false, false, "ControlData", null, "MedicineType10" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ac8fcf6b-0543-41c6-b3b8-b35ea0f347c3", "InitialUpload", "HealthPurchaseFromType", false, false, false, "ControlData", null, "PruchaseFromType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c9c5a192-db3a-4b0a-9a8d-7fb55102a788", "InitialUpload", "HealthPurchaseFromType", false, false, false, "ControlData", null, "PruchaseFromType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8ed672d6-8bfb-4823-b09a-42a5359a01ce", "InitialUpload", "HealthPurchaseFromType", false, false, false, "ControlData", null, "PruchaseFromType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2f6c6fb4-3a14-4dcf-aab3-88d2c0f1076c", "InitialUpload", "HealthPurchaseFromType", false, false, false, "ControlData", null, "PruchaseFromType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e4dd4d71-b4dd-4993-b06e-a5147947f933", "InitialUpload", "HealthPurchaseFromType", false, false, false, "ControlData", null, "PruchaseFromType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c5580775-b813-4a5e-a4ed-9a7f69f3151e", "InitialUpload", "HealthPurchaseFromType", false, false, false, "ControlData", null, "PruchaseFromType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "69e99ca1-106f-4cd2-b98b-583eaf1b9256", "InitialUpload", "HealthPurchaseFromType", false, false, false, "ControlData", null, "PruchaseFromType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a1071791-b798-4510-a62e-6b408ead687f", "InitialUpload", "HealthPurchaseFromType", false, false, false, "ControlData", null, "PruchaseFromType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c332c573-884d-4c68-9ab3-4b4ed48f53cb", "InitialUpload", "HealthPurchaseFromType", false, false, false, "ControlData", null, "PruchaseFromType9" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d4523994-f0bd-4386-bda8-8c20d4946d87", "InitialUpload", "HealthPurchaseFromType", false, false, false, "ControlData", null, "PruchaseFromType10" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "cb4e246b-6cdd-4662-9697-354e0a4c8119", "InitialUpload", "PurchasedWaterFrom", false, false, false, "ControlData", null, "PurchasedWaterFromType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0f396a39-b55d-4ffe-a5e5-fbb9477329da", "InitialUpload", "LabourType", false, false, false, "ControlData", null, "LabourType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1a9723ee-dacf-4ab5-8fc1-245d007eed5b", "InitialUpload", "LabourType", false, false, false, "ControlData", null, "LabourType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e210210a-806c-4f65-89dd-b5bb075573fc", "InitialUpload", "LabourType", false, false, false, "ControlData", null, "LabourType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3cedf42e-b301-4fd9-b478-34d39cb6a644", "InitialUpload", "LabourType", false, false, false, "ControlData", null, "LabourType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f844ccd6-2554-4e07-ab94-a6cbc674229f", "InitialUpload", "LabourType", false, false, false, "ControlData", null, "LabourType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "34a61dfd-8d3b-4be1-a06c-12f758b6477d", "InitialUpload", "HousingType", false, false, false, "ControlData", null, "HousingExpenseType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b935f950-5492-4740-9d20-7cf59e63dabd", "InitialUpload", "HousingType", false, false, false, "ControlData", null, "HousingExpenseType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7e03bb35-5eb7-4bd0-b834-490b48e2e8ef", "InitialUpload", "HousingType", false, false, false, "ControlData", null, "HousingExpenseType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9bbe947d-f6aa-4353-9618-57b27fd801fc", "InitialUpload", "HousingType", false, false, false, "ControlData", null, "HousingExpenseType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "09b2bc45-f1ba-4ba4-aa9c-851784100279", "InitialUpload", "HousingType", false, false, false, "ControlData", null, "HousingExpenseType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "24ba0055-5fd3-4db0-bef9-726a6394fb3c", "InitialUpload", "WaterPurchasedUnit", false, false, false, "ControlData", null, "WaterPurchasedUnitType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ba8a0798-abbf-4a76-a95f-fc1bb2f2c418", "InitialUpload", "WaterPurchasedUnit", false, false, false, "ControlData", null, "WaterPurchasedUnitType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7dfc2861-9977-4fd7-8fa5-60d28ee5f710", "InitialUpload", "WaterPurchasedUnit", false, false, false, "ControlData", null, "WaterPurchasedUnitType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "289d5b0f-b636-4635-b53d-198f72c68be4", "InitialUpload", "WaterPurchasedUnit", false, false, false, "ControlData", null, "WaterPurchasedUnitType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9783dd2a-b7dc-47ad-a234-e772c12f96df", "InitialUpload", "LabourType", false, false, false, "ControlData", null, "LabourType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2102f3bc-b820-44eb-a610-e0cb797a54a0", "InitialUpload", "LanguageType", false, false, false, "ControlData", null, "LanguageType6" });

            migrationBuilder.CreateIndex(
                name: "IX_ControlDataOptions_TranslationRowKey",
                table: "ControlDataOptions",
                column: "TranslationRowKey");

            migrationBuilder.CreateIndex(
                name: "IX_FeedItems_FeedType",
                table: "FeedItems",
                column: "FeedType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalHouseItems");

            migrationBuilder.DropTable(
                name: "AnimalPurchaseItems");

            migrationBuilder.DropTable(
                name: "BreedingServiceSaleItems");

            migrationBuilder.DropTable(
                name: "ControlDataOptions");

            migrationBuilder.DropTable(
                name: "EquipmentItems");

            migrationBuilder.DropTable(
                name: "FeedItems");

            migrationBuilder.DropTable(
                name: "HealthCareItems");

            migrationBuilder.DropTable(
                name: "LabourCostItems");

            migrationBuilder.DropTable(
                name: "LoanRepaymentItems");

            migrationBuilder.DropTable(
                name: "ManureSaleItems");

            migrationBuilder.DropTable(
                name: "MembershipItems");

            migrationBuilder.DropTable(
                name: "OtherCostItems");

            migrationBuilder.DropTable(
                name: "OtherIncomeItems");

            migrationBuilder.DropTable(
                name: "PigSaleItems");

            migrationBuilder.DropTable(
                name: "ReproductiveItems");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "WaterCostItems");

            migrationBuilder.DropTable(
                name: "Translations");
        }
    }
}
