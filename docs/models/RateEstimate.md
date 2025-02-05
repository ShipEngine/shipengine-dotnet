# ShipEngineSDK.Model.RateEstimate
A rate estimate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CarrierCode** | **string** | A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc. | [readonly] 
**CarrierFriendlyName** | **string** | carrier friendly name | [readonly] 
**CarrierId** | **string** | A string that uniquely identifies the carrier | [readonly] 
**CarrierNickname** | **string** | carrier nickname | [readonly] 
**ConfirmationAmount** | [**MonetaryValue**](MonetaryValue.md) | The confirmation amount | [readonly] 
**ErrorMessages** | **List&lt;string&gt;** | The error messages | [readonly] 
**GuaranteedService** | **bool** | Indicates if the rate is guaranteed. | [readonly] 
**InsuranceAmount** | [**MonetaryValue**](MonetaryValue.md) | The insurance amount | [readonly] 
**NegotiatedRate** | **bool** | Indicates if the rates been negotiated | [readonly] 
**OtherAmount** | [**MonetaryValue**](MonetaryValue.md) | Any other charges associated with this rate | [readonly] 
**RateType** | **RateType** |  | [readonly] 
**ServiceCode** | **string** | service code for the rate | [readonly] 
**ServiceType** | **string** | service type | [readonly] 
**ShippingAmount** | [**MonetaryValue**](MonetaryValue.md) | The shipping amount | [readonly] 
**Trackable** | **bool** | Indicates if rate is trackable | [readonly] 
**ValidationStatus** | **ValidationStatus** |  | [readonly] 
**WarningMessages** | **List&lt;string&gt;** | The warning messages | [readonly] 
**CarrierDeliveryDays** | **string** | The carrier delivery days | [optional] [readonly] 
**DeliveryDays** | **int** | The number of days estimated for delivery, this will show the _actual_ delivery time if for example, the package gets shipped on a Friday  | [optional] [readonly] 
**EstimatedDeliveryDate** | **DateTimeOffset** | An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date, but not a specific time.  The value _may_ contain a time component, but it will be set to &#x60;00:00:00&#x60; UTC by ShipEngine.  | [optional] [readonly] 
**PackageType** | **string** | package type that this rate was estimated for | [readonly] 
**ShipDate** | **DateTimeOffset** | ship date | [optional] [readonly] 
**TaxAmount** | [**MonetaryValue**](MonetaryValue.md) | Tariff and additional taxes associated with an international shipment. | [optional] [readonly] 
**Zone** | **int** | Certain carriers base [their rates](https://blog.stamps.com/2017/09/08/usps-postal-zones/) off of custom zones that vary depending upon the ship_to and ship_from location  | [readonly] 

