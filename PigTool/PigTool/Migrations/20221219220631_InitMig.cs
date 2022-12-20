using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class InitMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
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
                name: "OtherCostItems",
                columns: table => new
                {
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
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
                    RowKey = table.Column<string>(type: "TEXT", nullable: false),
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
                    DurationStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DurationFinish = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    AnimalExpenseTranslationString = table.Column<string>(type: "TEXT", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_AnimalHouseItems_Translations_HousingExpense",
                        column: x => x.HousingExpense,
                        principalTable: "Translations",
                        principalColumn: "RowKey");
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
                    DisplayTypeTranslationRowKey = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayTypeTranslationString = table.Column<string>(type: "TEXT", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_AnimalPurchaseItems_Translations_DisplayTypeTranslationRowKey",
                        column: x => x.DisplayTypeTranslationRowKey,
                        principalTable: "Translations",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Restrict);
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
                    DisplayTypeTranslationRowKey = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayTypeTranslationString = table.Column<string>(type: "TEXT", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_BreedingServiceSaleItems_Translations_DisplayTypeTranslationRowKey",
                        column: x => x.DisplayTypeTranslationRowKey,
                        principalTable: "Translations",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ControlDataOptions",
                columns: table => new
                {
                    DropDownControlOption = table.Column<string>(type: "TEXT", nullable: false),
                    TranslationRowKey = table.Column<string>(type: "TEXT", nullable: false),
                    DisplayOrder = table.Column<int>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PartitionKey = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "ControlData"),
                    RowKey = table.Column<string>(type: "TEXT", nullable: false, computedColumnSql: "[DropDownControlOption] + '-' + [TranslationRowKey]"),
                    Timestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlDataOptions", x => new { x.TranslationRowKey, x.DropDownControlOption });
                    table.ForeignKey(
                        name: "FK_ControlDataOptions_Translations_TranslationRowKey",
                        column: x => x.TranslationRowKey,
                        principalTable: "Translations",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Cascade);
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
                    DisplayTypeTranslationRowKey = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayTypeTranslationString = table.Column<string>(type: "TEXT", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_EquipmentItems_Translations_DisplayTypeTranslationRowKey",
                        column: x => x.DisplayTypeTranslationRowKey,
                        principalTable: "Translations",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Restrict);
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
                    DurationStart = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DurationFinish = table.Column<DateTime>(type: "TEXT", nullable: true),
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
                        principalColumn: "RowKey");
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
                    DisplayTypeTranslationRowKey = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayTypeTranslationString = table.Column<string>(type: "TEXT", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_HealthCareItems_Translations_DisplayTypeTranslationRowKey",
                        column: x => x.DisplayTypeTranslationRowKey,
                        principalTable: "Translations",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Restrict);
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
                    DurationStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DurationFinish = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DisplayTypeTranslationRowKey = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayTypeTranslationString = table.Column<string>(type: "TEXT", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_LabourCostItems_Translations_DisplayTypeTranslationRowKey",
                        column: x => x.DisplayTypeTranslationRowKey,
                        principalTable: "Translations",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Restrict);
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
                    DisplayTypeTranslationRowKey = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayTypeTranslationString = table.Column<string>(type: "TEXT", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_LoanRepaymentItems_Translations_DisplayTypeTranslationRowKey",
                        column: x => x.DisplayTypeTranslationRowKey,
                        principalTable: "Translations",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Restrict);
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
                    DisplayTypeTranslationRowKey = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayTypeTranslationString = table.Column<string>(type: "TEXT", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_ManureSaleItems_Translations_DisplayTypeTranslationRowKey",
                        column: x => x.DisplayTypeTranslationRowKey,
                        principalTable: "Translations",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Restrict);
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
                    DisplayTypeTranslationRowKey = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayTypeTranslationString = table.Column<string>(type: "TEXT", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_MembershipItems_Translations_DisplayTypeTranslationRowKey",
                        column: x => x.DisplayTypeTranslationRowKey,
                        principalTable: "Translations",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Restrict);
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
                    DisplayTypeTranslationRowKey = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayTypeTranslationString = table.Column<string>(type: "TEXT", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_PigSaleItems_Translations_DisplayTypeTranslationRowKey",
                        column: x => x.DisplayTypeTranslationRowKey,
                        principalTable: "Translations",
                        principalColumn: "RowKey",
                        onDelete: ReferentialAction.Restrict);
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
                    DisplayTypeTranslationRowKey = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayTypeTranslationString = table.Column<string>(type: "TEXT", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_ReproductiveItems_Translations_DisplayTypeTranslationRowKey",
                        column: x => x.DisplayTypeTranslationRowKey,
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
                values: new object[] { "DropDownPurchaseFrom3", "Another farmer", "Another farmer Lang1", "Another farmer Lang2" });

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
                values: new object[] { "DropDownUnitType2", "Number", "Number Lang1", "Number Lang2" });

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
                values: new object[] { "DropDownFeedType16", "Minerals", "Minerals Lang1", "Minerals Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HeathCareType6", "(6)  Herd visit/monitoring", "(6)       Herd visit/monitoring Lang1", "(6)       Herd visit/monitoring Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthProviderType1", "Private animal health worker or veterinarian", "Private animal health worker or veterinarian Lang1", "Private animal health worker or veterinarian Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthProviderType2", "Government animal health worker veterinarian", "Government animal health worker veterinarian Lang1", "Government animal health worker veterinarian Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MedicineType1", "Drugs ", "Drugs  Lang1", "Drugs  Lang2" });

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
                values: new object[] { "DropDownFeedType15", "Compounded Feeds (Non-Labelled Feeds)", "Compounded Feeds (Non-Labelled Feeds) Lang1", "Compounded Feeds (Non-Labelled Feeds) Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HousingExpenseType1", "New house construction", "New house construction Lang1", "New house construction Lang2" });

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
                values: new object[] { "MedicineType2", "Vaccinations", "Vaccinations Lang1", "Vaccinations Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LabourType2", "Temporary hired labourer", "Temporary hired labourer Lang1", "Temporary hired labourer Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MembershipType1", "Co-operative or group fees", "Co-operative or group fees Lang1", "Co-operative or group fees Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType14", "Compounded Feeds (Labelled Feeds)", "Compounded Feeds (Labelled Feeds) Lang1", "Compounded Feeds (Labelled Feeds) Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType12", "Cotton Seed Cake", "Cotton Seed Cake Lang1", "Cotton Seed Cake Lang2" });

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
                values: new object[] { "RegistrationSuccessfulContinueTranslation", "Continue", "Continue Lang 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "RegistrationSuccessfulDescTranslation", "You can now begin collecting and storing your data", "Begin Lang 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerSoldToTranslation", "Select a Buyer", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerPaymentTypeTranslation", "Select a Payment Type", "", "" });

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
                values: new object[] { "DropDownFeedType6", "Wheat Gluten Feed", "Wheat Gluten Feed Lang1", "Wheat Gluten Feed Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType5", "Maize Gluten Feed", "Maize Gluten Feed Lang1", "Maize Gluten Feed Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType13", "Groundnut Cake", "Groundnut Cake Lang1", "Groundnut Cake Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType4", "Rice Bran", "Rice Bran Lang1", "Rice Bran Lang2" });

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
                values: new object[] { "PickerCountyTranslation", "Select a County", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PickerDistrictTranslation", "Select a District", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownFeedType3", "Maize Germ", "Maize Germ Lang1", "Maize Germ Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TimePeriodUnitType1", "Months", "Months Lang1", "Months Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TimePeriodUnitType2", "Years", "Years Lang1", "Years Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ServiceType1", "Artificial insemination", "Artificial insemination Lang1", "Artificial insemination Lang2" });

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
                values: new object[] { "DistrictType5", "DistrictType 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SubCountyType4", "SubCountyType 4", "", "" });

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
                values: new object[] { "DistrictType4", "DistrictType 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CurrencyType5", "CurrencyType 5", "", "" });

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
                values: new object[] { "SubCountyType8", "SubCountyType 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CurrencyType4", "CurrencyType 4", "", "" });

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
                values: new object[] { "LoanProviderType6", "Relatives or friends", "Relatives or friends Lang1", "Relatives or friends Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchasedFromType2", "Trader", "Trader Lang1", "Trader Lang2" });

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
                values: new object[] { "ServiceType2", "Natural mating", "Natural mating Lang1", "Natural mating Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchasedFromType1", "Market ", "Market  Lang1", "Market  Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "RegistrationSuccessfulTitleTranslation", "Your Account Has Been Created", "Account Created Lang 1", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentType1", "Feeding equipment", "Feeding equipment Lang1", "Feeding equipment Lang2" });

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
                values: new object[] { "EquipmentType2", "Watering equipment", "Watering equipment Lang1", "Watering equipment Lang2" });

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
                values: new object[] { "GoogleSignUpTranslation", "Sign up with Google", "Google Lang 1", "" });

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
                values: new object[] { "FeedDurationTranslation", "Feed use duration", "Duration Lang1", "Duration Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LabourDurationTranslation", "Labour use duration", "Duration Lang1", "Duration Lang2" });

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
                values: new object[] { "FeedItemTitleTranslation", "Feed Cost", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherMedicineTypeTranslation", "Other Medicine Type", "Other Medicine Type: Lang1", "Other Medicine Type: Lang2" });

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
                values: new object[] { "MedicineTypeTranslation", "Medicine Type", "Medicine Type: Lang1", "Medicine Type: Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "FinishTranslation", "Finish", "Finish Lang1", "Finish Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "StartTranslation", "Start", "Start Lang1", "Start Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DeleteTranslation", "Delete", "Delete Lang1", "Delete Lang2" });

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
                values: new object[] { "UploadDataTranslation", "Upload", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Reproduction", "Reproduction", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "RegistrationTranslation", "Registration", "", "" });

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
                values: new object[] { "FilterTranslation", "Filter by:", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HousingTitleTranslation", "Animal Housing", "Animal Housing Lang1", "Animal Housing Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Membership", "Co-Operative / Group membership", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherCostEvent", "Other", "Other", "Other" });

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
                values: new object[] { "Other", "Other, specify", "Other, specify Lang1", "Other, specify Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DateTranslation", "Date", "Date Lang1", "Date Lang 2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherIncome", "Other Income", "Home Lang1", "Home Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ManureSale", "Sale of manure", "Home Lang1", "Home Lang2" });

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
                values: new object[] { "Equipment", "Equipment", "Equipment Lang1", "Equipment Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LanguageType5", "Language5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HousingExpenseTranslation", "Housing Expense", "Housing Expense Lang1", "Housing Expense Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "YearsExpectedTranslation", "Expected Housing Lifespan (Years)", "Expected Housing Lifespan (Years)1", "Expected Housing Lifespan (Years)2" });

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
                values: new object[] { "NumberServicesTranslation", "Number Services", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BreedingServiceSaleTitleTranslation", "Sale of Reproductive Services", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EmailTranslation", "Email", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PhoneNumberTranslation", "Phone Number", "", "" });

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
                values: new object[] { "BrokerageTranslation", "Brokerage", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CurrencyTranslation", "Currency", "", "" });

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
                values: new object[] { "ParishTranslation", "Parish", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SubCountyTranslation", "Sub County", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CellTranslation", "Cell", "", "" });

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
                values: new object[] { "SowsServicedTranslation", "Sows Serviced", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MembershipTypeTranslation", "Membership type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WaterDurationTranslation", "Water use duration", "Duration Lang1", "Duration Lang2" });

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
                values: new object[] { "WaterCostTitleTranslation", "Water Cost", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SliderControlTranslation", "If new housing built (rather than maintenance) lifespan in years + expected salvage value at end ? ", "If new housing built(rather than maintenance)lifespan in years + expected salvage value at end ? Lang1", "If new housing built(rather than maintenance)lifespan in years + expected salvage value at end ? Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MembershipTitleTranslation", "Co-Operative / Group membership", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherHousingExpenseTranslation", "Other Housing Expense", "Other Housing Expense Lang1", "Other Housing Expense Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WhoProvidedServiceTranslation", "Who Provided Service", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalPurchaseTitleTranslation", "Animal Purchase", "", "" });

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
                values: new object[] { "EquipmentTypeTranslation", "Equipment Type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentTitleTranslation", "Equipment", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherWhoProvidedServiceTranslation", "Who Provided Service", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TotalAmountRepaidTranslation", "Total Amount Paid", "", "" });

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
                values: new object[] { "OtherAnimalTypeTranslation", "Animal type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalTypeTranslation", "Animal type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherLoanProviderTranslation", "Other Loan Provider", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LanguageType6", "Language6", "", "" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "Other", "InitialUpload", 20, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "PigSaleType", "PigType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "PigSaleType", "PigType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "PigSaleType", "PigType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "PigSaleType", "PigType4", "InitialUpload", 4, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "SoldToType", "SoldToType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "SoldToType", "SoldToType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "SoldToType", "SoldToType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "BreedingServiceType", "BreedingServiceType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "BreedingServiceType", "BreedingServiceType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "OtherPaymentType", "PaymentType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "ClientType", "ClientType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "VolumeUnitType", "VolumeUnitType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "GenderType", "GenderType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "GenderType", "GenderType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "GenderType", "GenderType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "EquipmentType", "EquipmentType4", "InitialUpload", 4, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "EquipmentType", "EquipmentType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "EquipmentType", "EquipmentType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "EquipmentType", "EquipmentType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "WhoProvidedServiceUnit", "WhoProvidedServiceType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "WhoProvidedServiceUnit", "WhoProvidedServiceType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "WhoProvidedServiceUnit", "WhoProvidedServiceType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "AnimalType", "AnimalType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "AnimalType", "AnimalType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "AnimalType", "AnimalType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "AnimalPurchasedFrom", "AnimalPurchasedFromType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "DistrictType", "DistrictType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "AnimalPurchasedFrom", "AnimalPurchasedFromType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "AnimalPurchasedFrom", "AnimalPurchasedFromType4", "InitialUpload", 4, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "LoanProvider", "LoanProviderType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "LoanProvider", "LoanProviderType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "LoanProvider", "LoanProviderType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "LoanProvider", "LoanProviderType4", "InitialUpload", 4, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "LoanProvider", "LoanProviderType5", "InitialUpload", 5, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "LoanProvider", "LoanProviderType6", "InitialUpload", 6, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "AnimalPurchasedFrom", "AnimalPurchasedFromType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "ServiceUnit", "ServiceType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "DistrictType", "DistrictType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "DistrictType", "DistrictType4", "InitialUpload", 4, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CountryType", "CountryTypeUganda", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CountryType", "CountryTypeVietnam", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CountryType", "CountryTypeRwanda", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CurrencyType", "CurrencyType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CurrencyType", "CurrencyType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CurrencyType", "CurrencyType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CurrencyType", "CurrencyType4", "InitialUpload", 4, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CurrencyType", "CurrencyType5", "InitialUpload", 5, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CurrencyType", "CurrencyType6", "InitialUpload", 6, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CurrencyType", "CurrencyType7", "InitialUpload", 7, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CurrencyType", "CurrencyType8", "InitialUpload", 8, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "LanguageType", "LanguageType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "LanguageType", "LanguageType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "LanguageType", "LanguageType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "LanguageType", "LanguageType4", "InitialUpload", 4, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "SubCountyType", "SubCountyType8", "InitialUpload", 8, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "SubCountyType", "SubCountyType7", "InitialUpload", 7, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "SubCountyType", "SubCountyType6", "InitialUpload", 6, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "SubCountyType", "SubCountyType5", "InitialUpload", 5, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "DistrictType", "DistrictType5", "InitialUpload", 5, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "DistrictType", "DistrictType6", "InitialUpload", 6, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "DistrictType", "DistrictType7", "InitialUpload", 7, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "DistrictType", "DistrictType8", "InitialUpload", 8, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CountyType", "CountyType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CountyType", "CountyType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CountyType", "CountyType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "DistrictType", "DistrictType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CountyType", "CountyType4", "InitialUpload", 4, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CountyType", "CountyType6", "InitialUpload", 6, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CountyType", "CountyType7", "InitialUpload", 7, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CountyType", "CountyType8", "InitialUpload", 8, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "SubCountyType", "SubCountyType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "SubCountyType", "SubCountyType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "SubCountyType", "SubCountyType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "SubCountyType", "SubCountyType4", "InitialUpload", 4, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "CountyType", "CountyType5", "InitialUpload", 5, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "LanguageType", "LanguageType5", "InitialUpload", 5, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "ServiceUnit", "ServiceType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "TimePeriodUnitType", "TimePeriodUnitType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "OtherPaymentType", "Other", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "ClientType", "Other", "InitialUpload", 9, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "VolumeUnitType", "Other", "InitialUpload", 9, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType4", "InitialUpload", 4, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType5", "InitialUpload", 5, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType6", "InitialUpload", 6, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType7", "InitialUpload", 7, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType8", "InitialUpload", 8, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType9", "InitialUpload", 9, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType10", "InitialUpload", 10, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType11", "InitialUpload", 11, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType12", "InitialUpload", 12, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "BreedingServiceType", "Other", "InitialUpload", 9, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "SoldToType", "Other", "InitialUpload", 9, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "PigSaleType", "Other", "InitialUpload", 9, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "EquipmentType", "Other", "InitialUpload", 9, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedAmountPurchasedUnitType", "Other", "InitialUpload", 5, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedPurchasedType", "Other", "InitialUpload", 5, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthCareType", "Other", "InitialUpload", 11, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthServivceProivderType", "Other", "InitialUpload", 11, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthMedicineType", "Other", "InitialUpload", 11, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthPurchaseFromType", "Other", "InitialUpload", 11, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "LabourType", "Other", "InitialUpload", 7, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType13", "InitialUpload", 13, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HousingType", "Other", "InitialUpload", 6, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "PurchasedWaterFrom", "Other", "InitialUpload", 11, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "MembershipType", "Other", "InitialUpload", 9, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "ServiceUnit", "Other", "InitialUpload", 9, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "WhoProvidedServiceUnit", "Other", "InitialUpload", 9, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "AnimalType", "Other", "InitialUpload", 9, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "AnimalPurchasedFrom", "Other", "InitialUpload", 9, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "LoanProvider", "Other", "InitialUpload", 9, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "WaterPurchasedUnit", "Other", "InitialUpload", 6, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "TimePeriodUnitType", "TimePeriodUnitType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType14", "InitialUpload", 14, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType16", "InitialUpload", 16, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthMedicineType", "MedicineType4", "InitialUpload", 4, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthPurchaseFromType", "PruchaseFromType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthPurchaseFromType", "PruchaseFromType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthPurchaseFromType", "PruchaseFromType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "LabourType", "LabourType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "LabourType", "LabourType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HousingType", "HousingExpenseType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HousingType", "HousingExpenseType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HousingType", "HousingExpenseType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "WaterPurchasedUnit", "WaterPurchasedUnitType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "WaterPurchasedUnit", "WaterPurchasedUnitType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "PurchasedWaterFrom", "PurchasedWaterFromType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "PurchasedWaterFrom", "PurchasedWaterFromType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "PurchasedWaterFrom", "PurchasedWaterFromType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "MembershipType", "MembershipType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthMedicineType", "MedicineType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthMedicineType", "MedicineType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthMedicineType", "MedicineType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthServivceProivderType", "HealthProviderType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType17", "InitialUpload", 17, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType18", "InitialUpload", 18, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType19", "InitialUpload", 19, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedAmountPurchasedUnitType", "DropDownUnitType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedAmountPurchasedUnitType", "DropDownUnitType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedPurchasedType", "DropDownPurchaseFrom1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedPurchasedType", "DropDownPurchaseFrom2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedType", "DropDownFeedType15", "InitialUpload", 15, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedPurchasedType", "DropDownPurchaseFrom3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthCareType", "HeathCareType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthCareType", "HeathCareType2", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthCareType", "HeathCareType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthCareType", "HeathCareType4", "InitialUpload", 4, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthCareType", "HeathCareType5", "InitialUpload", 5, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthCareType", "HeathCareType6", "InitialUpload", 6, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthServivceProivderType", "HealthProviderType1", "InitialUpload", 1, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedPurchasedType", "DropDownPurchaseFrom4", "InitialUpload", 4, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "LanguageType", "LanguageType6", "InitialUpload", 6, false, false, "ControlData", null });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalHouseItems_HousingExpense",
                table: "AnimalHouseItems",
                column: "HousingExpense");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalPurchaseItems_DisplayTypeTranslationRowKey",
                table: "AnimalPurchaseItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.CreateIndex(
                name: "IX_BreedingServiceSaleItems_DisplayTypeTranslationRowKey",
                table: "BreedingServiceSaleItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentItems_DisplayTypeTranslationRowKey",
                table: "EquipmentItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.CreateIndex(
                name: "IX_FeedItems_FeedType",
                table: "FeedItems",
                column: "FeedType");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCareItems_DisplayTypeTranslationRowKey",
                table: "HealthCareItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.CreateIndex(
                name: "IX_LabourCostItems_DisplayTypeTranslationRowKey",
                table: "LabourCostItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.CreateIndex(
                name: "IX_LoanRepaymentItems_DisplayTypeTranslationRowKey",
                table: "LoanRepaymentItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.CreateIndex(
                name: "IX_ManureSaleItems_DisplayTypeTranslationRowKey",
                table: "ManureSaleItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.CreateIndex(
                name: "IX_MembershipItems_DisplayTypeTranslationRowKey",
                table: "MembershipItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.CreateIndex(
                name: "IX_PigSaleItems_DisplayTypeTranslationRowKey",
                table: "PigSaleItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.CreateIndex(
                name: "IX_ReproductiveItems_DisplayTypeTranslationRowKey",
                table: "ReproductiveItems",
                column: "DisplayTypeTranslationRowKey");
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
