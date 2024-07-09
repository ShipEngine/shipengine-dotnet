/*
 * ShipEngine API
 *
 * ShipEngine's easy-to-use REST API lets you manage all of your shipping needs without worrying about the complexities of different carrier APIs and protocols. We handle all the heavy lifting so you can focus on providing a first-class shipping experience for your customers at the best possible prices.  Each of ShipEngine's features can be used by itself or in conjunction with each other to build powerful shipping functionality into your application or service.  ## Getting Started If you're new to REST APIs then be sure to read our [introduction to REST](https://www.shipengine.com/docs/rest/) to understand the basics.  Learn how to [authenticate yourself to ShipEngine](https://www.shipengine.com/docs/auth/), and then use our [sandbox environment](https://www.shipengine.com/docs/sandbox/) to kick the tires and get familiar with our API. If you run into any problems, then be sure to check the [error handling guide](https://www.shipengine.com/docs/errors/) for tips.  Here are some step-by-step **tutorials** to get you started:    - [Learn how to create your first shipping label](https://www.shipengine.com/docs/labels/create-a-label/)   - [Calculate shipping costs and compare rates across carriers](https://www.shipengine.com/docs/rates/)   - [Track packages on-demand or in real time](https://www.shipengine.com/docs/tracking/)   - [Validate mailing addresses anywhere on Earth](https://www.shipengine.com/docs/addresses/validation/)   ## Shipping Labels for Every Major Carrier ShipEngine makes it easy to [create shipping labels for any carrier](https://www.shipengine.com/docs/labels/create-a-label/) and [download them](https://www.shipengine.com/docs/labels/downloading/) in a [variety of file formats](https://www.shipengine.com/docs/labels/formats/). You can even customize labels with your own [messages](https://www.shipengine.com/docs/labels/messages/) and [images](https://www.shipengine.com/docs/labels/branding/).   ## Real-Time Package Tracking With ShipEngine you can [get the current status of a package](https://www.shipengine.com/docs/tracking/) or [subscribe to real-time tracking updates](https://www.shipengine.com/docs/tracking/webhooks/) via webhooks. You can also create [custimized tracking pages](https://www.shipengine.com/docs/tracking/branded-tracking-page/) with your own branding so your customers will always know where their package is.   ## Compare Shipping Costs Across Carriers Make sure you ship as cost-effectively as possible by [comparing rates across carriers](https://www.shipengine.com/docs/rates/get-shipment-rates/) using the ShipEngine Rates API. Or if you don't know the full shipment details yet, then you can [get rate estimates](https://www.shipengine.com/docs/rates/estimate/) with limited address info.   ## Worldwide Address Validation ShipEngine supports [address validation](https://www.shipengine.com/docs/addresses/validation/) for virtually [every country on Earth](https://www.shipengine.com/docs/addresses/validation/countries/), including the United States, Canada, Great Britain, Australia, Germany, France, Norway, Spain, Sweden, Israel, Italy, and over 160 others.  # Authentication  <!- - ReDoc-Inject: <security-definitions> - ->
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
/// [Ancillary service endorsements](https://pe.usps.com/text/qsg300/Q507.htm) are used by mailers to request an addressee&#39;s new address and to provide the carrier with instructions on how to handle packages that are undeliverable as addressed.  | Ancillary Service Endorsement  | Description |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | &#x60;none&#x60;                         | No ancillary service is requested. Depending on the carrier servive, the package may be forwarded, returned, or discarded. | &#x60;return_service_requested&#x60;     | The package is returned to the sender. If possible, notification of the new address is is included with the returned package. | &#x60;forwarding_service_requested&#x60; | Forward the package to the new address, if possible; otherwise, return it to the sender. | &#x60;address_service_requested&#x60;    | Forward the package to the new address, if possible; otherwise, return it to the sender. This is similar to &#x60;forwarding_service_requested&#x60;, but different restrictions and charges may apply. | &#x60;change_service_requested&#x60;     | The package is discarded. If possible, notification of the new address is sent to the sender. | &#x60;leave_if_no_response&#x60;         | 
/// </summary>
/// <value>[Ancillary service endorsements](https://pe.usps.com/text/qsg300/Q507.htm) are used by mailers to request an addressee&#39;s new address and to provide the carrier with instructions on how to handle packages that are undeliverable as addressed.  | Ancillary Service Endorsement  | Description |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | &#x60;none&#x60;                         | No ancillary service is requested. Depending on the carrier servive, the package may be forwarded, returned, or discarded. | &#x60;return_service_requested&#x60;     | The package is returned to the sender. If possible, notification of the new address is is included with the returned package. | &#x60;forwarding_service_requested&#x60; | Forward the package to the new address, if possible; otherwise, return it to the sender. | &#x60;address_service_requested&#x60;    | Forward the package to the new address, if possible; otherwise, return it to the sender. This is similar to &#x60;forwarding_service_requested&#x60;, but different restrictions and charges may apply. | &#x60;change_service_requested&#x60;     | The package is discarded. If possible, notification of the new address is sent to the sender. | &#x60;leave_if_no_response&#x60;         | </value>
[JsonConverter(typeof(AncillaryServiceEndorsementJsonConverter))]
public class AncillaryServiceEndorsement
{
    private string _value;

    internal AncillaryServiceEndorsement()
    {
        _value = "none";
    }

    /// <summary>
    /// Create a new instance of AncillaryServiceEndorsement with a custom value.
    /// </summary>
    /// <param name="value">The value of the AncillaryServiceEndorsement</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public AncillaryServiceEndorsement(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum None for value: none
    /// </summary>
    public static AncillaryServiceEndorsement None { get; } = new("none");


    /// <summary>
    /// Enum ReturnServiceRequested for value: return_service_requested
    /// </summary>
    public static AncillaryServiceEndorsement ReturnServiceRequested { get; } = new("return_service_requested");


    /// <summary>
    /// Enum ForwardingServiceRequested for value: forwarding_service_requested
    /// </summary>
    public static AncillaryServiceEndorsement ForwardingServiceRequested { get; } = new("forwarding_service_requested");


    /// <summary>
    /// Enum AddressServiceRequested for value: address_service_requested
    /// </summary>
    public static AncillaryServiceEndorsement AddressServiceRequested { get; } = new("address_service_requested");


    /// <summary>
    /// Enum ChangeServiceRequested for value: change_service_requested
    /// </summary>
    public static AncillaryServiceEndorsement ChangeServiceRequested { get; } = new("change_service_requested");


    /// <summary>
    /// Enum LeaveIfNoResponse for value: leave_if_no_response
    /// </summary>
    public static AncillaryServiceEndorsement LeaveIfNoResponse { get; } = new("leave_if_no_response");


    public override string ToString() => _value;
}

internal class AncillaryServiceEndorsementJsonConverter : JsonConverter<AncillaryServiceEndorsement>
{
    public override AncillaryServiceEndorsement? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new AncillaryServiceEndorsement(reader.GetString()) : null;

    public override void Write(Utf8JsonWriter writer, AncillaryServiceEndorsement value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(AncillaryServiceEndorsement);
}