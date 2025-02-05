# ShipEngineSDK.Model.InternationalShipmentOptions
Options for international shipments, such as customs declarations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Contents** | **PackageContents** | The type of contents in this shipment.  This may impact import duties or customs treatment. | 
**NonDelivery** | **NonDelivery** | Indicates what to do if a package is unable to be delivered. | 
**ContentsExplanation** | **string** | Explanation for contents (required if the &#x60;contents&#x60; is provided as &#x60;other&#x60;) | [optional] 
**CustomsItems** | [**List&lt;CustomsItem&gt;**](CustomsItem.md) | Customs declarations for each item in the shipment. (Please provide this information under &#x60;products&#x60; inside &#x60;packages&#x60;) | [optional] 
**Declaration** | **string** | Declaration statement to be placed on the commercial invoice | [optional] 
**ImporterOfRecord** | [**ImporterOfRecords**](ImporterOfRecords.md) |  | [optional] 
**InvoiceAdditionalDetails** | [**InvoiceAdditionalDetails**](InvoiceAdditionalDetails.md) |  | [optional] 
**TermsOfTradeCode** | **AllowedIncoterms** | Specifies the supported terms of trade code (incoterms) | [optional] 

