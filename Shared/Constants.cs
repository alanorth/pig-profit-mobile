using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public static class Constants
    {
        public const string MasterStorageConnectionString = "StorageConnectionString";
        public const string OTHER = "Other";

        #region API URLS

        public const string ROUTE_API_BASE = "/api";
        public const string ROUTE_API_VERSION = ROUTE_API_BASE + "/version";
        public const string ROUTE_API_STORAGE = ROUTE_API_BASE + "/storage";


        public const string ROUTE_AUTH_BASE = "/auth";
        public const string ROUTE_AUTH_REGISTERUSER = ROUTE_AUTH_BASE + "/RegisterUser";
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
        #endregion


        #region StorageTables
        public const string TABLEUSERS = "Users";

        #endregion

    }
}
