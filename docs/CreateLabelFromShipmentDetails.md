# Create Label From Shipment Details

[ShipEngine](www.shipengine.com) allows you programmatically create shipping labels. Please see [our docs](https://www.shipengine.com/docs/labels/create-a-label/) to learn more about creating shipping labels.

## Input Parameters

The `CreateLabelFromShipmentDetails` method accepts shipment related params. You can view the properties here[`CreateLabelFromShipmentDetails.Param`](https://github.com/ShipEngine/shipengine-dotnet/blob/main/ShipEngine/Models/Dto/CreateLabelFromShipmentDetails/Params.cs).

## Output

The `CreateLabelFromShipmentDetails` method returns the label that was created.
You can view the properties here [`CreateLabelFromShipmentDetails.Result`](https://github.com/ShipEngine/shipengine-dotnet/blob/main/ShipEngine/Models/Dto/CreateLabelFromShipmentDetails/Result.cs)

# Example

```csharp
using ShipEngineSDK;
using System.Threading.Tasks;
using System;
using ShipEngineSDK.CreateLabelFromShipmentDetails;
using System.Collections.Generic;
using ShipEngineSDK.Common.Enums;
using ShipEngineSDK.Common;

public class Example
{
  public async Task<Result> CreateLabelFromShipmentDetails()
  {
    var shipEngine = new ShipEngine("api_key");

    var rateParams = new Params()
    {
      Shipment = new Shipment()
      {
        ServiceCode = "usps_priority_mail",
        ShipFrom = new Address()
        {
          Name = "John Doe",
          AddressLine1 = "4009 Marathon Blvd",
          CityLocality = "Austin",
          StateProvince = "TX",
          PostalCode = "78756",
          CountryCode = Country.US,
          Phone = "512-555-5555"
        },
        ShipTo = new Address()
        {
          Name = "Amanda Miller",
          AddressLine1 = "525 S Winchester Blvd",
          CityLocality = "San Jose",
          StateProvince = "CA",
          PostalCode = "95128",
          CountryCode = Country.US,
          Phone = "512-555-5555"
        },
        Packages = new List<Package>()
          {
            new Package() {
              Weight = new Weight() {
                  Value = 17,
                  Unit = WeightUnit.Pound
              },
              Dimensions = new Dimensions() {
                  Length = 36,
                  Width = 12,
                  Height = 24,
                  Unit = DimensionUnit.Inch,
              }
            }
          }
      },
    };

    try
    {
      var result = await shipEngine.CreateLabelFromShipmentDetails(rateParams);
      return result;
    }
    catch (ShipEngineException e)
    {
      Console.WriteLine("Error creating label");
      throw e;
    }
  }
}
```

## Example Output

### Successful Create Label Result

```csharp
{Result}
  LabelId: "se-81223599"
  Status: LabelStatus.Completed
  ShipmentId: "se-155796411"
  ShipDate: "2021-09-01T00:00:00Z"
  CreatedAt: "2021-09-01T15:32:21.799893Z"
  ShipmentCost: {MonetaryValue}
    Currency: Currency.USD
    Amount: 115.51
  InsuranceCost: {MonetaryValue}
    Currency: Currency.USD
    Amount: 0
  TrackingNumber: "9405511899560775487501"
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
    Href: "https://api.shipengine.com/v1/downloads/10/8nyGj_0WHkCLwaK9TSYang/label-81223599.pdf"
    Pdf: "https://api.shipengine.com/v1/downloads/10/8nyGj_0WHkCLwaK9TSYang/label-81223599.pdf"
    Png: "https://api.shipengine.com/v1/downloads/10/8nyGj_0WHkCLwaK9TSYang/label-81223599.png"
    Zpl: "https://api.shipengine.com/v1/downloads/10/8nyGj_0WHkCLwaK9TSYang/label-81223599.zpl"
  TrackingStatus: TrackingStatus.InTransit
  FormDownload: null
  InsuranceClaim: null
  Packages: ...
    {LabelPackage}
      PackageId: 86169368
      PackageCode: "package"
      Weight: {Weight}
        Value: 17
        Unit: WeightUnit.Pound
      Dimensions: {Dimensions}
        Unit: DimensionUnit.Inch
        Length: 36
        Width: 12
        Height: 24
      InsuredValue: {MonetaryValue}
        Currency: Currency.USD
        Amount: 0
      TrackingNumber: "9405511899560775487501"
      LabelMessages: {LabelMessages}
        Reference1: null
        Reference2: null
        Reference3: null
      ExternalPackageId: null
      Sequence: 1
```
