using System;

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
        public DateTime DurationStart { get; set; }
        public DateTime DurationFinish { get; set; }
    }
}
