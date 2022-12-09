using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class IntialStandup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "a09c5210-f57e-4cdc-a0da-db1f105ccfc4"),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    IsModified = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true),
                    IsEnable = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true),
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValueSql: "datetime()"),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "datetime()"),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "OtherIncome"),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseItems", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
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
                    AuthorisedUserName = table.Column<string>(type: "TEXT", nullable: true),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RefreshToken = table.Column<string>(type: "TEXT", nullable: false),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.RowKey);
                });

            migrationBuilder.CreateTable(
                name: "AnimalHouseItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "a09c5210-f57e-4cdc-a0da-db1f105ccfc4"),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HousingExpense = table.Column<string>(type: "TEXT", nullable: true),
                    OtherHousingExpense = table.Column<string>(type: "TEXT", nullable: true),
                    TotalCosts = table.Column<double>(type: "REAL", nullable: false),
                    TransportationCost = table.Column<double>(type: "REAL", nullable: false),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    YearsExpected = table.Column<int>(type: "INTEGER", nullable: true),
                    Comment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalHouseItems", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_AnimalHouseItems_BaseItems_RowKey",
                        column: x => x.RowKey,
                        principalTable: "BaseItems",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalPurchaseItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "a09c5210-f57e-4cdc-a0da-db1f105ccfc4"),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AnimalType = table.Column<string>(type: "TEXT", nullable: true),
                    OtherAnimalType = table.Column<string>(type: "TEXT", nullable: true),
                    NumberPurchased = table.Column<int>(type: "INTEGER", nullable: true),
                    TotalCosts = table.Column<double>(type: "REAL", nullable: false),
                    AnimalPurchasedFrom = table.Column<string>(type: "TEXT", nullable: true),
                    OtherAnimalPurchasedFrom = table.Column<string>(type: "TEXT", nullable: true),
                    TransportationCost = table.Column<double>(type: "REAL", nullable: false),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalPurchaseItems", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_AnimalPurchaseItems_BaseItems_RowKey",
                        column: x => x.RowKey,
                        principalTable: "BaseItems",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BreedingServiceSaleItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "a09c5210-f57e-4cdc-a0da-db1f105ccfc4"),
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
                    Comment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreedingServiceSaleItems", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_BreedingServiceSaleItems_BaseItems_RowKey",
                        column: x => x.RowKey,
                        principalTable: "BaseItems",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "a09c5210-f57e-4cdc-a0da-db1f105ccfc4"),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalCosts = table.Column<double>(type: "REAL", nullable: false),
                    EquipmentType = table.Column<string>(type: "TEXT", nullable: true),
                    OtherEquipmentType = table.Column<string>(type: "TEXT", nullable: true),
                    TransportationCost = table.Column<double>(type: "REAL", nullable: false),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentItems", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_EquipmentItems_BaseItems_RowKey",
                        column: x => x.RowKey,
                        principalTable: "BaseItems",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthCareItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "a09c5210-f57e-4cdc-a0da-db1f105ccfc4"),
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
                    Comment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCareItems", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_HealthCareItems_BaseItems_RowKey",
                        column: x => x.RowKey,
                        principalTable: "BaseItems",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LabourCostItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "a09c5210-f57e-4cdc-a0da-db1f105ccfc4"),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LabourType = table.Column<string>(type: "TEXT", nullable: true),
                    OtherLabourType = table.Column<string>(type: "TEXT", nullable: true),
                    AmountPaid = table.Column<double>(type: "REAL", nullable: false),
                    OtherCost = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabourCostItems", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_LabourCostItems_BaseItems_RowKey",
                        column: x => x.RowKey,
                        principalTable: "BaseItems",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanRepaymentItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "a09c5210-f57e-4cdc-a0da-db1f105ccfc4"),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalAmountRepaid = table.Column<double>(type: "REAL", nullable: false),
                    LoanProvider = table.Column<string>(type: "TEXT", nullable: true),
                    OtherLoanProvider = table.Column<string>(type: "TEXT", nullable: true),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanRepaymentItems", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_LoanRepaymentItems_BaseItems_RowKey",
                        column: x => x.RowKey,
                        principalTable: "BaseItems",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManureSaleItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "a09c5210-f57e-4cdc-a0da-db1f105ccfc4"),
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
                    Comment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManureSaleItems", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_ManureSaleItems_BaseItems_RowKey",
                        column: x => x.RowKey,
                        principalTable: "BaseItems",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MembershipItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "a09c5210-f57e-4cdc-a0da-db1f105ccfc4"),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalCosts = table.Column<double>(type: "REAL", nullable: false),
                    MembershipType = table.Column<string>(type: "TEXT", nullable: true),
                    OtherMembershipType = table.Column<string>(type: "TEXT", nullable: true),
                    TimePeriod = table.Column<int>(type: "INTEGER", nullable: false),
                    TimePeriodUnit = table.Column<string>(type: "TEXT", nullable: false),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: true),
                    Comment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipItems", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_MembershipItems_BaseItems_RowKey",
                        column: x => x.RowKey,
                        principalTable: "BaseItems",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherCostItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "a09c5210-f57e-4cdc-a0da-db1f105ccfc4"),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalCosts = table.Column<double>(type: "REAL", nullable: false),
                    OtherWhatFor = table.Column<string>(type: "TEXT", nullable: true),
                    TransportationCosts = table.Column<double>(type: "REAL", nullable: true),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherCostItems", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_OtherCostItems_BaseItems_RowKey",
                        column: x => x.RowKey,
                        principalTable: "BaseItems",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherIncomeItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "a09c5210-f57e-4cdc-a0da-db1f105ccfc4"),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalIncome = table.Column<double>(type: "REAL", nullable: false),
                    OtherWhatFor = table.Column<string>(type: "TEXT", nullable: true),
                    TransportationCosts = table.Column<double>(type: "REAL", nullable: false),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherIncomeItems", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_OtherIncomeItems_BaseItems_RowKey",
                        column: x => x.RowKey,
                        principalTable: "BaseItems",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PigSaleItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "a09c5210-f57e-4cdc-a0da-db1f105ccfc4"),
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
                    Comment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PigSaleItems", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_PigSaleItems_BaseItems_RowKey",
                        column: x => x.RowKey,
                        principalTable: "BaseItems",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReproductiveItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "a09c5210-f57e-4cdc-a0da-db1f105ccfc4"),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ServiceType = table.Column<string>(type: "TEXT", nullable: true),
                    OtherServiceType = table.Column<string>(type: "TEXT", nullable: true),
                    SowsServiced = table.Column<int>(type: "INTEGER", nullable: false),
                    WhoProvidedService = table.Column<string>(type: "TEXT", nullable: true),
                    OtherWhoProvidedService = table.Column<string>(type: "TEXT", nullable: true),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReproductiveItems", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_ReproductiveItems_BaseItems_RowKey",
                        column: x => x.RowKey,
                        principalTable: "BaseItems",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterCostItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "a09c5210-f57e-4cdc-a0da-db1f105ccfc4"),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    WaterPurchased = table.Column<double>(type: "REAL", nullable: true),
                    WaterPurchasedUnit = table.Column<string>(type: "TEXT", nullable: true),
                    OtherWaterPurchasedUnit = table.Column<string>(type: "TEXT", nullable: true),
                    TotalCosts = table.Column<double>(type: "REAL", nullable: false),
                    PurchasedWaterFrom = table.Column<string>(type: "TEXT", nullable: true),
                    OtherPurchasedWaterFrom = table.Column<string>(type: "TEXT", nullable: true),
                    TransportationCost = table.Column<double>(type: "REAL", nullable: false),
                    OtherCosts = table.Column<double>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterCostItems", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_WaterCostItems_BaseItems_RowKey",
                        column: x => x.RowKey,
                        principalTable: "BaseItems",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ControlDataOptions",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "a09c5210-f57e-4cdc-a0da-db1f105ccfc4"),
                    DropDownControlOption = table.Column<string>(type: "TEXT", nullable: false),
                    TranslationRowKey = table.Column<string>(type: "TEXT", nullable: false),
                    DisplayOrder = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlDataOptions", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_ControlDataOptions_BaseItems_RowKey",
                        column: x => x.RowKey,
                        principalTable: "BaseItems",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Cascade);
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
                    RowKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "a09c5210-f57e-4cdc-a0da-db1f105ccfc4"),
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
                    FeedTypeTranslationString = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedItems", x => x.RowKey);
                    table.ForeignKey(
                        name: "FK_FeedItems_BaseItems_RowKey",
                        column: x => x.RowKey,
                        principalTable: "BaseItems",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeedItems_Translations_FeedType",
                        column: x => x.FeedType,
                        principalTable: "Translations",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "14c9442b-dca1-449e-827d-043c9caf6afb", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "0bc48e59-820d-46c5-8b6d-cdf938226b23", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "7b05e4fb-ee6e-4fa8-aac2-42264a14e7ae", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "bc8eae9f-d053-4c38-8a23-f422c2c59900", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "ea2af976-d176-417c-a383-15889e5f0c09", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "e1bd7f0a-36a1-4ce5-9423-91bd0ad0b0d4", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "88b2ebfd-7793-45e7-a75b-13bccfa1a5e2", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "43a798ca-66d4-45b2-8446-4bb653bb3737", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "68c4ae11-ea22-4b7a-894f-b64a9cc99ffc", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "159ad760-d9d3-4006-b06d-b2e1c2a28edc", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "2a1f02d6-c45a-45cb-8f7b-0631c78bea6c", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "ccd9bde7-b194-42bb-af26-39f84e0b81fc", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "0111b4a9-8e04-4064-96aa-988d579c20de", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "0980d54e-3d00-4b8d-994c-3c70ccf571ea", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "13a6da5d-1c5a-4c14-a0ee-63643dc0f579", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "8a9911fb-7e54-4592-830d-4681fe457b49", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "01cb343f-efda-42f5-a8c6-8ce09ff8cb13", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "6423eef1-b5ce-46d5-b319-ef67a0f2c6aa", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "0016c2fe-70dd-48be-8c04-c860c68748db", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "eb82e318-df59-4420-838e-a5d33640e67b", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "009f0888-f88e-4caf-ac36-a19d0059c5c7", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "0416239c-6201-4bbe-b136-d3343ffe278e", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "ed898248-735c-41ec-b48e-fdb5f2477f42", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "bf7b291e-f0e4-46c9-91e0-7fd453edd040", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "8a6e0337-aad7-4bdb-83bc-1e00ef6bd05e", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "f28cbeca-f630-4c06-9ce4-db9f6fa64697", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "2fcb2edb-2dd0-4357-9739-c240c4c763d3", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "54f275be-f59d-4d01-bffe-d8f319c99b43", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "c7d4a5c1-d825-4700-81bd-398f9e63e760", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "1af0ce9f-08f4-4ae8-acf2-065e047585c7", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "da5f84a1-8977-4385-a0de-75e65767959d", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "4656aef5-9e64-4c08-b8b4-072ff8bcdc98", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "16f62cae-f50d-45c7-9a0f-54e386a992bf", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "07b2793c-4de1-4fff-87a6-b063c41f6acd", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "1d5ceeda-1573-434e-a22e-071f3062bfe6", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "1bd3eb96-4727-4229-aee2-6626d2768797", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "e8635f63-2dd4-478a-8f84-9f2ba61f7bc6", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "5a679349-ff98-45ae-8e42-992ec55c8de3", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "0ba4717f-9e1a-4578-adb7-52e89f5b0ced", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "439185db-6270-4fc1-a13f-0e4e73c19464", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "795c0595-9685-4b57-9493-75a0397f83b4", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "a22b53a6-e5e9-4d55-80d1-7798828cf5ab", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "343bbccd-e1aa-4c07-af22-96caf83bbc8e", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "45d24b1e-2916-4585-8f45-c8c2f8318fe2", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "4802325f-af46-4e4b-9184-058a29aaaef7", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "dadef8cb-6d14-4da3-a017-53c4952be087", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "55c8ba21-3eb9-467a-890f-b2b11dd719d7", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "2d3996d4-ab3f-4357-8640-6df85625e3ed", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "ad5cb049-c345-4fea-bcd2-36499ca3ce12", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "4d2bc0ab-7edf-4613-bd8f-84046aaef544", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "516382c3-bae7-437a-9a2a-66de8e2d68a7", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "0fa15027-0f0d-462e-8e5c-c6a4483ce08f", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "5ca17f02-078f-4f88-800f-260efd0b125c", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "0c0994e5-bb30-4b75-973b-a0f5da30697c", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "786fb005-c7c9-4636-a8f7-9b66da8a683d", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "c0149ef1-6997-4ccf-a3de-3bf674cb8717", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "f85572ad-0b98-4bdb-b39a-7ff7912b13e9", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "a79f3ecd-bbff-4377-9ce3-c96ee7397232", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "c56659b2-d9bf-46d5-90fa-c8ff875795ed", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "b39066e9-b831-42d5-8333-ac9ab35532a5", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "3baf7583-aa21-4c31-90ec-0fd5d253b8a9", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "cd7669b3-5863-4b94-8103-7ec3b6f3c0e8", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "7d8e9931-b717-4abb-ba22-e5034051fa69", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "a8c39632-d077-433b-8cbf-2bafc97cd095", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "1ac5e15e-2273-481c-b1a3-4e84cb12b339", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "6ca8e1d7-b21a-483b-aef6-8829134716de", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "c9fbf14c-bd4b-43e3-ae84-f71345902807", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "c3006711-9fe0-472c-9790-cad0b736a4fe", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "cec8ece6-cdc1-4577-a1c0-acaeae876dcf", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "3e350de1-0752-4bed-b283-45422c067dd5", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "75867a7c-8e5e-42bf-823f-555de8696655", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "36051801-dde1-49db-b5b6-1fe5f4d8cac3", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "608178e1-1622-46d0-9ab5-511e8df26234", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "a4925392-07c9-4343-8ec7-e706882c0ace", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "8f2e8856-8d00-4e57-9220-1fac043a2a7e", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "ba212081-5968-44f7-a9ee-5986aed88234", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "d723d80c-bbf9-4166-b0de-4c303798d22c", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "ef03058e-89c7-4740-bd0d-f8de0d02c9a6", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "3e1997e3-c921-48ac-854c-93dd41d6e4b7", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "cec7267b-2d31-463e-babd-e2dcf41c4a25", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "5958b664-0fb3-4c3c-8ca0-15073fa52c1d", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "ebdbeaad-0dfe-4802-a5bb-f07a670153cf", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "1d01870a-16bd-4672-bf21-323405d0905b", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "4435ce51-7af5-440d-bad4-063ee1724b40", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "f2f40090-021c-4862-817b-1d0d7affe33d", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "73a41c2d-b49e-4bfe-b87f-e24dd048a0a5", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "b0b14a49-e65f-4c5a-b50e-6c96a5075c06", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "42bdbde3-8027-4265-8b1d-2ec5dbfd4d4d", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "fe2ae394-f272-4951-95b3-1ba9a8d8b817", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "fe97e73f-29a9-4606-87b8-53bde82dce51", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "37d66923-93fb-4083-891b-49fedc3443af", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "d7cd9298-2f2d-4327-b673-f1d1f599abd7", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "649af70c-224c-4a42-ada3-0239fa0dd7ca", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "4adccac0-6128-456b-924a-b9c9df3f6930", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "3c849c96-fe4e-4560-afde-9769a563a03f", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "78121b2c-8c81-423e-bbd4-7e509bdfd058", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "e12108ca-4086-4c1c-963a-a6518f0a8ba0", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "8fe6bd77-4456-4f1a-8524-2d97697f7867", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "e18e97cc-1fd7-4c68-a8a6-dbf5b6b61be1", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "2e191f20-a64b-46f9-8f67-344db87633ac", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "e55d0630-24c8-4818-9135-8e9a843f32de", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "b70e14d8-d548-4560-b1d9-f20939e7620a", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "539bee40-dd09-46c8-8581-64274205118c", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "b128233c-5b7a-4b5a-82bd-b6dd52e051a2", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "b90d081c-8f97-44fc-ae5f-2d66e77c0720", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "28f219fc-218a-42e2-8106-d3485334bf30", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "3c734493-98cb-4aec-b9f4-3b6ec3b61cb7", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "efc4dd0f-c700-405a-9a4c-bc1fe3206b18", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "048f8e6b-e1c0-49a7-8d05-66a3d3371b35", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "0cd92b84-78c9-4693-8fba-a77f7eb4d852", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "c3567e23-da8b-4a67-a3ce-5b801af64806", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "e4f8b3c2-2612-4c6c-80c1-6ccff30afc6a", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "07e32b28-e95e-4dbb-a6d3-85569145584b", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "269fb1e8-2cd3-4967-b1d3-27b983bc7156", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "1ab11dcf-0379-4ccb-ae08-981e3220fa4a", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "51974689-81ec-423b-a2c1-562f958397ce", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "399c1faa-25a3-4d1b-91fa-b4bf4aaa5f34", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "4a4b8e08-df25-42d2-b2f1-64410aa747f5", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "15e56d57-8208-49b8-9174-460f76eac918", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "2b003845-f1f4-4380-a121-117626b75879", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "52845133-65fe-4b70-80e9-8757301f3861", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "09dca768-84cb-481f-b047-29ffc5129b2c", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "c433a1e8-9af9-4e5f-b757-713e02bf06d7", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "3bcba90c-4efa-4d32-b35b-029d60ed844a", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "913422cb-42f4-4a0a-bb76-fd30e7cd895a", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "b4dd82c0-e5cf-4c1b-b2d6-d90ad3b64b26", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "7737f472-2b5c-4c59-bb53-26ceec572df3", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "0181adca-09e0-4f61-8cb1-c24a2c3948b6", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "dacd05b3-0ef6-4f89-9474-a23cb32b3702", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "397c4c00-dc49-4289-aa56-0abc8e835a62", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "4d0dbcc5-bc71-4cce-8952-e0dbe01f6594", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "ea71ba20-dbe9-4b68-89fb-e11468a16643", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "8f17d8ea-f196-4cc3-8e77-7fbe8d4bbcf7", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "f3c8c59d-5e70-43fb-b029-d8e037bd94c9", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "eb5b9abf-b5d8-4fd0-b1d3-d76fee03fb38", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "6e5238ed-c401-4765-885d-765d5882e932", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "2374712d-dfd1-48ce-8995-ddacab0d2b6e", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "8e7378f6-9152-4ef8-8811-4eb5c4aff47e", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "5ce26544-a6af-4be6-96b4-eed629378468", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "b8bc6fad-3127-4805-9203-96115a487b02", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "b32de65c-aec1-4328-a51b-fa5888f0b6d2", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "02baee85-9d1d-48d8-b1d2-245657c16cc1", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "f208c2e2-8fb9-445c-b0e2-9469b9c3b0ae", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "8c007b6d-a3ba-44e5-be2d-c4060b6fba42", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "e344fd94-c582-4913-a8a7-a44898fd93ba", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "77fc5f46-3e1c-4338-bf0e-12cda58eec70", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "857cad2d-55a0-4093-a267-dfdf9e3cc61f", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "614589d8-4e41-4759-a758-5ee6c5f51489", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "8870d94b-af65-4c3c-a7bc-b17880e0836f", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "35806643-d506-4287-aa89-459389fe9b33", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "c77b5356-1602-4faf-88e0-2fb4b24bf79f", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "696fea15-e91d-4e05-95aa-8e1c7908b0c8", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "bbaca534-0515-43a2-921c-5639f5f6044f", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "3e38f7d6-9569-4463-aac4-eea8fae14eec", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "BaseItems",
                columns: new[] { "RowKey", "CreatedBy", "IsDeleted", "PartitionKey", "Timestamp" },
                values: new object[] { "ef34bb5d-14ef-4c4d-9158-6fdb5398832a", "InitialUpload", true, "ControlData", null });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HeathCareType6", "(6)  Herd visit/monitoring", "(6)       Herd visit/monitoring Lang1", "(6)       Herd visit/monitoring Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HeathCareType5", "(5)  Use of disinfectants", "(5)       Use of disinfectants Lang1", "(5)       Use of disinfectants Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HeathCareType4", "(4)  Deworming", "(4)  Deworming Lang1", "(4)  Deworming Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HeathCareType3", "(3)  Administration of vitamins", "(3)       Administration of vitamins Lang1", "(3)       Administration of vitamins Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HeathCareType2", "(2)  Preventative (vaccination,", "(2)       Preventative (vaccination, Lang1", "(2)       Preventative (vaccination, Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HeathCareType1", "(1)  Curative (treatment of a disease)", "(1)       Curative (treatment of a disease) Lang1", "(1)       Curative (treatment of a disease) Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownPurchaseFrom4", "Transporter", "Transporter Lang1", "Transporter Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownUnitType2", "Number", "Number Lang1", "Number Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownPurchaseFrom2", "Agro-vet", "Agro-vet Lang1", "Agro-vet Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownPurchaseFrom1", "Feed supplier", "Feed supplier Lang1", "Feed supplier Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownUnitType1", "Kg", "Kg Lang1", "Kg Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType19", "Silage", "Silage Lang1", "Silage Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType18", "Pre-Mixes", "Pre-Mixes Lang1", "Pre-Mixes Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType17", "Vitamins", "Vitamins Lang1", "Vitamins Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthProviderType1", "Private animal health worker or veterinarian", "Private animal health worker or veterinarian Lang1", "Private animal health worker or veterinarian Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownPurchaseFrom3", "Another farmer", "Another farmer Lang1", "Another farmer Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthProviderType2", "Government animal health worker veterinarian", "Government animal health worker veterinarian Lang1", "Government animal health worker veterinarian Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MembershipType1", "Co-operative or group fees", "Co-operative or group fees Lang1", "Co-operative or group fees Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MedicineType2", "Vaccinations", "Vaccinations Lang1", "Vaccinations Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PurchasedWaterFromType3", "Neighbour / friend", "Neighbour / friend Lang1", "Neighbour / friend Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PurchasedWaterFromType2", "Water company", "Water company Lang1", "Water company Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PurchasedWaterFromType1", "Mobile water seller", "Mobile water seller Lang1", "Mobile water seller Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WaterPurchasedUnitType2", "Cubic meter", "Cubic meter Lang1", "Cubic meter Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WaterPurchasedUnitType1", "Litre", "Litre Lang1", "Litre Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HousingExpenseType3", "Repairs or maintenance", "Repairs or maintenance Lang1", "Repairs or maintenance Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HousingExpenseType2", "Expansion of existing housing", "Expansion of existing housing Lang1", "Expansion of existing housing Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HousingExpenseType1", "New house construction", "New house construction Lang1", "New house construction Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LabourType2", "Temporary hired labourer", "Temporary hired labourer Lang1", "Temporary hired labourer Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LabourType1", "Permanent hired labourer", "Permanent hired labourer Lang1", "Permanent hired labourer Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PruchaseFromType3", "Agro-vet store", "Agro-vet store Lang1", "Agro-vet store Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PruchaseFromType2", "Government animal health worker veterinarian", "Government animal health worker veterinarian Lang1", "Government animal health worker veterinarian Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PruchaseFromType1", "Private animal health worker or veterinarian", "Private animal health worker or veterinarian Lang1", "Private animal health worker or veterinarian Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MedicineType4", "Vitamins", "Vitamins Lang1", "Vitamins Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MedicineType3", "Dewormers", "Dewormers Lang1", "Dewormers Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MedicineType1", "Drugs ", "Drugs  Lang1", "Drugs  Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType16", "Minerals", "Minerals Lang1", "Minerals Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerUnitTranslation", "Unit", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType14", "Compounded Feeds (Labelled Feeds)", "Compounded Feeds (Labelled Feeds) Lang1", "Compounded Feeds (Labelled Feeds) Lang2" });

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
                values: new object[] { "TimePeriodUnitType1", "Months", "Months Lang1", "Months Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerClientTranslation", "Select a Client", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerGenderTranslation", "Select a Gender", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerDistrictTranslation", "Select a District", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerCountyTranslation", "Select a County", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType13", "Groundnut Cake", "Groundnut Cake Lang1", "Groundnut Cake Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType12", "Cotton Seed Cake", "Cotton Seed Cake Lang1", "Cotton Seed Cake Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType11", "Sunflower Cake", "Sunflower Cake Lang1", "Sunflower Cake Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType10", "Soybean Meal", "Soybean Meal Lang1", "Soybean Meal Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType9", "Soybean Seed Cake", "Soybean Seed Cake Lang1", "Soybean Seed Cake Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType8", "Ground Maize", "Ground Maize Lang1", "Ground Maize Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType7", "Dried Brewers’ Grain", "Dried Brewers’ Grain Lang1", "Dried Brewers’ Grain Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType15", "Compounded Feeds (Non-Labelled Feeds)", "Compounded Feeds (Non-Labelled Feeds) Lang1", "Compounded Feeds (Non-Labelled Feeds) Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType6", "Wheat Gluten Feed", "Wheat Gluten Feed Lang1", "Wheat Gluten Feed Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType4", "Rice Bran", "Rice Bran Lang1", "Rice Bran Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType3", "Maize Germ", "Maize Germ Lang1", "Maize Germ Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType2", "Wheat Bran", "Wheat Bran Lang1", "Wheat Bran Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType1", "Maize Bran", "Maize Bran Lang1", "Maize Bran Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerCurrencyTranslation", "Select a Currency", "", "" });

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
                values: new object[] { "DropDownFeedType5", "Maize Gluten Feed", "Maize Gluten Feed Lang1", "Maize Gluten Feed Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TimePeriodUnitType2", "Years", "Years Lang1", "Years Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType2", "DistrictType 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ServiceType2", "Natural mating", "Natural mating Lang1", "Natural mating Lang2" });

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
                values: new object[] { "SubCountyType1", "SubCountyType 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType8", "CountyType 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType7", "CountyType 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType6", "CountyType 6", "", "" });

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
                values: new object[] { "SubCountyType5", "SubCountyType 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SubCountyType6", "SubCountyType 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SubCountyType7", "SubCountyType 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SubCountyType8", "SubCountyType 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "RegistrationSuccessfulContinueTranslation", "Continue", "Continue Lang 1", "" });

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
                values: new object[] { "DistrictType5", "DistrictType 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CurrencyType6", "CurrencyType 6", "", "" });

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
                values: new object[] { "CurrencyType2", "CurrencyType 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CurrencyType1", "CurrencyType 1", "", "" });

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
                values: new object[] { "CurrencyType5", "CurrencyType 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ServiceType1", "Artificial insemination", "Artificial insemination Lang1", "Artificial insemination Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType4", "DistrictType 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType1", "DistrictType 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanProviderType5", "Club", "Club Lang1", "Club Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanProviderType4", "Self-help group or savings ", "Self-help group or savings  Lang1", "Self-help group or savings  Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanProviderType3", "Co-operative or group", "Co-operative or group Lang1", "Co-operative or group Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanProviderType2", "Bank", "Bank Lang1", "Bank Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanProviderType1", "Micro-credit provider", "Micro-credit provider Lang1", "Micro-credit provider Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchasedFromType4", "Pig breeding company", "Pig breeding company Lang1", "Pig breeding company Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchasedFromType3", "Pig farmer", "Pig farmer Lang1", "Pig farmer Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchasedFromType2", "Trader", "Trader Lang1", "Trader Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchasedFromType1", "Market ", "Market  Lang1", "Market  Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalType3", "Young male / boar for breeding", "Young male / boar for breeding Lang1", "Young male / boar for breeding Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalType2", "Gilt / sow for breeding", "Gilt / sow for breeding Lang1", "Gilt / sow for breeding Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalType1", "Piglet(s) for fattening", "Piglet(s) for fattening Lang1", "Piglet(s) for fattening Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WhoProvidedServiceType3", "Boar keeper", "Boar keeper Lang1", "Boar keeper Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WhoProvidedServiceType2", "Government artificial insemination service provider", "Government artificial insemination service provider Lang1", "Government artificial insemination service provider Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WhoProvidedServiceType1", "Private artificial insemination service provider", "Private artificial insemination service provider Lang1", "Private artificial insemination service provider Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanProviderType6", "Relatives or friends", "Relatives or friends Lang1", "Relatives or friends Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentType1", "Feeding equipment", "Feeding equipment Lang1", "Feeding equipment Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentType2", "Watering equipment", "Watering equipment Lang1", "Watering equipment Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentType3", "Cleaning equipment", "Cleaning equipment Lang1", "Cleaning equipment Lang2" });

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
                values: new object[] { "VolumeUnitType1", "Kg", "Kg Lang1", "Kg Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ClientType1", "Pig farmer", "Pig farmer Lang1", "Pig farmer Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PaymentType1", "Piglet", "Piglet Lang1", "Piglet Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BreedingServiceType2", "Semen sale (? to include)", "Semen sale (? to include) Lang1", "Semen sale (? to include) Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType3", "DistrictType 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BreedingServiceType1", "Boar services", "Boar services Lang1", "Boar services Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SoldToType2", "Slaughter-house", "Slaughter-house Lang1", "Slaughter-house Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SoldToType1", "Trader", "Trader Lang1", "Trader Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PigType4", "Young male/boar for breeding ", "Young male/boar for breeding  Lang1", "Young male/boar for breeding  Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PigType3", "Gilt/sow sow for breeding", "Gilt/sow sow for breeding Lang1", "Gilt/sow sow for breeding Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PigType2", "Slaughter animal", "Slaughter animal Lang1", "Slaughter animal Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PigType1", "Piglet (for fattening)", "Piglet (for fattening) Lang1", "Piglet (for fattening) Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentType4", "Animal tags", "Animal tags Lang1", "Animal tags Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SoldToType3", "Pig farmer", "Pig farmer Lang1", "Pig farmer Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "RegistrationSuccessfulDescTranslation", "You can now begin collecting and storing your data", "Begin Lang 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SliderControlTranslation", "If new housing built (rather than maintenance) lifespan in years + expected salvage value at end ? ", "If new housing built(rather than maintenance)lifespan in years + expected salvage value at end ? Lang1", "If new housing built(rather than maintenance)lifespan in years + expected salvage value at end ? Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "GoogleSignUpTranslation", "Sign up with Google", "Google Lang 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CostTrans", "Cost", "Cost Lang1", "Cost Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherAmountPurchaseTrans", "Other Amount Purchased", "Other Amount Purchased Lang1", "Other Amount Purchased Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "UnitTrans", "Unit", "Unit Lang1", "Unit Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AmountPurchasedTrans", "Amount Purchased", "Amount Purchased Lang1", "Amount Purchased Lang2" });

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
                values: new object[] { "FeedTypeTranslation", "Feed Type", "Feed Type Lang1", "Feed Type Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TransportCostTrans", "Transportation Cost", "Transportation Cost Lang1", "Transportation Cost Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PurchasedFrom", "Purchased From", "Purchased From Lang1", "Purchased From Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CommentTrans", "Comment", "Comment Lang1", "Comment Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthCareTitleTranslation", "Health Care", "", "" });

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
                values: new object[] { "FeedItemTitleTranslation", "Feed Cost", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CostTranslation", "Any other cost:", "Any other cost: Lang1", "Any other cost: Lang2" });

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
                values: new object[] { "OtherMedicineTypeTranslation", "Other Medicine Type", "Other Medicine Type: Lang1", "Other Medicine Type: Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherHousingExpenseTranslation", "Other Housing Expense", "Other Housing Expense Lang1", "Other Housing Expense Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DeleteTranslation", "Delete", "Delete Lang1", "Delete Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ResetTranslation", "Reset", "Reset Lang1", "Reset Lang2" });

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
                values: new object[] { "UploadDataTranslation", "Upload", "", "" });

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
                values: new object[] { "LoginButton", "Login", "SignUP", "OverHere" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Housing", "Housing", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Water", "Water", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Reproduction", "Reproduction", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Membership", "Co-Operative / Group membership", "Home Lang1", "Home Lang2" });

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
                values: new object[] { "EditTranslation", "Edit", "Edit Lang1", "Edit Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherIncome", "Other Income", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BreedingServiceSale", "Sale of breeding services", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PigSale", "Sale of Pigs", "Home Lang1", "Home Lang2" });

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
                values: new object[] { "OtherCostEvent", "Other", "Other", "Other" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Other", "Other, specify", "Other, specify Lang1", "Other, specify Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ManureSale", "Sale of manure", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "RegistrationSuccessfulTitleTranslation", "Your Account Has Been Created", "Account Created Lang 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "YearsExpectedTranslation", "Expected Housing Lifespan (Years)", "Expected Housing Lifespan (Years)1", "Expected Housing Lifespan (Years)2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WaterCostTitleTranslation", "Water Cost", "", "" });

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
                values: new object[] { "NameTranslation", "Name", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "UserNameTranslation", "Username", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "RegistrationTitleTranslation", "Registration", "Registration Lang 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TotalIncomeTranslation", "Total Income", "", "" });

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
                values: new object[] { "DistrictTranslation", "District", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyTranslation", "County", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SubCountyTranslation", "Sub County", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ParishTranslation", "Parish", "", "" });

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
                values: new object[] { "NumberServicesTranslation", "Number Services", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LanguageTranslation", "Language", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CurrencyTranslation", "Currency", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CellTranslation", "Cell", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SectorTranslation", "Sector", "", "" });

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
                values: new object[] { "GenderTranslation", "Gender", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LanguageType5", "Language5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BreedingServiceSaleTitleTranslation", "Sale of Reproductive Services", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherSoldToTranslation", "Other Sold To", "", "" });

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
                values: new object[] { "OtherServiceTypeTranslation", "Other service type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ServiceTypeTranslation", "Service type", "", "" });

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
                values: new object[] { "WaterPurchasedTranslation", "Water Purchased", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherWhoProvidedServiceTranslation", "Who Provided Service", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchaseTitleTranslation", "Animal Purchase", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalTypeTranslation", "Animal type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherAnimalTypeTranslation", "Animal type", "", "" });

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
                values: new object[] { "OtherEquipmentTypeTranslation", "Other Equipment Type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BrokerageTranslation", "Brokerage", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentTypeTranslation", "Equipment Type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TotalAmountRepaidTranslation", "Total Amount Paid", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherLoanProviderTranslation", "Other Loan Provider", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanProviderTranslation", "Loan Provider", "", "" });

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
                values: new object[] { "EquipmentTitleTranslation", "Equipment", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LanguageType6", "Language6", "", "" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "78121b2c-8c81-423e-bbd4-7e509bdfd058", 20, "FeedType", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "07b2793c-4de1-4fff-87a6-b063c41f6acd", 1, "PigSaleType", "PigType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "1d5ceeda-1573-434e-a22e-071f3062bfe6", 2, "PigSaleType", "PigType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "1bd3eb96-4727-4229-aee2-6626d2768797", 3, "PigSaleType", "PigType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "eb82e318-df59-4420-838e-a5d33640e67b", 4, "PigSaleType", "PigType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "6423eef1-b5ce-46d5-b319-ef67a0f2c6aa", 1, "SoldToType", "SoldToType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "01cb343f-efda-42f5-a8c6-8ce09ff8cb13", 2, "SoldToType", "SoldToType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "0bc48e59-820d-46c5-8b6d-cdf938226b23", 3, "SoldToType", "SoldToType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "bc8eae9f-d053-4c38-8a23-f422c2c59900", 1, "BreedingServiceType", "BreedingServiceType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "ea2af976-d176-417c-a383-15889e5f0c09", 2, "BreedingServiceType", "BreedingServiceType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "88b2ebfd-7793-45e7-a75b-13bccfa1a5e2", 1, "OtherPaymentType", "PaymentType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "68c4ae11-ea22-4b7a-894f-b64a9cc99ffc", 1, "ClientType", "ClientType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "2a1f02d6-c45a-45cb-8f7b-0631c78bea6c", 1, "VolumeUnitType", "VolumeUnitType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "0111b4a9-8e04-4064-96aa-988d579c20de", 1, "GenderType", "GenderType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "0980d54e-3d00-4b8d-994c-3c70ccf571ea", 2, "GenderType", "GenderType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "13a6da5d-1c5a-4c14-a0ee-63643dc0f579", 3, "GenderType", "GenderType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "4656aef5-9e64-4c08-b8b4-072ff8bcdc98", 4, "EquipmentType", "EquipmentType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "da5f84a1-8977-4385-a0de-75e65767959d", 3, "EquipmentType", "EquipmentType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "1af0ce9f-08f4-4ae8-acf2-065e047585c7", 2, "EquipmentType", "EquipmentType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "e8635f63-2dd4-478a-8f84-9f2ba61f7bc6", 1, "EquipmentType", "EquipmentType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "7737f472-2b5c-4c59-bb53-26ceec572df3", 1, "WhoProvidedServiceUnit", "WhoProvidedServiceType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "eb5b9abf-b5d8-4fd0-b1d3-d76fee03fb38", 2, "WhoProvidedServiceUnit", "WhoProvidedServiceType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "0181adca-09e0-4f61-8cb1-c24a2c3948b6", 3, "WhoProvidedServiceUnit", "WhoProvidedServiceType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "397c4c00-dc49-4289-aa56-0abc8e835a62", 1, "AnimalType", "AnimalType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "4d0dbcc5-bc71-4cce-8952-e0dbe01f6594", 2, "AnimalType", "AnimalType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "ea71ba20-dbe9-4b68-89fb-e11468a16643", 3, "AnimalType", "AnimalType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "3e1997e3-c921-48ac-854c-93dd41d6e4b7", 1, "AnimalPurchasedFrom", "AnimalPurchasedFromType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "8a9911fb-7e54-4592-830d-4681fe457b49", 1, "DistrictType", "DistrictType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "3c849c96-fe4e-4560-afde-9769a563a03f", 2, "AnimalPurchasedFrom", "AnimalPurchasedFromType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "5a679349-ff98-45ae-8e42-992ec55c8de3", 4, "AnimalPurchasedFrom", "AnimalPurchasedFromType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "0416239c-6201-4bbe-b136-d3343ffe278e", 1, "LoanProvider", "LoanProviderType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "ed898248-735c-41ec-b48e-fdb5f2477f42", 2, "LoanProvider", "LoanProviderType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "bf7b291e-f0e4-46c9-91e0-7fd453edd040", 3, "LoanProvider", "LoanProviderType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "8a6e0337-aad7-4bdb-83bc-1e00ef6bd05e", 4, "LoanProvider", "LoanProviderType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "f28cbeca-f630-4c06-9ce4-db9f6fa64697", 5, "LoanProvider", "LoanProviderType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "2fcb2edb-2dd0-4357-9739-c240c4c763d3", 6, "LoanProvider", "LoanProviderType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "d723d80c-bbf9-4166-b0de-4c303798d22c", 3, "AnimalPurchasedFrom", "AnimalPurchasedFromType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "2374712d-dfd1-48ce-8995-ddacab0d2b6e", 2, "ServiceUnit", "ServiceType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "54f275be-f59d-4d01-bffe-d8f319c99b43", 2, "DistrictType", "DistrictType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "c9fbf14c-bd4b-43e3-ae84-f71345902807", 4, "DistrictType", "DistrictType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "75867a7c-8e5e-42bf-823f-555de8696655", 1, "CountryType", "CountryTypeUganda" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "36051801-dde1-49db-b5b6-1fe5f4d8cac3", 2, "CountryType", "CountryTypeVietnam" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "608178e1-1622-46d0-9ab5-511e8df26234", 3, "CountryType", "CountryTypeRwanda" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "343bbccd-e1aa-4c07-af22-96caf83bbc8e", 1, "CurrencyType", "CurrencyType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "45d24b1e-2916-4585-8f45-c8c2f8318fe2", 2, "CurrencyType", "CurrencyType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "4802325f-af46-4e4b-9184-058a29aaaef7", 3, "CurrencyType", "CurrencyType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "dadef8cb-6d14-4da3-a017-53c4952be087", 4, "CurrencyType", "CurrencyType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "55c8ba21-3eb9-467a-890f-b2b11dd719d7", 5, "CurrencyType", "CurrencyType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "2d3996d4-ab3f-4357-8640-6df85625e3ed", 6, "CurrencyType", "CurrencyType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "ad5cb049-c345-4fea-bcd2-36499ca3ce12", 7, "CurrencyType", "CurrencyType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "4d2bc0ab-7edf-4613-bd8f-84046aaef544", 8, "CurrencyType", "CurrencyType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "516382c3-bae7-437a-9a2a-66de8e2d68a7", 1, "LanguageType", "LanguageType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "0fa15027-0f0d-462e-8e5c-c6a4483ce08f", 2, "LanguageType", "LanguageType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "5ca17f02-078f-4f88-800f-260efd0b125c", 3, "LanguageType", "LanguageType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "0c0994e5-bb30-4b75-973b-a0f5da30697c", 4, "LanguageType", "LanguageType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "a22b53a6-e5e9-4d55-80d1-7798828cf5ab", 8, "SubCountyType", "SubCountyType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "795c0595-9685-4b57-9493-75a0397f83b4", 7, "SubCountyType", "SubCountyType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "c0149ef1-6997-4ccf-a3de-3bf674cb8717", 6, "SubCountyType", "SubCountyType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "f85572ad-0b98-4bdb-b39a-7ff7912b13e9", 5, "SubCountyType", "SubCountyType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "439185db-6270-4fc1-a13f-0e4e73c19464", 5, "DistrictType", "DistrictType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "b39066e9-b831-42d5-8333-ac9ab35532a5", 6, "DistrictType", "DistrictType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "3baf7583-aa21-4c31-90ec-0fd5d253b8a9", 7, "DistrictType", "DistrictType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "cd7669b3-5863-4b94-8103-7ec3b6f3c0e8", 8, "DistrictType", "DistrictType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "7d8e9931-b717-4abb-ba22-e5034051fa69", 1, "CountyType", "CountyType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "a8c39632-d077-433b-8cbf-2bafc97cd095", 2, "CountyType", "CountyType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "1ac5e15e-2273-481c-b1a3-4e84cb12b339", 3, "CountyType", "CountyType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "0ba4717f-9e1a-4578-adb7-52e89f5b0ced", 3, "DistrictType", "DistrictType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "6ca8e1d7-b21a-483b-aef6-8829134716de", 4, "CountyType", "CountyType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "ba212081-5968-44f7-a9ee-5986aed88234", 6, "CountyType", "CountyType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "cec8ece6-cdc1-4577-a1c0-acaeae876dcf", 7, "CountyType", "CountyType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "3e350de1-0752-4bed-b283-45422c067dd5", 8, "CountyType", "CountyType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "a4925392-07c9-4343-8ec7-e706882c0ace", 1, "SubCountyType", "SubCountyType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "8f2e8856-8d00-4e57-9220-1fac043a2a7e", 2, "SubCountyType", "SubCountyType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "c56659b2-d9bf-46d5-90fa-c8ff875795ed", 3, "SubCountyType", "SubCountyType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "a79f3ecd-bbff-4377-9ce3-c96ee7397232", 4, "SubCountyType", "SubCountyType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "c3006711-9fe0-472c-9790-cad0b736a4fe", 5, "CountyType", "CountyType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "ef03058e-89c7-4740-bd0d-f8de0d02c9a6", 5, "LanguageType", "LanguageType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "3bcba90c-4efa-4d32-b35b-029d60ed844a", 1, "ServiceUnit", "ServiceType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "09dca768-84cb-481f-b047-29ffc5129b2c", 1, "TimePeriodUnitType", "TimePeriodUnitType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "43a798ca-66d4-45b2-8446-4bb653bb3737", 2, "OtherPaymentType", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "159ad760-d9d3-4006-b06d-b2e1c2a28edc", 9, "ClientType", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "ccd9bde7-b194-42bb-af26-39f84e0b81fc", 9, "VolumeUnitType", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "14c9442b-dca1-449e-827d-043c9caf6afb", 1, "FeedType", "DropDownFeedType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "e18e97cc-1fd7-4c68-a8a6-dbf5b6b61be1", 2, "FeedType", "DropDownFeedType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "2e191f20-a64b-46f9-8f67-344db87633ac", 3, "FeedType", "DropDownFeedType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "e55d0630-24c8-4818-9135-8e9a843f32de", 4, "FeedType", "DropDownFeedType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "b70e14d8-d548-4560-b1d9-f20939e7620a", 5, "FeedType", "DropDownFeedType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "539bee40-dd09-46c8-8581-64274205118c", 6, "FeedType", "DropDownFeedType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "b128233c-5b7a-4b5a-82bd-b6dd52e051a2", 7, "FeedType", "DropDownFeedType7" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "b90d081c-8f97-44fc-ae5f-2d66e77c0720", 8, "FeedType", "DropDownFeedType8" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "3c734493-98cb-4aec-b9f4-3b6ec3b61cb7", 9, "FeedType", "DropDownFeedType9" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "1ab11dcf-0379-4ccb-ae08-981e3220fa4a", 10, "FeedType", "DropDownFeedType10" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "efc4dd0f-c700-405a-9a4c-bc1fe3206b18", 11, "FeedType", "DropDownFeedType11" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "048f8e6b-e1c0-49a7-8d05-66a3d3371b35", 12, "FeedType", "DropDownFeedType12" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "e1bd7f0a-36a1-4ce5-9423-91bd0ad0b0d4", 9, "BreedingServiceType", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "7b05e4fb-ee6e-4fa8-aac2-42264a14e7ae", 9, "SoldToType", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "0016c2fe-70dd-48be-8c04-c860c68748db", 9, "PigSaleType", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "16f62cae-f50d-45c7-9a0f-54e386a992bf", 9, "EquipmentType", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "5958b664-0fb3-4c3c-8ca0-15073fa52c1d", 5, "FeedAmountPurchasedUnitType", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "73a41c2d-b49e-4bfe-b87f-e24dd048a0a5", 5, "FeedPurchasedType", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "649af70c-224c-4a42-ada3-0239fa0dd7ca", 11, "HealthCareType", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "51974689-81ec-423b-a2c1-562f958397ce", 11, "HealthServivceProivderType", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "b32de65c-aec1-4328-a51b-fa5888f0b6d2", 11, "HealthMedicineType", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "e344fd94-c582-4913-a8a7-a44898fd93ba", 11, "HealthPurchaseFromType", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "614589d8-4e41-4759-a758-5ee6c5f51489", 7, "LabourType", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "0cd92b84-78c9-4693-8fba-a77f7eb4d852", 13, "FeedType", "DropDownFeedType13" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "696fea15-e91d-4e05-95aa-8e1c7908b0c8", 6, "HousingType", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "15e56d57-8208-49b8-9174-460f76eac918", 11, "PurchasedWaterFrom", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "52845133-65fe-4b70-80e9-8757301f3861", 9, "MembershipType", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "913422cb-42f4-4a0a-bb76-fd30e7cd895a", 9, "ServiceUnit", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "dacd05b3-0ef6-4f89-9474-a23cb32b3702", 9, "WhoProvidedServiceUnit", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "f3c8c59d-5e70-43fb-b029-d8e037bd94c9", 9, "AnimalType", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "009f0888-f88e-4caf-ac36-a19d0059c5c7", 9, "AnimalPurchasedFrom", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "c7d4a5c1-d825-4700-81bd-398f9e63e760", 9, "LoanProvider", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "8e7378f6-9152-4ef8-8811-4eb5c4aff47e", 6, "WaterPurchasedUnit", "Other" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "c433a1e8-9af9-4e5f-b757-713e02bf06d7", 2, "TimePeriodUnitType", "TimePeriodUnitType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "c3567e23-da8b-4a67-a3ce-5b801af64806", 14, "FeedType", "DropDownFeedType14" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "07e32b28-e95e-4dbb-a6d3-85569145584b", 16, "FeedType", "DropDownFeedType16" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "b8bc6fad-3127-4805-9203-96115a487b02", 4, "HealthMedicineType", "MedicineType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "02baee85-9d1d-48d8-b1d2-245657c16cc1", 1, "HealthPurchaseFromType", "PruchaseFromType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "f208c2e2-8fb9-445c-b0e2-9469b9c3b0ae", 2, "HealthPurchaseFromType", "PruchaseFromType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "8c007b6d-a3ba-44e5-be2d-c4060b6fba42", 3, "HealthPurchaseFromType", "PruchaseFromType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "77fc5f46-3e1c-4338-bf0e-12cda58eec70", 1, "LabourType", "LabourType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "ef34bb5d-14ef-4c4d-9158-6fdb5398832a", 2, "LabourType", "LabourType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "8870d94b-af65-4c3c-a7bc-b17880e0836f", 1, "HousingType", "HousingExpenseType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "35806643-d506-4287-aa89-459389fe9b33", 2, "HousingType", "HousingExpenseType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "c77b5356-1602-4faf-88e0-2fb4b24bf79f", 3, "HousingType", "HousingExpenseType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "bbaca534-0515-43a2-921c-5639f5f6044f", 1, "WaterPurchasedUnit", "WaterPurchasedUnitType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "3e38f7d6-9569-4463-aac4-eea8fae14eec", 2, "WaterPurchasedUnit", "WaterPurchasedUnitType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "5ce26544-a6af-4be6-96b4-eed629378468", 1, "PurchasedWaterFrom", "PurchasedWaterFromType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "6e5238ed-c401-4765-885d-765d5882e932", 2, "PurchasedWaterFrom", "PurchasedWaterFromType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "b4dd82c0-e5cf-4c1b-b2d6-d90ad3b64b26", 3, "PurchasedWaterFrom", "PurchasedWaterFromType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "2b003845-f1f4-4380-a121-117626b75879", 1, "MembershipType", "MembershipType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "857cad2d-55a0-4093-a267-dfdf9e3cc61f", 3, "HealthMedicineType", "MedicineType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "4a4b8e08-df25-42d2-b2f1-64410aa747f5", 2, "HealthMedicineType", "MedicineType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "8f17d8ea-f196-4cc3-8e77-7fbe8d4bbcf7", 1, "HealthMedicineType", "MedicineType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "28f219fc-218a-42e2-8106-d3485334bf30", 2, "HealthServivceProivderType", "HealthProviderType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "269fb1e8-2cd3-4967-b1d3-27b983bc7156", 17, "FeedType", "DropDownFeedType17" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "8fe6bd77-4456-4f1a-8524-2d97697f7867", 18, "FeedType", "DropDownFeedType18" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "e12108ca-4086-4c1c-963a-a6518f0a8ba0", 19, "FeedType", "DropDownFeedType19" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "399c1faa-25a3-4d1b-91fa-b4bf4aaa5f34", 1, "FeedAmountPurchasedUnitType", "DropDownUnitType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "cec7267b-2d31-463e-babd-e2dcf41c4a25", 2, "FeedAmountPurchasedUnitType", "DropDownUnitType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "ebdbeaad-0dfe-4802-a5bb-f07a670153cf", 1, "FeedPurchasedType", "DropDownPurchaseFrom1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "1d01870a-16bd-4672-bf21-323405d0905b", 2, "FeedPurchasedType", "DropDownPurchaseFrom2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "e4f8b3c2-2612-4c6c-80c1-6ccff30afc6a", 15, "FeedType", "DropDownFeedType15" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "4435ce51-7af5-440d-bad4-063ee1724b40", 3, "FeedPurchasedType", "DropDownPurchaseFrom3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "b0b14a49-e65f-4c5a-b50e-6c96a5075c06", 1, "HealthCareType", "HeathCareType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "42bdbde3-8027-4265-8b1d-2ec5dbfd4d4d", 2, "HealthCareType", "HeathCareType2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "fe2ae394-f272-4951-95b3-1ba9a8d8b817", 3, "HealthCareType", "HeathCareType3" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "fe97e73f-29a9-4606-87b8-53bde82dce51", 4, "HealthCareType", "HeathCareType4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "37d66923-93fb-4083-891b-49fedc3443af", 5, "HealthCareType", "HeathCareType5" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "d7cd9298-2f2d-4327-b673-f1d1f599abd7", 6, "HealthCareType", "HeathCareType6" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "4adccac0-6128-456b-924a-b9c9df3f6930", 1, "HealthServivceProivderType", "HealthProviderType1" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "f2f40090-021c-4862-817b-1d0d7affe33d", 4, "FeedPurchasedType", "DropDownPurchaseFrom4" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "RowKey", "DisplayOrder", "DropDownControlOption", "TranslationRowKey" },
                values: new object[] { "786fb005-c7c9-4636-a8f7-9b66da8a683d", 6, "LanguageType", "LanguageType6" });

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
                name: "Items");

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

            migrationBuilder.DropTable(
                name: "BaseItems");
        }
    }
}
