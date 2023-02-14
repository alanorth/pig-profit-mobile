using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class ChangeOrder140223 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAnimalCosts");

            migrationBuilder.AddColumn<DateTime>(
                name: "DurationFinish",
                table: "MembershipItems",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DurationStart",
                table: "MembershipItems",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "OtherCosts",
                table: "FeedItems",
                type: "REAL",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAnimalPurchasedTranslation",
                column: "English",
                value: "Other Purchased from");

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TotalAnimalCostsTranslation", "Total cost for all animals", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MembershipDurationTranslation", "Membership duration", "Duration Lang1", "Duration Lang2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipDurationTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAnimalCostsTranslation");

            migrationBuilder.DropColumn(
                name: "DurationFinish",
                table: "MembershipItems");

            migrationBuilder.DropColumn(
                name: "DurationStart",
                table: "MembershipItems");

            migrationBuilder.DropColumn(
                name: "OtherCosts",
                table: "FeedItems");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAnimalPurchasedTranslation",
                column: "English",
                value: "Purchased from");

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TotalAnimalCosts", "", "", "" });
        }
    }
}
