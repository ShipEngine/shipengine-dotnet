# ShipEngineSDK.Model.ListServicePointsResponseBody
A list service points response body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | The errors associated with the failed API call | [optional] [readonly] 
**Lat** | **double** | The latitude of the point. Represented as signed degrees. Required if long is provided. http://www.geomidpoint.com/latlon.html | [optional] 
**Long** | **double** | The longitude of the point. Represented as signed degrees. Required if lat is provided. http://www.geomidpoint.com/latlon.html | [optional] 
**ServicePoints** | [**List&lt;ListServicePointsResponseBodyServicePointsInner&gt;**](ListServicePointsResponseBodyServicePointsInner.md) |  | [optional] 

