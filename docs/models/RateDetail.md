# ShipEngineSDK.Model.RateDetail
Represents detailed information about a shipping cost 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | [**MonetaryValue**](MonetaryValue.md) |  | [optional] 
**BillingSource** | **string** | The source of the billing information. This is typically the carrier, but could be a third party, e.g insurance | [optional] 
**CarrierBillingCode** | **string** | A rate detail code defined by a carrier | [optional] 
**CarrierDescription** | **string** | A rate detail description defined by a carrier | [optional] 
**CarrierMemo** | **string** | Contains any additional information | [optional] 
**RateDetailAttributes** | [**RateDetailAttributes**](RateDetailAttributes.md) | If applicable, contains additional data about a rate detail of a specific type, e.g. VAT | [optional] 
**RateDetailType** | **RateDetailType** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

