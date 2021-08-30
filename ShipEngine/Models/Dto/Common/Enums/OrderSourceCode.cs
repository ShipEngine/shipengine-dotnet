using System.Runtime.Serialization;

namespace ShipEngineSDK.Common.Enums
{
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
}