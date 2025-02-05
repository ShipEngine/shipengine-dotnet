# PackageTypes Methods

| Method | Description |
|--------|-------------|
| [**CreatePackageType**](PackageTypesApi.md#createpackagetype) | Create Custom Package Type |
| [**DeletePackageType**](PackageTypesApi.md#deletepackagetype) | Delete A Custom Package By ID |
| [**GetPackageTypeById**](PackageTypesApi.md#getpackagetypebyid) | Get Custom Package Type By ID |
| [**ListPackageTypes**](PackageTypesApi.md#listpackagetypes) | List Custom Package Types |
| [**UpdatePackageType**](PackageTypesApi.md#updatepackagetype) | Update Custom Package Type By ID |

<a id="createpackagetype"></a>
# **CreatePackageType**
```csharp
CreatePackageTypeResponseBody CreatePackageType (CreatePackageTypeRequestBody createPackageTypeRequestBody, CancellationToken cancellationToken = default)

CreatePackageTypeResponseBody CreatePackageType (HttpClient methodClient, CreatePackageTypeRequestBody createPackageTypeRequestBody, CancellationToken cancellationToken = default)
```

Create Custom Package Type

Create a custom package type to better assist in getting accurate rate estimates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class CreatePackageTypeExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var createPackageTypeRequestBody = new CreatePackageTypeRequestBody();

            try
            {
                // Create Custom Package Type
                CreatePackageTypeResponseBody result = await shipEngine.CreatePackageType(createPackageTypeRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling PackageTypesApi.CreatePackageType: " + e.Message);
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
| **createPackageTypeRequestBody** | [**CreatePackageTypeRequestBody**](../../docs//models/CreatePackageTypeRequestBody.md) |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**CreatePackageTypeResponseBody**](../models/CreatePackageTypeResponseBody.md)

<a id="deletepackagetype"></a>
# **DeletePackageType**
```csharp
string DeletePackageType (string packageId, CancellationToken cancellationToken = default)

string DeletePackageType (HttpClient methodClient, string packageId, CancellationToken cancellationToken = default)
```

Delete A Custom Package By ID

Delete a custom package using the ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class DeletePackageTypeExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var packageId = "packageId_example";

            try
            {
                // Delete A Custom Package By ID
                string result = await shipEngine.DeletePackageType(packageId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling PackageTypesApi.DeletePackageType: " + e.Message);
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
| **packageId** | **string** | Package ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

<a id="getpackagetypebyid"></a>
# **GetPackageTypeById**
```csharp
GetPackageTypeByIdResponseBody GetPackageTypeById (string packageId, CancellationToken cancellationToken = default)

GetPackageTypeByIdResponseBody GetPackageTypeById (HttpClient methodClient, string packageId, CancellationToken cancellationToken = default)
```

Get Custom Package Type By ID

Get Custom Package Type by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class GetPackageTypeByIdExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var packageId = "packageId_example";

            try
            {
                // Get Custom Package Type By ID
                GetPackageTypeByIdResponseBody result = await shipEngine.GetPackageTypeById(packageId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling PackageTypesApi.GetPackageTypeById: " + e.Message);
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
| **packageId** | **string** | Package ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**GetPackageTypeByIdResponseBody**](../models/GetPackageTypeByIdResponseBody.md)

<a id="listpackagetypes"></a>
# **ListPackageTypes**
```csharp
ListPackageTypesResponseBody ListPackageTypes (CancellationToken cancellationToken = default)

ListPackageTypesResponseBody ListPackageTypes (HttpClient methodClient, CancellationToken cancellationToken = default)
```

List Custom Package Types

List the custom package types associated with the account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ListPackageTypesExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");

            try
            {
                // List Custom Package Types
                ListPackageTypesResponseBody result = await shipEngine.ListPackageTypes();
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling PackageTypesApi.ListPackageTypes: " + e.Message);
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

[**ListPackageTypesResponseBody**](../models/ListPackageTypesResponseBody.md)

<a id="updatepackagetype"></a>
# **UpdatePackageType**
```csharp
string UpdatePackageType (UpdatePackageTypeRequestBody updatePackageTypeRequestBody, string packageId, CancellationToken cancellationToken = default)

string UpdatePackageType (HttpClient methodClient, UpdatePackageTypeRequestBody updatePackageTypeRequestBody, string packageId, CancellationToken cancellationToken = default)
```

Update Custom Package Type By ID

Update the custom package type object by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class UpdatePackageTypeExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var updatePackageTypeRequestBody = new UpdatePackageTypeRequestBody();
            var packageId = "packageId_example";

            try
            {
                // Update Custom Package Type By ID
                string result = await shipEngine.UpdatePackageType(updatePackageTypeRequestBody, packageId);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling PackageTypesApi.UpdatePackageType: " + e.Message);
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
| **updatePackageTypeRequestBody** | [**UpdatePackageTypeRequestBody**](../../docs//models/UpdatePackageTypeRequestBody.md) |  |  |
| **packageId** | **string** | Package ID |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**string**

