using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class AnimalPurchaseItem : BaseItem
    {
        public DateTime Date { get; set; }
        public string? AnimalType { get; set; }
        public string? OtherAnimalType { get; set; }
        public int? NumberPurchased { get; set; }
        public double TotalCosts { get; set; }
        public string? AnimalPurchasedFrom { get; set; }
        public string? OtherAnimalPurchasedFrom { get; set; }
        public double TransportationCost { get; set; }
        public double OtherCosts { get; set; }
        public string? Comment { get; set; }
    }
}
