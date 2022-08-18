using System;
using System.Collections.Generic;
using System.Text;

namespace PigTool.Models
{
    public class HealthCareItem : BaseItem
    {
        public DateTime Date { get; set; }
        public string HealthCareType { get; set; }
        public string OtherHealthCareType { get; set; }
        public double? HealthCareCost { get; set; }
        public string Provider { get; set; }
        public string OtherProvider { get; set; }
        public double? MedicineCost { get; set; }
        public string MedinceType { get; set; }
        public string OtherMedinceType { get; set; }
        public string PurchasedFrom { get; set; }
        public string OtherPurchasedFrom { get; set; }
        public double? Cost { get; set; }
        public double? TransportationCost { get; set; }
        public string Comment { get; set; }

    }
}
