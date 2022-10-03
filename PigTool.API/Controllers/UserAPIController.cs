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

            try
            {
             
                var requestJson = await Parse(Request);
                var unparsedRequest = requestJson.Body;
                var user = new UserInfo();
                var requeststring = Convert.ToString(unparsedRequest);

                //Get the user from the request
                user = JsonConvert.DeserializeObject<UserInfo>(requeststring);


                //TODO need to check if user exists before creating....

                var Connection = GetStorageConnectionString();
                // var tableOperations = new TableOperations();
                var opertions = new TableOperations();
               
                var userlist = new List<UserInfo>();

                userlist.Add(user);

                var result = opertions.InsertTableEntities(userlist, Constants.TABLEUSERS, Connection);

            }
            catch (Exception ex)
            {

                return new ContentResult()
                {
                    Content = $"Error creating user" + ex.Message,
                    ContentType = "text/plain"
                };
            }

            return new ContentResult()
            {
                Content = $"User Created",
                ContentType = "text/plain"
            };

        }

        }
}
