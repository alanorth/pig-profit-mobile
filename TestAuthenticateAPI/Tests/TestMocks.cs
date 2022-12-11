using Shared;
using System;
using System.Text.Json;

namespace PigTool.API.Tests
{
    public static class Mocks
    {
        public static string ConstructAPIItem()
        {
            var mockdate = DateTime.UtcNow;
            

            var item = new APITransferItem
            {
                AnimalHouseItems = new List<AnimalHouseItem> { 
                    new AnimalHouseItem { PartitionKey = Constants.PartitionKeyAnimalHouse,
                    RowKey = Guid.NewGuid().ToString(),
                    CreatedTimeStamp = mockdate,
                    LastModified = mockdate,
                    Timestamp = mockdate,
                    CreatedBy = "API Test Mocks",
                    Date = mockdate,
                    TotalCosts = 56.26,
                    TransportationCost = 566,
                    OtherCosts = 26,} 
                },
                FeedItems = new List<FeedItem>{new  FeedItem
                {
                    PartitionKey = Constants.PartitionKeyFeed,
                    RowKey = Guid.NewGuid().ToString(),
                    CreatedTimeStamp = mockdate,
                    LastModified = mockdate,
                    Timestamp = mockdate,
                    CreatedBy = "API Test Mocks",
                    Date = mockdate,
                    TotalCosts = 559.33,
                    TransportationCost = 66.66,
                    FeedTypeTranslation = new Translation { RowKey = "FeedTypeTranslation", English = "Feed Type", Lang1 = "Feed Type Lang1", Lang2 = "Feed Type Lang2" },
                    FeedTypeTranslationString = "FeedTypeTranslation"
                } }
                //HealthCare = new HealthCareItem
                //{  

                //},
                //LabourCost = new LabourCostItem 
                //{
                    
                //},
                //Membership = new MembershipItem 
                //{  
                
                //},
                //OtherCost = new OtherCostItem 
                //{  

                //},
                //Reproductive = new ReproductiveItem 
                //{
                
                //},
                //MobileUser = new MobileUser  
                //{
                
                //},
                //WaterCost = new WaterCostItem  
                //{
                
                //}


    };


            return JsonSerializer.Serialize(item); ;

        }


    }
}
