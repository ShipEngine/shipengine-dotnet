# CarrierAccounts Methods

| Method | Description |
|--------|-------------|
| [**ConnectCarrier**](CarrierAccountsApi.md#connectcarrier) | Connect a carrier account |
| [**DisconnectCarrier**](CarrierAccountsApi.md#disconnectcarrier) | Disconnect a carrier |
| [**GetCarrierSettings**](CarrierAccountsApi.md#getcarriersettings) | Get carrier settings |
| [**UpdateCarrierSettings**](CarrierAccountsApi.md#updatecarriersettings) | Update carrier settings |

<a id="connectcarrier"></a>
# **ConnectCarrier**
```csharp
ConnectCarrierResponseBody ConnectCarrier (CarrierName carrierName, ConnectCarrierRequestBody connectCarrierRequestBody, CancellationToken cancellationToken = default)

ConnectCarrierResponseBody ConnectCarrier (HttpClient methodClient, CarrierName carrierName, ConnectCarrierRequestBody connectCarrierRequestBody, CancellationToken cancellationToken = default)
```

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
            var carrierName = dhl_express;
            var connectCarrierRequestBody = new ConnectCarrierRequestBody();

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **carrierName** | **CarrierName** | The carrier name, such as &#x60;stamps_com&#x60;, &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;. |  |
| **connectCarrierRequestBody** | [**ConnectCarrierRequestBody**](ConnectCarrierRequestBody.md) |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**ConnectCarrierResponseBody**](../models/ConnectCarrierResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="disconnectcarrier"></a>
# **DisconnectCarrier**
```csharp
string DisconnectCarrier (CarrierName carrierName, string carrierId, CancellationToken cancellationToken = default)

string DisconnectCarrier (HttpClient methodClient, CarrierName carrierName, string carrierId, CancellationToken cancellationToken = default)
```

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
            var carrierName = dhl_express;
            var carrierId = se-28529731;

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **carrierName** | **CarrierName** | The carrier name, such as &#x60;stamps_com&#x60;, &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;. |  |
| **carrierId** | **string** | Carrier ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcarriersettings"></a>
# **GetCarrierSettings**
```csharp
GetCarrierSettingsResponseBody GetCarrierSettings (CarrierNameWithSettings carrierName, string carrierId, CancellationToken cancellationToken = default)

GetCarrierSettingsResponseBody GetCarrierSettings (HttpClient methodClient, CarrierNameWithSettings carrierName, string carrierId, CancellationToken cancellationToken = default)
```

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
            var carrierName = dhl_express;
            var carrierId = se-28529731;

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **carrierName** | **CarrierNameWithSettings** | The carrier name, such as &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;. |  |
| **carrierId** | **string** | Carrier ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetCarrierSettingsResponseBody**](../models/GetCarrierSettingsResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatecarriersettings"></a>
# **UpdateCarrierSettings**
```csharp
string UpdateCarrierSettings (CarrierNameWithSettings carrierName, UpdateCarrierSettingsRequestBody updateCarrierSettingsRequestBody, string carrierId, CancellationToken cancellationToken = default)

string UpdateCarrierSettings (HttpClient methodClient, CarrierNameWithSettings carrierName, UpdateCarrierSettingsRequestBody updateCarrierSettingsRequestBody, string carrierId, CancellationToken cancellationToken = default)
```

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
            var carrierName = dhl_express;
            var updateCarrierSettingsRequestBody = new UpdateCarrierSettingsRequestBody();
            var carrierId = se-28529731;

            try
            {
                // Update carrier settings
                string result = await shipEngine.UpdateCarrierSettings(carrierName, updateCarrierSettingsRequestBody, carrierId);
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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **carrierName** | **CarrierNameWithSettings** | The carrier name, such as &#x60;ups&#x60;, &#x60;fedex&#x60;, or &#x60;dhl_express&#x60;. |  |
| **updateCarrierSettingsRequestBody** | [**UpdateCarrierSettingsRequestBody**](UpdateCarrierSettingsRequestBody.md) |  |  |
| **carrierId** | **string** | Carrier ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

