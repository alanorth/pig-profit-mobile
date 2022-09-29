using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class ReproductiveItem : BaseItem
    {
        public DateTime Date { get; set; }
        public string? ServiceType { get; set; }
        public string? OtherServiceType { get; set; }
        public int SowsServiced { get; set; }
        public string? WhoProvidedService { get; set; }
        public string? OtherWhoProvidedService { get; set; }
        public double OtherCosts { get; set; }
        public string? Comment { get; set; }
    }
}
