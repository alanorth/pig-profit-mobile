using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using PigTool.API.Services;
using Microsoft.Extensions.Configuration;
using Shared;
using Microsoft.WindowsAzure.Storage.Table;
using Newtonsoft.Json;
using PigTool.API.Tests;
using System.Collections.Concurrent;

namespace PigTool.API.Controllers
{
    [Tags("Data Services")]
    [ApiController]
    public class DataAPIController : PigToolBaseController
    {
        public DataAPIController(

        IConfiguration config) : base(config)
        {

        }

        

        [HttpPost, Route(Constants.ROUTE_API_SUBMITDATA)]
        public async Task<ActionResult> SubmitData()
        {
            var callGUID = Guid.NewGuid().ToString();
            var Connection = GetStorageConnectionString();


            try
            {
                var requestJson = await Parse(Request);
                var unparsedRequest = requestJson.Body;
                var transferitems = new APITransferItem();
                var requeststring = Convert.ToString(unparsedRequest);

#if DEBUG
                requeststring = Mocks.ConstructAPIItem();
#endif
                //Log response
                await LoggingOperations.LogRequestToBlob("SUBMITDATA", "POST", requeststring, callGUID, Connection);

                //Get the data from the request
                transferitems = JsonConvert.DeserializeObject<APITransferItem>(requeststring);
                var result = string.Empty;
               
                var opertions = new TableOperations();

                //AnimalHouse
                result = await opertions.InsertTableEntities(transferitems.AnimalHouseItems, Constants.TABLEDATA, Connection);
                //Feed
                result = await opertions.InsertTableEntities(transferitems.FeedItems, Constants.TABLEDATA, Connection);
                //Helthcare
                result = await opertions.InsertTableEntities(transferitems.HealthCareItems, Constants.TABLEDATA, Connection);
                //Labourcosts
                result = await opertions.InsertTableEntities(transferitems.LabourCostItems, Constants.TABLEDATA, Connection);
                //Memberships
                result = await opertions.InsertTableEntities(transferitems.MembershipItems, Constants.TABLEDATA, Connection);
                //Other costs
                result = await opertions.InsertTableEntities(transferitems.OtherCostItems, Constants.TABLEDATA, Connection);
                //Reproductive
                result = await opertions.InsertTableEntities(transferitems.ReproductiveItems, Constants.TABLEDATA, Connection);
                //Water costs
                result = await opertions.InsertTableEntities(transferitems.WaterCostItems, Constants.TABLEDATA, Connection);


            }
            catch (Exception ex)
            {
                var result = new ContentResult
                {
                    Content = $"Failed to create data " + Constants.APICALLID + callGUID,
                    ContentType = "text/plain"
                };

                await LoggingOperations.LogRequestToBlob("SUBMITDATA", "RESPONSE", result.Content, callGUID, Connection);

                return result;
            }

            var contentresult = new ContentResult()
            {
                Content = $"Data Created" + Constants.APICALLID + callGUID,
                ContentType = "text/plain"
            };

            await LoggingOperations.LogRequestToBlob("SUBMITDATA", "RESPONSE", contentresult.Content, callGUID, Connection);
            return contentresult;
        }



    }
}
