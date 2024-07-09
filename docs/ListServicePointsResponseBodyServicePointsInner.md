# ShipEngineSDK.Model.ListServicePointsResponseBodyServicePointsInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CarrierCode** | **string** | A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  | [optional] 
**ServiceCodes** | **List&lt;string&gt;** |  | [optional] 
**ServicePointId** | **string** | A unique identifier for a carrier drop off point. | [optional] 
**CompanyName** | **string** | If this is a business address, then the company name should be specified here. | [optional] 
**AddressLine1** | **string** | The first line of the street address.  For some addresses, this may be the only line.  Other addresses may require 2 or 3 lines. | [optional] 
**CityLocality** | **string** | The name of the city or locality | [optional] 
**StateProvince** | **string** | The state or province. For some countries (including the U.S.) only abbreviations are allowed. Other countries allow the full name or abbreviation. | [optional] 
**PostalCode** | **string** | postal code | [optional] 
**CountryCode** | **string** | A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1)  | [optional] 
**PhoneNumber** | **string** | Phone number associated | [optional] 
**Lat** | **double** | The latitude of the point. Represented as signed degrees. Required if long is provided. http://www.geomidpoint.com/latlon.html | [optional] 
**Long** | **double** | The longitude of the point. Represented as signed degrees. Required if lat is provided. http://www.geomidpoint.com/latlon.html | [optional] 
**DistanceInMeters** | **double** | Distance in meters | [optional] 
**HoursOfOperation** | [**ListServicePointsResponseBodyServicePointsInnerHoursOfOperation**](ListServicePointsResponseBodyServicePointsInnerHoursOfOperation.md) |  | [optional] 
**Features** | **List&lt;ListServicePointsResponseBodyServicePointsInner.FeaturesEnum&gt;** | Service features | [optional] 
**Type** | **string** | Service point type | [optional] [default to TypeEnum.Pudo]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

