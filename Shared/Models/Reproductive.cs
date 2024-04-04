using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shared
{
    [Table("ReproductiveItems")]
    public class ReproductiveItem : BaseItem
    {
        public DateTime Date { get; set; }
        public string? ServiceType { get; set; }
        public string? OtherServiceType { get; set; }
        public double SowsServicedCost { get; set; }
        public string? WhoProvidedService { get; set; }
        public string? OtherWhoProvidedService { get; set; }
        public double? OtherCosts { get; set; }
        public double?TransportCost { get; set; }
        public string? Comment { get; set; }
        [JsonIgnore]
        public virtual Translation? DisplayTypeTranslation { get; set; }
        public virtual string? DisplayTypeTranslationString { get; set; }
        public virtual string DateNiceFormat { get { return Date.ToString("dd/MMM/yyyy"); } }
        public virtual double? DisplayTotalCosts { get => OtherCosts + SowsServicedCost + TransportCost; }

    }
}
