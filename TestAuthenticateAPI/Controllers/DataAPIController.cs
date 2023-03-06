using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using Microsoft.Extensions.Configuration;
using Shared;
using Azure.Data.Tables;
//using Microsoft.WindowsAzure.Storage.Table;
using Newtonsoft.Json;
using PigTool.API.Tests;
using TestAuthenticateAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Shared.Models;
using Azure.Core;

namespace TestAuthenticateAPI.Controllers
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

        [Authorize]
        [HttpPost, Route(Constants.ROUTE_API_SUBMITDATA)]
        public async Task<ActionResult> SubmitData()
        {
            var responseModel = new DataUploadResponse
            {
                Success = false
            };

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
                result += await opertions.InsertTableEntities(transferitems.HealthCareItems, Constants.TABLEDATA, Connection);
                //Labourcosts
                result += await opertions.InsertTableEntities(transferitems.LabourCostItems, Constants.TABLEDATA, Connection);
                //AnimalHouse
                result += await opertions.InsertTableEntities(transferitems.AnimalHouseItems, Constants.TABLEDATA, Connection);
                //Water costs
                result += await opertions.InsertTableEntities(transferitems.WaterCostItems, Constants.TABLEDATA, Connection);
                //Reproductive
                result += await opertions.InsertTableEntities(transferitems.ReproductiveItems, Constants.TABLEDATA, Connection);
                //Memberships
                result += await opertions.InsertTableEntities(transferitems.MembershipItems, Constants.TABLEDATA, Connection);
                //Other costs
                result += await opertions.InsertTableEntities(transferitems.OtherCostItems, Constants.TABLEDATA, Connection);
                //Animal Purchase
                result += await opertions.InsertTableEntities(transferitems.AnimalPurchaseItems, Constants.TABLEDATA, Connection);
                //Loan Payment
                result += await opertions.InsertTableEntities(transferitems.LoanRepaymentItems, Constants.TABLEDATA, Connection);
                //Equipment
                result += await opertions.InsertTableEntities(transferitems.EquipmentItems, Constants.TABLEDATA, Connection);
                //Sale of Pigs
                result += await opertions.InsertTableEntities(transferitems.PigSaleItems, Constants.TABLEDATA, Connection);
                //Sale of Breeding Services
                result += await opertions.InsertTableEntities(transferitems.BreedingServiceSaleItems, Constants.TABLEDATA, Connection);
                //Sale of Manure
                result += await opertions.InsertTableEntities(transferitems.ManureSaleItems, Constants.TABLEDATA, Connection);
                //Other income
                result += await opertions.InsertTableEntities(transferitems.OtherIncomeItems, Constants.TABLEDATA, Connection);

                if (string.IsNullOrWhiteSpace(result))
                {
                    responseModel.Success = true;
                }
                else
                {
                    responseModel.Message = result;
                }

            }
            catch (Exception ex)
            {

                responseModel.Message = ex.Message;


                var result = new ContentResult
                {
                    Content = JsonConvert.SerializeObject(responseModel),
                    ContentType = "application/json"
                };

                await LoggingOperations.LogRequestToBlob("SUBMITDATA", "RESPONSE", result.Content, callGUID, Connection);

                return result;
            }

            var contentresult = new ContentResult()
            {
                Content = JsonConvert.SerializeObject(responseModel),
                ContentType = "application/json"
            };

            await LoggingOperations.LogRequestToBlob("SUBMITDATA", "RESPONSE", contentresult.Content, callGUID, Connection);
            return contentresult;

        }

        /*
        //Intended to help test locally without auth needed
        [HttpPost, Route(Constants.ROUTE_API_DATA + "/testing")]
        public async Task<ActionResult> SubmitData2()
        {
            var responseModel = new DataUploadResponse
            {
                Success = false
            };

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
                result += await opertions.InsertTableEntities(transferitems.HealthCareItems, Constants.TABLEDATA, Connection);
                //Labourcosts
                result += await opertions.InsertTableEntities(transferitems.LabourCostItems, Constants.TABLEDATA, Connection);
                //AnimalHouse
                result += await opertions.InsertTableEntities(transferitems.AnimalHouseItems, Constants.TABLEDATA, Connection);
                //Water costs
                result += await opertions.InsertTableEntities(transferitems.WaterCostItems, Constants.TABLEDATA, Connection);
                //Reproductive
                result += await opertions.InsertTableEntities(transferitems.ReproductiveItems, Constants.TABLEDATA, Connection);
                //Memberships
                result += await opertions.InsertTableEntities(transferitems.MembershipItems, Constants.TABLEDATA, Connection);
                //Other costs
                result += await opertions.InsertTableEntities(transferitems.OtherCostItems, Constants.TABLEDATA, Connection);
                //Animal Purchase
                result += await opertions.InsertTableEntities(transferitems.AnimalPurchaseItems, Constants.TABLEDATA, Connection);
                //Loan Payment
                result += await opertions.InsertTableEntities(transferitems.LoanRepaymentItems, Constants.TABLEDATA, Connection);
                //Equipment
                result += await opertions.InsertTableEntities(transferitems.EquipmentItems, Constants.TABLEDATA, Connection);
                //Sale of Pigs
                result += await opertions.InsertTableEntities(transferitems.PigSaleItems, Constants.TABLEDATA, Connection);
                //Sale of Breeding Services
                result += await opertions.InsertTableEntities(transferitems.BreedingServiceSaleItems, Constants.TABLEDATA, Connection);
                //Sale of Manure
                result += await opertions.InsertTableEntities(transferitems.ManureSaleItems, Constants.TABLEDATA, Connection);
                //Other income
                result += await opertions.InsertTableEntities(transferitems.OtherIncomeItems, Constants.TABLEDATA, Connection);

                if (string.IsNullOrWhiteSpace(result))
                {
                    responseModel.Success = true;
                }
                else
                {
                    responseModel.Message = result;
                }

            }
            catch (Exception ex)
            {

                responseModel.Message = ex.Message;


                var result = new ContentResult
                {
                    Content = JsonConvert.SerializeObject(responseModel),
                    ContentType = "application/json"
                };

                await LoggingOperations.LogRequestToBlob("SUBMITDATA", "RESPONSE", result.Content, callGUID, Connection);

                return result;
            }

            var contentresult = new ContentResult()
            {
                Content = JsonConvert.SerializeObject(responseModel),
                ContentType = "application/json"
            };

            await LoggingOperations.LogRequestToBlob("SUBMITDATA", "RESPONSE", contentresult.Content, callGUID, Connection);
            return contentresult;

        }*/

    }

    

}

