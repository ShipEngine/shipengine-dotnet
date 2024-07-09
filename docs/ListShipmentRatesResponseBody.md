# ShipEngineSDK.Model.ListShipmentRatesResponseBody
A list shipment rates response body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rates** | [**List&lt;Rate&gt;**](Rate.md) | An array of shipment rates | [readonly] 
**InvalidRates** | [**List&lt;Rate&gt;**](Rate.md) | An array of invalid shipment rates | [readonly] 
**RateRequestId** | **string** | A string that uniquely identifies the rate request | [readonly] 
**ShipmentId** | **string** | A string that uniquely identifies the shipment | [readonly] 
**CreatedAt** | **string** | When the rate was created | 
**Status** | **RateResponseStatus** |  | [readonly] 
**Errors** | [**List&lt;Error&gt;**](Error.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

