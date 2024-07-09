# ShipEngineSDK.Model.AddressValidationResult
An address validation result

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **AddressValidationStatus** |  | 
**OriginalAddress** | [**Address**](Address.md) | The original address that was sent for validation | 
**MatchedAddress** | [**Address**](Address.md) | The matched address found by the Shipengine API | [readonly] 
**Messages** | [**List&lt;ResponseMessage&gt;**](ResponseMessage.md) | The list of messages that were generated during the address validation request. | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

