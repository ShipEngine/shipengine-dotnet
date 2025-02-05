# ShipEngineSDK.Model.PaginationLink
Helpful links to other pages of results

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**First** | [**Link**](Link.md) | The link to the first page of results.  This object will _always_ have an &#x60;href&#x60; field. If there are no results, then the first page will contain an empty array of items.  | 
**Last** | [**Link**](Link.md) | The link to the final page of results.  This object will _always_ have an &#x60;href&#x60; field. If there are no results, then the final page will contain an empty array of items.  | 
**Next** | [**OptionalLink**](OptionalLink.md) | The link to the next page of results.  The &#x60;href&#x60; field will only be set when the &#x60;page&#x60; is less than &#x60;pages&#x60;.  | 
**Prev** | [**OptionalLink**](OptionalLink.md) | The link to the previous page of results.  The &#x60;href&#x60; field will only be set when the &#x60;page&#x60; is 2 or greater.  | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

