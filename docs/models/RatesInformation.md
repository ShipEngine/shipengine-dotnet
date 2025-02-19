# ShipEngineSDK.Model.RatesInformation
A rates information resource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **string** | When the rate was created | [optional] 
**Errors** | [**List&lt;Error&gt;**](Error.md) |  | [optional] 
**InvalidRates** | [**List&lt;Rate&gt;**](Rate.md) | An array of invalid shipment rates | [optional] [readonly] 
**RateRequestId** | **string** | A string that uniquely identifies the rate request | [optional] [readonly] 
**Rates** | [**List&lt;Rate&gt;**](Rate.md) | An array of shipment rates | [optional] [readonly] 
**ShipmentId** | **string** | A string that uniquely identifies the shipment | [optional] [readonly] 
**Status** | **RateResponseStatus** |  | [optional] [readonly] 

