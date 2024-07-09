# ShipEngineSDK.Model.DeprecatedManifest
Deprecated manifest resource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ManifestId** | **string** | A string that uniquely identifies the manifest | [optional] 
**FormId** | **string** | A string that uniquely identifies the form | [optional] 
**CreatedAt** | **DateTime** | The date-time that the manifest was created | [optional] 
**ShipDate** | **DateTime** | The date-time that the manifests shipments will be picked up | [optional] 
**Shipments** | **int** | The number of shipments that are included in this manifest | [optional] [readonly] 
**WarehouseId** | **string** | A string that uniquely identifies the warehouse | [optional] 
**SubmissionId** | **string** | A string that uniquely identifies the submission | [optional] 
**CarrierId** | **string** | A string that uniquely identifies the carrier | [optional] 
**ManifestDownload** | [**ManifestDownload**](ManifestDownload.md) |  | [optional] 
**LabelIds** | **List&lt;string&gt;** | An array of the label ids used in this manifest. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

