# Downloads Methods

| Method | Description |
|--------|-------------|
| [**DownloadFile**](DownloadsApi.md#downloadfile) | Download File |

<a id="downloadfile"></a>
# **DownloadFile**
```csharp
System.IO.Stream DownloadFile (string subdir, string filename, string dir, int rotation = null, string download = null, CancellationToken cancellationToken = default)

System.IO.Stream DownloadFile (HttpClient methodClient, string subdir, string filename, string dir, int rotation = null, string download = null, CancellationToken cancellationToken = default)
```

Download File

Get File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class DownloadFileExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var subdir = "subdir_example";
            var filename = "filename_example";
            var dir = "dir_example";
            var rotation = 56;
            var download = "download_example";

            try
            {
                // Download File
                System.IO.Stream result = await shipEngine.DownloadFile(subdir, filename, dir, rotation, download);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling DownloadsApi.DownloadFile: " + e.Message);
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
| **subdir** | **string** |  |  |
| **filename** | **string** |  |  |
| **dir** | **string** |  |  |
| **rotation** | **int** |  | [optional]  |
| **download** | **string** |  | [optional]  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

**System.IO.Stream**

