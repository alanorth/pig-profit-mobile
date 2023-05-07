using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shared
{
    [Table("PigSaleItems")]
    public class PigSaleItem : BaseItem
    {
        public DateTime Date { get; set; }
        public string? PigType { get; set; }
        public string? OtherPigType { get; set; }
        public int? NumberSold { get; set; }
        public double SalePrice { get; set; }
        public string? SoldTo { get; set; }
        public string? OtherSoldTo { get; set; }
        //public double? Brokerage { get; set; }
        public double TransportationCost { get; set; }
        public double? OtherCosts { get; set; }
        public string? Comment { get; set; }
        [JsonIgnore]
        public virtual Translation? DisplayTypeTranslation { get; set; }
        public virtual string? DisplayTypeTranslationString { get; set; }
        public virtual string DateNiceFormat { get { return Date.ToString("dd/MMM/yyyy"); } }
    }
}
