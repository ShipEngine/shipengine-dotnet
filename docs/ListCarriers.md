# List Carrier Accounts

[ShipEngine](www.shipengine.com) allows you to connect
your own carrier accounts through the ShipEngine [dashboard](https://www.shipengine.com/docs/carriers/setup/). You can list all the carrier accounts you have connected with the `listCarriers` method. To learn more about carrier accounts please see [our docs](https://www.shipengine.com/docs/reference/list-carriers/).

## Output

The `ListCarriers` method returns an array of connected carriers.
You can view the properties here [`ListCarriers.Result`](https://github.com/ShipEngine/shipengine-dotnet/blob/main/ShipEngine/Models/Dto/ListCarriers/Result.cs).

## Example

```csharp
using ShipEngineSDK;
using System.Threading.Tasks;
using System;
using ShipEngineSDK.ListCarriers;

public class Example
{
  public async Task<Result> ListCarriers()
  {
    var shipEngine = new ShipEngine("api_key");

    try
    {
      var result = await shipEngine.ListCarriers();
      return result;
    }
    catch (ShipEngineException e)
    {
      Console.WriteLine("Error getting carrier accounts");
      throw e;
    }
  }
}
```

# Example Output

## Successful List Carriers Result

```csharp
{Result}
  Carriers: ...
    {Carrier}
      CarrierId: "se-423887"
      CarrierCode: "stamps_com"
      AccountNumber: "test_account_423887"
      RequiresFundedAmount: true
      Balance: 5461.45
      Nickname: "ShipEngine Test Account - Stamps.com"
      FriendlyName: "Stamps.com"
      Primary: false
      HasMultiPackageSupportingServices: false
      SupportsLabelMessages: true
      Services: ...
        {Service}
          CarrierId: "se-423887"
          CarrierCode: "stamps_com"
          ServiceCode: "usps_first_class_mail"
          Name: "USPS First Class Mail"
          Domestic: true
          International: false
          IsMultiPackageSupported: false
        {Service}
          CarrierId: "se-423887"
          CarrierCode: "stamps_com"
          ServiceCode: "usps_media_mail"
          Name: "USPS Media Mail"
          Domestic: true
          International: false
          IsMultiPackageSupported: false
        {Service}
          CarrierId: "se-423887"
          CarrierCode: "stamps_com"
          ServiceCode: "usps_parcel_select"
          Name: "USPS Parcel Select Ground"
          Domestic: true
          International: false
          IsMultiPackageSupported: false
        {Service}
          CarrierId: "se-423887"
          CarrierCode: "stamps_com"
          ServiceCode: "usps_priority_mail"
          Name: "USPS Priority Mail"
          Domestic: true
          International: false
          IsMultiPackageSupported: false
        {Service}
          CarrierId: "se-423887"
          CarrierCode: "stamps_com"
          ServiceCode: "usps_priority_mail_express"
          Name: "USPS Priority Mail Express"
          Domestic: true
          International: false
          IsMultiPackageSupported: false
        {Service}
          CarrierId: "se-423887"
          CarrierCode: "stamps_com"
          ServiceCode: "usps_first_class_mail_international"
          Name: "USPS First Class Mail Intl"
          Domestic: false
          International: true
          IsMultiPackageSupported: false
        {Service}
          CarrierId: "se-423887"
          CarrierCode: "stamps_com"
          ServiceCode: "usps_priority_mail_international"
          Name: "USPS Priority Mail Intl"
          Domestic: false
          International: true
          IsMultiPackageSupported: false
        {Service}
          CarrierId: "se-423887"
          CarrierCode: "stamps_com"
          ServiceCode: "usps_priority_mail_express_international"
          Name: "USPS Priority Mail Express Intl"
          Domestic: false
          International: true
          IsMultiPackageSupported: false
      Packages: ...
        {PackageType}
          PackageId: null
          PackageCode: "cubic"
          Name: "Cubic"
          Dimensions: null
          Description: "Cubic"
        {PackageType}
          PackageId: null
          PackageCode: "flat_rate_envelope"
          Name: "Flat Rate Envelope"
          Dimensions: null
          Description: "USPS flat rate envelope. A special cardboard envelope provided by the USPS that clearly indicates \"Flat Rate\"."
        {PackageType}
          PackageId: null
          PackageCode: "flat_rate_legal_envelope"
          Name: "Flat Rate Legal Envelope"
          Dimensions: null
          Description: "Flat Rate Legal Envelope"
        {PackageType}
          PackageId: null
          PackageCode: "flat_rate_padded_envelope"
          Name: "Flat Rate Padded Envelope"
          Dimensions: null
          Description: "Flat Rate Padded Envelope"
        {PackageType}
          PackageId: null
          PackageCode: "large_envelope_or_flat"
          Name: "Large Envelope or Flat"
          Dimensions: null
          Description: "Large envelope or flat. Has one dimension that is between 11 1/2\" and 15\" long, 6 1/18\" and 12\" high, or 1/4\" and 3/4\" thick."
        {PackageType}
          PackageId: null
          PackageCode: "large_flat_rate_box"
          Name: "Large Flat Rate Box"
          Dimensions: null
          Description: "Large Flat Rate Box"
        {PackageType}
          PackageId: null
          PackageCode: "large_package"
          Name: "Large Package (any side > 12\")"
          Dimensions: null
          Description: "Large package. Longest side plus the distance around the thickest part is over 84\" and less than or equal to 108\"."
        {PackageType}
          PackageId: null
          PackageCode: "letter"
          Name: "Letter"
          Dimensions: null
          Description: "Letter"
        {PackageType}
          PackageId: null
          PackageCode: "medium_flat_rate_box"
          Name: "Medium Flat Rate Box"
          Dimensions: null
          Description: "USPS flat rate box. A special 11\" x 8 1/2\" x 5 1/2\" or 14\" x 3.5\" x 12\" USPS box that clearly indicates \"Flat Rate Box\""
        {PackageType}
          PackageId: null
          PackageCode: "non_rectangular"
          Name: "Non Rectangular Package"
          Dimensions: null
          Description: "Non-Rectangular package type that is cylindrical in shape."
        {PackageType}
          PackageId: null
          PackageCode: "package"
          Name: "Package"
          Dimensions: null
          Description: "Package. Longest side plus the distance around the thickest part is less than or equal to 84\""
        {PackageType}
          PackageId: null
          PackageCode: "regional_rate_box_a"
          Name: "Regional Rate Box A"
          Dimensions: null
          Description: "Regional Rate Box A"
        {PackageType}
          PackageId: null
          PackageCode: "regional_rate_box_b"
          Name: "Regional Rate Box B"
          Dimensions: null
          Description: "Regional Rate Box B"
        {PackageType}
          PackageId: null
          PackageCode: "small_flat_rate_box"
          Name: "Small Flat Rate Box"
          Dimensions: null
          Description: "Small Flat Rate Box"
        {PackageType}
          PackageId: null
          PackageCode: "thick_envelope"
          Name: "Thick Envelope"
          Dimensions: null
          Description: "Thick envelope. Envelopes or flats greater than 3/4\" at the thickest point."
      Options: ...
        {AdvancedOption}
          Name: "non_machinable"
          DefaultValue: "false"
          Description: ""
        {AdvancedOption}
          Name: "bill_to_account"
          DefaultValue: null
          Description: "Bill To Account"
        {AdvancedOption}
          Name: "bill_to_party"
          DefaultValue: null
          Description: "Bill To Party"
        {AdvancedOption}
          Name: "bill_to_postal_code"
          DefaultValue: null
          Description: "Bill To Postal Code"
        {AdvancedOption}
          Name: "bill_to_country_code"
          DefaultValue: null
          Description: "Bill To Country Code"
    {Carrier}
      CarrierId: "se-423888"
      CarrierCode: "ups"
      AccountNumber: "test_account_423888"
      RequiresFundedAmount: false
      Balance: 0
      Nickname: "ShipEngine Test Account - UPS"
      FriendlyName: "UPS"
      Primary: false
      HasMultiPackageSupportingServices: true
      SupportsLabelMessages: true
      Services: ...
        {Service}
          CarrierId: "se-423888"
          CarrierCode: "ups"
          ServiceCode: "ups_standard_international"
          Name: "UPS Standard®"
          Domestic: false
          International: true
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423888"
          CarrierCode: "ups"
          ServiceCode: "ups_next_day_air_early_am"
          Name: "UPS Next Day Air® Early"
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423888"
          CarrierCode: "ups"
          ServiceCode: "ups_worldwide_express"
          Name: "UPS Worldwide Express®"
          Domestic: false
          International: true
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423888"
          CarrierCode: "ups"
          ServiceCode: "ups_next_day_air"
          Name: "UPS Next Day Air®"
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423888"
          CarrierCode: "ups"
          ServiceCode: "ups_ground_international"
          Name: "UPS Ground® (International)"
          Domestic: false
          International: true
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423888"
          CarrierCode: "ups"
          ServiceCode: "ups_worldwide_express_plus"
          Name: "UPS Worldwide Express Plus®"
          Domestic: false
          International: true
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423888"
          CarrierCode: "ups"
          ServiceCode: "ups_next_day_air_saver"
          Name: "UPS Next Day Air Saver®"
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423888"
          CarrierCode: "ups"
          ServiceCode: "ups_worldwide_expedited"
          Name: "UPS Worldwide Expedited®"
          Domestic: false
          International: true
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423888"
          CarrierCode: "ups"
          ServiceCode: "ups_2nd_day_air_am"
          Name: "UPS 2nd Day Air AM®"
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423888"
          CarrierCode: "ups"
          ServiceCode: "ups_2nd_day_air"
          Name: "UPS 2nd Day Air®"
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423888"
          CarrierCode: "ups"
          ServiceCode: "ups_worldwide_saver"
          Name: "UPS Worldwide Saver®"
          Domestic: false
          International: true
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423888"
          CarrierCode: "ups"
          ServiceCode: "ups_2nd_day_air_international"
          Name: "UPS 2nd Day Air® (International)"
          Domestic: false
          International: true
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423888"
          CarrierCode: "ups"
          ServiceCode: "ups_3_day_select"
          Name: "UPS 3 Day Select®"
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423888"
          CarrierCode: "ups"
          ServiceCode: "ups_ground"
          Name: "UPS® Ground"
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423888"
          CarrierCode: "ups"
          ServiceCode: "ups_next_day_air_international"
          Name: "UPS Next Day Air® (International)"
          Domestic: false
          International: true
          IsMultiPackageSupported: true
      Packages: ...
        {PackageType}
          PackageId: null
          PackageCode: "package"
          Name: "Package"
          Dimensions: null
          Description: "Package. Longest side plus the distance around the thickest part is less than or equal to 84\""
        {PackageType}
          PackageId: null
          PackageCode: "ups__express_box_large"
          Name: "UPS  Express® Box - Large"
          Dimensions: null
          Description: "Express Box - Large"
        {PackageType}
          PackageId: null
          PackageCode: "ups_10_kg_box"
          Name: "UPS 10 KG Box®"
          Dimensions: null
          Description: "10 KG Box"
        {PackageType}
          PackageId: null
          PackageCode: "ups_25_kg_box"
          Name: "UPS 25 KG Box®"
          Dimensions: null
          Description: "25 KG Box"
        {PackageType}
          PackageId: null
          PackageCode: "ups_express_box"
          Name: "UPS Express® Box"
          Dimensions: null
          Description: "Express Box"
        {PackageType}
          PackageId: null
          PackageCode: "ups_express_box_medium"
          Name: "UPS Express® Box - Medium"
          Dimensions: null
          Description: "Express Box - Medium"
        {PackageType}
          PackageId: null
          PackageCode: "ups_express_box_small"
          Name: "UPS Express® Box - Small"
          Dimensions: null
          Description: "Express Box - Small"
        {PackageType}
          PackageId: null
          PackageCode: "ups_express_pak"
          Name: "UPS Express® Pak"
          Dimensions: null
          Description: "Pak"
        {PackageType}
          PackageId: null
          PackageCode: "ups_letter"
          Name: "UPS Letter"
          Dimensions: null
          Description: "Letter"
        {PackageType}
          PackageId: null
          PackageCode: "ups_tube"
          Name: "UPS Tube"
          Dimensions: null
          Description: "Tube"
      Options: ...
        {AdvancedOption}
          Name: "bill_to_account"
          DefaultValue: ""
          Description: ""
        {AdvancedOption}
          Name: "bill_to_country_code"
          DefaultValue: ""
          Description: ""
        {AdvancedOption}
          Name: "bill_to_party"
          DefaultValue: ""
          Description: ""
        {AdvancedOption}
          Name: "bill_to_postal_code"
          DefaultValue: ""
          Description: ""
        {AdvancedOption}
          Name: "collect_on_delivery"
          DefaultValue: ""
          Description: ""
        {AdvancedOption}
          Name: "contains_alcohol"
          DefaultValue: "false"
          Description: ""
        {AdvancedOption}
          Name: "delivered_duty_paid"
          DefaultValue: "false"
          Description: ""
        {AdvancedOption}
          Name: "dry_ice"
          DefaultValue: "false"
          Description: ""
        {AdvancedOption}
          Name: "dry_ice_weight"
          DefaultValue: "0"
          Description: ""
        {AdvancedOption}
          Name: "freight_class"
          DefaultValue: ""
          Description: ""
        {AdvancedOption}
          Name: "non_machinable"
          DefaultValue: "false"
          Description: ""
        {AdvancedOption}
          Name: "saturday_delivery"
          DefaultValue: "false"
          Description: ""
        {AdvancedOption}
          Name: "shipper_release"
          DefaultValue: "false"
          Description: "Driver may release package without signature"
    {Carrier}
      CarrierId: "se-423889"
      CarrierCode: "fedex"
      AccountNumber: "test_account_423889"
      RequiresFundedAmount: false
      Balance: 0
      Nickname: "ShipEngine Test Account - FedEx"
      FriendlyName: "FedEx"
      Primary: false
      HasMultiPackageSupportingServices: true
      SupportsLabelMessages: true
      Services: ...
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_ground"
          Name: "FedEx Ground®"
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_home_delivery"
          Name: "FedEx Home Delivery®"
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_2day"
          Name: "FedEx 2Day®"
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_2day_am"
          Name: "FedEx 2Day® A.M."
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_express_saver"
          Name: "FedEx Express Saver®"
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_standard_overnight"
          Name: "FedEx Standard Overnight®"
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_priority_overnight"
          Name: "FedEx Priority Overnight®"
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_first_overnight"
          Name: "FedEx First Overnight®"
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_1_day_freight"
          Name: "FedEx 1Day® Freight"
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_2_day_freight"
          Name: "FedEx 2Day® Freight"
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_3_day_freight"
          Name: "FedEx 3Day® Freight"
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_first_overnight_freight"
          Name: "FedEx First Overnight® Freight"
          Domestic: true
          International: false
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_ground_international"
          Name: "FedEx International Ground®"
          Domestic: false
          International: true
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_international_economy"
          Name: "FedEx International Economy®"
          Domestic: false
          International: true
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_international_priority"
          Name: "FedEx International Priority®"
          Domestic: false
          International: true
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_international_first"
          Name: "FedEx International First®"
          Domestic: false
          International: true
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_international_economy_freight"
          Name: "FedEx International Economy® Freight"
          Domestic: false
          International: true
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_international_priority_freight"
          Name: "FedEx International Priority® Freight"
          Domestic: false
          International: true
          IsMultiPackageSupported: true
        {Service}
          CarrierId: "se-423889"
          CarrierCode: "fedex"
          ServiceCode: "fedex_international_connect_plus"
          Name: "FedEx International Connect Plus®"
          Domestic: false
          International: true
          IsMultiPackageSupported: false
      Packages: ...
        {PackageType}
          PackageId: null
          PackageCode: "fedex_envelope_onerate"
          Name: "FedEx One Rate® Envelope"
          Dimensions: null
          Description: "FedEx® Envelope"
        {PackageType}
          PackageId: null
          PackageCode: "fedex_extra_large_box_onerate"
          Name: "FedEx One Rate® Extra Large Box"
          Dimensions: null
          Description: "FedEx® Extra Large Box"
        {PackageType}
          PackageId: null
          PackageCode: "fedex_large_box_onerate"
          Name: "FedEx One Rate® Large Box"
          Dimensions: null
          Description: "FedEx® Large Box"
        {PackageType}
          PackageId: null
          PackageCode: "fedex_medium_box_onerate"
          Name: "FedEx One Rate® Medium Box"
          Dimensions: null
          Description: "FedEx® Medium Box"
        {PackageType}
          PackageId: null
          PackageCode: "fedex_pak_onerate"
          Name: "FedEx One Rate® Pak"
          Dimensions: null
          Description: "FedEx® Pak"
        {PackageType}
          PackageId: null
          PackageCode: "fedex_small_box_onerate"
          Name: "FedEx One Rate® Small Box"
          Dimensions: null
          Description: "FedEx® Small Box"
        {PackageType}
          PackageId: null
          PackageCode: "fedex_tube_onerate"
          Name: "FedEx One Rate® Tube"
          Dimensions: null
          Description: "FedEx® Tube"
        {PackageType}
          PackageId: null
          PackageCode: "fedex_10kg_box"
          Name: "FedEx® 10kg Box"
          Dimensions: null
          Description: "FedEx® 10kg Box"
        {PackageType}
          PackageId: null
          PackageCode: "fedex_25kg_box"
          Name: "FedEx® 25kg Box"
          Dimensions: null
          Description: "FedEx® 25kg Box"
        {PackageType}
          PackageId: null
          PackageCode: "fedex_box"
          Name: "FedEx® Box"
          Dimensions: null
          Description: "FedEx® Box"
        {PackageType}
          PackageId: null
          PackageCode: "fedex_envelope"
          Name: "FedEx® Envelope"
          Dimensions: null
          Description: "FedEx® Envelope"
        {PackageType}
          PackageId: null
          PackageCode: "fedex_extra_large_box"
          Name: "FedEx® Extra Large Box"
          Dimensions: null
          Description: "FedEx® Extra Large Box"
        {PackageType}
          PackageId: null
          PackageCode: "fedex_large_box"
          Name: "FedEx® Large Box"
          Dimensions: null
          Description: "FedEx® Large Box"
        {PackageType}
          PackageId: null
          PackageCode: "fedex_medium_box"
          Name: "FedEx® Medium Box"
          Dimensions: null
          Description: "FedEx® Medium Box"
        {PackageType}
          PackageId: null
          PackageCode: "fedex_pak"
          Name: "FedEx® Pak"
          Dimensions: null
          Description: "FedEx® Pak"
        {PackageType}
          PackageId: null
          PackageCode: "fedex_small_box"
          Name: "FedEx® Small Box"
          Dimensions: null
          Description: "FedEx® Small Box"
        {PackageType}
          PackageId: null
          PackageCode: "fedex_tube"
          Name: "FedEx® Tube"
          Dimensions: null
          Description: "FedEx® Tube"
        {PackageType}
          PackageId: null
          PackageCode: "package"
          Name: "Package"
          Dimensions: null
          Description: "Package. Longest side plus the distance around the thickest part is less than or equal to 84\""
      Options: ...
        {AdvancedOption}
          Name: "bill_to_account"
          DefaultValue: ""
          Description: ""
        {AdvancedOption}
          Name: "bill_to_country_code"
          DefaultValue: ""
          Description: ""
        {AdvancedOption}
          Name: "bill_to_party"
          DefaultValue: ""
          Description: ""
        {AdvancedOption}
          Name: "bill_to_postal_code"
          DefaultValue: ""
          Description: ""
        {AdvancedOption}
          Name: "collect_on_delivery"
          DefaultValue: ""
          Description: ""
        {AdvancedOption}
          Name: "contains_alcohol"
          DefaultValue: "false"
          Description: ""
        {AdvancedOption}
          Name: "delivered_duty_paid"
          DefaultValue: "false"
          Description: ""
        {AdvancedOption}
          Name: "dry_ice"
          DefaultValue: "false"
          Description: ""
        {AdvancedOption}
          Name: "dry_ice_weight"
          DefaultValue: "0"
          Description: ""
        {AdvancedOption}
          Name: "non_machinable"
          DefaultValue: "false"
          Description: ""
        {AdvancedOption}
          Name: "saturday_delivery"
          DefaultValue: "false"
          Description: ""
  RequestId: "aca26140-726c-49b8-8370-0eca0010fa27"
  Errors: ...
```
