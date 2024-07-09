# ShipEngineSDK.Model.PickupResponseBody
A pickup response body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PickupId** | **string** | Pickup Resource ID | [readonly] 
**LabelIds** | **List&lt;string&gt;** | Label IDs that will be included in the pickup request | 
**CreatedAt** | **DateTime** | The date and time that the pickup was created in ShipEngine. | [readonly] 
**CancelledAt** | **DateTime** | The date and time that the pickup was cancelled in ShipEngine. | [optional] [readonly] 
**CarrierId** | **string** | The carrier_id associated with the pickup | [readonly] 
**ConfirmationNumber** | **string** | The carrier confirmation number for the scheduled pickup. | [readonly] 
**WarehouseId** | **string** | The warehouse_id associated with the pickup | [readonly] 
**PickupAddress** | [**Address**](Address.md) |  | [readonly] 
**ContactDetails** | [**ContactDetails**](ContactDetails.md) |  | 
**PickupNotes** | **string** | Used by some carriers to give special instructions for a package pickup | [optional] 
**PickupWindow** | [**PickupWindow**](PickupWindow.md) |  | 
**PickupWindows** | [**List&lt;PickupWindows&gt;**](PickupWindows.md) | An array of available pickup windows. Carriers can return multiple times that they will pickup packages.  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

