# ShipEngineSDK.Api.AccountApi

All URIs are relative to *https://api.shipengine.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAccountImage**](AccountApi.md#createaccountimage) | **POST** /v1/account/settings/images | Create an Account Image |
| [**DeleteAccountImageById**](AccountApi.md#deleteaccountimagebyid) | **DELETE** /v1/account/settings/images/{label_image_id} | Delete Account Image By Id |
| [**GetAccountSettingsImagesById**](AccountApi.md#getaccountsettingsimagesbyid) | **GET** /v1/account/settings/images/{label_image_id} | Get Account Image By ID |
| [**ListAccountImages**](AccountApi.md#listaccountimages) | **GET** /v1/account/settings/images | List Account Images |
| [**ListAccountSettings**](AccountApi.md#listaccountsettings) | **GET** /v1/account/settings | List Account Settings |
| [**UpdateAccountSettingsImagesById**](AccountApi.md#updateaccountsettingsimagesbyid) | **PUT** /v1/account/settings/images/{label_image_id} | Update Account Image By ID |

<a id="createaccountimage"></a>
# **CreateAccountImage**
> GetAccountSettingsImagesResponseBody CreateAccountImage (CreateAccountSettingsImageRequestBody createAccountSettingsImageRequestBody)

Create an Account Image

Create an Account Image

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class CreateAccountImageExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var createAccountSettingsImageRequestBody = new CreateAccountSettingsImageRequestBody(); // CreateAccountSettingsImageRequestBody | 

            try
            {
                // Create an Account Image
                GetAccountSettingsImagesResponseBody result = await shipEngine.CreateAccountImage(createAccountSettingsImageRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling AccountApi.CreateAccountImage: " + e.Message);
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
| **createAccountSettingsImageRequestBody** | [**CreateAccountSettingsImageRequestBody**](CreateAccountSettingsImageRequestBody.md) |  |  |

### Return type

[**GetAccountSettingsImagesResponseBody**](GetAccountSettingsImagesResponseBody.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested object creation was a success. |  -  |
| **400** | The request contained errors. |  -  |
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteaccountimagebyid"></a>
# **DeleteAccountImageById**
> string DeleteAccountImageById (string labelImageId)

Delete Account Image By Id

Delete Account Image By Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class DeleteAccountImageByIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var labelImageId = "labelImageId_example";  // string | Label Image Id

            try
            {
                // Delete Account Image By Id
                string result = await shipEngine.DeleteAccountImageById(labelImageId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling AccountApi.DeleteAccountImageById: " + e.Message);
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
| **labelImageId** | **string** | Label Image Id |  |

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

<a id="getaccountsettingsimagesbyid"></a>
# **GetAccountSettingsImagesById**
> GetAccountSettingsImagesResponseBody GetAccountSettingsImagesById (string labelImageId)

Get Account Image By ID

Retrieve information for an account image.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetAccountSettingsImagesByIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var labelImageId = "labelImageId_example";  // string | Label Image Id

            try
            {
                // Get Account Image By ID
                GetAccountSettingsImagesResponseBody result = await shipEngine.GetAccountSettingsImagesById(labelImageId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccountSettingsImagesById: " + e.Message);
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
| **labelImageId** | **string** | Label Image Id |  |

### Return type

[**GetAccountSettingsImagesResponseBody**](GetAccountSettingsImagesResponseBody.md)

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

<a id="listaccountimages"></a>
# **ListAccountImages**
> ListAccountSettingsImagesResponseBody ListAccountImages ()

List Account Images

List all account images for the ShipEngine account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListAccountImagesExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");

            try
            {
                // List Account Images
                ListAccountSettingsImagesResponseBody result = await shipEngine.ListAccountImages();
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling AccountApi.ListAccountImages: " + e.Message);
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

[**ListAccountSettingsImagesResponseBody**](ListAccountSettingsImagesResponseBody.md)

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

<a id="listaccountsettings"></a>
# **ListAccountSettings**
> GetAccountSettingsResponseBody ListAccountSettings ()

List Account Settings

List all account settings for the ShipEngine account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListAccountSettingsExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");

            try
            {
                // List Account Settings
                GetAccountSettingsResponseBody result = await shipEngine.ListAccountSettings();
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling AccountApi.ListAccountSettings: " + e.Message);
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

[**GetAccountSettingsResponseBody**](GetAccountSettingsResponseBody.md)

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

<a id="updateaccountsettingsimagesbyid"></a>
# **UpdateAccountSettingsImagesById**
> string UpdateAccountSettingsImagesById (string labelImageId, UpdateAccountSettingsImageRequestBody updateAccountSettingsImageRequestBody)

Update Account Image By ID

Update information for an account image.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class UpdateAccountSettingsImagesByIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var labelImageId = "labelImageId_example";  // string | Label Image Id
            var updateAccountSettingsImageRequestBody = new UpdateAccountSettingsImageRequestBody(); // UpdateAccountSettingsImageRequestBody | 

            try
            {
                // Update Account Image By ID
                string result = await shipEngine.UpdateAccountSettingsImagesById(labelImageId, updateAccountSettingsImageRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling AccountApi.UpdateAccountSettingsImagesById: " + e.Message);
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
| **labelImageId** | **string** | Label Image Id |  |
| **updateAccountSettingsImageRequestBody** | [**UpdateAccountSettingsImageRequestBody**](UpdateAccountSettingsImageRequestBody.md) |  |  |

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

