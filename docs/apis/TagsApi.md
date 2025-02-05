# Tags Methods

| Method | Description |
|--------|-------------|
| [**CreateTag**](TagsApi.md#createtag) | Create a New Tag |
| [**DeleteTag**](TagsApi.md#deletetag) | Delete Tag |
| [**ListTags**](TagsApi.md#listtags) | Get Tags |
| [**RenameTag**](TagsApi.md#renametag) | Update Tag Name |

<a id="createtag"></a>
# **CreateTag**
```csharp
CreateTagResponseBody CreateTag (string tagName, CancellationToken cancellationToken = default)

CreateTagResponseBody CreateTag (HttpClient methodClient, string tagName, CancellationToken cancellationToken = default)
```

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
            var tagName = "tagName_example";

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **tagName** | **string** |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**CreateTagResponseBody**](../models/CreateTagResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletetag"></a>
# **DeleteTag**
```csharp
string DeleteTag (string tagName, CancellationToken cancellationToken = default)

string DeleteTag (HttpClient methodClient, string tagName, CancellationToken cancellationToken = default)
```

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
            var tagName = "tagName_example";

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **tagName** | **string** |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listtags"></a>
# **ListTags**
```csharp
ListTagsResponseBody ListTags (CancellationToken cancellationToken = default)

ListTagsResponseBody ListTags (HttpClient methodClient, CancellationToken cancellationToken = default)
```

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
| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**ListTagsResponseBody**](../models/ListTagsResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="renametag"></a>
# **RenameTag**
```csharp
string RenameTag (string tagName, string newTagName, CancellationToken cancellationToken = default)

string RenameTag (HttpClient methodClient, string tagName, string newTagName, CancellationToken cancellationToken = default)
```

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
            var tagName = "tagName_example";
            var newTagName = "newTagName_example";

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **tagName** | **string** |  |  |
| **newTagName** | **string** |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

