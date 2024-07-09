# Get Rates With Shipment Details

Given some shipment details and rate options, this method returns a list of rate quotes. Please see [our docs](https://www.shipengine.com/docs/rates/) to learn more about calculating rates.

## Input Parameters

The `GetRatesWithShipmentDetails` method accepts shipment related params. You can view the properties here [`GetRatesWithShipmentDetails.Param`](https://github.com/ShipEngine/shipengine-dotnet/blob/main/ShipEngine/Models/Dto/CreateLabelFromShipmentDetails/Params.cs).

## Output

The `GetRatesWithShipmentDetails` method returns the rates that were calculated for the given shipment params.
You can view the properties here[`GetRatesWithShipmentDetails.Result`](https://github.com/ShipEngine/shipengine-dotnet/blob/main/ShipEngine/Models/Dto/CreateLabelFromShipmentDetails/Result.cs).

# Example

```csharp
using ShipEngineSDK;
using System.Threading.Tasks;
using System;
using ShipEngineSDK.GetRatesWithShipmentDetails;
using System.Collections.Generic;
using ShipEngineSDK.Common.Enums;
using ShipEngineSDK.Common;

public class Example
{
  public async Task<Result> GetRatesWithShipmentDetails()
  {
    var shipEngine = new ShipEngine("api_key");

    var ratesParams = new Params()
    {
      Shipment = new Shipment()
      {
        ValidateAddress = ValidateAddress.NoValidation,

        ShipFrom = new Address()
        {
          Name = "John Doe",
          Phone = "512-555-5555",
          CompanyName = "The Walt Disney Company",
          AddressLine1 = "4009 Marathon Blvd",
          CityLocality = "Austin",
          StateProvince = "TX",
          PostalCode = "78756",
          CountryCode = Country.US
        },

        ShipTo = new Address()
        {
          Name = "Mickey and Minnie Mouse",
          Phone = "714-781-4565",
          CompanyName = "The Walt Disney Company",
          AddressLine1 = "500 South Buena Vista Street",
          CityLocality = "Burbank",
          StateProvince = "CA",
          PostalCode = "91521",
          CountryCode = Country.US,
          AddressResidentialIndicator = AddressResidentialIndicator.Unknown
        },
        Packages = new List<ShipmentPackage>()
          {
            new ShipmentPackage() {

                Weight = new Weight()
                {
                    Value = 17,
                    Unit = WeightUnit.Pound
                },
                Dimensions = new Dimensions() {
                    Length = 10,
                    Width = 10,
                    Height = 10,
                    Unit = DimensionUnit.Inch
                }
            }
          }
      },
      RateOptions = new RateOptions()
      {
        CarrierIds = new List<string>() { "se-423887" },
        ServiceCodes = new List<string>() { "usps_priority_mail" },
      }
    };

    try
    {
      var result = await shipEngine.GetRatesWithShipmentDetails(ratesParams);
      return result;
    }
    catch (ShipEngineException e)
    {
      Console.WriteLine("Error getting rates");
      throw e;
    }
  }
}


```

## Example Output

### Successful Get Rates Result

```csharp
{Result}
  ShipmentId: "se-155796389"
  CarrierId: "se-423887"
  ServiceCode: "usps_priority_mail"
  ExternalOrderId: null
  Items: ...
  TaxIdentifiers: null
  ExternalShipmentId: null
  ShipDate: "2021-09-01T00:00:00Z"
  CreatedAt: "2021-09-01T15:32:19.493Z"
  ModifiedAt: "2021-09-01T15:32:19.48Z"
  ShipmentStatus: ShipmentStatus.Pending
  ShipTo: {Address}
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
  ShipFrom: {Address}
    Name: "John Doe"
    Phone: "512-555-5555"
    CompanyName: "The Walt Disney Company"
    AddressLine1: "4009 Marathon Blvd"
    AddressLine2: null
    AddressLine3: null
    CityLocality: "Austin"
    StateProvince: "TX"
    PostalCode: "78756"
    CountryCode: Country.US
    AddressResidentialIndicator: AddressResidentialIndicator.Unknown
  WarehouseId: null
  ReturnTo: {Address}
    Name: "John Doe"
    Phone: "512-555-5555"
    CompanyName: "The Walt Disney Company"
    AddressLine1: "4009 Marathon Blvd"
    AddressLine2: null
    AddressLine3: null
    CityLocality: "Austin"
    StateProvince: "TX"
    PostalCode: "78756"
    CountryCode: Country.US
    AddressResidentialIndicator: AddressResidentialIndicator.Unknown
  Confirmation: DeliveryConfirmation.None
  Customs: {Customs}
    Contents: PackageContents.Merchandise
    NonDelivery: NonDelivery.ReturnToSender
    CustomsItems: ...
  AdvancedOptions: {AdvancedShipmentOptions}
    BillToAccount: null
    BillToCountryCode: null
    BillToParty: null
    BillToPostalCode: null
    ContainsAlcohol: false
    DeliveredDutyPaid: false
    DryIce: false
    DryIceWeight: null
    FedexFreight: null
    NonMachinable: false
    SaturdayDelivery: false
    UseUpsGroundFreightPricing: null
    FreightClass: null
    CustomField1: null
    CustomField2: null
    CustomField3: null
    OriginType: null
    ShipperRelease: null
    CollectOnDelivery: null
  OriginType: OriginType.Pickup
  InsuranceProvider: InsuranceProvider.None
  Tags: ...
  TotalWeight: {Weight}
    Value: 17
    Unit: WeightUnit.Pound
  OrderSourceCode: null
  Packages: ...
    {ShipmentPackage}
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
      LabelMessages: {LabelMessages}
        Reference1: null
        Reference2: null
        Reference3: null
      ExternalPackageId: null
  Weight: null
  RateResponse: {RateResponse}
    Rates: ...
      {Rate}
        RateId: "se-853053244"
        RateType: RateType.Shipment
        CarrierId: "se-423887"
        ShippingAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 46.18
        InsuranceAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        ConfirmationAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        OtherAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        TaxAmount: null
        Zone: 6
        PackageType: "package"
        DeliveryDays: 3
        GuaranteedService: false
        EstimatedDeliveryDate: "2021-09-04T00:00:00Z"
        CarrierDeliveryDays: "3"
        ShipDate: "2021-09-01T00:00:00Z"
        NegotiatedRate: false
        ServiceType: "USPS Priority Mail"
        ServiceCode: "usps_priority_mail"
        Trackable: true
        CarrierCode: "stamps_com"
        CarrierNickname: "ShipEngine Test Account - Stamps.com"
        CarrierFriendlyName: "Stamps.com"
        ValidationStatus: ValidationStatus.Valid
        WarningMessages: ...
        ErrorMessages: ...
      {Rate}
        RateId: "se-853053245"
        RateType: RateType.Shipment
        CarrierId: "se-423887"
        ShippingAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 13.75
        InsuranceAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        ConfirmationAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        OtherAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        TaxAmount: null
        Zone: 6
        PackageType: "medium_flat_rate_box"
        DeliveryDays: 3
        GuaranteedService: false
        EstimatedDeliveryDate: "2021-09-04T00:00:00Z"
        CarrierDeliveryDays: "3"
        ShipDate: "2021-09-01T00:00:00Z"
        NegotiatedRate: false
        ServiceType: "USPS Priority Mail"
        ServiceCode: "usps_priority_mail"
        Trackable: true
        CarrierCode: "stamps_com"
        CarrierNickname: "ShipEngine Test Account - Stamps.com"
        CarrierFriendlyName: "Stamps.com"
        ValidationStatus: ValidationStatus.Valid
        WarningMessages: ...
        ErrorMessages: ...
      {Rate}
        RateId: "se-853053247"
        RateType: RateType.Shipment
        CarrierId: "se-423887"
        ShippingAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 7.9
        InsuranceAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        ConfirmationAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        OtherAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        TaxAmount: null
        Zone: 6
        PackageType: "small_flat_rate_box"
        DeliveryDays: 3
        GuaranteedService: false
        EstimatedDeliveryDate: "2021-09-04T00:00:00Z"
        CarrierDeliveryDays: "3"
        ShipDate: "2021-09-01T00:00:00Z"
        NegotiatedRate: false
        ServiceType: "USPS Priority Mail"
        ServiceCode: "usps_priority_mail"
        Trackable: true
        CarrierCode: "stamps_com"
        CarrierNickname: "ShipEngine Test Account - Stamps.com"
        CarrierFriendlyName: "Stamps.com"
        ValidationStatus: ValidationStatus.Valid
        WarningMessages: ...
        ErrorMessages: ...
      {Rate}
        RateId: "se-853053249"
        RateType: RateType.Shipment
        CarrierId: "se-423887"
        ShippingAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 19.3
        InsuranceAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        ConfirmationAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        OtherAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        TaxAmount: null
        Zone: 6
        PackageType: "large_flat_rate_box"
        DeliveryDays: 3
        GuaranteedService: false
        EstimatedDeliveryDate: "2021-09-04T00:00:00Z"
        CarrierDeliveryDays: "3"
        ShipDate: "2021-09-01T00:00:00Z"
        NegotiatedRate: false
        ServiceType: "USPS Priority Mail"
        ServiceCode: "usps_priority_mail"
        Trackable: true
        CarrierCode: "stamps_com"
        CarrierNickname: "ShipEngine Test Account - Stamps.com"
        CarrierFriendlyName: "Stamps.com"
        ValidationStatus: ValidationStatus.Valid
        WarningMessages: ...
        ErrorMessages: ...
      {Rate}
        RateId: "se-853053251"
        RateType: RateType.Shipment
        CarrierId: "se-423887"
        ShippingAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 7.4
        InsuranceAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        ConfirmationAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        OtherAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        TaxAmount: null
        Zone: 6
        PackageType: "flat_rate_envelope"
        DeliveryDays: 3
        GuaranteedService: false
        EstimatedDeliveryDate: "2021-09-04T00:00:00Z"
        CarrierDeliveryDays: "3"
        ShipDate: "2021-09-01T00:00:00Z"
        NegotiatedRate: false
        ServiceType: "USPS Priority Mail"
        ServiceCode: "usps_priority_mail"
        Trackable: true
        CarrierCode: "stamps_com"
        CarrierNickname: "ShipEngine Test Account - Stamps.com"
        CarrierFriendlyName: "Stamps.com"
        ValidationStatus: ValidationStatus.HasWarnings
        WarningMessages: ...
          "Heads up! You\'ve included custom dimensions for a package type with a standardized size. For more accurate rates, consider removing the dimensions for this shipment."
        ErrorMessages: ...
      {Rate}
        RateId: "se-853053252"
        RateType: RateType.Shipment
        CarrierId: "se-423887"
        ShippingAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 8
        InsuranceAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        ConfirmationAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        OtherAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        TaxAmount: null
        Zone: 6
        PackageType: "flat_rate_padded_envelope"
        DeliveryDays: 3
        GuaranteedService: false
        EstimatedDeliveryDate: "2021-09-04T00:00:00Z"
        CarrierDeliveryDays: "3"
        ShipDate: "2021-09-01T00:00:00Z"
        NegotiatedRate: false
        ServiceType: "USPS Priority Mail"
        ServiceCode: "usps_priority_mail"
        Trackable: true
        CarrierCode: "stamps_com"
        CarrierNickname: "ShipEngine Test Account - Stamps.com"
        CarrierFriendlyName: "Stamps.com"
        ValidationStatus: ValidationStatus.Valid
        WarningMessages: ...
        ErrorMessages: ...
      {Rate}
        RateId: "se-853053254"
        RateType: RateType.Shipment
        CarrierId: "se-423887"
        ShippingAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 17.5
        InsuranceAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        ConfirmationAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        OtherAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        TaxAmount: null
        Zone: 6
        PackageType: "regional_rate_box_b"
        DeliveryDays: 3
        GuaranteedService: false
        EstimatedDeliveryDate: "2021-09-04T00:00:00Z"
        CarrierDeliveryDays: "3"
        ShipDate: "2021-09-01T00:00:00Z"
        NegotiatedRate: false
        ServiceType: "USPS Priority Mail"
        ServiceCode: "usps_priority_mail"
        Trackable: true
        CarrierCode: "stamps_com"
        CarrierNickname: "ShipEngine Test Account - Stamps.com"
        CarrierFriendlyName: "Stamps.com"
        ValidationStatus: ValidationStatus.Valid
        WarningMessages: ...
        ErrorMessages: ...
      {Rate}
        RateId: "se-853053256"
        RateType: RateType.Shipment
        CarrierId: "se-423887"
        ShippingAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 7.7
        InsuranceAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        ConfirmationAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        OtherAmount: {MonetaryValue}
          Currency: Currency.USD
          Amount: 0
        TaxAmount: null
        Zone: 6
        PackageType: "flat_rate_legal_envelope"
        DeliveryDays: 3
        GuaranteedService: false
        EstimatedDeliveryDate: "2021-09-04T00:00:00Z"
        CarrierDeliveryDays: "3"
        ShipDate: "2021-09-01T00:00:00Z"
        NegotiatedRate: false
        ServiceType: "USPS Priority Mail"
        ServiceCode: "usps_priority_mail"
        Trackable: true
        CarrierCode: "stamps_com"
        CarrierNickname: "ShipEngine Test Account - Stamps.com"
        CarrierFriendlyName: "Stamps.com"
        ValidationStatus: ValidationStatus.Valid
        WarningMessages: ...
        ErrorMessages: ...
    InvalidRates: ...
    RateRequestId: "se-94560853"
    ShipmentId: "se-155796389"
    CreatedAt: "2021-09-01T15:32:20.0098692Z"
    Status: RateStatus.Completed
    Errors: ...
```
