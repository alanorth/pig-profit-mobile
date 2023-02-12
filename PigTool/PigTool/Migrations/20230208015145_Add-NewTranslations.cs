using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class AddNewTranslations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ControlDataOptions",
                keyColumns: new[] { "DropDownControlOption", "TranslationRowKey" },
                keyValues: new object[] { "FeedAmountPurchasedUnitType", "DropDownUnitType2" },
                column: "DisplayOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedItemTitleTranslation",
                column: "English",
                value: "Feed");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareTitleTranslation",
                column: "English",
                value: "Healthcare");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingTitleTranslation",
                column: "English",
                value: "Housing");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourTitleTranslation",
                column: "English",
                value: "Labour");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostTitleTranslation",
                column: "English",
                value: "Other");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPurchasedFromTranslation",
                column: "English",
                value: "Other Purchased From");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType3",
                column: "English",
                value: "Gilt/Sow for breeding");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterCostTitleTranslation",
                column: "English",
                value: "Water");

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DropDownUnitType3", "gram", "Kg Lang1", "Kg Lang2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "FeedAmountPurchasedUnitType", "DropDownUnitType3", "InitialUpload", 2, false, false, "ControlData", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ControlDataOptions",
                keyColumns: new[] { "DropDownControlOption", "TranslationRowKey" },
                keyValues: new object[] { "FeedAmountPurchasedUnitType", "DropDownUnitType3" });

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownUnitType3");

            migrationBuilder.UpdateData(
                table: "ControlDataOptions",
                keyColumns: new[] { "DropDownControlOption", "TranslationRowKey" },
                keyValues: new object[] { "FeedAmountPurchasedUnitType", "DropDownUnitType2" },
                column: "DisplayOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedItemTitleTranslation",
                column: "English",
                value: "Feed Cost");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareTitleTranslation",
                column: "English",
                value: "Health Care");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingTitleTranslation",
                column: "English",
                value: "Animal Housing");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourTitleTranslation",
                column: "English",
                value: "Labour Cost");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostTitleTranslation",
                column: "English",
                value: "Other Cost");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPurchasedFromTranslation",
                column: "English",
                value: "Purchased From");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType3",
                column: "English",
                value: "Gilt/sow sow for breeding");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterCostTitleTranslation",
                column: "English",
                value: "Water Cost");
        }
    }
}
