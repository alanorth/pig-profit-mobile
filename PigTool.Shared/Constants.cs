using System;
using System.Collections.Generic;
using System.Text;

namespace PigTool.Shared
{
    public static class Constants
    {
        public const string MasterStorageConnectionString = "StorageConnectionString";


        public const string ROUTE_AUTH_BASE = "/auth-api";
        public const string ROUTE_AUTH_VERSION = ROUTE_AUTH_BASE + "/version";
        public const string ROUTE_AUTH_STORAGE = ROUTE_AUTH_BASE + "/storage";
    }
}
