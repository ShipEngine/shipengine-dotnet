# ShipEngineSDK.Model.TrackEvent
A track event

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CarrierDetailCode** | **string** | Carrier detail code | [readonly] 
**CarrierStatusCode** | **string** | Carrier status code | [readonly] 
**CarrierStatusDescription** | **string** | carrier status description | [readonly] 
**CityLocality** | **string** | City locality | [readonly] 
**OccurredAt** | **DateTimeOffset** | Timestamp for carrier event | 
**PostalCode** | **string** | Postal code | [readonly] 
**StateProvince** | **string** | State province | [readonly] 
**StatusCode** | **StatusCode** |  | 
**StatusDescription** | **string** | Event Status Description | [readonly] 
**CarrierOccurredAt** | **DateTimeOffset** | Carrier timestamp for the event, it is assumed to be the local time of where the event occurred. | [optional] 
**CompanyName** | **string** | Company Name | [optional] [readonly] 
**CountryCode** | **string** | A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1)  | [optional] 
**Description** | **string** | Event description | [optional] [readonly] 
**EventCode** | **string** | Event Code | [optional] 
**Latitude** | **double** | Latitude coordinate of tracking event. | [optional] 
**Longitude** | **double** | Longitude coordinate of tracking event. | [optional] 
**Signer** | **string** | Signer information | [optional] [readonly] 
**StatusDetailCode** | **StatusDetailCode** |  | [optional] 
**StatusDetailDescription** | **string** | Event Status Detail Description | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

