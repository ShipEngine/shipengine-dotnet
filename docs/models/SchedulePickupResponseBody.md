# ShipEngineSDK.Model.SchedulePickupResponseBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | The errors associated with the failed API call | [readonly] 
**RequestId** | **Guid** | A UUID that uniquely identifies the request id. This can be given to the support team to help debug non-trivial issues that may occur  | 
**CancelledAt** | **DateTimeOffset** | The date and time that the pickup was cancelled in ShipEngine. | [optional] [readonly] 
**CarrierId** | **string** | The carrier_id associated with the pickup | [optional] [readonly] 
**ConfirmationNumber** | **string** | The carrier confirmation number for the scheduled pickup. | [optional] [readonly] 
**ContactDetails** | [**ContactDetails**](ContactDetails.md) |  | [optional] 
**CreatedAt** | **DateTimeOffset** | The date and time that the pickup was created in ShipEngine. | [optional] [readonly] 
**LabelIds** | **List&lt;string&gt;** | Label IDs that will be included in the pickup request | [optional] 
**PickupAddress** | [**Address**](Address.md) |  | [optional] [readonly] 
**PickupId** | **string** | Pickup Resource ID | [optional] [readonly] 
**PickupNotes** | **string** | Used by some carriers to give special instructions for a package pickup | [optional] 
**PickupWindow** | [**PickupWindow**](PickupWindow.md) |  | [optional] 
**PickupWindows** | [**List&lt;PickupWindows&gt;**](PickupWindows.md) | An array of available pickup windows. Carriers can return multiple times that they will pickup packages.  | [optional] [readonly] 
**WarehouseId** | **string** | The warehouse_id associated with the pickup | [optional] [readonly] 

