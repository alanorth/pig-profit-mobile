using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class _40523a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartTile",
                column: "English",
                value: "Total Period Profit / Loss");

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SummaryChartProfitLoss", "Total Profit/Loss", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SummaryIncomeTranslation", "Income", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SummaryCostTranslation", "Cost", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SummaryProfitLossTranslation", "Profit/Loss", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BreakdownLabel", "Cost Breakdown", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "IncomeBreakdownLabel", "Income Breakdown", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SummaryLabel", "Summary", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreakdownLabel");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "IncomeBreakdownLabel");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartProfitLoss");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryCostTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryIncomeTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryLabel");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryProfitLossTranslation");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartTile",
                column: "English",
                value: "Total period profit / loss");
        }
    }
}
