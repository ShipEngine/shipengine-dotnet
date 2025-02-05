# Labels Methods

| Method | Description |
|--------|-------------|
| [**CreateLabel**](LabelsApi.md#createlabel) | Purchase Label |
| [**CreateLabelFromRate**](LabelsApi.md#createlabelfromrate) | Purchase Label with Rate ID |
| [**CreateLabelFromShipment**](LabelsApi.md#createlabelfromshipment) | Purchase Label with Shipment ID |
| [**CreateReturnLabel**](LabelsApi.md#createreturnlabel) | Create a return label |
| [**GetLabelByExternalShipmentId**](LabelsApi.md#getlabelbyexternalshipmentid) | Get Label By External Shipment ID |
| [**GetLabelById**](LabelsApi.md#getlabelbyid) | Get Label By ID |
| [**GetTrackingLogFromLabel**](LabelsApi.md#gettrackinglogfromlabel) | Get Label Tracking Information |
| [**ListLabels**](LabelsApi.md#listlabels) | List labels |
| [**VoidLabel**](LabelsApi.md#voidlabel) | Void a Label By ID |

<a id="createlabel"></a>
# **CreateLabel**
```csharp
CreateLabelResponseBody CreateLabel (CreateLabelRequestBody createLabelRequestBody, CancellationToken cancellationToken = default)

CreateLabelResponseBody CreateLabel (HttpClient methodClient, CreateLabelRequestBody createLabelRequestBody, CancellationToken cancellationToken = default)
```

Purchase Label

Purchase and print a label for shipment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class CreateLabelExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var createLabelRequestBody = new CreateLabelRequestBody();

            try
            {
                // Purchase Label
                CreateLabelResponseBody result = await shipEngine.CreateLabel(createLabelRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling LabelsApi.CreateLabel: " + e.Message);
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
| **createLabelRequestBody** | [**CreateLabelRequestBody**](../../docs//models/CreateLabelRequestBody.md) |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**CreateLabelResponseBody**](../models/CreateLabelResponseBody.md)

<a id="createlabelfromrate"></a>
# **CreateLabelFromRate**
```csharp
CreateLabelFromRateResponseBody CreateLabelFromRate (CreateLabelFromRateRequestBody createLabelFromRateRequestBody, string rateId, CancellationToken cancellationToken = default)

CreateLabelFromRateResponseBody CreateLabelFromRate (HttpClient methodClient, CreateLabelFromRateRequestBody createLabelFromRateRequestBody, string rateId, CancellationToken cancellationToken = default)
```

Purchase Label with Rate ID

When retrieving rates for shipments using the `/rates` endpoint, the returned information contains a `rate_id` property that can be used to generate a label without having to refill in the shipment information repeatedly. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class CreateLabelFromRateExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var createLabelFromRateRequestBody = new CreateLabelFromRateRequestBody();
            var rateId = "rateId_example";

            try
            {
                // Purchase Label with Rate ID
                CreateLabelFromRateResponseBody result = await shipEngine.CreateLabelFromRate(createLabelFromRateRequestBody, rateId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling LabelsApi.CreateLabelFromRate: " + e.Message);
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
| **createLabelFromRateRequestBody** | [**CreateLabelFromRateRequestBody**](../../docs//models/CreateLabelFromRateRequestBody.md) |  |  |
| **rateId** | **string** | Rate ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**CreateLabelFromRateResponseBody**](../models/CreateLabelFromRateResponseBody.md)

<a id="createlabelfromshipment"></a>
# **CreateLabelFromShipment**
```csharp
CreateLabelFromShipmentResponseBody CreateLabelFromShipment (CreateLabelFromShipmentRequestBody createLabelFromShipmentRequestBody, string shipmentId, CancellationToken cancellationToken = default)

CreateLabelFromShipmentResponseBody CreateLabelFromShipment (HttpClient methodClient, CreateLabelFromShipmentRequestBody createLabelFromShipmentRequestBody, string shipmentId, CancellationToken cancellationToken = default)
```

Purchase Label with Shipment ID

Purchase a label using a shipment ID that has already been created with the desired address and package info. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class CreateLabelFromShipmentExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var createLabelFromShipmentRequestBody = new CreateLabelFromShipmentRequestBody();
            var shipmentId = "shipmentId_example";

            try
            {
                // Purchase Label with Shipment ID
                CreateLabelFromShipmentResponseBody result = await shipEngine.CreateLabelFromShipment(createLabelFromShipmentRequestBody, shipmentId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling LabelsApi.CreateLabelFromShipment: " + e.Message);
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
| **createLabelFromShipmentRequestBody** | [**CreateLabelFromShipmentRequestBody**](../../docs//models/CreateLabelFromShipmentRequestBody.md) |  |  |
| **shipmentId** | **string** | Shipment ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**CreateLabelFromShipmentResponseBody**](../models/CreateLabelFromShipmentResponseBody.md)

<a id="createreturnlabel"></a>
# **CreateReturnLabel**
```csharp
CreateReturnLabelResponseBody CreateReturnLabel (CreateReturnLabelRequestBody createReturnLabelRequestBody, string labelId, CancellationToken cancellationToken = default)

CreateReturnLabelResponseBody CreateReturnLabel (HttpClient methodClient, CreateReturnLabelRequestBody createReturnLabelRequestBody, string labelId, CancellationToken cancellationToken = default)
```

Create a return label

Create a return label

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class CreateReturnLabelExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var createReturnLabelRequestBody = new CreateReturnLabelRequestBody();
            var labelId = "labelId_example";

            try
            {
                // Create a return label
                CreateReturnLabelResponseBody result = await shipEngine.CreateReturnLabel(createReturnLabelRequestBody, labelId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling LabelsApi.CreateReturnLabel: " + e.Message);
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
| **createReturnLabelRequestBody** | [**CreateReturnLabelRequestBody**](../../docs//models/CreateReturnLabelRequestBody.md) |  |  |
| **labelId** | **string** | Label ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**CreateReturnLabelResponseBody**](../models/CreateReturnLabelResponseBody.md)

<a id="getlabelbyexternalshipmentid"></a>
# **GetLabelByExternalShipmentId**
```csharp
GetLabelByExternalShipmentIdResponseBody GetLabelByExternalShipmentId (string externalShipmentId, LabelDownloadType labelDownloadType = null, CancellationToken cancellationToken = default)

GetLabelByExternalShipmentIdResponseBody GetLabelByExternalShipmentId (HttpClient methodClient, string externalShipmentId, LabelDownloadType labelDownloadType = null, CancellationToken cancellationToken = default)
```

Get Label By External Shipment ID

Find a label by using the external shipment id that was used during label creation 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetLabelByExternalShipmentIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var externalShipmentId = 0bcb569d-1727-4ff9-ab49-b2fec0cee5ae;
            var labelDownloadType = url;

            try
            {
                // Get Label By External Shipment ID
                GetLabelByExternalShipmentIdResponseBody result = await shipEngine.GetLabelByExternalShipmentId(externalShipmentId, labelDownloadType);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling LabelsApi.GetLabelByExternalShipmentId: " + e.Message);
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
| **labelDownloadType** | **LabelDownloadType** |  | [optional]  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetLabelByExternalShipmentIdResponseBody**](../models/GetLabelByExternalShipmentIdResponseBody.md)

<a id="getlabelbyid"></a>
# **GetLabelById**
```csharp
GetLabelByIdResponseBody GetLabelById (string labelId, LabelDownloadType labelDownloadType = null, CancellationToken cancellationToken = default)

GetLabelByIdResponseBody GetLabelById (HttpClient methodClient, string labelId, LabelDownloadType labelDownloadType = null, CancellationToken cancellationToken = default)
```

Get Label By ID

Retrieve information for individual labels.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetLabelByIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var labelId = "labelId_example";
            var labelDownloadType = url;

            try
            {
                // Get Label By ID
                GetLabelByIdResponseBody result = await shipEngine.GetLabelById(labelId, labelDownloadType);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling LabelsApi.GetLabelById: " + e.Message);
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
| **labelId** | **string** | Label ID |  |
| **labelDownloadType** | **LabelDownloadType** |  | [optional]  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetLabelByIdResponseBody**](../models/GetLabelByIdResponseBody.md)

<a id="gettrackinglogfromlabel"></a>
# **GetTrackingLogFromLabel**
```csharp
GetTrackingLogFromLabelResponseBody GetTrackingLogFromLabel (string labelId, CancellationToken cancellationToken = default)

GetTrackingLogFromLabelResponseBody GetTrackingLogFromLabel (HttpClient methodClient, string labelId, CancellationToken cancellationToken = default)
```

Get Label Tracking Information

Retrieve the label's tracking information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetTrackingLogFromLabelExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var labelId = "labelId_example";

            try
            {
                // Get Label Tracking Information
                GetTrackingLogFromLabelResponseBody result = await shipEngine.GetTrackingLogFromLabel(labelId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling LabelsApi.GetTrackingLogFromLabel: " + e.Message);
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
| **labelId** | **string** | Label ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetTrackingLogFromLabelResponseBody**](../models/GetTrackingLogFromLabelResponseBody.md)

<a id="listlabels"></a>
# **ListLabels**
```csharp
ListLabelsResponseBody ListLabels (DateTimeOffset createdAtStart = null, DateTimeOffset createdAtEnd = null, LabelStatus labelStatus = null, SortDir sortDir = null, string serviceCode = null, string carrierId = null, string trackingNumber = null, string batchId = null, string rateId = null, string shipmentId = null, string warehouseId = null, int page = null, int pageSize = null, string sortBy = null, CancellationToken cancellationToken = default)

ListLabelsResponseBody ListLabels (HttpClient methodClient, DateTimeOffset createdAtStart = null, DateTimeOffset createdAtEnd = null, LabelStatus labelStatus = null, SortDir sortDir = null, string serviceCode = null, string carrierId = null, string trackingNumber = null, string batchId = null, string rateId = null, string shipmentId = null, string warehouseId = null, int page = null, int pageSize = null, string sortBy = null, CancellationToken cancellationToken = default)
```

List labels

This endpoint returns a list of labels that you've [created](https://www.shipengine.com/docs/labels/create-a-label/). You can optionally filter the results as well as control their sort order and the number of results returned at a time.  By default, all labels are returned, 25 at a time, starting with the most recently created ones.  You can combine multiple filter options to narrow-down the results.  For example, if you only want to get your UPS labels for your east coast warehouse you could query by both `warehouse_id` and `carrier_id` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListLabelsExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var createdAtStart = 2019-03-12T19:24:13.657Z;
            var createdAtEnd = 2019-03-12T19:24:13.657Z;
            var labelStatus = (LabelStatus) "processing";
            var sortDir = (SortDir) "asc";
            var serviceCode = usps_first_class_mail;
            var carrierId = "carrierId_example";
            var trackingNumber = 9405511899223197428490;
            var batchId = "batchId_example";
            var rateId = "rateId_example";
            var shipmentId = "shipmentId_example";
            var warehouseId = "warehouseId_example";
            var page = 2;
            var pageSize = 50;
            var sortBy = "modified_at";

            try
            {
                // List labels
                ListLabelsResponseBody result = await shipEngine.ListLabels(createdAtStart, createdAtEnd, labelStatus, sortDir, serviceCode, carrierId, trackingNumber, batchId, rateId, shipmentId, warehouseId, page, pageSize, sortBy);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling LabelsApi.ListLabels: " + e.Message);
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
| **createdAtStart** | **DateTimeOffset** | Only return labels that were created on or after a specific date/time | [optional]  |
| **createdAtEnd** | **DateTimeOffset** | Only return labels that were created on or before a specific date/time | [optional]  |
| **labelStatus** | **LabelStatus** | Only return labels that are currently in the specified status | [optional]  |
| **sortDir** | **SortDir** | Controls the sort order of the query. | [optional]  |
| **serviceCode** | **string** | Only return labels for a specific [carrier service](https://www.shipengine.com/docs/shipping/use-a-carrier-service/) | [optional]  |
| **carrierId** | **string** | Only return labels for a specific [carrier account](https://www.shipengine.com/docs/carriers/setup/) | [optional]  |
| **trackingNumber** | **string** | Only return labels with a specific tracking number | [optional]  |
| **batchId** | **string** | Only return labels that were created in a specific [batch](https://www.shipengine.com/docs/labels/bulk/) | [optional]  |
| **rateId** | **string** | Rate ID | [optional]  |
| **shipmentId** | **string** | Shipment ID | [optional]  |
| **warehouseId** | **string** | Only return labels that originate from a specific [warehouse](https://www.shipengine.com/docs/shipping/ship-from-a-warehouse/) | [optional]  |
| **page** | **int** | Return a specific page of results. Defaults to the first page. If set to a number that&#39;s greater than the number of pages of results, an empty page is returned.  | [optional] [default to 1] |
| **pageSize** | **int** | The number of results to return per response. | [optional] [default to 25] |
| **sortBy** | **string** | Controls which field the query is sorted by. | [optional] [default to created_at] |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**ListLabelsResponseBody**](../models/ListLabelsResponseBody.md)

<a id="voidlabel"></a>
# **VoidLabel**
```csharp
VoidLabelResponseBody VoidLabel (string labelId, CancellationToken cancellationToken = default)

VoidLabelResponseBody VoidLabel (HttpClient methodClient, string labelId, CancellationToken cancellationToken = default)
```

Void a Label By ID

Void a label by ID to get a refund.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class VoidLabelExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var labelId = "labelId_example";

            try
            {
                // Void a Label By ID
                VoidLabelResponseBody result = await shipEngine.VoidLabel(labelId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling LabelsApi.VoidLabel: " + e.Message);
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
| **labelId** | **string** | Label ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**VoidLabelResponseBody**](../models/VoidLabelResponseBody.md)

