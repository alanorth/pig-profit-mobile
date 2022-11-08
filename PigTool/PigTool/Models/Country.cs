using System;
using System.Collections.Generic;
using System.Text;
using Azure;
using Azure.Data.Tables;

namespace Shared
{
    public class Country
    {
        public string CountryName { get; set; }
        public CountryEnum CountryEnum { get; set; }

    }
    public enum CountryEnum
    {
        Country1,
        Country2,
        Country3
    }

}
