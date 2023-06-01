using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class NewRwandaTranslation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lang3",
                table: "Translations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "About",
                column: "Lang3",
                value: "Ibyerekeye");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AddData",
                column: "Lang3",
                value: "Ongeraho amakuru");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AddFeedItemTrans",
                column: "Lang3",
                value: "Ongeramo igiciro cy'ibiryo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPaidNotProvided",
                column: "Lang3",
                value: "Ingano y'amafaranga yishuwe ntabwo yatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPaidTranslation",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPurchasedTrans",
                column: "Lang3",
                value: "Amafaranga yakoreshejwe ugura ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPurchasedTranslation",
                column: "Lang3",
                value: "Amafaranga yakoreshejwe ugura ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPurchasedUnitTranslation",
                column: "Lang3",
                value: "Amafaranga yakoreshejwe ugura ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountRecievedTranslation",
                column: "Lang3",
                value: "ingano y'amafaranga yabonetse mu kubanguriza");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchase",
                column: "Lang3",
                value: "Kugura amatungo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromTranslation",
                column: "Lang3",
                value: "Aho byaguriwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType1",
                column: "Lang3",
                value: "isoko");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType2",
                column: "Lang3",
                value: "umucuruzi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType3",
                column: "Lang3",
                value: "umworozi w'ingurube");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType4",
                column: "Lang3",
                value: "sosiyete / kampani yorora ingurube ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchaseTitleTranslation",
                column: "Lang3",
                value: "Kugura amatungo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalSaved",
                column: "Lang3",
                value: "Amakuru y'amatungo yaguzwe yabitswe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalType1",
                column: "Lang3",
                value: "ikibwana cyo kubyibushwa");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalType2",
                column: "Lang3",
                value: "inyagazi/ imbyeyi yo korora");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalType3",
                column: "Lang3",
                value: "isekurume/impfizi yo korora");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalTypeTranslation",
                column: "Lang3",
                value: "Ubwoko bw'itungo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalUpdated",
                column: "Lang3",
                value: "Amakuru y'ahaguriwe amatungo yavuguruwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnyOtherPaymentTranslation",
                column: "Lang3",
                value: "Ubundi bwishyu waba warabonye");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreakdownLabel",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingSaved",
                column: "Lang3",
                value: "Ikiguzi cyo kubanguriza cyabitswe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceSale",
                column: "Lang3",
                value: "ikiguzi cyo kubanguriza");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceSaleTitleTranslation",
                column: "Lang3",
                value: "ikiguzi cyo kubanguriza");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceType1",
                column: "Lang3",
                value: "kubangurira ku mfizi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BrokerageTranslation",
                column: "Lang3",
                value: "umu sherisheri / komisiyoneri / uhuza abaguzi n'abagurisha");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Cancel",
                column: "Lang3",
                value: "Hagarika");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CellTranslation",
                column: "Lang3",
                value: "Akagali");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ClientTranslation",
                column: "Lang3",
                value: "umuguzi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ClientType1",
                column: "Lang3",
                value: "umworozi w'ingurube");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CommentTrans",
                column: "Lang3",
                value: "igitekerezo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CommentTranslation",
                column: "Lang3",
                value: "igitekerezo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CommuneTranslation",
                column: "Lang3",
                value: "Komini");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Costs",
                column: "Lang3",
                value: "Ikiguzi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CostTrans",
                column: "Lang3",
                value: "Ikiguzi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CostTranslation",
                column: "Lang3",
                value: "Ikindi kiguzi cyishuwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTranslation",
                column: "Lang3",
                value: "Igihugu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTypeRwanda",
                column: "Lang3",
                value: "U Rwanda");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTypeUganda",
                column: "Lang3",
                value: "Uganda");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTypeVietnam",
                column: "Lang3",
                value: "Vietnamu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountyTranslation",
                column: "Lang3",
                value: " See above the admin units in Rwanda");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Created",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CurrencyTranslation",
                column: "Lang3",
                value: "ifaranga rikoreshejwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CurrencyType1",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CurrencyType2",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CurrencyType3",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CurrencyType4",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CurrencyType5",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CurrencyType6",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CurrencyType7",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CurrencyType8",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DataHasBeenUploaded",
                column: "Lang3",
                value: "Amakuru yamaze kongeweho");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DataUploaded",
                column: "Lang3",
                value: "Amakuru yongeweho!");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DateLastUploaded",
                column: "Lang3",
                value: "Amakuru aheruka gushyirwaho");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DateObtainedTrans",
                column: "Lang3",
                value: "Itariki byaguriwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DateTranslation",
                column: "Lang3",
                value: "Itariki");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DeleteConfirmation",
                column: "Lang3",
                value: "Kwemeza Gusiba");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DeleteTranslation",
                column: "Lang3",
                value: "Siba");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DeleteVerify",
                column: "Lang3",
                value: "Uzi neza ko ushaka Gusiba iki kintu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DistrictTranslation",
                column: "Lang3",
                value: "Akarere");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType1",
                column: "Lang3",
                value: "buranda y'ibigori");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType10",
                column: "Lang3",
                value: "indyo ya soya");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType11",
                column: "Lang3",
                value: "ibisigazwa by'ibihwagari");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType12",
                column: "Lang3",
                value: "Ipampa");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType13",
                column: "Lang3",
                value: "ubunyobwa");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType14",
                column: "Lang3",
                value: "Imvage y'ibiryo (ifite izina ry'ubucuruzi)");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType15",
                column: "Lang3",
                value: "Imvage y'ibiryo (itagira izina ry'ubucuruzi)");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType16",
                column: "Lang3",
                value: "imyunyu ngugu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType17",
                column: "Lang3",
                value: "vitamini");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType18",
                column: "Lang3",
                value: "Premix");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType19",
                column: "Lang3",
                value: "ansilaje (ubwatsi buhugutishijwe)");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType2",
                column: "Lang3",
                value: "buranda y'ingano");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType3",
                column: "Lang3",
                value: "imigondoro y'ibigori");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType4",
                column: "Lang3",
                value: "buranda y'umuceri");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType5",
                column: "Lang3",
                value: "gluten y'ibigori");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType6",
                column: "Lang3",
                value: " gluten y'ingano ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType7",
                column: "Lang3",
                value: "intete za dereshe zumye");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType8",
                column: "Lang3",
                value: "Ibigori");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType9",
                column: "Lang3",
                value: "ibisigazwa bya soya");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom1",
                column: "Lang3",
                value: "Ucuruza ibiryo by'amatungo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom2",
                column: "Lang3",
                value: "Ucuruza inyongeramusaruro zo mu buhinzi n'ubworozi ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom3",
                column: "Lang3",
                value: "Undi mworozi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom4",
                column: "Lang3",
                value: "Abakora ubwikorezi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownUnitType1",
                column: "Lang3",
                value: "Ibilo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownUnitType2",
                column: "Lang3",
                value: "Umubare");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownUnitType3",
                column: "Lang3",
                value: "garamu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DurIsbefore",
                column: "Lang3",
                value: "Igihe cyo gusoza ni mbere y'igihe cyo Gutangira");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EditData",
                column: "Lang3",
                value: "Reba/ Kosora / Siba amakuru");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EditTranslation",
                column: "Lang3",
                value: "Kosora");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EmailTranslation",
                column: "Lang3",
                value: "imeri");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "English",
                column: "Lang3",
                value: "Kinyarwanda");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Equipment",
                column: "Lang3",
                value: "Ibikoresho");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentSaved",
                column: "Lang3",
                value: "Amakuru ku bikoresho yabitswe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentTitleTranslation",
                column: "Lang3",
                value: "Ibikoresho");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType1",
                column: "Lang3",
                value: "ibikoresho byo kugabura");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType2",
                column: "Lang3",
                value: "ibikoresho byo gutanga amazi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType3",
                column: "Lang3",
                value: "ibikoresho byo gusukura");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType4",
                column: "Lang3",
                value: "amaherena");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentTypeTranslation",
                column: "Lang3",
                value: "Ubwoko bw'ibikoresho");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentUpdated",
                column: "Lang3",
                value: "Amakuru ku bikoresho yavuguruwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Error",
                column: "Lang3",
                value: "Ntabwo aribyo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FailedToLoad",
                column: "Lang3",
                value: "Byanze kongeraho amakuru");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Feed",
                column: "Lang3",
                value: "Ibiryo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedDurationTranslation",
                column: "Lang3",
                value: "Igihe umara ukoresha ibyo biryo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedItemTitleTranslation",
                column: "Lang3",
                value: "Ibiryo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedSaved",
                column: "Lang3",
                value: "Ubwoko bw'ibiryo bwabitswe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedTypeTrans",
                column: "Lang3",
                value: "Ubwoko bw'ibiryo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedTypeTranslation",
                column: "Lang3",
                value: "Ubwoko bw'ibiryo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedUpdated",
                column: "Lang3",
                value: "Amakuru ku biryo yavuguruwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FilterTranslation",
                column: "Lang3",
                value: "Tandukanya ukoresheje:");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FinishTranslation",
                column: "Lang3",
                value: "Soza");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderTranslation",
                column: "Lang3",
                value: "Igitsina");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderType1",
                column: "Lang3",
                value: "gabo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderType2",
                column: "Lang3",
                value: "gore");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderType3",
                column: "Lang3",
                value: "ibindi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GoogleAuth",
                column: "Lang3",
                value: "Ukwemezwa na Google ntabwo byemeye");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GoogleSignUpTranslation",
                column: "Lang3",
                value: "iyandikishe ukoresheje google");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Healthcare",
                column: "Lang3",
                value: "kwita ku buzima bw'amatungo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareCostTranslation",
                column: "Lang3",
                value: "Ikiguzi cy'uwatanze serivisi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareTitleTranslation",
                column: "Lang3",
                value: "kwita ku buzima bw'amatungo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareTypeTranslation",
                column: "Lang3",
                value: "Uburyo bukoreshwa mu kwita ku buzima bw'amatungo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType1",
                column: "Lang3",
                value: "Veterineri cyangwa umujyanama ku buzima bw'amatungo wikorera ku giti cye");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType2",
                column: "Lang3",
                value: "Veterineri cyangwa ushinzwe ubuzima bw'amatungo wa Leta");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType3",
                column: "Lang3",
                value: "wenyine");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType4",
                column: "Lang3",
                value: "Umuturanyi, inshuti, cyangwa umuvandimwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthSaved",
                column: "Lang3",
                value: "Amakuru ku kwita ku buzima bw'amatungo yabitswe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthUpdated",
                column: "Lang3",
                value: "Amakuru ku kwita ku buzima bw'amatungo yavuguruwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType1",
                column: "Lang3",
                value: "Kuvura (kuvura indwra runaka)");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType2",
                column: "Lang3",
                value: "Kurinda indwara (nko gukingira)");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType3",
                column: "Lang3",
                value: "gutanga za vitamini");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType4",
                column: "Lang3",
                value: "gutanga umuti w’inzoka");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType5",
                column: "Lang3",
                value: "Gukoresha imiti yica udukoko (desinfectants)");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType6",
                column: "Lang3",
                value: "Gusura amatungo / gukurikirana");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Hello",
                column: "Lang3",
                value: "Mwaramutse");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Home",
                column: "Lang3",
                value: "Ahabanza");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Housing",
                column: "Lang3",
                value: "Ikiraro");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseTranslation",
                column: "Lang3",
                value: "Igiciro cy'ibyakozwe wubaka ikiraro");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseType1",
                column: "Lang3",
                value: "Kubaka ikiraro gishya");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseType2",
                column: "Lang3",
                value: "Kwagura ikiraro gisanzwe gihari");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseType3",
                column: "Lang3",
                value: "Gusana cyangwa kubungabunga ikiraro");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingTitleTranslation",
                column: "Lang3",
                value: "Ikiraro");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Income",
                column: "Lang3",
                value: "Amafaranga yinjira");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "IncomeBreakdownLabel",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Labour",
                column: "Lang3",
                value: "Umurimo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourDurationTranslation",
                column: "Lang3",
                value: "Imibyizi ukenera ukoresha ibyo biryo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourTitleTranslation",
                column: "Lang3",
                value: "Umurimo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourType1",
                column: "Lang3",
                value: "Umukozi uhoraho / uhembwa buri kwezi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourType2",
                column: "Lang3",
                value: "Umukozi udahoraho/nyakabyizi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourTypeTranslation",
                column: "Lang3",
                value: "Ubwoko bw'umurimo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageTranslation",
                column: "Lang3",
                value: "Ururimi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType1",
                column: "Lang3",
                value: "Kinyarwanda");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType2",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType3",
                column: "Lang3",
                value: "Ikinyaviyetinamu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType4",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType5",
                column: "Lang3",
                value: "Ururimi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType6",
                column: "Lang3",
                value: "Ururimi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LastData",
                column: "Lang3",
                value: "Kuvugurura amakuru aheruka");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LastUploadTranslation",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerAgreeTranslation",
                column: "Lang3",
                value: "Mu kugenzura iyi bogisi / agasanduak wemeje amabwiriza yavuzwe haruguru");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerBodyTranslation",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerProceedTranslation",
                column: "Lang3",
                value: "komeza");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerTitleTranslation",
                column: "Lang3",
                value: "Kwamagana byemewe n'amategeko");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanDurationTranslation",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderTranslation",
                column: "Lang3",
                value: "Uwatanze inguzanyo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType1",
                column: "Lang3",
                value: "Utanga inguzanyo ziciriritse");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType2",
                column: "Lang3",
                value: "banki");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType3",
                column: "Lang3",
                value: "koperative cyangwa itsinda");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType4",
                column: "Lang3",
                value: "itsinda ryo gufashanya cyangwa kwizigama");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType5",
                column: "Lang3",
                value: "Itsinda / umurwi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType6",
                column: "Lang3",
                value: "abavandimwe cyangwa incuti");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanRepayment",
                column: "Lang3",
                value: "Kwihyura inguzanyo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanRepaymentTitleTranslation",
                column: "Lang3",
                value: "Kwihyura inguzanyo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanSaved",
                column: "Lang3",
                value: "Kwishyura inguzanyo byabitswe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanUpdated",
                column: "Lang3",
                value: "Amakuru ku kwishyura inguzanyo yavuguruwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoginButton",
                column: "Lang3",
                value: "Injiramo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LossTranslation",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureAmountRecievedTranslation",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureSale",
                column: "Lang3",
                value: "kugurisha ifumbire");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureSaleTitleTranslation",
                column: "Lang3",
                value: "kugurisha ifumbire");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureSaved",
                column: "Lang3",
                value: "kugurisha ifumbire byabitswe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureUpdated",
                column: "Lang3",
                value: "Amakuru ku kugurisha ifumbire yavuguruwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineCostTranslation",
                column: "Lang3",
                value: "Ikiguzi cy'imiti");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType1",
                column: "Lang3",
                value: "Imiti");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType2",
                column: "Lang3",
                value: "Gukingira indwara");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType3",
                column: "Lang3",
                value: "Imiti y'inzoka");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType4",
                column: "Lang3",
                value: "vitamini");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType5",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineTypeTranslation",
                column: "Lang3",
                value: "Ubwoko bw'imiti");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Membership",
                column: "Lang3",
                value: "koperative cyangwa itsinda ubarizwamo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipDurationTranslation",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MemberShipSaved",
                column: "Lang3",
                value: "Ubunyamurayango bwabitswe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipTitleTranslation",
                column: "Lang3",
                value: "koperative cyangwa itsinda ubarizwamo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipType1",
                column: "Lang3",
                value: "Amafaranga agenerwa koperative cyangwa itsinda");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipTypeTranslation",
                column: "Lang3",
                value: "Uburyo ubayemo umunyamuryango");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipUpdated",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MonthTranslation",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Name",
                column: "Lang3",
                value: "Amazina");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NameTranslation",
                column: "Lang3",
                value: "Amazina");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoAmountRecevied",
                column: "Lang3",
                value: "Amafaranga yinjiye ntabwo yatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoAnimalType",
                column: "Lang3",
                value: "Ubundi bwoko bw'itungo ntabwo bwatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoBrokerage",
                column: "Lang3",
                value: "umu sherisheri / komisiyoneri / uhuza abaguzi n'abagurisha ntabwo yatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoCountry",
                column: "Lang3",
                value: "Izina ry'igihugu ntiryatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoCurrency",
                column: "Lang3",
                value: "ifaranga ntabwo ryatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoDate",
                column: "Lang3",
                value: "Itariki yabonekeyeho ntabwo yatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoDateProvided",
                column: "Lang3",
                value: "Itariki ntabwo yatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoDurationEnd",
                column: "Lang3",
                value: "Igihe cyo gusoza ntabwo cyatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoDurationStart",
                column: "Lang3",
                value: "Igihe cyo gutangira ntabwo cyatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoFeedType",
                column: "Lang3",
                value: "Ubundi bwoko bw'ibiryo ntabwo bwavuzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoHealthCareCost",
                column: "Lang3",
                value: "Ikindi kiguzi cyatanzwe ku kwita ku buzima bw'amatungo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoHousingExpense",
                column: "Lang3",
                value: "Andi mafaranga yatanzwe ku kiraro ntabwo yatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoMedicineCost",
                column: "Lang3",
                value: "Ikiguzi cy'imiti ntabwo cyatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoName",
                column: "Lang3",
                value: "Amazina ntabwo yatanzwe ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherHealthCareYpe",
                column: "Lang3",
                value: "Ikindi kiguzi cyatanzwe ku kwita ku buzima bw'amatungo ntabwo cyatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherLabourType",
                column: "Lang3",
                value: "Ubundi bwoko bw'umurimo ntibwavuzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherMediceType",
                column: "Lang3",
                value: "Ubundi bwoko bw'imiti ntabwo bwatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherMemberShip",
                column: "Lang3",
                value: "Ubundi bunyamurayango ntabwo bwavuzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherPerson",
                column: "Lang3",
                value: "Abandi bantu baguriwe ntibavuzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherPigType",
                column: "Lang3",
                value: "Ubundi bwoko bw'ingurube ntibwatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherProvider",
                column: "Lang3",
                value: "Undi utanga serivisi / ibikoresho/ibintu ntabwo yavuzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherPurcFrom",
                column: "Lang3",
                value: "Ahandi byaguriwe ntabwo havuzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherServiceProvider",
                column: "Lang3",
                value: "Abandi batanga serivisi ntibavuzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherSoldTo",
                column: "Lang3",
                value: "Ibindi byagurishijwe ntabwo byavuzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoPaymentValue",
                column: "Lang3",
                value: "Agaciro kibyishuwe ntabwo katanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoPeriodUnit",
                column: "Lang3",
                value: "Igipimo cy'igihe ntabwo cyatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoPhoneNumber",
                column: "Lang3",
                value: "Nimero ya telefoni ntabwo yatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoPurchasedFrom",
                column: "Lang3",
                value: "Ahandi amatungo yaguriwe ntabwo hatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoSalePrice",
                column: "Lang3",
                value: "Igiciro cyo kugurishaho ntabwo cyatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoServiceType",
                column: "Lang3",
                value: "Ubundi bwoko bwa serivisi ntabwo bwavuzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoSowsServiced",
                column: "Lang3",
                value: "Imbyeyi zabanguriwe ntizatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoTotalAmount",
                column: "Lang3",
                value: "Igiteranyo cy'amafaranga yose yishyuwe ntabwo cyatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoTotalCost",
                column: "Lang3",
                value: "Igiteranyo cy'ikiguzi cyose ntabwo cyatanzwwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NotOtherClient",
                column: "Lang3",
                value: "Undi mukiliya ntabwo byavuzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoTransportationCost",
                column: "Lang3",
                value: "ikiguzi cy'ubwikorezi ntabwo cyatanzwwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoUsername",
                column: "Lang3",
                value: "Izina ukoresha ntabwo rytanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NumberPurchasedTranslation",
                column: "Lang3",
                value: "Umubare w'ibyaguzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NumberServicesTranslation",
                column: "Lang3",
                value: "incuro wabangurije");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NumberSoldTranslation",
                column: "Lang3",
                value: "Umubare wagurishijwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OK",
                column: "Lang3",
                value: "Yego");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Other",
                column: "Lang3",
                value: "Ibindi, bivuge");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAmountPurchasedUnitTranslation",
                column: "Lang3",
                value: "igipimo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAmountPurchaseTrans",
                column: "Lang3",
                value: "Andi mafaranga yakoreshejwe ugura");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAnimalPurchasedTranslation",
                column: "Lang3",
                value: "Aho byaguriwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAnimalTypeTranslation",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherClientTranslation",
                column: "Lang3",
                value: "undi muguzi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostEvent",
                column: "Lang3",
                value: "ibindi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostsSaved",
                column: "Lang3",
                value: "Ikindi kiguzi cyabibitswe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostsTranslation",
                column: "Lang3",
                value: "Ikindi kiguzi cyishuwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostTitleTranslation",
                column: "Lang3",
                value: "ibindi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostTranslation",
                column: "Lang3",
                value: "Ikindi kiguzi cyishuwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostUpdated",
                column: "Lang3",
                value: "Andi makuru ku kiguzi yavuguruwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherEqNotProvided",
                column: "Lang3",
                value: "Ubundi bwoko bw'ibikoresho ntabwo bwatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherEquipmentTypeTranslation",
                column: "Lang3",
                value: "Ubundi bwoko bw'ibikoresho");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherFeedTypeTrans",
                column: "Lang3",
                value: "Ubundi bwoko bw'ibiryo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherFeedTypeTranslation",
                column: "Lang3",
                value: "Ubundi bwoko bw'ibiryo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherHealthCareTypeTranslation",
                column: "Lang3",
                value: "Ikindi kiguzi cyatanzwe ku kwita ku buzima bw'amatungo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherHousingExpenseTranslation",
                column: "Lang3",
                value: "Andi mafaranga yatanzwe ku kiraro");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncome",
                column: "Lang3",
                value: "Andi mafaranga yinjira");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncomeSaved",
                column: "Lang3",
                value: "Andi mafaranga yinjira yabitswe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncomeTitleTranslation",
                column: "Lang3",
                value: "Andi mafaranga yinjira");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncomeUpdated",
                column: "Lang3",
                value: "Amakaru ku yandi mafaranga yinjira yavuguruwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherLaboutTypeTranslation",
                column: "Lang3",
                value: "Ubundi bwoko bw'umurimo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherLoanProviderTranslation",
                column: "Lang3",
                value: "Undi watanze inguzanyo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherMedicineTypeTranslation",
                column: "Lang3",
                value: "Ikindi kiguzi cy'imiti");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherMembershipTypeTranslation",
                column: "Lang3",
                value: "Ubundi bwoko");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPigTypeTranslation",
                column: "Lang3",
                value: "Ikindi kigero cy'ingurube");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherProviderTranslation",
                column: "Lang3",
                value: "Indi serivisi yatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPurchasedFromTranslation",
                column: "Lang3",
                value: "Ahandi byaguriwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPurchasedUnitNotProvided",
                column: "Lang3",
                value: "Andi mafaranga yakoreshejwe ugura ntabwo yavuzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPurchasedWaterFromTranslation",
                column: "Lang3",
                value: "Aho byaguriwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherServiceTypeTranslation",
                column: "Lang3",
                value: "ubundi bwoko bwa serivisi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherSoldToTranslation",
                column: "Lang3",
                value: "Ahandi byagurishijwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherUnitNotProvided",
                column: "Lang3",
                value: "Ikindi gipimo ntabwo cyavuzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherUnitTypeTranslation",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherWaterPurchasedTranslation",
                column: "Lang3",
                value: "igipimo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherWhatForTranslation",
                column: "Lang3",
                value: "kuberiki");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherWhoProvidedServiceTranslation",
                column: "Lang3",
                value: "Ninde watanze iyo serivisi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ParishTranslation",
                column: "Lang3",
                value: "Paruwasi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PaymentType1",
                column: "Lang3",
                value: "ikibwana");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PaymentTypeTranslation",
                column: "Lang3",
                value: "ubwoko");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PaymentValueTranslation",
                column: "Lang3",
                value: "agaciro");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PhoneNumberTranslation",
                column: "Lang3",
                value: "nimero ya telefoni");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerAnimalTypeTranslation",
                column: "Lang3",
                value: "Hitamo icyiciro cy'ubukure bw'ingurube");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerClientTranslation",
                column: "Lang3",
                value: "Hitamo umukiliya");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerCountryTranslation",
                column: "Lang3",
                value: "hitamo igihugu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerCountyTranslation",
                column: "Lang3",
                value: "Hitamo Akarere");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerCurrencyTranslation",
                column: "Lang3",
                value: "hitamo ifaranga");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerDistrictTranslation",
                column: "Lang3",
                value: "Hitamo Umurenge");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerEquipmentTypeTranslation",
                column: "Lang3",
                value: "Hitamo ubwoko bw'igikoresho");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerFeedTypeTranslation",
                column: "Lang3",
                value: "Hitamo ubwoko bw'ibiryo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerGenderTranslation",
                column: "Lang3",
                value: "Hitamo igitsina");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerHealthCareTypeTranslation",
                column: "Lang3",
                value: "Hitamo ubury uyitaho");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerHousingExpenseTranslation",
                column: "Lang3",
                value: "Hitamo ugukoreshwa kw'amafaranga");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerLabourTypeTranslation",
                column: "Lang3",
                value: "Hitamo ubwoko bw'umurimo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerMedicineTypeTranslation",
                column: "Lang3",
                value: "Hitamo ubwoko bw'imiti");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerMembershipTypeTranslation",
                column: "Lang3",
                value: "Hitamo kuba uri umunyamuryango wa:");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerPaymentTypeTranslation",
                column: "Lang3",
                value: "Hitamo uburyo bwo kwishyura");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerPigTypeTranslation",
                column: "Lang3",
                value: "Hitamo icyiciro cy'ubukure bw'ingurube");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerProviderTranslation",
                column: "Lang3",
                value: "Hitamo utanga serivisi/ / ibikoresho/ibintu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerPurchasedFromTranslation",
                column: "Lang3",
                value: "Hitamo utanga serivisi/ / ibikoresho/ibintu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerServiceTypeTranslation",
                column: "Lang3",
                value: "Hitamo serivisi:");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerSoldToTranslation",
                column: "Lang3",
                value: "Hitamo umuguzi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerSubCountyTranslation",
                column: "Lang3",
                value: "Hitamo intara");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerUnitTranslation",
                column: "Lang3",
                value: "Igipimo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigSale",
                column: "Lang3",
                value: "kugurisha ingurube");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigSaleSaved",
                column: "Lang3",
                value: "Amakuru ku kugirisha ingurube yabitswe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigSaleTitleTranslation",
                column: "Lang3",
                value: "Ingurube zagurishijwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigSaleUpdated",
                column: "Lang3",
                value: "Amakuru ku kugirisha ingurube yavuguruwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType1",
                column: "Lang3",
                value: "ikibwana cyo kubyibushwa");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType2",
                column: "Lang3",
                value: "itungo ryo kubaga");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType3",
                column: "Lang3",
                value: "inyagazi/ imbyeyi yo korora");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType4",
                column: "Lang3",
                value: "isekurume/impfizi yo korora");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigTypeTranslation",
                column: "Lang3",
                value: "Ikigero cy'ingurube");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ProfitTranslation",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ProviderTranslation",
                column: "Lang3",
                value: "Ninde watanze iyo serivisi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ProvinceTranslation",
                column: "Lang3",
                value: "Intara");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PruchaseFromType1",
                column: "Lang3",
                value: "Veterineri cyangwa umujyanama ku buzima bw'amatungo wikorera ku giti cye");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PruchaseFromType2",
                column: "Lang3",
                value: "Veterineri cyangwa ushinzwe ubuzima bw'amatungo wa Leta");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PruchaseFromType3",
                column: "Lang3",
                value: "Ububiko bw'inyongeramusaruro zo mu buhinzi n'ubworozi ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedFrom",
                column: "Lang3",
                value: "Aho byaguriwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedFromTranslation",
                column: "Lang3",
                value: "Aho byaguriwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromTranslation",
                column: "Lang3",
                value: "Ninde wabiguze");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromType1",
                column: "Lang3",
                value: "Ugurisha amazi ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromType2",
                column: "Lang3",
                value: "Ikigo / sosiyete ikwirakwiza amazi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromType3",
                column: "Lang3",
                value: "Umuturanyi / Incuti");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RecordLabourCostSaved",
                column: "Lang3",
                value: "Amakuru ku kiguzi cy'umurimo yabitswe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RecordLabourUpdated",
                column: "Lang3",
                value: "Amakuru ku kiguzi cy'umurimo yavuguruwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationSuccessfulContinueTranslation",
                column: "Lang3",
                value: "Komeza");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationSuccessfulDescTranslation",
                column: "Lang3",
                value: "Ushobora noneho gutangira gukusanya no kubika amakuru");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationSuccessfulTitleTranslation",
                column: "Lang3",
                value: "konte yawe yashyizweho");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationTitleTranslation",
                column: "Lang3",
                value: "Kwiyandikisha");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationTranslation",
                column: "Lang3",
                value: "Kwiyandikisha");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReportingDuration",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Reproduction",
                column: "Lang3",
                value: "Imyororokere");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReproductionSaved",
                column: "Lang3",
                value: "Amakuru ku myororokere yabitswe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReproductionUpdated",
                column: "Lang3",
                value: "Amakuru ku myororokere yavuguruwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReproductiveTitleTranslation",
                column: "Lang3",
                value: "Imyororokere");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ResetTranslation",
                column: "Lang3",
                value: "gusubiramo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SalePriceTranslation",
                column: "Lang3",
                value: "Igiciro watangiyeho amatungo yose yagurishijwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SaleSaved",
                column: "Lang3",
                value: "Igurisha rya serivisi z'imyororokere ryabitswe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SaveHouseRecord",
                column: "Lang3",
                value: "Amakuru ku biraro yabitswe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SaveTranslation",
                column: "Lang3",
                value: "Bika amakuru");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SectorTranslation",
                column: "Lang3",
                value: "Umurenge");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SendDataUploadTimeLabel",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SendingData",
                column: "Lang3",
                value: "Kohereza amakuru");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ServiceType1",
                column: "Lang3",
                value: "Gutera intanga");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ServiceType2",
                column: "Lang3",
                value: "kubangurira ku mfizi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ServiceTypeTranslation",
                column: "Lang3",
                value: "Ubwoko bwa serivisi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SliderControlTranslation",
                column: "Lang3",
                value: "Niba ari ibiraro bishya byubatswe (kuruta kubibungabunga), tanga igihe cyo kubaho mumyaka +  agaciro gateganyijwe nyuma yo gukoreshwa / habariwemo ugukuganayuka kw'agaicro k'inyubako ka buri mwaka?");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToTranslation",
                column: "Lang3",
                value: "Byagurishijwe ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType1",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType2",
                column: "Lang3",
                value: "umucuruzi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType3",
                column: "Lang3",
                value: "ibagiro");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SomethingWrong",
                column: "Lang3",
                value: "Hari ikintu kitagenze neza, nyamuneka gerageza nyuma");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SowsServicedCostTranslation",
                column: "Lang3",
                value: "Igiteranyo cy'ikiguzi cyose cya serivisi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "StartTranslation",
                column: "Lang3",
                value: "Tangira");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SubCountyTranslation",
                column: "Lang3",
                value: "Sub-County");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SubCountyType1",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SubCountyType2",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SubCountyType3",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SubCountyType4",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SubCountyType5",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SubCountyType6",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SubCountyType7",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SubCountyType8",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartCostGroup",
                column: "Lang3",
                value: "Igiteranyo cy'ikiguzi cyose hamwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartIncomeGroup",
                column: "Lang3",
                value: "Amafaranga yose yinjiye");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartProfitLoss",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartTile",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryCostTranslation",
                column: "Lang3",
                value: "Ikiguzi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryIncomeTranslation",
                column: "Lang3",
                value: "Amafaranga yinjira");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryLabel",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryProfitLossTranslation",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryTableHeading",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Swahili",
                column: "Lang3",
                value: "Ikiswahili");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodNotProvided",
                column: "Lang3",
                value: "Igihe ntabwo cyatanzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodTranslation",
                column: "Lang3",
                value: "Igihe cyagenwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodUnitType1",
                column: "Lang3",
                value: "Amezi ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodUnitType2",
                column: "Lang3",
                value: "Imyaka");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAmountRepaidTranslation",
                column: "Lang3",
                value: "Igiteranyo cy'amafaranga yose yishuwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAnimalCosts",
                column: "Lang3",
                value: "Igiteranyo cy'ikiguzi cyose cy'amatungo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAnimalCostsTranslation",
                column: "Lang3",
                value: "Igiteranyo cy'ikiguzi cyose cy'amatungo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalCost",
                column: "Lang3",
                value: "Igiteranyo cy'ikiguzi cyose hamwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalCostAllUnits",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalCostTranslation",
                column: "Lang3",
                value: "Igiteranyo cy'ikiguzi cyose hamwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalIncomeTranslation",
                column: "Lang3",
                value: "Amafaranga yose yinjiye");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalProfit",
                column: "Lang3",
                value: "Igiteranyo cy'inyungu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TransportationCostTranslation",
                column: "Lang3",
                value: "Ikiguzi cy'ubwikorezi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TransportCostTrans",
                column: "Lang3",
                value: "Ikiguzi cy'ubwikorezi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "UnitTrans",
                column: "Lang3",
                value: "Igipimo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Updated",
                column: "Lang3",
                value: "Byavuguruwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "UploadDataTranslation",
                column: "Lang3",
                value: "Shyiraho ibisabwa");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "UserNameTranslation",
                column: "Lang3",
                value: "Izina ukoresha");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ViewReports",
                column: "Lang3",
                value: "Raporo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Viilage",
                column: "Lang3",
                value: "Umudugudu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Village",
                column: "Lang3",
                value: "Umudugudu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VillageTranslation",
                column: "Lang3",
                value: "Umudugudu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Vitnamese",
                column: "Lang3",
                value: "Ikinyaviyetinamu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VolumeSoldTranslation",
                column: "Lang3",
                value: "ingano yagurishijwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VolumeUnitType1",
                column: "Lang3",
                value: "Ibilo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VolumeUnitType2",
                column: "Lang3",
                value: "Igikapu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Wait",
                column: "Lang3",
                value: "Tegereza gato");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Water",
                column: "Lang3",
                value: "Amazi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterCostTitleTranslation",
                column: "Lang3",
                value: "Amazi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterCostUpdated",
                column: "Lang3",
                value: "Amakuru ku kiguzi cy'amazi yavuguruwe ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterDurationTranslation",
                column: "Lang3",
                value: "Igihe umara ukoresha ayo mazi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterPurchasedTranslation",
                column: "Lang3",
                value: "Amazi  yaguzwe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterPurchasedUnitType1",
                column: "Lang3",
                value: "litiro");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterPurchasedUnitType2",
                column: "Lang3",
                value: "metero kibe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterSaved",
                column: "Lang3",
                value: "Amakuru ku mazi yabitswe ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WatherDurationTranslation",
                column: "Lang3",
                value: "Igihe umara ukoresha ayo mazi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WebAuthDescTranslation",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WebAuthTitleTranslation",
                column: "Lang3",
                value: "Iyandikishe");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhereAreYouLocatedTranslation",
                column: "Lang3",
                value: "Ubarizwa / uherereye he?");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceTranslation",
                column: "Lang3",
                value: "Ninde watanze iyo serivisi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceType1",
                column: "Lang3",
                value: "utera intanga mu ngurube wikorera ku giti cye");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceType2",
                column: "Lang3",
                value: "utera intanga mu ngurube wa Leta");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceType3",
                column: "Lang3",
                value: "umworozi w'imfizi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "YearsExpectedTranslation",
                column: "Lang3",
                value: "Igihe giteganyijwe ikiraro kizamara (mu myaka)");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "YearTranslation",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "YourChangesSaved",
                column: "Lang3",
                value: "Impinduka zawe wakoze zabitswe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lang3",
                table: "Translations");
        }
    }
}
