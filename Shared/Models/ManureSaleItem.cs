using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shared
{
    [Table("ManureSaleItems")]
    public class ManureSaleItem : BaseItem
    {
        public DateTime Date { get; set; }
        public double? VolumeSold { get; set; }
        public string? VolumeUnitType { get; set; }
        public double AmountRecieved { get; set; }
        public string? PaymentType { get; set; }
        public double PaymentValue { get; set; }
        public string? SoldTo { get; set; }
        public string? OtherSoldTo { get; set; }
        public double TransportationCost { get; set; }
        public double OtherCosts { get; set; }
        public string? Comment { get; set; }
    }
}
