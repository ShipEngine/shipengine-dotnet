# Insurance Methods

| Method | Description |
|--------|-------------|
| [**AddFundsToInsurance**](InsuranceApi.md#addfundstoinsurance) | Add Funds To Insurance |
| [**ConnectInsurer**](InsuranceApi.md#connectinsurer) | Connect a Shipsurance Account |
| [**DisconnectInsurer**](InsuranceApi.md#disconnectinsurer) | Disconnect a Shipsurance Account |
| [**GetInsuranceBalance**](InsuranceApi.md#getinsurancebalance) | Get Insurance Funds Balance |

<a id="addfundstoinsurance"></a>
# **AddFundsToInsurance**
```csharp
AddFundsToInsuranceResponseBody AddFundsToInsurance (AddFundsToInsuranceRequestBody addFundsToInsuranceRequestBody, CancellationToken cancellationToken = default)

AddFundsToInsuranceResponseBody AddFundsToInsurance (HttpClient methodClient, AddFundsToInsuranceRequestBody addFundsToInsuranceRequestBody, CancellationToken cancellationToken = default)
```

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
            var addFundsToInsuranceRequestBody = new AddFundsToInsuranceRequestBody();

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **addFundsToInsuranceRequestBody** | [**AddFundsToInsuranceRequestBody**](AddFundsToInsuranceRequestBody.md) |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**AddFundsToInsuranceResponseBody**](../models/AddFundsToInsuranceResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="connectinsurer"></a>
# **ConnectInsurer**
```csharp
Object ConnectInsurer (ConnectInsurerRequestBody connectInsurerRequestBody, CancellationToken cancellationToken = default)

Object ConnectInsurer (HttpClient methodClient, ConnectInsurerRequestBody connectInsurerRequestBody, CancellationToken cancellationToken = default)
```

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
            var connectInsurerRequestBody = new ConnectInsurerRequestBody();

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **connectInsurerRequestBody** | [**ConnectInsurerRequestBody**](ConnectInsurerRequestBody.md) |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**Object**

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="disconnectinsurer"></a>
# **DisconnectInsurer**
```csharp
Object DisconnectInsurer (CancellationToken cancellationToken = default)

Object DisconnectInsurer (HttpClient methodClient, CancellationToken cancellationToken = default)
```

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
| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**Object**

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getinsurancebalance"></a>
# **GetInsuranceBalance**
```csharp
GetInsuranceBalanceResponseBody GetInsuranceBalance (CancellationToken cancellationToken = default)

GetInsuranceBalanceResponseBody GetInsuranceBalance (HttpClient methodClient, CancellationToken cancellationToken = default)
```

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
| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetInsuranceBalanceResponseBody**](../models/GetInsuranceBalanceResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

