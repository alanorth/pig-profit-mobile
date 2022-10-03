using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class APITransferItem : BaseItem 
    {
        public List<AnimalHouseItem>? AnimalHouseItems { get; set; }    
        public List<FeedItem>? FeedItems { get; set; }  
        public List<HealthCareItem>? HealthCareItems { get; set; }  
        public List<LabourCostItem>? LabourCostItems { get; set; }

        public List<MembershipItem>? MembershipItems { get; set; }  

        public List<OtherCostItem>? OtherCostItems { get; set; }

        public List<ReproductiveItem>? ReproductiveItems { get; set; }

        public List<WaterCostItem>? WaterCostItems { get; set; }
    }
}
