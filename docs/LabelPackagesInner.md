# ShipEngineSDK.Model.LabelPackagesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PackageId** | **string** | A string that uniquely identifies this [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/) | [optional] 
**PackageCode** | **string** | The [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/), such as &#x60;thick_envelope&#x60;, &#x60;small_flat_rate_box&#x60;, &#x60;large_package&#x60;, etc.  The code &#x60;package&#x60; indicates a custom or unknown package type.  | [optional] 
**ContentDescription** | **string** | A short description of the package content. Required for shipments moving to, from, and through Mexico.  | [optional] 
**Weight** | [**Weight**](Weight.md) | The package weight | 
**Dimensions** | [**Dimensions**](Dimensions.md) | The package dimensions | [optional] 
**InsuredValue** | [**MonetaryValue**](MonetaryValue.md) | The insured value of the package.  Requires the &#x60;insurance_provider&#x60; field of the shipment to be set.  | [optional] 
**TrackingNumber** | **string** | The tracking number for the package.  The format depends on the carrier.  | [optional] [readonly] 
**LabelMessages** | [**LabelMessages**](LabelMessages.md) |  | [optional] 
**ExternalPackageId** | **string** | An external package id. | [optional] 
**LabelDownload** | [**LabelDownload**](LabelDownload.md) | The label download for the package | [optional] [readonly] 
**FormDownload** | [**OptionalLink**](OptionalLink.md) | The form download for any customs that are needed | [optional] [readonly] 
**PaperlessDownload** | [**PaperlessDownload**](PaperlessDownload.md) | The paperless details which may contain elements like &#x60;href&#x60;, &#x60;instructions&#x60; and &#x60;handoff_code&#x60;. | [optional] [readonly] 
**Sequence** | **int** | Package sequence | [optional] [readonly] 
**Products** | [**List&lt;Products&gt;**](Products.md) | Details about products inside packages (Information provided would be used on custom documentation) | [optional] 
**AlternativeIdentifiers** | [**List&lt;AlternativeIdentifier&gt;**](AlternativeIdentifier.md) | Alternative identifiers associated with this package.  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

