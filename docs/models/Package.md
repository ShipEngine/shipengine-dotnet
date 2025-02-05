# ShipEngineSDK.Model.Package
A package associated with a shipment 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Weight** | [**Weight**](Weight.md) | The package weight | 
**ContentDescription** | **string** | A short description of the package content. Required for shipments moving to, from, and through Mexico.  | [optional] 
**Dimensions** | [**Dimensions**](Dimensions.md) | The package dimensions | [optional] 
**ExternalPackageId** | **string** | An external package id. | [optional] 
**InsuredValue** | [**MonetaryValue**](MonetaryValue.md) | The insured value of the package.  Requires the &#x60;insurance_provider&#x60; field of the shipment to be set.  | [optional] 
**LabelMessages** | [**LabelMessages**](LabelMessages.md) |  | [optional] 
**PackageCode** | **string** | The [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/), such as &#x60;thick_envelope&#x60;, &#x60;small_flat_rate_box&#x60;, &#x60;large_package&#x60;, etc.  The code &#x60;package&#x60; indicates a custom or unknown package type.  | [optional] 
**PackageId** | **string** | A string that uniquely identifies this [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/) | [optional] 
**PackageName** | **string** | The name of the of the [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/) | [optional] 
**Products** | [**List&lt;Products&gt;**](Products.md) | Details about products inside packages (Information provided would be used on custom documentation) | [optional] 
**ShipmentPackageId** | **string** | A string that uniquely identifies this shipment package | [optional] [readonly] 
**TrackingNumber** | **string** | The tracking number for the package.  The format depends on the carrier.  | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

