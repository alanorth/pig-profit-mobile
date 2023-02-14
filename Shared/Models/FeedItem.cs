using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Azure;
using Azure.Data.Tables;
using Newtonsoft.Json;
using System;

namespace Shared
{
    [Table("FeedItems")]
    public class FeedItem : BaseItem
    {
        
        public DateTime Date { get; set; }
        public string? FeedType { get; set; }
        public string? OtherFeedType { get; set; }
        public double? AmountPurchased { get; set; }
        public double? OtherCosts { get; set; }
        public string? AmountPurchasedUnit { get; set; }
        public string? OtherAmountPurchaseUnit { get; set; }
        public double TotalCosts { get; set; }
        public double TransportationCost { get; set; }
        public string? PurchasedFrom { get; set; }
        public string? OtherPurchasedFrom { get; set; }
        public string? Comment { get; set; }
        public DateTime? DurationStart { get; set; }
        public DateTime? DurationFinish { get; set; }
        [JsonIgnore]
        public virtual Translation? FeedTypeTranslation { get; set; }
        public virtual string? FeedTypeTranslationString { get; set; }
    }
}
