# ShipEngineSDK.Model.ListServicePointsResponseBody
A list service points response body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Lat** | **double** | The latitude of the point. Represented as signed degrees. Required if long is provided. http://www.geomidpoint.com/latlon.html | [optional] 
**Long** | **double** | The longitude of the point. Represented as signed degrees. Required if lat is provided. http://www.geomidpoint.com/latlon.html | [optional] 
**ServicePoints** | [**List&lt;ListServicePointsResponseBodyServicePointsInner&gt;**](ListServicePointsResponseBodyServicePointsInner.md) |  | [optional] 
**Errors** | [**List&lt;Error&gt;**](Error.md) | The errors associated with the failed API call | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

