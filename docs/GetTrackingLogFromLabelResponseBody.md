# ShipEngineSDK.Model.GetTrackingLogFromLabelResponseBody
A get tracking log from label response body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TrackingNumber** | **string** | A tracking number for a package. The format depends on the carrier. | 
**TrackingUrl** | **string** | Carrier Tracking Url, if available | [optional] [readonly] 
**StatusCode** | **StatusCode** |  | 
**CarrierCode** | **string** | A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  | [optional] 
**CarrierId** | **string** | A string that uniquely identifies a ShipEngine resource, such as a carrier, label, shipment, etc. | [optional] 
**StatusDescription** | **string** | Status description | [optional] [readonly] 
**CarrierStatusCode** | **string** | Carrier status code | [readonly] 
**CarrierDetailCode** | **string** | Carrier detail code | [optional] [readonly] 
**CarrierStatusDescription** | **string** | carrier status description | [optional] [readonly] 
**ShipDate** | **DateTime** | An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time.  | [optional] 
**EstimatedDeliveryDate** | **DateTime** | An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time.  | 
**ActualDeliveryDate** | **DateTime** | An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time.  | [optional] 
**ExceptionDescription** | **string** | Exception description | [optional] [readonly] 
**Events** | [**List&lt;TrackEvent&gt;**](TrackEvent.md) | The events that have occured during the lifetime of this tracking number. | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

