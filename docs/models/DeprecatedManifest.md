# ShipEngineSDK.Model.DeprecatedManifest
Deprecated manifest resource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CarrierId** | **string** | A string that uniquely identifies the carrier | [optional] 
**CreatedAt** | **DateTimeOffset** | The date-time that the manifest was created | [optional] 
**FormId** | **string** | A string that uniquely identifies the form | [optional] 
**LabelIds** | **List&lt;string&gt;** | An array of the label ids used in this manifest. | [optional] [readonly] 
**ManifestDownload** | [**ManifestDownload**](ManifestDownload.md) |  | [optional] 
**ManifestId** | **string** | A string that uniquely identifies the manifest | [optional] 
**ShipDate** | **DateTimeOffset** | The date-time that the manifests shipments will be picked up | [optional] 
**Shipments** | **int** | The number of shipments that are included in this manifest | [optional] [readonly] 
**SubmissionId** | **string** | A string that uniquely identifies the submission | [optional] 
**WarehouseId** | **string** | A string that uniquely identifies the warehouse | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

