# ShipEngineSDK.Model.CreateLabelRateShopperRequestBody
Request body for creating a label using the Rate Shopper. The Rate Shopper automatically selects the carrier and service based on your specified strategy.  **Important Constraints:** - You MUST provide shipment details inline in the `shipment` object - You MUST NOT set `shipment_id` (inline shipment only) - You MUST NOT include `carrier_id`, `service_code`, or `shipping_rule_id`   in the shipment (Rate Shopper selects these automatically) - Only carriers configured in your wallet will be considered - This endpoint is not available in sandbox mode 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Shipment** | [**PartialShipmentForRateShopper**](PartialShipmentForRateShopper.md) | The shipment details for which to create a label. Must be provided inline. The carrier_id, service_code, and shipping_rule_id are not included as these will be automatically determined by the Rate Shopper based on your strategy.  | 
**ChargeEvent** | **LabelChargeEvent** | The label charge event.  | [optional] 
**DisplayScheme** | **DisplayScheme** | The display format that the label should be shown in. | [optional] 
**IsReturnLabel** | **bool** | Indicates whether this is a return label.  You may also want to set the &#x60;rma_number&#x60; so you know what is being returned.  | [optional] 
**LabelDownloadType** | **LabelDownloadType** |  | [optional] 
**LabelFormat** | **LabelFormat** | The file format that you want the label to be in.  We recommend &#x60;pdf&#x60; format because it is supported by all carriers, whereas some carriers do not support the &#x60;png&#x60; or &#x60;zpl&#x60; formats.  | [optional] 
**LabelImageId** | **string** | The label image resource that was used to create a custom label image. | [optional] 
**LabelLayout** | **LabelLayout** | The layout (size) that you want the label to be in.  The &#x60;label_format&#x60; determines which sizes are allowed.  &#x60;4x6&#x60; is supported for all label formats, whereas &#x60;letter&#x60; (8.5\&quot; x 11\&quot;) is only supported for &#x60;pdf&#x60; format.  | [optional] 
**OutboundLabelId** | **string** | The &#x60;label_id&#x60; of the original (outgoing) label that the return label is for. This associates the two labels together, which is required by some carriers.  | [optional] 
**RmaNumber** | **string** | An optional Return Merchandise Authorization number.  This field is useful for return labels.  You can set it to any string value.  | [optional] 
**TestLabel** | **bool** | Indicate if this label is being used only for testing purposes. If true, then no charge will be added to your account. | [optional] [default to false]
**ValidateAddress** | **ValidateAddress** |  | [optional] 

