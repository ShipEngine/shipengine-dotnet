# ShipEngineSDK.Model.GetPickupsResponseBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | The errors associated with the failed API call | [readonly] 
**Links** | [**PaginationLink**](PaginationLink.md) | Helpful links to other pages of results | [readonly] 
**Page** | **int** | Current page of the list pickups results | [readonly] 
**Pages** | **int** | Total number of pages for list pickups results | [readonly] 
**Pickups** | [**List&lt;Pickup&gt;**](Pickup.md) | An array of pickups associated with the user&#39;s account. | 
**RequestId** | **Guid** | A UUID that uniquely identifies the request id. This can be given to the support team to help debug non-trivial issues that may occur  | 
**Total** | **long** | The total number of pickups returned | [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

