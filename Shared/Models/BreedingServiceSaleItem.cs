﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class BreedingServiceSaleItem : BaseItem
    {
        public DateTime Date { get; set; }
        public string? ServiceType { get; set; }
        public string? OtherServiceType { get; set; }
        public int? NumberServices { get; set; }
        public double AmountRecieved { get; set; }
        public string? PaymentType { get; set; }
        public double PaymentValue { get; set; }
        public string? Client { get; set; }
        public string? OtherClient { get; set; }
        public double TransportationCost { get; set; }
        public double OtherCosts { get; set; }
        public string? Comment { get; set; }
    }
}