# ShipEngineSDK.Api.InsuranceApi

All URIs are relative to *https://api.shipengine.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddFundsToInsurance**](InsuranceApi.md#addfundstoinsurance) | **PATCH** /v1/insurance/shipsurance/add_funds | Add Funds To Insurance |
| [**ConnectInsurer**](InsuranceApi.md#connectinsurer) | **POST** /v1/connections/insurance/shipsurance | Connect a Shipsurance Account |
| [**DisconnectInsurer**](InsuranceApi.md#disconnectinsurer) | **DELETE** /v1/connections/insurance/shipsurance | Disconnect a Shipsurance Account |
| [**GetInsuranceBalance**](InsuranceApi.md#getinsurancebalance) | **GET** /v1/insurance/shipsurance/balance | Get Insurance Funds Balance |

<a id="addfundstoinsurance"></a>
# **AddFundsToInsurance**
> AddFundsToInsuranceResponseBody AddFundsToInsurance (AddFundsToInsuranceRequestBody addFundsToInsuranceRequestBody)

Add Funds To Insurance

You may need to auto fund your account from time to time. For example, if you don't normally ship items over $100, and may want to add funds to insurance rather than keeping the account funded. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class AddFundsToInsuranceExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var addFundsToInsuranceRequestBody = new AddFundsToInsuranceRequestBody(); // AddFundsToInsuranceRequestBody | 

            try
            {
                // Add Funds To Insurance
                AddFundsToInsuranceResponseBody result = await shipEngine.AddFundsToInsurance(addFundsToInsuranceRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling InsuranceApi.AddFundsToInsurance: " + e.Message);
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
| **addFundsToInsuranceRequestBody** | [**AddFundsToInsuranceRequestBody**](AddFundsToInsuranceRequestBody.md) |  |  |

### Return type

[**AddFundsToInsuranceResponseBody**](AddFundsToInsuranceResponseBody.md)

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

<a id="connectinsurer"></a>
# **ConnectInsurer**
> Object ConnectInsurer (ConnectInsurerRequestBody connectInsurerRequestBody)

Connect a Shipsurance Account

Connect a Shipsurance Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ConnectInsurerExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var connectInsurerRequestBody = new ConnectInsurerRequestBody(); // ConnectInsurerRequestBody | 

            try
            {
                // Connect a Shipsurance Account
                Object result = await shipEngine.ConnectInsurer(connectInsurerRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling InsuranceApi.ConnectInsurer: " + e.Message);
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
| **connectInsurerRequestBody** | [**ConnectInsurerRequestBody**](ConnectInsurerRequestBody.md) |  |  |

### Return type

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request was a success |  -  |
| **400** | The request contained errors. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="disconnectinsurer"></a>
# **DisconnectInsurer**
> Object DisconnectInsurer ()

Disconnect a Shipsurance Account

Disconnect a Shipsurance Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class DisconnectInsurerExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");

            try
            {
                // Disconnect a Shipsurance Account
                Object result = await shipEngine.DisconnectInsurer();
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling InsuranceApi.DisconnectInsurer: " + e.Message);
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

**Object**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request was a success |  -  |
| **400** | The request contained errors. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinsurancebalance"></a>
# **GetInsuranceBalance**
> GetInsuranceBalanceResponseBody GetInsuranceBalance ()

Get Insurance Funds Balance

Retrieve the balance of your Shipsurance account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetInsuranceBalanceExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");

            try
            {
                // Get Insurance Funds Balance
                GetInsuranceBalanceResponseBody result = await shipEngine.GetInsuranceBalance();
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling InsuranceApi.GetInsuranceBalance: " + e.Message);
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

[**GetInsuranceBalanceResponseBody**](GetInsuranceBalanceResponseBody.md)

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
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

