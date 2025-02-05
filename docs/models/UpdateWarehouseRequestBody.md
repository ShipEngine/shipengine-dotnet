# ShipEngineSDK.Model.UpdateWarehouseRequestBody
An update warehouse request body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the warehouse | 
**OriginAddress** | [**Address**](Address.md) | The origin address of the warehouse | 
**CreatedAt** | **DateTimeOffset** | Timestamp that indicates when the warehouse was created | [optional] [readonly] 
**IsDefault** | **bool** | Designates which single warehouse is the default on the account | [optional] [default to false]
**ReturnAddress** | [**Address**](Address.md) | The return address associated with the warehouse | [optional] 
**WarehouseId** | **string** | A string that uniquely identifies the warehouse | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

