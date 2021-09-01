# Track Using Label ID

[ShipEngine](www.shipengine.com) allows you to track a package by its ShipEngine label ID. Please see [our docs](https://www.shipengine.com/docs/tracking/track-by-label-id/) to learn more about tracking shipments.

## Input Parameters

The `TrackUsingLabelId` method requires the ID of the label associated with the shipment you are trying to track.

## Output

The `TrackUsingLabelId` method returns tracking information associated with the shipment for the given label ID.
You can view the properties here [`TrackUsingLabelId.Result`](https://github.com/ShipEngine/shipengine-dotnet/blob/main/ShipEngine/Models/Dto/TrackUsingLabelId/Result.cs).

# Example

```csharp
using ShipEngineSDK;
using System.Threading.Tasks;
using System;
using ShipEngineSDK.TrackUsingLabelId;

public class Example
{
  public async Task<Result> TrackUsingLabelId()
  {
    var shipEngine = new ShipEngine("api_key");

    try
    {
      var response = await shipEngine.TrackUsingLabelId("se-81208131");
      return response;
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
