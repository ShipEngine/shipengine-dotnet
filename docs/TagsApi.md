# ShipEngineSDK.Api.TagsApi

All URIs are relative to *https://api.shipengine.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTag**](TagsApi.md#createtag) | **POST** /v1/tags/{tag_name} | Create a New Tag |
| [**DeleteTag**](TagsApi.md#deletetag) | **DELETE** /v1/tags/{tag_name} | Delete Tag |
| [**ListTags**](TagsApi.md#listtags) | **GET** /v1/tags | Get Tags |
| [**RenameTag**](TagsApi.md#renametag) | **PUT** /v1/tags/{tag_name}/{new_tag_name} | Update Tag Name |

<a id="createtag"></a>
# **CreateTag**
> CreateTagResponseBody CreateTag (string tagName)

Create a New Tag

Create a new Tag for customizing how you track your shipments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class CreateTagExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var tagName = "tagName_example";  // string | 

            try
            {
                // Create a New Tag
                CreateTagResponseBody result = await shipEngine.CreateTag(tagName);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling TagsApi.CreateTag: " + e.Message);
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
| **tagName** | **string** |  |  |

### Return type

[**CreateTagResponseBody**](CreateTagResponseBody.md)

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

<a id="deletetag"></a>
# **DeleteTag**
> string DeleteTag (string tagName)

Delete Tag

Delete a tag that is no longer needed

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class DeleteTagExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var tagName = "tagName_example";  // string | 

            try
            {
                // Delete Tag
                string result = await shipEngine.DeleteTag(tagName);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling TagsApi.DeleteTag: " + e.Message);
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
| **tagName** | **string** |  |  |

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

<a id="listtags"></a>
# **ListTags**
> ListTagsResponseBody ListTags ()

Get Tags

Get a list of all tags associated with an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListTagsExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");

            try
            {
                // Get Tags
                ListTagsResponseBody result = await shipEngine.ListTags();
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling TagsApi.ListTags: " + e.Message);
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

[**ListTagsResponseBody**](ListTagsResponseBody.md)

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

<a id="renametag"></a>
# **RenameTag**
> string RenameTag (string tagName, string newTagName)

Update Tag Name

Change a tag name while still keeping the relevant shipments attached to it

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class RenameTagExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var tagName = "tagName_example";  // string | 
            var newTagName = "newTagName_example";  // string | 

            try
            {
                // Update Tag Name
                string result = await shipEngine.RenameTag(tagName, newTagName);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling TagsApi.RenameTag: " + e.Message);
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
| **tagName** | **string** |  |  |
| **newTagName** | **string** |  |  |

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

