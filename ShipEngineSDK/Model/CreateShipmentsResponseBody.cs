// <auto-generated />
// DO NOT MODIFY THIS FILE

// Changes can be made in a corresponding partial file, or by changing
// the template in <root>/generation/templates and generating the class again.


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
/// A create shipments response body
/// </summary>
public partial class CreateShipmentsResponseBody
{

    /// <summary>
    /// An array of shipments that were created.
    /// </summary>
    /// <value>An array of shipments that were created.</value>
    [JsonPropertyName("shipments"), JsonPropertyOrder(1)]
    public required List<CreateAndValidateShipment> Shipments { get; set; }

    /// <summary>
    /// Indicates if errors occured while creating the shipments
    /// </summary>
    /// <value>Indicates if errors occured while creating the shipments</value>
    [JsonPropertyName("has_errors"), JsonPropertyOrder(2)]
    public required bool HasErrors { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateShipmentsResponseBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Shipments: ").Append(Shipments).Append("\n");
        sb.Append("  HasErrors: ").Append(HasErrors).Append("\n");
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