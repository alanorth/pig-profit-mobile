using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class _270423a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ControlDataOptions",
                keyColumns: new[] { "DropDownControlOption", "TranslationRowKey" },
                keyValues: new object[] { "SoldToType", "SoldToType3" });

            migrationBuilder.AlterColumn<double>(
                name: "SowsServicedCost",
                table: "ReproductiveItems",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "OtherUnitType",
                table: "ManureSaleItems",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DurationFinish",
                table: "LoanRepaymentItems",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DurationStart",
                table: "LoanRepaymentItems",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceSaleTitleTranslation",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Sale of breeding services", "Sente ezivvudde mukuwakisa Ebisolo" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAmountPurchasedUnitTranslation",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Other unit", "Ekipimo ekilala" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAnimalTypeTranslation",
                column: "English",
                value: "Other Animal type");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType1",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Other farmer", "Mulunzi wambizi" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType2",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Trader", "Omusubuzi" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType3",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Slaughter-house", "Lufula" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "YearTranslation", "Year", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MonthTranslation", "Month", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SummaryTableHeading", "Profit/loss by month", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SummaryChartIncomeGroup", "Total Income", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SummaryChartTile", "Total period profit / loss", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LossTranslation", "Loss", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ProfitTranslation", "Profit", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ReportingDuration", "Reporting Duration", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LastUploadTranslation", "Last upload of data", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherUnitTypeTranslation", "Other Unit Type", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SummaryChartCostGroup", "Total Cost", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanDurationTranslation", "Loan duration", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LastUploadTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanDurationTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LossTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MonthTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherUnitTypeTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ProfitTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReportingDuration");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartCostGroup");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartIncomeGroup");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartTile");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryTableHeading");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "YearTranslation");

            migrationBuilder.DropColumn(
                name: "OtherUnitType",
                table: "ManureSaleItems");

            migrationBuilder.DropColumn(
                name: "DurationFinish",
                table: "LoanRepaymentItems");

            migrationBuilder.DropColumn(
                name: "DurationStart",
                table: "LoanRepaymentItems");

            migrationBuilder.AlterColumn<int>(
                name: "SowsServicedCost",
                table: "ReproductiveItems",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "SoldToType", "SoldToType3", "InitialUpload", 3, false, false, "ControlData", null });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceSaleTitleTranslation",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Sale of Reproductive Services", "Entunda y'obuwereza obukwetagana ne' okuwakisa no' kuzala" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAmountPurchasedUnitTranslation",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Other Amount Purchased", "Obunji obulala bwe wagula" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAnimalTypeTranslation",
                column: "English",
                value: "Animal type");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType1",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Trader", "Omusubuzi" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType2",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Slaughter-house", "Lufula" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType3",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Pig farmer", "Mulunzi wambizi" });
        }
    }
}
