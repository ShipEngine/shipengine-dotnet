# ShipEngineSDK.Api.TrackingApi

All URIs are relative to *https://api.shipengine.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTrackingLog**](TrackingApi.md#gettrackinglog) | **GET** /v1/tracking | Get Tracking Information |
| [**StartTracking**](TrackingApi.md#starttracking) | **POST** /v1/tracking/start | Start Tracking a Package |
| [**StopTracking**](TrackingApi.md#stoptracking) | **POST** /v1/tracking/stop | Stop Tracking a Package |

<a id="gettrackinglog"></a>
# **GetTrackingLog**
> GetTrackingLogResponseBody GetTrackingLog (string carrierCode = null, string trackingNumber = null)

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
            var carrierCode = stamps_com;  // string | A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as `fedex`, `dhl_express`, `stamps_com`, etc.  (optional) 
            var trackingNumber = 9405511899223197428490;  // string | The tracking number associated with a shipment (optional) 

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
| **carrierCode** | **string** | A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  | [optional]  |
| **trackingNumber** | **string** | The tracking number associated with a shipment | [optional]  |

### Return type

[**GetTrackingLogResponseBody**](GetTrackingLogResponseBody.md)

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

<a id="starttracking"></a>
# **StartTracking**
> string StartTracking (string carrierCode = null, string trackingNumber = null)

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
            var carrierCode = stamps_com;  // string | A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as `fedex`, `dhl_express`, `stamps_com`, etc.  (optional) 
            var trackingNumber = 9405511899223197428490;  // string | The tracking number associated with a shipment (optional) 

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
| **carrierCode** | **string** | A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  | [optional]  |
| **trackingNumber** | **string** | The tracking number associated with a shipment | [optional]  |

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

<a id="stoptracking"></a>
# **StopTracking**
> string StopTracking (string carrierCode = null, string trackingNumber = null)

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
            var carrierCode = stamps_com;  // string | A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as `fedex`, `dhl_express`, `stamps_com`, etc.  (optional) 
            var trackingNumber = 9405511899223197428490;  // string | The tracking number associated with a shipment (optional) 

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
| **carrierCode** | **string** | A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  | [optional]  |
| **trackingNumber** | **string** | The tracking number associated with a shipment | [optional]  |

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

