# ShipEngineSDK.Model.CreateManifestResponseBody
A create manifest response body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Manifests** | [**List&lt;Manifest&gt;**](Manifest.md) | Resulting Manifests | [optional] 
**ManifestRequests** | [**List&lt;ManifestRequest&gt;**](ManifestRequest.md) | Resulting manifest requests with statuses | [optional] 
**ManifestId** | **string** | A string that uniquely identifies the manifest | 
**FormId** | **string** | A string that uniquely identifies the form | 
**CreatedAt** | **DateTime** | The date-time that the manifest was created | 
**ShipDate** | **DateTime** | The date-time that the manifests shipments will be picked up | 
**Shipments** | **int** | The number of shipments that are included in this manifest | [readonly] 
**WarehouseId** | **string** | A string that uniquely identifies the warehouse | 
**SubmissionId** | **string** | A string that uniquely identifies the submission | 
**CarrierId** | **string** | A string that uniquely identifies the carrier | 
**ManifestDownload** | [**ManifestDownload**](ManifestDownload.md) |  | 
**LabelIds** | **List&lt;string&gt;** | An array of the label ids used in this manifest. | [optional] [readonly] 
**RequestId** | **Guid** | A UUID that uniquely identifies the request id. This can be given to the support team to help debug non-trivial issues that may occur  | 
**Errors** | [**List&lt;Error&gt;**](Error.md) | The errors associated with the failed API call | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

