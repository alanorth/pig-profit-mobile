using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using PigTool.API.Services;
using Microsoft.Extensions.Configuration;
using Shared;
using Microsoft.WindowsAzure.Storage.Table;
using Newtonsoft.Json;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace PigTool.API.Controllers
{
    [Tags("User Services")]
    [ApiController]
    public class UserAPIController : PigToolBaseController
    {
        public UserAPIController(

      IConfiguration config) : base(config)
        {

        }

        
        [HttpPost, Route(Constants.ROUTE_AUTH_REGISTERUSER)]
        public async Task<ActionResult> RegisterUser()
        {
            var callGUID = Guid.NewGuid().ToString();
            var Connection = GetStorageConnectionString();

            try
            {
             
                var requestJson = await Parse(Request);
                var unparsedRequest = requestJson.Body;
                var user = new MobileUser();
                var requeststring = Convert.ToString(unparsedRequest);

                //Log request
                await LoggingOperations.LogRequestToBlob("REGISTERUSER", "POST", requeststring, callGUID, Connection);


                //Get the user from the request
                user = JsonConvert.DeserializeObject<MobileUser>(requeststring);


                //TODO need to check if user exists before creating....

               
                // var tableOperations = new TableOperations();
                var opertions = new TableOperations();
               
                var userlist = new List<MobileUser>();

                userlist.Add(user);

                var result = opertions.InsertTableEntities(userlist, Constants.TABLEUSERS, Connection);

            }
            catch (Exception ex)
            {

                var result = new ContentResult()
                {
                    Content = $"Error creating user" + Constants.APICALLID + callGUID,
                    ContentType = "text/plain"
                };

                await LoggingOperations.LogRequestToBlob("REGISTERUSER", "RESPONSE", result.Content, callGUID, Connection);

                return result;
            }

            var contentresult = new ContentResult()
            {
                Content = $"User Created",
                ContentType = "text/plain"
            };

            await LoggingOperations.LogRequestToBlob("REGISTERUSER", "RESPONSE", contentresult.Content, callGUID, Connection);

            return contentresult;
        }

        }
}
