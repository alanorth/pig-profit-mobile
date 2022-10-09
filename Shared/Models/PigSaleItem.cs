using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class PigSaleItem : BaseItem
    {
        public DateTime Date { get; set; }
        public string? PigType { get; set; }
        public string? OtherPigType { get; set; }
        public int? NumberSold { get; set; }
        public double SalePrice { get; set; }
        public string? SoldTo { get; set; }
        public string? OtherSoldTo { get; set; }
        public double Brokerage { get; set; }
        public double TransportationCost { get; set; }
        public double OtherCosts { get; set; }
        public string? Comment { get; set; }
    }
}
