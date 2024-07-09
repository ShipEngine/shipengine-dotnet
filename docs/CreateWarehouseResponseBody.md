# ShipEngineSDK.Model.CreateWarehouseResponseBody
A create warehouse response body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WarehouseId** | **string** | A string that uniquely identifies the warehouse | [readonly] 
**IsDefault** | **bool?** | Designates which single warehouse is the default on the account | [optional] [default to false]
**Name** | **string** | Name of the warehouse | 
**CreatedAt** | **DateTime** | Timestamp that indicates when the warehouse was created | [readonly] 
**OriginAddress** | [**Address**](Address.md) | The origin address of the warehouse | 
**ReturnAddress** | [**Address**](Address.md) | The return address associated with the warehouse | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

