# ShipEngineSDK.Api.ManifestsApi

All URIs are relative to *https://api.shipengine.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateManifest**](ManifestsApi.md#createmanifest) | **POST** /v1/manifests | Create Manifest |
| [**GetManifestById**](ManifestsApi.md#getmanifestbyid) | **GET** /v1/manifests/{manifest_id} | Get Manifest By Id |
| [**GetManifestRequestById**](ManifestsApi.md#getmanifestrequestbyid) | **GET** /v1/manifests/requests/{manifest_request_id} | Get Manifest Request By Id |
| [**ListManifests**](ManifestsApi.md#listmanifests) | **GET** /v1/manifests | List Manifests |

<a id="createmanifest"></a>
# **CreateManifest**
> CreateManifestResponseBody CreateManifest (CreateManifestRequestBody createManifestRequestBody)

Create Manifest

Each ShipEngine manifest is created for a specific warehouse, so you'll need to provide the warehouse_id rather than the ship_from address. You can create a warehouse for each location that you want to create manifests for. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class CreateManifestExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var createManifestRequestBody = new CreateManifestRequestBody(); // CreateManifestRequestBody | 

            try
            {
                // Create Manifest
                CreateManifestResponseBody result = await shipEngine.CreateManifest(createManifestRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling ManifestsApi.CreateManifest: " + e.Message);
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
| **createManifestRequestBody** | [**CreateManifestRequestBody**](CreateManifestRequestBody.md) |  |  |

### Return type

[**CreateManifestResponseBody**](CreateManifestResponseBody.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request was a success. |  -  |
| **400** | The request contained errors. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmanifestbyid"></a>
# **GetManifestById**
> GetManifestByIdResponseBody GetManifestById (string manifestId)

Get Manifest By Id

Get Manifest By Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetManifestByIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var manifestId = "manifestId_example";  // string | The Manifest Id

            try
            {
                // Get Manifest By Id
                GetManifestByIdResponseBody result = await shipEngine.GetManifestById(manifestId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling ManifestsApi.GetManifestById: " + e.Message);
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
| **manifestId** | **string** | The Manifest Id |  |

### Return type

[**GetManifestByIdResponseBody**](GetManifestByIdResponseBody.md)

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

<a id="getmanifestrequestbyid"></a>
# **GetManifestRequestById**
> CreateManifestResponseBody GetManifestRequestById (string manifestRequestId)

Get Manifest Request By Id

Get Manifest Request By Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetManifestRequestByIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var manifestRequestId = "manifestRequestId_example";  // string | The Manifest Request Id

            try
            {
                // Get Manifest Request By Id
                CreateManifestResponseBody result = await shipEngine.GetManifestRequestById(manifestRequestId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling ManifestsApi.GetManifestRequestById: " + e.Message);
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
| **manifestRequestId** | **string** | The Manifest Request Id |  |

### Return type

[**CreateManifestResponseBody**](CreateManifestResponseBody.md)

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

<a id="listmanifests"></a>
# **ListManifests**
> ListManifestsResponseBody ListManifests (string warehouseId = null, DateTime? shipDateStart = null, DateTime? shipDateEnd = null, DateTime? createdAtStart = null, DateTime? createdAtEnd = null, string carrierId = null, int? page = null, int? pageSize = null, List<string> labelIds = null)

List Manifests

Similar to querying shipments, we allow you to query manifests since there will likely be a large number over a long period of time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListManifestsExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var warehouseId = "warehouseId_example";  // string | Warehouse ID (optional) 
            var shipDateStart = 2018-09-23T15:00:00.000Z;  // DateTime? | ship date start range (optional) 
            var shipDateEnd = 2018-09-23T15:00:00.000Z;  // DateTime? | ship date end range (optional) 
            var createdAtStart = 2019-03-12T19:24:13.657Z;  // DateTime? | Used to create a filter for when a resource was created (ex. A shipment that was created after a certain time) (optional) 
            var createdAtEnd = 2019-03-12T19:24:13.657Z;  // DateTime? | Used to create a filter for when a resource was created, (ex. A shipment that was created before a certain time) (optional) 
            var carrierId = "carrierId_example";  // string | Carrier ID (optional) 
            var page = 2;  // int? | Return a specific page of results. Defaults to the first page. If set to a number that's greater than the number of pages of results, an empty page is returned.  (optional)  (default to 1)
            var pageSize = 50;  // int? | The number of results to return per response. (optional)  (default to 25)
            var labelIds = new List<string>(); // List<string> |  (optional) 

            try
            {
                // List Manifests
                ListManifestsResponseBody result = await shipEngine.ListManifests(warehouseId, shipDateStart, shipDateEnd, createdAtStart, createdAtEnd, carrierId, page, pageSize, labelIds);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling ManifestsApi.ListManifests: " + e.Message);
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
| **warehouseId** | **string** | Warehouse ID | [optional]  |
| **shipDateStart** | **DateTime?** | ship date start range | [optional]  |
| **shipDateEnd** | **DateTime?** | ship date end range | [optional]  |
| **createdAtStart** | **DateTime?** | Used to create a filter for when a resource was created (ex. A shipment that was created after a certain time) | [optional]  |
| **createdAtEnd** | **DateTime?** | Used to create a filter for when a resource was created, (ex. A shipment that was created before a certain time) | [optional]  |
| **carrierId** | **string** | Carrier ID | [optional]  |
| **page** | **int?** | Return a specific page of results. Defaults to the first page. If set to a number that&#39;s greater than the number of pages of results, an empty page is returned.  | [optional] [default to 1] |
| **pageSize** | **int?** | The number of results to return per response. | [optional] [default to 25] |
| **labelIds** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**ListManifestsResponseBody**](ListManifestsResponseBody.md)

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

