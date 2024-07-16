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
/// A get service points request body. Caller must provide exactly one of address_query, address, or lat / long pair.
/// </summary>
public partial class GetServicePointsRequestBody
{

    /// <summary>
    /// An array of shipping service providers and service codes
    /// </summary>
    /// <value>An array of shipping service providers and service codes</value>
    [JsonPropertyName("providers")]
    [JsonRequired]
    public required List<GetServicePointsRequestBodyProvidersInner> Providers { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [JsonPropertyName("address")]
    public GetServicePointsRequestBodyAddress? Address { get; set; }

    /// <summary>
    /// Unstructured text to search for service points by.
    /// </summary>
    /// <value>Unstructured text to search for service points by.</value>
    /// <example>
    /// 177A Bleecker Street New York
    /// </example>
    [JsonPropertyName("address_query")]
    public string? AddressQuery { get; set; }

    /// <summary>
    /// The latitude of the point. Represented as signed degrees. Required if long is provided. http://www.geomidpoint.com/latlon.html
    /// </summary>
    /// <value>The latitude of the point. Represented as signed degrees. Required if long is provided. http://www.geomidpoint.com/latlon.html</value>
    /// <example>
    /// 48.874518928233094
    /// </example>
    [JsonPropertyName("lat")]
    public double? Lat { get; set; }

    /// <summary>
    /// The longitude of the point. Represented as signed degrees. Required if lat is provided. http://www.geomidpoint.com/latlon.html
    /// </summary>
    /// <value>The longitude of the point. Represented as signed degrees. Required if lat is provided. http://www.geomidpoint.com/latlon.html</value>
    /// <example>
    /// 2.3591775711639404
    /// </example>
    [JsonPropertyName("long")]
    public double? Long { get; set; }

    /// <summary>
    /// The maximum number of service points to return
    /// </summary>
    /// <value>The maximum number of service points to return</value>
    /// <example>
    /// 25
    /// </example>
    [JsonPropertyName("max_results")]
    public int? MaxResults { get; set; }

    /// <summary>
    /// Search radius in kilometers
    /// </summary>
    /// <value>Search radius in kilometers</value>
    /// <example>
    /// 500
    /// </example>
    [JsonPropertyName("radius")]
    public int? Radius { get; set; }

    /// <summary>
    /// Gets or Sets Shipment
    /// </summary>
    [JsonPropertyName("shipment")]
    public GetServicePointsRequestBodyShipment? Shipment { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class GetServicePointsRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Providers: ").Append(Providers).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  AddressQuery: ").Append(AddressQuery).Append("\n");
        sb.Append("  Lat: ").Append(Lat).Append("\n");
        sb.Append("  Long: ").Append(Long).Append("\n");
        sb.Append("  MaxResults: ").Append(MaxResults).Append("\n");
        sb.Append("  Radius: ").Append(Radius).Append("\n");
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