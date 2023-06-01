using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class TranslationCleanUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Cancel",
                column: "Lang1",
                value: "Togenda mumaso kukyikola/Kijeemu");

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "NoTranslation", "No", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "YesTranslation", "Yes", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "AppRestartTranslation", "Changing the language requires the app to restart.Proceed?", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "SureTranslation", "Are you sure?", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "ChangeLanguageTrasnlation", "Change Language", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "LogoutWarningTransaltion", "By logging out any data not submitted to the cloud will be lost and current data on the device will be removed", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "ConfirmLogoutTranslation", "Confirm Logout", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "LogoutTranslation", "Logout", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "AcceptTranslation", "Accept", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "ChangeProfileTranslation", " Change Profile Info", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "ViewTranslation", "View", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "UploadTile", "Upload", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "SettingsTile", "Settings", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "ReportsTile", "Reports", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "ManageDataTile", "Manage", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "AddDataTile", "Add Data", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "HomeTile", "Home", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "BenchmarkingTabLable", "Benchmark", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "SettingsPageTranslation", " Settings", "", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "AdvanceTabLable", "Advance", "", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AcceptTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AddDataTile");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AdvanceTabLable");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AppRestartTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BenchmarkingTabLable");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ChangeLanguageTrasnlation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ChangeProfileTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ConfirmLogoutTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HomeTile");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LogoutTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LogoutWarningTransaltion");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManageDataTile");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReportsTile");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SettingsPageTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SettingsTile");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SureTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "UploadTile");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ViewTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "YesTranslation");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Cancel",
                column: "Lang1",
                value: "Togenda mumaso kukyikola/Tokyikola/SikkituFfu/Kijeeko/Kijeewo/Kijeemu");
        }
    }
}
