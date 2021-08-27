using System.Runtime.Serialization;

namespace ShipEngineSDK.CreateLabelFromRate
{
    public enum ChargeEvent
    {
        [EnumMember(Value = "carrier_default")]
        CarrierDefault,

        [EnumMember(Value = "on_creation")]
        OnCreation,

        [EnumMember(Value = "on_carrier_acceptance")]
        OnCarrierAcceptance
    }

    public enum LabelStatus
    {
        Processing,
        Completed,
        Error,
        Voided
    }

    public enum DisplayScheme
    {
        Label,

        [EnumMember(Value = "qr_code")]
        QRCode
    }

    public enum LabelLayout
    {
        Letter,

        [EnumMember(Value = "4x6")]
        FourBySix
    }

    public enum LabelFormat
    {
        PDF,
        PNG,
        ZPL
    }

    public enum TrackingStatus
    {
        Unknown,

        [EnumMember(Value = "in_transit")]
        InTransit,
        Error,
        Delivered
    }

    public enum LabelDownloadType
    {
        Url,
        Inline,
    }

    public enum ValidateAddress
    {
        [EnumMember(Value = "no_validation")]
        NoValidation,

        [EnumMember(Value = "validate_only")]
        ValidateOnly,

        [EnumMember(Value = "validate_and_clean")]
        ValidateAndClean,
    }

    public enum DeliveryConfirmation
    {
        None,
        Delivery,
        Signature,

        [EnumMember(Value = "adult_signature")]
        AdultSignature,

        [EnumMember(Value = "direct_signature")]
        DirectSignature,

        [EnumMember(Value = "delivery_mailed")]
        DeliveryMailed
    }

    public enum InsuranceProvider
    {
        None,
        Shipsurance,
        Carrier,

        [EnumMember(Value = "third_party")]
        ThirdParty
    }

    public enum OriginType
    {
        Pickup,

        [EnumMember(Value = "drop_off")]
        DropOff
    }

    public enum TaxableEntityType
    {
        Shipper,
        Recipient
    }

    public enum IdentifierType
    {
        Vat,
        Eori,
        SSN,
        Ein,
        Tin,
        Ioss,
        Pan,
        Voec
    }

    public enum PaymentType
    {
        Any,
        Cash,

        [EnumMember(Value = "cash_equivalent")]
        CashEquivalent,
        None
    }

    public enum OrderSourceCode
    {
        [EnumMember(Value = "amazon_ca")]
        AmazonCA,

        [EnumMember(Value = "amazon_us")]
        AmazonUS,

        Brightpearl,


        [EnumMember(Value = "channel_advisor")]
        ChannelAdvisor,
        Cratejoy,
        Ebay,
        Etsy,
        Jane,

        [EnumMember(Value = "groupon_goods")]
        GrouponGoods,
        Magento,
        Paypal,

        [EnumMember(Value = "seller_activity")]
        SellerActivity,
        Shopify,

        [EnumMember(Value = "stitch_labs")]
        StitchLabs,
        Squarespace,

        [EnumMember(Value = "three_dcart")]
        ThreeDCart,
        Tophatter,
        Walmart,

        [EnumMember(Value = "woo_commerce")]
        WooCommerce,
        Volusion,
    }

    public enum NonDelivery
    {
        [EnumMember(Value = "return_to_sender")]
        ReturnToSender,

        [EnumMember(Value = "treat_as_abandoned")]
        TreatAsAbandoned
    }

    public enum PackageContents
    {
        Merchandise,
        Documents,
        Gift,

        [EnumMember(Value = "returned_goods")]
        ReturnedGoods,
        Sample
    }

    public enum BillToParty
    {
        Recipient,

        [EnumMember(Value = "third_party")]
        ThirdParty
    }

    public enum AddressResidentialIndicator
    {
        [EnumMember(Value = "unknown")]
        Unknown,

        [EnumMember(Value = "yes")]
        Yes,

        [EnumMember(Value = "no")]
        No,
    }

}