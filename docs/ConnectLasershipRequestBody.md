# ShipEngineSDK.Model.ConnectLasershipRequestBody
A Lasership account information request body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Nickname** | **string** | Nickname | 
**WebServicesId** | **string** | Web Service ID (WSID) | 
**WebServicesKey** | **string** | Web Service Key (WSKey) | 
**CustomerBranch** | **string** | Customer Branch | 
**Address** | **String** | Address | 
**Address2** | **String** | Address2 | [optional] 
**PostalCode** | **String** | PostalCode | 
**City** | **String** | City | 
**State** | **String** | State | 
**Country** | **String** | Country | [optional] 
**Phone** | **String** | Phone | [optional] 
**Email** | **String** | Email | [optional] 
**Instructions** | **String** | Instructions | [optional] 
**FacilityCode** | **String** | Facility Code | [optional] 
**LasershipCriticalPullTime** | **String** | Critical Pull Time (local time) | 
**LasershipCriticalEntryTime** | **String** | Critical Entry Time (local time) | 
**DeclarePieceAttributesSeparatelyForEveryShipment** | **Boolean** | Declare piece attributes separately for every shipment, overrides individual attribute below. | [optional] 
**AttrAlcohol** | **Boolean** | Set this to true if your shipments will always contain Alcohol | [optional] 
**AttrDryIce** | **Boolean** | Set this to true if your shipments will always contain DryIce | [optional] 
**AttrHazmat** | **Boolean** | Set this to true if your shipments will always contain Hazmat | [optional] 
**AttrTwoPersons** | **Boolean** | Set this to true if your shipments will always require Two Persons | [optional] 
**AttrExplosive** | **Boolean** | Set this to true if your shipments will always contain Explosives | [optional] 
**AttrControlledSubstance** | **Boolean** | Set this to true if your shipments will always contain Controlled Substances | [optional] 
**AttrRefrigerated** | **Boolean** | Set this to true if your shipments will always require Refrigeration | [optional] 
**AttrPerishable** | **Boolean** | Set this to true if your shipments will always be Perishable | [optional] 
**AttrNoRTS** | **Boolean** | Set this to true if your shipments will always use \&quot;No Return To Sender\&quot; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

