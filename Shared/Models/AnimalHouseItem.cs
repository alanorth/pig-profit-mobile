using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
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
    } 
}
