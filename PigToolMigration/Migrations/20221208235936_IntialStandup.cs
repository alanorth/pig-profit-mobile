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
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql : "datetime()" ),
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
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                values: new object[] { "9b42ad2e-9471-4c69-8473-f17f4f2c67e7", "InitialUpload", "FeedType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e1d6abd3-22b9-4bd2-9560-22519e350d36", "InitialUpload", "EquipmentType", true, false, false, "ControlData", null, "EquipmentType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0dbadf35-63bf-4d2d-9f87-004314dacb12", "InitialUpload", "PigSaleType", true, false, false, "ControlData", null, "PigType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "93ad9050-7545-44cb-9664-890058345e13", "InitialUpload", "PigSaleType", true, false, false, "ControlData", null, "PigType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "32974f5f-2704-4be0-ac57-3a05249472b1", "InitialUpload", "PigSaleType", true, false, false, "ControlData", null, "PigType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "59e8252c-f135-4148-b6f2-03a4385fd513", "InitialUpload", "PigSaleType", true, false, false, "ControlData", null, "PigType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "09c19e85-4f4f-4082-b2e3-e80bb5d9c994", "InitialUpload", "PigSaleType", true, false, false, "ControlData", null, "PigType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9096057d-0ec1-4898-b375-4f839b78819c", "InitialUpload", "PigSaleType", true, false, false, "ControlData", null, "PigType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8259e20c-ec93-4562-9ec7-723d731d22e2", "InitialUpload", "PigSaleType", true, false, false, "ControlData", null, "PigType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f7f767ce-2252-47f5-ab14-2ec5b8f197d6", "InitialUpload", "PigSaleType", true, false, false, "ControlData", null, "PigType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5b334253-62ed-44ff-92ed-d2e0ad021de6", "InitialUpload", "SoldToType", true, false, false, "ControlData", null, "SoldToType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f435ebea-26f6-4806-87b8-3ea797f712ce", "InitialUpload", "SoldToType", true, false, false, "ControlData", null, "SoldToType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "999c73c5-7b5a-4119-ab9f-3373e440e192", "InitialUpload", "SoldToType", true, false, false, "ControlData", null, "SoldToType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "93f0364d-e692-4e18-9d27-678f5d6574a4", "InitialUpload", "SoldToType", true, false, false, "ControlData", null, "SoldToType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4b4c1b1a-321c-479f-9b9d-68015c4a461c", "InitialUpload", "SoldToType", true, false, false, "ControlData", null, "SoldToType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5cf7720c-6e1c-4f4a-8bc5-65b462a5a67f", "InitialUpload", "SoldToType", true, false, false, "ControlData", null, "SoldToType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "aa06ee62-8695-445f-b7df-bffeb27dd6d1", "InitialUpload", "SoldToType", true, false, false, "ControlData", null, "SoldToType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7596fc31-28de-4cc6-9ff3-06a753b0ca90", "InitialUpload", "SoldToType", true, false, false, "ControlData", null, "SoldToType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f49d4535-4402-4d35-b370-3525a4e77bc4", "InitialUpload", "BreedingServiceType", true, false, false, "ControlData", null, "BreedingServiceType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "aaca6028-e30a-4a75-8951-af32c143f259", "InitialUpload", "BreedingServiceType", true, false, false, "ControlData", null, "BreedingServiceType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6eed4f41-d9c9-43e6-be73-36d775dd824f", "InitialUpload", "BreedingServiceType", true, false, false, "ControlData", null, "BreedingServiceType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6683e030-9fff-42c6-9dfb-e1627beaba6e", "InitialUpload", "BreedingServiceType", true, false, false, "ControlData", null, "BreedingServiceType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "03ac38b3-d837-4aee-b3fc-eb7965194562", "InitialUpload", "BreedingServiceType", true, false, false, "ControlData", null, "BreedingServiceType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0d58adef-dc67-4b31-b530-c529c43db22a", "InitialUpload", "BreedingServiceType", true, false, false, "ControlData", null, "BreedingServiceType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1abd5c9c-99cd-4243-9dbd-fe55af41bb6a", "InitialUpload", "BreedingServiceType", true, false, false, "ControlData", null, "BreedingServiceType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4a37882b-55d3-4337-b503-a68676ed61e2", "InitialUpload", "BreedingServiceType", true, false, false, "ControlData", null, "BreedingServiceType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9e0b07c4-bcb9-4199-a532-d5eebede18b3", "InitialUpload", "OtherPaymentType", true, false, false, "ControlData", null, "PaymentType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6acc0836-cc0b-42e6-b9d6-4f74c770508f", "InitialUpload", "OtherPaymentType", true, false, false, "ControlData", null, "PaymentType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "dfee5afa-fb6f-4788-9540-d320ecbe4e75", "InitialUpload", "EquipmentType", true, false, false, "ControlData", null, "EquipmentType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e1a47151-edb7-4e44-bd2d-0752a3922ac1", "InitialUpload", "EquipmentType", true, false, false, "ControlData", null, "EquipmentType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c3facaa2-7831-42c1-98d9-84e94bcf4d85", "InitialUpload", "EquipmentType", true, false, false, "ControlData", null, "EquipmentType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e0dd38e9-ef03-4c23-bd43-46a950aef42c", "InitialUpload", "EquipmentType", true, false, false, "ControlData", null, "EquipmentType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "326f1492-a506-4ef3-beab-f7d9dc519151", "InitialUpload", "WhoProvidedServiceUnit", true, false, false, "ControlData", null, "WhoProvidedServiceType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "517f92e3-b93b-4d17-a51e-a3c7c3c8a43c", "InitialUpload", "AnimalType", true, false, false, "ControlData", null, "AnimalType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d56a2a58-abbf-4e27-8e9e-2d588f133301", "InitialUpload", "AnimalType", true, false, false, "ControlData", null, "AnimalType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "979b1a15-a2e8-4af1-bced-9c228a2f9a60", "InitialUpload", "AnimalType", true, false, false, "ControlData", null, "AnimalType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "04fb6391-1da6-45f6-9c05-cd088ea7ce04", "InitialUpload", "AnimalType", true, false, false, "ControlData", null, "AnimalType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1cd82d2a-0e16-4307-b1fe-bed0f5063e24", "InitialUpload", "AnimalType", true, false, false, "ControlData", null, "AnimalType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "32192899-5d73-4f87-ae4c-47277e454db9", "InitialUpload", "AnimalType", true, false, false, "ControlData", null, "AnimalType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "af5c456e-33ec-4674-916c-c675422196d1", "InitialUpload", "AnimalType", true, false, false, "ControlData", null, "AnimalType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f1f0512d-51b2-4d8f-83d9-2e5f7b814254", "InitialUpload", "AnimalType", true, false, false, "ControlData", null, "AnimalType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "752ad166-0048-4625-a6b1-f496bf3357e2", "InitialUpload", "AnimalPurchasedFrom", true, false, false, "ControlData", null, "AnimalPurchasedFromType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b10ed6ac-2b6e-4117-a2d5-c62c02086514", "InitialUpload", "AnimalPurchasedFrom", true, false, false, "ControlData", null, "AnimalPurchasedFromType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3c2f2eee-2386-4b10-ab2a-490cddc9e603", "InitialUpload", "AnimalPurchasedFrom", true, false, false, "ControlData", null, "AnimalPurchasedFromType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "bb89c17d-2d40-4d9c-98df-7333c41087c4", "InitialUpload", "AnimalPurchasedFrom", true, false, false, "ControlData", null, "AnimalPurchasedFromType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "13d1f936-afbf-4440-9ea2-b6799cf1129e", "InitialUpload", "OtherPaymentType", true, false, false, "ControlData", null, "PaymentType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3138bd83-d3d3-4cf7-832a-fefaaa624bfd", "InitialUpload", "AnimalPurchasedFrom", true, false, false, "ControlData", null, "AnimalPurchasedFromType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4e4092fa-1ce3-476a-baa7-d024f03c8a41", "InitialUpload", "AnimalPurchasedFrom", true, false, false, "ControlData", null, "AnimalPurchasedFromType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "27aaf357-ccdc-4c8a-8037-3d4f1e9f3e90", "InitialUpload", "AnimalPurchasedFrom", true, false, false, "ControlData", null, "AnimalPurchasedFromType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "cee61806-4fa8-4b08-9efb-5c5855b89c66", "InitialUpload", "LoanProvider", true, false, false, "ControlData", null, "LoanProviderType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ab18f290-d307-4ebb-ae4e-e4b76a93d41f", "InitialUpload", "LoanProvider", true, false, false, "ControlData", null, "LoanProviderType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "65cbdf7f-bdf9-4c1b-be53-8acee2c8acfd", "InitialUpload", "LoanProvider", true, false, false, "ControlData", null, "LoanProviderType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ee5789e0-90a9-4733-bbcd-1c961da13374", "InitialUpload", "LoanProvider", true, false, false, "ControlData", null, "LoanProviderType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "12e37f24-d276-48cc-901a-46c16e57dda0", "InitialUpload", "LoanProvider", true, false, false, "ControlData", null, "LoanProviderType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "cea8e02f-2c18-4a69-9c6e-edbf17675a4f", "InitialUpload", "LoanProvider", true, false, false, "ControlData", null, "LoanProviderType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "261e7f89-372b-4f61-953f-764e64f720e5", "InitialUpload", "LoanProvider", true, false, false, "ControlData", null, "LoanProviderType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9fcec9a6-6a5b-45ce-9eed-7fd6ea3bef05", "InitialUpload", "LoanProvider", true, false, false, "ControlData", null, "LoanProviderType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "181456be-c199-4b38-b068-9f43846ee5e5", "InitialUpload", "EquipmentType", true, false, false, "ControlData", null, "EquipmentType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "217486be-b266-410a-8ec1-e32a5d9611ac", "InitialUpload", "EquipmentType", true, false, false, "ControlData", null, "EquipmentType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "cbb8dba5-8356-4932-bdd3-ab6d968eceb8", "InitialUpload", "EquipmentType", true, false, false, "ControlData", null, "EquipmentType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ab0385c2-da1f-4c0c-9372-b09d63852b38", "InitialUpload", "AnimalPurchasedFrom", true, false, false, "ControlData", null, "AnimalPurchasedFromType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "881c1075-4d0b-47bb-a50c-b73b39bd7e13", "InitialUpload", "OtherPaymentType", true, false, false, "ControlData", null, "PaymentType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "40bc82b2-c823-4795-96d2-b89b2f71a0e7", "InitialUpload", "OtherPaymentType", true, false, false, "ControlData", null, "PaymentType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5bfc985d-3341-4b49-81eb-b8c80776f042", "InitialUpload", "OtherPaymentType", true, false, false, "ControlData", null, "PaymentType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ca0ef4a1-0527-449a-b8fa-c3b89f06dcef", "InitialUpload", "CountyType", true, false, false, "ControlData", null, "CountyType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "86016667-d7fb-4c2b-a83c-81805d207bf1", "InitialUpload", "CountyType", true, false, false, "ControlData", null, "CountyType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "324d5ff4-15a2-43cf-860f-9a638c5c693c", "InitialUpload", "CountyType", true, false, false, "ControlData", null, "CountyType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "609cb20f-3bf6-4b20-82b1-393fd5a8293b", "InitialUpload", "CountyType", true, false, false, "ControlData", null, "CountyType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "da8a47e8-1c55-4721-bd8a-9d713461741c", "InitialUpload", "CountyType", true, false, false, "ControlData", null, "CountyType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f3ff6ac4-569a-4e55-b6e0-5099e50cc3f9", "InitialUpload", "SubCountyType", true, false, false, "ControlData", null, "SubCountyType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "87d193e2-53ac-4624-8ed2-73001ebd98e4", "InitialUpload", "SubCountyType", true, false, false, "ControlData", null, "SubCountyType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "916fd182-e83d-43dd-94ba-a91a51217112", "InitialUpload", "SubCountyType", true, false, false, "ControlData", null, "SubCountyType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2075aeb3-cb50-4082-8187-3aa2c25d49ae", "InitialUpload", "SubCountyType", true, false, false, "ControlData", null, "SubCountyType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "355b9986-8eb6-4efd-af83-605fd4d4f861", "InitialUpload", "SubCountyType", true, false, false, "ControlData", null, "SubCountyType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "32390add-2dc9-4653-a17e-587989cfc0cc", "InitialUpload", "SubCountyType", true, false, false, "ControlData", null, "SubCountyType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1d534ccc-90fd-4c03-94b9-58f1fcac4dc8", "InitialUpload", "SubCountyType", true, false, false, "ControlData", null, "SubCountyType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "15a7208e-588b-4800-b376-eec6f81b3272", "InitialUpload", "SubCountyType", true, false, false, "ControlData", null, "SubCountyType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "27cf7713-be94-4942-b5d7-87624590be7c", "InitialUpload", "CountyType", true, false, false, "ControlData", null, "CountyType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "86e22b60-fcf7-4f0d-b8a7-cfc152baed3c", "InitialUpload", "CountryType", true, false, false, "ControlData", null, "CountryTypeUganda" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f7762344-e211-4e11-a6d9-49044525a398", "InitialUpload", "CountryType", true, false, false, "ControlData", null, "CountryTypeRwanda" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "cc72a4d0-0d9f-49ed-a227-6450434dd218", "InitialUpload", "CurrencyType", true, false, false, "ControlData", null, "CurrencyType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6202b37b-b380-4e0a-9b9a-a8ef28789147", "InitialUpload", "CurrencyType", true, false, false, "ControlData", null, "CurrencyType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7c1a079c-f238-42ca-ad92-a56d6d295fe4", "InitialUpload", "CurrencyType", true, false, false, "ControlData", null, "CurrencyType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ee6c107b-87f3-43c0-a6c1-1b9a42aab015", "InitialUpload", "CurrencyType", true, false, false, "ControlData", null, "CurrencyType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2417517d-b87a-491e-aec3-d47e37778434", "InitialUpload", "CurrencyType", true, false, false, "ControlData", null, "CurrencyType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2b6b0ed7-22b4-43e8-9f6b-1f15e874422a", "InitialUpload", "CurrencyType", true, false, false, "ControlData", null, "CurrencyType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7e478301-b70d-40b7-8f51-ca606b385e0d", "InitialUpload", "CurrencyType", true, false, false, "ControlData", null, "CurrencyType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "809e5b2e-6e16-4395-a3d0-6ff022190ab1", "InitialUpload", "CurrencyType", true, false, false, "ControlData", null, "CurrencyType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e6916571-9dd3-405c-aada-273d367f72d7", "InitialUpload", "LanguageType", true, false, false, "ControlData", null, "LanguageType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "be22d24d-8015-4516-8bfe-669d41a6ad13", "InitialUpload", "LanguageType", true, false, false, "ControlData", null, "LanguageType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e877026e-89b5-4627-ac51-84bdfefa11d4", "InitialUpload", "LanguageType", true, false, false, "ControlData", null, "LanguageType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "bcff259b-22bd-4fcb-97ef-8cc013909945", "InitialUpload", "LanguageType", true, false, false, "ControlData", null, "LanguageType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8ef0cb03-cd8a-4a93-a44c-332c25205a29", "InitialUpload", "CountryType", true, false, false, "ControlData", null, "CountryTypeVietnam" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8c3c585a-cf7c-4979-8673-b09d4fd913dd", "InitialUpload", "WhoProvidedServiceUnit", true, false, false, "ControlData", null, "WhoProvidedServiceType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "df2af023-dee5-44ee-a625-a31777785249", "InitialUpload", "CountyType", true, false, false, "ControlData", null, "CountyType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3c50db2e-4785-430a-b17a-06ed1e2121de", "InitialUpload", "DistrictType", true, false, false, "ControlData", null, "DistrictType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "fe9a6f34-8b9d-4a7e-a943-bae6c75820a6", "InitialUpload", "OtherPaymentType", true, false, false, "ControlData", null, "PaymentType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "15661b02-b5e9-4639-9d2c-e34224e95946", "InitialUpload", "OtherPaymentType", true, false, false, "ControlData", null, "PaymentType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5d939e1f-6fda-480b-9358-cb1a463204ed", "InitialUpload", "ClientType", true, false, false, "ControlData", null, "ClientType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0c453989-bffb-42b6-a5a8-050ffab7df00", "InitialUpload", "ClientType", true, false, false, "ControlData", null, "ClientType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2514bf04-994b-4c3e-ae08-91b76fdd8e3e", "InitialUpload", "ClientType", true, false, false, "ControlData", null, "ClientType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f464969b-1a3d-4ade-9772-afe12512b02d", "InitialUpload", "ClientType", true, false, false, "ControlData", null, "ClientType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6e92b4c6-8e2d-4a55-859d-d5c43bf6a801", "InitialUpload", "ClientType", true, false, false, "ControlData", null, "ClientType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c5dcf015-d466-4741-956b-4ea9229514fc", "InitialUpload", "ClientType", true, false, false, "ControlData", null, "ClientType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "db27b2f3-07fb-4f36-98d9-4d42d5b1b864", "InitialUpload", "ClientType", true, false, false, "ControlData", null, "ClientType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "97dcb4fa-3291-4a94-8cf8-fa447c9909fd", "InitialUpload", "ClientType", true, false, false, "ControlData", null, "ClientType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7e778b3c-0925-41e0-a70f-6cef1e091821", "InitialUpload", "VolumeUnitType", true, false, false, "ControlData", null, "VolumeUnitType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5c0f5946-df01-46b6-93eb-7079b46526af", "InitialUpload", "VolumeUnitType", true, false, false, "ControlData", null, "VolumeUnitType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2e0ef8e6-f979-4da3-b70c-f095cb2b5efd", "InitialUpload", "VolumeUnitType", true, false, false, "ControlData", null, "VolumeUnitType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3512fa94-4fff-41e8-81f4-2ce6e421d876", "InitialUpload", "CountyType", true, false, false, "ControlData", null, "CountyType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3f3d6c4d-f229-4f37-a905-02054c4c59d3", "InitialUpload", "VolumeUnitType", true, false, false, "ControlData", null, "VolumeUnitType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b2df1b58-efc0-45ae-8243-566b36c66ad5", "InitialUpload", "VolumeUnitType", true, false, false, "ControlData", null, "VolumeUnitType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "22bba24d-33ac-43e5-b4a6-bee23aafe143", "InitialUpload", "VolumeUnitType", true, false, false, "ControlData", null, "VolumeUnitType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5013a9a1-421c-474f-90ad-3309fc674da8", "InitialUpload", "VolumeUnitType", true, false, false, "ControlData", null, "VolumeUnitType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1c5c6c10-dce1-4ee2-8fac-5978428d783c", "InitialUpload", "GenderType", true, false, false, "ControlData", null, "GenderType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d9c237f4-2eaa-4bf1-a204-ae0dd2eeddcc", "InitialUpload", "GenderType", true, false, false, "ControlData", null, "GenderType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0fe438d5-7f15-40db-a20f-92ae2f7f6931", "InitialUpload", "GenderType", true, false, false, "ControlData", null, "GenderType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "755838b8-581e-46e0-affa-695db3f3cc7b", "InitialUpload", "DistrictType", true, false, false, "ControlData", null, "DistrictType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b2fb9866-c379-41ff-a414-7631570c3392", "InitialUpload", "DistrictType", true, false, false, "ControlData", null, "DistrictType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "07efb3b7-92a2-49e2-90a0-9afad1634c92", "InitialUpload", "DistrictType", true, false, false, "ControlData", null, "DistrictType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f71d9e0c-c052-4aca-89b3-522a128c17fe", "InitialUpload", "DistrictType", true, false, false, "ControlData", null, "DistrictType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ddc19311-18a9-444c-989a-129fa6015717", "InitialUpload", "DistrictType", true, false, false, "ControlData", null, "DistrictType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c177dd7e-496b-4eed-9d9b-e5b48e93e4f0", "InitialUpload", "DistrictType", true, false, false, "ControlData", null, "DistrictType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "63ae082f-7ef1-4cc5-bd48-95b92b73840c", "InitialUpload", "DistrictType", true, false, false, "ControlData", null, "DistrictType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ad4d15ba-9fcd-4c10-ae55-18dda48bbea2", "InitialUpload", "VolumeUnitType", true, false, false, "ControlData", null, "VolumeUnitType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4247d234-913f-4180-8339-b60b27b4ba74", "InitialUpload", "LanguageType", true, false, false, "ControlData", null, "LanguageType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "da20651a-684f-4a3e-b982-5a0b74664199", "InitialUpload", "WhoProvidedServiceUnit", true, false, false, "ControlData", null, "WhoProvidedServiceType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "04057ad8-3dda-4fc2-9fb0-e0da7948a055", "InitialUpload", "WhoProvidedServiceUnit", true, false, false, "ControlData", null, "WhoProvidedServiceType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "79fc6bb0-99e5-4242-8570-2d59478261e3", "InitialUpload", "FeedPurchasedType", true, false, false, "ControlData", null, "DropDownPurchaseFrom2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "12451e02-bce2-4c0e-b216-0b78b8323c66", "InitialUpload", "FeedPurchasedType", true, false, false, "ControlData", null, "DropDownPurchaseFrom3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4db11f62-817b-4279-a53e-b3d91dd70a15", "InitialUpload", "FeedPurchasedType", true, false, false, "ControlData", null, "DropDownPurchaseFrom4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3456dfea-1ab7-4954-96a9-fc7dab1e1952", "InitialUpload", "FeedPurchasedType", true, false, false, "ControlData", null, "DropDownPurchaseFrom5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f3932957-6b67-4407-b0f0-faac2f0f0285", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0016cd60-88cd-4b9e-8420-5f35d91d4b15", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8884c348-e6d9-422a-9d74-5cc9d9acfd15", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e83ed694-c73b-41ef-a576-76bdd0453ab7", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "fe0de186-0f77-4e44-beae-d585e934ec6b", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3e57e32e-79bc-4791-ace6-3d87bf247fb5", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "78a2da5f-0bef-4256-b91f-d5cc691e9c6f", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c1fcc3d9-afcc-4a10-b417-d54f20df7dc7", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e21015e5-9194-4b15-a399-34e3bb38aed6", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType9" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "92ea807e-c789-41e5-a1c2-d2607fae2cd8", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "HeathCareType10" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2597f6b7-507e-4c91-bc36-d16961ab12d0", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "bf86c9ec-9979-4310-9840-1166b55f3bfe", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a55684ce-0e41-47d3-8c7e-3bc842858b4d", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2e1acf67-4e83-4903-8490-6c63a000e9ba", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "55ad2efc-0776-4334-bb3d-3e399fef96a4", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "40294d6f-6c1a-45a1-a9a2-f895e5ee46f6", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "26a3217d-dca3-43bb-8da6-3476a321befe", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "143b9f04-04ec-4cb7-902f-f7ee51af0f3f", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a8d2c94a-c51f-44ac-b8cb-ca0cc77e0b69", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType9" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d8fcec1f-67c4-45b5-9108-8d558634575f", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "HealthProviderType10" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1d9b2152-d037-4c4a-8af8-4c1ec9890115", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5ca2ed25-8f10-4177-9fbe-ec5b60f2a582", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9255650b-2427-4221-a4d5-c56bd4a6ed30", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c4521989-2d98-44da-b205-b7c3285b0bb1", "InitialUpload", "FeedPurchasedType", true, false, false, "ControlData", null, "DropDownPurchaseFrom1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ee5f04a1-b198-47f4-bc92-043fee8f3cd6", "InitialUpload", "FeedAmountPurchasedUnitType", true, false, false, "ControlData", null, "DropDownUnitType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0ff9691e-5827-4f63-8c58-7dc5e8e4e201", "InitialUpload", "FeedAmountPurchasedUnitType", true, false, false, "ControlData", null, "DropDownUnitType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5db90d8f-69ad-4604-bac0-0f73a413d94b", "InitialUpload", "FeedAmountPurchasedUnitType", true, false, false, "ControlData", null, "DropDownUnitType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6b604691-20f1-438e-9522-3a146d21cd20", "InitialUpload", "FeedAmountPurchasedUnitType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1bbbe86d-8c37-4d72-930d-6ceb2d8d1352", "InitialUpload", "HealthCareType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6dd3af94-05d3-4c3e-9654-a074daf5d808", "InitialUpload", "HealthServivceProivderType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8561f04d-8760-4a0e-a72b-1f60c3042fc2", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7a8f8aa9-f493-48ea-8dad-73ba617f4244", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "71f0fa4c-3218-4bfa-b74d-e4017f9a6516", "InitialUpload", "LabourType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ccfec117-8e22-475a-aacb-67257dfbe818", "InitialUpload", "HousingType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e7bc6c1f-3305-446e-9fd9-822e6c3a14df", "InitialUpload", "WaterPurchasedUnit", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "7a6647a2-c6bf-45f6-b1e5-ddce7cee1dce", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "97c1f966-cf92-439e-a004-0cf04f110216", "InitialUpload", "MembershipType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6afbde10-2906-4e95-a396-7825c65759db", "InitialUpload", "ServiceUnit", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "734cd5a5-8b32-4fe8-8660-cdfa8d55fd59", "InitialUpload", "WhoProvidedServiceUnit", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8f05dbdc-de7c-4722-82e7-06f43418faf9", "InitialUpload", "AnimalType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "98f7edea-29fd-4672-b5a0-75368fb8386a", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "81ec8faa-ef59-4fa5-8a77-ec52ced2730d", "InitialUpload", "AnimalPurchasedFrom", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6c270e56-b237-44dd-8bfd-9023ce32c9b4", "InitialUpload", "EquipmentType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c97cd62a-103a-442b-b7ec-5503c684ec8a", "InitialUpload", "PigSaleType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3080470d-8ed6-4d9e-8049-2c5845683529", "InitialUpload", "SoldToType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8fb11228-07f8-4c5a-8629-dfee668846c6", "InitialUpload", "BreedingServiceType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ec642937-25ff-4ec7-8812-6fd19536696a", "InitialUpload", "ClientType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "bc26bb06-2995-4f24-bb30-4f253cf72edd", "InitialUpload", "VolumeUnitType", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "65fea029-f790-419c-967a-bb440b1a564c", "InitialUpload", "FeedType", true, false, false, "ControlData", null, "DropDownFeedType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "304ebbc9-7d64-4b63-8cb0-37784eb91b17", "InitialUpload", "FeedType", true, false, false, "ControlData", null, "DropDownFeedType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "10dd6f10-0af2-4ca7-b0c5-91d4286cd153", "InitialUpload", "FeedType", true, false, false, "ControlData", null, "DropDownFeedType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "cf1e6dd6-6548-406d-bb14-00d35d24c7f1", "InitialUpload", "FeedType", true, false, false, "ControlData", null, "DropDownFeedType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3489d901-bed1-40be-b2d6-d3feeb3ad868", "InitialUpload", "FeedType", true, false, false, "ControlData", null, "DropDownFeedType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "dd9a0ef7-843a-44c4-bbec-7b9bf16b1643", "InitialUpload", "FeedAmountPurchasedUnitType", true, false, false, "ControlData", null, "DropDownUnitType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "259b95b5-7345-4561-86b7-3032c7deaff0", "InitialUpload", "FeedAmountPurchasedUnitType", true, false, false, "ControlData", null, "DropDownUnitType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8dc05242-2fc2-4df6-81fc-b7d92a65b1f2", "InitialUpload", "LoanProvider", true, false, false, "ControlData", null, "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ad4162af-fb12-4b32-a254-97e1a81f5ea9", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9cd54ad3-6725-40e7-b2d4-ed7429ed3f9e", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4114f371-a687-42e0-a258-93cf17902894", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f3558818-1183-427f-a5d2-e9d0ed83dced", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "856623a9-b9e9-4a9f-8bed-0d3d31fdba31", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "c812d19e-5097-4e37-a2f8-ec5ddc71d86d", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3f17c6a1-97bc-4e83-aa79-0a0fffcdd342", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9f00498e-99ae-4310-99be-7efe3d3c6b3e", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0d8ef31e-4e08-4af0-9633-178dd314e033", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType9" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0a73b889-d7bf-4102-8f22-ceb65aa4eef9", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType10" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e5375aff-73fd-46df-b855-6b67d15200fc", "InitialUpload", "MembershipType", true, false, false, "ControlData", null, "MembershipType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "dff664dc-092a-48bb-a664-4211e3d3a1ce", "InitialUpload", "MembershipType", true, false, false, "ControlData", null, "MembershipType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "fb8c13f3-86ca-454c-87d8-b94e2d844a3f", "InitialUpload", "MembershipType", true, false, false, "ControlData", null, "MembershipType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d3b1f41f-a8df-4c6b-a10b-f676ff2dbeb0", "InitialUpload", "MembershipType", true, false, false, "ControlData", null, "MembershipType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "22b0d45e-68bd-4b7a-bbb0-fd40d91a76ff", "InitialUpload", "MembershipType", true, false, false, "ControlData", null, "MembershipType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "cabb288c-3522-4445-8560-e152d17ec5a0", "InitialUpload", "MembershipType", true, false, false, "ControlData", null, "MembershipType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b27617e7-8156-40be-8d61-a361783a5509", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e2de2d28-bafd-41b3-aa39-a812375fd9c8", "InitialUpload", "MembershipType", true, false, false, "ControlData", null, "MembershipType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d4160da1-cefb-4203-8f3c-ed5fb017e8b2", "InitialUpload", "TimePeriodUnitType", true, false, false, "ControlData", null, "TimePeriodUnitType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "dcc6a66c-1dae-42dc-905d-76ddc48fc14a", "InitialUpload", "TimePeriodUnitType", true, false, false, "ControlData", null, "TimePeriodUnitType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "dda9f899-0aea-4eae-9836-dee28497fa3e", "InitialUpload", "ServiceUnit", true, false, false, "ControlData", null, "ServiceType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2694c845-3361-497d-8e3b-b6a684f59dde", "InitialUpload", "ServiceUnit", true, false, false, "ControlData", null, "ServiceType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "137c02dc-9127-4dc4-8211-7723fda4219a", "InitialUpload", "ServiceUnit", true, false, false, "ControlData", null, "ServiceType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "bc8720e6-d2b8-4404-ad6f-19d5da107cd3", "InitialUpload", "ServiceUnit", true, false, false, "ControlData", null, "ServiceType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ba2af367-7796-4793-b59b-67e52139bfcf", "InitialUpload", "ServiceUnit", true, false, false, "ControlData", null, "ServiceType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "22d86529-4133-4489-8e47-870612083880", "InitialUpload", "ServiceUnit", true, false, false, "ControlData", null, "ServiceType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "11d1069b-9257-4c08-b044-4d9a7d37f58a", "InitialUpload", "ServiceUnit", true, false, false, "ControlData", null, "ServiceType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "2c939b32-a41b-4aa2-81c5-471f15acd721", "InitialUpload", "ServiceUnit", true, false, false, "ControlData", null, "ServiceType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e77cafce-7a6d-4df0-b1a7-93f6a038e1d7", "InitialUpload", "WhoProvidedServiceUnit", true, false, false, "ControlData", null, "WhoProvidedServiceType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0254db5a-285e-45e3-96d4-01c21125235b", "InitialUpload", "WhoProvidedServiceUnit", true, false, false, "ControlData", null, "WhoProvidedServiceType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "6f008a4b-f26f-4f92-939b-d076629013b7", "InitialUpload", "WhoProvidedServiceUnit", true, false, false, "ControlData", null, "WhoProvidedServiceType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "1dda4d2d-ad44-4448-9598-4e7c927a93c7", "InitialUpload", "MembershipType", true, false, false, "ControlData", null, "MembershipType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "a4c5a99d-3ede-4c75-8601-9e5c94933aa7", "InitialUpload", "WhoProvidedServiceUnit", true, false, false, "ControlData", null, "WhoProvidedServiceType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e1162d88-7521-4edc-abe7-29788b0b4625", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0cc1c8b3-0f55-40a8-b25d-c2926b5931a3", "InitialUpload", "WaterPurchasedUnit", true, false, false, "ControlData", null, "WaterPurchasedUnitType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3b53c96a-a5e2-4e77-b689-e6457b808498", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "bd01253b-479b-470a-82b8-17a5bd1f70b0", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType9" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "fb819eda-2d41-441a-8e70-7246aac37662", "InitialUpload", "HealthMedicineType", true, false, false, "ControlData", null, "MedicineType10" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "e146345f-e127-4cbd-9b28-c0dcfae9a12b", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "ccd0e0b7-7d1d-4e4f-9548-def25f0b16d1", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8f580a62-72ba-4988-97ab-060f30d50cfd", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "d8b88320-d1c8-428d-a388-e4ecf7887d2c", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "35b3b9b8-359f-40e9-ada3-4595dd66b100", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "de2ffeb2-b643-4f48-bfaa-96feb9c12960", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "23bb3fa2-626e-4a8a-a921-760f711ff52d", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "83622f69-c2e8-4ab4-b745-e6d2974d35cc", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "bbe6c87d-7a52-41d3-8a39-e9fd15a38632", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType9" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "aa0ad0ba-71a0-4bfa-844c-c299aafe80e0", "InitialUpload", "HealthPurchaseFromType", true, false, false, "ControlData", null, "PruchaseFromType10" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "9e27082b-1b9a-4b2e-b185-2f02b753e933", "InitialUpload", "PurchasedWaterFrom", true, false, false, "ControlData", null, "PurchasedWaterFromType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "8b279231-877c-4757-89cf-998a1434dfab", "InitialUpload", "LabourType", true, false, false, "ControlData", null, "LabourType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "3efd9762-84d5-441a-b42c-3cbed28b8943", "InitialUpload", "LabourType", true, false, false, "ControlData", null, "LabourType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "dee0b103-23f1-45b1-a249-0d40076f2581", "InitialUpload", "LabourType", true, false, false, "ControlData", null, "LabourType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "751a552b-8b87-4d5c-b3c2-ddf535fdc182", "InitialUpload", "LabourType", true, false, false, "ControlData", null, "LabourType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "5efab53a-4aef-4f0a-8954-d20d700b8e40", "InitialUpload", "LabourType", true, false, false, "ControlData", null, "LabourType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "803d3334-8f1a-430c-883e-25603a11b42e", "InitialUpload", "HousingType", true, false, false, "ControlData", null, "HousingExpenseType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "4dc7bdbc-2d36-427f-a0c9-b5c0d053c673", "InitialUpload", "HousingType", true, false, false, "ControlData", null, "HousingExpenseType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "f122201b-b572-41f7-890f-dadb503d68cd", "InitialUpload", "HousingType", true, false, false, "ControlData", null, "HousingExpenseType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "98ef8c66-ce96-4f16-acde-d17cd035f73f", "InitialUpload", "HousingType", true, false, false, "ControlData", null, "HousingExpenseType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "b437441d-f89f-43cc-83a9-9e62d2f2301a", "InitialUpload", "HousingType", true, false, false, "ControlData", null, "HousingExpenseType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "56e5db30-0a63-49b1-8ad4-dd2ed3f979a8", "InitialUpload", "WaterPurchasedUnit", true, false, false, "ControlData", null, "WaterPurchasedUnitType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "62f4e2a4-d776-4b22-ae53-315a43f25c11", "InitialUpload", "WaterPurchasedUnit", true, false, false, "ControlData", null, "WaterPurchasedUnitType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "cfc89207-d382-431c-bfca-9139aed5b34c", "InitialUpload", "WaterPurchasedUnit", true, false, false, "ControlData", null, "WaterPurchasedUnitType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "52f40e7a-0de6-4774-9769-658f0087c4dc", "InitialUpload", "WaterPurchasedUnit", true, false, false, "ControlData", null, "WaterPurchasedUnitType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "0428d966-2800-4a7d-91a3-587457bf0ca1", "InitialUpload", "LabourType", true, false, false, "ControlData", null, "LabourType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "CreatedBy", "DropDownControlOption", "IsDeleted", "IsEnable", "IsModified", "PartitionKey", "Timestamp", "TranslationRowKey" },
                values: new object[] { "15bae5cf-201c-400d-b40b-99b268bf8b6f", "InitialUpload", "LanguageType", true, false, false, "ControlData", null, "LanguageType6" });

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
