# ShipEngineSDK.Model.Products
The customs declaration for a single item in the shipment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CountryOfOrigin** | **string** | The two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) where this item originated  | [optional] 
**DangerousGoods** | [**List&lt;DangerousGoods&gt;**](DangerousGoods.md) | Details about dangerous goods inside products | [optional] 
**Description** | **string** | A description of the item | [optional] 
**ExtendedDetails** | **Dictionary&lt;string, Object&gt;** | Additional details about products | [optional] 
**HarmonizedTariffCode** | **string** | The [Harmonized Tariff Code](https://en.wikipedia.org/wiki/Harmonized_System) of this item. | [optional] 
**MidCode** | **string** | Manufacturers Identification code | [optional] 
**ProductUrl** | **string** | link to the item on the seller website | [optional] 
**Quantity** | **int** | The quantity of this item in the shipment. | [optional] [default to 0]
**Sku** | **string** | The SKU (Stock Keeping Unit) of the item | [optional] 
**SkuDescription** | **string** | Description of the Custom Item&#39;s SKU | [optional] 
**UnitOfMeasure** | **string** |  | [optional] 
**Value** | [**MonetaryValue**](MonetaryValue.md) | The declared value of each item | [optional] 
**VatRate** | **decimal** | VAT rate applicable to the item | [optional] 
**Weight** | [**Weight**](Weight.md) | The item weight | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

