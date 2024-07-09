# ShipEngineSDK.Model.VoidLabelResponseBody
A void label response body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Approved** | **bool** | Indicates whether the attempt to void the label was successful | [readonly] 
**Message** | **string** |  | [readonly] 
**ReasonCode** | **ReasonCode** | Indicates a normalized reason for the conditions if the void attempt was not approved. Will not populate if approved is true. â€œunknownâ€ codes may be specified later. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

