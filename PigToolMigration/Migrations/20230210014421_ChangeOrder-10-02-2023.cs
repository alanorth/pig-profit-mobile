using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class ChangeOrder10022023 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SowsServicedTranslation");

            migrationBuilder.RenameColumn(
                name: "SowsServiced",
                table: "ReproductiveItems",
                newName: "SowsServicedCost");

            migrationBuilder.AddColumn<double>(
                name: "TransportCost",
                table: "ReproductiveItems",
                type: "REAL",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PaymentValue",
                table: "ManureSaleItems",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AddColumn<double>(
                name: "TransportCosts",
                table: "LoanRepaymentItems",
                type: "REAL",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PaymentValue",
                table: "BreedingServiceSaleItems",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPaidTranslation",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Amount paid over the labour use duration", "Amount paid over the labour use duration Lang1", "Amount paid over the labour use duration Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalType2",
                column: "English",
                value: "Gilt/Sow for breeding");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareCostTranslation",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Service Provider Cost", "Service Provider Cost Lang1", "Service Provider Cost Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType1",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Curative (treatment of a disease)", "Curative (treatment of a disease) Lang1", "Curative (treatment of a disease) Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType2",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Preventative (such as vaccinations)", "Preventative (such as vaccinations) Lang1", "Preventative (such as vaccinations) Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType3",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Administration of vitamins", "Administration of vitamins Lang1", "Administration of vitamins Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType4",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Deworming", "Deworming Lang1", "Deworming Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType5",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Use of disinfectants", "Use of disinfectants Lang1", "Use of disinfectants Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType6",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Herd visit/monitoring", "Herd visit/monitoring Lang1", "Herd visit/monitoring Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WatherDurationTranslation", "Water Use Duration", "Water Use Duration Lang1", "Water Use Duration Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SowsServicedCostTranslation", "Total Service Cost", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TotalAnimalCosts", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthProviderType3", "Self", "Self Lang1", "Self Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthProviderType4", "Neighbour, friend, or relative", "Neighbour, friend, or relative Lang1", "Neighbour, friend, or relative Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "VolumeUnitType2", "Bag", "Bag Lang1", "Bag Lang2" });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthServivceProivderType", "HealthProviderType3", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "HealthServivceProivderType", "HealthProviderType4", "InitialUpload", 2, false, false, "ControlData", null });

            migrationBuilder.InsertData(
                table: "ControlDataOptions",
                columns: new[] { "DropDownControlOption", "TranslationRowKey", "CreatedBy", "DisplayOrder", "IsDeleted", "IsEnable", "PartitionKey", "Timestamp" },
                values: new object[] { "VolumeUnitType", "VolumeUnitType2", "InitialUpload", 1, false, false, "ControlData", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ControlDataOptions",
                keyColumns: new[] { "DropDownControlOption", "TranslationRowKey" },
                keyValues: new object[] { "HealthServivceProivderType", "HealthProviderType3" });

            migrationBuilder.DeleteData(
                table: "ControlDataOptions",
                keyColumns: new[] { "DropDownControlOption", "TranslationRowKey" },
                keyValues: new object[] { "HealthServivceProivderType", "HealthProviderType4" });

            migrationBuilder.DeleteData(
                table: "ControlDataOptions",
                keyColumns: new[] { "DropDownControlOption", "TranslationRowKey" },
                keyValues: new object[] { "VolumeUnitType", "VolumeUnitType2" });

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SowsServicedCostTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAnimalCosts");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WatherDurationTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType3");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType4");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VolumeUnitType2");

            migrationBuilder.DropColumn(
                name: "TransportCost",
                table: "ReproductiveItems");

            migrationBuilder.DropColumn(
                name: "TransportCosts",
                table: "LoanRepaymentItems");

            migrationBuilder.RenameColumn(
                name: "SowsServicedCost",
                table: "ReproductiveItems",
                newName: "SowsServiced");

            migrationBuilder.AlterColumn<double>(
                name: "PaymentValue",
                table: "ManureSaleItems",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PaymentValue",
                table: "BreedingServiceSaleItems",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPaidTranslation",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Amount Paid", "Amount Paid Lang1", "Amount Paid Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalType2",
                column: "English",
                value: "Gilt / sow for breeding");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareCostTranslation",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Care Cost", "Care Cost", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType1",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "(1)  Curative (treatment of a disease)", "(1)       Curative (treatment of a disease) Lang1", "(1)       Curative (treatment of a disease) Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType2",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "(2)  Preventative (vaccination,", "(2)       Preventative (vaccination, Lang1", "(2)       Preventative (vaccination, Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType3",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "(3)  Administration of vitamins", "(3)       Administration of vitamins Lang1", "(3)       Administration of vitamins Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType4",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "(4)  Deworming", "(4)  Deworming Lang1", "(4)  Deworming Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType5",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "(5)  Use of disinfectants", "(5)       Use of disinfectants Lang1", "(5)       Use of disinfectants Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType6",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "(6)  Herd visit/monitoring", "(6)       Herd visit/monitoring Lang1", "(6)       Herd visit/monitoring Lang2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SowsServicedTranslation", "Sows Serviced", "", "" });
        }
    }
}
