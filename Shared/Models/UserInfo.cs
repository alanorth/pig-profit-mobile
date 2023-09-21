using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;
using Azure;
using Azure.Data.Tables;

namespace Shared
{
    public class MobileUser : ITableEntity
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        //Phone could include country code so set to string
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string? District { get; set; }
        public string? County { get; set; }
        public string? SubCounty { get; set; }
        public string? Parish { get; set; }
        public string? Village { get; set; }

        public string? Province { get; set; }
        public string? Commune { get; set; }
        public string? Sector { get; set; }
        public string? Cell { get; set; }

        //public string? Currency {  get; set; }

        public DateTime LastUploadDate { get; set; }
        public UserLangSettings UserLang { get; set; }
        public string AuthorisedToken {get; set;}
        public string AuthorisedEmail { get; set; }
        public string? AuthorisedUserName { get; set; }
        public DateTime LastModified { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }

        public virtual string PartitionKey { get; set; }
        public virtual string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
        public Dictionary<string, string> ReturnDisreteUserVariablesInDiction()
        {
            Dictionary<string, string> variables = new Dictionary<string, string>();

            if(Name != null)
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
            if (Province != null)
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

        public CultureInfo GetCultureInfo()
        {
            
            //good idea, unfortuneatly not many African Countires are not supported in CulturalInfo class
            switch (UserLang)
            {
                case UserLangSettings.Eng:
                    return new CultureInfo("lg"); 
                case UserLangSettings.Lang1:
                    //Uganda
                    return new CultureInfo("lg");
                case UserLangSettings.Lang2:
                    //Vietnamese
                    return new CultureInfo("vi");
                case UserLangSettings.Lang3:
                    //rw-RW
                    return new CultureInfo("rw");
                default:
                    return new CultureInfo("en-GB");
            }
        }

        public string CurrencySymbol()
        {
            switch (Country) {
                case Constants.UGANDATYPE:
                    return "USh"; //Uganda
                case Constants.VIETNAMTYPE:
                    return "VND "; //Vietnamese
                case Constants.RWANDATYPE:
                    return "RWF"; // Rawanda
                default:
                    return ""; 
            }
        }
    }
    public enum UserLangSettings
    {
        Eng,
        Lang1,
        Lang2,
        Lang3
    }

}
