using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class ChangeOrder140223a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimePeriod",
                table: "MembershipItems");

            migrationBuilder.DropColumn(
                name: "TimePeriodUnit",
                table: "MembershipItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TimePeriod",
                table: "MembershipItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TimePeriodUnit",
                table: "MembershipItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
