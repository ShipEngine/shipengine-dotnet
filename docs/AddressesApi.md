# ShipEngineSDK.Api.AddressesApi

All URIs are relative to *https://api.shipengine.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ParseAddress**](AddressesApi.md#parseaddress) | **PUT** /v1/addresses/recognize | Parse an address |
| [**ValidateAddress**](AddressesApi.md#validateaddress) | **POST** /v1/addresses/validate | Validate An Address |

<a id="parseaddress"></a>
# **ParseAddress**
> ParseAddressResponseBody ParseAddress (ParseAddressRequestBody parseAddressRequestBody)

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
            var parseAddressRequestBody = new ParseAddressRequestBody(); // ParseAddressRequestBody | The only required field is `text`, which is the text to be parsed. You can optionally also provide an `address` containing already-known values. For example, you may already know the recipient's name, city, and country, and only want to parse the street address into separate lines. 

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
| **parseAddressRequestBody** | [**ParseAddressRequestBody**](ParseAddressRequestBody.md) | The only required field is &#x60;text&#x60;, which is the text to be parsed. You can optionally also provide an &#x60;address&#x60; containing already-known values. For example, you may already know the recipient&#39;s name, city, and country, and only want to parse the street address into separate lines.  |  |

### Return type

[**ParseAddressResponseBody**](ParseAddressResponseBody.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the parsed address, as well as a confidence score and a list of all the entities that were recognized in the text.  |  -  |
| **400** | The request contained errors. |  -  |
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="validateaddress"></a>
# **ValidateAddress**
> List&lt;AddressValidationResult&gt; ValidateAddress (List<AddressToValidate> addressToValidate)

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
            var addressToValidate = new List<AddressToValidate>(); // List<AddressToValidate> | 

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
| **addressToValidate** | [**List&lt;AddressToValidate&gt;**](AddressToValidate.md) |  |  |

### Return type

[**List&lt;AddressValidationResult&gt;**](AddressValidationResult.md)

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
| **500** | An error occurred on ShipEngine&#39;s side.  &gt; This error will automatically be reported to our engineers.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

