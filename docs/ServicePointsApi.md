# ShipEngineSDK.Api.ServicePointsApi

All URIs are relative to *https://api.shipengine.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ServicePointsGetById**](ServicePointsApi.md#servicepointsgetbyid) | **GET** /v1/service_points/{carrier_code}/{country_code}/{service_point_id} | Get Service Point By ID |
| [**ServicePointsList**](ServicePointsApi.md#servicepointslist) | **POST** /v1/service_points/list | List Service Points |

<a id="servicepointsgetbyid"></a>
# **ServicePointsGetById**
> GetServicePointByIdResponseBody ServicePointsGetById (string carrierCode, string countryCode, string servicePointId)

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
            var carrierCode = stamps_com;  // string | Carrier code
            var countryCode = CA;  // string | A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) 
            var servicePointId = 614940;  // string | 

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
| **carrierCode** | **string** | Carrier code |  |
| **countryCode** | **string** | A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1)  |  |
| **servicePointId** | **string** |  |  |

### Return type

[**GetServicePointByIdResponseBody**](GetServicePointByIdResponseBody.md)

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

<a id="servicepointslist"></a>
# **ServicePointsList**
> ListServicePointsResponseBody ServicePointsList (GetServicePointsRequest getServicePointsRequest)

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
            var getServicePointsRequest = new GetServicePointsRequest(); // GetServicePointsRequest | 

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
| **getServicePointsRequest** | [**GetServicePointsRequest**](GetServicePointsRequest.md) |  |  |

### Return type

[**ListServicePointsResponseBody**](ListServicePointsResponseBody.md)

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

