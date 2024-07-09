/*
 * ShipEngine API
 *
 * ShipEngine's easy-to-use REST API lets you manage all of your shipping needs without worrying about the complexities of different carrier APIs and protocols. We handle all the heavy lifting so you can focus on providing a first-class shipping experience for your customers at the best possible prices.  Each of ShipEngine's features can be used by itself or in conjunction with each other to build powerful shipping functionality into your application or service.  ## Getting Started If you're new to REST APIs then be sure to read our [introduction to REST](https://www.shipengine.com/docs/rest/) to understand the basics.  Learn how to [authenticate yourself to ShipEngine](https://www.shipengine.com/docs/auth/), and then use our [sandbox environment](https://www.shipengine.com/docs/sandbox/) to kick the tires and get familiar with our API. If you run into any problems, then be sure to check the [error handling guide](https://www.shipengine.com/docs/errors/) for tips.  Here are some step-by-step **tutorials** to get you started:    - [Learn how to create your first shipping label](https://www.shipengine.com/docs/labels/create-a-label/)   - [Calculate shipping costs and compare rates across carriers](https://www.shipengine.com/docs/rates/)   - [Track packages on-demand or in real time](https://www.shipengine.com/docs/tracking/)   - [Validate mailing addresses anywhere on Earth](https://www.shipengine.com/docs/addresses/validation/)   ## Shipping Labels for Every Major Carrier ShipEngine makes it easy to [create shipping labels for any carrier](https://www.shipengine.com/docs/labels/create-a-label/) and [download them](https://www.shipengine.com/docs/labels/downloading/) in a [variety of file formats](https://www.shipengine.com/docs/labels/formats/). You can even customize labels with your own [messages](https://www.shipengine.com/docs/labels/messages/) and [images](https://www.shipengine.com/docs/labels/branding/).   ## Real-Time Package Tracking With ShipEngine you can [get the current status of a package](https://www.shipengine.com/docs/tracking/) or [subscribe to real-time tracking updates](https://www.shipengine.com/docs/tracking/webhooks/) via webhooks. You can also create [custimized tracking pages](https://www.shipengine.com/docs/tracking/branded-tracking-page/) with your own branding so your customers will always know where their package is.   ## Compare Shipping Costs Across Carriers Make sure you ship as cost-effectively as possible by [comparing rates across carriers](https://www.shipengine.com/docs/rates/get-shipment-rates/) using the ShipEngine Rates API. Or if you don't know the full shipment details yet, then you can [get rate estimates](https://www.shipengine.com/docs/rates/estimate/) with limited address info.   ## Worldwide Address Validation ShipEngine supports [address validation](https://www.shipengine.com/docs/addresses/validation/) for virtually [every country on Earth](https://www.shipengine.com/docs/addresses/validation/countries/), including the United States, Canada, Great Britain, Australia, Germany, France, Norway, Spain, Sweden, Israel, Italy, and over 160 others. 
 *
 * The version of the OpenAPI document: 1.1.202406212006
 * Contact: sales@shipengine.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Text.RegularExpressions;

namespace ShipEngineSDK.Model;

/// <summary>
/// The order sources that are supported by ShipEngine
/// </summary>
/// <value>The order sources that are supported by ShipEngine</value>
[JsonConverter(typeof(OrderSourceNameJsonConverter))]
public class OrderSourceName
{
    private string _value;

    internal OrderSourceName() {
        _value = "amazon_ca";
    }

    /// <summary>
    /// Create a new instance of OrderSourceName with a custom value.
    /// </summary>
    /// <param name="value">The value of the OrderSourceName</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public OrderSourceName(string value) {
      _value = value;
    }

    /// <summary>
    /// Enum AmazonCa for value: amazon_ca
    /// </summary>
    public static OrderSourceName AmazonCa { get; } = new("amazon_ca");


    /// <summary>
    /// Enum AmazonUs for value: amazon_us
    /// </summary>
    public static OrderSourceName AmazonUs { get; } = new("amazon_us");


    /// <summary>
    /// Enum Brightpearl for value: brightpearl
    /// </summary>
    public static OrderSourceName Brightpearl { get; } = new("brightpearl");


    /// <summary>
    /// Enum ChannelAdvisor for value: channel_advisor
    /// </summary>
    public static OrderSourceName ChannelAdvisor { get; } = new("channel_advisor");


    /// <summary>
    /// Enum Cratejoy for value: cratejoy
    /// </summary>
    public static OrderSourceName Cratejoy { get; } = new("cratejoy");


    /// <summary>
    /// Enum Ebay for value: ebay
    /// </summary>
    public static OrderSourceName Ebay { get; } = new("ebay");


    /// <summary>
    /// Enum Etsy for value: etsy
    /// </summary>
    public static OrderSourceName Etsy { get; } = new("etsy");


    /// <summary>
    /// Enum Jane for value: jane
    /// </summary>
    public static OrderSourceName Jane { get; } = new("jane");


    /// <summary>
    /// Enum GrouponGoods for value: groupon_goods
    /// </summary>
    public static OrderSourceName GrouponGoods { get; } = new("groupon_goods");


    /// <summary>
    /// Enum Magento for value: magento
    /// </summary>
    public static OrderSourceName Magento { get; } = new("magento");


    /// <summary>
    /// Enum Paypal for value: paypal
    /// </summary>
    public static OrderSourceName Paypal { get; } = new("paypal");


    /// <summary>
    /// Enum SellerActive for value: seller_active
    /// </summary>
    public static OrderSourceName SellerActive { get; } = new("seller_active");


    /// <summary>
    /// Enum Shopify for value: shopify
    /// </summary>
    public static OrderSourceName Shopify { get; } = new("shopify");


    /// <summary>
    /// Enum StitchLabs for value: stitch_labs
    /// </summary>
    public static OrderSourceName StitchLabs { get; } = new("stitch_labs");


    /// <summary>
    /// Enum Squarespace for value: squarespace
    /// </summary>
    public static OrderSourceName Squarespace { get; } = new("squarespace");


    /// <summary>
    /// Enum ThreeDcart for value: three_dcart
    /// </summary>
    public static OrderSourceName ThreeDcart { get; } = new("three_dcart");


    /// <summary>
    /// Enum Tophatter for value: tophatter
    /// </summary>
    public static OrderSourceName Tophatter { get; } = new("tophatter");


    /// <summary>
    /// Enum Walmart for value: walmart
    /// </summary>
    public static OrderSourceName Walmart { get; } = new("walmart");


    /// <summary>
    /// Enum WooCommerce for value: woo_commerce
    /// </summary>
    public static OrderSourceName WooCommerce { get; } = new("woo_commerce");


    /// <summary>
    /// Enum Volusion for value: volusion
    /// </summary>
    public static OrderSourceName Volusion { get; } = new("volusion");


    public override string ToString() => _value;
}

internal class OrderSourceNameJsonConverter : JsonConverter<OrderSourceName>
{
    public override OrderSourceName? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new OrderSourceName(reader.GetString()) : null;

    public override void Write(Utf8JsonWriter writer, OrderSourceName value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(OrderSourceName);
}
