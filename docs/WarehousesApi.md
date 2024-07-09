# ShipEngineSDK.Api.WarehousesApi

All URIs are relative to *https://api.shipengine.com*

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
> CreateWarehouseResponseBody CreateWarehouse (CreateWarehouseRequestBody createWarehouseRequestBody)

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
            var createWarehouseRequestBody = new CreateWarehouseRequestBody(); // CreateWarehouseRequestBody | 

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
| **createWarehouseRequestBody** | [**CreateWarehouseRequestBody**](CreateWarehouseRequestBody.md) |  |  |

### Return type

[**CreateWarehouseResponseBody**](CreateWarehouseResponseBody.md)

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

<a id="deletewarehouse"></a>
# **DeleteWarehouse**
> string DeleteWarehouse (string warehouseId)

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
            var warehouseId = "warehouseId_example";  // string | Warehouse ID

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
| **warehouseId** | **string** | Warehouse ID |  |

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

<a id="getwarehousebyid"></a>
# **GetWarehouseById**
> GetWarehouseByIdResponseBody GetWarehouseById (string warehouseId)

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
            var warehouseId = "warehouseId_example";  // string | Warehouse ID

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
| **warehouseId** | **string** | Warehouse ID |  |

### Return type

[**GetWarehouseByIdResponseBody**](GetWarehouseByIdResponseBody.md)

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

<a id="listwarehouses"></a>
# **ListWarehouses**
> ListWarehousesResponseBody ListWarehouses ()

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
This endpoint does not need any parameter.
### Return type

[**ListWarehousesResponseBody**](ListWarehousesResponseBody.md)

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

<a id="updatewarehouse"></a>
# **UpdateWarehouse**
> string UpdateWarehouse (string warehouseId, UpdateWarehouseRequestBody updateWarehouseRequestBody)

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
            var warehouseId = "warehouseId_example";  // string | Warehouse ID
            var updateWarehouseRequestBody = new UpdateWarehouseRequestBody(); // UpdateWarehouseRequestBody | 

            try
            {
                // Update Warehouse By Id
                string result = await shipEngine.UpdateWarehouse(warehouseId, updateWarehouseRequestBody);
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
| **warehouseId** | **string** | Warehouse ID |  |
| **updateWarehouseRequestBody** | [**UpdateWarehouseRequestBody**](UpdateWarehouseRequestBody.md) |  |  |

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
| **400** | The request contained errors. |  -  |
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatewarehousesettings"></a>
# **UpdateWarehouseSettings**
> string UpdateWarehouseSettings (string warehouseId, UpdateWarehouseSettingsRequestBody updateWarehouseSettingsRequestBody)

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
            var warehouseId = "warehouseId_example";  // string | Warehouse ID
            var updateWarehouseSettingsRequestBody = new UpdateWarehouseSettingsRequestBody(); // UpdateWarehouseSettingsRequestBody | 

            try
            {
                // Update Warehouse Settings
                string result = await shipEngine.UpdateWarehouseSettings(warehouseId, updateWarehouseSettingsRequestBody);
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
| **warehouseId** | **string** | Warehouse ID |  |
| **updateWarehouseSettingsRequestBody** | [**UpdateWarehouseSettingsRequestBody**](UpdateWarehouseSettingsRequestBody.md) |  |  |

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
| **400** | The request contained errors. |  -  |
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

