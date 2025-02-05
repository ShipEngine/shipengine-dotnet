# ShipEngineSDK.Model.SchedulePickupRequestBody
A schedule pickup request body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContactDetails** | [**ContactDetails**](ContactDetails.md) |  | 
**LabelIds** | **List&lt;string&gt;** | Label IDs that will be included in the pickup request | 
**PickupWindow** | [**PickupWindow**](PickupWindow.md) |  | 
**CancelledAt** | **DateTimeOffset** | The date and time that the pickup was cancelled in ShipEngine. | [optional] [readonly] 
**CarrierId** | **string** | The carrier_id associated with the pickup | [optional] [readonly] 
**ConfirmationNumber** | **string** | The carrier confirmation number for the scheduled pickup. | [optional] [readonly] 
**CreatedAt** | **DateTimeOffset** | The date and time that the pickup was created in ShipEngine. | [optional] [readonly] 
**PickupAddress** | [**Address**](Address.md) |  | [optional] [readonly] 
**PickupId** | **string** | Pickup Resource ID | [optional] [readonly] 
**PickupNotes** | **string** | Used by some carriers to give special instructions for a package pickup | [optional] 
**PickupWindows** | [**List&lt;PickupWindows&gt;**](PickupWindows.md) | An array of available pickup windows. Carriers can return multiple times that they will pickup packages.  | [optional] [readonly] 
**WarehouseId** | **string** | The warehouse_id associated with the pickup | [optional] [readonly] 

