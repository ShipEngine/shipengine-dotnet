# ShipEngineSDK.Model.CompareBulkRatesRequestBody
A rate shipments request body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RateOptions** | [**RateRequestBody**](RateRequestBody.md) | The rate options | 
**ShipFromServicePointId** | **string** | A unique identifier for a carrier drop off point where a merchant plans to deliver packages. This will take precedence over a shipment&#39;s ship from address. | [optional] 
**ShipToServicePointId** | **string** | A unique identifier for a carrier service point where the shipment will be delivered by the carrier. This will take precedence over a shipment&#39;s ship to address. | [optional] 

