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
/// A pickup response body
/// </summary>
public partial class PickupResponseBody
{

    /// <summary>
    /// The carrier_id associated with the pickup
    /// </summary>
    /// <value>The carrier_id associated with the pickup</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("carrier_id"), JsonInclude]
    public string? CarrierId { get; set; }

    /// <summary>
    /// Gets or Sets ContactDetails
    /// </summary>
    [JsonPropertyName("contact_details"), JsonPropertyOrder(2)]
    public required ContactDetails ContactDetails { get; set; }

    /// <summary>
    /// The date and time that the pickup was created in ShipEngine.
    /// </summary>
    /// <value>The date and time that the pickup was created in ShipEngine.</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("created_at"), JsonInclude]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// Label IDs that will be included in the pickup request
    /// </summary>
    /// <value>Label IDs that will be included in the pickup request</value>
    [JsonPropertyName("label_ids"), JsonPropertyOrder(4)]
    public required List<string> LabelIds { get; set; }

    /// <summary>
    /// Gets or Sets PickupAddress
    /// </summary>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("pickup_address"), JsonInclude]
    public Address? PickupAddress { get; set; }

    /// <summary>
    /// Pickup Resource ID
    /// </summary>
    /// <value>Pickup Resource ID</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// pik_3YcKU5zdtJuCqoeNwyqqbW
    /// </example>
    [JsonPropertyName("pickup_id"), JsonInclude]
    public string? PickupId { get; set; }

    /// <summary>
    /// Gets or Sets PickupWindow
    /// </summary>
    [JsonPropertyName("pickup_window"), JsonPropertyOrder(7)]
    public required PickupWindow PickupWindow { get; set; }

    /// <summary>
    /// The warehouse_id associated with the pickup
    /// </summary>
    /// <value>The warehouse_id associated with the pickup</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("warehouse_id"), JsonInclude]
    public string? WarehouseId { get; set; }

    /// <summary>
    /// The date and time that the pickup was cancelled in ShipEngine.
    /// </summary>
    /// <value>The date and time that the pickup was cancelled in ShipEngine.</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("cancelled_at"), JsonInclude]
    public DateTimeOffset? CancelledAt { get; set; }

    /// <summary>
    /// The carrier confirmation number for the scheduled pickup.
    /// </summary>
    /// <value>The carrier confirmation number for the scheduled pickup.</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// 292513CL4A3
    /// </example>
    [JsonPropertyName("confirmation_number"), JsonInclude]
    public string? ConfirmationNumber { get; set; }

    /// <summary>
    /// Used by some carriers to give special instructions for a package pickup
    /// </summary>
    /// <value>Used by some carriers to give special instructions for a package pickup</value>
    [JsonPropertyName("pickup_notes"), JsonPropertyOrder(11)]
    public string? PickupNotes { get; set; }

    /// <summary>
    /// An array of available pickup windows. Carriers can return multiple times that they will pickup packages. 
    /// </summary>
    /// <value>An array of available pickup windows. Carriers can return multiple times that they will pickup packages. </value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("pickup_windows"), JsonInclude]
    public List<PickupWindows>? PickupWindows { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PickupResponseBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
        sb.Append("  ContactDetails: ").Append(ContactDetails).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  LabelIds: ").Append(LabelIds).Append("\n");
        sb.Append("  PickupAddress: ").Append(PickupAddress).Append("\n");
        sb.Append("  PickupId: ").Append(PickupId).Append("\n");
        sb.Append("  PickupWindow: ").Append(PickupWindow).Append("\n");
        sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
        sb.Append("  CancelledAt: ").Append(CancelledAt).Append("\n");
        sb.Append("  ConfirmationNumber: ").Append(ConfirmationNumber).Append("\n");
        sb.Append("  PickupNotes: ").Append(PickupNotes).Append("\n");
        sb.Append("  PickupWindows: ").Append(PickupWindows).Append("\n");
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