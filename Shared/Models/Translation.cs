using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Shared;

namespace Shared
{
    public class Translation
    {
        public string RowKey { get; set; }
        public string PartitionKey { get; }
        public string English { get; set; }
        public string Lang1 { get; set; }
        public string Lang2 { get; set; }
        public string Lang3 { get; set; }
        public List<ControlData> ControlDatas { get; set; }
        [JsonIgnore]
        public virtual ICollection<FeedItem> FeedItems { get; set; }
        [JsonIgnore]
        public virtual ICollection<AnimalHouseItem> AnimalHouseItems { get; set; }
        [JsonIgnore]
        public virtual ICollection<AnimalPurchaseItem> AnimalPurchaseItems { get; set; }
        [JsonIgnore]
        public virtual ICollection<BreedingServiceSaleItem> BreedingServiceSaleItems { get; set; }
        [JsonIgnore]
        public virtual ICollection<EquipmentItem> EquipmentItems { get; set; }
        [JsonIgnore]
        public virtual ICollection<HealthCareItem> HealthCareItems { get; set; }
        [JsonIgnore]
        public virtual ICollection<LabourCostItem> LabourCostItems { get; set; }
        [JsonIgnore]
        public virtual ICollection<LoanRepaymentItem> LoanRepaymentItems { get; set; }
        [JsonIgnore]
        public virtual ICollection<MembershipItem> MembershipItems { get; set; }
        [JsonIgnore]
        public virtual ICollection<PigSaleItem> PigSaleItems { get; set; }
        [JsonIgnore]
        public virtual ICollection<ReproductiveItem> ReproductiveItems { get; set; }
        [JsonIgnore]
        public virtual ICollection<ManureSaleItem> ManureSaleItems { get; set; }

        public Translation()
        {
            PartitionKey = "Translation";
        }

        public string getTranslation(UserLangSettings lang)
        {
            switch (lang)
            {
                case UserLangSettings.Eng:
                    return English;
                case UserLangSettings.Lang1:
                    return Lang1;
                case UserLangSettings.Lang2:
                    return Lang2;
                case UserLangSettings.Lang3:
                    return Lang3;
                default:
                    return English;
            }
        }
    }
}
