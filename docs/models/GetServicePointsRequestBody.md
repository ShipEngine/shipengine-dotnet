# ShipEngineSDK.Model.GetServicePointsRequestBody
A get service points request body. Caller must provide exactly one of address_query, address, or lat / long pair.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Providers** | [**List&lt;GetServicePointsRequestBodyProvidersInner&gt;**](GetServicePointsRequestBodyProvidersInner.md) | An array of shipping service providers and service codes | 
**Address** | [**GetServicePointsRequestBodyAddress**](GetServicePointsRequestBodyAddress.md) |  | [optional] 
**AddressQuery** | **string** | Unstructured text to search for service points by. | [optional] 
**Lat** | **double** | The latitude of the point. Represented as signed degrees. Required if long is provided. http://www.geomidpoint.com/latlon.html | [optional] 
**Long** | **double** | The longitude of the point. Represented as signed degrees. Required if lat is provided. http://www.geomidpoint.com/latlon.html | [optional] 
**MaxResults** | **int** | The maximum number of service points to return | [optional] 
**Radius** | **int** | Search radius in kilometers | [optional] 
**Shipment** | [**GetServicePointsRequestBodyShipment**](GetServicePointsRequestBodyShipment.md) |  | [optional] 

