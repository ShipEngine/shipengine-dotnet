# ShipEngineSDK.Api.DownloadsApi

All URIs are relative to *https://api.shipengine.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DownloadFile**](DownloadsApi.md#downloadfile) | **GET** /v1/downloads/{dir}/{subdir}/{filename} | Download File |

<a id="downloadfile"></a>
# **DownloadFile**
> System.IO.Stream DownloadFile (string subdir, string filename, string dir, string download = null, int? rotation = null)

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
            var subdir = "subdir_example";  // string | 
            var filename = "filename_example";  // string | 
            var dir = "dir_example";  // string | 
            var download = "download_example";  // string |  (optional) 
            var rotation = 56;  // int? |  (optional) 

            try
            {
                // Download File
                System.IO.Stream result = await shipEngine.DownloadFile(subdir, filename, dir, download, rotation);
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
| **subdir** | **string** |  |  |
| **filename** | **string** |  |  |
| **dir** | **string** |  |  |
| **download** | **string** |  | [optional]  |
| **rotation** | **int?** |  | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf, image/png, application/zpl, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request was a success |  -  |
| **400** | The request contained errors. |  -  |
| **404** | The specified resource does not exist. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

