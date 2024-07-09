# ShipEngineSDK.Api.TokensApi

All URIs are relative to *https://api.shipengine.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TokensGetEphemeralToken**](TokensApi.md#tokensgetephemeraltoken) | **POST** /v1/tokens/ephemeral | Get Ephemeral Token |

<a id="tokensgetephemeraltoken"></a>
# **TokensGetEphemeralToken**
> TokensGetEphemeralTokenResponseBodyYaml TokensGetEphemeralToken (Redirect? redirect = null)

Get Ephemeral Token

This endpoint returns a token that can be passed to an application for authorized access.  The lifetime of this token is 10 seconds.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class TokensGetEphemeralTokenExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var redirect = (Redirect) "shipengine-dashboard";  // Redirect? | Include a redirect url to the application formatted with the ephemeral token. (optional) 

            try
            {
                // Get Ephemeral Token
                TokensGetEphemeralTokenResponseBodyYaml result = await shipEngine.TokensGetEphemeralToken(redirect);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling TokensApi.TokensGetEphemeralToken: " + e.Message);
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
| **redirect** | **Redirect?** | Include a redirect url to the application formatted with the ephemeral token. | [optional]  |

### Return type

[**TokensGetEphemeralTokenResponseBodyYaml**](TokensGetEphemeralTokenResponseBodyYaml.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

