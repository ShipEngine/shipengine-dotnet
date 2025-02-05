# ShipEngineSDK.Model.TrackingInformation
A tracking information resource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActualDeliveryDate** | **DateTimeOffset** | An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time.  | [optional] 
**CarrierCode** | **string** | A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  | [optional] 
**CarrierDetailCode** | **string** | Carrier detail code | [optional] [readonly] 
**CarrierId** | **int** | The unique ID of the [carrier account](https://www.shipengine.com/docs/carriers/setup/) that was used to create this label  | [optional] [readonly] 
**CarrierStatusCode** | **string** | Carrier status code | [optional] [readonly] 
**CarrierStatusDescription** | **string** | carrier status description | [optional] [readonly] 
**EstimatedDeliveryDate** | **DateTimeOffset** | An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time.  | [optional] 
**Events** | [**List&lt;TrackEvent&gt;**](TrackEvent.md) | The events that have occured during the lifetime of this tracking number. | [optional] [readonly] 
**ExceptionDescription** | **string** | Exception description | [optional] [readonly] 
**ShipDate** | **DateTimeOffset** | An [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) string that represents a date and time.  | [optional] 
**StatusCode** | **StatusCode** |  | [optional] 
**StatusDescription** | **string** | Status description | [optional] [readonly] 
**StatusDetailCode** | **StatusDetailCode** |  | [optional] 
**StatusDetailDescription** | **string** | Status detail description | [optional] [readonly] 
**TrackingNumber** | **string** | A tracking number for a package. The format depends on the carrier. | [optional] 
**TrackingUrl** | **string** | Carrier Tracking Url, if available | [optional] [readonly] 

