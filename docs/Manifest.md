# ShipEngineSDK.Model.Manifest
Used for combining packages into one scannable form that a carrier can use when picking up a large  number of shipments 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ManifestId** | **string** | A string that uniquely identifies the manifest | [optional] [readonly] 
**FormId** | **string** | A string that uniquely identifies the form | [optional] [readonly] 
**CreatedAt** | **DateTime** | The date-time that the manifest was created | [optional] [readonly] 
**ShipDate** | **DateTime** | The date-time that the manifests shipments will be picked up | [optional] [readonly] 
**Shipments** | **int** | The number of shipments that are included in this manifest | [optional] [readonly] 
**LabelIds** | **List&lt;string&gt;** | An array of the label ids used in this manifest. | [optional] [readonly] 
**WarehouseId** | **string** | A string that uniquely identifies the warehouse | [optional] [readonly] 
**SubmissionId** | **string** | A string that uniquely identifies the submission | [optional] [readonly] 
**CarrierId** | **string** | A string that uniquely identifies the carrier | [optional] [readonly] 
**ManifestDownload** | [**ManifestDownload**](ManifestDownload.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

