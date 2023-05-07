using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shared
{
    [Table("LabourCostItems")]
    public class LabourCostItem : BaseItem
    {

        public DateTime Date { get; set; }
        public string? LabourType { get; set; }
        public string? OtherLabourType { get; set; }
        public double AmountPaid { get; set; }
        public double? OtherCost { get; set; }
        public string? Comment { get; set; }
        public DateTime DurationStart { get; set; }
        public DateTime DurationFinish { get; set; }
        [JsonIgnore]
        public virtual Translation? DisplayTypeTranslation { get; set; }
        public virtual string? DisplayTypeTranslationString { get; set; }
        public virtual string DateNiceFormat { get { return Date.ToString("dd/MMM/yyyy"); } }
    }
}
