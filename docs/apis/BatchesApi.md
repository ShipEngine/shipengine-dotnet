# Batches Methods

| Method | Description |
|--------|-------------|
| [**AddToBatch**](BatchesApi.md#addtobatch) | Add to a Batch |
| [**CreateBatch**](BatchesApi.md#createbatch) | Create A Batch |
| [**DeleteBatch**](BatchesApi.md#deletebatch) | Delete Batch By Id |
| [**GetBatchByExternalId**](BatchesApi.md#getbatchbyexternalid) | Get Batch By External ID |
| [**GetBatchById**](BatchesApi.md#getbatchbyid) | Get Batch By ID |
| [**ListBatchErrors**](BatchesApi.md#listbatcherrors) | Get Batch Errors |
| [**ListBatches**](BatchesApi.md#listbatches) | List Batches |
| [**ProcessBatch**](BatchesApi.md#processbatch) | Process Batch ID Labels |
| [**RemoveFromBatch**](BatchesApi.md#removefrombatch) | Remove From Batch |
| [**UpdateBatch**](BatchesApi.md#updatebatch) | Update Batch By Id |

<a id="addtobatch"></a>
# **AddToBatch**
```csharp
string AddToBatch (AddToBatchRequestBody addToBatchRequestBody, string batchId, CancellationToken cancellationToken = default)

string AddToBatch (HttpClient methodClient, AddToBatchRequestBody addToBatchRequestBody, string batchId, CancellationToken cancellationToken = default)
```

Add to a Batch

Add a Shipment or Rate to a Batch

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class AddToBatchExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var addToBatchRequestBody = new AddToBatchRequestBody();
            var batchId = "batchId_example";

            try
            {
                // Add to a Batch
                string result = await shipEngine.AddToBatch(addToBatchRequestBody, batchId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.AddToBatch: " + e.Message);
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
| **addToBatchRequestBody** | [**AddToBatchRequestBody**](../../docs//models/AddToBatchRequestBody.md) |  |  |
| **batchId** | **string** | Batch ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

<a id="createbatch"></a>
# **CreateBatch**
```csharp
CreateBatchResponseBody CreateBatch (CreateBatchRequest createBatchRequest, CancellationToken cancellationToken = default)

CreateBatchResponseBody CreateBatch (HttpClient methodClient, CreateBatchRequest createBatchRequest, CancellationToken cancellationToken = default)
```

Create A Batch

Create a Batch

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class CreateBatchExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var createBatchRequest = new CreateBatchRequest();

            try
            {
                // Create A Batch
                CreateBatchResponseBody result = await shipEngine.CreateBatch(createBatchRequest);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.CreateBatch: " + e.Message);
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
| **createBatchRequest** | [**CreateBatchRequest**](../../docs//models/CreateBatchRequest.md) |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**CreateBatchResponseBody**](../models/CreateBatchResponseBody.md)

<a id="deletebatch"></a>
# **DeleteBatch**
```csharp
string DeleteBatch (string batchId, CancellationToken cancellationToken = default)

string DeleteBatch (HttpClient methodClient, string batchId, CancellationToken cancellationToken = default)
```

Delete Batch By Id

Delete Batch By Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class DeleteBatchExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var batchId = "batchId_example";

            try
            {
                // Delete Batch By Id
                string result = await shipEngine.DeleteBatch(batchId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.DeleteBatch: " + e.Message);
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
| **batchId** | **string** | Batch ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

<a id="getbatchbyexternalid"></a>
# **GetBatchByExternalId**
```csharp
GetBatchByExternalIdResponseBody GetBatchByExternalId (string externalBatchId, CancellationToken cancellationToken = default)

GetBatchByExternalIdResponseBody GetBatchByExternalId (HttpClient methodClient, string externalBatchId, CancellationToken cancellationToken = default)
```

Get Batch By External ID

Get Batch By External ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetBatchByExternalIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var externalBatchId = 13553d7f-3c87-4771-bae1-c49bacef11cb;

            try
            {
                // Get Batch By External ID
                GetBatchByExternalIdResponseBody result = await shipEngine.GetBatchByExternalId(externalBatchId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.GetBatchByExternalId: " + e.Message);
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
| **externalBatchId** | **string** |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetBatchByExternalIdResponseBody**](../models/GetBatchByExternalIdResponseBody.md)

<a id="getbatchbyid"></a>
# **GetBatchById**
```csharp
GetBatchByIdResponseBody GetBatchById (string batchId, CancellationToken cancellationToken = default)

GetBatchByIdResponseBody GetBatchById (HttpClient methodClient, string batchId, CancellationToken cancellationToken = default)
```

Get Batch By ID

Get Batch By ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetBatchByIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var batchId = "batchId_example";

            try
            {
                // Get Batch By ID
                GetBatchByIdResponseBody result = await shipEngine.GetBatchById(batchId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.GetBatchById: " + e.Message);
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
| **batchId** | **string** | Batch ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetBatchByIdResponseBody**](../models/GetBatchByIdResponseBody.md)

<a id="listbatcherrors"></a>
# **ListBatchErrors**
```csharp
ListBatchErrorsResponseBody ListBatchErrors (string batchId, int pagesize = null, int page = null, CancellationToken cancellationToken = default)

ListBatchErrorsResponseBody ListBatchErrors (HttpClient methodClient, string batchId, int pagesize = null, int page = null, CancellationToken cancellationToken = default)
```

Get Batch Errors

Error handling in batches are handled differently than in a single synchronous request. You must retrieve the status of your batch by [getting a batch](https://www.shipengine.com/docs/reference/get-batch-by-id/) and getting an overview of the statuses or you can list errors directly here below to get detailed information about the errors. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListBatchErrorsExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var batchId = "batchId_example";
            var pagesize = 56;
            var page = 2;

            try
            {
                // Get Batch Errors
                ListBatchErrorsResponseBody result = await shipEngine.ListBatchErrors(batchId, pagesize, page);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.ListBatchErrors: " + e.Message);
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
| **batchId** | **string** | Batch ID |  |
| **pagesize** | **int** |  | [optional]  |
| **page** | **int** | Return a specific page of results. Defaults to the first page. If set to a number that&#39;s greater than the number of pages of results, an empty page is returned.  | [optional] [default to 1] |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**ListBatchErrorsResponseBody**](../models/ListBatchErrorsResponseBody.md)

<a id="listbatches"></a>
# **ListBatches**
```csharp
ListBatchesResponseBody ListBatches (BatchStatus status = null, BatchesSortBy sortBy = null, SortDir sortDir = null, string batchNumber = null, int page = null, int pageSize = null, CancellationToken cancellationToken = default)

ListBatchesResponseBody ListBatches (HttpClient methodClient, BatchStatus status = null, BatchesSortBy sortBy = null, SortDir sortDir = null, string batchNumber = null, int page = null, int pageSize = null, CancellationToken cancellationToken = default)
```

List Batches

List Batches associated with your Shipengine account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListBatchesExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var status = (BatchStatus) "open";
            var sortBy = (BatchesSortBy) "ship_date";
            var sortDir = (SortDir) "asc";
            var batchNumber = "batchNumber_example";
            var page = 2;
            var pageSize = 50;

            try
            {
                // List Batches
                ListBatchesResponseBody result = await shipEngine.ListBatches(status, sortBy, sortDir, batchNumber, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.ListBatches: " + e.Message);
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
| **status** | **BatchStatus** |  | [optional]  |
| **sortBy** | **BatchesSortBy** |  | [optional]  |
| **sortDir** | **SortDir** | Controls the sort order of the query. | [optional]  |
| **batchNumber** | **string** | Batch Number | [optional]  |
| **page** | **int** | Return a specific page of results. Defaults to the first page. If set to a number that&#39;s greater than the number of pages of results, an empty page is returned.  | [optional] [default to 1] |
| **pageSize** | **int** | The number of results to return per response. | [optional] [default to 25] |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**ListBatchesResponseBody**](../models/ListBatchesResponseBody.md)

<a id="processbatch"></a>
# **ProcessBatch**
```csharp
string ProcessBatch (ProcessBatchRequestBody processBatchRequestBody, string batchId, CancellationToken cancellationToken = default)

string ProcessBatch (HttpClient methodClient, ProcessBatchRequestBody processBatchRequestBody, string batchId, CancellationToken cancellationToken = default)
```

Process Batch ID Labels

Process Batch ID Labels

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ProcessBatchExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var processBatchRequestBody = new ProcessBatchRequestBody();
            var batchId = "batchId_example";

            try
            {
                // Process Batch ID Labels
                string result = await shipEngine.ProcessBatch(processBatchRequestBody, batchId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.ProcessBatch: " + e.Message);
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
| **processBatchRequestBody** | [**ProcessBatchRequestBody**](../../docs//models/ProcessBatchRequestBody.md) |  |  |
| **batchId** | **string** | Batch ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

<a id="removefrombatch"></a>
# **RemoveFromBatch**
```csharp
string RemoveFromBatch (RemoveFromBatchRequestBody removeFromBatchRequestBody, string batchId, CancellationToken cancellationToken = default)

string RemoveFromBatch (HttpClient methodClient, RemoveFromBatchRequestBody removeFromBatchRequestBody, string batchId, CancellationToken cancellationToken = default)
```

Remove From Batch

Remove a shipment or rate from a batch

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class RemoveFromBatchExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var removeFromBatchRequestBody = new RemoveFromBatchRequestBody();
            var batchId = "batchId_example";

            try
            {
                // Remove From Batch
                string result = await shipEngine.RemoveFromBatch(removeFromBatchRequestBody, batchId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.RemoveFromBatch: " + e.Message);
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
| **removeFromBatchRequestBody** | [**RemoveFromBatchRequestBody**](../../docs//models/RemoveFromBatchRequestBody.md) |  |  |
| **batchId** | **string** | Batch ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

<a id="updatebatch"></a>
# **UpdateBatch**
```csharp
string UpdateBatch (string batchId, CancellationToken cancellationToken = default)

string UpdateBatch (HttpClient methodClient, string batchId, CancellationToken cancellationToken = default)
```

Update Batch By Id

Update Batch By Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class UpdateBatchExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var batchId = "batchId_example";

            try
            {
                // Update Batch By Id
                string result = await shipEngine.UpdateBatch(batchId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling BatchesApi.UpdateBatch: " + e.Message);
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
| **batchId** | **string** | Batch ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

