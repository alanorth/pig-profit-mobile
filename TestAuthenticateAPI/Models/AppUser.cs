//using AspNetCore.Identity.Mongo.Model;
using ElCamino.AspNetCore.Identity.AzureTable.Model;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAuthenticateAPI.Models
{
    public class APIUser : IdentityUser
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
        public string? Currency { get; set; }
        public string? Province { get; set; }
        public string? Commune { get; set; }
        public string? Sector { get; set; }
        public string? Cell { get; set; }

        public DateTime LastUploadDate { get; set; }
        public UserLangSettings UserLang { get; set; }
        public string AuthorisedToken { get; set; }
        public string AuthorisedEmail { get; set; }
        public DateTime LastModified { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }


        public void updateUserFeilds(MobileUser mobileUserDetails)
        {
            Gender = mobileUserDetails.Gender;
            PhoneNumber = mobileUserDetails.PhoneNumber;
            Country = mobileUserDetails.Country;
            District = mobileUserDetails.District;
            County = mobileUserDetails.County;
            SubCounty = mobileUserDetails.SubCounty;
            Parish = mobileUserDetails.Parish;
            Village = mobileUserDetails.Village;
            Province = mobileUserDetails.Province;
            Commune = mobileUserDetails.Commune;
            Sector = mobileUserDetails.Sector;
            Cell = mobileUserDetails.Cell;

            //Currency = mobileUserDetails.Currency;
            LastUploadDate = mobileUserDetails.LastUploadDate;
            AuthorisedToken = mobileUserDetails.AuthorisedToken;
            AuthorisedEmail = mobileUserDetails.AuthorisedEmail;
            LastModified = mobileUserDetails.LastModified;
            Name = mobileUserDetails.Name;
        }

        public Dictionary<string, string> ReturnDisreteUserVariablesInDiction()
        {
            Dictionary<string, string> variables = new Dictionary<string, string>();

            if (Name != null)
            {
                variables.Add(nameof(Name), Name);
            }
            if (Gender != null)
            {
                variables.Add(nameof(Gender), Gender);
            }
            if (Email != null)
            {
                variables.Add(nameof(Email), Email);
            }
            if (PhoneNumber != null)
            {
                variables.Add(nameof(PhoneNumber), PhoneNumber);
            }
            if (Country != null)
            {
                variables.Add(nameof(Country), Country);
            }
            if (District != null)
            {
                variables.Add(nameof(District), District);
            }
            if (County != null)
            {
                variables.Add(nameof(County), County);
            }
            if (SubCounty != null)
            {
                variables.Add(nameof(SubCounty), SubCounty);
            }
            if (Parish != null)
            {
                variables.Add(nameof(Parish), Parish);
            }
            if (Village != null)
            {
                variables.Add(nameof(Village), Village);
            }
            if(Province != null)
            {
                variables.Add(nameof(Province), Province);
            }
            if (Commune != null)
            {
                variables.Add(nameof(Commune), Commune);
            }
            if (Sector != null)
            {
                variables.Add(nameof(Sector), Sector);
            }
            if (Cell != null)
            {
                variables.Add(nameof(Cell), Cell);
            }

            return variables;

        }

    }
}
