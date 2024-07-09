# ShipEngineSDK.Model.UpdatePackageTypeRequestBody
An update package type request body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PackageId** | **string** | A string that uniquely identifies the package. | [optional] 
**PackageCode** | **string** | A [package type](https://www.shipengine.com/docs/reference/list-carrier-packages/), such as &#x60;thick_envelope&#x60;, &#x60;small_flat_rate_box&#x60;, &#x60;large_package&#x60;, etc.  Use the code &#x60;package&#x60; for custom or unknown package types.  | 
**Name** | **string** |  | 
**Dimensions** | [**Dimensions**](Dimensions.md) | The custom dimensions for the package. | [optional] 
**Description** | **string** | Provides a helpful description for the custom package. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

