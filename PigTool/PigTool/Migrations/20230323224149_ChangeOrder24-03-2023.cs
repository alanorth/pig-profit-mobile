using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class ChangeOrder24032023 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ControlDataOptions",
                keyColumns: new[] { "DropDownControlOption", "TranslationRowKey" },
                keyValues: new object[] { "BreedingServiceType", "BreedingServiceType2" });

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceType2");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "Brokerage",
                table: "PigSaleItems");

            migrationBuilder.DropColumn(
                name: "PaymentType",
                table: "ManureSaleItems");

            migrationBuilder.DropColumn(
                name: "PaymentValue",
                table: "ManureSaleItems");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPaidTranslation",
                column: "English",
                value: "Amount paid for piggery labour over the duration");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SalePriceTranslation",
                column: "English",
                value: "Sale price for all animals sold");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAnimalCostsTranslation",
                column: "English",
                value: "Total cost for all animals");

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Created", "Created", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TotalCostAllUnits", "Total Cost (all units)", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MedicineType5", "Disinfectant", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ManureAmountRecievedTranslation", "Sale price for all manure sold", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MembershipUpdated", "Membership Updated", "", "" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthMedicineType", "MedicineType5", "InitialUpload", 5, false, false, "ControlData", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ControlDataOptions",
                keyColumns: new[] { "DropDownControlOption", "TranslationRowKey" },
                keyValues: new object[] { "HealthMedicineType", "MedicineType5" });

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Created");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureAmountRecievedTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipUpdated");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalCostAllUnits");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType5");

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "UserInfos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Brokerage",
                table: "PigSaleItems",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "PaymentType",
                table: "ManureSaleItems",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PaymentValue",
                table: "ManureSaleItems",
                type: "REAL",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPaidTranslation",
                column: "English",
                value: "Amount paid over the labour use duration");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SalePriceTranslation",
                column: "English",
                value: "Sale Price");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAnimalCostsTranslation",
                column: "English",
                value: "TotalAnimalCostsTranslation");

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BreedingServiceType2", "Semen sale (? to include)", "Okutunda amazzi agokuwakisa", "" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "BreedingServiceType", "BreedingServiceType2", "InitialUpload", 2, false, false, "ControlData", null });
        }
    }
}
