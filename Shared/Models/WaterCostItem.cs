using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shared
{
    [Table("WaterCostItems")]
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
        public double? OtherCosts { get; set; }
        public string? Comment { get; set; }
        public DateTime DurationStart { get; set; }
        public DateTime DurationFinish { get; set; }
        public virtual string DateNiceFormat { get { return Date.ToString("dd/MMM/yyyy"); } }
        public virtual double? DisplayTotalCosts { get => OtherCosts + TotalCosts + TransportationCost; }
    }
}
