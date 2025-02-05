# ShipEngineSDK.Model.ListAccountSettingsImagesResponseBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Images** | **List&lt;Object&gt;** | Image List | [readonly] 
**Links** | [**PaginationLink**](PaginationLink.md) |  | 
**Page** | **int** | The current page number of results.  For example, if there are 80 results, and the page size is 25, then &#x60;page&#x60; could be 1, 2, 3, or 4.  The first three pages would contain 25 items each, and the fourth page would contain the five remaining items. | 
**Pages** | **int** | The total number of pages of results.  For example, if there are 80 results, and the page size is 25, then &#x60;pages&#x60; would be 4.  The first three pages would contain 25 items each, and the fourth page would contain the five remaining items.  If there are no results, then &#x60;pages&#x60; will be zero. | 
**Total** | **int** | The total number of items across all pages of results | 

