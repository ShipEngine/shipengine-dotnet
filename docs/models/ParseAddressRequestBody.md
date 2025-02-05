# ShipEngineSDK.Model.ParseAddressRequestBody
The only required field is `text`, which is the text to be parsed. You can optionally also provide an `address` containing already-known values. For example, you may already know the recipient's name, city, and country, and only want to parse the street address into separate lines. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | The unstructured text that contains address-related entities | 
**Address** | [**PartialAddress**](PartialAddress.md) | You can optionally provide any already-known address values. For example, you may already know the recipient&#39;s name, city, and country, and only want to parse the street address into separate lines.  | [optional] 

