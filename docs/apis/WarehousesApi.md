

# Warehouses Methods

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateWarehouse**](WarehousesApi.md#createwarehouse) | **POST** /v1/warehouses | Create Warehouse |
| [**DeleteWarehouse**](WarehousesApi.md#deletewarehouse) | **DELETE** /v1/warehouses/{warehouse_id} | Delete Warehouse By ID |
| [**GetWarehouseById**](WarehousesApi.md#getwarehousebyid) | **GET** /v1/warehouses/{warehouse_id} | Get Warehouse By Id |
| [**ListWarehouses**](WarehousesApi.md#listwarehouses) | **GET** /v1/warehouses | List Warehouses |
| [**UpdateWarehouse**](WarehousesApi.md#updatewarehouse) | **PUT** /v1/warehouses/{warehouse_id} | Update Warehouse By Id |
| [**UpdateWarehouseSettings**](WarehousesApi.md#updatewarehousesettings) | **PUT** /v1/warehouses/{warehouse_id}/settings | Update Warehouse Settings |

<a id="createwarehouse"></a>
# **CreateWarehouse**
```csharp
CreateWarehouseResponseBody CreateWarehouse (CreateWarehouseRequestBody createWarehouseRequestBody, CancellationToken cancellationToken = default)

CreateWarehouseResponseBody CreateWarehouse (HttpClient methodClient, CreateWarehouseRequestBody createWarehouseRequestBody, CancellationToken cancellationToken = default)
```

Create Warehouse

Create a warehouse location that you can use to create shipping items by simply passing in the generated warehouse id. If the return address is not supplied in the request body then it is assumed that the origin address is the return address as well 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class CreateWarehouseExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var createWarehouseRequestBody = new CreateWarehouseRequestBody();

            try
            {
                // Create Warehouse
                CreateWarehouseResponseBody result = await shipEngine.CreateWarehouse(createWarehouseRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling WarehousesApi.CreateWarehouse: " + e.Message);
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
| **createWarehouseRequestBody** | [**CreateWarehouseRequestBody**](CreateWarehouseRequestBody.md) |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**CreateWarehouseResponseBody**](../models/CreateWarehouseResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletewarehouse"></a>
# **DeleteWarehouse**
```csharp
string DeleteWarehouse (string warehouseId, CancellationToken cancellationToken = default)

string DeleteWarehouse (HttpClient methodClient, string warehouseId, CancellationToken cancellationToken = default)
```

Delete Warehouse By ID

Delete a warehouse by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class DeleteWarehouseExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var warehouseId = "warehouseId_example";

            try
            {
                // Delete Warehouse By ID
                string result = await shipEngine.DeleteWarehouse(warehouseId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling WarehousesApi.DeleteWarehouse: " + e.Message);
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
| **warehouseId** | **string** | Warehouse ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getwarehousebyid"></a>
# **GetWarehouseById**
```csharp
GetWarehouseByIdResponseBody GetWarehouseById (string warehouseId, CancellationToken cancellationToken = default)

GetWarehouseByIdResponseBody GetWarehouseById (HttpClient methodClient, string warehouseId, CancellationToken cancellationToken = default)
```

Get Warehouse By Id

Retrieve warehouse data based on the warehouse ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetWarehouseByIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var warehouseId = "warehouseId_example";

            try
            {
                // Get Warehouse By Id
                GetWarehouseByIdResponseBody result = await shipEngine.GetWarehouseById(warehouseId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling WarehousesApi.GetWarehouseById: " + e.Message);
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
| **warehouseId** | **string** | Warehouse ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetWarehouseByIdResponseBody**](../models/GetWarehouseByIdResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listwarehouses"></a>
# **ListWarehouses**
```csharp
ListWarehousesResponseBody ListWarehouses (, CancellationToken cancellationToken = default)

ListWarehousesResponseBody ListWarehouses (HttpClient methodClient, , CancellationToken cancellationToken = default)
```

List Warehouses

Retrieve a list of warehouses associated with this account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListWarehousesExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");

            try
            {
                // List Warehouses
                ListWarehousesResponseBody result = await shipEngine.ListWarehouses();
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling WarehousesApi.ListWarehouses: " + e.Message);
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

[**ListWarehousesResponseBody**](../models/ListWarehousesResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatewarehouse"></a>
# **UpdateWarehouse**
```csharp
string UpdateWarehouse (UpdateWarehouseRequestBody updateWarehouseRequestBodystring warehouseId, CancellationToken cancellationToken = default)

string UpdateWarehouse (HttpClient methodClient, UpdateWarehouseRequestBody updateWarehouseRequestBodystring warehouseId, CancellationToken cancellationToken = default)
```

Update Warehouse By Id

Update Warehouse object information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class UpdateWarehouseExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var updateWarehouseRequestBody = new UpdateWarehouseRequestBody();
            var warehouseId = "warehouseId_example";

            try
            {
                // Update Warehouse By Id
                string result = await shipEngine.UpdateWarehouse(updateWarehouseRequestBody, warehouseId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling WarehousesApi.UpdateWarehouse: " + e.Message);
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
| **updateWarehouseRequestBody** | [**UpdateWarehouseRequestBody**](UpdateWarehouseRequestBody.md) |  |  |
| **warehouseId** | **string** | Warehouse ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatewarehousesettings"></a>
# **UpdateWarehouseSettings**
```csharp
string UpdateWarehouseSettings (UpdateWarehouseSettingsRequestBody updateWarehouseSettingsRequestBodystring warehouseId, CancellationToken cancellationToken = default)

string UpdateWarehouseSettings (HttpClient methodClient, UpdateWarehouseSettingsRequestBody updateWarehouseSettingsRequestBodystring warehouseId, CancellationToken cancellationToken = default)
```

Update Warehouse Settings

Update Warehouse settings object information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class UpdateWarehouseSettingsExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var updateWarehouseSettingsRequestBody = new UpdateWarehouseSettingsRequestBody();
            var warehouseId = "warehouseId_example";

            try
            {
                // Update Warehouse Settings
                string result = await shipEngine.UpdateWarehouseSettings(updateWarehouseSettingsRequestBody, warehouseId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling WarehousesApi.UpdateWarehouseSettings: " + e.Message);
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
| **updateWarehouseSettingsRequestBody** | [**UpdateWarehouseSettingsRequestBody**](UpdateWarehouseSettingsRequestBody.md) |  |  |
| **warehouseId** | **string** | Warehouse ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

