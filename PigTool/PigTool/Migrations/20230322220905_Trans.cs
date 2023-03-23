using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class Trans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountyType1");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountyType2");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountyType3");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountyType4");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountyType5");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountyType6");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountyType7");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountyType8");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DistrictType1");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DistrictType2");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DistrictType3");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DistrictType4");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DistrictType5");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DistrictType6");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DistrictType7");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DistrictType8");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AddData",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Yongerako Obubaka obulala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AddFeedItemTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Jjuzamu sente ze wabigula", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPaidTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Sente zosasula abakozi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPurchasedTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Obunji bwe wagula", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPurchasedTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Obunji bwewagula ", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPurchasedUnitTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Obunji bwewagula ", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountRecievedTranslation",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Amount received for all services", "Sente zonna awamu e zobuwereza byoona" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchase",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Okugula Ebisolo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromTranslation",
                column: "Lang1",
                value: "JJewabigula");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType1",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Market", "Obutale ", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Omusubuuzi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Omulunzi wembizi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType4",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ekitongole ekiwakisa embizi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchaseTitleTranslation",
                column: "Lang1",
                value: "Okugula Ebisolo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Embizi endaawe/ezirindwa ngazakusala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebizzi endusi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Enume  ento nga yakulinyira enkazi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalTypeTranslation",
                column: "Lang1",
                value: "Ebika bye'bisolo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnyOtherPaymentTranslation",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Any Other Payment Received", "Sente endala zebakusasula" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceSale",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Sente ezivvudde mukuwakisa Ebisolo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceSaleTitleTranslation",
                column: "Lang1",
                value: "Entunda y'obuwereza obukwetagana ne' okuwakisa no' kuzala");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Obuwereza obwekusa ku nume ewakisa", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Okutunda amazzi agokuwakisa", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BrokerageTranslation",
                column: "Lang1",
                value: "Kayungirizi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CellTranslation",
                column: "Lang1",
                value: "Ekyaalo kyo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ClientTranslation",
                column: "Lang1",
                value: "Omuguzzi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ClientType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Omolunzi wembizi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CommentTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Oyina kyogamba ", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CommentTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Bakokyogamba", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CommuneTranslation",
                column: "Lang1",
                value: "Ekika kya'bantu gyobeera");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Costs",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ensasaanya", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CostTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Sente zewasasula", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CostTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ensasanya endala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTranslation",
                column: "Lang1",
                value: "Ensi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTypeRwanda",
                column: "Lang1",
                value: "Rwanda");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTypeUganda",
                column: "Lang1",
                value: "Uganda");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTypeVietnam",
                column: "Lang1",
                value: "Ventinamu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountyTranslation",
                column: "Lang1",
                value: "Essaza");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CurrencyTranslation",
                column: "Lang1",
                value: "Ekika kye'sente");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DateLastUploaded",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "obuka bbwewasembayo okutekakko", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DateObtainedTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Enakuzomwezi  lwewabifuna", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DateTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Enakuzomwezi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DeleteTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ssangula", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DistrictTranslation",
                column: "Lang1",
                value: "Disitulikiti yo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Kyakyu wa kasoli", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType10",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Soyaa ensekule ", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType11",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Kikamulo kya e'ntungo enene", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType12",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ekikamulo kya pamba", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType13",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ekikamulo kye e'binwyobwa", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType14",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Emere entabule, eliko obuwandike", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType15",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Emere entabule nga teliko buwandike", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType16",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ekilungo kyomunyu", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType17",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "vitamini", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType18",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebilungo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType19",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Sayirajji", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Kyakyu w'engano", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Obuweeke bya kasooli", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType4",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Kyakyu  w'omukyere", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType5",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ekimere kya kasooli", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType6",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ekimere kye' ngano", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType7",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebikanjja ebikalu", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType8",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Kasooli omukube", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType9",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Kikamulo kya soyaa", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Atunda emere ye bisolo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Omusawo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Omulimi omulala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom4",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Owe byentambula", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownUnitType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Kilo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownUnitType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Namba", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownUnitType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Obuzito", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EditData",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Byetegereze/Jamuensobi/ Bisangule wo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EditTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Jamu ensobi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EmailTranslation",
                column: "Lang1",
                value: "Elinya lyo kozesa ku emailo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Equipment",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Byetukozessa okkola Emirimu", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentTitleTranslation",
                column: "Lang1",
                value: "Ebikozesebwa");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebikozesebwa muku ziwa emere", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebifukirila amazzi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebikosesebwa mu kuyonja", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType4",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Obulamba ebisolo  kumatu", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentTypeTranslation",
                column: "Lang1",
                value: "Ebika bye ebikozesebwa");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Feed",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Emere  ye' bisolo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedDurationTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebanga emere lyemala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedItemTitleTranslation",
                column: "Lang1",
                value: "Emere ye'bisolo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedTypeTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebika bye mere ", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedTypeTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebika bye'mere yebisolo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FilterTranslation",
                column: "Lang1",
                value: "Byawule okusinziraku");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FinishTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Maliliza", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderTranslation",
                column: "Lang1",
                value: "Ekikula kyo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderType1",
                column: "Lang1",
                value: "Omusajja");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderType2",
                column: "Lang1",
                value: "Omukazi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderType3",
                column: "Lang1",
                value: "Ebilala");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GoogleSignUpTranslation",
                column: "Lang1",
                value: "Wewandisizze kumutimbagano");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Healthcare",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebyobulamu", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareCostTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Obuwereza obwo bwasente meka", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareTitleTranslation",
                column: "Lang1",
                value: "Obujanjabi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareTypeTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebika ebyo bujanjabi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Omusawo we bisolo atali wagavumenti", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Omusawo we bisolo wagavumenti", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Nze", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType4",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Mulilwana, mukwano gwo, owoluganda ", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Okujanjaba endwaade ", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Okuzeyiza endwaade katugeze nga okuzigema", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Okujiwa vitamini", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType4",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Okuta enjoka", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType5",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Okozesa edagala elita obuwuka obtalabika", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType6",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Okwekebejja ebisol", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Home",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Awatandikilwa", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Housing",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Enyumba", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ensasaanya kunyumba ye bisoolo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Okuzimba enyumba empya", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Okugaziya  enyumba ye bisolo eliwo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Okudabiliza", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingTitleTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Enyumba", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Income",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Enyingiza Ya sente", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Labour",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Abakozi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourDurationTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebanga abakoze lyebakola", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourTitleTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Abaakozi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Abakozi abenkalakalira", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Abakozi abatali  bankalakalira", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourTypeTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ekyika kyabakozi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageTranslation",
                column: "Lang1",
                value: "Olulimi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType1",
                column: "English",
                value: "English");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType2",
                column: "English",
                value: "Lugunda");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType3",
                column: "English",
                value: "Vietnamese");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType4",
                column: "English",
                value: "Kinyarwanda ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType5",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Language", "Olulimi lwoyogera" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType6",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Language", "Olulimi " });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerAgreeTranslation",
                column: "Lang1",
                value: "Okuteka akasitale wano, kitegeeza okiriziganya ne'obukwakulizzo obuli mu mboozi yaffe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerBodyTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerProceedTranslation",
                column: "Lang1",
                value: "Genda Mumaaso");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerTitleTranslation",
                column: "Lang1",
                value: "Tetuvunanyizibwa kwebyo ebiva mukozessa obubi omukutu guno");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderTranslation",
                column: "Lang1",
                value: "Ani akuwola sente");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Awola sente /Omuwozi wa sente", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Banka", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ekibina kyobwegasi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType4",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Self-help group or savings", "Ekibiina kyokukyaalo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType5",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Kibiina", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType6",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Abo luganda lwange / Mikwano gwange", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanRepayment",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Okusasula emabanja", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanRepaymentTitleTranslation",
                column: "Lang1",
                value: "Ensasula yasente zewewola");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoginButton",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Nyiga wano okutandika", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureSale",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Sente ezivvudde mukutunda Ebijimusa", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureSaleTitleTranslation",
                column: "Lang1",
                value: "Entunda ye' ebijimusa");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineCostTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ensasaanya kudagala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType1",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Drugs", "Amakerenda/edagala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Okugema ", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Edagala lye njoka", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType4",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Vitamini", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineTypeTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebika bye dagala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Membership",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ekibiinna kyobwegasi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipDurationTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipTitleTranslation",
                column: "Lang1",
                value: "Ekibiinna kyobwegasi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Sente ze kibiina ekyo bwegasi, ", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipTypeTranslation",
                column: "Lang1",
                value: "Ekika kyo bwamemba ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Name",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Erinya", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NameTranslation",
                column: "Lang1",
                value: "Elinya");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NumberPurchasedTranslation",
                column: "Lang1",
                value: "Wagula bunji ki");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NumberServicesTranslation",
                column: "Lang1",
                value: "Emirimu jjali emeka/ Obuwereza byali bya mirudi emeeka");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NumberSoldTranslation",
                column: "Lang1",
                value: "Watunda meka");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Other",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebilala, biwandikawano.", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAmountPurchasedUnitTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Obunji obulala bwe wagula", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAmountPurchaseTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Obunji bwe wagula obulala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAnimalPurchasedTranslation",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Purchased from", "JJewabigula" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAnimalTypeTranslation",
                column: "Lang1",
                value: "Ebika bye'bisolo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherClientTranslation",
                column: "Lang1",
                value: "Omuguzi abalala");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostEvent",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebilala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostsTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ensasanya endala yona", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostTitleTranslation",
                column: "Lang1",
                value: "Ebilala");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ensasaanya endala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherEquipmentTypeTranslation",
                column: "Lang1",
                value: "Ebikozesebwa ebilala");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherFeedTypeTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebika bye mere'bilala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherFeedTypeTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebika ebirala ebye'mere yebisolo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherHealthCareTypeTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Obujanjabi obulala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherHousingExpenseTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ensasaanya endala kunyumba ye bisolo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncome",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Enyigiza yasente endala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncomeTitleTranslation",
                column: "Lang1",
                value: "Sente endala zoyingizza");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherLaboutTypeTranslation",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Other Labour Type", "Ebika byabakozi ebirala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherLoanProviderTranslation",
                column: "Lang1",
                value: "Abawola sente abalala/ bewewola ko sente abalala");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherMedicineTypeTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebika byedagala ebilala ", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherMembershipTypeTranslation",
                column: "Lang1",
                value: "Ebika ebilala");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPigTypeTranslation",
                column: "Lang1",
                value: "Ebika bye mbizi ebilala");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherProviderTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Obuwerezza obulala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPurchasedFromTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Awalala jewagula", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPurchasedWaterFromTranslation",
                column: "Lang1",
                value: "Ngagula okuva");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherServiceTypeTranslation",
                column: "Lang1",
                value: "Ebika byobuwerezza ebilala");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherSoldToTranslation",
                column: "Lang1",
                value: "Bewaguzza abalala");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherWaterPurchasedTranslation",
                column: "Lang1",
                value: "Ekipimo ekilala");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherWhatForTranslation",
                column: "Lang1",
                value: "Byaaki");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherWhoProvidedServiceTranslation",
                column: "Lang1",
                value: "Ani akuwa obuwereza obwo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ParishTranslation",
                column: "Lang1",
                value: "Omuluka");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PaymentType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Obubizi obuto", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PaymentTypeTranslation",
                column: "Lang1",
                value: "Ekika");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PaymentValueTranslation",
                column: "Lang1",
                value: "Omuwendo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PhoneNumberTranslation",
                column: "Lang1",
                value: "Esiimu yo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerAnimalTypeTranslation",
                column: "Lang1",
                value: "Londako ekyika kye ebisolo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerClientTranslation",
                column: "Lang1",
                value: "Londa kasitoma wo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerCountryTranslation",
                column: "Lang1",
                value: "Londa ensi jova");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerCountyTranslation",
                column: "Lang1",
                value: "Londa Esaaza jova ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerCurrencyTranslation",
                column: "Lang1",
                value: "Londako ekyika kyasente");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerDistrictTranslation",
                column: "Lang1",
                value: "Londa Distulikiti jova ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerEquipmentTypeTranslation",
                column: "Lang1",
                value: "Londako ekyika kyebikozesebwa");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerFeedTypeTranslation",
                column: "Lang1",
                value: "Londako ekyika kyemere yebisolo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerGenderTranslation",
                column: "Lang1",
                value: "Londako ekikulakyo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerHealthCareTypeTranslation",
                column: "Lang1",
                value: "Londako ekyika  kyo kolabilila embiizi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerHousingExpenseTranslation",
                column: "Lang1",
                value: "Londako ensasaanya yo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerLabourTypeTranslation",
                column: "Lang1",
                value: "Londako ekyika kya bakozi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerMedicineTypeTranslation",
                column: "Lang1",
                value: "Londako ekyika kye dagala");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerMembershipTypeTranslation",
                column: "Lang1",
                value: "Londako obwa memba bwolina");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerPaymentTypeTranslation",
                column: "Lang1",
                value: "Londa  ensasula joyagala");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerPigTypeTranslation",
                column: "Lang1",
                value: "Londako ekyika kye mbizi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerProviderTranslation",
                column: "Lang1",
                value: "Londako  akuwa obuwerezza obwo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerPurchasedFromTranslation",
                column: "Lang1",
                value: "Londako akuwa  obuwerezza obwo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerServiceTypeTranslation",
                column: "Lang1",
                value: "Londako ekyika kyo obuwerezza");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerSoldToTranslation",
                column: "Lang1",
                value: "Londa omuguzi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerSubCountyTranslation",
                column: "Lang1",
                value: "Londa Egombolola jova");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerUnitTranslation",
                column: "Lang1",
                value: "Ekipimo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigSale",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Sente ezivvudde mukutunda Embizzi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigSaleTitleTranslation",
                column: "Lang1",
                value: "Okutunda embizi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Embizi endawo/Ezilundibwa ngazakusala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebisolo ebyokusala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebizi endusi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType4",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Young male/boar for breeding", "Enume yembizi ento/Enume eyo kuwakisa", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigTypeTranslation",
                column: "Lang1",
                value: "Ebika byembizi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ProviderTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ani akuwa obuwereza obwo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ProvinceTranslation",
                column: "Lang1",
                value: "Etundutundu jobela");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PruchaseFromType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Omusawo webisoliatali wagavumenti", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PruchaseFromType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Omusawo  webisolo owagovumenti", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PruchaseFromType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Eduuka lyedagala lyebisolo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedFrom",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Jjewabigula", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedFromTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "jjewabigula/wabigulawa", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromTranslation",
                column: "Lang1",
                value: "Ani, agagula/ Ngagula okuva");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Abatunda ebidomola by mazzi/abatembeyi ba amazzi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ekitongole kyamazzi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Mulirwana/ Mulilaanwa/Mukwano gwo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationSuccessfulContinueTranslation",
                column: "Lang1",
                value: "Genda Mumaaso");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationSuccessfulDescTranslation",
                column: "Lang1",
                value: "Oliwandembe okutandika oku kungaanya no kutereka ebiwandiko byo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationSuccessfulTitleTranslation",
                column: "Lang1",
                value: "Accounta yo eggudwawo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationTitleTranslation",
                column: "Lang1",
                value: "Okwewandisa");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationTranslation",
                column: "Lang1",
                value: "Okwewandisa");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Reproduction",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ebyo gwako no kuzaala", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReproductiveTitleTranslation",
                column: "Lang1",
                value: "Ebyekusa kugwako, ne'okuzzaala");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ResetTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ddamu bupya", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SalePriceTranslation",
                column: "Lang1",
                value: "Wabaguzza sente meka");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SaveTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Bitereke ", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SectorTranslation",
                column: "Lang1",
                value: "Ekitongole ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ServiceType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Okuwakisa ebisolo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ServiceType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Embiizi enume okuwakisa enkazi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ServiceTypeTranslation",
                column: "Lang1",
                value: "Ebika byobuwerezza");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SliderControlTranslation",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "If new housing built (rather than maintenance) lifespan in years + expected salvage value at end ?", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToTranslation",
                column: "Lang1",
                value: "Bewaguzza");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Omusubuzi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Lufula", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Mulunzi wambizi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SowsServicedCostTranslation",
                column: "Lang1",
                value: "Omuggate gwosasula kubuwereza ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "StartTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Tandika", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SubCountyTranslation",
                column: "Lang1",
                value: "Egombolola");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodTranslation",
                column: "Lang1",
                value: "Obudde bwebitutte");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodUnitType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Emyeezi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodUnitType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Emyaaka", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAmountRepaidTranslation",
                column: "Lang1",
                value: "Omugatte gwasente zo sasula");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAnimalCostsTranslation",
                column: "English",
                value: "TotalAnimalCostsTranslation");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalCostTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Gatta nsasaanya yona ", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalIncomeTranslation",
                column: "Lang1",
                value: "Omugatte gwasente zoyingizza ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TransportationCostTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ensasaanya kubye'ntambula", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TransportCostTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Entambula", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "UnitTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ekipimo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "UploadDataTranslation",
                column: "Lang1",
                value: "Sindika kumutimbagano");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "UserNameTranslation",
                column: "Lang1",
                value: "Elinya lyo kozesa kumutimbagano");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ViewReports",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Alipota/obubaka", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Village",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ekyaalo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VillageTranslation",
                column: "Lang1",
                value: "Ekyaalo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VolumeSoldTranslation",
                column: "Lang1",
                value: "Watunda bunji kyi/ Bunji ki byo' tunda");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VolumeUnitType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Kilo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VolumeUnitType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ensawo", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Water",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Amazzi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterCostTitleTranslation",
                column: "Lang1",
                value: "Amazzi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterDurationTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Obudde bwomala nga okozessa amazzi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterPurchasedTranslation",
                column: "Lang1",
                value: "Amazzi agagulwa");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterPurchasedUnitType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Liita", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterPurchasedUnitType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ekipimo Kya mazzi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WatherDurationTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Obudde bwomala nga okozessa amazzi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WebAuthDescTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WebAuthTitleTranslation",
                column: "Lang1",
                value: "Wewandise kumukutu guno");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhereAreYouLocatedTranslation",
                column: "Lang1",
                value: "Obeelawa");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceTranslation",
                column: "Lang1",
                value: "Ani akuwa obuwereza obwo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Omusawo atali wagavument ajikuba amazzi ge nume/ Omusawo atali wagavument awakisa embiizi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Omusawo wagavument ajikuba amazzi ge nume/omusawo wagavument awakisa embiizi", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Omulunzi wa nume", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "YearsExpectedTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Obuwangazi bwenyumba/Enyumba,Enawangala myaka emaka ", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoOtherPurcFrom", "Other Purchased From Not Provided", "Totaddemu awalala jewabigula", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoFeedType", "Other Feed Type Not Provided", "Totaddemu ebika ebirala ebye'mere yebisolo ", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthUpdated", "Health care record has been updated", "Tugaseko ebiwandiko ebipya ku byobulamu", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "HealthSaved", "Health care record has been saved", "Biterekedwa ebikwata ku byobulamu", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherPurchasedUnitNotProvided", "Other Amount Purchased Unit Not Provided", "Totaddemu bipimo kubunji bwewagula", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoDurationEnd", "Duration Finish Not Provided", "Totaddemu obudde bwo' malilideko", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoDurationStart", "Duration Start Not Provided", "Totaddemu obudde bwo' tandikiddeko", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DurIsbefore", "Duration Finish is before Duration Start", "Soka, otekemu obudde bwewamalirako, oddeko bwewatandikirako", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "FeedSaved", "Feed item has been saved", "Biterekedwa ebikwata ku mere yebisolo", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoPaymentValue", "Payment Value Not Provided", "Totaddemu sente zewasasula", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherEqNotProvided", "Other Equipment Type Not Provided", "Totaddemu ebika bye'bikozesebwa ebilala", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoPurchasedFrom", "Other Animal Purchased From Not Provided", "Totaddemu, ebisolo ebirala jjewagula/Totaddemu,  awala wewagula ebisolo ", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoAnimalType", "Other Animal Type Not Provided", "Totaddemu, ebika bye ebisolo ebirala", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoHousingExpense", "Other Housing Expense Not Provided", "Totaddemu, Ensasanya endala ku nyumba ze bisolo", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoTransportationCost", "Transportation Cost Not Provided", "Totaddemu sente zewasasanya ku ntabula", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoTotalCost", "Total Cost Not Provided", "Totaddemu omuggate gwa sente zewasasanya", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoDate", "Date obtained not provided", "Totademu naku,zamwezi lwewabifuna", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Error", "Error", "Ensobi ekoledwa", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Updated", "Updated", "Tugaseko ebipya  ", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DeleteVerify", "Are you sure you want to Delete this item", "Okakakasa oyagala kubijjamu", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Cancel", "Cancel", "Togenda mumaso kukyikola/Tokyikola/SikkituFfu/Kijeeko/Kijeewo/Kijeemu", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "FeedUpdated", "Feed record has been updated", "Tugaseko ebiwandiko ebipya ku mere yebisolo", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OK", "OK", "Kaale/Gendamumaso", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SaveHouseRecord", "Housing record has been saved", "Biterekeddwa ebiwandiko ebikwata kunyumba ze bisolo", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalUpdated", "Animal purchase record has been updated", "Tugaseko ebiwandiko ebipya ebikwatagana mukugula ebisolo ", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AnimalSaved", "Animal purchase has been saved", "Biterekeddwa Ebyo kugula ebisolo ", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoAmountRecevied", "Amount Received Not Provided", "Totaddemu sente zewafuna", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoServiceType", "Other Service Type Not Provided", "Totaddemu ebika byo obuwereza obulala", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NotOtherClient", "Other Client Not Provided", "Totaddemu bakasitoma abalala ", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "BreedingSaved", "Breeding service sale has been saved", " Obuwerezza obwekusa ku no'kuwakisa buterekeddwa", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SaleSaved", "Sale of reproductive services has been saved", "Obuwerezza obwekusa kugwako no kuzzala buterekeddwa/ Entunda yo' obuwerezza obwekusa kugwako no kuzzala  eterekeddwa", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentUpdated", "Equipment record has been updated", "Tugaseko ebiwandiko ebipya ku bikozesebwa", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "EquipmentSaved", "Equipment record has been saved", "Biterekeddwa ebikwata kubikozesebwa", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DeleteConfirmation", "Deletion Confirmation", "Bisanguddwa/Bijjiddwamu", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoOtherHealthCareYpe", "Other Health Care Type Not Provided", "Totaddemu ebika byobujjanjabi ebilala", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoCountry", "Country Not Provided", "Totaddemu  erinya lyensiyo jova", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoOtherMediceType", "Other Medicine Type Not Provided", "Totaddemu bika byadagla bilala", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoSowsServiced", "Sows Serviced Not Provided", "Totaddemu, mbizi enkazi zewawakisa", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoOtherServiceProvider", "Other Who Provided Service Not Provided", "Totademu, omulala eyakuwa obuwerezza buno ", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WaterSaved", "Water record has been saved", "Ebiwandiko bya' mazzi bitrekeddwa", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoOtherPerson", "Other Person Purchased From Not Provided", "Totademu, abalala bewagulako ", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "About", "About", "Ebikwatagana ne", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LastData", "Last Data Update: ", "Lwewasemba yo'kutekakko ebipya", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Hello", "Hello ", "Abeenno", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Viilage", "Village: ", "Ekyaalo", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "FailedToLoad", "Failed to Load Item", "Kyosindika Tekyigenze", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SendingData", "Sending Data", "Obubakka buli kusindikibwa", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoUsername", "Username Not provided", "Totaddemu elinya lyo kozesa kuno", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoName", "Name Not provided", "Totaddemu linya lyo", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoPhoneNumber", "Phone Number Not Provided", "Totaddemu namba ya simu yo", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoCurrency", "Currency Not Provided", "Totaddemu kyika kyasente", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DataUploaded", "Data Uploaded!", "Obubakka buwerezeddwa", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DataHasBeenUploaded", "The Data has been uploaded", "Obubakka buwerezeddwa", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Vitnamese", "Vietnamese", "Oluventinamu", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Swahili", "Swahili", "Oluswayiri", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "English", "English", "Oluzungu", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "Wait", "Please Wait", "Ojira olinda ko", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "GoogleAuth", "Google Auth Failed", "Waliwo obuzibu", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TotalCost", "Total Cost", "Omugatte ogwensasaanya yona ", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TotalProfit", "Total Profit", "Omugatte ogwamagoba gona", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SomethingWrong", "Something went wrong, please try again later", "Ddamu bupya waliwo ekitagenze bulunji, geezako oluvanyuma ", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "YourChangesSaved", "Your changes have been saved", "Tujikiriza, enkyuka,kyuka jokozze", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ReproductionSaved", "Reproduction record has been saved", "Ebiwandiko ebyekusa kugwakko no' okuzaala bitrekeddwa", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ReproductionUpdated", "Reproduction record has been updated", "Tugaseko ebiwandiko ebipya ebyekusa kugwakko no' okuzaala", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoOtherPigType", "Other Pig Type Not Provided", "Totaddemu ebika  ebilala ebye' mbizi", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoBrokerage", "Brokerage Not Provided", "Totaddemu  ebyakayungirizi", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoMedicineCost", "Medicine Cost Not Provided", "Totaddemu nsasanya kudagala", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoHealthCareCost", "Health Care Cost Not Provided", "Totaddemu nsasanya kubyobulamu", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoDateProvided", "Date not provided", "Totaddemu naku zamwezzi", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "RecordLabourUpdated", "Labour Cost Record Update", "Tugaseko ensasanya kubakozi", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "RecordLabourCostSaved", "Labour Cost Record Saved", "Ensasanya kubakozi Eterekeddwa, ", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "AmountPaidNotProvided", "Amount Paid Not Provided", "Tottademu omuwendo gwewasasula", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoOtherLabourType", "Other Labour Type Not Provided", "Totaddemu bika byabakozi, ebilala", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanUpdated", "Loan repayment record has been updated", "Tugaseko ebipya kunsasula yamabanja", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "LoanSaved", "Loan repayment has been saved", "Biterekeddwa ebipya kunsasula yamabanja", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoTotalAmount", "Total Amount Repaid Not Provided", "Totaddemu muwendo gwe wakasasulako", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherUnitNotProvided", "Other Unit Not Provided", "Totaddemu epimo endala", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ManureUpdated", "Manure sale record has been updated", "Tugaseko ebipya kuntunda ye ebijimusa", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoOtherProvider", "Other Provider Not Provided", "Totaddemu abawereza abalala ", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "ManureSaved", "Manure sale has been saved", "Ebipya kuntunda ye ebijimusa Biterekeddwa ", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "WaterCostUpdated", "Water cost record has been updated", "Tugaseko ensasaanya kumazzi", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "MemberShipSaved", "Membership has been saved", "Biterekeddwa ebikwata kubwamemba bwo", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TimePeriodNotProvided", "Time Period Not Provided", "Totaddemu budde", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoPeriodUnit", "Time Period Unit Not Provided", "Totaddemu ngeri jobazemu budde bwo", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoOtherMemberShip", "Other Membership Type Not Provided", "Totaddemu bwamemba bwo obulala", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherCostUpdated", "Other cost record has been updated", "Tugaseko ebye'nsasanya endala", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherCostsSaved", "Other Cost has been saved", "Ensasanya endala eterekedwa", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherIncomeUpdated", "Other income record has been updated", "Tugaseko Ebye'nyingiza endala", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "OtherIncomeSaved", "Other income has been saved", "Ebye'nyingiza endala biterekeddwa", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PigSaleUpdated", "Pig sale record has been updated", "Tugaseko ebipya kumbizi  ezatundwa", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "PigSaleSaved", "Pig sale has been saved", "Ebye'mbizi sewatunda biterekeddwa", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoSalePrice", "Sale Price Not Provided", "Totaddemu beyi jewatundi lako", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "NoOtherSoldTo", "Other Sold To Not Provided", "Totaddemu abalala be waguza", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "TotalAnimalCosts", "Total cost for all animals", "Omugatte gwensasaanya kubisolo byona", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "About");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPaidNotProvided");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalSaved");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalUpdated");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingSaved");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Cancel");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DataHasBeenUploaded");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DataUploaded");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DeleteConfirmation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DeleteVerify");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DurIsbefore");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "English");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentSaved");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentUpdated");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Error");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FailedToLoad");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedSaved");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedUpdated");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GoogleAuth");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthSaved");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthUpdated");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Hello");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LastData");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanSaved");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanUpdated");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureSaved");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureUpdated");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MemberShipSaved");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoAmountRecevied");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoAnimalType");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoBrokerage");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoCountry");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoCurrency");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoDate");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoDateProvided");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoDurationEnd");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoDurationStart");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoFeedType");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoHealthCareCost");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoHousingExpense");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoMedicineCost");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoName");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherHealthCareYpe");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherLabourType");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherMediceType");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherMemberShip");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherPerson");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherPigType");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherProvider");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherPurcFrom");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherServiceProvider");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherSoldTo");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoPaymentValue");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoPeriodUnit");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoPhoneNumber");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoPurchasedFrom");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoSalePrice");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoServiceType");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoSowsServiced");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoTotalAmount");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoTotalCost");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NotOtherClient");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoTransportationCost");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoUsername");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OK");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostsSaved");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostUpdated");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherEqNotProvided");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncomeSaved");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncomeUpdated");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPurchasedUnitNotProvided");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherUnitNotProvided");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigSaleSaved");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigSaleUpdated");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RecordLabourCostSaved");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RecordLabourUpdated");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReproductionSaved");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReproductionUpdated");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SaleSaved");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SaveHouseRecord");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SendingData");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SomethingWrong");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Swahili");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodNotProvided");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAnimalCosts");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalCost");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalProfit");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Updated");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Viilage");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Vitnamese");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Wait");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterCostUpdated");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterSaved");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "YourChangesSaved");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AddData",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Add Data lang1", "Add Data lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AddFeedItemTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Add Feed Cost Lang1", "Add Feed Cost Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPaidTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Amount paid over the labour use duration Lang1", "Amount paid over the labour use duration Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPurchasedTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Amount Purchased Lang1", "Amount Purchased Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPurchasedTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Amount Purchased Lang1", "Amount Purchased Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPurchasedUnitTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Amount Purchased Lang1", "Amount Purchased Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountRecievedTranslation",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Amount recieved for all services", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchase",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Home Lang1", "Home Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType1",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Market ", "Market  Lang1", "Market  Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Trader Lang1", "Trader Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Pig farmer Lang1", "Pig farmer Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType4",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Pig breeding company Lang1", "Pig breeding company Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchaseTitleTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Piglet(s) for fattening Lang1", "Piglet(s) for fattening Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Gilt / sow for breeding Lang1", "Gilt / sow for breeding Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Young male / boar for breeding Lang1", "Young male / boar for breeding Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnyOtherPaymentTranslation",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Any Other Payment Recieved", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceSale",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Home Lang1", "Home Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceSaleTitleTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Boar services Lang1", "Boar services Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Semen sale (? to include) Lang1", "Semen sale (? to include) Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BrokerageTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CellTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ClientTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ClientType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Pig farmer Lang1", "Pig farmer Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CommentTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Comment Lang1", "Comment Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CommentTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Comment Lang1", "Comment Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CommuneTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Costs",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Home Lang1", "Home Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CostTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Cost Lang1", "Cost Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CostTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Any other cost: Lang1", "Any other cost: Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTypeRwanda",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTypeUganda",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTypeVietnam",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountyTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CurrencyTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DateLastUploaded",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Data last uploaded lang1", "Data last uploaded lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DateObtainedTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Date Obtained Lang1", "Date Obtained Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DateTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Date Lang1", "Date Lang 2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DeleteTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Delete Lang1", "Delete Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DistrictTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Maize Bran Lang1", "Maize Bran Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType10",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Soybean Meal Lang1", "Soybean Meal Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType11",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Sunflower Cake Lang1", "Sunflower Cake Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType12",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Cotton Seed Cake Lang1", "Cotton Seed Cake Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType13",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Groundnut Cake Lang1", "Groundnut Cake Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType14",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Compounded Feeds (Labelled Feeds) Lang1", "Compounded Feeds (Labelled Feeds) Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType15",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Compounded Feeds (Non-Labelled Feeds) Lang1", "Compounded Feeds (Non-Labelled Feeds) Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType16",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Minerals Lang1", "Minerals Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType17",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Vitamins Lang1", "Vitamins Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType18",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Pre-Mixes Lang1", "Pre-Mixes Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType19",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Silage Lang1", "Silage Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Wheat Bran Lang1", "Wheat Bran Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Maize Germ Lang1", "Maize Germ Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType4",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Rice Bran Lang1", "Rice Bran Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType5",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Maize Gluten Feed Lang1", "Maize Gluten Feed Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType6",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Wheat Gluten Feed Lang1", "Wheat Gluten Feed Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType7",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Dried Brewers’ Grain Lang1", "Dried Brewers’ Grain Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType8",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Ground Maize Lang1", "Ground Maize Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType9",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Soybean Seed Cake Lang1", "Soybean Seed Cake Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Feed supplier Lang1", "Feed supplier Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Agro-vet Lang1", "Agro-vet Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Another farmer Lang1", "Another farmer Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom4",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Transporter Lang1", "Transporter Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownUnitType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Kg Lang1", "Kg Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownUnitType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Number Lang1", "Number Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownUnitType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Kg Lang1", "Kg Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EditData",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "View / Edit / Delete data lang1", "View / Edit / Delete data lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EditTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Edit Lang1", "Edit Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EmailTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Equipment",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Equipment Lang1", "Equipment Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentTitleTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Feeding equipment Lang1", "Feeding equipment Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Watering equipment Lang1", "Watering equipment Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Cleaning equipment Lang1", "Cleaning equipment Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType4",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Animal tags Lang1", "Animal tags Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Feed",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Home Lang1", "Home Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedDurationTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Duration Lang1", "Duration Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedItemTitleTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedTypeTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Feed Type Lang1", "Feed Type Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedTypeTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Feed Type Lang1", "Feed Type Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FilterTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FinishTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Finish Lang1", "Finish Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderType1",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderType2",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderType3",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GoogleSignUpTranslation",
                column: "Lang1",
                value: "Google Lang 1");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Healthcare",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Home Lang1", "Home Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareCostTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Service Provider Cost Lang1", "Service Provider Cost Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareTitleTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareTypeTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Health Care Type Lang1", "Health Care Type Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Private animal health worker or veterinarian Lang1", "Private animal health worker or veterinarian Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Government animal health worker veterinarian Lang1", "Government animal health worker veterinarian Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Self Lang1", "Self Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType4",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Neighbour, friend, or relative Lang1", "Neighbour, friend, or relative Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Curative (treatment of a disease) Lang1", "Curative (treatment of a disease) Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Preventative (such as vaccinations) Lang1", "Preventative (such as vaccinations) Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Administration of vitamins Lang1", "Administration of vitamins Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType4",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Deworming Lang1", "Deworming Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType5",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Use of disinfectants Lang1", "Use of disinfectants Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType6",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Herd visit/monitoring Lang1", "Herd visit/monitoring Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Home",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Home Lang1", "Home Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Housing",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Home Lang1", "Home Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Housing Expense Lang1", "Housing Expense Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "New house construction Lang1", "New house construction Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Expansion of existing housing Lang1", "Expansion of existing housing Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Repairs or maintenance Lang1", "Repairs or maintenance Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingTitleTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Animal Housing Lang1", "Animal Housing Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Income",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Home Lang1", "Home Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Labour",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Home Lang1", "Home Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourDurationTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Duration Lang1", "Duration Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourTitleTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Labour Cost Lang1", "Labour Cost Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Permanent hired labourer Lang1", "Permanent hired labourer Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Temporary hired labourer Lang1", "Temporary hired labourer Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourTypeTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Labour Type Lang1", "Labour Type Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType1",
                column: "English",
                value: "Language1");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType2",
                column: "English",
                value: "Language2");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType3",
                column: "English",
                value: "Language3");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType4",
                column: "English",
                value: "Language4");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType5",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Language5", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType6",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Language6", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerAgreeTranslation",
                column: "Lang1",
                value: "Legal check 1");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerBodyTranslation",
                column: "Lang1",
                value: "Legal body Lang 1");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerProceedTranslation",
                column: "Lang1",
                value: "Proceed Lang 1");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerTitleTranslation",
                column: "Lang1",
                value: "Legal Lang 1");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Micro-credit provider Lang1", "Micro-credit provider Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Bank Lang1", "Bank Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Co-operative or group Lang1", "Co-operative or group Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType4",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Self-help group or savings ", "Self-help group or savings  Lang1", "Self-help group or savings  Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType5",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Club Lang1", "Club Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType6",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Relatives or friends Lang1", "Relatives or friends Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanRepayment",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Home Lang1", "Home Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanRepaymentTitleTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoginButton",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "SignUP", "OverHere" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureSale",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Home Lang1", "Home Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureSaleTitleTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineCostTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Medicine Cost: Lang1", "Medicine Cost: Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType1",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Drugs ", "Drugs  Lang1", "Drugs  Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Vaccinations Lang1", "Vaccinations Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Dewormers Lang1", "Dewormers Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType4",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Vitamins Lang1", "Vitamins Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineTypeTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Medicine Type: Lang1", "Medicine Type: Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Membership",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Home Lang1", "Home Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipDurationTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Duration Lang1", "Duration Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipTitleTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Co-operative or group fees Lang1", "Co-operative or group fees Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Name",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "NameLang1", "NameLang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NameTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NumberPurchasedTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NumberServicesTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NumberSoldTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Other",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Other, specify Lang1", "Other, specify Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAmountPurchasedUnitTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Other Amount Purchased Lang1", "Other Amount Purchased Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAmountPurchaseTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Other Amount Purchased Lang1", "Other Amount Purchased Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAnimalPurchasedTranslation",
                columns: new[] { "English", "Lang1" },
                values: new object[] { "Other Purchased from", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAnimalTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherClientTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostEvent",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Other", "Other" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostsTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Any Other Cost Lang1", "Any Other Cost Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostTitleTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Any Other Cost Lang1", "Any Other Cost Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherEquipmentTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherFeedTypeTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Other Feed Type Lang1", "Other Feed Type Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherFeedTypeTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Other Feed Type Lang1", "Other Feed Type Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherHealthCareTypeTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Other Health Care Type Lang 1", "Other Health Care Type Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherHousingExpenseTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Other Housing Expense Lang1", "Other Housing Expense Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncome",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Home Lang1", "Home Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncomeTitleTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherLaboutTypeTranslation",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Other LabourType", "Other LabourType Lang1", "Other LabourType Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherLoanProviderTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherMedicineTypeTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Other Medicine Type: Lang1", "Other Medicine Type: Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherMembershipTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPigTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherProviderTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Other provided service: Lang1", "Other provided service: Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPurchasedFromTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Purchased From Lang1", "Purchased From Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPurchasedWaterFromTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherServiceTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherSoldToTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherWaterPurchasedTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherWhatForTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherWhoProvidedServiceTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ParishTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PaymentType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Piglet Lang1", "Piglet Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PaymentTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PaymentValueTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PhoneNumberTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerAnimalTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerClientTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerCountryTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerCountyTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerCurrencyTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerDistrictTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerEquipmentTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerFeedTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerGenderTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerHealthCareTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerHousingExpenseTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerLabourTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerMedicineTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerMembershipTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerPaymentTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerPigTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerProviderTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerPurchasedFromTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerServiceTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerSoldToTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerSubCountyTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerUnitTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigSale",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Home Lang1", "Home Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigSaleTitleTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Piglet (for fattening) Lang1", "Piglet (for fattening) Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Slaughter animal Lang1", "Slaughter animal Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Gilt/sow sow for breeding Lang1", "Gilt/sow sow for breeding Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType4",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "Young male/boar for breeding ", "Young male/boar for breeding  Lang1", "Young male/boar for breeding  Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ProviderTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Who provided service: Lang1", "Who provided service: Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ProvinceTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PruchaseFromType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Private animal health worker or veterinarian Lang1", "Private animal health worker or veterinarian Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PruchaseFromType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Government animal health worker veterinarian Lang1", "Government animal health worker veterinarian Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PruchaseFromType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Agro-vet store Lang1", "Agro-vet store Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedFrom",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Purchased From Lang1", "Purchased From Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedFromTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Purchased From Lang1", "Purchased From Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Mobile water seller Lang1", "Mobile water seller Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Water company Lang1", "Water company Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Neighbour / friend Lang1", "Neighbour / friend Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationSuccessfulContinueTranslation",
                column: "Lang1",
                value: "Continue Lang 1");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationSuccessfulDescTranslation",
                column: "Lang1",
                value: "Begin Lang 1");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationSuccessfulTitleTranslation",
                column: "Lang1",
                value: "Account Created Lang 1");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationTitleTranslation",
                column: "Lang1",
                value: "Registration Lang 1");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Reproduction",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Home Lang1", "Home Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReproductiveTitleTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ResetTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Reset Lang1", "Reset Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SalePriceTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SaveTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Save Lang1", "Save Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SectorTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ServiceType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Artificial insemination Lang1", "Artificial insemination Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ServiceType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Natural mating Lang1", "Natural mating Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ServiceTypeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SliderControlTranslation",
                columns: new[] { "English", "Lang1", "Lang2" },
                values: new object[] { "If new housing built (rather than maintenance) lifespan in years + expected salvage value at end ? ", "If new housing built(rather than maintenance)lifespan in years + expected salvage value at end ? Lang1", "If new housing built(rather than maintenance)lifespan in years + expected salvage value at end ? Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Trader Lang1", "Trader Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Slaughter-house Lang1", "Slaughter-house Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Pig farmer Lang1", "Pig farmer Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SowsServicedCostTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "StartTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Start Lang1", "Start Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SubCountyTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodUnitType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Months Lang1", "Months Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodUnitType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Years Lang1", "Years Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAmountRepaidTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAnimalCostsTranslation",
                column: "English",
                value: "Total cost for all animals");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalCostTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Total Cost Lang1", "Total Cost Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalIncomeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TransportationCostTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Transport Cost Lang1", "Transport Cost Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TransportCostTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Transportation Cost Lang1", "Transportation Cost Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "UnitTrans",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Unit Lang1", "Unit Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "UploadDataTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "UserNameTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ViewReports",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Reports Lang1", "Reports Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Village",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "VillageLang1", "VillageLang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VillageTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VolumeSoldTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VolumeUnitType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Kg Lang1", "Kg Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VolumeUnitType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Bag Lang1", "Bag Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Water",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Home Lang1", "Home Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterCostTitleTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterDurationTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Duration Lang1", "Duration Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterPurchasedTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterPurchasedUnitType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Litre Lang1", "Litre Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterPurchasedUnitType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Cubic meter Lang1", "Cubic meter Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WatherDurationTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Water Use Duration Lang1", "Water Use Duration Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WebAuthDescTranslation",
                column: "Lang1",
                value: "Desc Lang 1");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WebAuthTitleTranslation",
                column: "Lang1",
                value: "Sign Up Lang 1");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhereAreYouLocatedTranslation",
                column: "Lang1",
                value: "Located Lang 1");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceType1",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Private artificial insemination service provider Lang1", "Private artificial insemination service provider Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceType2",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Government artificial insemination service provider Lang1", "Government artificial insemination service provider Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceType3",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Boar keeper Lang1", "Boar keeper Lang2" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "YearsExpectedTranslation",
                columns: new[] { "Lang1", "Lang2" },
                values: new object[] { "Expected Housing Lifespan (Years)1", "Expected Housing Lifespan (Years)2" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType7", "CountyType 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType2", "DistrictType 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType3", "DistrictType 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType4", "DistrictType 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType5", "DistrictType 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType6", "DistrictType 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType7", "DistrictType 7", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType8", "DistrictType 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType1", "CountyType 1", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType2", "CountyType 2", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType3", "CountyType 3", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType4", "CountyType 4", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType5", "CountyType 5", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType6", "CountyType 6", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "CountyType8", "CountyType 8", "", "" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "DistrictType1", "DistrictType 1", "", "" });
        }
    }
}
