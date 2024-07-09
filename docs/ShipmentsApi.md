# ShipEngineSDK.Api.ShipmentsApi

All URIs are relative to *https://api.shipengine.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelShipments**](ShipmentsApi.md#cancelshipments) | **PUT** /v1/shipments/{shipment_id}/cancel | Cancel a Shipment |
| [**CreateShipments**](ShipmentsApi.md#createshipments) | **POST** /v1/shipments | Create Shipments |
| [**GetShipmentByExternalId**](ShipmentsApi.md#getshipmentbyexternalid) | **GET** /v1/shipments/external_shipment_id/{external_shipment_id} | Get Shipment By External ID |
| [**GetShipmentById**](ShipmentsApi.md#getshipmentbyid) | **GET** /v1/shipments/{shipment_id} | Get Shipment By ID |
| [**ListShipmentRates**](ShipmentsApi.md#listshipmentrates) | **GET** /v1/shipments/{shipment_id}/rates | Get Shipment Rates |
| [**ListShipments**](ShipmentsApi.md#listshipments) | **GET** /v1/shipments | List Shipments |
| [**ParseShipment**](ShipmentsApi.md#parseshipment) | **PUT** /v1/shipments/recognize | Parse shipping info |
| [**ShipmentsListTags**](ShipmentsApi.md#shipmentslisttags) | **GET** /v1/shipments/{shipment_id}/tags | Get Shipment Tags |
| [**ShipmentsUpdateTags**](ShipmentsApi.md#shipmentsupdatetags) | **PUT** /v1/shipments/tags | Update Shipments Tags |
| [**TagShipment**](ShipmentsApi.md#tagshipment) | **POST** /v1/shipments/{shipment_id}/tags/{tag_name} | Add Tag to Shipment |
| [**UntagShipment**](ShipmentsApi.md#untagshipment) | **DELETE** /v1/shipments/{shipment_id}/tags/{tag_name} | Remove Tag from Shipment |
| [**UpdateShipment**](ShipmentsApi.md#updateshipment) | **PUT** /v1/shipments/{shipment_id} | Update Shipment By ID |

<a id="cancelshipments"></a>
# **CancelShipments**
> string CancelShipments (string shipmentId)

Cancel a Shipment

Mark a shipment cancelled, if it is no longer needed or being used by your organized. Any label associated with the shipment needs to be voided first An example use case would be if a batch label creation job is going to run at a set time and only queries `pending` shipments. Marking a shipment as cancelled would remove it from this process 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class CancelShipmentsExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var shipmentId = "shipmentId_example";  // string | Shipment ID

            try
            {
                // Cancel a Shipment
                string result = await shipEngine.CancelShipments(shipmentId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling ShipmentsApi.CancelShipments: " + e.Message);
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
| **shipmentId** | **string** | Shipment ID |  |

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

<a id="createshipments"></a>
# **CreateShipments**
> CreateShipmentsResponseBody CreateShipments (CreateShipmentsRequestBody createShipmentsRequestBody)

Create Shipments

Create one or multiple shipments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class CreateShipmentsExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var createShipmentsRequestBody = new CreateShipmentsRequestBody(); // CreateShipmentsRequestBody | 

            try
            {
                // Create Shipments
                CreateShipmentsResponseBody result = await shipEngine.CreateShipments(createShipmentsRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling ShipmentsApi.CreateShipments: " + e.Message);
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
| **createShipmentsRequestBody** | [**CreateShipmentsRequestBody**](CreateShipmentsRequestBody.md) |  |  |

### Return type

[**CreateShipmentsResponseBody**](CreateShipmentsResponseBody.md)

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
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getshipmentbyexternalid"></a>
# **GetShipmentByExternalId**
> GetShipmentByExternalIdResponseBody GetShipmentByExternalId (string externalShipmentId)

Get Shipment By External ID

Query Shipments created using your own custom ID convention using this endpint

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetShipmentByExternalIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var externalShipmentId = 0bcb569d-1727-4ff9-ab49-b2fec0cee5ae;  // string | 

            try
            {
                // Get Shipment By External ID
                GetShipmentByExternalIdResponseBody result = await shipEngine.GetShipmentByExternalId(externalShipmentId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling ShipmentsApi.GetShipmentByExternalId: " + e.Message);
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
| **externalShipmentId** | **string** |  |  |

### Return type

[**GetShipmentByExternalIdResponseBody**](GetShipmentByExternalIdResponseBody.md)

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

<a id="getshipmentbyid"></a>
# **GetShipmentById**
> GetShipmentByIdResponseBody GetShipmentById (string shipmentId)

Get Shipment By ID

Get an individual shipment based on its ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetShipmentByIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var shipmentId = "shipmentId_example";  // string | Shipment ID

            try
            {
                // Get Shipment By ID
                GetShipmentByIdResponseBody result = await shipEngine.GetShipmentById(shipmentId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling ShipmentsApi.GetShipmentById: " + e.Message);
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
| **shipmentId** | **string** | Shipment ID |  |

### Return type

[**GetShipmentByIdResponseBody**](GetShipmentByIdResponseBody.md)

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

<a id="listshipmentrates"></a>
# **ListShipmentRates**
> ListShipmentRatesResponseBody ListShipmentRates (string shipmentId, DateTime? createdAtStart = null)

Get Shipment Rates

Get Rates for the shipment information associated with the shipment ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListShipmentRatesExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var shipmentId = "shipmentId_example";  // string | Shipment ID
            var createdAtStart = 2019-03-12T19:24:13.657Z;  // DateTime? | Used to create a filter for when a resource was created (ex. A shipment that was created after a certain time) (optional) 

            try
            {
                // Get Shipment Rates
                ListShipmentRatesResponseBody result = await shipEngine.ListShipmentRates(shipmentId, createdAtStart);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ListShipmentRates: " + e.Message);
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
| **shipmentId** | **string** | Shipment ID |  |
| **createdAtStart** | **DateTime?** | Used to create a filter for when a resource was created (ex. A shipment that was created after a certain time) | [optional]  |

### Return type

[**ListShipmentRatesResponseBody**](ListShipmentRatesResponseBody.md)

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

<a id="listshipments"></a>
# **ListShipments**
> ListShipmentsResponseBody ListShipments (ShipmentStatus? shipmentStatus = null, string batchId = null, string tag = null, DateTime? createdAtStart = null, DateTime? createdAtEnd = null, DateTime? modifiedAtStart = null, DateTime? modifiedAtEnd = null, int? page = null, int? pageSize = null, string salesOrderId = null, SortDir? sortDir = null, ShipmentsSortBy? sortBy = null)

List Shipments

Get list of Shipments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListShipmentsExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var shipmentStatus = (ShipmentStatus) "pending";  // ShipmentStatus? |  (optional) 
            var batchId = "batchId_example";  // string | Batch ID (optional) 
            var tag = Letters_to_santa;  // string | Search for shipments based on the custom tag added to the shipment object (optional) 
            var createdAtStart = 2019-03-12T19:24:13.657Z;  // DateTime? | Used to create a filter for when a resource was created (ex. A shipment that was created after a certain time) (optional) 
            var createdAtEnd = 2019-03-12T19:24:13.657Z;  // DateTime? | Used to create a filter for when a resource was created, (ex. A shipment that was created before a certain time) (optional) 
            var modifiedAtStart = 2019-03-12T19:24:13.657Z;  // DateTime? | Used to create a filter for when a resource was modified (ex. A shipment that was modified after a certain time) (optional) 
            var modifiedAtEnd = 2019-03-12T19:24:13.657Z;  // DateTime? | Used to create a filter for when a resource was modified (ex. A shipment that was modified before a certain time) (optional) 
            var page = 2;  // int? | Return a specific page of results. Defaults to the first page. If set to a number that's greater than the number of pages of results, an empty page is returned.  (optional)  (default to 1)
            var pageSize = 50;  // int? | The number of results to return per response. (optional)  (default to 25)
            var salesOrderId = "salesOrderId_example";  // string | Sales Order ID (optional) 
            var sortDir = (SortDir) "asc";  // SortDir? | Controls the sort order of the query. (optional) 
            var sortBy = modified_at;  // ShipmentsSortBy? |  (optional) 

            try
            {
                // List Shipments
                ListShipmentsResponseBody result = await shipEngine.ListShipments(shipmentStatus, batchId, tag, createdAtStart, createdAtEnd, modifiedAtStart, modifiedAtEnd, page, pageSize, salesOrderId, sortDir, sortBy);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ListShipments: " + e.Message);
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
| **shipmentStatus** | **ShipmentStatus?** |  | [optional]  |
| **batchId** | **string** | Batch ID | [optional]  |
| **tag** | **string** | Search for shipments based on the custom tag added to the shipment object | [optional]  |
| **createdAtStart** | **DateTime?** | Used to create a filter for when a resource was created (ex. A shipment that was created after a certain time) | [optional]  |
| **createdAtEnd** | **DateTime?** | Used to create a filter for when a resource was created, (ex. A shipment that was created before a certain time) | [optional]  |
| **modifiedAtStart** | **DateTime?** | Used to create a filter for when a resource was modified (ex. A shipment that was modified after a certain time) | [optional]  |
| **modifiedAtEnd** | **DateTime?** | Used to create a filter for when a resource was modified (ex. A shipment that was modified before a certain time) | [optional]  |
| **page** | **int?** | Return a specific page of results. Defaults to the first page. If set to a number that&#39;s greater than the number of pages of results, an empty page is returned.  | [optional] [default to 1] |
| **pageSize** | **int?** | The number of results to return per response. | [optional] [default to 25] |
| **salesOrderId** | **string** | Sales Order ID | [optional]  |
| **sortDir** | **SortDir?** | Controls the sort order of the query. | [optional]  |
| **sortBy** | **ShipmentsSortBy?** |  | [optional]  |

### Return type

[**ListShipmentsResponseBody**](ListShipmentsResponseBody.md)

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

<a id="parseshipment"></a>
# **ParseShipment**
> ParseShipmentResponseBody ParseShipment (ParseShipmentRequestBody parseShipmentRequestBody)

Parse shipping info

The shipment-recognition API makes it easy for you to extract shipping data from unstructured text, including people's names, addresses, package weights and dimensions, insurance and delivery requirements, and more.  Data often enters your system as unstructured text (for example: emails, SMS messages, support tickets, or other documents). ShipEngine's shipment-recognition API helps you extract meaningful, structured data from this unstructured text. The parsed shipment data is returned in the same structure that's used for other ShipEngine APIs, so you can easily use the parsed data to create a shipping label.  > **Note:** Shipment recognition is currently supported for the United States, Canada, Australia, New Zealand, the United Kingdom, and Ireland. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ParseShipmentExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var parseShipmentRequestBody = new ParseShipmentRequestBody(); // ParseShipmentRequestBody | The only required field is `text`, which is the text to be parsed. You can optionally also provide a `shipment` containing any already-known values. For example, you probably already know the `ship_from` address, and you may also already know what carrier and service you want to use. 

            try
            {
                // Parse shipping info
                ParseShipmentResponseBody result = await shipEngine.ParseShipment(parseShipmentRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ParseShipment: " + e.Message);
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
| **parseShipmentRequestBody** | [**ParseShipmentRequestBody**](ParseShipmentRequestBody.md) | The only required field is &#x60;text&#x60;, which is the text to be parsed. You can optionally also provide a &#x60;shipment&#x60; containing any already-known values. For example, you probably already know the &#x60;ship_from&#x60; address, and you may also already know what carrier and service you want to use.  |  |

### Return type

[**ParseShipmentResponseBody**](ParseShipmentResponseBody.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the parsed shipment, as well as a confidence score and a list of all the shipping entities that were recognized in the text.  |  -  |
| **400** | The request contained errors. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="shipmentslisttags"></a>
# **ShipmentsListTags**
> TagShipmentResponseBody ShipmentsListTags (string shipmentId)

Get Shipment Tags

Get Shipment tags based on its ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ShipmentsListTagsExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var shipmentId = "shipmentId_example";  // string | Shipment ID

            try
            {
                // Get Shipment Tags
                TagShipmentResponseBody result = await shipEngine.ShipmentsListTags(shipmentId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentsListTags: " + e.Message);
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
| **shipmentId** | **string** | Shipment ID |  |

### Return type

[**TagShipmentResponseBody**](TagShipmentResponseBody.md)

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

<a id="shipmentsupdatetags"></a>
# **ShipmentsUpdateTags**
> void ShipmentsUpdateTags (UpdateShipmentsTagsRequestBody updateShipmentsTagsRequestBody)

Update Shipments Tags

Update Shipments Tags

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ShipmentsUpdateTagsExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var updateShipmentsTagsRequestBody = new UpdateShipmentsTagsRequestBody(); // UpdateShipmentsTagsRequestBody | 

            try
            {
                // Update Shipments Tags
                shipEngine.ShipmentsUpdateTags(updateShipmentsTagsRequestBody);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentsUpdateTags: " + e.Message);
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
| **updateShipmentsTagsRequestBody** | [**UpdateShipmentsTagsRequestBody**](UpdateShipmentsTagsRequestBody.md) |  |  |

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | NoContent |  -  |
| **400** | The request contained errors. |  -  |
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="tagshipment"></a>
# **TagShipment**
> TagShipmentResponseBody TagShipment (string shipmentId, string tagName)

Add Tag to Shipment

Add a tag to the shipment object

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class TagShipmentExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var shipmentId = "shipmentId_example";  // string | Shipment ID
            var tagName = "tagName_example";  // string | 

            try
            {
                // Add Tag to Shipment
                TagShipmentResponseBody result = await shipEngine.TagShipment(shipmentId, tagName);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling ShipmentsApi.TagShipment: " + e.Message);
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
| **shipmentId** | **string** | Shipment ID |  |
| **tagName** | **string** |  |  |

### Return type

[**TagShipmentResponseBody**](TagShipmentResponseBody.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested object creation was a success. |  -  |
| **400** | The request contained errors. |  -  |
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="untagshipment"></a>
# **UntagShipment**
> string UntagShipment (string shipmentId, string tagName)

Remove Tag from Shipment

Remove an existing tag from the Shipment object

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class UntagShipmentExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var shipmentId = "shipmentId_example";  // string | Shipment ID
            var tagName = "tagName_example";  // string | 

            try
            {
                // Remove Tag from Shipment
                string result = await shipEngine.UntagShipment(shipmentId, tagName);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling ShipmentsApi.UntagShipment: " + e.Message);
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
| **shipmentId** | **string** | Shipment ID |  |
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

<a id="updateshipment"></a>
# **UpdateShipment**
> UpdateShipmentResponseBody UpdateShipment (string shipmentId, UpdateShipmentRequestBody updateShipmentRequestBody)

Update Shipment By ID

Update a shipment object based on its ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class UpdateShipmentExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var shipmentId = "shipmentId_example";  // string | Shipment ID
            var updateShipmentRequestBody = new UpdateShipmentRequestBody(); // UpdateShipmentRequestBody | 

            try
            {
                // Update Shipment By ID
                UpdateShipmentResponseBody result = await shipEngine.UpdateShipment(shipmentId, updateShipmentRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling ShipmentsApi.UpdateShipment: " + e.Message);
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
| **shipmentId** | **string** | Shipment ID |  |
| **updateShipmentRequestBody** | [**UpdateShipmentRequestBody**](UpdateShipmentRequestBody.md) |  |  |

### Return type

[**UpdateShipmentResponseBody**](UpdateShipmentResponseBody.md)

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

