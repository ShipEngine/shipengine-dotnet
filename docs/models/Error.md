# ShipEngineSDK.Model.Error
The error structure that gets returned with almost all failed API calls 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ErrorCode** | **ErrorCode** |  | 
**ErrorSource** | **ErrorSource** |  | 
**ErrorType** | **ErrorType** |  | 
**Message** | **string** | An error message associated with the failed API call | [readonly] 
**CarrierCode** | **string** | The name of the [shipping carrier](https://www.shipengine.com/docs/carriers/setup/) that generated the error, such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  | [optional] [readonly] 
**CarrierId** | **string** | A string that uniquely identifies the carrier that generated the error. | [optional] [readonly] 
**FieldName** | **string** | The name of the field that caused the error | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

