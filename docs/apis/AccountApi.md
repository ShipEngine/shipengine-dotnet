# Account Methods

| Method | Description |
|--------|-------------|
| [**CreateAccountImage**](AccountApi.md#createaccountimage) | Create an Account Image |
| [**DeleteAccountImageById**](AccountApi.md#deleteaccountimagebyid) | Delete Account Image By Id |
| [**GetAccountSettingsImagesById**](AccountApi.md#getaccountsettingsimagesbyid) | Get Account Image By ID |
| [**ListAccountImages**](AccountApi.md#listaccountimages) | List Account Images |
| [**ListAccountSettings**](AccountApi.md#listaccountsettings) | List Account Settings |
| [**UpdateAccountSettingsImagesById**](AccountApi.md#updateaccountsettingsimagesbyid) | Update Account Image By ID |

<a id="createaccountimage"></a>
# **CreateAccountImage**
```csharp
GetAccountSettingsImagesResponseBody CreateAccountImage (CreateAccountSettingsImageRequestBody createAccountSettingsImageRequestBody, CancellationToken cancellationToken = default)

GetAccountSettingsImagesResponseBody CreateAccountImage (HttpClient methodClient, CreateAccountSettingsImageRequestBody createAccountSettingsImageRequestBody, CancellationToken cancellationToken = default)
```

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
            var createAccountSettingsImageRequestBody = new CreateAccountSettingsImageRequestBody();

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **createAccountSettingsImageRequestBody** | [**CreateAccountSettingsImageRequestBody**](CreateAccountSettingsImageRequestBody.md) |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetAccountSettingsImagesResponseBody**](../models/GetAccountSettingsImagesResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteaccountimagebyid"></a>
# **DeleteAccountImageById**
```csharp
string DeleteAccountImageById (string labelImageId, CancellationToken cancellationToken = default)

string DeleteAccountImageById (HttpClient methodClient, string labelImageId, CancellationToken cancellationToken = default)
```

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
            var labelImageId = "labelImageId_example";

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **labelImageId** | **string** | Label Image Id |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getaccountsettingsimagesbyid"></a>
# **GetAccountSettingsImagesById**
```csharp
GetAccountSettingsImagesResponseBody GetAccountSettingsImagesById (string labelImageId, CancellationToken cancellationToken = default)

GetAccountSettingsImagesResponseBody GetAccountSettingsImagesById (HttpClient methodClient, string labelImageId, CancellationToken cancellationToken = default)
```

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
            var labelImageId = "labelImageId_example";

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **labelImageId** | **string** | Label Image Id |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetAccountSettingsImagesResponseBody**](../models/GetAccountSettingsImagesResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listaccountimages"></a>
# **ListAccountImages**
```csharp
ListAccountSettingsImagesResponseBody ListAccountImages (CancellationToken cancellationToken = default)

ListAccountSettingsImagesResponseBody ListAccountImages (HttpClient methodClient, CancellationToken cancellationToken = default)
```

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
| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**ListAccountSettingsImagesResponseBody**](../models/ListAccountSettingsImagesResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listaccountsettings"></a>
# **ListAccountSettings**
```csharp
GetAccountSettingsResponseBody ListAccountSettings (CancellationToken cancellationToken = default)

GetAccountSettingsResponseBody ListAccountSettings (HttpClient methodClient, CancellationToken cancellationToken = default)
```

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
| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetAccountSettingsResponseBody**](../models/GetAccountSettingsResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateaccountsettingsimagesbyid"></a>
# **UpdateAccountSettingsImagesById**
```csharp
string UpdateAccountSettingsImagesById (UpdateAccountSettingsImageRequestBody updateAccountSettingsImageRequestBody, string labelImageId, CancellationToken cancellationToken = default)

string UpdateAccountSettingsImagesById (HttpClient methodClient, UpdateAccountSettingsImageRequestBody updateAccountSettingsImageRequestBody, string labelImageId, CancellationToken cancellationToken = default)
```

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
            var updateAccountSettingsImageRequestBody = new UpdateAccountSettingsImageRequestBody();
            var labelImageId = "labelImageId_example";

            try
            {
                // Update Account Image By ID
                string result = await shipEngine.UpdateAccountSettingsImagesById(updateAccountSettingsImageRequestBody, labelImageId);
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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **updateAccountSettingsImageRequestBody** | [**UpdateAccountSettingsImageRequestBody**](UpdateAccountSettingsImageRequestBody.md) |  |  |
| **labelImageId** | **string** | Label Image Id |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

