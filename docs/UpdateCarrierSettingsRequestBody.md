# ShipEngineSDK.Model.UpdateCarrierSettingsRequestBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Nickname** | **string** | nickname | [optional] 
**ShouldHideAccountNumberOnArchiveDoc** | **bool** | Indicates if the account number should be hidden on the archive documentation | [optional] 
**IsPrimaryAccount** | **bool** | Indicates if this is the primary UPS account | [optional] 
**PickupType** | **UpsPickupType** |  | [optional] 
**SmartPostHub** | **SmartPostHub** |  | [optional] 
**SmartPostEndorsement** | **AncillaryServiceEndorsement** |  | [optional] 
**SignatureImage** | **string** |  | [optional] 
**LetterheadImage** | **string** |  | [optional] 
**IncludeBarcodeWithOrderNumber** | **bool** |  | [optional] 
**ReceiveEmailOnManifestProcessing** | **bool** |  | [optional] 
**UseCarbonNeutralShippingProgram** | **bool** | The use carbon neutral shipping program | [optional] 
**UseGroundFreightPricing** | **bool** | The use ground freight pricing | [optional] 
**UseConsolidationServices** | **bool** | The use consolidation services | [optional] 
**UseOrderNumberOnMailInnovationsLabels** | **bool** | The use order number on mail innovations labels | [optional] 
**MailInnovationsEndorsement** | **AncillaryServiceEndorsement** |  | [optional] 
**MailInnovationsCostCenter** | **string** | mail innovations cost center | [optional] 
**UseNegotiatedRates** | **bool** | The use negotiated rates | [optional] 
**AccountPostalCode** | **string** | account postal code | [optional] 
**Invoice** | [**UpsInvoice**](UpsInvoice.md) | The invoice | [optional] 
**Email** | **string** | Email | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

