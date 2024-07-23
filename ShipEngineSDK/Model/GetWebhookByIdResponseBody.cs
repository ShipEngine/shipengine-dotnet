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
/// A get webhook id response body
/// </summary>
public partial class GetWebhookByIdResponseBody
{

    /// <summary>
    /// Gets or Sets Event
    /// </summary>
    [JsonPropertyName("event"), JsonPropertyOrder(1)]
    public required WebhookEvent Event { get; set; }

    /// <summary>
    /// The url that the webhook sends the request to
    /// </summary>
    /// <value>The url that the webhook sends the request to</value>
    /// <example>
    /// http://api.shipengine.com/v1/labels/se-28529731
    /// </example>
    [JsonPropertyName("url"), JsonPropertyOrder(2)]
    public required string Url { get; set; }

    /// <summary>
    /// A string that uniquely identifies the webhook
    /// </summary>
    /// <value>A string that uniquely identifies the webhook</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("webhook_id"), JsonInclude]
    public string? WebhookId { get; set; }

    /// <summary>
    /// Array of custom webhook headers
    /// </summary>
    /// <value>Array of custom webhook headers</value>
    [JsonPropertyName("headers"), JsonPropertyOrder(4)]
    public List<WebhookHeader>? Headers { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GetWebhookByIdResponseBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Event: ").Append(Event).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  WebhookId: ").Append(WebhookId).Append("\n");
        sb.Append("  Headers: ").Append(Headers).Append("\n");
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