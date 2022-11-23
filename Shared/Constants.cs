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

        public const string ROUTE_AUTH_BASE = "/MobileAuth";
        public const string ROUTE_AUTH_REGISTERUSER = ROUTE_AUTH_BASE + "/RegisterUser";
        public const string ROUTE_AUTH_TEST = ROUTE_AUTH_BASE + "/Test";


        public const string ROUTE_API_DATA = ROUTE_API_BASE + "/data";
        public const string ROUTE_API_SUBMITDATA = ROUTE_API_DATA + "/SubmitData";

        public const string APICALLID = " API Service ID = ";

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

    }
}
