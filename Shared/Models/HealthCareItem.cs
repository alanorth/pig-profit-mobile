using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shared
{
    [Table("HealthCareItems")]
    public class HealthCareItem : BaseItem
    {
        public DateTime Date { get; set; }
        public string? HealthCareType { get; set; }
        public string? OtherHealthCareType { get; set; }
        public double HealthCareCost { get; set; }
        public string? Provider { get; set; }
        public string? OtherProvider { get; set; }
        public double MedicineCost { get; set; }
        public string? MedicineType { get; set; }
        public string? OtherMedicineType { get; set; }
        public string? PurchasedFrom { get; set; }
        public string? OtherPurchasedFrom { get; set; }
        public double TransportationCost { get; set; }
        public double? OtherCosts { get; set; }
        public string? Comment { get; set; }
        [JsonIgnore]
        public virtual Translation? DisplayTypeTranslation { get; set; }
        public virtual string? DisplayTypeTranslationString { get; set; }
        public virtual string DateNiceFormat { get { return Date.ToString("dd/MMM/yyyy"); }}

    }
}
