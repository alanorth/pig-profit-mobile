using System;
using System.Collections.Generic;
using System.Text;

namespace PigTool.Models
{
    public class AnimalHouseItem : BaseItem
    {
        DateTime Date { get; set; }
        string HousingExpense { get; set; }
        string OtherHousingExpense { get; set; }
        double? TotalCosts { get; set; }
        double? TransportationCost { get; set; }
        double? OtherCosts { get; set; }
        int YearsExpected { get; set; }
    }
}
