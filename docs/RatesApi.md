# ShipEngineSDK.Api.RatesApi

All URIs are relative to *https://api.shipengine.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CalculateRates**](RatesApi.md#calculaterates) | **POST** /v1/rates | Get Shipping Rates |
| [**CompareBulkRates**](RatesApi.md#comparebulkrates) | **POST** /v1/rates/bulk | Get Bulk Rates |
| [**EstimateRates**](RatesApi.md#estimaterates) | **POST** /v1/rates/estimate | Estimate Rates |
| [**GetRateById**](RatesApi.md#getratebyid) | **GET** /v1/rates/{rate_id} | Get Rate By ID |

<a id="calculaterates"></a>
# **CalculateRates**
> CalculateRatesResponseBody CalculateRates (CalculateRatesRequestBody calculateRatesRequestBody)

Get Shipping Rates

It's not uncommon that you want to give your customer the choice between whether they want to ship the fastest, cheapest, or the most trusted route. Most companies don't solely ship things using a single shipping option; so we provide functionality to show you all your options! 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class CalculateRatesExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var calculateRatesRequestBody = new CalculateRatesRequestBody(); // CalculateRatesRequestBody | 

            try
            {
                // Get Shipping Rates
                CalculateRatesResponseBody result = await shipEngine.CalculateRates(calculateRatesRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling RatesApi.CalculateRates: " + e.Message);
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
| **calculateRatesRequestBody** | [**CalculateRatesRequestBody**](CalculateRatesRequestBody.md) |  |  |

### Return type

[**CalculateRatesResponseBody**](CalculateRatesResponseBody.md)

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

<a id="comparebulkrates"></a>
# **CompareBulkRates**
> List&lt;BulkRate&gt; CompareBulkRates (CompareBulkRatesRequestBody compareBulkRatesRequestBody)

Get Bulk Rates

Get Bulk Shipment Rates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class CompareBulkRatesExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var compareBulkRatesRequestBody = new CompareBulkRatesRequestBody(); // CompareBulkRatesRequestBody | 

            try
            {
                // Get Bulk Rates
                List<BulkRate> result = await shipEngine.CompareBulkRates(compareBulkRatesRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling RatesApi.CompareBulkRates: " + e.Message);
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
| **compareBulkRatesRequestBody** | [**CompareBulkRatesRequestBody**](CompareBulkRatesRequestBody.md) |  |  |

### Return type

[**List&lt;BulkRate&gt;**](BulkRate.md)

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

<a id="estimaterates"></a>
# **EstimateRates**
> List&lt;RateEstimate&gt; EstimateRates (EstimateRatesRequestBody estimateRatesRequestBody)

Estimate Rates

Get Rate Estimates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class EstimateRatesExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var estimateRatesRequestBody = new EstimateRatesRequestBody(); // EstimateRatesRequestBody | 

            try
            {
                // Estimate Rates
                List<RateEstimate> result = await shipEngine.EstimateRates(estimateRatesRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling RatesApi.EstimateRates: " + e.Message);
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
| **estimateRatesRequestBody** | [**EstimateRatesRequestBody**](EstimateRatesRequestBody.md) |  |  |

### Return type

[**List&lt;RateEstimate&gt;**](RateEstimate.md)

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

<a id="getratebyid"></a>
# **GetRateById**
> GetRateByIdResponseBody GetRateById (string rateId)

Get Rate By ID

Retrieve a previously queried rate by its ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetRateByIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var rateId = "rateId_example";  // string | Rate ID

            try
            {
                // Get Rate By ID
                GetRateByIdResponseBody result = await shipEngine.GetRateById(rateId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling RatesApi.GetRateById: " + e.Message);
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
| **rateId** | **string** | Rate ID |  |

### Return type

[**GetRateByIdResponseBody**](GetRateByIdResponseBody.md)

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

