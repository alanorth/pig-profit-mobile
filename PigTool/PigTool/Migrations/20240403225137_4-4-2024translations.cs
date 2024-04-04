using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class _442024translations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceSale",
                column: "English",
                value: "Sale of Breeding Services");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LogoutWarningTransaltion",
                columns: new[] { "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "Logout and delete all data", "Wo fuluma osazaamu data yonna", "Đăng xuất và xóa tất cả dữ liệu", "Injira kandi usibe amakuru yose" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureSale",
                column: "English",
                value: "Sale of Manure");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostEvent",
                column: "English",
                value: "Other Cost");

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP19", "Delete Your Personal Data ", "Delete Your Personal Data ", "Delete Your Personal Data ", "Delete Your Personal Data " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP20", "You have the right to delete or request that we assist in deleting the Personal Data that we have collected about you. The App may give you the ability to delete certain information about you from within the App. You may update, amend, or delete your information at any time by signing into your Account and visiting the account settings section that allows you to manage your personal information. You may also contact us to request access to, correct, or delete any personal information that you have provided to us. Please note, however, that we may need to retain certain information when we have a legal obligation or lawful basis to do so. ", "You have the right to delete or request that we assist in deleting the Personal Data that we have collected about you. The App may give you the ability to delete certain information about you from within the App. You may update, amend, or delete your information at any time by signing into your Account and visiting the account settings section that allows you to manage your personal information. You may also contact us to request access to, correct, or delete any personal information that you have provided to us. Please note, however, that we may need to retain certain information when we have a legal obligation or lawful basis to do so. ", "You have the right to delete or request that we assist in deleting the Personal Data that we have collected about you. The App may give you the ability to delete certain information about you from within the App. You may update, amend, or delete your information at any time by signing into your Account and visiting the account settings section that allows you to manage your personal information. You may also contact us to request access to, correct, or delete any personal information that you have provided to us. Please note, however, that we may need to retain certain information when we have a legal obligation or lawful basis to do so. ", "You have the right to delete or request that we assist in deleting the Personal Data that we have collected about you. The App may give you the ability to delete certain information about you from within the App. You may update, amend, or delete your information at any time by signing into your Account and visiting the account settings section that allows you to manage your personal information. You may also contact us to request access to, correct, or delete any personal information that you have provided to us. Please note, however, that we may need to retain certain information when we have a legal obligation or lawful basis to do so. " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP21", "Disclosure of Your Personal Data ", "Disclosure of Your Personal Data ", "Disclosure of Your Personal Data ", "Disclosure of Your Personal Data " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP22", "Law enforcement ", "Law enforcement ", "Law enforcement ", "Law enforcement " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP23", "Under certain circumstances, we may be required to disclose your Personal Data if required to do so by law or in response to valid requests by public authorities (e.g. a court or a government agency). \n\nWe  may disclose your Personal Data in the good faith belief that such action is necessary to: \n\nProtect and defend our rights  \n\nPrevent or investigate possible wrongdoing in connection with the App \n\nProtect the personal safety of Users of the App  \n\nProtect against legal liability ", "Under certain circumstances, we may be required to disclose your Personal Data if required to do so by law or in response to valid requests by public authorities (e.g. a court or a government agency). \n\nWe  may disclose your Personal Data in the good faith belief that such action is necessary to: \n\nProtect and defend our rights  \n\nPrevent or investigate possible wrongdoing in connection with the App \n\nProtect the personal safety of Users of the App  \n\nProtect against legal liability ", "Under certain circumstances, we may be required to disclose your Personal Data if required to do so by law or in response to valid requests by public authorities (e.g. a court or a government agency). \n\nWe  may disclose your Personal Data in the good faith belief that such action is necessary to: \n\nProtect and defend our rights  \n\nPrevent or investigate possible wrongdoing in connection with the App \n\nProtect the personal safety of Users of the App  \n\nProtect against legal liability ", "Under certain circumstances, we may be required to disclose your Personal Data if required to do so by law or in response to valid requests by public authorities (e.g. a court or a government agency). \n\nWe  may disclose your Personal Data in the good faith belief that such action is necessary to: \n\nProtect and defend our rights  \n\nPrevent or investigate possible wrongdoing in connection with the App \n\nProtect the personal safety of Users of the App  \n\nProtect against legal liability " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP24", "Security of Your Personal Data", "Security of Your Personal Data", "Security of Your Personal Data", "Security of Your Personal Data" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP25", "The security of your Personal Data is important to us, but remember that no method of transmission over the Internet, or method of electronic storage is 100% secure. While we strive to use commercially acceptable means to protect your Personal Data, we cannot guarantee its absolute security. ", "The security of your Personal Data is important to us, but remember that no method of transmission over the Internet, or method of electronic storage is 100% secure. While we strive to use commercially acceptable means to protect your Personal Data, we cannot guarantee its absolute security. ", "The security of your Personal Data is important to us, but remember that no method of transmission over the Internet, or method of electronic storage is 100% secure. While we strive to use commercially acceptable means to protect your Personal Data, we cannot guarantee its absolute security. ", "The security of your Personal Data is important to us, but remember that no method of transmission over the Internet, or method of electronic storage is 100% secure. While we strive to use commercially acceptable means to protect your Personal Data, we cannot guarantee its absolute security. " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP26", "Use of Information Collected when Using the Application", "Use of Information Collected when Using the Application", "Use of Information Collected when Using the Application", "Use of Information Collected when Using the Application" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP28", "Children's Privacy ", "Children's Privacy ", "Children's Privacy ", "Children's Privacy " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP29", " We do not knowingly collect personally identifiable information from anyone under the age of 18. If we become aware that we have collected Personal Data from anyone under the age of 18 without verification of parental consent, we shall take steps to remove that information from Our servers. ", " We do not knowingly collect personally identifiable information from anyone under the age of 18. If we become aware that we have collected Personal Data from anyone under the age of 18 without verification of parental consent, we shall take steps to remove that information from Our servers. ", " We do not knowingly collect personally identifiable information from anyone under the age of 18. If we become aware that we have collected Personal Data from anyone under the age of 18 without verification of parental consent, we shall take steps to remove that information from Our servers. ", " We do not knowingly collect personally identifiable information from anyone under the age of 18. If we become aware that we have collected Personal Data from anyone under the age of 18 without verification of parental consent, we shall take steps to remove that information from Our servers. " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP30", "Changes to this Privacy Policy ", "Changes to this Privacy Policy ", "Changes to this Privacy Policy ", "Changes to this Privacy Policy " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP31", "We may update Our Privacy Policy from time to time. We will notify you of any changes by posting the new Privacy Policy on this page. You are advised to review this Privacy Policy periodically for any changes. Changes to this Privacy Policy are effective when they are posted on this page. ", "We may update Our Privacy Policy from time to time. We will notify you of any changes by posting the new Privacy Policy on this page. You are advised to review this Privacy Policy periodically for any changes. Changes to this Privacy Policy are effective when they are posted on this page. ", "We may update Our Privacy Policy from time to time. We will notify you of any changes by posting the new Privacy Policy on this page. You are advised to review this Privacy Policy periodically for any changes. Changes to this Privacy Policy are effective when they are posted on this page. ", "We may update Our Privacy Policy from time to time. We will notify you of any changes by posting the new Privacy Policy on this page. You are advised to review this Privacy Policy periodically for any changes. Changes to this Privacy Policy are effective when they are posted on this page. " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP32", "Contact Us ", "Contact Us ", "Contact Us ", "Contact Us " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP33", "If you have any questions about this Privacy Policy, You can contact us: \n\nBy email: kmarshall@cgiar.org ", "If you have any questions about this Privacy Policy, You can contact us: \n\nBy email: kmarshall@cgiar.org ", "If you have any questions about this Privacy Policy, You can contact us: \n\nBy email: kmarshall@cgiar.org ", "If you have any questions about this Privacy Policy, You can contact us: \n\nBy email: kmarshall@cgiar.org " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP18", "We will take all steps reasonably necessary to ensure that your data is treated securely and in accordance with this Privacy Policy and no transfer of your Personal Data will take place to an organization or a country unless there are adequate controls in place including the security of Your data and other personal information. ", "We will take all steps reasonably necessary to ensure that your data is treated securely and in accordance with this Privacy Policy and no transfer of your Personal Data will take place to an organization or a country unless there are adequate controls in place including the security of Your data and other personal information. ", "We will take all steps reasonably necessary to ensure that your data is treated securely and in accordance with this Privacy Policy and no transfer of your Personal Data will take place to an organization or a country unless there are adequate controls in place including the security of Your data and other personal information. ", "We will take all steps reasonably necessary to ensure that your data is treated securely and in accordance with this Privacy Policy and no transfer of your Personal Data will take place to an organization or a country unless there are adequate controls in place including the security of Your data and other personal information. " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP27", "Information collected on using the App on costs and income related to the pig enterprise, which is entered by the user, is used to determine the profit or loss of the user’s pig enterprise.  This is reported back to the user in the App.  This data will remain on the users device until it is uploaded (through the upload function of the App), in which case it will be uploaded to a database maintained by the International Livestock Research Institute (ILRI).  The ILRI database will be accessible for use by ILRI scientists and collaborators who may use the data for analysis including, but not limited to, understanding the costs, incomes and profit associated with pig enterprises.  Reports or publications may be made from this analysis, but individual users will not be identified in any way, only summary information will be included in the reports or publications.  In some cases this information may be shared back to specific users via the App.  Users who do not wish for their data to be uploaded to the ILRI database and accessible by ILRI scientists and collaborators should not upload their data.  ", "Information collected on using the App on costs and income related to the pig enterprise, which is entered by the user, is used to determine the profit or loss of the user’s pig enterprise.  This is reported back to the user in the App.  This data will remain on the users device until it is uploaded (through the upload function of the App), in which case it will be uploaded to a database maintained by the International Livestock Research Institute (ILRI).  The ILRI database will be accessible for use by ILRI scientists and collaborators who may use the data for analysis including, but not limited to, understanding the costs, incomes and profit associated with pig enterprises.  Reports or publications may be made from this analysis, but individual users will not be identified in any way, only summary information will be included in the reports or publications.  In some cases this information may be shared back to specific users via the App.  Users who do not wish for their data to be uploaded to the ILRI database and accessible by ILRI scientists and collaborators should not upload their data.  ", "Information collected on using the App on costs and income related to the pig enterprise, which is entered by the user, is used to determine the profit or loss of the user’s pig enterprise.  This is reported back to the user in the App.  This data will remain on the users device until it is uploaded (through the upload function of the App), in which case it will be uploaded to a database maintained by the International Livestock Research Institute (ILRI).  The ILRI database will be accessible for use by ILRI scientists and collaborators who may use the data for analysis including, but not limited to, understanding the costs, incomes and profit associated with pig enterprises.  Reports or publications may be made from this analysis, but individual users will not be identified in any way, only summary information will be included in the reports or publications.  In some cases this information may be shared back to specific users via the App.  Users who do not wish for their data to be uploaded to the ILRI database and accessible by ILRI scientists and collaborators should not upload their data.  ", "Information collected on using the App on costs and income related to the pig enterprise, which is entered by the user, is used to determine the profit or loss of the user’s pig enterprise.  This is reported back to the user in the App.  This data will remain on the users device until it is uploaded (through the upload function of the App), in which case it will be uploaded to a database maintained by the International Livestock Research Institute (ILRI).  The ILRI database will be accessible for use by ILRI scientists and collaborators who may use the data for analysis including, but not limited to, understanding the costs, incomes and profit associated with pig enterprises.  Reports or publications may be made from this analysis, but individual users will not be identified in any way, only summary information will be included in the reports or publications.  In some cases this information may be shared back to specific users via the App.  Users who do not wish for their data to be uploaded to the ILRI database and accessible by ILRI scientists and collaborators should not upload their data.  " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP17", "Your information, including Personal Data, is processed at our operating offices and in any other places where the parties involved in the processing are located. It means that this information may be transferred to — and maintained on — computers located outside of your county, country or other governmental jurisdiction where the data protection laws may differ than those from your jurisdiction. Your consent to this Privacy Policy followed by your submission of such information represents your agreement to that transfer. ", "Your information, including Personal Data, is processed at our operating offices and in any other places where the parties involved in the processing are located. It means that this information may be transferred to — and maintained on — computers located outside of your county, country or other governmental jurisdiction where the data protection laws may differ than those from your jurisdiction. Your consent to this Privacy Policy followed by your submission of such information represents your agreement to that transfer. ", "Your information, including Personal Data, is processed at our operating offices and in any other places where the parties involved in the processing are located. It means that this information may be transferred to — and maintained on — computers located outside of your county, country or other governmental jurisdiction where the data protection laws may differ than those from your jurisdiction. Your consent to this Privacy Policy followed by your submission of such information represents your agreement to that transfer. ", "Your information, including Personal Data, is processed at our operating offices and in any other places where the parties involved in the processing are located. It means that this information may be transferred to — and maintained on — computers located outside of your county, country or other governmental jurisdiction where the data protection laws may differ than those from your jurisdiction. Your consent to this Privacy Policy followed by your submission of such information represents your agreement to that transfer. " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP15", "We will retain your Personal Data only for as long as is necessary for the purposes set out in this Privacy Policy. We will retain and use your Personal Data to the extent necessary to comply with our legal obligations (for example, if we are required to retain your data to comply with applicable laws), resolve disputes, and enforce our legal agreements and policies. We will also retain Usage Data for internal analysis purposes. Usage Data is generally retained for a shorter period of time, except when this data is used to strengthen the security or to improve the functionality of the App, or we are legally obligated to retain this data for longer time periods. ", "We will retain your Personal Data only for as long as is necessary for the purposes set out in this Privacy Policy. We will retain and use your Personal Data to the extent necessary to comply with our legal obligations (for example, if we are required to retain your data to comply with applicable laws), resolve disputes, and enforce our legal agreements and policies. We will also retain Usage Data for internal analysis purposes. Usage Data is generally retained for a shorter period of time, except when this data is used to strengthen the security or to improve the functionality of the App, or we are legally obligated to retain this data for longer time periods. ", "We will retain your Personal Data only for as long as is necessary for the purposes set out in this Privacy Policy. We will retain and use your Personal Data to the extent necessary to comply with our legal obligations (for example, if we are required to retain your data to comply with applicable laws), resolve disputes, and enforce our legal agreements and policies. We will also retain Usage Data for internal analysis purposes. Usage Data is generally retained for a shorter period of time, except when this data is used to strengthen the security or to improve the functionality of the App, or we are legally obligated to retain this data for longer time periods. ", "We will retain your Personal Data only for as long as is necessary for the purposes set out in this Privacy Policy. We will retain and use your Personal Data to the extent necessary to comply with our legal obligations (for example, if we are required to retain your data to comply with applicable laws), resolve disputes, and enforce our legal agreements and policies. We will also retain Usage Data for internal analysis purposes. Usage Data is generally retained for a shorter period of time, except when this data is used to strengthen the security or to improve the functionality of the App, or we are legally obligated to retain this data for longer time periods. " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "GroupMembershipShortTranslation", "Group Membership", "Obwammemba bw’ekibiina", "Thành viên tổ/nhóm", "Itsinda ubarizwamo" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "TermsAndCondtions", "Terms and Conditions Last updated: April 04, 2023\n\nPlease read these terms and conditions carefully before using the Pig Profit (App).\n\nBy accessing or using the App you agree to be bound by these Terms and Conditions and our Privacy Policy. If you disagree with any part of these Terms and Conditions then you may not access the App. Please read our Privacy Policy carefully before using the App.\n\nYou are responsible for safeguarding the password that you use to access the App and for any activities or actions under your password. You may choose to only upload the data to the App in your device or additionally upload it to our database for further analysis and reporting. By uploading your data to our database, you grant us the right and license to use, modify, analyze and make further use of the data for reporting purposes.\n\nYou understand that the accuracy of any reports generated by the App depends on the reliability of the content that you upload or provide.\n\nYou represent and warrant that: (i) the data is yours or you have the right to use it and grant us the rights and license as provided in these Terms, and (ii) the posting of your data on the App does not violate the privacy rights, publicity rights, copyrights, contract rights or any other rights of any person. We are not responsible for the content of the App's users. You expressly understand and agree that you are solely responsible for the data and for all activity that occurs under your account, whether done so by you or any third person using your account.\n\nYou may not transmit any content that is unlawful, offensive, upsetting, intended to disgust, threatening, libelous, defamatory, obscene or otherwise objectionable.\n\nIn no event shall we be liable for any special, incidental, indirect, or consequential damages whatsoever. The App is provided to you \"AS IS\" and \"AS AVAILABLE\" without warranty of any kind. We expressly disclaim all warranties, whether express, implied, statutory or otherwise, with respect to the App.\n\nWe do not make any representation or warranty of any kind, express or implied: (i) as to the operation or availability of the App; (ii) that the App will be uninterrupted or error-free; (iii) as to the accuracy, reliability, or currency of any information or content provided through the Tool; or (iv) that the Tool, its servers, the content, or e-mails are free of viruses or other harmful components.\n\nThe laws of the Republic of Kenya shall govern these Terms and Conditions. Your use of the App may also be subject to other local, state, national, or international laws. If you have any concern or dispute about the App you agree to first try to resolve the dispute informally by contacting us.\n\nWe reserve the right to modify or replace these Terms at any time. By continuing to access or use the App after those revisions become effective, you agree to be bound by the revised terms. If you do not agree to the new terms, in whole or in part, please stop using the App.", "Terms and Conditions Last updated: April 04, 2023\n\nPlease read these terms and conditions carefully before using the Pig Profit (App).\n\nBy accessing or using the App you agree to be bound by these Terms and Conditions and our Privacy Policy. If you disagree with any part of these Terms and Conditions then you may not access the App. Please read our Privacy Policy carefully before using the App.\n\nYou are responsible for safeguarding the password that you use to access the App and for any activities or actions under your password. You may choose to only upload the data to the App in your device or additionally upload it to our database for further analysis and reporting. By uploading your data to our database, you grant us the right and license to use, modify, analyze and make further use of the data for reporting purposes.\n\nYou understand that the accuracy of any reports generated by the App depends on the reliability of the content that you upload or provide.\n\nYou represent and warrant that: (i) the data is yours or you have the right to use it and grant us the rights and license as provided in these Terms, and (ii) the posting of your data on the App does not violate the privacy rights, publicity rights, copyrights, contract rights or any other rights of any person. We are not responsible for the content of the App's users. You expressly understand and agree that you are solely responsible for the data and for all activity that occurs under your account, whether done so by you or any third person using your account.\n\nYou may not transmit any content that is unlawful, offensive, upsetting, intended to disgust, threatening, libelous, defamatory, obscene or otherwise objectionable.\n\nIn no event shall we be liable for any special, incidental, indirect, or consequential damages whatsoever. The App is provided to you \"AS IS\" and \"AS AVAILABLE\" without warranty of any kind. We expressly disclaim all warranties, whether express, implied, statutory or otherwise, with respect to the App.\n\nWe do not make any representation or warranty of any kind, express or implied: (i) as to the operation or availability of the App; (ii) that the App will be uninterrupted or error-free; (iii) as to the accuracy, reliability, or currency of any information or content provided through the Tool; or (iv) that the Tool, its servers, the content, or e-mails are free of viruses or other harmful components.\n\nThe laws of the Republic of Kenya shall govern these Terms and Conditions. Your use of the App may also be subject to other local, state, national, or international laws. If you have any concern or dispute about the App you agree to first try to resolve the dispute informally by contacting us.\n\nWe reserve the right to modify or replace these Terms at any time. By continuing to access or use the App after those revisions become effective, you agree to be bound by the revised terms. If you do not agree to the new terms, in whole or in part, please stop using the App.", "Terms and Conditions Last updated: April 04, 2023\n\nPlease read these terms and conditions carefully before using the Pig Profit (App).\n\nBy accessing or using the App you agree to be bound by these Terms and Conditions and our Privacy Policy. If you disagree with any part of these Terms and Conditions then you may not access the App. Please read our Privacy Policy carefully before using the App.\n\nYou are responsible for safeguarding the password that you use to access the App and for any activities or actions under your password. You may choose to only upload the data to the App in your device or additionally upload it to our database for further analysis and reporting. By uploading your data to our database, you grant us the right and license to use, modify, analyze and make further use of the data for reporting purposes.\n\nYou understand that the accuracy of any reports generated by the App depends on the reliability of the content that you upload or provide.\n\nYou represent and warrant that: (i) the data is yours or you have the right to use it and grant us the rights and license as provided in these Terms, and (ii) the posting of your data on the App does not violate the privacy rights, publicity rights, copyrights, contract rights or any other rights of any person. We are not responsible for the content of the App's users. You expressly understand and agree that you are solely responsible for the data and for all activity that occurs under your account, whether done so by you or any third person using your account.\n\nYou may not transmit any content that is unlawful, offensive, upsetting, intended to disgust, threatening, libelous, defamatory, obscene or otherwise objectionable.\n\nIn no event shall we be liable for any special, incidental, indirect, or consequential damages whatsoever. The App is provided to you \"AS IS\" and \"AS AVAILABLE\" without warranty of any kind. We expressly disclaim all warranties, whether express, implied, statutory or otherwise, with respect to the App.\n\nWe do not make any representation or warranty of any kind, express or implied: (i) as to the operation or availability of the App; (ii) that the App will be uninterrupted or error-free; (iii) as to the accuracy, reliability, or currency of any information or content provided through the Tool; or (iv) that the Tool, its servers, the content, or e-mails are free of viruses or other harmful components.\n\nThe laws of the Republic of Kenya shall govern these Terms and Conditions. Your use of the App may also be subject to other local, state, national, or international laws. If you have any concern or dispute about the App you agree to first try to resolve the dispute informally by contacting us.\n\nWe reserve the right to modify or replace these Terms at any time. By continuing to access or use the App after those revisions become effective, you agree to be bound by the revised terms. If you do not agree to the new terms, in whole or in part, please stop using the App.", "Terms and Conditions Last updated: April 04, 2023\n\nPlease read these terms and conditions carefully before using the Pig Profit (App).\n\nBy accessing or using the App you agree to be bound by these Terms and Conditions and our Privacy Policy. If you disagree with any part of these Terms and Conditions then you may not access the App. Please read our Privacy Policy carefully before using the App.\n\nYou are responsible for safeguarding the password that you use to access the App and for any activities or actions under your password. You may choose to only upload the data to the App in your device or additionally upload it to our database for further analysis and reporting. By uploading your data to our database, you grant us the right and license to use, modify, analyze and make further use of the data for reporting purposes.\n\nYou understand that the accuracy of any reports generated by the App depends on the reliability of the content that you upload or provide.\n\nYou represent and warrant that: (i) the data is yours or you have the right to use it and grant us the rights and license as provided in these Terms, and (ii) the posting of your data on the App does not violate the privacy rights, publicity rights, copyrights, contract rights or any other rights of any person. We are not responsible for the content of the App's users. You expressly understand and agree that you are solely responsible for the data and for all activity that occurs under your account, whether done so by you or any third person using your account.\n\nYou may not transmit any content that is unlawful, offensive, upsetting, intended to disgust, threatening, libelous, defamatory, obscene or otherwise objectionable.\n\nIn no event shall we be liable for any special, incidental, indirect, or consequential damages whatsoever. The App is provided to you \"AS IS\" and \"AS AVAILABLE\" without warranty of any kind. We expressly disclaim all warranties, whether express, implied, statutory or otherwise, with respect to the App.\n\nWe do not make any representation or warranty of any kind, express or implied: (i) as to the operation or availability of the App; (ii) that the App will be uninterrupted or error-free; (iii) as to the accuracy, reliability, or currency of any information or content provided through the Tool; or (iv) that the Tool, its servers, the content, or e-mails are free of viruses or other harmful components.\n\nThe laws of the Republic of Kenya shall govern these Terms and Conditions. Your use of the App may also be subject to other local, state, national, or international laws. If you have any concern or dispute about the App you agree to first try to resolve the dispute informally by contacting us.\n\nWe reserve the right to modify or replace these Terms at any time. By continuing to access or use the App after those revisions become effective, you agree to be bound by the revised terms. If you do not agree to the new terms, in whole or in part, please stop using the App." });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP1", "Privacy Policy  \n\nThis Privacy Policy describes our policies and procedures on the collection, use and disclosure of your information when you use the App and tells you about your privacy rights and how the law protects you. We use your Personal data to provide and improve the App. By using the App, you agree to the collection and use of information in accordance with this Privacy Policy. ", "Privacy Policy  \n\nThis Privacy Policy describes our policies and procedures on the collection, use and disclosure of your information when you use the App and tells you about your privacy rights and how the law protects you. We use your Personal data to provide and improve the App. By using the App, you agree to the collection and use of information in accordance with this Privacy Policy. ", "Privacy Policy  \n\nThis Privacy Policy describes our policies and procedures on the collection, use and disclosure of your information when you use the App and tells you about your privacy rights and how the law protects you. We use your Personal data to provide and improve the App. By using the App, you agree to the collection and use of information in accordance with this Privacy Policy. ", "Privacy Policy  \n\nThis Privacy Policy describes our policies and procedures on the collection, use and disclosure of your information when you use the App and tells you about your privacy rights and how the law protects you. We use your Personal data to provide and improve the App. By using the App, you agree to the collection and use of information in accordance with this Privacy Policy. " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP2", "Collecting and Using Your Personal Data ", "Collecting and Using Your Personal Data ", "Collecting and Using Your Personal Data ", "Collecting and Using Your Personal Data " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP3", "Types of Data Collected ", "Types of Data Collected ", "Types of Data Collected ", "Types of Data Collected " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP4", "Personal Data  ", "Personal Data  ", "Personal Data  ", "Personal Data  " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP5", "While using the App, you may be asked to provide us with certain personally identifiable information that can be used to contact or identify You. Personally identifiable information may include, but is not limited to: \n\nEmail address \n\nFirst name and last name \n\nGender \n\nPhone number \n\nAddress \n\nUsage Data ", "While using the App, you may be asked to provide us with certain personally identifiable information that can be used to contact or identify You. Personally identifiable information may include, but is not limited to: \n\nEmail address \n\nFirst name and last name \n\nGender \n\nPhone number \n\nAddress \n\nUsage Data ", "While using the App, you may be asked to provide us with certain personally identifiable information that can be used to contact or identify You. Personally identifiable information may include, but is not limited to: \n\nEmail address \n\nFirst name and last name \n\nGender \n\nPhone number \n\nAddress \n\nUsage Data ", "While using the App, you may be asked to provide us with certain personally identifiable information that can be used to contact or identify You. Personally identifiable information may include, but is not limited to: \n\nEmail address \n\nFirst name and last name \n\nGender \n\nPhone number \n\nAddress \n\nUsage Data " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP16", "Transfer of Your Personal Data ", "Transfer of Your Personal Data ", "Transfer of Your Personal Data ", "Transfer of Your Personal Data " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP6", "Usage Data", "Usage Data", "Usage Data", "Usage Data" });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP8", "Information Collected while Using the Application ", "Information Collected while Using the Application ", "Information Collected while Using the Application ", "Information Collected while Using the Application " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP9", "The App is designed to determine the profit or loss of smallholder pig enterprises, with the user inputting their data relating to this.  This data includes but is not limited to: data on costs including on feed, labour, water, co-operative / group membership, animal purchase, equipment, healthcare, housing, reproduction, loan repaying and other; and data on income including sale of pigs, sale of manure, sale of breeding services, other income.   ", "The App is designed to determine the profit or loss of smallholder pig enterprises, with the user inputting their data relating to this.  This data includes but is not limited to: data on costs including on feed, labour, water, co-operative / group membership, animal purchase, equipment, healthcare, housing, reproduction, loan repaying and other; and data on income including sale of pigs, sale of manure, sale of breeding services, other income.   ", "The App is designed to determine the profit or loss of smallholder pig enterprises, with the user inputting their data relating to this.  This data includes but is not limited to: data on costs including on feed, labour, water, co-operative / group membership, animal purchase, equipment, healthcare, housing, reproduction, loan repaying and other; and data on income including sale of pigs, sale of manure, sale of breeding services, other income.   ", "The App is designed to determine the profit or loss of smallholder pig enterprises, with the user inputting their data relating to this.  This data includes but is not limited to: data on costs including on feed, labour, water, co-operative / group membership, animal purchase, equipment, healthcare, housing, reproduction, loan repaying and other; and data on income including sale of pigs, sale of manure, sale of breeding services, other income.   " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP10", "Location data ", "Location data ", "Location data ", "Location data " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP11", "We may collect, information regarding your location, with your prior permission. We use this information to provide features of the App, to improve and customize the App. The information may be uploaded to our servers and/or a Service Provider's server or it may be simply stored on your device. You can enable or disable access to this information at any time, through your Device settings. ", "We may collect, information regarding your location, with your prior permission. We use this information to provide features of the App, to improve and customize the App. The information may be uploaded to our servers and/or a Service Provider's server or it may be simply stored on your device. You can enable or disable access to this information at any time, through your Device settings. ", "We may collect, information regarding your location, with your prior permission. We use this information to provide features of the App, to improve and customize the App. The information may be uploaded to our servers and/or a Service Provider's server or it may be simply stored on your device. You can enable or disable access to this information at any time, through your Device settings. ", "We may collect, information regarding your location, with your prior permission. We use this information to provide features of the App, to improve and customize the App. The information may be uploaded to our servers and/or a Service Provider's server or it may be simply stored on your device. You can enable or disable access to this information at any time, through your Device settings. " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP12", "Use of Your Personal Data ", "Use of Your Personal Data ", "Use of Your Personal Data ", "Use of Your Personal Data " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP13", "We may use Personal Data for the following purposes: \n\nTo provide and maintain the App, including to monitor the usage of the App. \n\nTo manage Your Account: to manage your registration as a user of the App.  \n\nTo contact You: To contact you by email, telephone calls, SMS, or other equivalent forms of electronic communication, such as a mobile application's push notifications regarding updates or informative communications related to the functionalities, including security updates, when necessary or reasonable for their implementation. \n\nFor other purposes: We may use your information for other purposes, such as data analysis, identifying usage trends and to evaluate and improve the App and your experience. \n\nWe may share your personal information in the following situations: \n\nWith Affiliates: We may share your information with our affiliates, in which case we will require those affiliates to honor this Privacy Policy.  \n\nWith Your consent: We may disclose your personal information for any other purpose with your consent. ", "We may use Personal Data for the following purposes: \n\nTo provide and maintain the App, including to monitor the usage of the App. \n\nTo manage Your Account: to manage your registration as a user of the App.  \n\nTo contact You: To contact you by email, telephone calls, SMS, or other equivalent forms of electronic communication, such as a mobile application's push notifications regarding updates or informative communications related to the functionalities, including security updates, when necessary or reasonable for their implementation. \n\nFor other purposes: We may use your information for other purposes, such as data analysis, identifying usage trends and to evaluate and improve the App and your experience. \n\nWe may share your personal information in the following situations: \n\nWith Affiliates: We may share your information with our affiliates, in which case we will require those affiliates to honor this Privacy Policy.  \n\nWith Your consent: We may disclose your personal information for any other purpose with your consent. ", "We may use Personal Data for the following purposes: \n\nTo provide and maintain the App, including to monitor the usage of the App. \n\nTo manage Your Account: to manage your registration as a user of the App.  \n\nTo contact You: To contact you by email, telephone calls, SMS, or other equivalent forms of electronic communication, such as a mobile application's push notifications regarding updates or informative communications related to the functionalities, including security updates, when necessary or reasonable for their implementation. \n\nFor other purposes: We may use your information for other purposes, such as data analysis, identifying usage trends and to evaluate and improve the App and your experience. \n\nWe may share your personal information in the following situations: \n\nWith Affiliates: We may share your information with our affiliates, in which case we will require those affiliates to honor this Privacy Policy.  \n\nWith Your consent: We may disclose your personal information for any other purpose with your consent. ", "We may use Personal Data for the following purposes: \n\nTo provide and maintain the App, including to monitor the usage of the App. \n\nTo manage Your Account: to manage your registration as a user of the App.  \n\nTo contact You: To contact you by email, telephone calls, SMS, or other equivalent forms of electronic communication, such as a mobile application's push notifications regarding updates or informative communications related to the functionalities, including security updates, when necessary or reasonable for their implementation. \n\nFor other purposes: We may use your information for other purposes, such as data analysis, identifying usage trends and to evaluate and improve the App and your experience. \n\nWe may share your personal information in the following situations: \n\nWith Affiliates: We may share your information with our affiliates, in which case we will require those affiliates to honor this Privacy Policy.  \n\nWith Your consent: We may disclose your personal information for any other purpose with your consent. " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP14", "Retention of Your Personal Data ", "Retention of Your Personal Data ", "Retention of Your Personal Data ", "Retention of Your Personal Data " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "PP7", "Usage Data may be collected automatically when using the App. Usage Data may include information such as your Device's Internet Protocol address (e.g. IP address), browser type, browser version, the type of mobile device you use, your mobile operating system, the pages of App that you visit, the time and date of your visit, the time spent on those pages, unique device identifiers and other diagnostic data. ", "Usage Data may be collected automatically when using the App. Usage Data may include information such as your Device's Internet Protocol address (e.g. IP address), browser type, browser version, the type of mobile device you use, your mobile operating system, the pages of App that you visit, the time and date of your visit, the time spent on those pages, unique device identifiers and other diagnostic data. ", "Usage Data may be collected automatically when using the App. Usage Data may include information such as your Device's Internet Protocol address (e.g. IP address), browser type, browser version, the type of mobile device you use, your mobile operating system, the pages of App that you visit, the time and date of your visit, the time spent on those pages, unique device identifiers and other diagnostic data. ", "Usage Data may be collected automatically when using the App. Usage Data may include information such as your Device's Internet Protocol address (e.g. IP address), browser type, browser version, the type of mobile device you use, your mobile operating system, the pages of App that you visit, the time and date of your visit, the time spent on those pages, unique device identifiers and other diagnostic data. " });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "LogoutWarningTransaltion2", "All your data will be deleted and not recoverable.  Do you wish to continue?", " Data yo yonna ejja kusazibwamu era tegenda kuddamu kuzuulibwa. Oyagala okugenda mu maaso?", "Tất cả dữ liệu của bạn sẽ bị xóa và không thể phục hồi được. Bạn có muốn tiếp tục không?", "Amakuru yawe yose azasibwa kandi ntashobora kugarurwa. Urashaka gukomeza?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GroupMembershipShortTranslation");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LogoutWarningTransaltion2");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP1");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP10");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP11");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP12");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP13");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP14");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP15");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP16");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP17");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP18");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP19");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP2");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP20");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP21");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP22");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP23");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP24");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP25");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP26");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP27");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP28");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP29");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP3");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP30");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP31");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP32");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP33");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP4");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP5");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP6");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP7");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP8");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PP9");

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TermsAndCondtions");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceSale",
                column: "English",
                value: "Sale of breeding services");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LogoutWarningTransaltion",
                columns: new[] { "English", "Lang1", "Lang2", "Lang3" },
                values: new object[] { "By logging out any data not submitted to the cloud will be lost and current data on the device will be removed", "Nga ofuluma obubaka byonna obu tateereddwa mu kiire bujja kubula era obubaka obuli ku kyuma bujja kuggyibwawo", "Bằng cách đăng xuất, mọi dữ liệu không được gửi lên đám mây sẽ bị mất và dữ liệu hiện tại trên thiết bị sẽ bị xóa", "Mukwemeza gusohoka amakuru yose atohererejwe ku mashini ikusanya amakuru azabura kandi n'aya makuru ari kuri iyi telefoni nayo aravanwaho" });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureSale",
                column: "English",
                value: "Sale of manure");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostEvent",
                column: "English",
                value: "Other");
        }
    }
}
