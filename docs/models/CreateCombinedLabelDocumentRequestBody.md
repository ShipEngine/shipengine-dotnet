# ShipEngineSDK.Model.CreateCombinedLabelDocumentRequestBody
A create combined label document request body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LabelDownloadType** | **string** | The download type for the combined label document; note that currently only &#x60;\&quot;inline\&quot;&#x60; is supported. | [optional] 
**LabelFormat** | **string** | The file format for the combined label document; note that currently only &#x60;\&quot;pdf\&quot;&#x60; is supported. | [optional] 
**LabelIds** | **List&lt;string&gt;** | The list of up to 30 label ids to include in the combined label document. Note that to avoid response size limits, you should only expect to be able to combine 30 single page labels similar in size to that of USPS labels.  | [optional] 

