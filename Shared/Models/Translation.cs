using System;
using System.Collections.Generic;
using System.Text;
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
        public List<ControlData> ControlDatas { get; set; }

        public virtual ICollection<FeedItem> FeedItems { get; set; }
        public virtual ICollection<AnimalHouseItem> AnimalHouseItems { get; set; }
        public virtual ICollection<AnimalPurchaseItem> AnimalPurchaseItems { get; set; }
        public virtual ICollection<BreedingServiceSaleItem> BreedingServiceSaleItems { get; set; }
        public virtual ICollection<EquipmentItem> EquipmentItems { get; set; }
        public virtual ICollection<HealthCareItem> HealthCareItems { get; set; }
        public virtual ICollection<LabourCostItem> LabourCostItems { get; set; }
        public virtual ICollection<LoanRepaymentItem> LoanRepaymentItems { get; set; }
        public virtual ICollection<MembershipItem> MembershipItems { get; set; }
        public virtual ICollection<PigSaleItem> PigSaleItems { get; set; }
        public virtual ICollection<ReproductiveItem> ReproductiveItems { get; set; }
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
                default:
                    return English;
            }
        }
    }
}
