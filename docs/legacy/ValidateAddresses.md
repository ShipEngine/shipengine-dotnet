# Validate Addresses

[ShipEngine](www.shipengine.com) allows you to validate an array of addresses before using it to create a shipment to ensure
accurate delivery of your packages. Please see [our docs](https://www.shipengine.com/docs/addresses/validation/) to learn more about validating addresses.

## Input Parameters

The `ValidateAddresses` method accepts an array of addresses. You can view the properties here (https://github.com/ShipEngine/shipengine-dotnet/blob/main/ShipEngine/Models/Dto/Common/Address.cs).

## Output

The `ValidateAddresses` method returns an array of address validation result objects.
You can view the properties here [`ValidateAddresses.Result`](https://github.com/ShipEngine/shipengine-dotnet/blob/main/ShipEngine/Models/Dto/ValidateAddresses/Result.cs).

# Example

```csharp
using ShipEngineSDK;
using ShipEngineSDK.ValidateAddresses;
using ShipEngineSDK.Common;
using System.Threading.Tasks;
using System.Collections.Generic;
using ShipEngineSDK.Common.Enums;
using System;

public class Example
{
  public async Task<List<Result>> ValidateAddresses()
  {
    var shipEngine = new ShipEngine("api_key");

    var validateAddressParams = new List<Address>() {
      new Address()
        {
          Name = "Mickey and Minnie Mouse",
          Phone = "714-781-4565",
          CompanyName = "The Walt Disney Company",
          AddressLine1 = "500 South Buena Vista Street",
          CityLocality = "Burbank",
          StateProvince = "CA",
          PostalCode = "91521",
          CountryCode = Country.US
        }
    };

    try
    {
      var result = await shipEngine.ValidateAddresses(validateAddressParams);
      return result;
    }
    catch (ShipEngineException e)
    {
      Console.WriteLine("Error validating address");
      throw e;
    }
  }
}


```

## Example Output

### Successful Address Validation

```csharp
{Result}
  Status: AddressValidationResult.Verified
  OriginalAddress: {Address}
    Name: "Mickey and Minnie Mouse"
    Phone: "714-781-4565"
    CompanyName: "The Walt Disney Company"
    AddressLine1: "500 South Buena Vista Street"
    AddressLine2: null
    AddressLine3: null
    CityLocality: "Burbank"
    StateProvince: "CA"
    PostalCode: "91521"
    CountryCode: Country.US
    AddressResidentialIndicator: AddressResidentialIndicator.Unknown
  NormalizedAddress: {Address}
    Name: "MICKEY AND MINNIE MOUSE"
    Phone: "714-781-4565"
    CompanyName: "THE WALT DISNEY COMPANY"
    AddressLine1: "500 S BUENA VISTA ST"
    AddressLine2: ""
    AddressLine3: null
    CityLocality: "BURBANK"
    StateProvince: "CA"
    PostalCode: "91521-0007"
    CountryCode: Country.US
    AddressResidentialIndicator: AddressResidentialIndicator.No
  Messages: ...
```
