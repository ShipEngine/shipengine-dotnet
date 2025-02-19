# ShipEngineSDK.Model.CreateManifestByObjectRequestBody
A create manifest request body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CarrierId** | **string** | A string that uniquely identifies the carrier | 
**ShipDate** | **DateTimeOffset** | The ship date that the shipment will be sent out on | 
**WarehouseId** | **string** | A string that uniquely identifies the warehouse | 
**ExcludedLabelIds** | **List&lt;string&gt;** | The list of label ids to exclude from the manifest | [optional] 
**LabelIds** | **List&lt;string&gt;** | The list of label ids to include for the manifest | [optional] 

