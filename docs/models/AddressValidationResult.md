# ShipEngineSDK.Model.AddressValidationResult
An address validation result

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Messages** | [**List&lt;ResponseMessage&gt;**](ResponseMessage.md) | The list of messages that were generated during the address validation request. | [readonly] 
**OriginalAddress** | [**Address**](Address.md) | The original address that was sent for validation | 
**Status** | **AddressValidationStatus** |  | 
**MatchedAddress** | [**Address**](Address.md) | The matched address found by the Shipengine API | [readonly] 

