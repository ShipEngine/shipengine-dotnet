# Addresses Methods

| Method | Description |
|--------|-------------|
| [**ParseAddress**](AddressesApi.md#parseaddress) | Parse an address |
| [**ValidateAddress**](AddressesApi.md#validateaddress) | Validate An Address |

<a id="parseaddress"></a>
# **ParseAddress**
```csharp
ParseAddressResponseBody ParseAddress (ParseAddressRequestBody parseAddressRequestBody, CancellationToken cancellationToken = default)

ParseAddressResponseBody ParseAddress (HttpClient methodClient, ParseAddressRequestBody parseAddressRequestBody, CancellationToken cancellationToken = default)
```

Parse an address

The address-recognition API makes it easy for you to extract address data from unstructured text, including the recipient name, line 1, line 2, city, postal code, and more.  Data often enters your system as unstructured text (for example: emails, SMS messages, support tickets, or other documents). ShipEngine's address-recognition API helps you extract meaningful, structured data from this unstructured text. The parsed address data is returned in the same structure that's used for other ShipEngine APIs, such as address validation, rate quotes, and shipping labels.  > **Note:** Address recognition is currently supported for the United States, Canada, Australia, New Zealand, the United Kingdom, and Ireland. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ParseAddressExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var parseAddressRequestBody = new ParseAddressRequestBody();

            try
            {
                // Parse an address
                ParseAddressResponseBody result = await shipEngine.ParseAddress(parseAddressRequestBody);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling AddressesApi.ParseAddress: " + e.Message);
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
| **parseAddressRequestBody** | [**ParseAddressRequestBody**](ParseAddressRequestBody.md) | The only required field is &#x60;text&#x60;, which is the text to be parsed. You can optionally also provide an &#x60;address&#x60; containing already-known values. For example, you may already know the recipient&#39;s name, city, and country, and only want to parse the street address into separate lines.  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**ParseAddressResponseBody**](../models/ParseAddressResponseBody.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="validateaddress"></a>
# **ValidateAddress**
```csharp
List&lt;AddressValidationResult&gt; ValidateAddress (List<AddressToValidate> addressToValidate, CancellationToken cancellationToken = default)

List&lt;AddressValidationResult&gt; ValidateAddress (HttpClient methodClient, List<AddressToValidate> addressToValidate, CancellationToken cancellationToken = default)
```

Validate An Address

Address validation ensures accurate addresses and can lead to reduced shipping costs by preventing address correction surcharges. ShipEngine cross references multiple databases to validate addresses and identify potential deliverability issues. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipEngineSDK;
using ShipEngineSDK.Model;

namespace Example
{
    public class ValidateAddressExample
    {
        public static async Task Main()
        {
            var shipEngine = new ShipEngine("api_key");
            var addressToValidate = new List<AddressToValidate>();

            try
            {
                // Validate An Address
                List<AddressValidationResult> result = await shipEngine.ValidateAddress(addressToValidate);
                Debug.WriteLine(result);
            }
            catch (ShipEngineException e)
            {
                Debug.Print("Exception when calling AddressesApi.ValidateAddress: " + e.Message);
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
| **addressToValidate** | [**List&lt;AddressToValidate&gt;**](AddressToValidate.md) |  |  |
| **cancellationToken** | [**CancellationToken**](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=netstandard-2.0) | The cancellation token to use for the request. |  |

### Return type

[**List&lt;AddressValidationResult&gt;**](../models/AddressValidationResult.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

