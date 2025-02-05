# Tokens Methods

| Method | Description |
|--------|-------------|
| [**TokensGetEphemeralToken**](TokensApi.md#tokensgetephemeraltoken) | Get Ephemeral Token |

<a id="tokensgetephemeraltoken"></a>
# **TokensGetEphemeralToken**
```csharp
TokensGetEphemeralTokenResponseBodyYaml TokensGetEphemeralToken (Redirect redirect = null, CancellationToken cancellationToken = default)

TokensGetEphemeralTokenResponseBodyYaml TokensGetEphemeralToken (HttpClient methodClient, Redirect redirect = null, CancellationToken cancellationToken = default)
```

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
            var redirect = (Redirect) "shipengine-dashboard";

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
| **methodClient** | [**HttpClient**](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netstandard-2.0) | The HttpClient instance to use for the request. |  |
| **redirect** | **Redirect** | Include a redirect url to the application formatted with the ephemeral token. | [optional]  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**TokensGetEphemeralTokenResponseBodyYaml**](../models/TokensGetEphemeralTokenResponseBodyYaml.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

