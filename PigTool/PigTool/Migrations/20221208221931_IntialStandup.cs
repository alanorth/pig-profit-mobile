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
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HousingExpense = table.Column<string>(type: "TEXT", nullable: true),
                    OtherHousingExpense = table.Column<string>(type: "TEXT", nullable: true),
                    TotalCosts = table.Column<double>(type: "REAL", nullable: false),
                    TransportationCost = table.Column<double>(type: "REAL", nullable: false),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    YearsExpected = table.Column<int>(type: "INTEGER", nullable: true),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsModified = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "AnimalHouse"),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalHouseItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "AnimalPurchaseItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AnimalType = table.Column<string>(type: "TEXT", nullable: true),
                    OtherAnimalType = table.Column<string>(type: "TEXT", nullable: true),
                    NumberPurchased = table.Column<int>(type: "INTEGER", nullable: true),
                    TotalCosts = table.Column<double>(type: "REAL", nullable: false),
                    AnimalPurchasedFrom = table.Column<string>(type: "TEXT", nullable: true),
                    OtherAnimalPurchasedFrom = table.Column<string>(type: "TEXT", nullable: true),
                    TransportationCost = table.Column<double>(type: "REAL", nullable: false),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsModified = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "AnimalPurchase"),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalPurchaseItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "BreedingServiceSaleItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ServiceType = table.Column<string>(type: "TEXT", nullable: true),
                    OtherServiceType = table.Column<string>(type: "TEXT", nullable: true),
                    NumberServices = table.Column<int>(type: "INTEGER", nullable: true),
                    AmountRecieved = table.Column<double>(type: "REAL", nullable: false),
                    PaymentType = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentValue = table.Column<double>(type: "REAL", nullable: false),
                    Client = table.Column<string>(type: "TEXT", nullable: true),
                    OtherClient = table.Column<string>(type: "TEXT", nullable: true),
                    TransportationCost = table.Column<double>(type: "REAL", nullable: false),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsModified = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "BreedingServiceSale"),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreedingServiceSaleItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalCosts = table.Column<double>(type: "REAL", nullable: false),
                    EquipmentType = table.Column<string>(type: "TEXT", nullable: true),
                    OtherEquipmentType = table.Column<string>(type: "TEXT", nullable: true),
                    TransportationCost = table.Column<double>(type: "REAL", nullable: false),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsModified = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "Equipment"),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "HealthCareItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HealthCareType = table.Column<string>(type: "TEXT", nullable: true),
                    OtherHealthCareType = table.Column<string>(type: "TEXT", nullable: true),
                    HealthCareCost = table.Column<double>(type: "REAL", nullable: false),
                    Provider = table.Column<string>(type: "TEXT", nullable: true),
                    OtherProvider = table.Column<string>(type: "TEXT", nullable: true),
                    MedicineCost = table.Column<double>(type: "REAL", nullable: false),
                    MedicineType = table.Column<string>(type: "TEXT", nullable: true),
                    OtherMedicineType = table.Column<string>(type: "TEXT", nullable: true),
                    PurchasedFrom = table.Column<string>(type: "TEXT", nullable: true),
                    OtherPurchasedFrom = table.Column<string>(type: "TEXT", nullable: true),
                    TransportationCost = table.Column<double>(type: "REAL", nullable: false),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsModified = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "HealthCare"),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCareItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "LabourCostItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LabourType = table.Column<string>(type: "TEXT", nullable: true),
                    OtherLabourType = table.Column<string>(type: "TEXT", nullable: true),
                    AmountPaid = table.Column<double>(type: "REAL", nullable: false),
                    OtherCost = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsModified = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "Labour"),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabourCostItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "LoanRepaymentItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalAmountRepaid = table.Column<double>(type: "REAL", nullable: false),
                    LoanProvider = table.Column<string>(type: "TEXT", nullable: true),
                    OtherLoanProvider = table.Column<string>(type: "TEXT", nullable: true),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsModified = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "LoanRepayment"),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanRepaymentItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "ManureSaleItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VolumeSold = table.Column<double>(type: "REAL", nullable: true),
                    VolumeUnitType = table.Column<string>(type: "TEXT", nullable: true),
                    AmountRecieved = table.Column<double>(type: "REAL", nullable: false),
                    PaymentType = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentValue = table.Column<double>(type: "REAL", nullable: false),
                    SoldTo = table.Column<string>(type: "TEXT", nullable: true),
                    OtherSoldTo = table.Column<string>(type: "TEXT", nullable: true),
                    TransportationCost = table.Column<double>(type: "REAL", nullable: false),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsModified = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "ManureSale"),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManureSaleItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "MembershipItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalCosts = table.Column<double>(type: "REAL", nullable: false),
                    MembershipType = table.Column<string>(type: "TEXT", nullable: true),
                    OtherMembershipType = table.Column<string>(type: "TEXT", nullable: true),
                    TimePeriod = table.Column<int>(type: "INTEGER", nullable: false),
                    TimePeriodUnit = table.Column<string>(type: "TEXT", nullable: false),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: true),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsModified = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "MemberShip"),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "OtherCostItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalCosts = table.Column<double>(type: "REAL", nullable: false),
                    OtherWhatFor = table.Column<string>(type: "TEXT", nullable: true),
                    TransportationCosts = table.Column<double>(type: "REAL", nullable: true),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsModified = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "OtherCost"),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherCostItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "OtherIncomeItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalIncome = table.Column<double>(type: "REAL", nullable: false),
                    OtherWhatFor = table.Column<string>(type: "TEXT", nullable: true),
                    TransportationCosts = table.Column<double>(type: "REAL", nullable: false),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsModified = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "OtherIncome"),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherIncomeItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "PigSaleItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PigType = table.Column<string>(type: "TEXT", nullable: true),
                    OtherPigType = table.Column<string>(type: "TEXT", nullable: true),
                    NumberSold = table.Column<int>(type: "INTEGER", nullable: true),
                    SalePrice = table.Column<double>(type: "REAL", nullable: false),
                    SoldTo = table.Column<string>(type: "TEXT", nullable: true),
                    OtherSoldTo = table.Column<string>(type: "TEXT", nullable: true),
                    Brokerage = table.Column<double>(type: "REAL", nullable: false),
                    TransportationCost = table.Column<double>(type: "REAL", nullable: false),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsModified = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "PigSale"),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PigSaleItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "ReproductiveItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ServiceType = table.Column<string>(type: "TEXT", nullable: true),
                    OtherServiceType = table.Column<string>(type: "TEXT", nullable: true),
                    SowsServiced = table.Column<int>(type: "INTEGER", nullable: false),
                    WhoProvidedService = table.Column<string>(type: "TEXT", nullable: true),
                    OtherWhoProvidedService = table.Column<string>(type: "TEXT", nullable: true),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsModified = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "Reproductive"),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReproductiveItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
                    English = table.Column<string>(type: "TEXT", nullable: false),
                    Lang1 = table.Column<string>(type: "TEXT", nullable: false),
                    Lang2 = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    District = table.Column<string>(type: "TEXT", nullable: true),
                    County = table.Column<string>(type: "TEXT", nullable: true),
                    SubCounty = table.Column<string>(type: "TEXT", nullable: true),
                    Parish = table.Column<string>(type: "TEXT", nullable: true),
                    Village = table.Column<string>(type: "TEXT", nullable: true),
                    Province = table.Column<string>(type: "TEXT", nullable: true),
                    Commune = table.Column<string>(type: "TEXT", nullable: true),
                    Sector = table.Column<string>(type: "TEXT", nullable: true),
                    Cell = table.Column<string>(type: "TEXT", nullable: true),
                    Currency = table.Column<string>(type: "TEXT", nullable: false),
                    LastUploadDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserLang = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorisedToken = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorisedEmail = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "WaterCostItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    WaterPurchased = table.Column<double>(type: "REAL", nullable: true),
                    WaterPurchasedUnit = table.Column<string>(type: "TEXT", nullable: true),
                    OtherWaterPurchasedUnit = table.Column<string>(type: "TEXT", nullable: true),
                    TotalCosts = table.Column<double>(type: "REAL", nullable: false),
                    PurchasedWaterFrom = table.Column<string>(type: "TEXT", nullable: true),
                    OtherPurchasedWaterFrom = table.Column<string>(type: "TEXT", nullable: true),
                    TransportationCost = table.Column<double>(type: "REAL", nullable: false),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsModified = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "Water"),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterCostItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "ControlDataOptions",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
                    DropDownControlOption = table.Column<string>(type: "TEXT", nullable: false),
                    TranslationRowKey = table.Column<string>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsModified = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "ControlData"),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlDataOptions", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_ControlDataOptions_Translations_TranslationRowKey",
                        column: x => x.TranslationRowKey,
                        principalTable: "Translations",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeedItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FeedType = table.Column<string>(type: "TEXT", nullable: true),
                    OtherFeedType = table.Column<string>(type: "TEXT", nullable: true),
                    AmountPurchased = table.Column<double>(type: "REAL", nullable: true),
                    AmountPurchasedUnit = table.Column<string>(type: "TEXT", nullable: true),
                    OtherAmountPurchaseUnit = table.Column<string>(type: "TEXT", nullable: true),
                    TotalCosts = table.Column<double>(type: "REAL", nullable: false),
                    TransportationCost = table.Column<double>(type: "REAL", nullable: false),
                    PurchasedFrom = table.Column<string>(type: "TEXT", nullable: true),
                    OtherPurchasedFrom = table.Column<string>(type: "TEXT", nullable: true),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    FeedTypeTranslationString = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsModified = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "Feed"),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
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
                values: new object[] { "a985d0bd-d462-4b64-bcb3-9fc840ce4e87", "InitialUpload", "FeedType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ee66498e-0b00-436c-b9e4-85e44f328988", "InitialUpload", "EquipmentType", true, false, false, "ControlData", null, "EquipmentType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0b7416c0-6b08-4677-ab44-08ae48670b14", "InitialUpload", "PigSaleType", true, false, false, "ControlData", null, "PigType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c2cbc6ae-af32-4599-81a3-58752e5a1b46", "InitialUpload", "PigSaleType", true, false, false, "ControlData", null, "PigType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ffad326e-1cfa-402b-8250-650665096a08", "InitialUpload", "PigSaleType", true, false, false, "ControlData", null, "PigType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "79fdb3e9-a474-4e72-89c2-3464d3091724", "InitialUpload", "PigSaleType", true, false, false, "ControlData", null, "PigType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a1533e8a-6ac1-4f45-9571-2be3d1d09ca2", "InitialUpload", "PigSaleType", true, false, false, "ControlData", null, "PigType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e6a02d0e-cc91-4111-a5a7-44a41c2614f6", "InitialUpload", "PigSaleType", true, false, false, "ControlData", null, "PigType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3918d4d2-56a9-437c-baa2-c18cbc7eccb8", "InitialUpload", "PigSaleType", true, false, false, "ControlData", null, "PigType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1849f893-77ec-4dd6-9ab5-69ff40896e83", "InitialUpload", "PigSaleType", true, false, false, "ControlData", null, "PigType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "445a5d8f-8a57-44d1-960e-a80aeb4c8ef1", "InitialUpload", "SoldToType", true, false, false, "ControlData", null, "SoldToType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "70b61146-6653-48d7-9282-d004151e6bea", "InitialUpload", "SoldToType", true, false, false, "ControlData", null, "SoldToType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ae886681-7cb1-45b6-87f0-3472cbc8c34c", "InitialUpload", "SoldToType", true, false, false, "ControlData", null, "SoldToType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7b6f18cd-df69-4e6d-acfb-9e992d265c53", "InitialUpload", "SoldToType", true, false, false, "ControlData", null, "SoldToType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9be6d4e2-60ab-4984-90ab-4c8bbb48cbd6", "InitialUpload", "SoldToType", true, false, false, "ControlData", null, "SoldToType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "03ff9e3b-30fc-415b-b55e-ad79c6fa69b7", "InitialUpload", "SoldToType", true, false, false, "ControlData", null, "SoldToType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "140f26c0-fe75-452e-a349-f3f222e9587f", "InitialUpload", "SoldToType", true, false, false, "ControlData", null, "SoldToType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "cc09dfc7-a696-43c7-9f98-e9c4d2da57b6", "InitialUpload", "SoldToType", true, false, false, "ControlData", null, "SoldToType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6e791ed2-4799-45ac-9e12-cf7028b000e0", "InitialUpload", "BreedingServiceType", true, false, false, "ControlData", null, "BreedingServiceType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "29ad7f73-9017-440f-9ec6-0f7cbb2915d9", "InitialUpload", "BreedingServiceType", true, false, false, "ControlData", null, "BreedingServiceType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "496c5c92-74df-4a39-af0e-48a70680b2c9", "InitialUpload", "BreedingServiceType", true, false, false, "ControlData", null, "BreedingServiceType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8e2812d3-6d7b-4dd4-9903-955d055a9129", "InitialUpload", "BreedingServiceType", true, false, false, "ControlData", null, "BreedingServiceType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3d7b56f3-0a29-438b-8485-7f40d00c9e15", "InitialUpload", "BreedingServiceType", true, false, false, "ControlData", null, "BreedingServiceType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "47cd3875-7921-4877-b649-0e5ffe9c153b", "InitialUpload", "BreedingServiceType", true, false, false, "ControlData", null, "BreedingServiceType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "687ba879-8831-492c-a9f6-9696a8945090", "InitialUpload", "BreedingServiceType", true, false, false, "ControlData", null, "BreedingServiceType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "aaefb244-2ef1-4482-909f-82e3b0d9b491", "InitialUpload", "BreedingServiceType", true, false, false, "ControlData", null, "BreedingServiceType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a64d62aa-837e-45ad-b704-57916b31d0c7", "InitialUpload", "OtherPaymentType", true, false, false, "ControlData", null, "PaymentType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "83eb3e82-c23f-41b6-b3b6-21fb56226f99", "InitialUpload", "OtherPaymentType", true, false, false, "ControlData", null, "PaymentType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9e607c30-9c3b-48e8-ae29-befaf561a100", "InitialUpload", "EquipmentType", true, false, false, "ControlData", null, "EquipmentType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f1a95033-0af9-433b-bbb5-36fef1f4175f", "InitialUpload", "EquipmentType", true, false, false, "ControlData", null, "EquipmentType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0d630249-04ef-40f6-bf25-649ca30ee2db", "InitialUpload", "EquipmentType", true, false, false, "ControlData", null, "EquipmentType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "cfd4a9dd-933e-4535-abdd-d6fb334ba7de", "InitialUpload", "EquipmentType", true, false, false, "ControlData", null, "EquipmentType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a77960be-af82-495f-b82b-f85a9d347a49", "InitialUpload", "WhoProvidedServiceUnit", true, false, false, "ControlData", null, "WhoProvidedServiceType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "bfee9e65-4d17-4a81-9ecd-1820c31b57ca", "InitialUpload", "AnimalType", true, false, false, "ControlData", null, "AnimalType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5530d4a9-24de-4476-9b3e-b4b0dd69f3cf", "InitialUpload", "AnimalType", true, false, false, "ControlData", null, "AnimalType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "dbe985f1-6987-49b3-9daf-47171934c992", "InitialUpload", "AnimalType", true, false, false, "ControlData", null, "AnimalType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4c76d7ee-1599-42b7-b01f-6be975700b73", "InitialUpload", "AnimalType", true, false, false, "ControlData", null, "AnimalType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "bc18f066-479d-4a5b-ad43-369e8671fabe", "InitialUpload", "AnimalType", true, false, false, "ControlData", null, "AnimalType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f78e4fc1-54a2-4471-b2fe-830b29d81e03", "InitialUpload", "AnimalType", true, false, false, "ControlData", null, "AnimalType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5bb9830c-6ad3-4a67-b876-a1e9b37ebd5b", "InitialUpload", "AnimalType", true, false, false, "ControlData", null, "AnimalType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0baa313f-c068-4494-adbc-ee072967ab0b", "InitialUpload", "AnimalType", true, false, false, "ControlData", null, "AnimalType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e8f495ac-7f87-467e-b93d-0b244d7bc929", "InitialUpload", "AnimalPurchasedFrom", true, false, false, "ControlData", null, "AnimalPurchasedFromType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "dd42f2bc-daab-47c5-a1f5-c50456df6f1a", "InitialUpload", "AnimalPurchasedFrom", true, false, false, "ControlData", null, "AnimalPurchasedFromType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "590a4094-ae41-410f-96f0-27962f3721a1", "InitialUpload", "AnimalPurchasedFrom", true, false, false, "ControlData", null, "AnimalPurchasedFromType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a8aa45f5-046d-4596-812f-9d687c0e46d4", "InitialUpload", "AnimalPurchasedFrom", true, false, false, "ControlData", null, "AnimalPurchasedFromType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "edf8a627-5efd-4b1a-906a-68333e170090", "InitialUpload", "OtherPaymentType", true, false, false, "ControlData", null, "PaymentType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "45e931e4-76be-445a-a856-e4dd071dc3f2", "InitialUpload", "AnimalPurchasedFrom", true, false, false, "ControlData", null, "AnimalPurchasedFromType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "80c857f1-a208-4ae4-8f29-e5d1001bc551", "InitialUpload", "AnimalPurchasedFrom", true, false, false, "ControlData", null, "AnimalPurchasedFromType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2315e139-30a8-4ac4-a275-59afb9637486", "InitialUpload", "AnimalPurchasedFrom", true, false, false, "ControlData", null, "AnimalPurchasedFromType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "555b0088-4bde-422c-bb80-d09e9bce7163", "InitialUpload", "LoanProvider", true, false, false, "ControlData", null, "LoanProviderType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "bce89773-8d39-4d9c-adda-e0b2fd038a8e", "InitialUpload", "LoanProvider", true, false, false, "ControlData", null, "LoanProviderType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2465dd94-2b30-4c9a-b7c0-06b950c27947", "InitialUpload", "LoanProvider", true, false, false, "ControlData", null, "LoanProviderType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9ddd7665-4f53-4a83-8792-7a164342faff", "InitialUpload", "LoanProvider", true, false, false, "ControlData", null, "LoanProviderType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3e8022d9-e07c-424b-a0b6-3e2e560c1dda", "InitialUpload", "LoanProvider", true, false, false, "ControlData", null, "LoanProviderType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "46f19c68-8033-45ed-9ca3-985df1ed8d43", "InitialUpload", "LoanProvider", true, false, false, "ControlData", null, "LoanProviderType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "00fe31bc-85b8-43b0-a7b3-76edcc3dd198", "InitialUpload", "LoanProvider", true, false, false, "ControlData", null, "LoanProviderType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9b41f8d7-be46-46b5-9965-99656688497f", "InitialUpload", "LoanProvider", true, false, false, "ControlData", null, "LoanProviderType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "fd2a830c-d54d-4f12-90a0-88819431a410", "InitialUpload", "EquipmentType", true, false, false, "ControlData", null, "EquipmentType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d49e6f5e-32e3-4617-a4b5-d98a96afcca0", "InitialUpload", "EquipmentType", true, false, false, "ControlData", null, "EquipmentType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "39c6ea67-27db-488b-accd-b11738d5d0fe", "InitialUpload", "EquipmentType", true, false, false, "ControlData", null, "EquipmentType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d3fc5475-4ace-46c0-85a1-8969148f0b5e", "InitialUpload", "AnimalPurchasedFrom", true, false, false, "ControlData", null, "AnimalPurchasedFromType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "81783275-47f7-45fc-825d-3cc4d10802d3", "InitialUpload", "OtherPaymentType", true, false, false, "ControlData", null, "PaymentType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d12b96ad-d40a-478d-9885-66caec247453", "InitialUpload", "OtherPaymentType", true, false, false, "ControlData", null, "PaymentType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5dcd99e9-205a-4fc4-9d35-421bf9e69636", "InitialUpload", "OtherPaymentType", true, false, false, "ControlData", null, "PaymentType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "cfccf964-7224-4646-aca1-5fe0e270a50b", "InitialUpload", "CountyType", true, false, false, "ControlData", null, "CountyType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a31e0f95-145f-4fd5-9c79-507470206feb", "InitialUpload", "CountyType", true, false, false, "ControlData", null, "CountyType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c00d2f35-fff6-4c99-a8c1-979ea26f973d", "InitialUpload", "CountyType", true, false, false, "ControlData", null, "CountyType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "60b1e34c-0a4a-4612-ad3e-a360c8a678b0", "InitialUpload", "CountyType", true, false, false, "ControlData", null, "CountyType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f73bd0d0-4b48-4d59-a1f2-e9d363ff92e4", "InitialUpload", "CountyType", true, false, false, "ControlData", null, "CountyType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ba513f29-f6c6-408d-8ac5-a9def0120ad8", "InitialUpload", "SubCountyType", true, false, false, "ControlData", null, "SubCountyType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "05a091ca-3e46-420f-927e-6206df18643b", "InitialUpload", "SubCountyType", true, false, false, "ControlData", null, "SubCountyType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e3d31bfc-de7d-4eaa-887d-af8dbaf1acfb", "InitialUpload", "SubCountyType", true, false, false, "ControlData", null, "SubCountyType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b64ce4fd-1dcd-4c95-8306-845698b8f1e4", "InitialUpload", "SubCountyType", true, false, false, "ControlData", null, "SubCountyType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "45f8051c-d2b9-4848-a098-9a623b3cd911", "InitialUpload", "SubCountyType", true, false, false, "ControlData", null, "SubCountyType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a078c136-f947-4ad6-b432-f75c3c825967", "InitialUpload", "SubCountyType", true, false, false, "ControlData", null, "SubCountyType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c403f439-c7ae-4b83-8b1e-0920b4eb8ada", "InitialUpload", "SubCountyType", true, false, false, "ControlData", null, "SubCountyType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "df859cff-f492-49dd-bfea-3b482a1629ba", "InitialUpload", "SubCountyType", true, false, false, "ControlData", null, "SubCountyType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d879ea98-3fe8-46bd-8581-9460fbf8e441", "InitialUpload", "CountyType", true, false, false, "ControlData", null, "CountyType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "942f7829-3967-4225-bc97-e77b240d9d78", "InitialUpload", "CountryType", true, false, false, "ControlData", null, "CountryTypeUganda" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d4214435-65a9-41e2-ab9c-54995ded6d70", "InitialUpload", "CountryType", true, false, false, "ControlData", null, "CountryTypeRwanda" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2c0ae1a7-1e0b-4554-b35d-fc6bd346e7d1", "InitialUpload", "CurrencyType", true, false, false, "ControlData", null, "CurrencyType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f67ae89b-8a2b-40c4-bc8f-8dfc0b80e27e", "InitialUpload", "CurrencyType", true, false, false, "ControlData", null, "CurrencyType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3cad1cd6-f9f7-43d1-951e-b8c6bc92c7c8", "InitialUpload", "CurrencyType", true, false, false, "ControlData", null, "CurrencyType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "198e3717-cdad-481f-83f0-880e7fd8072c", "InitialUpload", "CurrencyType", true, false, false, "ControlData", null, "CurrencyType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "74e225c2-174b-4fc9-b6cb-cffeec61ef25", "InitialUpload", "CurrencyType", true, false, false, "ControlData", null, "CurrencyType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "985458da-d58f-4e88-84f9-2e8ef57ee465", "InitialUpload", "CurrencyType", true, false, false, "ControlData", null, "CurrencyType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "57ad2d7f-8ac2-49af-b9b4-87158f0fc41c", "InitialUpload", "CurrencyType", true, false, false, "ControlData", null, "CurrencyType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ea05034e-f5a9-4c0d-9965-ebb5c5811cf5", "InitialUpload", "CurrencyType", true, false, false, "ControlData", null, "CurrencyType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9d2d127f-e32f-4f1c-a098-6886a6cf5944", "InitialUpload", "LanguageType", true, false, false, "ControlData", null, "LanguageType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5be4a579-0cc2-4aaa-aa94-04927afd7915", "InitialUpload", "LanguageType", true, false, false, "ControlData", null, "LanguageType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "85550da9-dc4e-425b-9f44-af996ca73726", "InitialUpload", "LanguageType", true, false, false, "ControlData", null, "LanguageType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "60c51cbb-7222-479f-8a74-bbce6dc31ee3", "InitialUpload", "LanguageType", true, false, false, "ControlData", null, "LanguageType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c509eadb-5e82-4fe2-baaa-11f7e3f9b866", "InitialUpload", "CountryType", true, false, false, "ControlData", null, "CountryTypeVietnam" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "89b0ee44-0aea-45c3-9821-268c1df7be2c", "InitialUpload", "WhoProvidedServiceUnit", true, false, false, "ControlData", null, "WhoProvidedServiceType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e7c9591d-1b34-4ab1-8cc7-9aed66e07d1c", "InitialUpload", "CountyType", true, false, false, "ControlData", null, "CountyType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4132ddbf-6e74-4345-8389-071d8900ae51", "InitialUpload", "DistrictType", true, false, false, "ControlData", null, "DistrictType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e526cd0a-cae9-433b-9456-648cd7bbc9bb", "InitialUpload", "OtherPaymentType", true, false, false, "ControlData", null, "PaymentType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "831e6939-0c96-4215-8f7f-674c4bf2f12e", "InitialUpload", "OtherPaymentType", true, false, false, "ControlData", null, "PaymentType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ffd1d505-7ffb-420d-b20f-8dcb464ee7b0", "InitialUpload", "ClientType", true, false, false, "ControlData", null, "ClientType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f520ca9e-fe28-421b-8a13-9cb90068fe30", "InitialUpload", "ClientType", true, false, false, "ControlData", null, "ClientType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "50131af4-2602-4240-b372-b5dfee1c2616", "InitialUpload", "ClientType", true, false, false, "ControlData", null, "ClientType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2b744e14-299d-4166-999d-4fa7bf2c8423", "InitialUpload", "ClientType", true, false, false, "ControlData", null, "ClientType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5d9311b8-a56b-4495-970b-a73a58527551", "InitialUpload", "ClientType", true, false, false, "ControlData", null, "ClientType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "47fdf550-c309-4c72-a666-cd21e08307f8", "InitialUpload", "ClientType", true, false, false, "ControlData", null, "ClientType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "60a2fc49-077b-44b5-ba5d-6779b2ad3ba8", "InitialUpload", "ClientType", true, false, false, "ControlData", null, "ClientType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ac233f2f-a881-434d-b2a7-739875d60593", "InitialUpload", "ClientType", true, false, false, "ControlData", null, "ClientType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d9789ba0-cd05-4f98-a5d7-30855b5b433c", "InitialUpload", "VolumeUnitType", true, false, false, "ControlData", null, "VolumeUnitType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "05e20feb-3e4c-4283-a51c-4b5e6616e9f0", "InitialUpload", "VolumeUnitType", true, false, false, "ControlData", null, "VolumeUnitType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "311cbc7f-fb12-4215-841e-2e51c2f9abbe", "InitialUpload", "VolumeUnitType", true, false, false, "ControlData", null, "VolumeUnitType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f815abc7-b85a-4c65-8fd8-3b808c6675aa", "InitialUpload", "CountyType", true, false, false, "ControlData", null, "CountyType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "107b4991-c64e-4e14-ba7a-aa0421fb6a32", "InitialUpload", "VolumeUnitType", true, false, false, "ControlData", null, "VolumeUnitType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "66cd9b83-a6f2-4c7e-bc64-6be8a4b24480", "InitialUpload", "VolumeUnitType", true, false, false, "ControlData", null, "VolumeUnitType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "12250695-ab03-4f1b-acd3-0ea5348df796", "InitialUpload", "VolumeUnitType", true, false, false, "ControlData", null, "VolumeUnitType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "13705cce-ef38-48c2-a211-bbccea7e61d3", "InitialUpload", "VolumeUnitType", true, false, false, "ControlData", null, "VolumeUnitType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0b8760c7-7856-40ee-94ab-4eb6e830832f", "InitialUpload", "GenderType", true, false, false, "ControlData", null, "GenderType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5f8800ec-32dd-4fcf-aba5-b4490b3151b1", "InitialUpload", "GenderType", true, false, false, "ControlData", null, "GenderType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "99ebbf72-089a-42d7-85b2-25aebc8d4fa6", "InitialUpload", "GenderType", true, false, false, "ControlData", null, "GenderType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b665ce09-1194-462f-8bc9-a969417e31cb", "InitialUpload", "DistrictType", true, false, false, "ControlData", null, "DistrictType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6226099a-6710-4d7a-b1cb-fd508cda9175", "InitialUpload", "DistrictType", true, false, false, "ControlData", null, "DistrictType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "628d9f11-c764-4661-ad8e-5e02f8016663", "InitialUpload", "DistrictType", true, false, false, "ControlData", null, "DistrictType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4ac0c2be-748a-4fd7-8f50-62d5d215c281", "InitialUpload", "DistrictType", true, false, false, "ControlData", null, "DistrictType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "066d5840-733e-4e59-9000-8815cb7f5b39", "InitialUpload", "DistrictType", true, false, false, "ControlData", null, "DistrictType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ca808188-acea-4b98-ace8-0c45135a96f1", "InitialUpload", "DistrictType", true, false, false, "ControlData", null, "DistrictType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "86aa4b94-f79c-4f39-9beb-0b9cd6aca314", "InitialUpload", "DistrictType", true, false, false, "ControlData", null, "DistrictType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "32531ac5-05b4-448b-aeab-8bde3f4bd81a", "InitialUpload", "VolumeUnitType", true, false, false, "ControlData", null, "VolumeUnitType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f640254f-c693-43ae-8eb6-f408ac6bf2a7", "InitialUpload", "LanguageType", true, false, false, "ControlData", null, "LanguageType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "06fb05fe-d0d7-4e0a-b11b-83ca4f3e7c13", "InitialUpload", "WhoProvidedServiceUnit", true, false, false, "ControlData", null, "WhoProvidedServiceType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "cd023dc2-8aee-422a-b8b8-191cdca840fc", "InitialUpload", "WhoProvidedServiceUnit", true, false, false, "ControlData", null, "WhoProvidedServiceType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "275044fd-b8ac-4b95-bd87-82925d90fe69", "InitialUpload", "FeedPurchasedType", true, false, false, "ControlData", null, "DropDownPurchaseFrom2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "11997e37-b077-482f-ad17-fe36c25cc10e", "InitialUpload", "FeedPurchasedType", true, false, false, "ControlData", null, "DropDownPurchaseFrom3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "610d9cba-1760-4dfa-85ff-350c47ae027b", "InitialUpload", "FeedPurchasedType", true, false, false, "ControlData", null, "DropDownPurchaseFrom4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5afbb7d8-b3c8-42dd-91bb-eab40b212ed6", "InitialUpload", "FeedPurchasedType", true, false, false, "ControlData", null, "DropDownPurchaseFrom5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f158a764-7772-41d3-be99-84b371b115ee", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6916e350-60dd-4b7b-a06a-13490c14a3e0", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6cc35da6-4dd9-4c73-a996-e78e625fd171", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7c0639f1-7181-4f5d-8e01-a3326898b6d4", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4ce1215e-a11d-4d8d-8c41-a7fcfca882ab", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "15f3e59e-5e49-4413-b3d2-565ad85038b5", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "db008a17-ae3f-47e2-a16d-7b5ef65d6086", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6375c280-d141-458f-a34d-9a98a6593ead", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f63ed9c4-99cb-4390-b5c7-2e2cb483b1c4", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType9" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d4aafe09-c957-488c-b244-173f5a38abe8", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType10" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a0c35650-3e0c-4ede-bd89-78cbda0f1035", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c62574c6-6b6b-4aee-9ab2-2a88c5033e71", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b2c02b12-2f63-40bc-8042-2bcd0cad5e7a", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "cda55695-1809-4f46-afe8-39d434374621", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a9499b1c-d930-449a-a3f6-7a6e85557890", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f1e738d4-5fce-432c-9f63-36713498e21b", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3ee4638b-8b8b-4fa7-a254-c613d4f38ad1", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9670f09a-f348-4e37-95ca-5a9b439a02c8", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a9bc2a0c-6df8-453e-8bf0-3ea20c45b435", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType9" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4a108414-3d20-4049-a0b0-26b0073ff12a", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType10" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8fa0f088-9771-4e79-a61a-55092f299cee", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8e9e7ed9-c1d7-4e0d-8a08-da58453592c1", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f7c99c6c-84c9-4ab0-8acc-016bdae1fb9c", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "84fa1b35-0665-4f1d-9d08-4d2d01f74e20", "InitialUpload", "FeedPurchasedType", true, false, false, "ControlData", null, "DropDownPurchaseFrom1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5edbd432-a0f1-46c4-ade7-00b52c643526", "InitialUpload", "FeedAmountPurchasedUnitType", true, false, false, "ControlData", null, "DropDownUnitType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6ac5c9ad-5a7f-4305-aec2-ed3d7981e581", "InitialUpload", "FeedAmountPurchasedUnitType", true, false, false, "ControlData", null, "DropDownUnitType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c5abef12-acf2-4417-b35f-be1bb6badc9e", "InitialUpload", "FeedAmountPurchasedUnitType", true, false, false, "ControlData", null, "DropDownUnitType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "99d95584-6ac3-45f4-8b15-a25722b08708", "InitialUpload", "FeedAmountPurchasedUnitType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4f32b697-9eed-4971-b72f-3848df5700da", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3de760c7-43bf-4909-b53c-6645f374726a", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8b1b789d-db40-4a7d-85b4-d8759ea23956", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "864c9b23-7ccc-4e2e-bd7c-5320c0db0879", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "901d105c-f903-4c27-a2f1-725e797636a8", "InitialUpload", "LabourType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "16dfae26-60ea-47bd-a044-5658e53604b1", "InitialUpload", "HousingType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "751d08f7-cb1a-474a-9507-af222673e2bd", "InitialUpload", "WaterPurchasedUnit", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "959938dc-17e0-4066-b11c-cbc549148eb2", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "11bf6d20-c26d-460f-8cbf-27e9d171feb5", "InitialUpload", "MembershipType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "33d0b111-61ba-4514-802e-bf04ac487499", "InitialUpload", "ServiceUnit", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4ff3b3de-0935-42e9-aacb-cbdf9f4c63f3", "InitialUpload", "WhoProvidedServiceUnit", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8c329ef1-1cfc-4b58-b052-7ffa48c241c7", "InitialUpload", "AnimalType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f671887c-d238-4fc9-9f77-15e6785b683f", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0e1ea45f-0a94-4186-b12c-8085668d937b", "InitialUpload", "AnimalPurchasedFrom", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6b343c95-433a-4e4c-a71e-4345fb5a34f5", "InitialUpload", "EquipmentType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4199fa3c-1d68-43c3-91c0-827b1fab109d", "InitialUpload", "PigSaleType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "88816936-11f1-4390-80b8-4bd89371c3a1", "InitialUpload", "SoldToType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "cec085d5-ef6c-43be-8367-cb876f14aba9", "InitialUpload", "BreedingServiceType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5d4e1682-386a-425e-896c-2d829a9800ee", "InitialUpload", "ClientType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d8401cdf-4faf-4d07-be80-fde69a582490", "InitialUpload", "VolumeUnitType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "979c1b25-a1eb-4bd9-92ed-1dd6916ae1ea", "InitialUpload", "FeedType", true, false, false, "ControlData", null, "DropDownFeedType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7cc5c67e-74c3-4c2b-8bd2-2ba3561246ad", "InitialUpload", "FeedType", true, false, false, "ControlData", null, "DropDownFeedType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5171a108-c395-461a-9b0e-0b1fad3a172a", "InitialUpload", "FeedType", true, false, false, "ControlData", null, "DropDownFeedType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ccc55308-3c22-42d1-9ee1-e3fdfd7fbb16", "InitialUpload", "FeedType", true, false, false, "ControlData", null, "DropDownFeedType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7cbc1887-aaa3-401a-b223-2075568cad98", "InitialUpload", "FeedType", true, false, false, "ControlData", null, "DropDownFeedType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "364397e3-6d41-4d24-9623-bb1ef5b69a73", "InitialUpload", "FeedAmountPurchasedUnitType", true, false, false, "ControlData", null, "DropDownUnitType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ee1ee260-f994-4924-b6cd-ba2410409e8c", "InitialUpload", "FeedAmountPurchasedUnitType", true, false, false, "ControlData", null, "DropDownUnitType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "123a81ce-77a6-47d9-a59c-ec32ef239b28", "InitialUpload", "LoanProvider", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "79425ad1-a1fd-453c-a2da-578c87f580c8", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "63b290b1-bc6a-492b-8320-e2e112d45a52", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3f029645-0b1c-466a-9cc4-ab55f8292e8f", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "aec27479-bbe5-47f0-b0b5-63140a5403d6", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1e3da022-17b8-493a-a02d-8feecd1046b1", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ae3ce9af-02f9-4165-b702-48d3b6fc25b9", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "fafa76f6-ff03-4c20-aa6c-e07686f2832e", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1c264c3f-f763-46c3-a07a-cba892d90acf", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "89474c32-610b-49b2-8a6a-536119d51645", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType9" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b4e39db9-dc61-4b3f-9b56-ac84ee77c0fd", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType10" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "636ca00d-cdb5-4b3c-b325-e249d1857281", "InitialUpload", "MembershipType", true, false, false, "ControlData", null, "MembershipType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "170215a4-bbe1-4eb8-96b1-3362286d70ab", "InitialUpload", "MembershipType", true, false, false, "ControlData", null, "MembershipType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "352b7897-cc79-4a55-8b71-a5d3ddd0bc77", "InitialUpload", "MembershipType", true, false, false, "ControlData", null, "MembershipType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b570698a-ba41-4ef7-b8ae-7d5222a03be9", "InitialUpload", "MembershipType", true, false, false, "ControlData", null, "MembershipType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "39f74fb0-d71b-44a4-9d7a-f8600354a264", "InitialUpload", "MembershipType", true, false, false, "ControlData", null, "MembershipType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d85b11a7-2f1a-4740-888d-d19e9f0aabb8", "InitialUpload", "MembershipType", true, false, false, "ControlData", null, "MembershipType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1e0496ff-edba-4359-89fb-debeffeea907", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7d9f98b9-f4d5-41da-b15f-f1be56b2abf8", "InitialUpload", "MembershipType", true, false, false, "ControlData", null, "MembershipType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e4a6e9a6-0b82-4101-a9cb-3f7f720b9b06", "InitialUpload", "TimePeriodUnitType", true, false, false, "ControlData", null, "TimePeriodUnitType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "10624e1f-c475-44d5-821d-1cbb7698d694", "InitialUpload", "TimePeriodUnitType", true, false, false, "ControlData", null, "TimePeriodUnitType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e945ac8e-c5d2-44dd-afaa-90a8068e787c", "InitialUpload", "ServiceUnit", true, false, false, "ControlData", null, "ServiceType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0fa11c09-ffc9-424e-8055-ce12ece026b9", "InitialUpload", "ServiceUnit", true, false, false, "ControlData", null, "ServiceType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0ddd0ca7-ef8a-41e5-a9cd-e672154b6533", "InitialUpload", "ServiceUnit", true, false, false, "ControlData", null, "ServiceType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "453228c5-1837-4013-894d-99861cf7de58", "InitialUpload", "ServiceUnit", true, false, false, "ControlData", null, "ServiceType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "fc72e2de-d6c1-4801-935c-faaaf9ada523", "InitialUpload", "ServiceUnit", true, false, false, "ControlData", null, "ServiceType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c4e47fe1-e176-4cb0-8448-79385b8565aa", "InitialUpload", "ServiceUnit", true, false, false, "ControlData", null, "ServiceType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "56fe788d-10ca-4075-93b4-ec4ded2e408e", "InitialUpload", "ServiceUnit", true, false, false, "ControlData", null, "ServiceType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d0f74434-3b77-4a0d-834c-14188e76038b", "InitialUpload", "ServiceUnit", true, false, false, "ControlData", null, "ServiceType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d12dd472-5ebb-4eaf-be85-00db4218331f", "InitialUpload", "WhoProvidedServiceUnit", true, false, false, "ControlData", null, "WhoProvidedServiceType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b780213a-485b-4153-b48b-34143841cdae", "InitialUpload", "WhoProvidedServiceUnit", true, false, false, "ControlData", null, "WhoProvidedServiceType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2760a1e4-d3aa-4364-bfe6-ee49ad0aad30", "InitialUpload", "WhoProvidedServiceUnit", true, false, false, "ControlData", null, "WhoProvidedServiceType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "bd033fc1-9eee-4c92-b391-14bc23de34ed", "InitialUpload", "MembershipType", true, false, false, "ControlData", null, "MembershipType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6c7b69bb-7db3-4761-89f5-b928444a5662", "InitialUpload", "WhoProvidedServiceUnit", true, false, false, "ControlData", null, "WhoProvidedServiceType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "023fe748-01a9-43de-afdf-e742fa8b27c0", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "52060ec0-1d2c-4457-91ae-ed134b57a016", "InitialUpload", "WaterPurchasedUnit", true, false, false, "ControlData", null, "WaterPurchasedUnitType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "58a69a8e-e703-4d45-969b-e85ac1491236", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "56012939-b98a-46b7-bf8e-5ef3c3901cd6", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType9" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "dc3c84be-cf77-401b-bce5-c04d05729d71", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType10" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2c21345c-2194-4aeb-96e2-b57ca4344d9c", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "829b91ac-9fc6-49d8-9dfd-79c821ef381b", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5e0bd08c-ce7e-4577-a355-2c486ba16af4", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "fd4e8d04-dc4c-4873-b4b3-6157e74253ec", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "816da824-a866-4ea0-9eaf-9949fa2f98c2", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e7bd6a94-937d-4684-a749-11bfb27547da", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a46edf65-b370-456f-bb96-fe36d6a045f3", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "253656ee-2693-41ed-b3e9-7c8b1715b304", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "71b89936-0f9e-400e-9385-ab60952d26f3", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType9" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "814727c9-6e77-4dbb-999b-115fae56f337", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType10" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2fd2cabe-4b9e-4bb1-89d1-549dc531390e", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e942904f-bfa1-4fc4-8504-bac52f33028f", "InitialUpload", "LabourType", true, false, false, "ControlData", null, "LabourType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "dff4f3d0-d040-420c-9d98-0a11b0660af8", "InitialUpload", "LabourType", true, false, false, "ControlData", null, "LabourType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "fa6aedb3-17b8-4e06-abc2-3a2209d8a872", "InitialUpload", "LabourType", true, false, false, "ControlData", null, "LabourType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "065a8b30-ff40-431d-9aed-263561bd8ea3", "InitialUpload", "LabourType", true, false, false, "ControlData", null, "LabourType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1cb937c6-01f7-4ff2-a248-6c4632a25f5d", "InitialUpload", "LabourType", true, false, false, "ControlData", null, "LabourType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a520ea79-67d7-4f00-bfc3-4ae4aeab92d3", "InitialUpload", "HousingType", true, false, false, "ControlData", null, "HousingExpenseType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ee5f2f97-04a8-4b21-88d7-3a9fb1dbebf3", "InitialUpload", "HousingType", true, false, false, "ControlData", null, "HousingExpenseType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b3536342-73d3-41fb-97c1-58b6f3f2d8c3", "InitialUpload", "HousingType", true, false, false, "ControlData", null, "HousingExpenseType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2bf391df-2698-47bb-be98-37de8295bd96", "InitialUpload", "HousingType", true, false, false, "ControlData", null, "HousingExpenseType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e976af74-cb8e-4195-af75-0aa7c22fe94f", "InitialUpload", "HousingType", true, false, false, "ControlData", null, "HousingExpenseType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0210c907-76bc-47bc-a09c-3f6a72796bd0", "InitialUpload", "WaterPurchasedUnit", true, false, false, "ControlData", null, "WaterPurchasedUnitType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d59eccdd-84e8-4297-af12-9a721f834bbe", "InitialUpload", "WaterPurchasedUnit", true, false, false, "ControlData", null, "WaterPurchasedUnitType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f7ce0542-7732-47ca-9b69-fe5dfecf6939", "InitialUpload", "WaterPurchasedUnit", true, false, false, "ControlData", null, "WaterPurchasedUnitType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1c7ce4f3-7369-42ae-9ea4-8e88f1796e77", "InitialUpload", "WaterPurchasedUnit", true, false, false, "ControlData", null, "WaterPurchasedUnitType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6263d504-8729-440d-ac30-efede6083e82", "InitialUpload", "LabourType", true, false, false, "ControlData", null, "LabourType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "97861e28-5747-4044-98b6-dfe9b1396df6", "InitialUpload", "LanguageType", true, false, false, "ControlData", null, "LanguageType6" });

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
