using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class InitMig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BreedingServiceSaleItems_Translations_DisplayTypeTranslationRowKey",
                table: "BreedingServiceSaleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentItems_Translations_DisplayTypeTranslationRowKey",
                table: "EquipmentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthCareItems_Translations_DisplayTypeTranslationRowKey",
                table: "HealthCareItems");

            migrationBuilder.DropForeignKey(
                name: "FK_LabourCostItems_Translations_DisplayTypeTranslationRowKey",
                table: "LabourCostItems");

            migrationBuilder.DropIndex(
                name: "IX_LabourCostItems_DisplayTypeTranslationRowKey",
                table: "LabourCostItems");

            migrationBuilder.DropIndex(
                name: "IX_HealthCareItems_DisplayTypeTranslationRowKey",
                table: "HealthCareItems");

            migrationBuilder.DropIndex(
                name: "IX_EquipmentItems_DisplayTypeTranslationRowKey",
                table: "EquipmentItems");

            migrationBuilder.DropIndex(
                name: "IX_BreedingServiceSaleItems_DisplayTypeTranslationRowKey",
                table: "BreedingServiceSaleItems");

            migrationBuilder.DropColumn(
                name: "DisplayTypeTranslationRowKey",
                table: "LabourCostItems");

            migrationBuilder.DropColumn(
                name: "DisplayTypeTranslationRowKey",
                table: "HealthCareItems");

            migrationBuilder.DropColumn(
                name: "DisplayTypeTranslationRowKey",
                table: "EquipmentItems");

            migrationBuilder.DropColumn(
                name: "DisplayTypeTranslationRowKey",
                table: "BreedingServiceSaleItems");

            migrationBuilder.CreateIndex(
                name: "IX_LabourCostItems_LabourType",
                table: "LabourCostItems",
                column: "LabourType");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCareItems_HealthCareType",
                table: "HealthCareItems",
                column: "HealthCareType");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentItems_EquipmentType",
                table: "EquipmentItems",
                column: "EquipmentType");

            migrationBuilder.CreateIndex(
                name: "IX_BreedingServiceSaleItems_ServiceType",
                table: "BreedingServiceSaleItems",
                column: "ServiceType");

            migrationBuilder.AddForeignKey(
                name: "FK_BreedingServiceSaleItems_Translations_ServiceType",
                table: "BreedingServiceSaleItems",
                column: "ServiceType",
                principalTable: "Translations",
                principalColumn: "RowKey");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentItems_Translations_EquipmentType",
                table: "EquipmentItems",
                column: "EquipmentType",
                principalTable: "Translations",
                principalColumn: "RowKey");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCareItems_Translations_HealthCareType",
                table: "HealthCareItems",
                column: "HealthCareType",
                principalTable: "Translations",
                principalColumn: "RowKey");

            migrationBuilder.AddForeignKey(
                name: "FK_LabourCostItems_Translations_LabourType",
                table: "LabourCostItems",
                column: "LabourType",
                principalTable: "Translations",
                principalColumn: "RowKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BreedingServiceSaleItems_Translations_ServiceType",
                table: "BreedingServiceSaleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentItems_Translations_EquipmentType",
                table: "EquipmentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthCareItems_Translations_HealthCareType",
                table: "HealthCareItems");

            migrationBuilder.DropForeignKey(
                name: "FK_LabourCostItems_Translations_LabourType",
                table: "LabourCostItems");

            migrationBuilder.DropIndex(
                name: "IX_LabourCostItems_LabourType",
                table: "LabourCostItems");

            migrationBuilder.DropIndex(
                name: "IX_HealthCareItems_HealthCareType",
                table: "HealthCareItems");

            migrationBuilder.DropIndex(
                name: "IX_EquipmentItems_EquipmentType",
                table: "EquipmentItems");

            migrationBuilder.DropIndex(
                name: "IX_BreedingServiceSaleItems_ServiceType",
                table: "BreedingServiceSaleItems");

            migrationBuilder.AddColumn<string>(
                name: "DisplayTypeTranslationRowKey",
                table: "LabourCostItems",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisplayTypeTranslationRowKey",
                table: "HealthCareItems",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisplayTypeTranslationRowKey",
                table: "EquipmentItems",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisplayTypeTranslationRowKey",
                table: "BreedingServiceSaleItems",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LabourCostItems_DisplayTypeTranslationRowKey",
                table: "LabourCostItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCareItems_DisplayTypeTranslationRowKey",
                table: "HealthCareItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentItems_DisplayTypeTranslationRowKey",
                table: "EquipmentItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.CreateIndex(
                name: "IX_BreedingServiceSaleItems_DisplayTypeTranslationRowKey",
                table: "BreedingServiceSaleItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.AddForeignKey(
                name: "FK_BreedingServiceSaleItems_Translations_DisplayTypeTranslationRowKey",
                table: "BreedingServiceSaleItems",
                column: "DisplayTypeTranslationRowKey",
                principalTable: "Translations",
                principalColumn: "RowKey",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentItems_Translations_DisplayTypeTranslationRowKey",
                table: "EquipmentItems",
                column: "DisplayTypeTranslationRowKey",
                principalTable: "Translations",
                principalColumn: "RowKey",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCareItems_Translations_DisplayTypeTranslationRowKey",
                table: "HealthCareItems",
                column: "DisplayTypeTranslationRowKey",
                principalTable: "Translations",
                principalColumn: "RowKey",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LabourCostItems_Translations_DisplayTypeTranslationRowKey",
                table: "LabourCostItems",
                column: "DisplayTypeTranslationRowKey",
                principalTable: "Translations",
                principalColumn: "RowKey",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
