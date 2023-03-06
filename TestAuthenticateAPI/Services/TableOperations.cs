
using Microsoft.VisualBasic;
//using Microsoft.WindowsAzure.Storage;
//using Microsoft.WindowsAzure.Storage.Table;
using Azure.Data.Tables;
using System;
using System.Collections.Concurrent;
using Shared;
using Azure;
//using Microsoft.WindowsAzure.Storage.Table;

namespace TestAuthenticateAPI.Services
{
    public class TableOperations
    {
        public async Task<TableClient> GetStorageTable(string masterStorageConnectionString, string tableName)
        {
            var tableClient = new TableClient(masterStorageConnectionString, tableName);

            await tableClient.CreateIfNotExistsAsync();

            return tableClient;
        }

        public async Task<string> InsertTableEntities(
         IEnumerable<ITableEntity> entities,
         string tableName,
         string masterStorageConnectionString)
        {
            try
            {


                // nothing to do just bail out now
                if (entities == null
                    || !entities.Any())
                {
                    return string.Empty;
                }

                // Check to see if table name is provided
                if (string.IsNullOrWhiteSpace(tableName))
                {
                    return "no table name";
                }

                var tableClient = await GetStorageTable(masterStorageConnectionString, tableName);

                // Check to see if table name is provided
                if (tableClient == null)
                {
                    return "Table Client Failed to construct";
                }


                // because items in TableBatchOperation can't have different PartitionKeys,
                // we need to group them into entityGroups by PartitionKey
                var entitiesPartitionKeyGroup = entities
                    .GroupBy(f => f.PartitionKey).ToList();

                foreach (var entityGroup in entitiesPartitionKeyGroup)
                {
                    // Create the batch.
                    List<TableTransactionAction> addEntitiesBatch = new List<TableTransactionAction>();

                    addEntitiesBatch.AddRange(entityGroup.Select(e => new TableTransactionAction(TableTransactionActionType.UpsertMerge, e)));



                    // Submit the batch.
                    Response<IReadOnlyList<Response>> response = await tableClient.SubmitTransactionAsync(addEntitiesBatch).ConfigureAwait(false);



                    for (int i = 0; i < entityGroup.Count(); i++)
                    {
                        Console.WriteLine($"The ETag for the entity with RowKey: '{entityGroup.ElementAt(i).RowKey}' is {response.Value[i].Headers.ETag}");
                    }
                }

            }
            catch (SystemException exception)
            {

                return exception.Message;
            }
            catch (Exception ex)
            {
                // https://stackoverflow.com/questions/881473/why-catch-and-rethrow-an-exception-in-c
                return ex.Message;
            }

            return string.Empty;
        }


        public async Task<List<TableEntity>> GetTableEntities(string tableName,
         string masterStorageConnectionString, string query)
        {
            var tableToQuery = await GetStorageTable(masterStorageConnectionString, tableName);

            var queryResultsFilter = tableToQuery.Query<TableEntity>(filter: query);

            // Iterate the <see cref="Pageable"> to access all queried entities.
            foreach (TableEntity qEntity in queryResultsFilter)
            {
                Console.WriteLine($"{qEntity.GetString("Product")}: {qEntity.GetDouble("Price")}");
            }

            Console.WriteLine($"The query returned {queryResultsFilter.Count()} entities.");

            return queryResultsFilter.ToList();

        }

        public async Task<TableEntity> GetSingleEntityItem(string tableName,
       string masterStorageConnectionString, string PartitionKey, string RowKey)
        {
            var tableToQuery = await GetStorageTable(masterStorageConnectionString, tableName);
            TableEntity result = null;
            try
            {
                result = await tableToQuery.GetEntityAsync<TableEntity>(PartitionKey, RowKey);
            }
            catch (RequestFailedException azFaile)
            {
                if (azFaile.Status == 404)
                {
                    return null;
                }
                throw azFaile;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;

        }

        public string CreatePartionKeyRowKeyStringFilter(string partitionKey, string RowKey)
        {
            return $"PartitionKey eq '{partitionKey}' and RowKey eq '{RowKey}'";
        }

    }
}
