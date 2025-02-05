

# Rates Methods

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CalculateRates**](RatesApi.md#calculaterates) | **POST** /v1/rates | Get Shipping Rates |
| [**CompareBulkRates**](RatesApi.md#comparebulkrates) | **POST** /v1/rates/bulk | Get Bulk Rates |
| [**EstimateRates**](RatesApi.md#estimaterates) | **POST** /v1/rates/estimate | Estimate Rates |
| [**GetRateById**](RatesApi.md#getratebyid) | **GET** /v1/rates/{rate_id} | Get Rate By ID |

<a id="calculaterates"></a>
# **CalculateRates**
```csharp
CalculateRatesResponseBody CalculateRates (CalculateRatesRequestBody calculateRatesRequestBody, CancellationToken cancellationToken = default)

CalculateRatesResponseBody CalculateRates (HttpClient methodClient, CalculateRatesRequestBody calculateRatesRequestBody, CancellationToken cancellationToken = default)
```

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
            var calculateRatesRequestBody = new CalculateRatesRequestBody();

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **calculateRatesRequestBody** | [**CalculateRatesRequestBody**](CalculateRatesRequestBody.md) |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**CalculateRatesResponseBody**](../models/CalculateRatesResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="comparebulkrates"></a>
# **CompareBulkRates**
```csharp
List&lt;BulkRate&gt; CompareBulkRates (CompareBulkRatesRequestBody compareBulkRatesRequestBody, CancellationToken cancellationToken = default)

List&lt;BulkRate&gt; CompareBulkRates (HttpClient methodClient, CompareBulkRatesRequestBody compareBulkRatesRequestBody, CancellationToken cancellationToken = default)
```

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
            var compareBulkRatesRequestBody = new CompareBulkRatesRequestBody();

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **compareBulkRatesRequestBody** | [**CompareBulkRatesRequestBody**](CompareBulkRatesRequestBody.md) |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**List&lt;BulkRate&gt;**](../models/BulkRate.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="estimaterates"></a>
# **EstimateRates**
```csharp
List&lt;RateEstimate&gt; EstimateRates (EstimateRatesRequestBody estimateRatesRequestBody, CancellationToken cancellationToken = default)

List&lt;RateEstimate&gt; EstimateRates (HttpClient methodClient, EstimateRatesRequestBody estimateRatesRequestBody, CancellationToken cancellationToken = default)
```

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
            var estimateRatesRequestBody = new EstimateRatesRequestBody();

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **estimateRatesRequestBody** | [**EstimateRatesRequestBody**](EstimateRatesRequestBody.md) |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**List&lt;RateEstimate&gt;**](../models/RateEstimate.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getratebyid"></a>
# **GetRateById**
```csharp
GetRateByIdResponseBody GetRateById (string rateId, CancellationToken cancellationToken = default)

GetRateByIdResponseBody GetRateById (HttpClient methodClient, string rateId, CancellationToken cancellationToken = default)
```

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
            var rateId = "rateId_example";

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **rateId** | **string** | Rate ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetRateByIdResponseBody**](../models/GetRateByIdResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

