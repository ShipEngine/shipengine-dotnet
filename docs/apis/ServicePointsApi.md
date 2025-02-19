# ServicePoints Methods

| Method | Description |
|--------|-------------|
| [**ServicePointsGetById**](ServicePointsApi.md#servicepointsgetbyid) | Get Service Point By ID |
| [**ServicePointsList**](ServicePointsApi.md#servicepointslist) | List Service Points |

<a id="servicepointsgetbyid"></a>
# **ServicePointsGetById**
```csharp
GetServicePointByIdResponseBody ServicePointsGetById (string carrierCode, string countryCode, string servicePointId, CancellationToken cancellationToken = default)

GetServicePointByIdResponseBody ServicePointsGetById (HttpClient methodClient, string carrierCode, string countryCode, string servicePointId, CancellationToken cancellationToken = default)
```

Get Service Point By ID

Returns a carrier service point by using the service_point_id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ServicePointsGetByIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var carrierCode = stamps_com;
            var countryCode = CA;
            var servicePointId = 614940;

            try
            {
                // Get Service Point By ID
                GetServicePointByIdResponseBody result = await shipEngine.ServicePointsGetById(carrierCode, countryCode, servicePointId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling ServicePointsApi.ServicePointsGetById: " + e.Message);
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
| **carrierCode** | **string** | Carrier code |  |
| **countryCode** | **string** | A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1)  |  |
| **servicePointId** | **string** |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetServicePointByIdResponseBody**](../models/GetServicePointByIdResponseBody.md)

<a id="servicepointslist"></a>
# **ServicePointsList**
```csharp
ListServicePointsResponseBody ServicePointsList (GetServicePointsRequest getServicePointsRequest, CancellationToken cancellationToken = default)

ListServicePointsResponseBody ServicePointsList (HttpClient methodClient, GetServicePointsRequest getServicePointsRequest, CancellationToken cancellationToken = default)
```

List Service Points

List carrier service points by location

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ServicePointsListExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var getServicePointsRequest = new GetServicePointsRequest();

            try
            {
                // List Service Points
                ListServicePointsResponseBody result = await shipEngine.ServicePointsList(getServicePointsRequest);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling ServicePointsApi.ServicePointsList: " + e.Message);
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
| **getServicePointsRequest** | [**GetServicePointsRequest**](../../docs//models/GetServicePointsRequest.md) |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**ListServicePointsResponseBody**](../models/ListServicePointsResponseBody.md)

