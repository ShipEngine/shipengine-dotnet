# ShipEngineSDK.Model.DangerousGoods
Dangerous goods attribute associated with the product 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalDescription** | **string** | Provider additonal description regarding the dangerous goods. This is used as a placed holder to provider additional context and varies by carrier | [optional] 
**DangerousAmount** | [**DangerousAmount**](DangerousAmount.md) | This model represents the amount of the dangerous goods. | [optional] 
**IdNumber** | **string** | UN number to identify the dangerous goods. | [optional] 
**PackagingGroup** | **PackagingGroup** |  | [optional] 
**PackagingInstruction** | **string** | The specific standardized packaging instructions from the relevant regulatory agency that have been applied to the parcel/container. | [optional] 
**PackagingInstructionSection** | **PackagingInstructionSection** |  | [optional] 
**PackagingType** | **string** | The type of exterior packaging used to contain the dangerous good. | [optional] 
**ProductClass** | **string** | Dangerous goods product class based on regulation. | [optional] 
**ProductClassSubsidiary** | **string** | A secondary of product class for substances presenting more than one particular hazard | [optional] 
**Quantity** | **int** | Quantity of dangerous goods. | [optional] [default to 0]
**Radioactive** | **bool** | Indication if the substance is radioactive. | [optional] 
**RegulationAuthority** | **string** | Name of the regulatory authority. | [optional] 
**RegulationLevel** | **RegulationLevel** |  | [optional] 
**ReportableQuantity** | **bool** | Indication if the substance needs to be reported to regulatory authority based on the quantity. | [optional] 
**ShippingName** | **string** | Trade description of the dangerous goods. | [optional] 
**TechnicalName** | **string** | Recognized Technical or chemical name of dangerous goods. | [optional] 
**TransportCategory** | **string** | Transport category assign to dangerous goods for the transport purpose. | [optional] 
**TransportMean** | **TransportMean** |  | [optional] 
**TunnelCode** | **string** | Defines which types of tunnels the shipment is allowed to go through | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

