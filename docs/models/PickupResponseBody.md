# ShipEngineSDK.Model.PickupResponseBody
A pickup response body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CarrierId** | **string** | The carrier_id associated with the pickup | [readonly] 
**ContactDetails** | [**ContactDetails**](ContactDetails.md) |  | 
**CreatedAt** | **DateTimeOffset** | The date and time that the pickup was created in ShipEngine. | [readonly] 
**LabelIds** | **List&lt;string&gt;** | Label IDs that will be included in the pickup request | 
**PickupAddress** | [**Address**](Address.md) |  | [readonly] 
**PickupId** | **string** | Pickup Resource ID | [readonly] 
**PickupWindow** | [**PickupWindow**](PickupWindow.md) |  | 
**WarehouseId** | **string** | The warehouse_id associated with the pickup | [readonly] 
**CancelledAt** | **DateTimeOffset** | The date and time that the pickup was cancelled in ShipEngine. | [optional] [readonly] 
**ConfirmationNumber** | **string** | The carrier confirmation number for the scheduled pickup. | [readonly] 
**PickupNotes** | **string** | Used by some carriers to give special instructions for a package pickup | [optional] 
**PickupWindows** | [**List&lt;PickupWindows&gt;**](PickupWindows.md) | An array of available pickup windows. Carriers can return multiple times that they will pickup packages.  | [optional] [readonly] 

