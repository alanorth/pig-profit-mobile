using System;
using System.Collections.Generic;
using System.Text;

namespace PigTool.Models
{
    public class WaterCostItem : BaseItem
    {
        public DateTime Date { get; set; }
        public double? WaterPurchased { get; set; }
        public string? WaterPurchasedUnit { get; set; }
        public string? OtherWaterPurchasedUnit { get; set; }
        public double TotalCosts { get; set; }
        public string? PurchasedWaterFrom { get; set; }
        public string? OtherPurchasedWaterFrom { get; set; }
        public double TransportationCost { get; set; }
        public double OtherCosts { get; set; }
        public string? Comment { get; set; }
    }
}
