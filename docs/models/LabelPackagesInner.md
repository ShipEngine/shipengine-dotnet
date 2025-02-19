# ShipEngineSDK.Model.LabelPackagesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Weight** | [**Weight**](Weight.md) | The package weight | 
**AlternativeIdentifiers** | [**List&lt;AlternativeIdentifier&gt;**](AlternativeIdentifier.md) | Alternative identifiers associated with this package.  | [optional] [readonly] 
**ContentDescription** | **string** | A short description of the package content. Required for shipments moving to, from, and through Mexico.  | [optional] 
**Dimensions** | [**Dimensions**](Dimensions.md) | The package dimensions | [optional] 
**ExternalPackageId** | **string** | An external package id. | [optional] 
**FormDownload** | [**OptionalLink**](OptionalLink.md) | The form download for any customs that are needed | [optional] [readonly] 
**HasFormDocuments** | **bool** | Whether the package has form documents available for download | [optional] 
**HasLabelDocuments** | **bool** | Whether the package has label documents available for download | [optional] 
**HasPaperlessLabelDocuments** | **bool** | Whether the package has paperless documents available for download | [optional] 
**HasQrCodeDocuments** | **bool** | Whether the package has QR code documents available for download | [optional] 
**InsuredValue** | [**MonetaryValue**](MonetaryValue.md) | The insured value of the package.  Requires the &#x60;insurance_provider&#x60; field of the shipment to be set.  | [optional] 
**LabelDownload** | [**LabelDownload**](LabelDownload.md) | The label download for the package | [optional] [readonly] 
**LabelMessages** | [**LabelMessages**](LabelMessages.md) |  | [optional] 
**PackageCode** | **string** | The [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/), such as &#x60;thick_envelope&#x60;, &#x60;small_flat_rate_box&#x60;, &#x60;large_package&#x60;, etc.  The code &#x60;package&#x60; indicates a custom or unknown package type.  | [optional] 
**PackageId** | **int** | The shipment package id | [optional] [readonly] 
**PaperlessDownload** | [**PaperlessDownload**](PaperlessDownload.md) | The paperless details which may contain elements like &#x60;href&#x60;, &#x60;instructions&#x60; and &#x60;handoff_code&#x60;. | [optional] [readonly] 
**QrCodeDownload** | [**OptionalLink**](OptionalLink.md) | The QR code download for the package | [optional] [readonly] 
**Sequence** | **int** | Package sequence | [optional] [readonly] 
**TrackingNumber** | **string** | The tracking number for the package.  The format depends on the carrier.  | [optional] [readonly] 

