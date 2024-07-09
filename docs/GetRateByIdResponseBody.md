# ShipEngineSDK.Model.GetRateByIdResponseBody
A rate response body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RateId** | **string** | A string that uniquely identifies the rate | [readonly] 
**RateType** | **RateType** |  | [readonly] 
**CarrierId** | **string** | A string that uniquely identifies the carrier | [readonly] 
**ShippingAmount** | [**MonetaryValue**](MonetaryValue.md) | The shipping amount. Should be added with confirmation_amount, insurance_amount and other_amount to calculate the total purchase price. | [readonly] 
**InsuranceAmount** | [**MonetaryValue**](MonetaryValue.md) | The insurance amount.  Should be added with shipping_amount, confirmation_amount and other_amount to calculate the total purchase price. | [readonly] 
**ConfirmationAmount** | [**MonetaryValue**](MonetaryValue.md) | The confirmation amount.  Should be added with shipping_amount, insurance_amount and other_amount to calculate the total purchase price. | [readonly] 
**OtherAmount** | [**MonetaryValue**](MonetaryValue.md) | Any other charges associated with this rate.  Should be added with shipping_amount, insurance_amount and confirmation_amount to calculate the total purchase price. | [readonly] 
**RequestedComparisonAmount** | [**MonetaryValue**](MonetaryValue.md) | The total shipping cost for the specified comparison_rate_type. | [optional] [readonly] 
**TaxAmount** | [**MonetaryValue**](MonetaryValue.md) | Tariff and additional taxes associated with an international shipment. | [optional] [readonly] 
**Zone** | **int?** | Certain carriers base [their rates](https://blog.stamps.com/2017/09/08/usps-postal-zones/) off of custom zones that vary depending upon the ship_to and ship_from location  | [readonly] 
**PackageType** | **string** | package type that this rate was estimated for | [readonly] 
**DeliveryDays** | **int** | The number of days estimated for delivery, this will show the _actual_ delivery time if for example, the package gets shipped on a Friday  | [optional] [readonly] 
**GuaranteedService** | **bool** | Indicates if the rate is guaranteed. | [readonly] 
**EstimatedDeliveryDate** | **DateTime** | An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date, but not a specific time.  The value _may_ contain a time component, but it will be set to &#x60;00:00:00&#x60; UTC by ShipEngine.  | [optional] [readonly] 
**CarrierDeliveryDays** | **string** | The carrier delivery days | [optional] [readonly] 
**ShipDate** | **DateTime** | ship date | [optional] [readonly] 
**NegotiatedRate** | **bool** | Indicates if the rates been negotiated | [readonly] 
**ServiceType** | **string** | service type | [readonly] 
**ServiceCode** | **string** | service code for the rate | [readonly] 
**Trackable** | **bool** | Indicates if rate is trackable | [readonly] 
**CarrierCode** | **string** | carrier code | [readonly] 
**CarrierNickname** | **string** | carrier nickname | [readonly] 
**CarrierFriendlyName** | **string** | carrier friendly name | [readonly] 
**ValidationStatus** | **ValidationStatus** |  | [readonly] 
**WarningMessages** | **List&lt;string&gt;** | The warning messages | [readonly] 
**ErrorMessages** | **List&lt;string&gt;** | The error messages | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

