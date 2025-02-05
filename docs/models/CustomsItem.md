# ShipEngineSDK.Model.CustomsItem
The customs declaration for a single item in the shipment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomsItemId** | **string** | A string that uniquely identifies the customs item | [readonly] 
**CountryOfOrigin** | **string** | The two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) where this item originated  | [optional] 
**Description** | **string** | A description of the item | [optional] 
**HarmonizedTariffCode** | **string** | The [Harmonized Tariff Code](https://en.wikipedia.org/wiki/Harmonized_System) of this item. | [optional] 
**Quantity** | **int** | The quantity of this item in the shipment. | [optional] [default to 0]
**Sku** | **string** | The SKU (Stock Keeping Unit) of the customs item | [optional] 
**SkuDescription** | **string** | Description of the Custom Item&#39;s SKU | [optional] 
**UnitOfMeasure** | **string** |  | [optional] 
**Value** | **decimal** | The monetary amount, in the specified currency. | [optional] 
**ValueCurrency** | **string** | The currencies that are supported by ShipEngine are the ones that specified by ISO 4217: https://www.iso.org/iso-4217-currency-codes.html  | [optional] 
**Weight** | [**Weight**](Weight.md) | The item weight | [optional] 

