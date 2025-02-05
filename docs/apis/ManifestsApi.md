# Manifests Methods

| Method | Description |
|--------|-------------|
| [**CreateManifest**](ManifestsApi.md#createmanifest) | Create Manifest |
| [**GetManifestById**](ManifestsApi.md#getmanifestbyid) | Get Manifest By Id |
| [**GetManifestRequestById**](ManifestsApi.md#getmanifestrequestbyid) | Get Manifest Request By Id |
| [**ListManifests**](ManifestsApi.md#listmanifests) | List Manifests |

<a id="createmanifest"></a>
# **CreateManifest**
```csharp
CreateManifestResponseBody CreateManifest (CreateManifestRequestBody createManifestRequestBody, CancellationToken cancellationToken = default)

CreateManifestResponseBody CreateManifest (HttpClient methodClient, CreateManifestRequestBody createManifestRequestBody, CancellationToken cancellationToken = default)
```

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
            var createManifestRequestBody = new CreateManifestRequestBody();

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **createManifestRequestBody** | [**CreateManifestRequestBody**](CreateManifestRequestBody.md) |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**CreateManifestResponseBody**](../models/CreateManifestResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmanifestbyid"></a>
# **GetManifestById**
```csharp
GetManifestByIdResponseBody GetManifestById (string manifestId, CancellationToken cancellationToken = default)

GetManifestByIdResponseBody GetManifestById (HttpClient methodClient, string manifestId, CancellationToken cancellationToken = default)
```

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
            var manifestId = "manifestId_example";

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **manifestId** | **string** | The Manifest Id |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetManifestByIdResponseBody**](../models/GetManifestByIdResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getmanifestrequestbyid"></a>
# **GetManifestRequestById**
```csharp
CreateManifestResponseBody GetManifestRequestById (string manifestRequestId, CancellationToken cancellationToken = default)

CreateManifestResponseBody GetManifestRequestById (HttpClient methodClient, string manifestRequestId, CancellationToken cancellationToken = default)
```

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
            var manifestRequestId = "manifestRequestId_example";

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **manifestRequestId** | **string** | The Manifest Request Id |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**CreateManifestResponseBody**](../models/CreateManifestResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listmanifests"></a>
# **ListManifests**
```csharp
ListManifestsResponseBody ListManifests (DateTimeOffset shipDateStart = null, DateTimeOffset shipDateEnd = null, DateTimeOffset createdAtStart = null, DateTimeOffset createdAtEnd = null, List<string> labelIds = null, string warehouseId = null, string carrierId = null, int page = null, int pageSize = null, CancellationToken cancellationToken = default)

ListManifestsResponseBody ListManifests (HttpClient methodClient, DateTimeOffset shipDateStart = null, DateTimeOffset shipDateEnd = null, DateTimeOffset createdAtStart = null, DateTimeOffset createdAtEnd = null, List<string> labelIds = null, string warehouseId = null, string carrierId = null, int page = null, int pageSize = null, CancellationToken cancellationToken = default)
```

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
            var shipDateStart = 2018-09-23T15:00:00.000Z;
            var shipDateEnd = 2018-09-23T15:00:00.000Z;
            var createdAtStart = 2019-03-12T19:24:13.657Z;
            var createdAtEnd = 2019-03-12T19:24:13.657Z;
            var labelIds = new List<string>();
            var warehouseId = "warehouseId_example";
            var carrierId = "carrierId_example";
            var page = 2;
            var pageSize = 50;

            try
            {
                // List Manifests
                ListManifestsResponseBody result = await shipEngine.ListManifests(shipDateStart, shipDateEnd, createdAtStart, createdAtEnd, labelIds, warehouseId, carrierId, page, pageSize);
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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **shipDateStart** | **DateTimeOffset** | ship date start range | [optional]  |
| **shipDateEnd** | **DateTimeOffset** | ship date end range | [optional]  |
| **createdAtStart** | **DateTimeOffset** | Used to create a filter for when a resource was created (ex. A shipment that was created after a certain time) | [optional]  |
| **createdAtEnd** | **DateTimeOffset** | Used to create a filter for when a resource was created, (ex. A shipment that was created before a certain time) | [optional]  |
| **labelIds** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **warehouseId** | **string** | Warehouse ID | [optional]  |
| **carrierId** | **string** | Carrier ID | [optional]  |
| **page** | **int** | Return a specific page of results. Defaults to the first page. If set to a number that&#39;s greater than the number of pages of results, an empty page is returned.  | [optional] [default to 1] |
| **pageSize** | **int** | The number of results to return per response. | [optional] [default to 25] |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**ListManifestsResponseBody**](../models/ListManifestsResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

