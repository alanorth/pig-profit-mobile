using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using PigTool.API.Services;
using Microsoft.Extensions.Configuration;
using Shared;
using Azure.Data.Tables;
//using Microsoft.WindowsAzure.Storage.Table;
using Newtonsoft.Json;
using PigTool.API.Tests;
using System.Collections.Concurrent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.Extensions.Options;

namespace PigTool.API.Controllers
{
    [Tags("Data Services")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = AuthSchemes)]
    public class DataAPIController : PigToolBaseController
    {
        public DataAPIController(

        IConfiguration config) : base(config)
        {

        }

        [HttpPost, Route(Constants.ROUTE_API_SUBMITDATA)]
        //[Authorize]
        //[Authorize(AuthenticationSchemes = "Google")]
        public async Task<ActionResult> SubmitData()
        {
            /*
           var  requeststring = Mocks.ConstructAPIItem();

            var callGUID = Guid.NewGuid().ToString();
            var Connection = GetStorageConnectionString();
            
            var transferitems = JsonConvert.DeserializeObject<APITransferItem>(requeststring);
            var opertions = new TableOperations();
            var result = await opertions.InsertTableEntities(transferitems.AnimalHouseItems, Constants.TABLEDATA, Connection);

            var contentresult = new ContentResult()
            {
                Content = $"Data Created" + Constants.APICALLID + callGUID,
                ContentType = "text/plain"
            };

            await LoggingOperations.LogRequestToBlob("SUBMITDATA", "RESPONSE", contentresult.Content, callGUID, Connection);
            return contentresult;*/

            var callGUID = Guid.NewGuid().ToString();
            var Connection = GetStorageConnectionString();
            try
            {
                var requestJson = await Parse(Request);
                var unparsedRequest = requestJson.Body;
                var transferitems = new APITransferItem();
                var requeststring = Convert.ToString(unparsedRequest);

#if DEBUG
                if (requeststring == null)
                {
                    requeststring = Mocks.ConstructAPIItem();
                }



#endif
                //Log response
                await LoggingOperations.LogRequestToBlob("SUBMITDATA", "POST", requeststring, callGUID, Connection);

                //Get the data from the request
                transferitems = JsonConvert.DeserializeObject<APITransferItem>(requeststring);
                var result = string.Empty;

                var opertions = new TableOperations();

                
                //Feed
                result = await opertions.InsertTableEntities(transferitems.FeedItems, Constants.TABLEDATA, Connection);
                //Helthcare
                result = await opertions.InsertTableEntities(transferitems.HealthCareItems, Constants.TABLEDATA, Connection);
                //Labourcosts
                result = await opertions.InsertTableEntities(transferitems.LabourCostItems, Constants.TABLEDATA, Connection);
                //AnimalHouse
                result = await opertions.InsertTableEntities(transferitems.AnimalHouseItems, Constants.TABLEDATA, Connection);
                //Water costs
                result = await opertions.InsertTableEntities(transferitems.WaterCostItems, Constants.TABLEDATA, Connection);
                //Reproductive
                result = await opertions.InsertTableEntities(transferitems.ReproductiveItems, Constants.TABLEDATA, Connection);
                //Memberships
                result = await opertions.InsertTableEntities(transferitems.MembershipItems, Constants.TABLEDATA, Connection);
                //Other costs
                result = await opertions.InsertTableEntities(transferitems.OtherCostItems, Constants.TABLEDATA, Connection);
                //Animal Purchase
                result = await opertions.InsertTableEntities(transferitems.AnimalPurchaseItems, Constants.TABLEDATA, Connection);
                //Loan Payment
                result = await opertions.InsertTableEntities(transferitems.LoanRepaymentItems, Constants.TABLEDATA, Connection);
                //Equipment
                result = await opertions.InsertTableEntities(transferitems.EquipmentItems, Constants.TABLEDATA, Connection);

                //Sale of Pigs
                result = await opertions.InsertTableEntities(transferitems.PigSaleItems, Constants.TABLEDATA, Connection);
                //Sale of Breeding Services
                result = await opertions.InsertTableEntities(transferitems.BreedingServiceSaleItems, Constants.TABLEDATA, Connection);
                //Sale of Manure
                result = await opertions.InsertTableEntities(transferitems.ManureSaleItems, Constants.TABLEDATA, Connection);
                //Other income
                result = await opertions.InsertTableEntities(transferitems.OtherIncomeItems, Constants.TABLEDATA, Connection);




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

        [HttpGet, Route(Constants.ROUTE_API_DATA + "/GetUser")]
        public async Task<ActionResult> GetUser(string name)
        {

            var requestJson = await Parse(Request);
            var unparsedRequest = requestJson.Body;
            var requeststring = Convert.ToString(unparsedRequest);

            try
            {
                var operations = new TableOperations();

                var userInfo = await operations.GetSingleEntityItem("Data", GetStorageConnectionString(), "User", name);


                if (userInfo != null)
                {
                    var userString = JsonConvert.SerializeObject(userInfo);

                    var contentResult = new ContentResult
                    {
                        ContentType = "text/plain",
                        Content = userString,
                        StatusCode = 202,
                    };

                    return contentResult;
                }


                else return StatusCode(203, "No User Exists");
            }
            catch
            {
                var contentResult = new ContentResult
                {
                    ContentType = "text/plain",
                    Content = "User Auth Failed",
                    StatusCode = 401,
                };

                return contentResult;
            }

        }


        [HttpPost, Route(Constants.ROUTE_API_DATA + "/AddUser")]
        public async Task<ActionResult> RegisterUsers()
        {
            try
            {
                var requestJson = await Parse(Request);
                var unparsedRequest = requestJson.Body;
                var requeststring = Convert.ToString(unparsedRequest);
                var user = JsonConvert.DeserializeObject<MobileUser>(requeststring);


                var operations = new TableOperations();

                var result = await operations.InsertTableEntities(new List<MobileUser> { user }, "Data", GetStorageConnectionString());

                if (string.IsNullOrEmpty(result))
                {
                    return new ContentResult();
                }

                var Contentresult = new ContentResult
                {
                    Content = $"Failed to createUser " + result,
                    ContentType = "text/plain",
                    StatusCode = 501
                };

                return Contentresult;

            }
            catch (Exception ex)
            {
                var result = new ContentResult
                {
                    Content = $"Failed to createUser",
                    ContentType = "text/plain",
                    StatusCode = 501
                };

                return result;
            }

        }

    }
}
