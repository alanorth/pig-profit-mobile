//using AspNetCore.Identity.Mongo.Model;
using ElCamino.AspNetCore.Identity.AzureTable.Model;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAuthenticateAPI.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Name { get; set; }
        public string? Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string? District { get; set; }
        public string? County { get; set; }
        public string? SubCounty { get; set; }
        public string? Parish { get; set; }
        public string? Village { get; set; }
        public string Currency { get; set; }

        public DateTime LastUploadDate { get; set; }
        public UserLangSettings UserLang { get; set; }
        public string AuthorisedToken { get; set; }
        public string AuthorisedEmail { get; set; }
        public DateTime LastModified { get; set; }


        public void updateUserFeilds(UserInfo mobileUserDetails)
        {
            Gender = mobileUserDetails.Gender;
            PhoneNumber = mobileUserDetails.PhoneNumber;
            Country = mobileUserDetails.Country;
            District = mobileUserDetails.District;
            County = mobileUserDetails.County;
            SubCounty = mobileUserDetails.SubCounty;
            Parish = mobileUserDetails.Parish;
            Village = mobileUserDetails.Village;
            Currency = mobileUserDetails.Currency;
            LastUploadDate = mobileUserDetails.LastUploadDate;
            AuthorisedToken = mobileUserDetails.AuthorisedToken;
            AuthorisedEmail = mobileUserDetails.AuthorisedEmail;
            LastModified = mobileUserDetails.LastModified;
        }

    }
}
