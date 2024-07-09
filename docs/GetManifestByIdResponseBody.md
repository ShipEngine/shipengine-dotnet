# ShipEngineSDK.Model.GetManifestByIdResponseBody
A get manifest by id response body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ManifestId** | **string** | A string that uniquely identifies the manifest | [readonly] 
**FormId** | **string** | A string that uniquely identifies the form | [readonly] 
**CreatedAt** | **DateTime** | The date-time that the manifest was created | [readonly] 
**ShipDate** | **DateTime** | The date-time that the manifests shipments will be picked up | [readonly] 
**Shipments** | **int** | The number of shipments that are included in this manifest | [readonly] 
**LabelIds** | **List&lt;string&gt;** | An array of the label ids used in this manifest. | [readonly] 
**WarehouseId** | **string** | A string that uniquely identifies the warehouse | [readonly] 
**SubmissionId** | **string** | A string that uniquely identifies the submission | [readonly] 
**CarrierId** | **string** | A string that uniquely identifies the carrier | [readonly] 
**ManifestDownload** | [**ManifestDownload**](ManifestDownload.md) |  | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

