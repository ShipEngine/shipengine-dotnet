# Create Label From Rate

When retrieving rates for shipments using the `GetRatesWithShipmentDetails` method, the returned information contains a `RateId` property that can be used to purchase a label without having to refill in the shipment information repeatedly. Please see [our docs](https://www.shipengine.com/docs/labels/create-from-rate/) to learn more about creating shipping labels from rates.

## Input Parameters

The `CreateLabelFromRate` method requires a `RateId`.

## Output

The `CreateLabelFromRate` method returns the label that was created. You can view the properties here [`CreateLabelFromRate.Result`](https://github.com/ShipEngine/shipengine-dotnet/blob/main/ShipEngine/Models/Dto/CreateLabelFromRate/Result.cs).

# Example

```csharp
using ShipEngineSDK;
using ShipEngineSDK.CreateLabelFromRate;
using ShipEngineSDK.Common;
using ShipEngineSDK.Common.Enums;


public async Task<Result> CreateLabelFromRate {
    var shipEngine = new ShipEngine("api_key");

    Params = new Params()
        {
            RateId = "se-853449547",
            ValidateAddress = ValidateAddress.NoValidation,
            LabelLayout = LabelLayout.Letter,
            LabelFormat = LabelFormat.PDF,
            LabelDownloadType = LabelDownloadType.Url
        };


    try {
        var result = await shipEngine.CreateLabelFromRate(Params);
    }
    catch (ShipEngineException e) {
        Console.WriteLine("Error creating label");
        throw e;
    }
}
```

## Example Output

### Successful Create Label From Rate Result

```csharp
{Result}
  LabelId: "se-81223591"
  Status: LabelStatus.Completed
  ShipmentId: "se-155796389"
  ShipDate: "2021-09-01T00:00:00Z"
  CreatedAt: "2021-09-01T15:32:20.3296009Z"
  ShipmentCost: {MonetaryValue}
    Currency: Currency.USD
    Amount: 46.18
  InsuranceCost: {MonetaryValue}
    Currency: Currency.USD
    Amount: 0
  TrackingNumber: "9405511899560775487525"
  IsReturnLabel: false
  RmaNumber: null
  IsInternational: false
  BatchId: ""
  CarrierId: "se-423887"
  ChargeEvent: ChargeEvent.CarrierDefault
  ServiceCode: "usps_priority_mail"
  PackageCode: "package"
  Voided: false
  VoidedAt: null
  LabelFormat: LabelFormat.PDF
  DisplayScheme: DisplayScheme.Label
  LabelLayout: LabelLayout.FourBySix
  Trackable: true
  LabelImageId: null
  CarrierCode: "stamps_com"
  LabelDownload: {LabelDownload}
    Href: "https://api.shipengine.com/v1/downloads/10/7XjDQ3cMz02BCmMMJfqKAQ/label-81223591.pdf"
    Pdf: "https://api.shipengine.com/v1/downloads/10/7XjDQ3cMz02BCmMMJfqKAQ/label-81223591.pdf"
    Png: "https://api.shipengine.com/v1/downloads/10/7XjDQ3cMz02BCmMMJfqKAQ/label-81223591.png"
    Zpl: "https://api.shipengine.com/v1/downloads/10/7XjDQ3cMz02BCmMMJfqKAQ/label-81223591.zpl"
  TrackingStatus: TrackingStatus.InTransit
  FormDownload: null
  InsuranceClaim: null
  Packages: ...
    {Package}
      PackageId: 86169359
      PackageCode: "package"
      Weight: {Weight}
        Value: 17
        Unit: WeightUnit.Pound
      Dimensions: {Dimensions}
        Unit: DimensionUnit.Inch
        Length: 10
        Width: 10
        Height: 10
      InsuredValue: {MonetaryValue}
        Currency: Currency.USD
        Amount: 0
      TrackingNumber: "9405511899560775487525"
      LabelMessages: {LabelMessages}
        Reference1: null
        Reference2: null
        Reference3: null
      ExternalPackageId: null
      Sequence: 1
```
