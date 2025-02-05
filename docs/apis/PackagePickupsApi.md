# PackagePickups Methods

| Method | Description |
|--------|-------------|
| [**DeleteScheduledPickup**](PackagePickupsApi.md#deletescheduledpickup) | Delete a Scheduled Pickup |
| [**GetPickupById**](PackagePickupsApi.md#getpickupbyid) | Get Pickup By ID |
| [**ListScheduledPickups**](PackagePickupsApi.md#listscheduledpickups) | List Scheduled Pickups |
| [**SchedulePickup**](PackagePickupsApi.md#schedulepickup) | Schedule a Pickup |

<a id="deletescheduledpickup"></a>
# **DeleteScheduledPickup**
```csharp
DeletePickupByIdResponseBody DeleteScheduledPickup (string pickupId, CancellationToken cancellationToken = default)

DeletePickupByIdResponseBody DeleteScheduledPickup (HttpClient methodClient, string pickupId, CancellationToken cancellationToken = default)
```

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
            var pickupId = "pickupId_example";

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **pickupId** | **string** |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**DeletePickupByIdResponseBody**](../models/DeletePickupByIdResponseBody.md)

<a id="getpickupbyid"></a>
# **GetPickupById**
```csharp
GetPickupByIdResponseBody GetPickupById (string pickupId, CancellationToken cancellationToken = default)

GetPickupByIdResponseBody GetPickupById (HttpClient methodClient, string pickupId, CancellationToken cancellationToken = default)
```

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
            var pickupId = "pickupId_example";

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **pickupId** | **string** |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetPickupByIdResponseBody**](../models/GetPickupByIdResponseBody.md)

<a id="listscheduledpickups"></a>
# **ListScheduledPickups**
```csharp
GetPickupsResponseBody ListScheduledPickups (DateTimeOffset createdAtStart = null, DateTimeOffset createdAtEnd = null, string carrierId = null, string warehouseId = null, int page = null, int pageSize = null, CancellationToken cancellationToken = default)

GetPickupsResponseBody ListScheduledPickups (HttpClient methodClient, DateTimeOffset createdAtStart = null, DateTimeOffset createdAtEnd = null, string carrierId = null, string warehouseId = null, int page = null, int pageSize = null, CancellationToken cancellationToken = default)
```

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
            var createdAtStart = 2019-03-12T19:24:13.657Z;
            var createdAtEnd = 2019-03-12T19:24:13.657Z;
            var carrierId = "carrierId_example";
            var warehouseId = "warehouseId_example";
            var page = 2;
            var pageSize = 50;

            try
            {
                // List Scheduled Pickups
                GetPickupsResponseBody result = await shipEngine.ListScheduledPickups(createdAtStart, createdAtEnd, carrierId, warehouseId, page, pageSize);
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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **createdAtStart** | **DateTimeOffset** | Only return scheduled pickups that were created on or after a specific date/time | [optional]  |
| **createdAtEnd** | **DateTimeOffset** | Only return scheduled pickups that were created on or before a specific date/time | [optional]  |
| **carrierId** | **string** | Carrier ID | [optional]  |
| **warehouseId** | **string** | Warehouse ID | [optional]  |
| **page** | **int** | Return a specific page of results. Defaults to the first page. If set to a number that&#39;s greater than the number of pages of results, an empty page is returned.  | [optional] [default to 1] |
| **pageSize** | **int** | The number of results to return per response. | [optional] [default to 25] |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetPickupsResponseBody**](../models/GetPickupsResponseBody.md)

<a id="schedulepickup"></a>
# **SchedulePickup**
```csharp
SchedulePickupResponseBody SchedulePickup (SchedulePickupRequestBody schedulePickupRequestBody, CancellationToken cancellationToken = default)

SchedulePickupResponseBody SchedulePickup (HttpClient methodClient, SchedulePickupRequestBody schedulePickupRequestBody, CancellationToken cancellationToken = default)
```

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
            var schedulePickupRequestBody = new SchedulePickupRequestBody();

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **schedulePickupRequestBody** | [**SchedulePickupRequestBody**](../../docs//models/SchedulePickupRequestBody.md) |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**SchedulePickupResponseBody**](../models/SchedulePickupResponseBody.md)

