# ShipEngineSDK.Model.RatesInformation
A rates information resource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rates** | [**List&lt;Rate&gt;**](Rate.md) | An array of shipment rates | [optional] [readonly] 
**InvalidRates** | [**List&lt;Rate&gt;**](Rate.md) | An array of invalid shipment rates | [optional] [readonly] 
**RateRequestId** | **string** | A string that uniquely identifies the rate request | [optional] [readonly] 
**ShipmentId** | **string** | A string that uniquely identifies the shipment | [optional] [readonly] 
**CreatedAt** | **string** | When the rate was created | [optional] 
**Status** | **RateResponseStatus** |  | [optional] [readonly] 
**Errors** | [**List&lt;Error&gt;**](Error.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

