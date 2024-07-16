/*
 * ShipEngine API
 *
 * The version of the OpenAPI document: 1.1.202406212006
 * Contact: sales@shipengine.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Text.RegularExpressions;

namespace ShipEngineSDK.Model;

/// <summary>
/// The shipping carriers that are supported by ShipEngine
/// </summary>
/// <value>The shipping carriers that are supported by ShipEngine</value>
[JsonConverter(typeof(CarrierNameJsonConverter))]
public class CarrierName
{
    private string _value;

    internal CarrierName()
    {
        _value = "access_worldwide";
    }

    /// <summary>
    /// Create a new instance of CarrierName with a custom value.
    /// </summary>
    /// <param name="value">The value of the CarrierName</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public CarrierName(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum AccessWorldwide for value: access_worldwide
    /// </summary>
    public static CarrierName AccessWorldwide { get; } = new("access_worldwide");


    /// <summary>
    /// Enum AmazonBuyShipping for value: amazon_buy_shipping
    /// </summary>
    public static CarrierName AmazonBuyShipping { get; } = new("amazon_buy_shipping");


    /// <summary>
    /// Enum AmazonShippingUk for value: amazon_shipping_uk
    /// </summary>
    public static CarrierName AmazonShippingUk { get; } = new("amazon_shipping_uk");


    /// <summary>
    /// Enum Apc for value: apc
    /// </summary>
    public static CarrierName Apc { get; } = new("apc");


    /// <summary>
    /// Enum Asendia for value: asendia
    /// </summary>
    public static CarrierName Asendia { get; } = new("asendia");


    /// <summary>
    /// Enum AustraliaPost for value: australia_post
    /// </summary>
    public static CarrierName AustraliaPost { get; } = new("australia_post");


    /// <summary>
    /// Enum CanadaPost for value: canada_post
    /// </summary>
    public static CarrierName CanadaPost { get; } = new("canada_post");


    /// <summary>
    /// Enum DhlEcommerce for value: dhl_ecommerce
    /// </summary>
    public static CarrierName DhlEcommerce { get; } = new("dhl_ecommerce");


    /// <summary>
    /// Enum DhlExpress for value: dhl_express
    /// </summary>
    public static CarrierName DhlExpress { get; } = new("dhl_express");


    /// <summary>
    /// Enum DhlExpressAu for value: dhl_express_au
    /// </summary>
    public static CarrierName DhlExpressAu { get; } = new("dhl_express_au");


    /// <summary>
    /// Enum DhlExpressCa for value: dhl_express_ca
    /// </summary>
    public static CarrierName DhlExpressCa { get; } = new("dhl_express_ca");


    /// <summary>
    /// Enum DhlExpressUk for value: dhl_express_uk
    /// </summary>
    public static CarrierName DhlExpressUk { get; } = new("dhl_express_uk");


    /// <summary>
    /// Enum Dpd for value: dpd
    /// </summary>
    public static CarrierName Dpd { get; } = new("dpd");


    /// <summary>
    /// Enum Endicia for value: endicia
    /// </summary>
    public static CarrierName Endicia { get; } = new("endicia");


    /// <summary>
    /// Enum Fedex for value: fedex
    /// </summary>
    public static CarrierName Fedex { get; } = new("fedex");


    /// <summary>
    /// Enum FedexUk for value: fedex_uk
    /// </summary>
    public static CarrierName FedexUk { get; } = new("fedex_uk");


    /// <summary>
    /// Enum Firstmile for value: firstmile
    /// </summary>
    public static CarrierName Firstmile { get; } = new("firstmile");


    /// <summary>
    /// Enum Imex for value: imex
    /// </summary>
    public static CarrierName Imex { get; } = new("imex");


    /// <summary>
    /// Enum Newgistics for value: newgistics
    /// </summary>
    public static CarrierName Newgistics { get; } = new("newgistics");


    /// <summary>
    /// Enum Ontrac for value: ontrac
    /// </summary>
    public static CarrierName Ontrac { get; } = new("ontrac");


    /// <summary>
    /// Enum PurolatorCanada for value: purolator_canada
    /// </summary>
    public static CarrierName PurolatorCanada { get; } = new("purolator_canada");


    /// <summary>
    /// Enum RoyalMail for value: royal_mail
    /// </summary>
    public static CarrierName RoyalMail { get; } = new("royal_mail");


    /// <summary>
    /// Enum RrDonnelley for value: rr_donnelley
    /// </summary>
    public static CarrierName RrDonnelley { get; } = new("rr_donnelley");


    /// <summary>
    /// Enum Seko for value: seko
    /// </summary>
    public static CarrierName Seko { get; } = new("seko");


    /// <summary>
    /// Enum Sendle for value: sendle
    /// </summary>
    public static CarrierName Sendle { get; } = new("sendle");


    /// <summary>
    /// Enum StampsCom for value: stamps_com
    /// </summary>
    public static CarrierName StampsCom { get; } = new("stamps_com");


    /// <summary>
    /// Enum Ups for value: ups
    /// </summary>
    public static CarrierName Ups { get; } = new("ups");


    /// <summary>
    /// Enum Lasership for value: lasership
    /// </summary>
    public static CarrierName Lasership { get; } = new("lasership");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;
}

internal class CarrierNameJsonConverter : JsonConverter<CarrierName>
{
    public override CarrierName? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new CarrierName(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, CarrierName value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(CarrierName);
}