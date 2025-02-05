# Carriers Methods

| Method | Description |
|--------|-------------|
| [**AddFundsToCarrier**](CarriersApi.md#addfundstocarrier) | Add Funds To Carrier |
| [**DisconnectCarrierById**](CarriersApi.md#disconnectcarrierbyid) | Disconnect Carrier by ID |
| [**GetCarrierById**](CarriersApi.md#getcarrierbyid) | Get Carrier By ID |
| [**GetCarrierOptions**](CarriersApi.md#getcarrieroptions) | Get Carrier Options |
| [**ListCarrierPackageTypes**](CarriersApi.md#listcarrierpackagetypes) | List Carrier Package Types |
| [**ListCarrierServices**](CarriersApi.md#listcarrierservices) | List Carrier Services |
| [**ListCarriers**](CarriersApi.md#listcarriers) | List Carriers |

<a id="addfundstocarrier"></a>
# **AddFundsToCarrier**
```csharp
AddFundsToCarrierResponseBody AddFundsToCarrier (AddFundsToCarrierRequestBody addFundsToCarrierRequestBody, string carrierId, CancellationToken cancellationToken = default)

AddFundsToCarrierResponseBody AddFundsToCarrier (HttpClient methodClient, AddFundsToCarrierRequestBody addFundsToCarrierRequestBody, string carrierId, CancellationToken cancellationToken = default)
```

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
            var addFundsToCarrierRequestBody = new AddFundsToCarrierRequestBody();
            var carrierId = se-28529731;

            try
            {
                // Add Funds To Carrier
                AddFundsToCarrierResponseBody result = await shipEngine.AddFundsToCarrier(addFundsToCarrierRequestBody, carrierId);
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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **addFundsToCarrierRequestBody** | [**AddFundsToCarrierRequestBody**](AddFundsToCarrierRequestBody.md) |  |  |
| **carrierId** | **string** | Carrier ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**AddFundsToCarrierResponseBody**](../models/AddFundsToCarrierResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="disconnectcarrierbyid"></a>
# **DisconnectCarrierById**
```csharp
string DisconnectCarrierById (string carrierId, CancellationToken cancellationToken = default)

string DisconnectCarrierById (HttpClient methodClient, string carrierId, CancellationToken cancellationToken = default)
```

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
            var carrierId = se-28529731;

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **carrierId** | **string** | Carrier ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcarrierbyid"></a>
# **GetCarrierById**
```csharp
GetCarrierByIdResponseBody GetCarrierById (string carrierId, CancellationToken cancellationToken = default)

GetCarrierByIdResponseBody GetCarrierById (HttpClient methodClient, string carrierId, CancellationToken cancellationToken = default)
```

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
            var carrierId = se-28529731;

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **carrierId** | **string** | Carrier ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetCarrierByIdResponseBody**](../models/GetCarrierByIdResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcarrieroptions"></a>
# **GetCarrierOptions**
```csharp
GetCarrierOptionsResponseBody GetCarrierOptions (string carrierId, CancellationToken cancellationToken = default)

GetCarrierOptionsResponseBody GetCarrierOptions (HttpClient methodClient, string carrierId, CancellationToken cancellationToken = default)
```

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
            var carrierId = se-28529731;

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **carrierId** | **string** | Carrier ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetCarrierOptionsResponseBody**](../models/GetCarrierOptionsResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listcarrierpackagetypes"></a>
# **ListCarrierPackageTypes**
```csharp
ListCarrierPackageTypesResponseBody ListCarrierPackageTypes (string carrierId, CancellationToken cancellationToken = default)

ListCarrierPackageTypesResponseBody ListCarrierPackageTypes (HttpClient methodClient, string carrierId, CancellationToken cancellationToken = default)
```

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
            var carrierId = se-28529731;

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **carrierId** | **string** | Carrier ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**ListCarrierPackageTypesResponseBody**](../models/ListCarrierPackageTypesResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listcarrierservices"></a>
# **ListCarrierServices**
```csharp
ListCarrierServicesResponseBody ListCarrierServices (string carrierId, CancellationToken cancellationToken = default)

ListCarrierServicesResponseBody ListCarrierServices (HttpClient methodClient, string carrierId, CancellationToken cancellationToken = default)
```

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
            var carrierId = se-28529731;

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **carrierId** | **string** | Carrier ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**ListCarrierServicesResponseBody**](../models/ListCarrierServicesResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listcarriers"></a>
# **ListCarriers**
```csharp
GetCarriersResponseBody ListCarriers (CancellationToken cancellationToken = default)

GetCarriersResponseBody ListCarriers (HttpClient methodClient, CancellationToken cancellationToken = default)
```

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
| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetCarriersResponseBody**](../models/GetCarriersResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

