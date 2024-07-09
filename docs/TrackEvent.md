# ShipEngineSDK.Model.TrackEvent
A track event

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OccurredAt** | **DateTime** | Timestamp for carrier event | 
**CarrierOccurredAt** | **DateTime** | Carrier timestamp for the event, it is assumed to be the local time of where the event occurred. | [optional] 
**Description** | **string** | Event description | [optional] [readonly] 
**CityLocality** | **string** | City locality | [readonly] 
**StateProvince** | **string** | State province | [readonly] 
**PostalCode** | **string** | Postal code | [readonly] 
**CountryCode** | **string** | A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1)  | [optional] 
**CompanyName** | **string** | Company Name | [optional] [readonly] 
**Signer** | **string** | Signer information | [optional] [readonly] 
**EventCode** | **string** | Event Code | [optional] 
**CarrierDetailCode** | **string** | Carrier detail code | [readonly] 
**StatusCode** | **StatusCode** |  | 
**StatusDescription** | **string** | Event Status Description | [readonly] 
**CarrierStatusCode** | **string** | Carrier status code | [readonly] 
**CarrierStatusDescription** | **string** | carrier status description | [readonly] 
**Latitude** | **double** | Latitude coordinate of tracking event. | [optional] 
**Longitude** | **double** | Longitude coordinate of tracking event. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

