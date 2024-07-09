# ShipEngineSDK.Model.GetServicePointsRequestBody
A get service points request body. Caller must provide exactly one of address_query, address, or lat / long pair.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressQuery** | **string** | Unstructured text to search for service points by. | [optional] 
**Address** | [**GetServicePointsRequestBodyAddress**](GetServicePointsRequestBodyAddress.md) |  | [optional] 
**Providers** | [**List&lt;GetServicePointsRequestBodyProvidersInner&gt;**](GetServicePointsRequestBodyProvidersInner.md) | An array of shipping service providers and service codes | 
**Lat** | **double** | The latitude of the point. Represented as signed degrees. Required if long is provided. http://www.geomidpoint.com/latlon.html | [optional] 
**Long** | **double** | The longitude of the point. Represented as signed degrees. Required if lat is provided. http://www.geomidpoint.com/latlon.html | [optional] 
**Radius** | **int** | Search radius in kilometers | [optional] 
**MaxResults** | **int** | The maximum number of service points to return | [optional] 
**Shipment** | [**GetServicePointsRequestBodyShipment**](GetServicePointsRequestBodyShipment.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

