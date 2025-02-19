# ShipEngineSDK.Model.Shipment
The information necessary to ship a package, such as the origin, the destination, the carrier service, and the package dimensions and weight.  > **Note:** Either `ship_from` or `warehouse_id` must be set. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdvancedOptions** | [**AdvancedShipmentOptions**](AdvancedShipmentOptions.md) | Advanced shipment options.  These are entirely optional. | 
**CarrierId** | **string** | The carrier account that is billed for the shipping charges | 
**Confirmation** | **DeliveryConfirmation** | The type of delivery confirmation that is required for this shipment. | 
**CreatedAt** | **DateTimeOffset** | The date and time that the shipment was created in ShipEngine. | [readonly] 
**InsuranceProvider** | **InsuranceProvider** | The insurance provider to use for any insured packages in the shipment.  | 
**ModifiedAt** | **DateTimeOffset** | The date and time that the shipment was created or last modified. | [readonly] 
**Packages** | [**List&lt;Package&gt;**](Package.md) | The packages in the shipment.  &gt; **Note:** Some carriers only allow one package per shipment.  If you attempt to create a multi-package shipment for a carrier that doesn&#39;t allow it, an error will be returned.  | 
**ReturnTo** | [**ShippingAddress**](ShippingAddress.md) | The return address for this shipment.  Defaults to the &#x60;ship_from&#x60; address.  | 
**ServiceCode** | **string** | The [carrier service](https://www.shipengine.com/docs/shipping/use-a-carrier-service/) used to ship the package, such as &#x60;fedex_ground&#x60;, &#x60;usps_first_class_mail&#x60;, &#x60;flat_rate_envelope&#x60;, etc.  | 
**ShipDate** | **DateTimeOffset** | The date that the shipment was (or will be) shipped.  ShipEngine will take the day of week into consideration. For example, if the carrier does not operate on Sundays, then a package that would have shipped on Sunday will ship on Monday instead.  | 
**ShipFrom** | [**ShippingAddress**](ShippingAddress.md) | The shipment&#39;s origin address. If you frequently ship from the same location, consider [creating a warehouse](https://www.shipengine.com/docs/reference/create-warehouse/).  Then you can simply specify the &#x60;warehouse_id&#x60; rather than the complete address each time.  | 
**ShipTo** | [**ShippingAddressTo**](ShippingAddressTo.md) | The recipient&#39;s mailing address | 
**ShipmentId** | **string** | A string that uniquely identifies the shipment | [readonly] 
**ShipmentStatus** | **ShipmentStatus** | The current status of the shipment | [readonly] 
**Tags** | [**List&lt;Tag&gt;**](Tag.md) | Arbitrary tags associated with this shipment.  Tags can be used to categorize shipments, and shipments can be queried by their tags.  | [readonly] 
**TotalWeight** | [**Weight**](Weight.md) | The combined weight of all packages in the shipment | [readonly] 
**ComparisonRateType** | **string** | Calculate a rate for this shipment with the requested carrier using a ratecard that differs from the default.  Only supported for UPS and USPS. | [optional] 
**Customs** | [**InternationalShipmentOptions**](InternationalShipmentOptions.md) | Customs information.  This is usually only needed for international shipments.  | 
**ExternalOrderId** | **string** | ID that the Order Source assigned | [optional] 
**ExternalShipmentId** | **string** | A unique user-defined key to identify a shipment.  This can be used to retrieve the shipment.  &gt; **Warning:** The &#x60;external_shipment_id&#x60; is limited to 50 characters. Any additional characters will be truncated.  | [optional] 
**IsReturn** | **bool** | An optional indicator if the shipment is intended to be a return. Defaults to false if not provided.  | [optional] [default to false]
**Items** | [**List&lt;ShipmentItem&gt;**](ShipmentItem.md) | Describe the packages included in this shipment as related to potential metadata that was imported from external order sources  | [optional] 
**OrderSourceCode** | **OrderSourceName** |  | [optional] 
**ShipmentNumber** | **string** | A non-unique user-defined number used to identify a shipment.  If undefined, this will match the external_shipment_id of the shipment.  &gt; **Warning:** The &#x60;shipment_number&#x60; is limited to 50 characters. Any additional characters will be truncated.  | [optional] 
**ShippingRuleId** | **string** | ID of the shipping rule, which you want to use to automate carrier/carrier service selection for the shipment  | [optional] 
**TaxIdentifiers** | [**List&lt;TaxIdentifier&gt;**](TaxIdentifier.md) |  | [optional] 
**WarehouseId** | **string** | The [warehouse](https://www.shipengine.com/docs/shipping/ship-from-a-warehouse/) that the shipment is being shipped from.  Either &#x60;warehouse_id&#x60; or &#x60;ship_from&#x60; must be specified.  | 

