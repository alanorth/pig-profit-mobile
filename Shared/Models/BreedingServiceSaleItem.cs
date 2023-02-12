using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Shared
{
    [Table("BreedingServiceSaleItems")]
    public class BreedingServiceSaleItem : BaseItem
    {
        public DateTime Date { get; set; }
        public string? ServiceType { get; set; }
        public string? OtherServiceType { get; set; }
        public int? NumberServices { get; set; }
        public double AmountRecieved { get; set; }
        public string? PaymentType { get; set; }
        public double? PaymentValue { get; set; }
        public string? Client { get; set; }
        public string? OtherClient { get; set; }
        public double TransportationCost { get; set; }
        public double? OtherCosts { get; set; }
        public string? Comment { get; set; }
        [JsonIgnore]
        public virtual Translation? DisplayTypeTranslation { get; set; }
        public virtual string? DisplayTypeTranslationString { get; set; }
    }
}
