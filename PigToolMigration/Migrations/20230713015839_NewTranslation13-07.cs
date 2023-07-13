using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class NewTranslation1307 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AcceptTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Kirizza ", "Chấp nhận", "Emera" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AddDataTile",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Yongereko obubaka ", "Nhập dữ liệu", "Ongeraho amakuru" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AdvanceTabLable",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Tweyongere mumaso", "Tạm ứng", "amafaranga atangwa mbere" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPaidTranslation",
                column: "Lang3",
                value: "Amafaranga yiyongera yishyuwe nyuma yo gukoresha akazi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AppRestartTranslation",
                columns: new[] { "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Changing the language requires the app to restart. Proceed?", "Okukyusa oluliimi, ejjakudayo etandiike buuto. Genda mumaaso", "Thay đổi ngôn ngữ yêu cầu khởi động lại ứng dụng. Bạn có muốn tiếp tục?", "Guhindura ururimi bisaba iyi aprikasiyo kongera gutangira. Komeza?" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BenchmarkingTabLable",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Gerageranya", "Điểm chuẩn", "igipimo ngenderwaho" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreakdownLabel",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Okumenya menyamu ensasanya", "Phân tích chi phí", "Uko ikiguzi cyabazwe" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ChangeLanguageTrasnlation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Kyusa oluliimi", "Thay đổi ngôn ngữ", "Hindura ururimi" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ChangeProfileTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Kyusamu ku bikukwatako", "Thay đổi thông tin hồ sơ", "Hindura amakuru y'umwirondoro" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ConfirmLogoutTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Kakaasa nti ofulumye omutimbangano", "Xác nhận đăng xuất", "Emeza gusohokamo" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Created",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Kitekeddwawo", "Được tạo ra", "Bishyizweho" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HomeTile",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Awatandikilwa", "Trang chủ", "Mu rugo" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "IncomeBreakdownLabel",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Okumenya menyamu, Enyingiza", "Cơ cấu thu nhập", "Uko ibyinjiye byabazwe" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LastUploadTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Obubaka obwasembayo' kuwerezebwa", "Lần tải lên dữ liệu cuối cùng", "Aho uherukira gushyiraho amakuru" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerBodyTranslation",
                columns: new[] { "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Privacy Policy  \n\nThis Privacy Policy describes our policies and procedures on the collection, use and disclosure of your information when you use the App and tells you about your privacy rights and how the law protects you. We use your Personal data to provide and improve the App. By using the App, you agree to the collection and use of information in accordance with this Privacy Policy. \n\nCollecting and Using Your Personal Data \n\nTypes of Data Collected \n\nPersonal Data  \n\nWhile using the App, you may be asked to provide us with certain personally identifiable information that can be used to contact or identify You. Personally identifiable information may include, but is not limited to: \n\nEmail address \n\nFirst name and last name \n\nGender \n\nPhone number \n\nAddress \n\nUsage Data \n\nUsage Data \n\nUsage Data may be collected automatically when using the App. Usage Data may include information such as your Device's Internet Protocol address (e.g. IP address), browser type, browser version, the type of mobile device you use, your mobile operating system, the pages of App that you visit, the time and date of your visit, the time spent on those pages, unique device identifiers and other diagnostic data. \n\nInformation Collected while Using the Application \n\nThe App is designed to determine the profit or loss of smallholder pig enterprises, with the user inputting their data relating to this.  This data includes but is not limited to: data on costs including on feed, labour, water, co-operative / group membership, animal purchase, equipment, healthcare, housing, reproduction, loan repaying and other; and data on income including sale of pigs, sale of manure, sale of breeding services, other income.   \n\nLocation data \n\nWe may collect, information regarding your location, with your prior permission. We use this information to provide features of the App, to improve and customize the App. The information may be uploaded to our servers and/or a Service Provider's server or it may be simply stored on your device. You can enable or disable access to this information at any time, through your Device settings. \n\nUse of Your Personal Data \n\nWe may use Personal Data for the following purposes: \n\nTo provide and maintain the App, including to monitor the usage of the App. \n\nTo manage Your Account: to manage your registration as a user of the App.  \n\nTo contact You: To contact you by email, telephone calls, SMS, or other equivalent forms of electronic communication, such as a mobile application's push notifications regarding updates or informative communications related to the functionalities, including security updates, when necessary or reasonable for their implementation. \n\nFor other purposes: We may use your information for other purposes, such as data analysis, identifying usage trends and to evaluate and improve the App and your experience. \n\nWe may share your personal information in the following situations: \n\nWith Affiliates: We may share your information with our affiliates, in which case we will require those affiliates to honor this Privacy Policy.  \n\nWith Your consent: We may disclose your personal information for any other purpose with your consent. \n\nRetention of Your Personal Data \n\nWe will retain your Personal Data only for as long as is necessary for the purposes set out in this Privacy Policy. We will retain and use your Personal Data to the extent necessary to comply with our legal obligations (for example, if we are required to retain your data to comply with applicable laws), resolve disputes, and enforce our legal agreements and policies. We will also retain Usage Data for internal analysis purposes. Usage Data is generally retained for a shorter period of time, except when this data is used to strengthen the security or to improve the functionality of the App, or we are legally obligated to retain this data for longer time periods. \n\nTransfer of Your Personal Data \n\nYour information, including Personal Data, is processed at our operating offices and in any other places where the parties involved in the processing are located. It means that this information may be transferred to — and maintained on — computers located outside of your county, country or other governmental jurisdiction where the data protection laws may differ than those from your jurisdiction. Your consent to this Privacy Policy followed by your submission of such information represents your agreement to that transfer. \n\nWe will take all steps reasonably necessary to ensure that your data is treated securely and in accordance with this Privacy Policy and no transfer of your Personal Data will take place to an organization or a country unless there are adequate controls in place including the security of Your data and other personal information. \n\nDelete Your Personal Data \n\nYou have the right to delete or request that we assist in deleting the Personal Data that we have collected about you. The App may give you the ability to delete certain information about you from within the App. You may update, amend, or delete your information at any time by signing into your Account and visiting the account settings section that allows you to manage your personal information. You may also contact us to request access to, correct, or delete any personal information that you have provided to us. Please note, however, that we may need to retain certain information when we have a legal obligation or lawful basis to do so. \n\nDisclosure of Your Personal Data \n\nLaw enforcement \n\nUnder certain circumstances, we may be required to disclose your Personal Data if required to do so by law or in response to valid requests by public authorities (e.g. a court or a government agency). \n\nWe  may disclose your Personal Data in the good faith belief that such action is necessary to: \n\nProtect and defend our rights  \n\nPrevent or investigate possible wrongdoing in connection with the App \n\nProtect the personal safety of Users of the App  \n\nProtect against legal liability \n\nSecurity of Your Personal Data \n\nThe security of your Personal Data is important to us, but remember that no method of transmission over the Internet, or method of electronic storage is 100% secure. While we strive to use commercially acceptable means to protect your Personal Data, we cannot guarantee its absolute security. \n\n \n\nUse of Information Collected when Using the Application \n\nInformation collected on using the App on costs and income related to the pig enterprise, which is entered by the user, is used to determine the profit or loss of the user’s pig enterprise.  This is reported back to the user in the App.  This data will remain on the users device until it is uploaded (through the upload function of the App), in which case it will be uploaded to a database maintained by the International Livestock Research Institute (ILRI).  The ILRI database will be accessible for use by ILRI scientists and collaborators who may use the data for analysis including, but not limited to, understanding the costs, incomes and profit associated with pig enterprises.  Reports or publications may be made from this analysis, but individual users will not be identified in any way, only summary information will be included in the reports or publications.  In some cases this information may be shared back to specific users via the App.  Users who do not wish for their data to be uploaded to the ILRI database and accessible by ILRI scientists and collaborators should not upload their data.  \n\nChildren's Privacy \n\n We do not knowingly collect personally identifiable information from anyone under the age of 18. If we become aware that we have collected Personal Data from anyone under the age of 18 without verification of parental consent, we shall take steps to remove that information from Our servers. \n\nChanges to this Privacy Policy \n\nWe may update Our Privacy Policy from time to time. We will notify you of any changes by posting the new Privacy Policy on this page. You are advised to review this Privacy Policy periodically for any changes. Changes to this Privacy Policy are effective when they are posted on this page. \n\nContact Us \n\nIf you have any questions about this Privacy Policy, You can contact us: \n\nBy email: kmarshall@cgiar.org ", "Privacy Policy  \n\nThis Privacy Policy describes our policies and procedures on the collection, use and disclosure of your information when you use the App and tells you about your privacy rights and how the law protects you. We use your Personal data to provide and improve the App. By using the App, you agree to the collection and use of information in accordance with this Privacy Policy. \n\nCollecting and Using Your Personal Data \n\nTypes of Data Collected \n\nPersonal Data  \n\nWhile using the App, you may be asked to provide us with certain personally identifiable information that can be used to contact or identify You. Personally identifiable information may include, but is not limited to: \n\nEmail address \n\nFirst name and last name \n\nGender \n\nPhone number \n\nAddress \n\nUsage Data \n\nUsage Data \n\nUsage Data may be collected automatically when using the App. Usage Data may include information such as your Device's Internet Protocol address (e.g. IP address), browser type, browser version, the type of mobile device you use, your mobile operating system, the pages of App that you visit, the time and date of your visit, the time spent on those pages, unique device identifiers and other diagnostic data. \n\nInformation Collected while Using the Application \n\nThe App is designed to determine the profit or loss of smallholder pig enterprises, with the user inputting their data relating to this.  This data includes but is not limited to: data on costs including on feed, labour, water, co-operative / group membership, animal purchase, equipment, healthcare, housing, reproduction, loan repaying and other; and data on income including sale of pigs, sale of manure, sale of breeding services, other income.   \n\nLocation data \n\nWe may collect, information regarding your location, with your prior permission. We use this information to provide features of the App, to improve and customize the App. The information may be uploaded to our servers and/or a Service Provider's server or it may be simply stored on your device. You can enable or disable access to this information at any time, through your Device settings. \n\nUse of Your Personal Data \n\nWe may use Personal Data for the following purposes: \n\nTo provide and maintain the App, including to monitor the usage of the App. \n\nTo manage Your Account: to manage your registration as a user of the App.  \n\nTo contact You: To contact you by email, telephone calls, SMS, or other equivalent forms of electronic communication, such as a mobile application's push notifications regarding updates or informative communications related to the functionalities, including security updates, when necessary or reasonable for their implementation. \n\nFor other purposes: We may use your information for other purposes, such as data analysis, identifying usage trends and to evaluate and improve the App and your experience. \n\nWe may share your personal information in the following situations: \n\nWith Affiliates: We may share your information with our affiliates, in which case we will require those affiliates to honor this Privacy Policy.  \n\nWith Your consent: We may disclose your personal information for any other purpose with your consent. \n\nRetention of Your Personal Data \n\nWe will retain your Personal Data only for as long as is necessary for the purposes set out in this Privacy Policy. We will retain and use your Personal Data to the extent necessary to comply with our legal obligations (for example, if we are required to retain your data to comply with applicable laws), resolve disputes, and enforce our legal agreements and policies. We will also retain Usage Data for internal analysis purposes. Usage Data is generally retained for a shorter period of time, except when this data is used to strengthen the security or to improve the functionality of the App, or we are legally obligated to retain this data for longer time periods. \n\nTransfer of Your Personal Data \n\nYour information, including Personal Data, is processed at our operating offices and in any other places where the parties involved in the processing are located. It means that this information may be transferred to — and maintained on — computers located outside of your county, country or other governmental jurisdiction where the data protection laws may differ than those from your jurisdiction. Your consent to this Privacy Policy followed by your submission of such information represents your agreement to that transfer. \n\nWe will take all steps reasonably necessary to ensure that your data is treated securely and in accordance with this Privacy Policy and no transfer of your Personal Data will take place to an organization or a country unless there are adequate controls in place including the security of Your data and other personal information. \n\nDelete Your Personal Data \n\nYou have the right to delete or request that we assist in deleting the Personal Data that we have collected about you. The App may give you the ability to delete certain information about you from within the App. You may update, amend, or delete your information at any time by signing into your Account and visiting the account settings section that allows you to manage your personal information. You may also contact us to request access to, correct, or delete any personal information that you have provided to us. Please note, however, that we may need to retain certain information when we have a legal obligation or lawful basis to do so. \n\nDisclosure of Your Personal Data \n\nLaw enforcement \n\nUnder certain circumstances, we may be required to disclose your Personal Data if required to do so by law or in response to valid requests by public authorities (e.g. a court or a government agency). \n\nWe  may disclose your Personal Data in the good faith belief that such action is necessary to: \n\nProtect and defend our rights  \n\nPrevent or investigate possible wrongdoing in connection with the App \n\nProtect the personal safety of Users of the App  \n\nProtect against legal liability \n\nSecurity of Your Personal Data \n\nThe security of your Personal Data is important to us, but remember that no method of transmission over the Internet, or method of electronic storage is 100% secure. While we strive to use commercially acceptable means to protect your Personal Data, we cannot guarantee its absolute security. \n\n \n\nUse of Information Collected when Using the Application \n\nInformation collected on using the App on costs and income related to the pig enterprise, which is entered by the user, is used to determine the profit or loss of the user’s pig enterprise.  This is reported back to the user in the App.  This data will remain on the users device until it is uploaded (through the upload function of the App), in which case it will be uploaded to a database maintained by the International Livestock Research Institute (ILRI).  The ILRI database will be accessible for use by ILRI scientists and collaborators who may use the data for analysis including, but not limited to, understanding the costs, incomes and profit associated with pig enterprises.  Reports or publications may be made from this analysis, but individual users will not be identified in any way, only summary information will be included in the reports or publications.  In some cases this information may be shared back to specific users via the App.  Users who do not wish for their data to be uploaded to the ILRI database and accessible by ILRI scientists and collaborators should not upload their data.  \n\nChildren's Privacy \n\n We do not knowingly collect personally identifiable information from anyone under the age of 18. If we become aware that we have collected Personal Data from anyone under the age of 18 without verification of parental consent, we shall take steps to remove that information from Our servers. \n\nChanges to this Privacy Policy \n\nWe may update Our Privacy Policy from time to time. We will notify you of any changes by posting the new Privacy Policy on this page. You are advised to review this Privacy Policy periodically for any changes. Changes to this Privacy Policy are effective when they are posted on this page. \n\nContact Us \n\nIf you have any questions about this Privacy Policy, You can contact us: \n\nBy email: kmarshall@cgiar.org ", "Privacy Policy  \n\nThis Privacy Policy describes our policies and procedures on the collection, use and disclosure of your information when you use the App and tells you about your privacy rights and how the law protects you. We use your Personal data to provide and improve the App. By using the App, you agree to the collection and use of information in accordance with this Privacy Policy. \n\nCollecting and Using Your Personal Data \n\nTypes of Data Collected \n\nPersonal Data  \n\nWhile using the App, you may be asked to provide us with certain personally identifiable information that can be used to contact or identify You. Personally identifiable information may include, but is not limited to: \n\nEmail address \n\nFirst name and last name \n\nGender \n\nPhone number \n\nAddress \n\nUsage Data \n\nUsage Data \n\nUsage Data may be collected automatically when using the App. Usage Data may include information such as your Device's Internet Protocol address (e.g. IP address), browser type, browser version, the type of mobile device you use, your mobile operating system, the pages of App that you visit, the time and date of your visit, the time spent on those pages, unique device identifiers and other diagnostic data. \n\nInformation Collected while Using the Application \n\nThe App is designed to determine the profit or loss of smallholder pig enterprises, with the user inputting their data relating to this.  This data includes but is not limited to: data on costs including on feed, labour, water, co-operative / group membership, animal purchase, equipment, healthcare, housing, reproduction, loan repaying and other; and data on income including sale of pigs, sale of manure, sale of breeding services, other income.   \n\nLocation data \n\nWe may collect, information regarding your location, with your prior permission. We use this information to provide features of the App, to improve and customize the App. The information may be uploaded to our servers and/or a Service Provider's server or it may be simply stored on your device. You can enable or disable access to this information at any time, through your Device settings. \n\nUse of Your Personal Data \n\nWe may use Personal Data for the following purposes: \n\nTo provide and maintain the App, including to monitor the usage of the App. \n\nTo manage Your Account: to manage your registration as a user of the App.  \n\nTo contact You: To contact you by email, telephone calls, SMS, or other equivalent forms of electronic communication, such as a mobile application's push notifications regarding updates or informative communications related to the functionalities, including security updates, when necessary or reasonable for their implementation. \n\nFor other purposes: We may use your information for other purposes, such as data analysis, identifying usage trends and to evaluate and improve the App and your experience. \n\nWe may share your personal information in the following situations: \n\nWith Affiliates: We may share your information with our affiliates, in which case we will require those affiliates to honor this Privacy Policy.  \n\nWith Your consent: We may disclose your personal information for any other purpose with your consent. \n\nRetention of Your Personal Data \n\nWe will retain your Personal Data only for as long as is necessary for the purposes set out in this Privacy Policy. We will retain and use your Personal Data to the extent necessary to comply with our legal obligations (for example, if we are required to retain your data to comply with applicable laws), resolve disputes, and enforce our legal agreements and policies. We will also retain Usage Data for internal analysis purposes. Usage Data is generally retained for a shorter period of time, except when this data is used to strengthen the security or to improve the functionality of the App, or we are legally obligated to retain this data for longer time periods. \n\nTransfer of Your Personal Data \n\nYour information, including Personal Data, is processed at our operating offices and in any other places where the parties involved in the processing are located. It means that this information may be transferred to — and maintained on — computers located outside of your county, country or other governmental jurisdiction where the data protection laws may differ than those from your jurisdiction. Your consent to this Privacy Policy followed by your submission of such information represents your agreement to that transfer. \n\nWe will take all steps reasonably necessary to ensure that your data is treated securely and in accordance with this Privacy Policy and no transfer of your Personal Data will take place to an organization or a country unless there are adequate controls in place including the security of Your data and other personal information. \n\nDelete Your Personal Data \n\nYou have the right to delete or request that we assist in deleting the Personal Data that we have collected about you. The App may give you the ability to delete certain information about you from within the App. You may update, amend, or delete your information at any time by signing into your Account and visiting the account settings section that allows you to manage your personal information. You may also contact us to request access to, correct, or delete any personal information that you have provided to us. Please note, however, that we may need to retain certain information when we have a legal obligation or lawful basis to do so. \n\nDisclosure of Your Personal Data \n\nLaw enforcement \n\nUnder certain circumstances, we may be required to disclose your Personal Data if required to do so by law or in response to valid requests by public authorities (e.g. a court or a government agency). \n\nWe  may disclose your Personal Data in the good faith belief that such action is necessary to: \n\nProtect and defend our rights  \n\nPrevent or investigate possible wrongdoing in connection with the App \n\nProtect the personal safety of Users of the App  \n\nProtect against legal liability \n\nSecurity of Your Personal Data \n\nThe security of your Personal Data is important to us, but remember that no method of transmission over the Internet, or method of electronic storage is 100% secure. While we strive to use commercially acceptable means to protect your Personal Data, we cannot guarantee its absolute security. \n\n \n\nUse of Information Collected when Using the Application \n\nInformation collected on using the App on costs and income related to the pig enterprise, which is entered by the user, is used to determine the profit or loss of the user’s pig enterprise.  This is reported back to the user in the App.  This data will remain on the users device until it is uploaded (through the upload function of the App), in which case it will be uploaded to a database maintained by the International Livestock Research Institute (ILRI).  The ILRI database will be accessible for use by ILRI scientists and collaborators who may use the data for analysis including, but not limited to, understanding the costs, incomes and profit associated with pig enterprises.  Reports or publications may be made from this analysis, but individual users will not be identified in any way, only summary information will be included in the reports or publications.  In some cases this information may be shared back to specific users via the App.  Users who do not wish for their data to be uploaded to the ILRI database and accessible by ILRI scientists and collaborators should not upload their data.  \n\nChildren's Privacy \n\n We do not knowingly collect personally identifiable information from anyone under the age of 18. If we become aware that we have collected Personal Data from anyone under the age of 18 without verification of parental consent, we shall take steps to remove that information from Our servers. \n\nChanges to this Privacy Policy \n\nWe may update Our Privacy Policy from time to time. We will notify you of any changes by posting the new Privacy Policy on this page. You are advised to review this Privacy Policy periodically for any changes. Changes to this Privacy Policy are effective when they are posted on this page. \n\nContact Us \n\nIf you have any questions about this Privacy Policy, You can contact us: \n\nBy email: kmarshall@cgiar.org ", "Privacy Policy  \n\nThis Privacy Policy describes our policies and procedures on the collection, use and disclosure of your information when you use the App and tells you about your privacy rights and how the law protects you. We use your Personal data to provide and improve the App. By using the App, you agree to the collection and use of information in accordance with this Privacy Policy. \n\nCollecting and Using Your Personal Data \n\nTypes of Data Collected \n\nPersonal Data  \n\nWhile using the App, you may be asked to provide us with certain personally identifiable information that can be used to contact or identify You. Personally identifiable information may include, but is not limited to: \n\nEmail address \n\nFirst name and last name \n\nGender \n\nPhone number \n\nAddress \n\nUsage Data \n\nUsage Data \n\nUsage Data may be collected automatically when using the App. Usage Data may include information such as your Device's Internet Protocol address (e.g. IP address), browser type, browser version, the type of mobile device you use, your mobile operating system, the pages of App that you visit, the time and date of your visit, the time spent on those pages, unique device identifiers and other diagnostic data. \n\nInformation Collected while Using the Application \n\nThe App is designed to determine the profit or loss of smallholder pig enterprises, with the user inputting their data relating to this.  This data includes but is not limited to: data on costs including on feed, labour, water, co-operative / group membership, animal purchase, equipment, healthcare, housing, reproduction, loan repaying and other; and data on income including sale of pigs, sale of manure, sale of breeding services, other income.   \n\nLocation data \n\nWe may collect, information regarding your location, with your prior permission. We use this information to provide features of the App, to improve and customize the App. The information may be uploaded to our servers and/or a Service Provider's server or it may be simply stored on your device. You can enable or disable access to this information at any time, through your Device settings. \n\nUse of Your Personal Data \n\nWe may use Personal Data for the following purposes: \n\nTo provide and maintain the App, including to monitor the usage of the App. \n\nTo manage Your Account: to manage your registration as a user of the App.  \n\nTo contact You: To contact you by email, telephone calls, SMS, or other equivalent forms of electronic communication, such as a mobile application's push notifications regarding updates or informative communications related to the functionalities, including security updates, when necessary or reasonable for their implementation. \n\nFor other purposes: We may use your information for other purposes, such as data analysis, identifying usage trends and to evaluate and improve the App and your experience. \n\nWe may share your personal information in the following situations: \n\nWith Affiliates: We may share your information with our affiliates, in which case we will require those affiliates to honor this Privacy Policy.  \n\nWith Your consent: We may disclose your personal information for any other purpose with your consent. \n\nRetention of Your Personal Data \n\nWe will retain your Personal Data only for as long as is necessary for the purposes set out in this Privacy Policy. We will retain and use your Personal Data to the extent necessary to comply with our legal obligations (for example, if we are required to retain your data to comply with applicable laws), resolve disputes, and enforce our legal agreements and policies. We will also retain Usage Data for internal analysis purposes. Usage Data is generally retained for a shorter period of time, except when this data is used to strengthen the security or to improve the functionality of the App, or we are legally obligated to retain this data for longer time periods. \n\nTransfer of Your Personal Data \n\nYour information, including Personal Data, is processed at our operating offices and in any other places where the parties involved in the processing are located. It means that this information may be transferred to — and maintained on — computers located outside of your county, country or other governmental jurisdiction where the data protection laws may differ than those from your jurisdiction. Your consent to this Privacy Policy followed by your submission of such information represents your agreement to that transfer. \n\nWe will take all steps reasonably necessary to ensure that your data is treated securely and in accordance with this Privacy Policy and no transfer of your Personal Data will take place to an organization or a country unless there are adequate controls in place including the security of Your data and other personal information. \n\nDelete Your Personal Data \n\nYou have the right to delete or request that we assist in deleting the Personal Data that we have collected about you. The App may give you the ability to delete certain information about you from within the App. You may update, amend, or delete your information at any time by signing into your Account and visiting the account settings section that allows you to manage your personal information. You may also contact us to request access to, correct, or delete any personal information that you have provided to us. Please note, however, that we may need to retain certain information when we have a legal obligation or lawful basis to do so. \n\nDisclosure of Your Personal Data \n\nLaw enforcement \n\nUnder certain circumstances, we may be required to disclose your Personal Data if required to do so by law or in response to valid requests by public authorities (e.g. a court or a government agency). \n\nWe  may disclose your Personal Data in the good faith belief that such action is necessary to: \n\nProtect and defend our rights  \n\nPrevent or investigate possible wrongdoing in connection with the App \n\nProtect the personal safety of Users of the App  \n\nProtect against legal liability \n\nSecurity of Your Personal Data \n\nThe security of your Personal Data is important to us, but remember that no method of transmission over the Internet, or method of electronic storage is 100% secure. While we strive to use commercially acceptable means to protect your Personal Data, we cannot guarantee its absolute security. \n\n \n\nUse of Information Collected when Using the Application \n\nInformation collected on using the App on costs and income related to the pig enterprise, which is entered by the user, is used to determine the profit or loss of the user’s pig enterprise.  This is reported back to the user in the App.  This data will remain on the users device until it is uploaded (through the upload function of the App), in which case it will be uploaded to a database maintained by the International Livestock Research Institute (ILRI).  The ILRI database will be accessible for use by ILRI scientists and collaborators who may use the data for analysis including, but not limited to, understanding the costs, incomes and profit associated with pig enterprises.  Reports or publications may be made from this analysis, but individual users will not be identified in any way, only summary information will be included in the reports or publications.  In some cases this information may be shared back to specific users via the App.  Users who do not wish for their data to be uploaded to the ILRI database and accessible by ILRI scientists and collaborators should not upload their data.  \n\nChildren's Privacy \n\n We do not knowingly collect personally identifiable information from anyone under the age of 18. If we become aware that we have collected Personal Data from anyone under the age of 18 without verification of parental consent, we shall take steps to remove that information from Our servers. \n\nChanges to this Privacy Policy \n\nWe may update Our Privacy Policy from time to time. We will notify you of any changes by posting the new Privacy Policy on this page. You are advised to review this Privacy Policy periodically for any changes. Changes to this Privacy Policy are effective when they are posted on this page. \n\nContact Us \n\nIf you have any questions about this Privacy Policy, You can contact us: \n\nBy email: kmarshall@cgiar.org " });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanDurationTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Ebanja lyakumala bangakyi", "Thời hạn cho vay", "Igihe inguzanyo izamara" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LogoutTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Vva kumutimbagano", "Đăng xuất", "Sohokamo" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LogoutWarningTransaltion",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Nga ofuluma obubaka byonna obu tateereddwa mu kiire bujja kubula era obubaka obuli ku kyuma bujja kuggyibwawo", "Bằng cách đăng xuất, mọi dữ liệu không được gửi lên đám mây sẽ bị mất và dữ liệu hiện tại trên thiết bị sẽ bị xóa", "Mukwemeza gusohoka amakuru yose atohererejwe ku mashini ikusanya amakuru azabura kandi n'aya makuru ari kuri iyi telefoni nayo aravanwaho" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LossTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Okufirizibw'amagoba", "Lỗ", "igihombo" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManageDataTile",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "labirira obubaka", "Quản lý", "gucunga" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureAmountRecievedTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Ssente ezivudde mu bijimusa byoona ebitundidwa", "Giá bán cho tất cả các loại phân bón ", "Igiciro cy'ifumbire yose yagurishijwe" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType5",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Edagala elita obuwuka obutalabika", "Chất khử trùng", "umuti wica udukoko" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipDurationTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Ebbanga ly’obwammemba", "Thời hạn thành viên", "Igihe umaze uri umunyamuryango" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipUpdated",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Obwa memba bwo bu gatidwako", "Tư cách thành viên được cập nhật", "Amakuru arebana n'ubunyamuryango yavuguruwe" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MonthTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Omwezi", "Năm", "Ukwezi" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Nedda ", "Không", "Oya" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAnimalTypeTranslation",
                columns: new[] { "Lang2", "Lang3" },
                values: new object[] { "Các loại vật nuôi khác", "Ubundi bwoko bw'itungo" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherUnitTypeTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Ekika kyikipimo ekilala", "Loại đơn vị khác", "Ubundi bwoko bw'igipimo" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ProfitTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Amagoba", "Lãi", "Inyungu" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReportingDuration",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Ebanga ly'okukola'lipoota", "Khoảng thời gian báo cáo", "igihe cyo gutanga raporo" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReportsTile",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Alipoota", "Các báo cáo", "raporo" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SendDataUploadTimeLabel",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "ebintu ebipya okuva lwe  wasembayo okuteekeko", "Các cập nhật mới kể từ lần tải lên gần đây nhất tại:", "ibintu bishya kuva aho uheruka kohereza kuri:" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SettingsPageTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Ensengeka", "Cài đặt", "Igenamiterere" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SettingsTile",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Ensengeka", "Cài đặt", "Igenamiterere" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SliderControlTranslation",
                column: "Lang1",
                value: "Enyumba, enawangala myaka emaka ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType1",
                columns: new[] { "Lang2", "Lang3" },
                values: new object[] { "Nông dân khác", "Undi mworozi" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartCostGroup",
                column: "Lang1",
                value: "Omugatte gw’ensimbi zosassanya");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartIncomeGroup",
                column: "Lang1",
                value: "Omugatte gwa ssente zoyingizza");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartProfitLoss",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Omugatte gw'a magoba oba okufirizibwa", "Tổng Lãi/Lỗ", "Inyugu yose/Igihombo cyose hamwe" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartTile",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Ekiseera, kyomazze nga ofun'amagoba, oba nga ofiirizibwa", "Tổng lãi / lỗ trong kỳ", "Igihe Inyugu yose/Igihombo cyose hamwe byabariweho" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryCostTranslation",
                column: "Lang1",
                value: "Ensasanya ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryIncomeTranslation",
                column: "Lang1",
                value: "Ssente zoyingiza");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryLabel",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Okuwumbako/mubumpimpi", "Tóm tắt", "incamake" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryProfitLossTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Amagoba oba okufirizibwa", "Lãi/Lỗ", "Inyungu/igihombo" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryTableHeading",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Amagoba oba okufurizibwa mu' mwezi", "Lãi/lỗ theo tháng", "Inyungu/igihombo ku kwezi" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SureTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Okikakasa", "Bạn có chắc không?", "Urabyemeza neza?" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAnimalCostsTranslation",
                column: "Lang1",
                value: "Omugatte gwensasanya kubisolo byona");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalCostAllUnits",
                columns: new[] { "Lang1", "Lang3" },
                values: new object[] { "Omugatte ogwensasanya yona ", "Igiteranyo cy'ikiguzi cyose (mu bipimo byose)" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "UploadTile",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Sindika kumutimbagano", "Tải lên", "kongeraho" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ViewTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Byetegereze", "Xem", "Reba" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WebAuthDescTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Pig Profit App  yakakasibwa aba Google, okuba nti ekuma ebikukwatako nga tewali mulala yenn'asobola kubifuna                            ", "Ứng dụng Pig Profit xác thực với Google để xác thực tài khoản của bạn một cách an toàn và giữ an toàn cho dữ liệu của bạn.", "Iki gikoresho gikoreshwa mu kubara inyungu mu bworozi bw'ingurube cyemeza hamwe na Google kugirango yemeze neza konte yawe kandi ikomeze kurinda amakuru yawe neza." });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "YearTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Omwaka", "Tháng", "Umwaka" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "YesTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Yee", "Có", "Yego" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AcceptTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AddDataTile",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AdvanceTabLable",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPaidTranslation",
                column: "Lang3",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AppRestartTranslation",
                columns: new[] { "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Changing the language requires the app to restart.Proceed?", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BenchmarkingTabLable",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreakdownLabel",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ChangeLanguageTrasnlation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ChangeProfileTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ConfirmLogoutTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Created",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HomeTile",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "IncomeBreakdownLabel",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LastUploadTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerBodyTranslation",
                columns: new[] { "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Terms and Conditions Last updated: April 04, 2023 \n\nPlease read these terms and conditions carefully before using the Pig Profit  (App). \n\nBy accessing or using the App you agree to be bound by these Terms and Conditions and our Privacy Policy. If you disagree with any part of these Terms and Conditions then you may not access the App. Please read our Privacy Policy carefully before using the App. \n\nYou are responsible for safeguarding the password that you use to access the App and for any activities or actions under your password. You may choose to only upload the data to the App in your device or  additionally upload it to our database for further analysis and reporting. By uploading your data to our database, you grant us the right and license to use, modify, analyze  and make further use of the data for reporting purposes. \n\nYou understand that the accuracy of any reports generated by the App depends on the reliability of the content that you upload or provide.  \n\nYou represent and warrant that: (i) the data is yours or you have the right to use it and grant us the rights and license as provided in these Terms, and (ii) the posting of your data on the App does not violate the privacy rights, publicity rights, copyrights, contract rights or any other rights of any person. We are not responsible for the content of the App's users. You expressly understand and agree that you are solely responsible for the data and for all activity that occurs under your account, whether done so by you or any third person using your account. \n\nYou may not transmit any content that is unlawful, offensive, upsetting, intended to disgust, threatening, libelous, defamatory, obscene or otherwise objectionable.  \n\nIn no event shall we be liable for any special, incidental, indirect, or consequential damages whatsoever. The App is provided to you \"AS IS\" and \"AS AVAILABLE\" without warranty of any kind. We expressly disclaim all warranties, whether express, implied, statutory or otherwise, with respect to the App.  \n\nWe do not make any representation or warranty of any kind, express or implied: (i) as to the operation or availability of the App; (ii) that the App will be uninterrupted or error-free; (iii) as to the accuracy, reliability, or currency of any information or content provided through the Tool; or (iv) that the Tool, its servers, the content, or e-mails are free of viruses or other harmful components. \n\nThe laws of the Republic of Kenya shall govern these Terms and Conditions. Your use of the App may also be subject to other local, state, national, or international laws. If you have any concern or dispute about the App you agree to first try to resolve the dispute informally by contacting us. \n\nWe reserve the right to modify or replace these Terms at any time. By continuing to access or use the App after those revisions become effective, you agree to be bound by the revised terms. If you do not agree to the new terms, in whole or in part, please stop using the App. ", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanDurationTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LogoutTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LogoutWarningTransaltion",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LossTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManageDataTile",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureAmountRecievedTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType5",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipDurationTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipUpdated",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MonthTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAnimalTypeTranslation",
                columns: new[] { "Lang2", "Lang3" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherUnitTypeTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ProfitTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReportingDuration",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReportsTile",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SendDataUploadTimeLabel",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SettingsPageTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SettingsTile",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SliderControlTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType1",
                columns: new[] { "Lang2", "Lang3" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartCostGroup",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartIncomeGroup",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartProfitLoss",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartTile",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryCostTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryIncomeTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryLabel",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryProfitLossTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryTableHeading",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SureTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAnimalCostsTranslation",
                column: "Lang1",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalCostAllUnits",
                columns: new[] { "Lang1", "Lang3" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "UploadTile",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ViewTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WebAuthDescTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "YearTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "YesTranslation",
                columns: new[] { "Lang1", "Lang2", "Lang3" },
                values: new object[] { "", "", "" });
        }
    }
}
