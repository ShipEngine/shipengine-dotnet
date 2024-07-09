# ShipEngineSDK.Api.CarriersApi

All URIs are relative to *https://api.shipengine.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddFundsToCarrier**](CarriersApi.md#addfundstocarrier) | **PUT** /v1/carriers/{carrier_id}/add_funds | Add Funds To Carrier |
| [**DisconnectCarrierById**](CarriersApi.md#disconnectcarrierbyid) | **DELETE** /v1/carriers/{carrier_id} | Disconnect Carrier by ID |
| [**GetCarrierById**](CarriersApi.md#getcarrierbyid) | **GET** /v1/carriers/{carrier_id} | Get Carrier By ID |
| [**GetCarrierOptions**](CarriersApi.md#getcarrieroptions) | **GET** /v1/carriers/{carrier_id}/options | Get Carrier Options |
| [**ListCarrierPackageTypes**](CarriersApi.md#listcarrierpackagetypes) | **GET** /v1/carriers/{carrier_id}/packages | List Carrier Package Types |
| [**ListCarrierServices**](CarriersApi.md#listcarrierservices) | **GET** /v1/carriers/{carrier_id}/services | List Carrier Services |
| [**ListCarriers**](CarriersApi.md#listcarriers) | **GET** /v1/carriers | List Carriers |

<a id="addfundstocarrier"></a>
# **AddFundsToCarrier**
> AddFundsToCarrierResponseBody AddFundsToCarrier (string carrierId, AddFundsToCarrierRequestBody addFundsToCarrierRequestBody)

Add Funds To Carrier

Add Funds To A Carrier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class AddFundsToCarrierExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var carrierId = se-28529731;  // string | Carrier ID
            var addFundsToCarrierRequestBody = new AddFundsToCarrierRequestBody(); // AddFundsToCarrierRequestBody | 

            try
            {
                // Add Funds To Carrier
                AddFundsToCarrierResponseBody result = await shipEngine.AddFundsToCarrier(carrierId, addFundsToCarrierRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling CarriersApi.AddFundsToCarrier: " + e.Message);
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
| **carrierId** | **string** | Carrier ID |  |
| **addFundsToCarrierRequestBody** | [**AddFundsToCarrierRequestBody**](AddFundsToCarrierRequestBody.md) |  |  |

### Return type

[**AddFundsToCarrierResponseBody**](AddFundsToCarrierResponseBody.md)

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

<a id="disconnectcarrierbyid"></a>
# **DisconnectCarrierById**
> string DisconnectCarrierById (string carrierId)

Disconnect Carrier by ID

Disconnect a Carrier of the given ID from the account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class DisconnectCarrierByIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var carrierId = se-28529731;  // string | Carrier ID

            try
            {
                // Disconnect Carrier by ID
                string result = await shipEngine.DisconnectCarrierById(carrierId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling CarriersApi.DisconnectCarrierById: " + e.Message);
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
| **400** | The request contained errors. |  -  |
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcarrierbyid"></a>
# **GetCarrierById**
> GetCarrierByIdResponseBody GetCarrierById (string carrierId)

Get Carrier By ID

Retrive carrier info by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetCarrierByIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var carrierId = se-28529731;  // string | Carrier ID

            try
            {
                // Get Carrier By ID
                GetCarrierByIdResponseBody result = await shipEngine.GetCarrierById(carrierId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling CarriersApi.GetCarrierById: " + e.Message);
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
| **carrierId** | **string** | Carrier ID |  |

### Return type

[**GetCarrierByIdResponseBody**](GetCarrierByIdResponseBody.md)

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

<a id="getcarrieroptions"></a>
# **GetCarrierOptions**
> GetCarrierOptionsResponseBody GetCarrierOptions (string carrierId)

Get Carrier Options

Get a list of the options available for the carrier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetCarrierOptionsExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var carrierId = se-28529731;  // string | Carrier ID

            try
            {
                // Get Carrier Options
                GetCarrierOptionsResponseBody result = await shipEngine.GetCarrierOptions(carrierId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling CarriersApi.GetCarrierOptions: " + e.Message);
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
| **carrierId** | **string** | Carrier ID |  |

### Return type

[**GetCarrierOptionsResponseBody**](GetCarrierOptionsResponseBody.md)

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

<a id="listcarrierpackagetypes"></a>
# **ListCarrierPackageTypes**
> ListCarrierPackageTypesResponseBody ListCarrierPackageTypes (string carrierId)

List Carrier Package Types

List the package types associated with the carrier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListCarrierPackageTypesExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var carrierId = se-28529731;  // string | Carrier ID

            try
            {
                // List Carrier Package Types
                ListCarrierPackageTypesResponseBody result = await shipEngine.ListCarrierPackageTypes(carrierId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling CarriersApi.ListCarrierPackageTypes: " + e.Message);
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
| **carrierId** | **string** | Carrier ID |  |

### Return type

[**ListCarrierPackageTypesResponseBody**](ListCarrierPackageTypesResponseBody.md)

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

<a id="listcarrierservices"></a>
# **ListCarrierServices**
> ListCarrierServicesResponseBody ListCarrierServices (string carrierId)

List Carrier Services

List the services associated with the carrier ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListCarrierServicesExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var carrierId = se-28529731;  // string | Carrier ID

            try
            {
                // List Carrier Services
                ListCarrierServicesResponseBody result = await shipEngine.ListCarrierServices(carrierId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling CarriersApi.ListCarrierServices: " + e.Message);
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
| **carrierId** | **string** | Carrier ID |  |

### Return type

[**ListCarrierServicesResponseBody**](ListCarrierServicesResponseBody.md)

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

<a id="listcarriers"></a>
# **ListCarriers**
> GetCarriersResponseBody ListCarriers ()

List Carriers

List all carriers that have been added to this account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListCarriersExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");

            try
            {
                // List Carriers
                GetCarriersResponseBody result = await shipEngine.ListCarriers();
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling CarriersApi.ListCarriers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetCarriersResponseBody**](GetCarriersResponseBody.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request was a success. |  -  |
| **207** | The request was a partial success. It contains results, as well as errors. |  -  |
| **400** | The request contained errors. |  -  |
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

