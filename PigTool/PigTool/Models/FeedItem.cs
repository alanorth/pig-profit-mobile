using System;
using System.Collections.Generic;
using System.Text;

namespace PigTool.Models
{
    public class FeedItem : BaseItem
    {
        public DateTime DateObtained { get; set; }
        public string FeedType { get; set; }
        public string OtherFeedType { get; set; }
        public int AmountPurchased { get; set; }
        public string AmountPurchasedUnit { get; set; }
        public string OtherAmountPurchaseUnit { get; set; }
        public int Cost { get; set; }
        public int TransportationCost { get; set; }
        public string PurchasedFrom { get; set; }
        public string Comment { get; set; }
    }
}
