# ShipEngineSDK.Api.PackagePickupsApi

All URIs are relative to *https://api.shipengine.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteScheduledPickup**](PackagePickupsApi.md#deletescheduledpickup) | **DELETE** /v1/pickups/{pickup_id} | Delete a Scheduled Pickup |
| [**GetPickupById**](PackagePickupsApi.md#getpickupbyid) | **GET** /v1/pickups/{pickup_id} | Get Pickup By ID |
| [**ListScheduledPickups**](PackagePickupsApi.md#listscheduledpickups) | **GET** /v1/pickups | List Scheduled Pickups |
| [**SchedulePickup**](PackagePickupsApi.md#schedulepickup) | **POST** /v1/pickups | Schedule a Pickup |

<a id="deletescheduledpickup"></a>
# **DeleteScheduledPickup**
> DeletePickupByIdResponseBody DeleteScheduledPickup (string pickupId)

Delete a Scheduled Pickup

Delete a previously-scheduled pickup by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class DeleteScheduledPickupExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var pickupId = "pickupId_example";  // string | 

            try
            {
                // Delete a Scheduled Pickup
                DeletePickupByIdResponseBody result = await shipEngine.DeleteScheduledPickup(pickupId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling PackagePickupsApi.DeleteScheduledPickup: " + e.Message);
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
| **pickupId** | **string** |  |  |

### Return type

[**DeletePickupByIdResponseBody**](DeletePickupByIdResponseBody.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return the &#x60;pickup_id&#x60; of the scheduled pickup that was successfully deleted  |  -  |
| **400** | The request contained errors. |  -  |
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpickupbyid"></a>
# **GetPickupById**
> GetPickupByIdResponseBody GetPickupById (string pickupId)

Get Pickup By ID

Get Pickup By ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetPickupByIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var pickupId = "pickupId_example";  // string | 

            try
            {
                // Get Pickup By ID
                GetPickupByIdResponseBody result = await shipEngine.GetPickupById(pickupId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling PackagePickupsApi.GetPickupById: " + e.Message);
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
| **pickupId** | **string** |  |  |

### Return type

[**GetPickupByIdResponseBody**](GetPickupByIdResponseBody.md)

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

<a id="listscheduledpickups"></a>
# **ListScheduledPickups**
> GetPickupsResponseBody ListScheduledPickups (string carrierId = null, string warehouseId = null, DateTime? createdAtStart = null, DateTime? createdAtEnd = null, int? page = null, int? pageSize = null)

List Scheduled Pickups

List all pickups that have been scheduled for this carrier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListScheduledPickupsExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var carrierId = "carrierId_example";  // string | Carrier ID (optional) 
            var warehouseId = "warehouseId_example";  // string | Warehouse ID (optional) 
            var createdAtStart = 2019-03-12T19:24:13.657Z;  // DateTime? | Only return scheduled pickups that were created on or after a specific date/time (optional) 
            var createdAtEnd = 2019-03-12T19:24:13.657Z;  // DateTime? | Only return scheduled pickups that were created on or before a specific date/time (optional) 
            var page = 2;  // int? | Return a specific page of results. Defaults to the first page. If set to a number that's greater than the number of pages of results, an empty page is returned.  (optional)  (default to 1)
            var pageSize = 50;  // int? | The number of results to return per response. (optional)  (default to 25)

            try
            {
                // List Scheduled Pickups
                GetPickupsResponseBody result = await shipEngine.ListScheduledPickups(carrierId, warehouseId, createdAtStart, createdAtEnd, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling PackagePickupsApi.ListScheduledPickups: " + e.Message);
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
| **carrierId** | **string** | Carrier ID | [optional]  |
| **warehouseId** | **string** | Warehouse ID | [optional]  |
| **createdAtStart** | **DateTime?** | Only return scheduled pickups that were created on or after a specific date/time | [optional]  |
| **createdAtEnd** | **DateTime?** | Only return scheduled pickups that were created on or before a specific date/time | [optional]  |
| **page** | **int?** | Return a specific page of results. Defaults to the first page. If set to a number that&#39;s greater than the number of pages of results, an empty page is returned.  | [optional] [default to 1] |
| **pageSize** | **int?** | The number of results to return per response. | [optional] [default to 25] |

### Return type

[**GetPickupsResponseBody**](GetPickupsResponseBody.md)

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

<a id="schedulepickup"></a>
# **SchedulePickup**
> SchedulePickupResponseBody SchedulePickup (SchedulePickupRequestBody schedulePickupRequestBody)

Schedule a Pickup

Schedule a package pickup with a carrier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class SchedulePickupExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var schedulePickupRequestBody = new SchedulePickupRequestBody(); // SchedulePickupRequestBody | 

            try
            {
                // Schedule a Pickup
                SchedulePickupResponseBody result = await shipEngine.SchedulePickup(schedulePickupRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling PackagePickupsApi.SchedulePickup: " + e.Message);
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
| **schedulePickupRequestBody** | [**SchedulePickupRequestBody**](SchedulePickupRequestBody.md) |  |  |

### Return type

[**SchedulePickupResponseBody**](SchedulePickupResponseBody.md)

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

