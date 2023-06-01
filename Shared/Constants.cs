using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public static class Constants
    {
        public const string MasterStorageConnectionString = "StorageConnectionString";
        public const string OTHER = "Other";
        public const string DATE_FORMAT_DMY = "dd/MMM/yyyy";

        #region API 

        public const string ROUTE_API_BASE = "/api";
        public const string ROUTE_API_VERSION = ROUTE_API_BASE + "/version";
        public const string ROUTE_API_STORAGE = ROUTE_API_BASE + "/storage";
        public const string ROUTE_API_DENIED = ROUTE_API_BASE + "/denied";

        public const string ROUTE_ACCOUNT_BASE = BASEURL + "Account/";
        public const string ROUTE_AUTH_REGISTERUSER = ROUTE_ACCOUNT_BASE + "/RegisterUser";
        public const string ROUTE_AUTH_TEST = ROUTE_ACCOUNT_BASE + "/Test";


        public const string ROUTE_API_DATA = ROUTE_API_BASE + "/data";
        public const string ROUTE_API_SUBMITDATA = ROUTE_API_DATA + "/SubmitData";

        public const string APICALLID = " API Service ID = ";

        public const string BASEURL = "https://pigprofittool.azurewebsites.net/";
        //public const string BASEURL = "http://10.0.2.2:5272";

        #endregion

        #region User Controls
        public const string ExistingUser = "ExistingUser";
        #endregion

        #region DropDown Key Controls
        //Feed Item DropDowns
        public const string FEEDTYPE = "FeedType";
        public const string FEEDAMOUNTPURCHASEDUNITTYPE = "FeedAmountPurchasedUnitType";
        public const string FEEDPURCHASEDFROMTYPE = "FeedPurchasedType";

        //HealthCare DropDwons
        public const string HEALTHCARETYPE = "HealthCareType";
        public const string HEALTHSERVICEPROVIDER = "HealthServivceProivderType";
        public const string HEALTHMEDICETYPE = "HealthMedicineType";
        public const string HEALTHPURCHASEFROMTYPE = "HealthPurchaseFromType";

        //Labour Cost
        public const string LABOURTYPE = "LabourType";

        //Housing 
        public const string HOUSINGTYPE = "HousingType";

        //Water Cost
        public const string WATERPURCHASEDUNITTYPE = "WaterPurchasedUnit";
        public const string PURCHASEDWATERFROMTYPE = "PurchasedWaterFrom";

        //Reproduction
        public const string SERVICETYPE = "ServiceUnit";
        public const string WHOPROVIDEDSERVICETYPE = "WhoProvidedServiceUnit";

        //Membership
        public const string MEMBERSHIPTYPE = "MembershipType";
        public const string TIMEPERIODUNITTYPE = "TimePeriodUnitType";

        // Animal Purchase
        public const string ANIMALTYPE = "AnimalType";
        public const string ANIMALPURCHASEDFROMTYPE = "AnimalPurchasedFrom";

        // Loan Repayment
        public const string LOANPROVIDERTYPE = "LoanProvider";

        // Equipment
        public const string EQUIPMENTTYPE = "EquipmentType";

        // PigSale
        public const string PIGTYPE = "PigSaleType";
        public const string SOLDTOTYPE = "SoldToType";

        // BreedingServiceSale
        public const string BREEDINGSERVICETYPE = "BreedingServiceType";
        public const string OTHERPAYMENTTYPE = "OtherPaymentType";
        public const string CLIENTTYPE = "ClientType";

        // ManureSale
        public const string VOLUMEUNITTYPE = "VolumeUnitType";
        //other payment from above
        public const string MANURESOLDTOTYPE = "ManureSoldToType";

        // User
        public const string GENDERTYPE = "GenderType";
        public const string DISTRICTTYPE = "DistrictType";
        public const string COUNTYTYPE = "CountyType";
        public const string COUNTRYTYPE = "CountryType";
        public const string SUBCOUNTYTYPE = "SubCountyType";
        public const string CURRENCYTYPE = "CurrencyType";

        public const string LANGUAGETYPE = "LanguageType";

        //CountrySelect
        public const string VIETNAMTYPE = "CountryTypeVietnam";
        public const string RWANDATYPE = "CountryTypeRwanda";
        public const string UGANDATYPE = "CountryTypeUganda";

        #endregion

        #region StorageTables
        public const string TABLEUSERS = "Users";
        public const string TABLEDATA = "Data";

        #endregion

        #region PartitionKeys
        public const string PartitionKeyUserInfo = "MobileUser";
        public const string PartitionKeyAnimalHouse = "AnimalHouse";
        public const string PartitionKeyFeed = "Feed";
        public const string PartitionKeyControlData = "ControlData";
        public const string PartitionKeyHealthCareItem = "HealthCare";
        public const string PartitionKeyLabourCostItem = "Labour";
        public const string PartitionKeyMembershipItem = "MemberShip";
        public const string PartitionKeyOtherCostItem = "OtherCost";
        public const string PartitionKeyReproductiveItem = "Reproductive";
        public const string PartitionKeyWaterCostItem = "Water";
        public const string PartitionKeyAnimalPurchaseItem = "AnimalPurchase";
        public const string PartitionKeyLoanRepaymentItem = "LoanRepayment";
        public const string PartitionKeyEquipmentItem = "Equipment";
        public const string PartitionKeyPigSaleItem = "PigSale";
        public const string PartitionKeyBreedingServiceSaleItem = "BreedingServiceSale";
        public const string PartitionKeyManureSaleItem = "ManureSale";
        public const string PartitionKeyOtherIncomeItem = "OtherIncome";

        #endregion

        #region Translation RowKeys
        public const string DeleteConfirmation = nameof(DeleteConfirmation);
        public const string OK = nameof(OK);
        public const string Cancel = nameof(Cancel);
        public const string DeleteVerify = nameof(DeleteVerify);
        public const string Updated = nameof(Updated);
        public const string Error = nameof(Error);
        public const string NoDate = nameof(NoDate);
        public const string NoTotalCost = nameof(NoTotalCost);
        public const string NoTransportationCost = nameof(NoTransportationCost);
        public const string NoHousingExpense = nameof(NoHousingExpense);
        public const string NoAnimalType = nameof(NoAnimalType);
        public const string NoPurchasedFrom = nameof(NoPurchasedFrom);
        public const string AnimalUpdated = nameof(AnimalUpdated);
        public const string AnimalSaved = nameof(AnimalSaved);
        public const string NoAmountRecevied = nameof(NoAmountRecevied);
        public const string NoPaymentValue = nameof(NoPaymentValue);
        public const string NoServiceType = nameof(NoServiceType);
        public const string NotOtherClient = nameof(NotOtherClient);
        public const string BreedingSaved = nameof(BreedingSaved);
        public const string SaleSaved = nameof(SaleSaved);
        public const string EquipmentUpdated = nameof(EquipmentUpdated);
        public const string EquipmentSaved = nameof(EquipmentSaved);
        public const string OtherEqNotProvided = nameof(OtherEqNotProvided);
        public const string FeedUpdated = nameof(FeedUpdated);
        public const string FeedSaved = nameof(FeedSaved);
        public const string DurIsbefore = nameof(DurIsbefore);
        public const string NoDurationStart = nameof(NoDurationStart);
        public const string NoDurationEnd = nameof(NoDurationEnd);
        public const string OtherPurchasedUnitNotProvided = nameof(OtherPurchasedUnitNotProvided);
        public const string NoOtherPurcFrom = nameof(NoOtherPurcFrom);
        public const string NoFeedType = nameof(NoFeedType);
        public const string HealthUpdated = nameof(HealthUpdated);
        public const string HealthSaved = nameof(HealthSaved);
        public const string NoOtherHealthCareYpe = nameof(NoOtherHealthCareYpe);
        public const string NoOtherProvider = nameof(NoOtherProvider);
        public const string NoOtherMediceType = nameof(NoOtherMediceType);
        public const string NoMedicineCost = nameof(NoMedicineCost);
        public const string NoHealthCareCost = nameof(NoHealthCareCost);
        public const string NoDateProvided = nameof(NoDateProvided);
        public const string RecordLabourUpdated = nameof(RecordLabourUpdated);
        public const string RecordLabourCostSaved = nameof(RecordLabourCostSaved);
        public const string AmountPaidNotProvided = nameof(AmountPaidNotProvided);
        public const string NoOtherLabourType = nameof(NoOtherLabourType);
        public const string LoanUpdated = nameof(LoanUpdated);
        public const string LoanSaved = nameof(LoanSaved);
        public const string NoTotalAmount = nameof(NoTotalAmount);
        public const string OtherUnitNotProvided = nameof(OtherUnitNotProvided);
        public const string ManureUpdated = nameof(ManureUpdated);
        public const string ManureSaved = nameof(ManureSaved);
        public const string NoOtherSoldTo = nameof(NoOtherSoldTo);
        public const string WaterCostUpdated = nameof(WaterCostUpdated);
        public const string MemberShipSaved = nameof(MemberShipSaved);
        public const string TimePeriodNotProvided = nameof(TimePeriodNotProvided);
        public const string NoPeriodUnit = nameof(NoPeriodUnit);
        public const string NoOtherMemberShip = nameof(NoOtherMemberShip);
        public const string OtherCostUpdated = nameof(OtherCostUpdated);
        public const string OtherCostsSaved = nameof(OtherCostsSaved);
        public const string OtherIncomeUpdated = nameof(OtherIncomeUpdated);
        public const string OtherIncomeSaved = nameof(OtherIncomeSaved);
        public const string PigSaleUpdated = nameof(PigSaleUpdated);
        public const string PigSaleSaved = nameof(PigSaleSaved);
        public const string NoSalePrice = nameof(NoSalePrice);
        public const string NoBrokerage = nameof(NoBrokerage);
        public const string NoOtherPigType = nameof(NoOtherPigType);
        public const string ReproductionUpdated = nameof(ReproductionUpdated);
        public const string ReproductionSaved = nameof(ReproductionSaved);
        public const string NoSowsServiced = nameof(NoSowsServiced);
        public const string NoOtherServiceProvider = nameof(NoOtherServiceProvider);
        public const string WaterSaved = nameof(WaterSaved);
        public const string NoOtherPerson = nameof(NoOtherPerson);
        public const string About = nameof(About);
        public const string NoCountry = nameof(NoCountry);
        public const string LastData = nameof(LastData);
        public const string Hello = nameof(Hello);
        public const string Viilage = nameof(Viilage);
        public const string FailedToLoad = nameof(FailedToLoad);
        public const string SendingData = nameof(SendingData);
        public const string NoUsername = nameof(NoUsername);
        public const string NoName = nameof(NoName);
        public const string NoPhoneNumber = nameof(NoPhoneNumber);
        public const string NoCurrency = nameof(NoCurrency);
        public const string DataUploaded = nameof(DataUploaded);
        public const string DataHasBeenUploaded = nameof(DataHasBeenUploaded);
        public const string Vitnamese = nameof(Vitnamese);
        public const string Swahili = nameof(Swahili);
        public const string English = nameof(English);
        public const string Wait = nameof(Wait);
        public const string GoogleAuth = nameof(GoogleAuth);
        public const string TotalCost = nameof(TotalCost);
        public const string TotalProfit = nameof(TotalProfit);
        public const string SomethingWrong = nameof(SomethingWrong);
        public const string YourChangesSaved = nameof(YourChangesSaved);
        public const string Created = nameof(Created);
        public const string SaveHouseRecord = nameof (SaveHouseRecord);
        public const string MembershipUpdated = nameof(MembershipUpdated);
        #endregion

    }
}
