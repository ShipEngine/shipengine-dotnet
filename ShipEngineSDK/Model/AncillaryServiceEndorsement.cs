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
/// [Ancillary service endorsements](https://pe.usps.com/text/qsg300/Q507.htm) are used by mailers to request an addressee&#39;s new address and to provide the carrier with instructions on how to handle packages that are undeliverable as addressed.  | Ancillary Service Endorsement  | Description |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | &#x60;none&#x60;                         | No ancillary service is requested. Depending on the carrier servive, the package may be forwarded, returned, or discarded. | &#x60;return_service_requested&#x60;     | The package is returned to the sender. If possible, notification of the new address is is included with the returned package. | &#x60;forwarding_service_requested&#x60; | Forward the package to the new address, if possible; otherwise, return it to the sender. | &#x60;address_service_requested&#x60;    | Forward the package to the new address, if possible; otherwise, return it to the sender. This is similar to &#x60;forwarding_service_requested&#x60;, but different restrictions and charges may apply. | &#x60;change_service_requested&#x60;     | The package is discarded. If possible, notification of the new address is sent to the sender. | &#x60;leave_if_no_response&#x60;         | 
/// </summary>
/// <value>[Ancillary service endorsements](https://pe.usps.com/text/qsg300/Q507.htm) are used by mailers to request an addressee&#39;s new address and to provide the carrier with instructions on how to handle packages that are undeliverable as addressed.  | Ancillary Service Endorsement  | Description |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | &#x60;none&#x60;                         | No ancillary service is requested. Depending on the carrier servive, the package may be forwarded, returned, or discarded. | &#x60;return_service_requested&#x60;     | The package is returned to the sender. If possible, notification of the new address is is included with the returned package. | &#x60;forwarding_service_requested&#x60; | Forward the package to the new address, if possible; otherwise, return it to the sender. | &#x60;address_service_requested&#x60;    | Forward the package to the new address, if possible; otherwise, return it to the sender. This is similar to &#x60;forwarding_service_requested&#x60;, but different restrictions and charges may apply. | &#x60;change_service_requested&#x60;     | The package is discarded. If possible, notification of the new address is sent to the sender. | &#x60;leave_if_no_response&#x60;         | </value>
[JsonConverter(typeof(AncillaryServiceEndorsementJsonConverter))]
public class AncillaryServiceEndorsement
{
    private readonly string _value;

    /// <summary>
    /// Create a new instance of AncillaryServiceEndorsement with a predefined value.
    /// </summary>
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


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;

    /// <summary>
    /// Get whether this instance is equal to another instance
    /// </summary>
    public override bool Equals(object? obj) =>
        obj is AncillaryServiceEndorsement other && _value == other._value;

    /// <summary>
    /// Get the hash code of the object
    /// </summary>
    public override int GetHashCode() => _value.GetHashCode();
}

internal class AncillaryServiceEndorsementJsonConverter : JsonConverter<AncillaryServiceEndorsement>
{
    public override AncillaryServiceEndorsement? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new AncillaryServiceEndorsement(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, AncillaryServiceEndorsement value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(AncillaryServiceEndorsement);
}