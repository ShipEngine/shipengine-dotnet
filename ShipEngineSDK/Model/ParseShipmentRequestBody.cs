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
/// The only required field is &#x60;text&#x60;, which is the text to be parsed. You can optionally also provide a &#x60;shipment&#x60; containing any already-known values. For example, you probably already know the &#x60;ship_from&#x60; address, and you may also already know what carrier and service you want to use. 
/// </summary>
public partial class ParseShipmentRequestBody
{

    /// <summary>
    /// The unstructured text that contains shipping-related entities
    /// </summary>
    /// <value>The unstructured text that contains shipping-related entities</value>
    /// <example>
    /// I have a 4oz package that&#39;s 5x10x14in, and I need to ship it to Margie McMiller at 3800 North Lamar suite 200 in austin, tx 78652. Please send it via USPS first class and require an adult signature. It also needs to be insured for $400.

    /// </example>
    [JsonPropertyName("text")]
    [JsonRequired]
    public required string Text { get; set; }

    /// <summary>
    /// You can optionally provide a &#x60;shipment&#x60; object containing any already-known values. For example, you probably already know the &#x60;ship_from&#x60; address, and you may also already know what carrier and service you want to use. 
    /// </summary>
    /// <value>You can optionally provide a &#x60;shipment&#x60; object containing any already-known values. For example, you probably already know the &#x60;ship_from&#x60; address, and you may also already know what carrier and service you want to use. </value>
    [JsonPropertyName("shipment")]
    public PartialShipment? Shipment { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ParseShipmentRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Shipment: ").Append(Shipment).Append("\n");
#pragma warning restore CS0612 // Type or member is obsolete
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }

}