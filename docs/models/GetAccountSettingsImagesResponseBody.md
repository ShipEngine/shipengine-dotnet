# ShipEngineSDK.Model.GetAccountSettingsImagesResponseBody
A get account images by id response body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTimeOffset** | The date and time that the image was created in ShipEngine. | [optional] [readonly] 
**ImageContentType** | **string** | The image type | [optional] 
**ImageData** | **string** | A base64 encoded string representation of the image.  | [optional] 
**IsDefault** | **bool** | Indicates whether this image is set as default.  | [optional] 
**LabelImageId** | **string** | A string that uniquely identifies the image. This ID is generated by ShipEngine when the image is uploaded.  | [optional] [readonly] 
**ModifiedAt** | **DateTimeOffset** | The date and time that the image was modified in ShipEngine. | [optional] [readonly] 
**Name** | **string** | A human readable name for the image.  | [optional] 

