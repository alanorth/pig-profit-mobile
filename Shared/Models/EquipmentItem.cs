using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class EquipmentItem : BaseItem
    {
        public DateTime Date { get; set; }
        public double TotalCosts { get; set; }
        public string? EquipmentType { get; set; }
        public string? OtherEquipmentType { get; set; }
        public double TransportationCost { get; set; }
        public double OtherCosts { get; set; }
        public string? Comment { get; set; }
    }
}
