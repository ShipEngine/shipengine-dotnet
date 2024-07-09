# ShipEngineSDK.Model.CustomsItem
The customs declaration for a single item in the shipment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomsItemId** | **string** | A string that uniquely identifies the customs item | [readonly] 
**Description** | **string** | A description of the item | [optional] 
**Quantity** | **int** | The quantity of this item in the shipment. | [optional] [default to 0]
**Value** | **double** | The monetary amount, in the specified currency. | [optional] 
**ValueCurrency** | **string** | The currencies that are supported by ShipEngine are the ones that specified by ISO 4217: https://www.iso.org/iso-4217-currency-codes.html  | [optional] 
**Weight** | [**Weight**](Weight.md) | The item weight | [optional] 
**HarmonizedTariffCode** | **string** | The [Harmonized Tariff Code](https://en.wikipedia.org/wiki/Harmonized_System) of this item. | [optional] 
**CountryOfOrigin** | **string** | The two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) where this item originated  | [optional] 
**UnitOfMeasure** | **string** |  | [optional] 
**Sku** | **string** | The SKU (Stock Keeping Unit) of the customs item | [optional] 
**SkuDescription** | **string** | Description of the Custom Item&#39;s SKU | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

