

# Webhooks Methods

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateWebhook**](WebhooksApi.md#createwebhook) | **POST** /v1/environment/webhooks | Create a Webhook |
| [**DeleteWebhook**](WebhooksApi.md#deletewebhook) | **DELETE** /v1/environment/webhooks/{webhook_id} | Delete Webhook By ID |
| [**GetWebhookById**](WebhooksApi.md#getwebhookbyid) | **GET** /v1/environment/webhooks/{webhook_id} | Get Webhook By ID |
| [**ListWebhooks**](WebhooksApi.md#listwebhooks) | **GET** /v1/environment/webhooks | List Webhooks |
| [**UpdateWebhook**](WebhooksApi.md#updatewebhook) | **PUT** /v1/environment/webhooks/{webhook_id} | Update a Webhook |

<a id="createwebhook"></a>
# **CreateWebhook**
```csharp
CreateWebhookResponseBody CreateWebhook (CreateWebhookRequestBody createWebhookRequestBody, CancellationToken cancellationToken = default)

CreateWebhookResponseBody CreateWebhook (HttpClient methodClient, CreateWebhookRequestBody createWebhookRequestBody, CancellationToken cancellationToken = default)
```

Create a Webhook

Create a webook for specific events in the environment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class CreateWebhookExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var createWebhookRequestBody = new CreateWebhookRequestBody();

            try
            {
                // Create a Webhook
                CreateWebhookResponseBody result = await shipEngine.CreateWebhook(createWebhookRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling WebhooksApi.CreateWebhook: " + e.Message);
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
| **createWebhookRequestBody** | [**CreateWebhookRequestBody**](CreateWebhookRequestBody.md) |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**CreateWebhookResponseBody**](../models/CreateWebhookResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletewebhook"></a>
# **DeleteWebhook**
```csharp
string DeleteWebhook (string webhookId, CancellationToken cancellationToken = default)

string DeleteWebhook (HttpClient methodClient, string webhookId, CancellationToken cancellationToken = default)
```

Delete Webhook By ID

Delete a webhook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class DeleteWebhookExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var webhookId = "webhookId_example";

            try
            {
                // Delete Webhook By ID
                string result = await shipEngine.DeleteWebhook(webhookId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling WebhooksApi.DeleteWebhook: " + e.Message);
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
| **webhookId** | **string** | Webhook ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getwebhookbyid"></a>
# **GetWebhookById**
```csharp
GetWebhookByIdResponseBody GetWebhookById (string webhookId, CancellationToken cancellationToken = default)

GetWebhookByIdResponseBody GetWebhookById (HttpClient methodClient, string webhookId, CancellationToken cancellationToken = default)
```

Get Webhook By ID

Retrieve individual webhook by an ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetWebhookByIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var webhookId = "webhookId_example";

            try
            {
                // Get Webhook By ID
                GetWebhookByIdResponseBody result = await shipEngine.GetWebhookById(webhookId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhookById: " + e.Message);
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
| **webhookId** | **string** | Webhook ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetWebhookByIdResponseBody**](../models/GetWebhookByIdResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listwebhooks"></a>
# **ListWebhooks**
```csharp
List&lt;Webhook&gt; ListWebhooks (, CancellationToken cancellationToken = default)

List&lt;Webhook&gt; ListWebhooks (HttpClient methodClient, , CancellationToken cancellationToken = default)
```

List Webhooks

List all webhooks currently enabled for the account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListWebhooksExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");

            try
            {
                // List Webhooks
                List<Webhook> result = await shipEngine.ListWebhooks();
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling WebhooksApi.ListWebhooks: " + e.Message);
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

[**List&lt;Webhook&gt;**](../models/Webhook.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatewebhook"></a>
# **UpdateWebhook**
```csharp
string UpdateWebhook (UpdateWebhookRequestBody updateWebhookRequestBodystring webhookId, CancellationToken cancellationToken = default)

string UpdateWebhook (HttpClient methodClient, UpdateWebhookRequestBody updateWebhookRequestBodystring webhookId, CancellationToken cancellationToken = default)
```

Update a Webhook

Update the webhook url property

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class UpdateWebhookExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var updateWebhookRequestBody = new UpdateWebhookRequestBody();
            var webhookId = "webhookId_example";

            try
            {
                // Update a Webhook
                string result = await shipEngine.UpdateWebhook(updateWebhookRequestBody, webhookId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling WebhooksApi.UpdateWebhook: " + e.Message);
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
| **updateWebhookRequestBody** | [**UpdateWebhookRequestBody**](UpdateWebhookRequestBody.md) |  |  |
| **webhookId** | **string** | Webhook ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

