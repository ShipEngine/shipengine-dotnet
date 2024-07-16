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
/// A webhook response body
/// </summary>
public partial class CreateWebhookResponseBody
{

    /// <summary>
    /// Gets or Sets Event  CLOVUS
    /// </summary>
    [JsonPropertyName("event")]
    [JsonRequired]
    public WebhookEvent Event { get; set; } = new();


    /// <summary>
    /// The url that the webhook sends the request to
    /// </summary>
    /// <value>The url that the webhook sends the request to</value>
    /// <example>
    /// http://api.shipengine.com/v1/labels/se-28529731
    /// </example>
    [JsonPropertyName("url")]
    [JsonRequired]
    public string Url { get; set; }

    /// <summary>
    /// A string that uniquely identifies the webhook
    /// </summary>
    /// <value>A string that uniquely identifies the webhook</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("webhook_id")]
    [JsonRequired]
    public string WebhookId { get; set; }

    /// <summary>
    /// Array of custom webhook headers
    /// </summary>
    /// <value>Array of custom webhook headers</value>
    [JsonPropertyName("headers")]
    public List<WebhookHeader>? Headers { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class CreateWebhookResponseBody {\n");
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