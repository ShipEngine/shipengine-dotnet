# ShipEngineSDK.Model.CreateLabelRequestBody
A purchase label request body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Shipment** | [**ShipmentRequest**](ShipmentRequest.md) | The shipment information used to generate the label | 
**ChargeEvent** | **LabelChargeEvent** | The label charge event.  | [optional] 
**DisplayScheme** | **DisplayScheme** | The display format that the label should be shown in. | [optional] 
**IsReturnLabel** | **bool** | Indicates whether this is a return label.  You may also want to set the &#x60;rma_number&#x60; so you know what is being returned.  | [optional] 
**LabelDownloadType** | **LabelDownloadType** |  | [optional] 
**LabelFormat** | **LabelFormat** | The file format that you want the label to be in.  We recommend &#x60;pdf&#x60; format because it is supported by all carriers, whereas some carriers do not support the &#x60;png&#x60; or &#x60;zpl&#x60; formats.  | [optional] 
**LabelImageId** | **string** | The label image resource that was used to create a custom label image. | [optional] 
**LabelLayout** | **LabelLayout** | The layout (size) that you want the label to be in.  The &#x60;label_format&#x60; determines which sizes are allowed.  &#x60;4x6&#x60; is supported for all label formats, whereas &#x60;letter&#x60; (8.5\&quot; x 11\&quot;) is only supported for &#x60;pdf&#x60; format.  | [optional] 
**OutboundLabelId** | **string** | The &#x60;label_id&#x60; of the original (outgoing) label that the return label is for. This associates the two labels together, which is required by some carriers.  | [optional] 
**RmaNumber** | **string** | An optional Return Merchandise Authorization number.  This field is useful for return labels.  You can set it to any string value.  | [optional] 
**ShipFromServicePointId** | **string** | A unique identifier for a carrier drop off point where a merchant plans to deliver packages. This will take precedence over a shipment&#39;s ship from address. | [optional] 
**ShipToServicePointId** | **string** | A unique identifier for a carrier service point where the shipment will be delivered by the carrier. This will take precedence over a shipment&#39;s ship to address. | [optional] 
**TestLabel** | **bool** | Indicate if this label is being used only for testing purposes. If true, then no charge will be added to your account. | [optional] [default to false]
**ValidateAddress** | **ValidateAddress** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

