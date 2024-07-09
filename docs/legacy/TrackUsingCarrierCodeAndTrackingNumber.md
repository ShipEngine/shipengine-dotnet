# Track Using Carrier Code and Tracking Number

[ShipEngine](www.shipengine.com) allows you to track a package for a given carrier and tracking number. Please see [our docs](https://www.shipengine.com/docs/tracking/) to learn more about tracking shipments.

## Input Parameters

The `TrackUsingCarrierCodeAndTrackingNumber` method requires the carrier code and tracking number of the shipment being tracked.

## Output

The `TrackUsingCarrierCodeAndTrackingNumber` method returns tracking information associated with the shipment for the carrier code and tracking number.
You can view the properties here [`TrackUsingCarrierCodeAndTrackingNumberTypes.Result`](https://github.com/ShipEngine/shipengine-dotnet/blob/main/ShipEngine/Models/Dto/TrackUsingCarrierCodeAndTrackingNumber/Result.cs).

# Example

```csharp
using ShipEngineSDK;
using System.Threading.Tasks;
using System;
using ShipEngineSDK.TrackUsingCarrierCodeAndTrackingNumber;

public class Example
{
  public async Task<Result> TrackUsingCarrierCodeAndTrackingNumber()
  {
    var shipEngine = new ShipEngine("api_key");

    try
    {
      var result = await shipEngine.TrackUsingCarrierCodeAndTrackingNumber("9405511899560775488591", "stamps_com");
      return result;
    }
    catch (ShipEngineException e)
    {
      Console.WriteLine("Error getting tracking response");
      throw e;
    }
  }
}
```

## Example Output

### Tracking Result

```csharp
{Result}
  TrackingNumber: "9405511899560775488591"
  StatusCode: TrackingStatusCode.NY
  StatusDescription: TrackingStatusDescription.NotYetInSystem
  CarrierDetailCode: null
  CarrierStatusCode: "-2147219283"
  CarrierStatusDescription: "A status update is not yet available for this tracking number.  More information will become available when USPS receives the tracking information, or when the package is received by USPS."
  ShipDate: null
  EstimatedDeliveryDate: null
  ActualDeliveryDate: null
  ExceptionDescription: null
  Events: ...
```
