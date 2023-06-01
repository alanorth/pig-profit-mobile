using Microsoft.EntityFrameworkCore.Migrations;

namespace Shared.Migrations
{
    public partial class NewTranslations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "About",
                column: "Lang2",
                value: "Về chúng tôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AddData",
                column: "Lang2",
                value: "Thêm dữ liệu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AddFeedItemTrans",
                column: "Lang2",
                value: "Thêm chi phí thức ăn chăn nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPaidNotProvided",
                column: "Lang2",
                value: "Số tiền đã thanh toán chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPaidTranslation",
                column: "Lang2",
                value: "Số tiền trả cho lao động chăn nuôi lợn trong suốt thời gian");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPurchasedTrans",
                column: "Lang2",
                value: "Số tiền đã mua");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPurchasedTranslation",
                column: "Lang2",
                value: "Số tiền đã mua");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPurchasedUnitTranslation",
                column: "Lang2",
                value: "Số tiền đã mua");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountRecievedTranslation",
                column: "Lang2",
                value: "Tổng số tiền đã nhận cho tất cả các dịch vụ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchase",
                column: "Lang2",
                value: "Mua vật nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromTranslation",
                column: "Lang2",
                value: "Nơi mua");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType1",
                column: "Lang2",
                value: "Thị trường");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType2",
                column: "Lang2",
                value: "Thương lái");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType3",
                column: "Lang2",
                value: "Người chăn nuôi lợn");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType4",
                column: "Lang2",
                value: "Công ty chăn nuôi lợn");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchaseTitleTranslation",
                column: "Lang2",
                value: "Mua vật nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalSaved",
                column: "Lang2",
                value: "Mua vật nuôi đã được lưu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalType1",
                column: "Lang2",
                value: "Lợn con để vỗ béo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalType2",
                column: "Lang2",
                value: "Lợn nái hậu bị để làm giống");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalType3",
                column: "Lang2",
                value: "Lợn đực hậu bị để làm giống");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalTypeTranslation",
                column: "Lang2",
                value: "Loại vật nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalUpdated",
                column: "Lang2",
                value: "Thông tin mua vật nuôi đã được cập nhật");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnyOtherPaymentTranslation",
                column: "Lang2",
                value: "Thanh toán khác đã nhận");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingSaved",
                column: "Lang2",
                value: "Bán dịch vụ gây giống đã được lưu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceSale",
                column: "Lang2",
                value: "Bán các dịch vụ gây giống");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceSaleTitleTranslation",
                column: "Lang2",
                value: "Bán các dịch vụ gây giống");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceType1",
                column: "Lang2",
                value: "Dịch vụ lợn đực giống");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BrokerageTranslation",
                column: "Lang2",
                value: "Tiền hoa hồng môi giới");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Cancel",
                column: "Lang2",
                value: "Hủy bỏ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CellTranslation",
                column: "Lang2",
                value: "Tế bào");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ClientTranslation",
                column: "Lang2",
                value: "Khách hàng");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ClientType1",
                column: "Lang2",
                value: "Người chăn nuôi lợn");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CommentTrans",
                column: "Lang2",
                value: "Bình luận");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CommentTranslation",
                column: "Lang2",
                value: "Bình luận");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CommuneTranslation",
                column: "Lang2",
                value: "Xã");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Costs",
                column: "Lang2",
                value: "Chi phí");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CostTrans",
                column: "Lang2",
                value: "Chi phí");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CostTranslation",
                column: "Lang2",
                value: "Chi phí khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTranslation",
                column: "Lang2",
                value: "Quốc gia");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTypeRwanda",
                column: "Lang2",
                value: "Rwanda");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTypeUganda",
                column: "Lang2",
                value: "Uganda");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTypeVietnam",
                column: "Lang2",
                value: "Việt Nam");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountyTranslation",
                column: "Lang2",
                value: "Vùng");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CurrencyTranslation",
                column: "Lang2",
                value: "Tiền tệ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DataHasBeenUploaded",
                column: "Lang2",
                value: "Dữ liệu đã được tải lên");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DataUploaded",
                column: "Lang2",
                value: "Dữ liệu được tải lên thành công!");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DateLastUploaded",
                column: "Lang2",
                value: "Dữ liệu được tải lên lần cuối");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DateObtainedTrans",
                column: "Lang2",
                value: "Ngày ghi nhận");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DateTranslation",
                column: "Lang2",
                value: "Ngày");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DeleteConfirmation",
                column: "Lang2",
                value: "Xác nhận xóa");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DeleteTranslation",
                column: "Lang2",
                value: "Xóa");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DeleteVerify",
                column: "Lang2",
                value: "Bạn có chắc chắn muốn xóa mục này");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DistrictTranslation",
                column: "Lang2",
                value: "Quận/huyện");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType1",
                column: "Lang2",
                value: "Cám ngô");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType10",
                column: "Lang2",
                value: "Bã đậu tương");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType11",
                column: "Lang2",
                value: "Khô dầu hướng dương");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType12",
                column: "Lang2",
                value: "Bánh khô dầu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType13",
                column: "Lang2",
                value: "Khô dầu lạc");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType14",
                column: "Lang2",
                value: "Thức ăn chăn nuôi hỗn hợp (Thức ăn chăn nuôi gắn nhãn)");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType15",
                column: "Lang2",
                value: "Thức ăn chăn nuôi hỗn hợp (Thức ăn chăn nuôi không gắn nhãn)");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType16",
                column: "Lang2",
                value: "Khoáng chất");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType17",
                column: "Lang2",
                value: "Vitamin");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType18",
                column: "Lang2",
                value: "Thức ăn trộn sẵn");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType19",
                column: "Lang2",
                value: "Thức ăn ủ chua");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType2",
                column: "Lang2",
                value: "Cám mì");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType3",
                column: "Lang2",
                value: "Mầm ngô");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType4",
                column: "Lang2",
                value: "Cám gạo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType5",
                column: "Lang2",
                value: "Cám ngô Gluten");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType6",
                column: "Lang2",
                value: "Cám mì Gluten");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType7",
                column: "Lang2",
                value: "Bã bia");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType8",
                column: "Lang2",
                value: "Ngô xay");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType9",
                column: "Lang2",
                value: "Khô dầu đậu tương");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom1",
                column: "Lang2",
                value: "Đơn vị cung cấp thức ăn chăn nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom2",
                column: "Lang2",
                value: "Cửa hàng vật tư chăn nuôi và thuốc thú y");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom3",
                column: "Lang2",
                value: "Nông dân khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom4",
                column: "Lang2",
                value: "Phương tiện vận chuyển");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownUnitType1",
                column: "Lang2",
                value: "Kilôgam");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownUnitType2",
                column: "Lang2",
                value: "Số lượng");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownUnitType3",
                column: "Lang2",
                value: "gram");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DurIsbefore",
                column: "Lang2",
                value: "Thời gian Hoàn thành trước Thời gian Bắt đầu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EditData",
                column: "Lang2",
                value: "Xem/Sửa/Xóa dữ liệu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EditTranslation",
                column: "Lang2",
                value: "Sửa");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EmailTranslation",
                column: "Lang2",
                value: "E-mail");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "English",
                column: "Lang2",
                value: "Tiếng Việt");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Equipment",
                column: "Lang2",
                value: "Thiết bị");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentSaved",
                column: "Lang2",
                value: "Thông tin thiết bị đã được lưu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentTitleTranslation",
                column: "Lang2",
                value: "Thiết bị");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType1",
                column: "Lang2",
                value: "Thiết bị cho ăn");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType2",
                column: "Lang2",
                value: "Thiết bị cung cấp nước uống");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType3",
                column: "Lang2",
                value: "Thiết bị vệ sinh");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType4",
                column: "Lang2",
                value: "Thẻ tai vật nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentTypeTranslation",
                column: "Lang2",
                value: "Loại thiết bị");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentUpdated",
                column: "Lang2",
                value: "Thông tin thiết bị đã được cập nhật");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Error",
                column: "Lang2",
                value: "Lỗi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FailedToLoad",
                column: "Lang2",
                value: "Không thể tải mục");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Feed",
                column: "Lang2",
                value: "Thức ăn chăn nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedDurationTranslation",
                column: "Lang2",
                value: "Khoảng thời gian sử dụng thức ăn chăn nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedItemTitleTranslation",
                column: "Lang2",
                value: "Thức ăn chăn nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedSaved",
                column: "Lang2",
                value: "Loại thức ăn chăn nuôi đã được lưu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedTypeTrans",
                column: "Lang2",
                value: "Loại thức ăn chăn nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedTypeTranslation",
                column: "Lang2",
                value: "Loại thức ăn chăn nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedUpdated",
                column: "Lang2",
                value: "Thông tin thức ăn chăn nuôi đã được cập nhật");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FilterTranslation",
                column: "Lang2",
                value: "Bộ lọc:");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FinishTranslation",
                column: "Lang2",
                value: "Hoàn thành");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderTranslation",
                column: "Lang2",
                value: "Giới tính");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderType1",
                column: "Lang2",
                value: "Nam");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderType2",
                column: "Lang2",
                value: "Nữ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderType3",
                column: "Lang2",
                value: "Khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GoogleAuth",
                column: "Lang2",
                value: "Xác thực tài khoản Google không thành công");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GoogleSignUpTranslation",
                column: "Lang2",
                value: "Đăng ký với Google");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Healthcare",
                column: "Lang2",
                value: "Chăm sóc sức khỏe vật nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareCostTranslation",
                column: "Lang2",
                value: "Chi phí cung cấp dịch vụ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareTitleTranslation",
                column: "Lang2",
                value: "Chăm sóc sức khỏe vật nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareTypeTranslation",
                column: "Lang2",
                value: "Loại hình chăm sóc sức khỏe vật nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType1",
                column: "Lang2",
                value: "Cán bộ thú y tư nhân");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType2",
                column: "Lang2",
                value: "Cán bộ thú y nhà nước");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType3",
                column: "Lang2",
                value: "Bản thân");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType4",
                column: "Lang2",
                value: "Hàng xóm, bạn bè hoặc họ hàng");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthSaved",
                column: "Lang2",
                value: "Hồ sơ chăm sóc sức khỏe vật nuôi đã được lưu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthUpdated",
                column: "Lang2",
                value: "Hồ sơ chăm sóc sức khỏe vật nuôi đã được cập nhật");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType1",
                column: "Lang2",
                value: "Chữa bệnh (điều trị bệnh)");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType2",
                column: "Lang2",
                value: "Phòng bệnh (VD: tiêm vắc xin)");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType3",
                column: "Lang2",
                value: "Bổ sung vitamin");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType4",
                column: "Lang2",
                value: "Tẩy giun");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType5",
                column: "Lang2",
                value: "Sử dụng thuốc sát trùng");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType6",
                column: "Lang2",
                value: "Thăm nom/giám sát đàn vật nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Hello",
                column: "Lang2",
                value: "Xin chào");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Home",
                column: "Lang2",
                value: "Trang chủ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Housing",
                column: "Lang2",
                value: "Chuồng trại");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseTranslation",
                column: "Lang2",
                value: "Chi phí chuồng trại");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseType1",
                column: "Lang2",
                value: "Xây chuồng mới");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseType2",
                column: "Lang2",
                value: "Mở rộng chuồng trại hiện có");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseType3",
                column: "Lang2",
                value: "Sửa chữa hoặc bảo trì");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingTitleTranslation",
                column: "Lang2",
                value: "Chuồng trại");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Income",
                column: "Lang2",
                value: "Thu nhập");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Labour",
                column: "Lang2",
                value: "Lao động");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourDurationTranslation",
                column: "Lang2",
                value: "Khoảng thời gian sử dụng lao động");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourTitleTranslation",
                column: "Lang2",
                value: "Lao động");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourType1",
                column: "Lang2",
                value: "Lao động làm thuê dài hạn");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourType2",
                column: "Lang2",
                value: "Lao động làm thuê thời vụ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourTypeTranslation",
                column: "Lang2",
                value: "Loại lao động khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageTranslation",
                column: "Lang2",
                value: "Ngôn ngữ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType1",
                column: "Lang2",
                value: "Tiếng Việt");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType3",
                column: "Lang2",
                value: "Tiếng Việt");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType5",
                column: "Lang2",
                value: "Ngôn ngữ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType6",
                column: "Lang2",
                value: "Ngôn ngữ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LastData",
                column: "Lang2",
                value: "Cập nhật dữ liệu lần cuối cùng:");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerAgreeTranslation",
                column: "Lang2",
                value: "Chọn nếu bạn đồng ý với các điều khoản trên");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerBodyTranslation",
                column: "English",
                value: "Terms and Conditions Last updated: April 04, 2023 \n\nPlease read these terms and conditions carefully before using the Pig Profit  (App). \n\nBy accessing or using the App you agree to be bound by these Terms and Conditions and our Privacy Policy. If you disagree with any part of these Terms and Conditions then you may not access the App. Please read our Privacy Policy carefully before using the App. \n\nYou are responsible for safeguarding the password that you use to access the App and for any activities or actions under your password. You may choose to only upload the data to the App in your device or  additionally upload it to our database for further analysis and reporting. By uploading your data to our database, you grant us the right and license to use, modify, analyze  and make further use of the data for reporting purposes. \n\nYou understand that the accuracy of any reports generated by the App depends on the reliability of the content that you upload or provide.  \n\nYou represent and warrant that: (i) the data is yours or you have the right to use it and grant us the rights and license as provided in these Terms, and (ii) the posting of your data on the App does not violate the privacy rights, publicity rights, copyrights, contract rights or any other rights of any person. We are not responsible for the content of the App's users. You expressly understand and agree that you are solely responsible for the data and for all activity that occurs under your account, whether done so by you or any third person using your account. \n\nYou may not transmit any content that is unlawful, offensive, upsetting, intended to disgust, threatening, libelous, defamatory, obscene or otherwise objectionable.  \n\nIn no event shall we be liable for any special, incidental, indirect, or consequential damages whatsoever. The App is provided to you \"AS IS\" and \"AS AVAILABLE\" without warranty of any kind. We expressly disclaim all warranties, whether express, implied, statutory or otherwise, with respect to the App.  \n\nWe do not make any representation or warranty of any kind, express or implied: (i) as to the operation or availability of the App; (ii) that the App will be uninterrupted or error-free; (iii) as to the accuracy, reliability, or currency of any information or content provided through the Tool; or (iv) that the Tool, its servers, the content, or e-mails are free of viruses or other harmful components. \n\nThe laws of the Republic of Kenya shall govern these Terms and Conditions. Your use of the App may also be subject to other local, state, national, or international laws. If you have any concern or dispute about the App you agree to first try to resolve the dispute informally by contacting us. \n\nWe reserve the right to modify or replace these Terms at any time. By continuing to access or use the App after those revisions become effective, you agree to be bound by the revised terms. If you do not agree to the new terms, in whole or in part, please stop using the App. ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerProceedTranslation",
                column: "Lang2",
                value: "Tiếp tục");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerTitleTranslation",
                column: "Lang2",
                value: "Tuyên bố từ chối trách nhiệm pháp lý");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderTranslation",
                column: "Lang2",
                value: "Đơn vị cho vay");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType1",
                column: "Lang2",
                value: "Nhà cung cấp tín dụng vi mô");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType2",
                column: "Lang2",
                value: "Ngân hàng");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType3",
                column: "Lang2",
                value: "Hợp tác xã hoặc tổ/nhóm");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType4",
                column: "Lang2",
                value: "Nhóm tự giúp đỡ hoặc tiết kiệm");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType5",
                column: "Lang2",
                value: "Câu lạc bộ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType6",
                column: "Lang2",
                value: "Họ hàng hoặc bạn bè");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanRepayment",
                column: "Lang2",
                value: "Trả nợ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanRepaymentTitleTranslation",
                column: "Lang2",
                value: "Trả nợ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanSaved",
                column: "Lang2",
                value: "Thông tin trả nợ đã được lưu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanUpdated",
                column: "Lang2",
                value: "Thông tin trả nợ đã được cập nhật");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoginButton",
                column: "Lang2",
                value: "Đăng nhập");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureSale",
                column: "Lang2",
                value: "Bán phân chuồng");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureSaleTitleTranslation",
                column: "Lang2",
                value: "Bán phân chuồng");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureSaved",
                column: "Lang2",
                value: "Thông tin bán phân chuồng đã được lưu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureUpdated",
                column: "Lang2",
                value: "Thông tin bán phân chuồng đã được cập nhật");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineCostTranslation",
                column: "Lang2",
                value: "Chi phí thuốc");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType1",
                column: "Lang2",
                value: "Thuốc");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType2",
                column: "Lang2",
                value: "Tiêm vắc xin");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType3",
                column: "Lang2",
                value: "Thuốc tẩy giun");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType4",
                column: "Lang2",
                value: "Vitamin");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineTypeTranslation",
                column: "Lang2",
                value: "Loại thuốc");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Membership",
                column: "Lang2",
                value: "Thành viên hợp tác xã/tổ/nhóm");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MemberShipSaved",
                column: "Lang2",
                value: "Thông tin thành viên đã được lưu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipTitleTranslation",
                column: "Lang2",
                value: "Thành viên hợp tác xã/tổ/nhóm");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipType1",
                column: "Lang2",
                value: "Phí hợp tác xã hoặc tổ/ nhóm");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipTypeTranslation",
                column: "Lang2",
                value: "Loại thành viên");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Name",
                column: "Lang2",
                value: "Tên");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NameTranslation",
                column: "Lang2",
                value: "Tên");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoAmountRecevied",
                column: "Lang2",
                value: "Số tiền đã nhận chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoAnimalType",
                column: "Lang2",
                value: "Loại vật nuôi khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoBrokerage",
                column: "Lang2",
                value: "Tiền hoa hồng môi giới chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoCountry",
                column: "Lang2",
                value: "Quốc gia chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoCurrency",
                column: "Lang2",
                value: "Loại tiền tệ chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoDate",
                column: "Lang2",
                value: "Ngày báo cáo chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoDateProvided",
                column: "Lang2",
                value: "Ngày chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoDurationEnd",
                column: "Lang2",
                value: "Thời gian Hoàn thành chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoDurationStart",
                column: "Lang2",
                value: "Thời gian bắt đầu chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoFeedType",
                column: "Lang2",
                value: "Loại thức ăn chăn nuôi khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoHealthCareCost",
                column: "Lang2",
                value: "Chi phí chăm sóc sức khỏe vật nuôi chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoHousingExpense",
                column: "Lang2",
                value: "Chi phí chuồng trại khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoMedicineCost",
                column: "Lang2",
                value: "Chi phí thuốc chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoName",
                column: "Lang2",
                value: "Tên chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherHealthCareYpe",
                column: "Lang2",
                value: "Loại hình chăm sóc sức khỏe vật nuôi khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherLabourType",
                column: "Lang2",
                value: "Loại Lao động khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherMediceType",
                column: "Lang2",
                value: "Loại thuốc khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherMemberShip",
                column: "Lang2",
                value: "Loại thành viên khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherPerson",
                column: "Lang2",
                value: "Nơi khách hàng mua khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherPigType",
                column: "Lang2",
                value: "Loại lợn khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherProvider",
                column: "Lang2",
                value: "Đơn vị cung cấp khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherPurcFrom",
                column: "Lang2",
                value: "Nơi mua khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherServiceProvider",
                column: "Lang2",
                value: "Đơn vị cung cấp dịch vụ khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherSoldTo",
                column: "Lang2",
                value: "Người mua khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoPaymentValue",
                column: "Lang2",
                value: "Giá trị thanh toán chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoPeriodUnit",
                column: "Lang2",
                value: "Đơn vị thời gian chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoPhoneNumber",
                column: "Lang2",
                value: "Số điện thoại chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoPurchasedFrom",
                column: "Lang2",
                value: "Nơi mua vật nuôi khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoSalePrice",
                column: "Lang2",
                value: "Giá bán chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoServiceType",
                column: "Lang2",
                value: "Loại dịch vụ khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoSowsServiced",
                column: "Lang2",
                value: "Dịch vụ lợn nái chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoTotalAmount",
                column: "Lang2",
                value: "Tổng số tiền trả nợ chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoTotalCost",
                column: "Lang2",
                value: "Tổng chi phí chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NotOtherClient",
                column: "Lang2",
                value: "Khách hàng khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoTransportationCost",
                column: "Lang2",
                value: "Chi phí vận chuyển chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoUsername",
                column: "Lang2",
                value: "Tên người dùng chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NumberPurchasedTranslation",
                column: "Lang2",
                value: "Số lượng đã mua");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NumberServicesTranslation",
                column: "Lang2",
                value: "Số dịch vụ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NumberSoldTranslation",
                column: "Lang2",
                value: "Số lượng bán");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OK",
                column: "Lang2",
                value: "Chọn");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Other",
                column: "Lang2",
                value: "Khác, nêu rõ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAmountPurchasedUnitTranslation",
                column: "Lang2",
                value: "Đơn vị khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAmountPurchaseTrans",
                column: "Lang2",
                value: "Số tiền đã mua khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAnimalPurchasedTranslation",
                column: "Lang2",
                value: "Nơi mua");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherClientTranslation",
                column: "Lang2",
                value: "Khách hàng khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostEvent",
                column: "Lang2",
                value: "Khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostsSaved",
                column: "Lang2",
                value: "Chi phí khác đã được lưu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostsTranslation",
                column: "Lang2",
                value: "Chi phí khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostTitleTranslation",
                column: "Lang2",
                value: "Khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostTranslation",
                column: "Lang2",
                value: "Chi phí khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostUpdated",
                column: "Lang2",
                value: "Thông tin chi phí khác đã được cập nhật");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherEqNotProvided",
                column: "Lang2",
                value: "Loại thiết bị khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherEquipmentTypeTranslation",
                column: "Lang2",
                value: "Loại thiết bị khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherFeedTypeTrans",
                column: "Lang2",
                value: "Loại thức ăn chăn nuôi khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherFeedTypeTranslation",
                column: "Lang2",
                value: "Loại thức ăn chăn nuôi khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherHealthCareTypeTranslation",
                column: "Lang2",
                value: "Loại hình chăm sóc sức khỏe vật nuôi khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherHousingExpenseTranslation",
                column: "Lang2",
                value: "Chi phí chuồng trại khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncome",
                column: "Lang2",
                value: "Thu nhập khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncomeSaved",
                column: "Lang2",
                value: "Thông tin thu nhập khác đã được lưu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncomeTitleTranslation",
                column: "Lang2",
                value: "Thu nhập khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncomeUpdated",
                column: "Lang2",
                value: "Thông tin thu nhập khác đã được cập nhật");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherLaboutTypeTranslation",
                column: "Lang2",
                value: "Loại lao động");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherLoanProviderTranslation",
                column: "Lang2",
                value: "Đơn vị cho vay khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherMedicineTypeTranslation",
                column: "Lang2",
                value: "Loại thuốc khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherMembershipTypeTranslation",
                column: "Lang2",
                value: "Loại khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPigTypeTranslation",
                column: "Lang2",
                value: "Loại lợn khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherProviderTranslation",
                column: "Lang2",
                value: "Dịch vụ khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPurchasedFromTranslation",
                column: "Lang2",
                value: "Nơi mua khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPurchasedUnitNotProvided",
                column: "Lang2",
                value: "Đơn vị số tiền đã mua khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPurchasedWaterFromTranslation",
                column: "Lang2",
                value: "Nơi mua");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherServiceTypeTranslation",
                column: "Lang2",
                value: "Loại dịch vụ khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherSoldToTranslation",
                column: "Lang2",
                value: "Người mua khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherUnitNotProvided",
                column: "Lang2",
                value: "Đơn vị khác chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherWaterPurchasedTranslation",
                column: "Lang2",
                value: "Đơn vị khác");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherWhatForTranslation",
                column: "Lang2",
                value: "Mục đích");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherWhoProvidedServiceTranslation",
                column: "Lang2",
                value: "Đơn vị cung cấp dịch vụ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ParishTranslation",
                column: "Lang2",
                value: "Tôn giáo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PaymentType1",
                column: "Lang2",
                value: "Lợn con");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PaymentTypeTranslation",
                column: "Lang2",
                value: "Loại");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PaymentValueTranslation",
                column: "Lang2",
                value: "Giá trị");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PhoneNumberTranslation",
                column: "Lang2",
                value: "Số điện thoại");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerAnimalTypeTranslation",
                column: "Lang2",
                value: "Chọn loại vật nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerClientTranslation",
                column: "Lang2",
                value: "Chọn khách hàng");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerCountryTranslation",
                column: "Lang2",
                value: "Chọn quốc gia");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerCountyTranslation",
                column: "Lang2",
                value: "Chọn vùng");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerCurrencyTranslation",
                column: "Lang2",
                value: "Chọn loại tiền tệ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerDistrictTranslation",
                column: "Lang2",
                value: "Chọn quận/huyện");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerEquipmentTypeTranslation",
                column: "Lang2",
                value: "Chọn loại thiết bị");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerFeedTypeTranslation",
                column: "Lang2",
                value: "Chọn loại thức ăn");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerGenderTranslation",
                column: "Lang2",
                value: "Chọn giới tính");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerHealthCareTypeTranslation",
                column: "Lang2",
                value: "Chọn cách chăm sóc");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerHousingExpenseTranslation",
                column: "Lang2",
                value: "Chọn chi phí");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerLabourTypeTranslation",
                column: "Lang2",
                value: "Chọn loại lao động");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerMedicineTypeTranslation",
                column: "Lang2",
                value: "Chọn loại thuốc");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerMembershipTypeTranslation",
                column: "Lang2",
                value: "Chọn kiểu thành viên");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerPaymentTypeTranslation",
                column: "Lang2",
                value: "Chọn phương thức thanh toán");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerPigTypeTranslation",
                column: "Lang2",
                value: "Chọn loại lợn");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerProviderTranslation",
                column: "Lang2",
                value: "Chọn nhà cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerPurchasedFromTranslation",
                column: "Lang2",
                value: "Chọn nhà cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerServiceTypeTranslation",
                column: "Lang2",
                value: "Chọn loại dịch vụ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerSoldToTranslation",
                column: "Lang2",
                value: "Chọn người mua");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerSubCountyTranslation",
                column: "Lang2",
                value: "Chọn tỉnh");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerUnitTranslation",
                column: "Lang2",
                value: "Đơn vị");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigSale",
                column: "Lang2",
                value: "Bán lợn");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigSaleSaved",
                column: "Lang2",
                value: "Thông tin bán lợn đã được lưu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigSaleTitleTranslation",
                column: "Lang2",
                value: "Bán Lợn");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigSaleUpdated",
                column: "Lang2",
                value: "Thông tin bán lợn đã được cập nhật");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType1",
                column: "Lang2",
                value: "Lợn con (để vỗ béo)");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType2",
                column: "Lang2",
                value: "Giết mổ vật nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType3",
                column: "Lang2",
                value: "Lợn nái hậu bị để làm giống");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType4",
                column: "Lang2",
                value: "Lợn đực hậu bị để làm giống");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigTypeTranslation",
                column: "Lang2",
                value: "Loại lợn");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ProviderTranslation",
                column: "Lang2",
                value: "Đơn vị cung cấp dịch vụ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ProvinceTranslation",
                column: "Lang2",
                value: "Tỉnh");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PruchaseFromType1",
                column: "Lang2",
                value: "Cán bộ thú y tư nhân");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PruchaseFromType2",
                column: "Lang2",
                value: "Cán bộ thú y nhà nước");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PruchaseFromType3",
                column: "Lang2",
                value: "Cửa hàng vật tư chăn nuôi và thuốc thú y");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedFrom",
                column: "Lang2",
                value: "Nơi mua");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedFromTranslation",
                column: "Lang2",
                value: "Nơi mua");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromTranslation",
                column: "Lang2",
                value: "Ai đã mua từ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromType1",
                column: "Lang2",
                value: "Máy bán nước lưu động");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromType2",
                column: "Lang2",
                value: "Công ty cấp nước");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromType3",
                column: "Lang2",
                value: "Hàng xóm/bạn bè");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RecordLabourCostSaved",
                column: "Lang2",
                value: "Chi phí lao động đã được lưu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RecordLabourUpdated",
                column: "Lang2",
                value: "Cập nhật thông tin chi phí lao động");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationSuccessfulContinueTranslation",
                column: "Lang2",
                value: "Tiếp tục");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationSuccessfulDescTranslation",
                column: "Lang2",
                value: "Bạn có thể bắt đầu thu thập và lưu trữ dữ liệu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationSuccessfulTitleTranslation",
                column: "Lang2",
                value: "Tài khoản của bạn đã được thiết lập");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationTitleTranslation",
                column: "Lang2",
                value: "Đăng ký");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationTranslation",
                column: "Lang2",
                value: "Đăng ký");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Reproduction",
                column: "Lang2",
                value: "Bản sao");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReproductionSaved",
                column: "Lang2",
                value: "Thông tin sinh sản đã được lưu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReproductionUpdated",
                column: "Lang2",
                value: "Thông tin sinh sản đã được cập nhật");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReproductiveTitleTranslation",
                column: "Lang2",
                value: "Bản sao");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ResetTranslation",
                column: "Lang2",
                value: "Cài đặt lại");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SalePriceTranslation",
                column: "Lang2",
                value: "Giá bán cho tất cả các con vật đã bán ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SaleSaved",
                column: "Lang2",
                value: "Bán dịch vụ sinh sản đã được lưu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SaveHouseRecord",
                column: "Lang2",
                value: "Thông tin chuồng trại đã được lưu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SaveTranslation",
                column: "Lang2",
                value: "Lưu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SectorTranslation",
                column: "Lang2",
                value: "Ngành");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SendingData",
                column: "Lang2",
                value: "Đang gửi dữ liệu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ServiceType1",
                column: "Lang2",
                value: "Thụ tinh nhân tạo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ServiceType2",
                column: "Lang2",
                value: "Giao phối tự nhiên");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ServiceTypeTranslation",
                column: "Lang2",
                value: "Loại dịch vụ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SliderControlTranslation",
                column: "Lang2",
                value: "Nếu chuồng trại mới được xây dựng (không phải bảo trì), thời gian sử dụng tính bằng năm + giá trị thu hồi dự kiến khi hoàn thành là?");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToTranslation",
                column: "Lang2",
                value: "Người mua");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType2",
                column: "Lang2",
                value: "Thương lái");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType3",
                column: "Lang2",
                value: "Lò mổ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SomethingWrong",
                column: "Lang2",
                value: "Đã xảy ra lỗi, vui lòng thử lại sau");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SowsServicedCostTranslation",
                column: "Lang2",
                value: "Tổng chi phí dịch vụ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "StartTranslation",
                column: "Lang2",
                value: "Bắt đầu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SubCountyTranslation",
                column: "Lang2",
                value: "Tỉnh");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartCostGroup",
                column: "Lang2",
                value: "Tổng chi phí");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartIncomeGroup",
                column: "Lang2",
                value: "Tổng thu nhập");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryCostTranslation",
                column: "Lang2",
                value: "Chi phí");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryIncomeTranslation",
                column: "Lang2",
                value: "Thu nhập");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Swahili",
                column: "Lang2",
                value: "Tiếng Swahili");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodNotProvided",
                column: "Lang2",
                value: "Thời gian chưa được cung cấp");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodTranslation",
                column: "Lang2",
                value: "Khoảng thời gian báo cáo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodUnitType1",
                column: "Lang2",
                value: "Tháng");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodUnitType2",
                column: "Lang2",
                value: "Năm");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAmountRepaidTranslation",
                column: "Lang2",
                value: "Tổng số tiền thanh toán");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAnimalCosts",
                column: "Lang2",
                value: "Tổng chi phí cho tất cả vật nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAnimalCostsTranslation",
                column: "Lang2",
                value: "Tổng chi phí cho tất cả vật nuôi");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalCost",
                column: "Lang2",
                value: "Tổng chi phí");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalCostAllUnits",
                column: "Lang2",
                value: "Tổng chi phí (tất cả các đơn vị)");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalCostTranslation",
                column: "Lang2",
                value: "Tổng chi phí");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalIncomeTranslation",
                column: "Lang2",
                value: "Tổng thu nhập");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalProfit",
                column: "Lang2",
                value: "Tổng lợi nhuận");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TransportationCostTranslation",
                column: "Lang2",
                value: "Chi phí vận chuyển");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TransportCostTrans",
                column: "Lang2",
                value: "Chi phí vận chuyển");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "UnitTrans",
                column: "Lang2",
                value: "Đơn vị");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Updated",
                column: "Lang2",
                value: "Cập nhật");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "UploadDataTranslation",
                column: "Lang2",
                value: "Tải lên");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "UserNameTranslation",
                column: "Lang2",
                value: "Tên tài khoản");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ViewReports",
                column: "Lang2",
                value: "Báo cáo");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Viilage",
                column: "Lang2",
                value: "Thôn/ bản:");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Village",
                column: "Lang2",
                value: "Thôn/bản");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VillageTranslation",
                column: "Lang2",
                value: "Thôn/bản");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Vitnamese",
                column: "Lang2",
                value: "Tiếng Việt");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VolumeSoldTranslation",
                column: "Lang2",
                value: "Khối lượng đã bán");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VolumeUnitType1",
                column: "Lang2",
                value: "Kilôgam");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VolumeUnitType2",
                column: "Lang2",
                value: "Bao");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Wait",
                column: "Lang2",
                value: "Vui lòng chờ trong giây lát");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Water",
                column: "Lang2",
                value: "Nước");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterCostTitleTranslation",
                column: "Lang2",
                value: "Nước");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterCostUpdated",
                column: "Lang2",
                value: "Thông tin chi phí nước đã được cập nhật");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterDurationTranslation",
                column: "Lang2",
                value: "Khoảng thời gian sử dụng nước");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterPurchasedTranslation",
                column: "Lang2",
                value: "Nước đã mua");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterPurchasedUnitType1",
                column: "Lang2",
                value: "Lít");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterPurchasedUnitType2",
                column: "Lang2",
                value: "Mét khối");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterSaved",
                column: "Lang2",
                value: "Thông tin nước đã được lưu");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WatherDurationTranslation",
                column: "Lang2",
                value: "Khoảng thời gian sử dụng nước");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WebAuthDescTranslation",
                column: "English",
                value: "The Pig Profit App authenticates with Google to securely authenticate your account and keep your data safe.");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WebAuthTitleTranslation",
                column: "Lang2",
                value: "Đăng ký");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhereAreYouLocatedTranslation",
                column: "Lang2",
                value: "Nơi ở của bạn?");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceTranslation",
                column: "Lang2",
                value: "Đơn vị cung cấp dịch vụ");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceType1",
                column: "Lang2",
                value: "Đơn vị cung cấp dịch vụ thụ tinh nhân tạo tư nhân");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceType2",
                column: "Lang2",
                value: "Đơn vị cung cấp dịch vụ thụ tinh nhân tạo nhà nước");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceType3",
                column: "Lang2",
                value: "Người chăn nuôi lợn đực giống");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "YearsExpectedTranslation",
                column: "Lang2",
                value: "Thời gian sử dụng chuồng trại dự kiến (tính theo năm)");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "YourChangesSaved",
                column: "Lang2",
                value: "Thay đổi của bạn đã được lưu");

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "RowKey", "English", "Lang1", "Lang2" },
                values: new object[] { "SendDataUploadTimeLabel", " new items since last upload at:", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SendDataUploadTimeLabel");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "About",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AddData",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AddFeedItemTrans",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPaidNotProvided",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPaidTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPurchasedTrans",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPurchasedTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountPurchasedUnitTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AmountRecievedTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchase",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType3",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchasedFromType4",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalPurchaseTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalSaved",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalType3",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnimalUpdated",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "AnyOtherPaymentTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingSaved",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceSale",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceSaleTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BreedingServiceType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "BrokerageTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Cancel",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CellTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ClientTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ClientType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CommentTrans",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CommentTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CommuneTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Costs",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CostTrans",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CostTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTypeRwanda",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTypeUganda",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountryTypeVietnam",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CountyTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "CurrencyTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DataHasBeenUploaded",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DataUploaded",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DateLastUploaded",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DateObtainedTrans",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DateTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DeleteConfirmation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DeleteTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DeleteVerify",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DistrictTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType10",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType11",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType12",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType13",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType14",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType15",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType16",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType17",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType18",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType19",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType3",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType4",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType5",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType6",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType7",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType8",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownFeedType9",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom3",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownPurchaseFrom4",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownUnitType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownUnitType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DropDownUnitType3",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "DurIsbefore",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EditData",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EditTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EmailTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "English",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Equipment",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentSaved",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType3",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentType4",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "EquipmentUpdated",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Error",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FailedToLoad",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Feed",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedDurationTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedItemTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedSaved",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedTypeTrans",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FeedUpdated",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FilterTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "FinishTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GenderType3",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GoogleAuth",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "GoogleSignUpTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Healthcare",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareCostTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthCareTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType3",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthProviderType4",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthSaved",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HealthUpdated",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType3",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType4",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType5",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HeathCareType6",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Hello",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Home",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Housing",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingExpenseType3",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "HousingTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Income",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Labour",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourDurationTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LabourTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType3",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType5",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LanguageType6",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LastData",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerAgreeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerBodyTranslation",
                column: "English",
                value: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerProceedTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LegalDisclaimerTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType3",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType4",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType5",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanProviderType6",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanRepayment",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanRepaymentTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanSaved",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoanUpdated",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "LoginButton",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureSale",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureSaleTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureSaved",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ManureUpdated",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineCostTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType3",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineType4",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MedicineTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Membership",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MemberShipSaved",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "MembershipTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Name",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NameTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoAmountRecevied",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoAnimalType",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoBrokerage",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoCountry",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoCurrency",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoDate",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoDateProvided",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoDurationEnd",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoDurationStart",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoFeedType",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoHealthCareCost",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoHousingExpense",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoMedicineCost",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoName",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherHealthCareYpe",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherLabourType",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherMediceType",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherMemberShip",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherPerson",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherPigType",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherProvider",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherPurcFrom",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherServiceProvider",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoOtherSoldTo",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoPaymentValue",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoPeriodUnit",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoPhoneNumber",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoPurchasedFrom",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoSalePrice",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoServiceType",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoSowsServiced",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoTotalAmount",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoTotalCost",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NotOtherClient",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoTransportationCost",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NoUsername",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NumberPurchasedTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NumberServicesTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "NumberSoldTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OK",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Other",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAmountPurchasedUnitTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAmountPurchaseTrans",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherAnimalPurchasedTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherClientTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostEvent",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostsSaved",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostsTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherCostUpdated",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherEqNotProvided",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherEquipmentTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherFeedTypeTrans",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherFeedTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherHealthCareTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherHousingExpenseTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncome",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncomeSaved",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncomeTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherIncomeUpdated",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherLaboutTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherLoanProviderTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherMedicineTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherMembershipTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPigTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherProviderTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPurchasedFromTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPurchasedUnitNotProvided",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherPurchasedWaterFromTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherServiceTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherSoldToTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherUnitNotProvided",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherWaterPurchasedTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherWhatForTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "OtherWhoProvidedServiceTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ParishTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PaymentType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PaymentTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PaymentValueTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PhoneNumberTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerAnimalTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerClientTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerCountryTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerCountyTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerCurrencyTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerDistrictTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerEquipmentTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerFeedTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerGenderTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerHealthCareTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerHousingExpenseTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerLabourTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerMedicineTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerMembershipTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerPaymentTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerPigTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerProviderTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerPurchasedFromTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerServiceTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerSoldToTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerSubCountyTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PickerUnitTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigSale",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigSaleSaved",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigSaleTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigSaleUpdated",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType3",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigType4",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PigTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ProviderTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ProvinceTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PruchaseFromType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PruchaseFromType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PruchaseFromType3",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedFrom",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedFromTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "PurchasedWaterFromType3",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RecordLabourCostSaved",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RecordLabourUpdated",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationSuccessfulContinueTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationSuccessfulDescTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationSuccessfulTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "RegistrationTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Reproduction",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReproductionSaved",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReproductionUpdated",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ReproductiveTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ResetTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SalePriceTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SaleSaved",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SaveHouseRecord",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SaveTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SectorTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SendingData",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ServiceType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ServiceType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ServiceTypeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SliderControlTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SoldToType3",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SomethingWrong",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SowsServicedCostTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "StartTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SubCountyTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartCostGroup",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryChartIncomeGroup",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryCostTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "SummaryIncomeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Swahili",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodNotProvided",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodUnitType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TimePeriodUnitType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAmountRepaidTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAnimalCosts",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalAnimalCostsTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalCost",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalCostAllUnits",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalCostTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalIncomeTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TotalProfit",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TransportationCostTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "TransportCostTrans",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "UnitTrans",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Updated",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "UploadDataTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "UserNameTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "ViewReports",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Viilage",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Village",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VillageTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Vitnamese",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VolumeSoldTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VolumeUnitType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "VolumeUnitType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Wait",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "Water",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterCostTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterCostUpdated",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterDurationTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterPurchasedTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterPurchasedUnitType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterPurchasedUnitType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WaterSaved",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WatherDurationTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WebAuthDescTranslation",
                column: "English",
                value: "The Pig Economic Tool authenticates with Google to securely authenticate your account and keep your data safe.");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WebAuthTitleTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhereAreYouLocatedTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceType1",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceType2",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "WhoProvidedServiceType3",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "YearsExpectedTranslation",
                column: "Lang2",
                value: "");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "RowKey",
                keyValue: "YourChangesSaved",
                column: "Lang2",
                value: "");
        }
    }
}
