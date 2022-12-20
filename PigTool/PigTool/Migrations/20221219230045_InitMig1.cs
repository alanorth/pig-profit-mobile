using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class InitMig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalPurchaseItems_Translations_DisplayTypeTranslationRowKey",
                table: "AnimalPurchaseItems");

            migrationBuilder.DropIndex(
                name: "IX_AnimalPurchaseItems_DisplayTypeTranslationRowKey",
                table: "AnimalPurchaseItems");

            migrationBuilder.DropColumn(
                name: "DisplayTypeTranslationRowKey",
                table: "AnimalPurchaseItems");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalPurchaseItems_AnimalType",
                table: "AnimalPurchaseItems",
                column: "AnimalType");

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalPurchaseItems_Translations_AnimalType",
                table: "AnimalPurchaseItems",
                column: "AnimalType",
                principalTable: "Translations",
                principalColumn: "RowKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalPurchaseItems_Translations_AnimalType",
                table: "AnimalPurchaseItems");

            migrationBuilder.DropIndex(
                name: "IX_AnimalPurchaseItems_AnimalType",
                table: "AnimalPurchaseItems");

            migrationBuilder.AddColumn<string>(
                name: "DisplayTypeTranslationRowKey",
                table: "AnimalPurchaseItems",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AnimalPurchaseItems_DisplayTypeTranslationRowKey",
                table: "AnimalPurchaseItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalPurchaseItems_Translations_DisplayTypeTranslationRowKey",
                table: "AnimalPurchaseItems",
                column: "DisplayTypeTranslationRowKey",
                principalTable: "Translations",
                principalColumn: "RowKey",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
