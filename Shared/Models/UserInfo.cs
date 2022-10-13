using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.Storage.Table;

namespace Shared
{
    public class UserInfo : TableEntity
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        //Phone could include country code so set to string
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string? District { get; set; }
        public string County { get; set; }
        public string? SubCounty { get; set; }
        public string? Parish { get; set; }
        public string? Village { get; set; }
        public string Currency {  get; set; }

        public DateTime LastUploadDate { get; set; }
        public UserLangSettings UserLang { get; set; }
        public DateTime LastModified { get; set; }

    }
    public enum UserLangSettings
    {
        Eng,
        Lang1,
        Lang2
    }

}
