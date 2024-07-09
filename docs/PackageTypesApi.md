# ShipEngineSDK.Api.PackageTypesApi

All URIs are relative to *https://api.shipengine.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePackageType**](PackageTypesApi.md#createpackagetype) | **POST** /v1/packages | Create Custom Package Type |
| [**DeletePackageType**](PackageTypesApi.md#deletepackagetype) | **DELETE** /v1/packages/{package_id} | Delete A Custom Package By ID |
| [**GetPackageTypeById**](PackageTypesApi.md#getpackagetypebyid) | **GET** /v1/packages/{package_id} | Get Custom Package Type By ID |
| [**ListPackageTypes**](PackageTypesApi.md#listpackagetypes) | **GET** /v1/packages | List Custom Package Types |
| [**UpdatePackageType**](PackageTypesApi.md#updatepackagetype) | **PUT** /v1/packages/{package_id} | Update Custom Package Type By ID |

<a id="createpackagetype"></a>
# **CreatePackageType**
> CreatePackageTypeResponseBody CreatePackageType (CreatePackageTypeRequestBody createPackageTypeRequestBody)

Create Custom Package Type

Create a custom package type to better assist in getting accurate rate estimates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class CreatePackageTypeExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var createPackageTypeRequestBody = new CreatePackageTypeRequestBody(); // CreatePackageTypeRequestBody | 

            try
            {
                // Create Custom Package Type
                CreatePackageTypeResponseBody result = await shipEngine.CreatePackageType(createPackageTypeRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling PackageTypesApi.CreatePackageType: " + e.Message);
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
| **createPackageTypeRequestBody** | [**CreatePackageTypeRequestBody**](CreatePackageTypeRequestBody.md) |  |  |

### Return type

[**CreatePackageTypeResponseBody**](CreatePackageTypeResponseBody.md)

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

<a id="deletepackagetype"></a>
# **DeletePackageType**
> string DeletePackageType (string packageId)

Delete A Custom Package By ID

Delete a custom package using the ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class DeletePackageTypeExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var packageId = "packageId_example";  // string | Package ID

            try
            {
                // Delete A Custom Package By ID
                string result = await shipEngine.DeletePackageType(packageId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling PackageTypesApi.DeletePackageType: " + e.Message);
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
| **packageId** | **string** | Package ID |  |

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

<a id="getpackagetypebyid"></a>
# **GetPackageTypeById**
> GetPackageTypeByIdResponseBody GetPackageTypeById (string packageId)

Get Custom Package Type By ID

Get Custom Package Type by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetPackageTypeByIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var packageId = "packageId_example";  // string | Package ID

            try
            {
                // Get Custom Package Type By ID
                GetPackageTypeByIdResponseBody result = await shipEngine.GetPackageTypeById(packageId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling PackageTypesApi.GetPackageTypeById: " + e.Message);
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
| **packageId** | **string** | Package ID |  |

### Return type

[**GetPackageTypeByIdResponseBody**](GetPackageTypeByIdResponseBody.md)

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

<a id="listpackagetypes"></a>
# **ListPackageTypes**
> ListPackageTypesResponseBody ListPackageTypes ()

List Custom Package Types

List the custom package types associated with the account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListPackageTypesExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");

            try
            {
                // List Custom Package Types
                ListPackageTypesResponseBody result = await shipEngine.ListPackageTypes();
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling PackageTypesApi.ListPackageTypes: " + e.Message);
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

[**ListPackageTypesResponseBody**](ListPackageTypesResponseBody.md)

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

<a id="updatepackagetype"></a>
# **UpdatePackageType**
> string UpdatePackageType (string packageId, UpdatePackageTypeRequestBody updatePackageTypeRequestBody)

Update Custom Package Type By ID

Update the custom package type object by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class UpdatePackageTypeExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var packageId = "packageId_example";  // string | Package ID
            var updatePackageTypeRequestBody = new UpdatePackageTypeRequestBody(); // UpdatePackageTypeRequestBody | 

            try
            {
                // Update Custom Package Type By ID
                string result = await shipEngine.UpdatePackageType(packageId, updatePackageTypeRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling PackageTypesApi.UpdatePackageType: " + e.Message);
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
| **packageId** | **string** | Package ID |  |
| **updatePackageTypeRequestBody** | [**UpdatePackageTypeRequestBody**](UpdatePackageTypeRequestBody.md) |  |  |

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

