# ShipEngineSDK.Api.LabelsApi

All URIs are relative to *https://api.shipengine.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateLabel**](LabelsApi.md#createlabel) | **POST** /v1/labels | Purchase Label |
| [**CreateLabelFromRate**](LabelsApi.md#createlabelfromrate) | **POST** /v1/labels/rates/{rate_id} | Purchase Label with Rate ID |
| [**CreateLabelFromShipment**](LabelsApi.md#createlabelfromshipment) | **POST** /v1/labels/shipment/{shipment_id} | Purchase Label with Shipment ID |
| [**CreateReturnLabel**](LabelsApi.md#createreturnlabel) | **POST** /v1/labels/{label_id}/return | Create a return label |
| [**GetLabelByExternalShipmentId**](LabelsApi.md#getlabelbyexternalshipmentid) | **GET** /v1/labels/external_shipment_id/{external_shipment_id} | Get Label By External Shipment ID |
| [**GetLabelById**](LabelsApi.md#getlabelbyid) | **GET** /v1/labels/{label_id} | Get Label By ID |
| [**GetTrackingLogFromLabel**](LabelsApi.md#gettrackinglogfromlabel) | **GET** /v1/labels/{label_id}/track | Get Label Tracking Information |
| [**ListLabels**](LabelsApi.md#listlabels) | **GET** /v1/labels | List labels |
| [**VoidLabel**](LabelsApi.md#voidlabel) | **PUT** /v1/labels/{label_id}/void | Void a Label By ID |

<a id="createlabel"></a>
# **CreateLabel**
> CreateLabelResponseBody CreateLabel (CreateLabelRequestBody createLabelRequestBody)

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
            var createLabelRequestBody = new CreateLabelRequestBody(); // CreateLabelRequestBody | 

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
| **createLabelRequestBody** | [**CreateLabelRequestBody**](CreateLabelRequestBody.md) |  |  |

### Return type

[**CreateLabelResponseBody**](CreateLabelResponseBody.md)

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

<a id="createlabelfromrate"></a>
# **CreateLabelFromRate**
> CreateLabelFromRateResponseBody CreateLabelFromRate (string rateId, CreateLabelFromRateRequestBody createLabelFromRateRequestBody)

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
            var rateId = "rateId_example";  // string | Rate ID
            var createLabelFromRateRequestBody = new CreateLabelFromRateRequestBody(); // CreateLabelFromRateRequestBody | 

            try
            {
                // Purchase Label with Rate ID
                CreateLabelFromRateResponseBody result = await shipEngine.CreateLabelFromRate(rateId, createLabelFromRateRequestBody);
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
| **rateId** | **string** | Rate ID |  |
| **createLabelFromRateRequestBody** | [**CreateLabelFromRateRequestBody**](CreateLabelFromRateRequestBody.md) |  |  |

### Return type

[**CreateLabelFromRateResponseBody**](CreateLabelFromRateResponseBody.md)

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

<a id="createlabelfromshipment"></a>
# **CreateLabelFromShipment**
> CreateLabelFromShipmentResponseBody CreateLabelFromShipment (string shipmentId, CreateLabelFromShipmentRequestBody createLabelFromShipmentRequestBody)

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
            var shipmentId = "shipmentId_example";  // string | Shipment ID
            var createLabelFromShipmentRequestBody = new CreateLabelFromShipmentRequestBody(); // CreateLabelFromShipmentRequestBody | 

            try
            {
                // Purchase Label with Shipment ID
                CreateLabelFromShipmentResponseBody result = await shipEngine.CreateLabelFromShipment(shipmentId, createLabelFromShipmentRequestBody);
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
| **shipmentId** | **string** | Shipment ID |  |
| **createLabelFromShipmentRequestBody** | [**CreateLabelFromShipmentRequestBody**](CreateLabelFromShipmentRequestBody.md) |  |  |

### Return type

[**CreateLabelFromShipmentResponseBody**](CreateLabelFromShipmentResponseBody.md)

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

<a id="createreturnlabel"></a>
# **CreateReturnLabel**
> CreateReturnLabelResponseBody CreateReturnLabel (string labelId, CreateReturnLabelRequestBody createReturnLabelRequestBody)

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
            var labelId = "labelId_example";  // string | Label ID
            var createReturnLabelRequestBody = new CreateReturnLabelRequestBody(); // CreateReturnLabelRequestBody | 

            try
            {
                // Create a return label
                CreateReturnLabelResponseBody result = await shipEngine.CreateReturnLabel(labelId, createReturnLabelRequestBody);
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
| **labelId** | **string** | Label ID |  |
| **createReturnLabelRequestBody** | [**CreateReturnLabelRequestBody**](CreateReturnLabelRequestBody.md) |  |  |

### Return type

[**CreateReturnLabelResponseBody**](CreateReturnLabelResponseBody.md)

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

<a id="getlabelbyexternalshipmentid"></a>
# **GetLabelByExternalShipmentId**
> GetLabelByExternalShipmentIdResponseBody GetLabelByExternalShipmentId (string externalShipmentId, LabelDownloadType? labelDownloadType = null)

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
            var externalShipmentId = 0bcb569d-1727-4ff9-ab49-b2fec0cee5ae;  // string | 
            var labelDownloadType = url;  // LabelDownloadType? |  (optional) 

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
| **externalShipmentId** | **string** |  |  |
| **labelDownloadType** | **LabelDownloadType?** |  | [optional]  |

### Return type

[**GetLabelByExternalShipmentIdResponseBody**](GetLabelByExternalShipmentIdResponseBody.md)

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

<a id="getlabelbyid"></a>
# **GetLabelById**
> GetLabelByIdResponseBody GetLabelById (string labelId, LabelDownloadType? labelDownloadType = null)

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
            var labelId = "labelId_example";  // string | Label ID
            var labelDownloadType = url;  // LabelDownloadType? |  (optional) 

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
| **labelId** | **string** | Label ID |  |
| **labelDownloadType** | **LabelDownloadType?** |  | [optional]  |

### Return type

[**GetLabelByIdResponseBody**](GetLabelByIdResponseBody.md)

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

<a id="gettrackinglogfromlabel"></a>
# **GetTrackingLogFromLabel**
> GetTrackingLogFromLabelResponseBody GetTrackingLogFromLabel (string labelId)

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
            var labelId = "labelId_example";  // string | Label ID

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
| **labelId** | **string** | Label ID |  |

### Return type

[**GetTrackingLogFromLabelResponseBody**](GetTrackingLogFromLabelResponseBody.md)

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

<a id="listlabels"></a>
# **ListLabels**
> ListLabelsResponseBody ListLabels (LabelStatus? labelStatus = null, string serviceCode = null, string carrierId = null, string trackingNumber = null, string batchId = null, string rateId = null, string shipmentId = null, string warehouseId = null, DateTime? createdAtStart = null, DateTime? createdAtEnd = null, int? page = null, int? pageSize = null, SortDir? sortDir = null, string sortBy = null)

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
            var labelStatus = (LabelStatus) "processing";  // LabelStatus? | Only return labels that are currently in the specified status (optional) 
            var serviceCode = usps_first_class_mail;  // string | Only return labels for a specific [carrier service](https://www.shipengine.com/docs/shipping/use-a-carrier-service/) (optional) 
            var carrierId = "carrierId_example";  // string | Only return labels for a specific [carrier account](https://www.shipengine.com/docs/carriers/setup/) (optional) 
            var trackingNumber = 9405511899223197428490;  // string | Only return labels with a specific tracking number (optional) 
            var batchId = "batchId_example";  // string | Only return labels that were created in a specific [batch](https://www.shipengine.com/docs/labels/bulk/) (optional) 
            var rateId = "rateId_example";  // string | Rate ID (optional) 
            var shipmentId = "shipmentId_example";  // string | Shipment ID (optional) 
            var warehouseId = "warehouseId_example";  // string | Only return labels that originate from a specific [warehouse](https://www.shipengine.com/docs/shipping/ship-from-a-warehouse/) (optional) 
            var createdAtStart = 2019-03-12T19:24:13.657Z;  // DateTime? | Only return labels that were created on or after a specific date/time (optional) 
            var createdAtEnd = 2019-03-12T19:24:13.657Z;  // DateTime? | Only return labels that were created on or before a specific date/time (optional) 
            var page = 2;  // int? | Return a specific page of results. Defaults to the first page. If set to a number that's greater than the number of pages of results, an empty page is returned.  (optional)  (default to 1)
            var pageSize = 50;  // int? | The number of results to return per response. (optional)  (default to 25)
            var sortDir = (SortDir) "asc";  // SortDir? | Controls the sort order of the query. (optional) 
            var sortBy = "modified_at";  // string | Controls which field the query is sorted by. (optional)  (default to created_at)

            try
            {
                // List labels
                ListLabelsResponseBody result = await shipEngine.ListLabels(labelStatus, serviceCode, carrierId, trackingNumber, batchId, rateId, shipmentId, warehouseId, createdAtStart, createdAtEnd, page, pageSize, sortDir, sortBy);
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
| **labelStatus** | **LabelStatus?** | Only return labels that are currently in the specified status | [optional]  |
| **serviceCode** | **string** | Only return labels for a specific [carrier service](https://www.shipengine.com/docs/shipping/use-a-carrier-service/) | [optional]  |
| **carrierId** | **string** | Only return labels for a specific [carrier account](https://www.shipengine.com/docs/carriers/setup/) | [optional]  |
| **trackingNumber** | **string** | Only return labels with a specific tracking number | [optional]  |
| **batchId** | **string** | Only return labels that were created in a specific [batch](https://www.shipengine.com/docs/labels/bulk/) | [optional]  |
| **rateId** | **string** | Rate ID | [optional]  |
| **shipmentId** | **string** | Shipment ID | [optional]  |
| **warehouseId** | **string** | Only return labels that originate from a specific [warehouse](https://www.shipengine.com/docs/shipping/ship-from-a-warehouse/) | [optional]  |
| **createdAtStart** | **DateTime?** | Only return labels that were created on or after a specific date/time | [optional]  |
| **createdAtEnd** | **DateTime?** | Only return labels that were created on or before a specific date/time | [optional]  |
| **page** | **int?** | Return a specific page of results. Defaults to the first page. If set to a number that&#39;s greater than the number of pages of results, an empty page is returned.  | [optional] [default to 1] |
| **pageSize** | **int?** | The number of results to return per response. | [optional] [default to 25] |
| **sortDir** | **SortDir?** | Controls the sort order of the query. | [optional]  |
| **sortBy** | **string** | Controls which field the query is sorted by. | [optional] [default to created_at] |

### Return type

[**ListLabelsResponseBody**](ListLabelsResponseBody.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The response includes a &#x60;labels&#x60; array containing a page of results (as determined by the &#x60;page_size&#x60; query parameter).  It also includes other useful information, such as the total number of labels that match the query criteria, the number of pages of results, and the URLs of the first, last, next, and previous pages of results.  |  -  |
| **400** | The request contained errors. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="voidlabel"></a>
# **VoidLabel**
> VoidLabelResponseBody VoidLabel (string labelId)

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
            var labelId = "labelId_example";  // string | Label ID

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
| **labelId** | **string** | Label ID |  |

### Return type

[**VoidLabelResponseBody**](VoidLabelResponseBody.md)

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

