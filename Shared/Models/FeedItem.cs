using System;
using Newtonsoft.Json;

namespace Shared
{
    public class FeedItem : BaseItem
    {
        public DateTime Date { get; set; }
        public string? FeedType { get; set; }
        public string? OtherFeedType { get; set; }
        public double? AmountPurchased { get; set; }
        public string? AmountPurchasedUnit { get; set; }
        public string? OtherAmountPurchaseUnit { get; set; }
        public double TotalCosts { get; set; }
        public double TransportationCost { get; set; }
        public string? PurchasedFrom { get; set; }
        public string? OtherPurchasedFrom { get; set; }
        public string? Comment { get; set; }
        [JsonIgnore]
        public virtual Translation FeedTypeTranslation { get; set; }
        public virtual string FeedTypeTranslationString { get; set; }
    }
}
