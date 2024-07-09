# ShipEngineSDK.Api.WebhooksApi

All URIs are relative to *https://api.shipengine.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateWebhook**](WebhooksApi.md#createwebhook) | **POST** /v1/environment/webhooks | Create a Webhook |
| [**DeleteWebhook**](WebhooksApi.md#deletewebhook) | **DELETE** /v1/environment/webhooks/{webhook_id} | Delete Webhook By ID |
| [**GetWebhookById**](WebhooksApi.md#getwebhookbyid) | **GET** /v1/environment/webhooks/{webhook_id} | Get Webhook By ID |
| [**ListWebhooks**](WebhooksApi.md#listwebhooks) | **GET** /v1/environment/webhooks | List Webhooks |
| [**UpdateWebhook**](WebhooksApi.md#updatewebhook) | **PUT** /v1/environment/webhooks/{webhook_id} | Update a Webhook |

<a id="createwebhook"></a>
# **CreateWebhook**
> CreateWebhookResponseBody CreateWebhook (CreateWebhookRequestBody createWebhookRequestBody)

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
            var createWebhookRequestBody = new CreateWebhookRequestBody(); // CreateWebhookRequestBody | 

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
| **createWebhookRequestBody** | [**CreateWebhookRequestBody**](CreateWebhookRequestBody.md) |  |  |

### Return type

[**CreateWebhookResponseBody**](CreateWebhookResponseBody.md)

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
| **409** | The request conflicts with an existing resource. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletewebhook"></a>
# **DeleteWebhook**
> string DeleteWebhook (string webhookId)

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
            var webhookId = "webhookId_example";  // string | Webhook ID

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
| **webhookId** | **string** | Webhook ID |  |

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

<a id="getwebhookbyid"></a>
# **GetWebhookById**
> GetWebhookByIdResponseBody GetWebhookById (string webhookId)

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
            var webhookId = "webhookId_example";  // string | Webhook ID

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
| **webhookId** | **string** | Webhook ID |  |

### Return type

[**GetWebhookByIdResponseBody**](GetWebhookByIdResponseBody.md)

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

<a id="listwebhooks"></a>
# **ListWebhooks**
> List&lt;Webhook&gt; ListWebhooks ()

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
This endpoint does not need any parameter.
### Return type

[**List&lt;Webhook&gt;**](Webhook.md)

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
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatewebhook"></a>
# **UpdateWebhook**
> string UpdateWebhook (string webhookId, UpdateWebhookRequestBody updateWebhookRequestBody)

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
            var webhookId = "webhookId_example";  // string | Webhook ID
            var updateWebhookRequestBody = new UpdateWebhookRequestBody(); // UpdateWebhookRequestBody | 

            try
            {
                // Update a Webhook
                string result = await shipEngine.UpdateWebhook(webhookId, updateWebhookRequestBody);
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
| **webhookId** | **string** | Webhook ID |  |
| **updateWebhookRequestBody** | [**UpdateWebhookRequestBody**](UpdateWebhookRequestBody.md) |  |  |

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

