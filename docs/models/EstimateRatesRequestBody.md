# ShipEngineSDK.Model.EstimateRatesRequestBody
A rate estimate request body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromCityLocality** | **string** | from postal code | 
**FromCountryCode** | **string** | A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1)  | 
**FromPostalCode** | **string** | postal code | 
**FromStateProvince** | **string** | From state province | 
**ShipDate** | **DateTimeOffset** | ship date | 
**ToCityLocality** | **string** | The city locality the package is being shipped to | 
**ToCountryCode** | **string** | A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1)  | 
**ToPostalCode** | **string** | postal code | 
**ToStateProvince** | **string** | To state province | 
**Weight** | [**Weight**](Weight.md) | The weight of the package | 
**AddressResidentialIndicator** | **AddressResidentialIndicator** |  | [optional] 
**Confirmation** | **DeliveryConfirmation** |  | [optional] 
**Dimensions** | [**Dimensions**](Dimensions.md) | The dimensions of the package | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

