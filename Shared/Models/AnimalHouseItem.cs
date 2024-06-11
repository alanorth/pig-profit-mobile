using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shared
{
    [Table("AnimalHouseItems")]
    public class AnimalHouseItem : BaseItem
    {
        
        public DateTime Date { get; set; }
        public string? HousingExpense { get; set; }
        public string? OtherHousingExpense { get; set; }
        public double TotalCosts { get; set; }
        public double TransportationCost { get; set; }
        public double? OtherCosts { get; set; }
        public int? YearsExpected { get; set; }
        public string? Comment { get; set; }
        public DateTime? DurationStart { get => Date; }
        public DateTime? DurationFinish => YearsExpected == null ? Date : Date.AddYears((int)YearsExpected).AddDays(-1) ;

        private DateTime DateHolder;
        [JsonIgnore]
        [ForeignKey("RowKey")]
        public virtual Translation? AnimalExpenseTranslation { get; set; }
        public virtual string? AnimalExpenseTranslationString { get; set; }
        public virtual string DateNiceFormat { get { return Date.ToString("dd/MMM/yyyy"); } }
        public virtual double? DisplayTotalCosts { get => OtherCosts + TotalCosts + TransportationCost; }

        public double? GettheDailyCosts()
        {
            if (YearsExpected == null)
            {
                return 0.0;
            }
            else
            {
                var cosst = TotalCosts + TransportationCost + OtherCosts;
                var duration = DurationFinish - DurationStart;
                var days = duration?.TotalDays;
                return cosst / days;
            }
        }
    } 
}
