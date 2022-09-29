using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{ 
    public class LabourCostItem : BaseItem
    {

        public DateTime Date { get; set; }
        public string? LabourType { get; set; }
        public string? OtherLabourType { get; set; }
        public double AmountPaid { get; set; }
        public double OtherCost { get; set; }
        public string? Comment { get; set; }
    }
}
