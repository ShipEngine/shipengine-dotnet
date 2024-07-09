# ShipEngineSDK.Api.BatchesApi

All URIs are relative to *https://api.shipengine.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddToBatch**](BatchesApi.md#addtobatch) | **POST** /v1/batches/{batch_id}/add | Add to a Batch |
| [**CreateBatch**](BatchesApi.md#createbatch) | **POST** /v1/batches | Create A Batch |
| [**DeleteBatch**](BatchesApi.md#deletebatch) | **DELETE** /v1/batches/{batch_id} | Delete Batch By Id |
| [**GetBatchByExternalId**](BatchesApi.md#getbatchbyexternalid) | **GET** /v1/batches/external_batch_id/{external_batch_id} | Get Batch By External ID |
| [**GetBatchById**](BatchesApi.md#getbatchbyid) | **GET** /v1/batches/{batch_id} | Get Batch By ID |
| [**ListBatchErrors**](BatchesApi.md#listbatcherrors) | **GET** /v1/batches/{batch_id}/errors | Get Batch Errors |
| [**ListBatches**](BatchesApi.md#listbatches) | **GET** /v1/batches | List Batches |
| [**ProcessBatch**](BatchesApi.md#processbatch) | **POST** /v1/batches/{batch_id}/process/labels | Process Batch ID Labels |
| [**RemoveFromBatch**](BatchesApi.md#removefrombatch) | **POST** /v1/batches/{batch_id}/remove | Remove From Batch |
| [**UpdateBatch**](BatchesApi.md#updatebatch) | **PUT** /v1/batches/{batch_id} | Update Batch By Id |

<a id="addtobatch"></a>
# **AddToBatch**
> string AddToBatch (string batchId, AddToBatchRequestBody addToBatchRequestBody)

Add to a Batch

Add a Shipment or Rate to a Batch

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class AddToBatchExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var batchId = "batchId_example";  // string | Batch ID
            var addToBatchRequestBody = new AddToBatchRequestBody(); // AddToBatchRequestBody | 

            try
            {
                // Add to a Batch
                string result = await shipEngine.AddToBatch(batchId, addToBatchRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.AddToBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchId** | **string** | Batch ID |  |
| **addToBatchRequestBody** | [**AddToBatchRequestBody**](AddToBatchRequestBody.md) |  |  |

### Return type

**string**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The request was successful. |  -  |
| **400** | The request contained errors. |  -  |
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createbatch"></a>
# **CreateBatch**
> CreateBatchResponseBody CreateBatch (CreateBatchRequest createBatchRequest)

Create A Batch

Create a Batch

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class CreateBatchExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var createBatchRequest = new CreateBatchRequest(); // CreateBatchRequest | 

            try
            {
                // Create A Batch
                CreateBatchResponseBody result = await shipEngine.CreateBatch(createBatchRequest);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.CreateBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createBatchRequest** | [**CreateBatchRequest**](CreateBatchRequest.md) |  |  |

### Return type

[**CreateBatchResponseBody**](CreateBatchResponseBody.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested object creation was a success. |  -  |
| **207** | The request was a partial success. It contains results, as well as processing errors. |  -  |
| **400** | The request contained errors. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletebatch"></a>
# **DeleteBatch**
> string DeleteBatch (string batchId)

Delete Batch By Id

Delete Batch By Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class DeleteBatchExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var batchId = "batchId_example";  // string | Batch ID

            try
            {
                // Delete Batch By Id
                string result = await shipEngine.DeleteBatch(batchId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.DeleteBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchId** | **string** | Batch ID |  |

### Return type

**string**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The request was successful. |  -  |
| **400** | The request contained errors. |  -  |
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbatchbyexternalid"></a>
# **GetBatchByExternalId**
> GetBatchByExternalIdResponseBody GetBatchByExternalId (string externalBatchId)

Get Batch By External ID

Get Batch By External ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetBatchByExternalIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var externalBatchId = 13553d7f-3c87-4771-bae1-c49bacef11cb;  // string | 

            try
            {
                // Get Batch By External ID
                GetBatchByExternalIdResponseBody result = await shipEngine.GetBatchByExternalId(externalBatchId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.GetBatchByExternalId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **externalBatchId** | **string** |  |  |

### Return type

[**GetBatchByExternalIdResponseBody**](GetBatchByExternalIdResponseBody.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request was a success. |  -  |
| **400** | The request contained errors. |  -  |
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbatchbyid"></a>
# **GetBatchById**
> GetBatchByIdResponseBody GetBatchById (string batchId)

Get Batch By ID

Get Batch By ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetBatchByIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var batchId = "batchId_example";  // string | Batch ID

            try
            {
                // Get Batch By ID
                GetBatchByIdResponseBody result = await shipEngine.GetBatchById(batchId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.GetBatchById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchId** | **string** | Batch ID |  |

### Return type

[**GetBatchByIdResponseBody**](GetBatchByIdResponseBody.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request was a success. |  -  |
| **400** | The request contained errors. |  -  |
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listbatcherrors"></a>
# **ListBatchErrors**
> ListBatchErrorsResponseBody ListBatchErrors (string batchId, int? page = null, int? pagesize = null)

Get Batch Errors

Error handling in batches are handled differently than in a single synchronous request. You must retrieve the status of your batch by [getting a batch](https://www.shipengine.com/docs/reference/get-batch-by-id/) and getting an overview of the statuses or you can list errors directly here below to get detailed information about the errors. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListBatchErrorsExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var batchId = "batchId_example";  // string | Batch ID
            var page = 2;  // int? | Return a specific page of results. Defaults to the first page. If set to a number that's greater than the number of pages of results, an empty page is returned.  (optional)  (default to 1)
            var pagesize = 56;  // int? |  (optional) 

            try
            {
                // Get Batch Errors
                ListBatchErrorsResponseBody result = await shipEngine.ListBatchErrors(batchId, page, pagesize);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.ListBatchErrors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchId** | **string** | Batch ID |  |
| **page** | **int?** | Return a specific page of results. Defaults to the first page. If set to a number that&#39;s greater than the number of pages of results, an empty page is returned.  | [optional] [default to 1] |
| **pagesize** | **int?** |  | [optional]  |

### Return type

[**ListBatchErrorsResponseBody**](ListBatchErrorsResponseBody.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request was a success. |  -  |
| **400** | The request contained errors. |  -  |
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listbatches"></a>
# **ListBatches**
> ListBatchesResponseBody ListBatches (BatchStatus? status = null, int? page = null, int? pageSize = null, SortDir? sortDir = null, string batchNumber = null, BatchesSortBy? sortBy = null)

List Batches

List Batches associated with your Shipengine account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListBatchesExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var status = (BatchStatus) "open";  // BatchStatus? |  (optional) 
            var page = 2;  // int? | Return a specific page of results. Defaults to the first page. If set to a number that's greater than the number of pages of results, an empty page is returned.  (optional)  (default to 1)
            var pageSize = 50;  // int? | The number of results to return per response. (optional)  (default to 25)
            var sortDir = (SortDir) "asc";  // SortDir? | Controls the sort order of the query. (optional) 
            var batchNumber = "batchNumber_example";  // string | Batch Number (optional) 
            var sortBy = (BatchesSortBy) "ship_date";  // BatchesSortBy? |  (optional) 

            try
            {
                // List Batches
                ListBatchesResponseBody result = await shipEngine.ListBatches(status, page, pageSize, sortDir, batchNumber, sortBy);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.ListBatches: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | **BatchStatus?** |  | [optional]  |
| **page** | **int?** | Return a specific page of results. Defaults to the first page. If set to a number that&#39;s greater than the number of pages of results, an empty page is returned.  | [optional] [default to 1] |
| **pageSize** | **int?** | The number of results to return per response. | [optional] [default to 25] |
| **sortDir** | **SortDir?** | Controls the sort order of the query. | [optional]  |
| **batchNumber** | **string** | Batch Number | [optional]  |
| **sortBy** | **BatchesSortBy?** |  | [optional]  |

### Return type

[**ListBatchesResponseBody**](ListBatchesResponseBody.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request was a success. |  -  |
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="processbatch"></a>
# **ProcessBatch**
> string ProcessBatch (string batchId, ProcessBatchRequestBody processBatchRequestBody)

Process Batch ID Labels

Process Batch ID Labels

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ProcessBatchExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var batchId = "batchId_example";  // string | Batch ID
            var processBatchRequestBody = new ProcessBatchRequestBody(); // ProcessBatchRequestBody | 

            try
            {
                // Process Batch ID Labels
                string result = await shipEngine.ProcessBatch(batchId, processBatchRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.ProcessBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchId** | **string** | Batch ID |  |
| **processBatchRequestBody** | [**ProcessBatchRequestBody**](ProcessBatchRequestBody.md) |  |  |

### Return type

**string**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The request was successful. |  -  |
| **400** | The request contained errors. |  -  |
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removefrombatch"></a>
# **RemoveFromBatch**
> string RemoveFromBatch (string batchId, RemoveFromBatchRequestBody removeFromBatchRequestBody)

Remove From Batch

Remove a shipment or rate from a batch

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class RemoveFromBatchExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var batchId = "batchId_example";  // string | Batch ID
            var removeFromBatchRequestBody = new RemoveFromBatchRequestBody(); // RemoveFromBatchRequestBody | 

            try
            {
                // Remove From Batch
                string result = await shipEngine.RemoveFromBatch(batchId, removeFromBatchRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.RemoveFromBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchId** | **string** | Batch ID |  |
| **removeFromBatchRequestBody** | [**RemoveFromBatchRequestBody**](RemoveFromBatchRequestBody.md) |  |  |

### Return type

**string**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The request was successful. |  -  |
| **400** | The request contained errors. |  -  |
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatebatch"></a>
# **UpdateBatch**
> string UpdateBatch (string batchId)

Update Batch By Id

Update Batch By Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class UpdateBatchExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var batchId = "batchId_example";  // string | Batch ID

            try
            {
                // Update Batch By Id
                string result = await shipEngine.UpdateBatch(batchId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.UpdateBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchId** | **string** | Batch ID |  |

### Return type

**string**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The request was successful. |  -  |
| **400** | The request contained errors. |  -  |
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

