# ShipEngineSDK.Model.GetBatchByExternalIdResponseBody
A get batch by external id response body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LabelLayout** | **LabelLayout** | label layout | [readonly] 
**LabelFormat** | **LabelFormat** |  | [readonly] 
**BatchId** | **string** | A string that uniquely identifies the batch | [readonly] 
**BatchNumber** | **string** | The batch number. | [readonly] 
**ExternalBatchId** | **string** | A string that uniquely identifies the external batch | [readonly] 
**BatchNotes** | **string** | Custom notes you can add for each created batch | [readonly] [default to ""]
**CreatedAt** | **DateTime** | The date and time the batch was created in ShipEngine | [readonly] 
**ProcessedAt** | **DateTime** | The date and time the batch was processed in ShipEngine | [readonly] 
**Errors** | **int** | The number of errors that occurred while generating the batch | [readonly] 
**ProcessErrors** | [**List&lt;Error&gt;**](Error.md) | The errors associated with the failed API call | [readonly] 
**Warnings** | **int** | The number of warnings that occurred while generating the batch | [readonly] 
**Completed** | **int** | The number of labels generated in the batch | [readonly] 
**Forms** | **int** | The number of forms for customs that are available for download | [readonly] 
**Count** | **int** | The total of errors, warnings, and completed properties | [readonly] 
**BatchShipmentsUrl** | [**OptionalLink**](OptionalLink.md) | The batch shipments endpoint | 
**BatchLabelsUrl** | [**OptionalLink**](OptionalLink.md) | Link to batch labels query | 
**BatchErrorsUrl** | [**OptionalLink**](OptionalLink.md) | Link to batch errors endpoint | [readonly] 
**LabelDownload** | [**LabelDownload**](LabelDownload.md) | The label download for the batch | [readonly] 
**FormDownload** | [**OptionalLink**](OptionalLink.md) | The form download for any customs that are needed | [readonly] 
**PaperlessDownload** | [**PaperlessDownload**](PaperlessDownload.md) | The paperless details which may contain elements like &#x60;href&#x60;, &#x60;instructions&#x60; and &#x60;handoff_code&#x60;. | [readonly] 
**Status** | **BatchStatus** |  | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

