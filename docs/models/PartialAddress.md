# ShipEngineSDK.Model.PartialAddress
A complete or partial mailing address.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | The first line of the street address.  For some addresses, this may be the only line.  Other addresses may require 2 or 3 lines.  | [optional] 
**AddressLine2** | **string** | The second line of the street address.  For some addresses, this line may not be needed.  | [optional] 
**AddressLine3** | **string** | The third line of the street address.  For some addresses, this line may not be needed.  | [optional] 
**AddressResidentialIndicator** | **AddressResidentialIndicator** | Indicates whether this is a residential address. | [optional] 
**CityLocality** | **string** | The name of the city or locality | [optional] 
**CompanyName** | **string** | If this is a business address, then the company name should be specified here.  | [optional] 
**CountryCode** | **string** | The two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1)  | [optional] 
**Email** | **string** | Email for the address owner.  | [optional] 
**Name** | **string** | The name of a contact person at this address.  This field may be set instead of - or in addition to - the &#x60;company_name&#x60; field.  | [optional] 
**Phone** | **string** | The phone number of a contact person at this address.  The format of this phone number varies depending on the country.  | [optional] 
**PostalCode** | **string** | postal code | [optional] 
**StateProvince** | **string** | The state or province.  For some countries (including the U.S.) only abbreviations are allowed.  Other countries allow the full name or abbreviation.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

