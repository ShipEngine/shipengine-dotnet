# ShipEngineSDK.Model.GetBatchByExternalIdResponseBody
A get batch by external id response body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatchErrorsUrl** | [**OptionalLink**](OptionalLink.md) | Link to batch errors endpoint | [readonly] 
**BatchId** | **string** | A string that uniquely identifies the batch | [readonly] 
**BatchLabelsUrl** | [**OptionalLink**](OptionalLink.md) | Link to batch labels query | 
**BatchNumber** | **string** | The batch number. | [readonly] 
**BatchShipmentsUrl** | [**OptionalLink**](OptionalLink.md) | The batch shipments endpoint | 
**Completed** | **int** | The number of labels generated in the batch | [readonly] 
**Count** | **int** | The total of errors, warnings, and completed properties | [readonly] 
**CreatedAt** | **DateTimeOffset** | The date and time the batch was created in ShipEngine | [readonly] 
**Errors** | **int** | The number of errors that occurred while generating the batch | [readonly] 
**FormDownload** | [**OptionalLink**](OptionalLink.md) | The form download for any customs that are needed | [readonly] 
**Forms** | **int** | The number of forms for customs that are available for download | [readonly] 
**LabelDownload** | [**LabelDownload**](LabelDownload.md) | The label download for the batch | [readonly] 
**LabelFormat** | **LabelFormat** |  | [readonly] 
**LabelLayout** | **LabelLayout** | label layout | [readonly] 
**PaperlessDownload** | [**PaperlessDownload**](PaperlessDownload.md) | The paperless details which may contain elements like &#x60;href&#x60;, &#x60;instructions&#x60; and &#x60;handoff_code&#x60;. | [readonly] 
**ProcessErrors** | [**List&lt;Error&gt;**](Error.md) | The errors associated with the failed API call | [readonly] 
**Status** | **BatchStatus** |  | [readonly] 
**Warnings** | **int** | The number of warnings that occurred while generating the batch | [readonly] 
**BatchNotes** | **string** | Custom notes you can add for each created batch | [readonly] [default to ""]
**ExternalBatchId** | **string** | A string that uniquely identifies the external batch | [readonly] 
**ProcessedAt** | **DateTimeOffset** | The date and time the batch was processed in ShipEngine | [readonly] 

