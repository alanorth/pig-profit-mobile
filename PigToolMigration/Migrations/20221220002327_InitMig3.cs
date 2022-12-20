using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class InitMig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanRepaymentItems_Translations_DisplayTypeTranslationRowKey",
                table: "LoanRepaymentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ManureSaleItems_Translations_DisplayTypeTranslationRowKey",
                table: "ManureSaleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_MembershipItems_Translations_DisplayTypeTranslationRowKey",
                table: "MembershipItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PigSaleItems_Translations_DisplayTypeTranslationRowKey",
                table: "PigSaleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ReproductiveItems_Translations_DisplayTypeTranslationRowKey",
                table: "ReproductiveItems");

            migrationBuilder.DropIndex(
                name: "IX_ReproductiveItems_DisplayTypeTranslationRowKey",
                table: "ReproductiveItems");

            migrationBuilder.DropIndex(
                name: "IX_PigSaleItems_DisplayTypeTranslationRowKey",
                table: "PigSaleItems");

            migrationBuilder.DropIndex(
                name: "IX_MembershipItems_DisplayTypeTranslationRowKey",
                table: "MembershipItems");

            migrationBuilder.DropIndex(
                name: "IX_ManureSaleItems_DisplayTypeTranslationRowKey",
                table: "ManureSaleItems");

            migrationBuilder.DropIndex(
                name: "IX_LoanRepaymentItems_DisplayTypeTranslationRowKey",
                table: "LoanRepaymentItems");

            migrationBuilder.DropColumn(
                name: "DisplayTypeTranslationRowKey",
                table: "ReproductiveItems");

            migrationBuilder.DropColumn(
                name: "DisplayTypeTranslationRowKey",
                table: "PigSaleItems");

            migrationBuilder.DropColumn(
                name: "DisplayTypeTranslationRowKey",
                table: "MembershipItems");

            migrationBuilder.DropColumn(
                name: "DisplayTypeTranslationRowKey",
                table: "ManureSaleItems");

            migrationBuilder.DropColumn(
                name: "DisplayTypeTranslationRowKey",
                table: "LoanRepaymentItems");

            migrationBuilder.CreateIndex(
                name: "IX_ReproductiveItems_ServiceType",
                table: "ReproductiveItems",
                column: "ServiceType");

            migrationBuilder.CreateIndex(
                name: "IX_PigSaleItems_PigType",
                table: "PigSaleItems",
                column: "PigType");

            migrationBuilder.CreateIndex(
                name: "IX_MembershipItems_MembershipType",
                table: "MembershipItems",
                column: "MembershipType");

            migrationBuilder.CreateIndex(
                name: "IX_ManureSaleItems_SoldTo",
                table: "ManureSaleItems",
                column: "SoldTo");

            migrationBuilder.CreateIndex(
                name: "IX_LoanRepaymentItems_LoanProvider",
                table: "LoanRepaymentItems",
                column: "LoanProvider");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanRepaymentItems_Translations_LoanProvider",
                table: "LoanRepaymentItems",
                column: "LoanProvider",
                principalTable: "Translations",
                principalColumn: "RowKey");

            migrationBuilder.AddForeignKey(
                name: "FK_ManureSaleItems_Translations_SoldTo",
                table: "ManureSaleItems",
                column: "SoldTo",
                principalTable: "Translations",
                principalColumn: "RowKey");

            migrationBuilder.AddForeignKey(
                name: "FK_MembershipItems_Translations_MembershipType",
                table: "MembershipItems",
                column: "MembershipType",
                principalTable: "Translations",
                principalColumn: "RowKey");

            migrationBuilder.AddForeignKey(
                name: "FK_PigSaleItems_Translations_PigType",
                table: "PigSaleItems",
                column: "PigType",
                principalTable: "Translations",
                principalColumn: "RowKey");

            migrationBuilder.AddForeignKey(
                name: "FK_ReproductiveItems_Translations_ServiceType",
                table: "ReproductiveItems",
                column: "ServiceType",
                principalTable: "Translations",
                principalColumn: "RowKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanRepaymentItems_Translations_LoanProvider",
                table: "LoanRepaymentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ManureSaleItems_Translations_SoldTo",
                table: "ManureSaleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_MembershipItems_Translations_MembershipType",
                table: "MembershipItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PigSaleItems_Translations_PigType",
                table: "PigSaleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ReproductiveItems_Translations_ServiceType",
                table: "ReproductiveItems");

            migrationBuilder.DropIndex(
                name: "IX_ReproductiveItems_ServiceType",
                table: "ReproductiveItems");

            migrationBuilder.DropIndex(
                name: "IX_PigSaleItems_PigType",
                table: "PigSaleItems");

            migrationBuilder.DropIndex(
                name: "IX_MembershipItems_MembershipType",
                table: "MembershipItems");

            migrationBuilder.DropIndex(
                name: "IX_ManureSaleItems_SoldTo",
                table: "ManureSaleItems");

            migrationBuilder.DropIndex(
                name: "IX_LoanRepaymentItems_LoanProvider",
                table: "LoanRepaymentItems");

            migrationBuilder.AddColumn<string>(
                name: "DisplayTypeTranslationRowKey",
                table: "ReproductiveItems",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisplayTypeTranslationRowKey",
                table: "PigSaleItems",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisplayTypeTranslationRowKey",
                table: "MembershipItems",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisplayTypeTranslationRowKey",
                table: "ManureSaleItems",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisplayTypeTranslationRowKey",
                table: "LoanRepaymentItems",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReproductiveItems_DisplayTypeTranslationRowKey",
                table: "ReproductiveItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.CreateIndex(
                name: "IX_PigSaleItems_DisplayTypeTranslationRowKey",
                table: "PigSaleItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.CreateIndex(
                name: "IX_MembershipItems_DisplayTypeTranslationRowKey",
                table: "MembershipItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.CreateIndex(
                name: "IX_ManureSaleItems_DisplayTypeTranslationRowKey",
                table: "ManureSaleItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.CreateIndex(
                name: "IX_LoanRepaymentItems_DisplayTypeTranslationRowKey",
                table: "LoanRepaymentItems",
                column: "DisplayTypeTranslationRowKey");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanRepaymentItems_Translations_DisplayTypeTranslationRowKey",
                table: "LoanRepaymentItems",
                column: "DisplayTypeTranslationRowKey",
                principalTable: "Translations",
                principalColumn: "RowKey",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ManureSaleItems_Translations_DisplayTypeTranslationRowKey",
                table: "ManureSaleItems",
                column: "DisplayTypeTranslationRowKey",
                principalTable: "Translations",
                principalColumn: "RowKey",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MembershipItems_Translations_DisplayTypeTranslationRowKey",
                table: "MembershipItems",
                column: "DisplayTypeTranslationRowKey",
                principalTable: "Translations",
                principalColumn: "RowKey",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PigSaleItems_Translations_DisplayTypeTranslationRowKey",
                table: "PigSaleItems",
                column: "DisplayTypeTranslationRowKey",
                principalTable: "Translations",
                principalColumn: "RowKey",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReproductiveItems_Translations_DisplayTypeTranslationRowKey",
                table: "ReproductiveItems",
                column: "DisplayTypeTranslationRowKey",
                principalTable: "Translations",
                principalColumn: "RowKey",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
