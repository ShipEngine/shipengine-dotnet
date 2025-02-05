# Shipments Methods

| Method | Description |
|--------|-------------|
| [**CancelShipments**](ShipmentsApi.md#cancelshipments) | Cancel a Shipment |
| [**CreateShipments**](ShipmentsApi.md#createshipments) | Create Shipments |
| [**GetShipmentByExternalId**](ShipmentsApi.md#getshipmentbyexternalid) | Get Shipment By External ID |
| [**GetShipmentById**](ShipmentsApi.md#getshipmentbyid) | Get Shipment By ID |
| [**ListShipmentRates**](ShipmentsApi.md#listshipmentrates) | Get Shipment Rates |
| [**ListShipments**](ShipmentsApi.md#listshipments) | List Shipments |
| [**ParseShipment**](ShipmentsApi.md#parseshipment) | Parse shipping info |
| [**ShipmentsListTags**](ShipmentsApi.md#shipmentslisttags) | Get Shipment Tags |
| [**ShipmentsUpdateTags**](ShipmentsApi.md#shipmentsupdatetags) | Update Shipments Tags |
| [**TagShipment**](ShipmentsApi.md#tagshipment) | Add Tag to Shipment |
| [**UntagShipment**](ShipmentsApi.md#untagshipment) | Remove Tag from Shipment |
| [**UpdateShipment**](ShipmentsApi.md#updateshipment) | Update Shipment By ID |

<a id="cancelshipments"></a>
# **CancelShipments**
```csharp
string CancelShipments (string shipmentId, CancellationToken cancellationToken = default)

string CancelShipments (HttpClient methodClient, string shipmentId, CancellationToken cancellationToken = default)
```

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
            var shipmentId = "shipmentId_example";

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **shipmentId** | **string** | Shipment ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

<a id="createshipments"></a>
# **CreateShipments**
```csharp
CreateShipmentsResponseBody CreateShipments (CreateShipmentsRequestBody createShipmentsRequestBody, CancellationToken cancellationToken = default)

CreateShipmentsResponseBody CreateShipments (HttpClient methodClient, CreateShipmentsRequestBody createShipmentsRequestBody, CancellationToken cancellationToken = default)
```

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
            var createShipmentsRequestBody = new CreateShipmentsRequestBody();

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **createShipmentsRequestBody** | [**CreateShipmentsRequestBody**](../../docs//models/CreateShipmentsRequestBody.md) |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**CreateShipmentsResponseBody**](../models/CreateShipmentsResponseBody.md)

<a id="getshipmentbyexternalid"></a>
# **GetShipmentByExternalId**
```csharp
GetShipmentByExternalIdResponseBody GetShipmentByExternalId (string externalShipmentId, CancellationToken cancellationToken = default)

GetShipmentByExternalIdResponseBody GetShipmentByExternalId (HttpClient methodClient, string externalShipmentId, CancellationToken cancellationToken = default)
```

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
            var externalShipmentId = 0bcb569d-1727-4ff9-ab49-b2fec0cee5ae;

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **externalShipmentId** | **string** |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetShipmentByExternalIdResponseBody**](../models/GetShipmentByExternalIdResponseBody.md)

<a id="getshipmentbyid"></a>
# **GetShipmentById**
```csharp
GetShipmentByIdResponseBody GetShipmentById (string shipmentId, CancellationToken cancellationToken = default)

GetShipmentByIdResponseBody GetShipmentById (HttpClient methodClient, string shipmentId, CancellationToken cancellationToken = default)
```

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
            var shipmentId = "shipmentId_example";

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **shipmentId** | **string** | Shipment ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetShipmentByIdResponseBody**](../models/GetShipmentByIdResponseBody.md)

<a id="listshipmentrates"></a>
# **ListShipmentRates**
```csharp
ListShipmentRatesResponseBody ListShipmentRates (string shipmentId, DateTimeOffset createdAtStart = null, CancellationToken cancellationToken = default)

ListShipmentRatesResponseBody ListShipmentRates (HttpClient methodClient, string shipmentId, DateTimeOffset createdAtStart = null, CancellationToken cancellationToken = default)
```

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
            var shipmentId = "shipmentId_example";
            var createdAtStart = 2019-03-12T19:24:13.657Z;

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **shipmentId** | **string** | Shipment ID |  |
| **createdAtStart** | **DateTimeOffset** | Used to create a filter for when a resource was created (ex. A shipment that was created after a certain time) | [optional]  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**ListShipmentRatesResponseBody**](../models/ListShipmentRatesResponseBody.md)

<a id="listshipments"></a>
# **ListShipments**
```csharp
ListShipmentsResponseBody ListShipments (DateTimeOffset createdAtStart = null, DateTimeOffset createdAtEnd = null, DateTimeOffset modifiedAtStart = null, DateTimeOffset modifiedAtEnd = null, ShipmentStatus shipmentStatus = null, ShipmentsSortBy sortBy = null, SortDir sortDir = null, string batchId = null, string tag = null, string salesOrderId = null, int page = null, int pageSize = null, CancellationToken cancellationToken = default)

ListShipmentsResponseBody ListShipments (HttpClient methodClient, DateTimeOffset createdAtStart = null, DateTimeOffset createdAtEnd = null, DateTimeOffset modifiedAtStart = null, DateTimeOffset modifiedAtEnd = null, ShipmentStatus shipmentStatus = null, ShipmentsSortBy sortBy = null, SortDir sortDir = null, string batchId = null, string tag = null, string salesOrderId = null, int page = null, int pageSize = null, CancellationToken cancellationToken = default)
```

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
            var createdAtStart = 2019-03-12T19:24:13.657Z;
            var createdAtEnd = 2019-03-12T19:24:13.657Z;
            var modifiedAtStart = 2019-03-12T19:24:13.657Z;
            var modifiedAtEnd = 2019-03-12T19:24:13.657Z;
            var shipmentStatus = (ShipmentStatus) "pending";
            var sortBy = modified_at;
            var sortDir = (SortDir) "asc";
            var batchId = "batchId_example";
            var tag = Letters_to_santa;
            var salesOrderId = "salesOrderId_example";
            var page = 2;
            var pageSize = 50;

            try
            {
                // List Shipments
                ListShipmentsResponseBody result = await shipEngine.ListShipments(createdAtStart, createdAtEnd, modifiedAtStart, modifiedAtEnd, shipmentStatus, sortBy, sortDir, batchId, tag, salesOrderId, page, pageSize);
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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **createdAtStart** | **DateTimeOffset** | Used to create a filter for when a resource was created (ex. A shipment that was created after a certain time) | [optional]  |
| **createdAtEnd** | **DateTimeOffset** | Used to create a filter for when a resource was created, (ex. A shipment that was created before a certain time) | [optional]  |
| **modifiedAtStart** | **DateTimeOffset** | Used to create a filter for when a resource was modified (ex. A shipment that was modified after a certain time) | [optional]  |
| **modifiedAtEnd** | **DateTimeOffset** | Used to create a filter for when a resource was modified (ex. A shipment that was modified before a certain time) | [optional]  |
| **shipmentStatus** | **ShipmentStatus** |  | [optional]  |
| **sortBy** | **ShipmentsSortBy** |  | [optional]  |
| **sortDir** | **SortDir** | Controls the sort order of the query. | [optional]  |
| **batchId** | **string** | Batch ID | [optional]  |
| **tag** | **string** | Search for shipments based on the custom tag added to the shipment object | [optional]  |
| **salesOrderId** | **string** | Sales Order ID | [optional]  |
| **page** | **int** | Return a specific page of results. Defaults to the first page. If set to a number that&#39;s greater than the number of pages of results, an empty page is returned.  | [optional] [default to 1] |
| **pageSize** | **int** | The number of results to return per response. | [optional] [default to 25] |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**ListShipmentsResponseBody**](../models/ListShipmentsResponseBody.md)

<a id="parseshipment"></a>
# **ParseShipment**
```csharp
ParseShipmentResponseBody ParseShipment (ParseShipmentRequestBody parseShipmentRequestBody, CancellationToken cancellationToken = default)

ParseShipmentResponseBody ParseShipment (HttpClient methodClient, ParseShipmentRequestBody parseShipmentRequestBody, CancellationToken cancellationToken = default)
```

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
            var parseShipmentRequestBody = new ParseShipmentRequestBody();

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **parseShipmentRequestBody** | [**ParseShipmentRequestBody**](../../docs//models/ParseShipmentRequestBody.md) | The only required field is &#x60;text&#x60;, which is the text to be parsed. You can optionally also provide a &#x60;shipment&#x60; containing any already-known values. For example, you probably already know the &#x60;ship_from&#x60; address, and you may also already know what carrier and service you want to use.  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**ParseShipmentResponseBody**](../models/ParseShipmentResponseBody.md)

<a id="shipmentslisttags"></a>
# **ShipmentsListTags**
```csharp
TagShipmentResponseBody ShipmentsListTags (string shipmentId, CancellationToken cancellationToken = default)

TagShipmentResponseBody ShipmentsListTags (HttpClient methodClient, string shipmentId, CancellationToken cancellationToken = default)
```

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
            var shipmentId = "shipmentId_example";

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **shipmentId** | **string** | Shipment ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**TagShipmentResponseBody**](../models/TagShipmentResponseBody.md)

<a id="shipmentsupdatetags"></a>
# **ShipmentsUpdateTags**
```csharp
void ShipmentsUpdateTags (UpdateShipmentsTagsRequestBody updateShipmentsTagsRequestBody, CancellationToken cancellationToken = default)

void ShipmentsUpdateTags (HttpClient methodClient, UpdateShipmentsTagsRequestBody updateShipmentsTagsRequestBody, CancellationToken cancellationToken = default)
```

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
            var updateShipmentsTagsRequestBody = new UpdateShipmentsTagsRequestBody();

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **updateShipmentsTagsRequestBody** | [**UpdateShipmentsTagsRequestBody**](../../docs//models/UpdateShipmentsTagsRequestBody.md) |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

void (empty response body)

<a id="tagshipment"></a>
# **TagShipment**
```csharp
TagShipmentResponseBody TagShipment (string shipmentId, string tagName, CancellationToken cancellationToken = default)

TagShipmentResponseBody TagShipment (HttpClient methodClient, string shipmentId, string tagName, CancellationToken cancellationToken = default)
```

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
            var shipmentId = "shipmentId_example";
            var tagName = "tagName_example";

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **shipmentId** | **string** | Shipment ID |  |
| **tagName** | **string** |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**TagShipmentResponseBody**](../models/TagShipmentResponseBody.md)

<a id="untagshipment"></a>
# **UntagShipment**
```csharp
string UntagShipment (string shipmentId, string tagName, CancellationToken cancellationToken = default)

string UntagShipment (HttpClient methodClient, string shipmentId, string tagName, CancellationToken cancellationToken = default)
```

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
            var shipmentId = "shipmentId_example";
            var tagName = "tagName_example";

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **shipmentId** | **string** | Shipment ID |  |
| **tagName** | **string** |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

<a id="updateshipment"></a>
# **UpdateShipment**
```csharp
UpdateShipmentResponseBody UpdateShipment (UpdateShipmentRequestBody updateShipmentRequestBody, string shipmentId, CancellationToken cancellationToken = default)

UpdateShipmentResponseBody UpdateShipment (HttpClient methodClient, UpdateShipmentRequestBody updateShipmentRequestBody, string shipmentId, CancellationToken cancellationToken = default)
```

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
            var updateShipmentRequestBody = new UpdateShipmentRequestBody();
            var shipmentId = "shipmentId_example";

            try
            {
                // Update Shipment By ID
                UpdateShipmentResponseBody result = await shipEngine.UpdateShipment(updateShipmentRequestBody, shipmentId);
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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **updateShipmentRequestBody** | [**UpdateShipmentRequestBody**](../../docs//models/UpdateShipmentRequestBody.md) |  |  |
| **shipmentId** | **string** | Shipment ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**UpdateShipmentResponseBody**](../models/UpdateShipmentResponseBody.md)

