# ShipEngineSDK.Model.ImporterOfRecords
importer of records address, anywhere in the world. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | The first line of the street address.  For some addresses, this may be the only line.  Other addresses may require 2 or 3 lines.  | 
**CityLocality** | **string** | The name of the city or locality | 
**CountryCode** | **string** | The two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1)  | 
**Name** | **string** | The name of a contact person at this address. Either &#x60;name&#x60; or the &#x60;company_name&#x60; field should always be set.  | 
**PostalCode** | **string** | postal code | 
**AddressLine2** | **string** | The second line of the street address.  For some addresses, this line may not be needed.  | [optional] 
**AddressLine3** | **string** | The third line of the street address.  For some addresses, this line may not be needed.  | [optional] 
**CompanyName** | **string** | If this is a business address, then the company name should be specified here. Either &#x60;name&#x60; or the &#x60;company_name&#x60; field should always be set.  | [optional] 
**Email** | **string** | Email for the address owner.  | [optional] 
**Phone** | **string** | The phone number of a contact person at this address.  The format of this phone number varies depending on the country.  | [optional] 
**StateProvince** | **string** | The state or province.  For some countries (including the U.S.) only abbreviations are allowed.  Other countries allow the full name or abbreviation.  | [optional] 

