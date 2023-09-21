using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class _22923updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AcceptTranslation",
                column: "Lang1",
                value: "Kirizza");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CostTranslation",
                columns: new[] { "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Any Other Cost", "Esaasaanya endala", "Các chi phí khác", "Ibindi byishuwe" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareTitleTranslation",
                column: "Lang1",
                value: "Ebyobulamu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourTitleTranslation",
                column: "Lang1",
                value: "Abakozi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Esaasaanya endala", "Các chi phí khác", "Ibindi byishuwe" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncome",
                columns: new[] { "Lang1", "Lang3" },
                values: new object[] { "Enyingiza endala", "Andi mafaranga yinjiye" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncomeTitleTranslation",
                columns: new[] { "Lang1", "Lang3" },
                values: new object[] { "Enyingiza endala", "Andi mafaranga yinjiye" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartProfitLoss",
                columns: new[] { "English", "Lang2", "Lang3" },
                values: new object[] { "Total Profit / Loss", "Tổng Lãi / Lỗ", "Inyugu yose / Igihombo cyose hamwe" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryTableHeading",
                columns: new[] { "English", "Lang2", "Lang3" },
                values: new object[] { "Profit / Loss by month", "Lãi / Lỗ theo tháng", "Inyungu / Igihombo ku kwezi" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "VersionTranslation", "Version", "Ekika", "Toleo", "Phiên bản" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VersionTranslation");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AcceptTranslation",
                column: "Lang1",
                value: "Kirizza ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CostTranslation",
                columns: new[] { "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Any other cost:", "Ensasanya endala", "Chi phí khác", "Ikindi kiguzi cyishuwe" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareTitleTranslation",
                column: "Lang1",
                value: "Obujanjabi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourTitleTranslation",
                column: "Lang1",
                value: "Abaakozi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Ensasaanya endala", "Chi phí khác", "Ikindi kiguzi cyishuwe" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncome",
                columns: new[] { "Lang1", "Lang3" },
                values: new object[] { "Enyigiza yasente endala", "Andi mafaranga yinjira" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncomeTitleTranslation",
                columns: new[] { "Lang1", "Lang3" },
                values: new object[] { "Sente endala zoyingizza", "Andi mafaranga yinjira" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartProfitLoss",
                columns: new[] { "English", "Lang2", "Lang3" },
                values: new object[] { "Total Profit/Loss", "Tổng Lãi/Lỗ", "Inyugu yose/Igihombo cyose hamwe" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryTableHeading",
                columns: new[] { "English", "Lang2", "Lang3" },
                values: new object[] { "Profit/loss by month", "Lãi/lỗ theo tháng", "Inyungu/igihombo ku kwezi" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "", "", "" });
        }
    }
}
