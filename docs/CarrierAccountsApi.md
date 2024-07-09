# ShipEngineSDK.Api.CarrierAccountsApi

All URIs are relative to *https://api.shipengine.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConnectCarrier**](CarrierAccountsApi.md#connectcarrier) | **POST** /v1/connections/carriers/{carrier_name} | Connect a carrier account |
| [**DisconnectCarrier**](CarrierAccountsApi.md#disconnectcarrier) | **DELETE** /v1/connections/carriers/{carrier_name}/{carrier_id} | Disconnect a carrier |
| [**GetCarrierSettings**](CarrierAccountsApi.md#getcarriersettings) | **GET** /v1/connections/carriers/{carrier_name}/{carrier_id}/settings | Get carrier settings |
| [**UpdateCarrierSettings**](CarrierAccountsApi.md#updatecarriersettings) | **PUT** /v1/connections/carriers/{carrier_name}/{carrier_id}/settings | Update carrier settings |

<a id="connectcarrier"></a>
# **ConnectCarrier**
> ConnectCarrierResponseBody ConnectCarrier (CarrierName carrierName, ConnectCarrierRequestBody connectCarrierRequestBody)

Connect a carrier account

Connect a carrier account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ConnectCarrierExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var carrierName = dhl_express;  // CarrierName | The carrier name, such as `stamps_com`, `ups`, `fedex`, or `dhl_express`.
            var connectCarrierRequestBody = new ConnectCarrierRequestBody(); // ConnectCarrierRequestBody | 

            try
            {
                // Connect a carrier account
                ConnectCarrierResponseBody result = await shipEngine.ConnectCarrier(carrierName, connectCarrierRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.ConnectCarrier: " + e.Message);
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
| **carrierName** | **CarrierName** | The carrier name, such as &#x60;stamps_com&#x60;, &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;. |  |
| **connectCarrierRequestBody** | [**ConnectCarrierRequestBody**](ConnectCarrierRequestBody.md) |  |  |

### Return type

[**ConnectCarrierResponseBody**](ConnectCarrierResponseBody.md)

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
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="disconnectcarrier"></a>
# **DisconnectCarrier**
> string DisconnectCarrier (CarrierName carrierName, string carrierId)

Disconnect a carrier

Disconnect a carrier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class DisconnectCarrierExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var carrierName = dhl_express;  // CarrierName | The carrier name, such as `stamps_com`, `ups`, `fedex`, or `dhl_express`.
            var carrierId = se-28529731;  // string | Carrier ID

            try
            {
                // Disconnect a carrier
                string result = await shipEngine.DisconnectCarrier(carrierName, carrierId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.DisconnectCarrier: " + e.Message);
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
| **carrierName** | **CarrierName** | The carrier name, such as &#x60;stamps_com&#x60;, &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;. |  |
| **carrierId** | **string** | Carrier ID |  |

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
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcarriersettings"></a>
# **GetCarrierSettings**
> GetCarrierSettingsResponseBody GetCarrierSettings (CarrierNameWithSettings carrierName, string carrierId)

Get carrier settings

Get carrier settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetCarrierSettingsExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var carrierName = dhl_express;  // CarrierNameWithSettings | The carrier name, such as `ups`, `fedex`, or `dhl_express`.
            var carrierId = se-28529731;  // string | Carrier ID

            try
            {
                // Get carrier settings
                GetCarrierSettingsResponseBody result = await shipEngine.GetCarrierSettings(carrierName, carrierId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.GetCarrierSettings: " + e.Message);
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
| **carrierName** | **CarrierNameWithSettings** | The carrier name, such as &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;. |  |
| **carrierId** | **string** | Carrier ID |  |

### Return type

[**GetCarrierSettingsResponseBody**](GetCarrierSettingsResponseBody.md)

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

<a id="updatecarriersettings"></a>
# **UpdateCarrierSettings**
> string UpdateCarrierSettings (CarrierNameWithSettings carrierName, string carrierId, UpdateCarrierSettingsRequestBody updateCarrierSettingsRequestBody)

Update carrier settings

Update carrier settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class UpdateCarrierSettingsExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var carrierName = dhl_express;  // CarrierNameWithSettings | The carrier name, such as `ups`, `fedex`, or `dhl_express`.
            var carrierId = se-28529731;  // string | Carrier ID
            var updateCarrierSettingsRequestBody = new UpdateCarrierSettingsRequestBody(); // UpdateCarrierSettingsRequestBody | 

            try
            {
                // Update carrier settings
                string result = await shipEngine.UpdateCarrierSettings(carrierName, carrierId, updateCarrierSettingsRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.UpdateCarrierSettings: " + e.Message);
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
| **carrierName** | **CarrierNameWithSettings** | The carrier name, such as &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;. |  |
| **carrierId** | **string** | Carrier ID |  |
| **updateCarrierSettingsRequestBody** | [**UpdateCarrierSettingsRequestBody**](UpdateCarrierSettingsRequestBody.md) |  |  |

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
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

