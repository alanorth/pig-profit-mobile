using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using PigTool.API.Services;
using Microsoft.Extensions.Configuration;
using Shared;
using Microsoft.WindowsAzure.Storage.Table;

namespace PigTool.API.Controllers
{
    public class UserAPIController : PigToolBaseController
    {
        public UserAPIController(

      IConfiguration config) : base(config)
        {

        }

        [HttpPost, Route(Constants.ROUTE_AUTH_REGISTERUSER)]
        public ActionResult RegisterUser()
        {

            try
            {


                //var requestJson = await Parse(Request);
                //var unparsedRequest = requestJson.Body;

                var Connection = GetStorageConnectionString();
                // var tableOperations = new TableOperations();
                var opertions = new TableOperations();
                var user = new UserInfo
                {
                    PartitionKey = "User",
                    RowKey = Guid.NewGuid().ToString(),
                    County = "New Zealand",
                    SubCounty = "Otago",
                    District = "Southern Lakes",
                    Email = "mark@abacusbio.com",
                    LastUploadDate = DateTime.Now,
                    CreatedTimeStamp = DateTime.Now,
                    LastModified = DateTime.Now,
                    Timestamp = DateTime.Now,
                    Id = Guid.NewGuid().ToString(),
                    IsDeleted = false,
                    IsEnable = false,
                    IsModified = false,
                    CreatedBy = "API",
                    Gender = "Male",
                    Name = "Mark",
                    

                };
                var userlist = new List<UserInfo>();

                userlist.Add(user);

                var result = opertions.InsertTableEntities(userlist, Constants.TABLEUSERS, Connection);

            }
            catch (Exception)
            {

                return new ContentResult()
                {
                    Content = $"Error creating user",
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
