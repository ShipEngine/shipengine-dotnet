using System.Runtime.Serialization;

namespace ShipEngineSDK.Common.Enums
{
    /// <summary>
    /// Delivery Confirmation for your shipments
    /// <see href="https://www.shipengine.com/docs/shipping/delivery-confirmation/" />
    /// </summary>
    public enum DeliveryConfirmation
    {
        /// <summary>
        /// No confirmation requested.
        /// </summary>
        None,

        /// <summary>
        /// Delivery confirmation is requested.
        /// </summary>
        Delivery,

        /// <summary>
        /// Signature is required for the shipment to be delivered; this signature may be a neighbor,
        /// building manager, or the recipient can authorize the release of the package (without being present).
        /// </summary>
        Signature,

        /// <summary>
        /// An adult signature is required for the shipment to be delivered.
        /// </summary>
        [EnumMember(Value = "adult_signature")]
        AdultSignature,

        /// <summary>
        /// A signature of somebody at the address is required. This confirmation is only supported by FedEx.
        /// </summary>
        [EnumMember(Value = "direct_signature")]
        DirectSignature,

        /// <summary>
        /// Receive a delivery confirmation via mail. Currently only supported for UPS. There's a $2 charge for this service.
        /// </summary>
        [EnumMember(Value = "delivery_mailed")]
        DeliveryMailed
    }
}