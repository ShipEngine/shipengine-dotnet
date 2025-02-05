# ShipEngineSDK.Model.Carrier
A carrier object that represents a provider such as UPS, USPS, DHL, etc that has been tied to the current account. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountNumber** | **string** | The account number that the carrier is connected to. | [optional] [readonly] 
**Balance** | **decimal** | Current available balance | [optional] [readonly] 
**CarrierCode** | **string** | The [shipping carrier](https://www.shipengine.com/docs/carriers/setup/) who will ship the package, such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc.  | [optional] [readonly] 
**CarrierId** | **string** | A string that uniquely identifies the carrier. | [optional] [readonly] 
**DisabledByBillingPlan** | **bool** | The carrier is disabled by the current ShipEngine account&#39;s billing plan. | [optional] [readonly] 
**FriendlyName** | **string** | Screen readable name | [optional] [readonly] 
**FundingSourceId** | **string** | Funding source ID for the carrier | [optional] [readonly] 
**HasMultiPackageSupportingServices** | **bool** | Carrier supports multiple packages per shipment | [optional] [readonly] 
**Nickname** | **string** | Nickname given to the account when initially setting up the carrier. | [optional] [readonly] 
**Options** | [**List&lt;CarrierAdvancedOption&gt;**](CarrierAdvancedOption.md) | A list of options that are available to that carrier | [optional] [readonly] 
**Packages** | [**List&lt;PackageType&gt;**](PackageType.md) | A list of package types that are supported by the carrier | [optional] [readonly] 
**Primary** | **bool** | Is this the primary carrier that is used by default when no carrier is specified in label/shipment creation | [optional] [readonly] 
**RequiresFundedAmount** | **bool** | Indicates whether the carrier requires funding to use its services | [optional] [readonly] 
**Services** | [**List&lt;Service&gt;**](Service.md) | A list of services that are offered by the carrier | [optional] [readonly] 
**SupportsLabelMessages** | **bool** | The carrier supports adding custom label messages to an order. | [optional] [readonly] 

