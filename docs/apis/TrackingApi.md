# Tracking Methods

| Method | Description |
|--------|-------------|
| [**GetTrackingLog**](TrackingApi.md#gettrackinglog) | Get Tracking Information |
| [**StartTracking**](TrackingApi.md#starttracking) | Start Tracking a Package |
| [**StopTracking**](TrackingApi.md#stoptracking) | Stop Tracking a Package |

<a id="gettrackinglog"></a>
# **GetTrackingLog**
```csharp
GetTrackingLogResponseBody GetTrackingLog (string carrierCode = null, string trackingNumber = null, CancellationToken cancellationToken = default)

GetTrackingLogResponseBody GetTrackingLog (HttpClient methodClient, string carrierCode = null, string trackingNumber = null, CancellationToken cancellationToken = default)
```

Get Tracking Information

Retrieve package tracking information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetTrackingLogExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var carrierCode = stamps_com;
            var trackingNumber = 9405511899223197428490;

            try
            {
                // Get Tracking Information
                GetTrackingLogResponseBody result = await shipEngine.GetTrackingLog(carrierCode, trackingNumber);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling TrackingApi.GetTrackingLog: " + e.Message);
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
| **carrierCode** | **string** | A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  | [optional]  |
| **trackingNumber** | **string** | The tracking number associated with a shipment | [optional]  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetTrackingLogResponseBody**](../models/GetTrackingLogResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="starttracking"></a>
# **StartTracking**
```csharp
string StartTracking (string carrierCode = null, string trackingNumber = null, CancellationToken cancellationToken = default)

string StartTracking (HttpClient methodClient, string carrierCode = null, string trackingNumber = null, CancellationToken cancellationToken = default)
```

Start Tracking a Package

Allows you to subscribe to tracking updates for a package. You specify the carrier_code and tracking_number of the package, and receive notifications via webhooks whenever the shipping status changes. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class StartTrackingExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var carrierCode = stamps_com;
            var trackingNumber = 9405511899223197428490;

            try
            {
                // Start Tracking a Package
                string result = await shipEngine.StartTracking(carrierCode, trackingNumber);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling TrackingApi.StartTracking: " + e.Message);
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
| **carrierCode** | **string** | A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  | [optional]  |
| **trackingNumber** | **string** | The tracking number associated with a shipment | [optional]  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="stoptracking"></a>
# **StopTracking**
```csharp
string StopTracking (string carrierCode = null, string trackingNumber = null, CancellationToken cancellationToken = default)

string StopTracking (HttpClient methodClient, string carrierCode = null, string trackingNumber = null, CancellationToken cancellationToken = default)
```

Stop Tracking a Package

Unsubscribe from tracking updates for a package.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class StopTrackingExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var carrierCode = stamps_com;
            var trackingNumber = 9405511899223197428490;

            try
            {
                // Stop Tracking a Package
                string result = await shipEngine.StopTracking(carrierCode, trackingNumber);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling TrackingApi.StopTracking: " + e.Message);
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
| **carrierCode** | **string** | A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  | [optional]  |
| **trackingNumber** | **string** | The tracking number associated with a shipment | [optional]  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

