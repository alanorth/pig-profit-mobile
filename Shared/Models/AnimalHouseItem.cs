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
        public double OtherCosts { get; set; }
        public int? YearsExpected { get; set; }
        public string? Comment { get; set; }

        private DateTime DateHolder;
        [JsonIgnore]
        [ForeignKey("RowKey")]
        public virtual Translation? AnimalExpenseTranslation { get; set; }
        public virtual string? AnimalExpenseTranslationString { get; set; }
    } 
}
