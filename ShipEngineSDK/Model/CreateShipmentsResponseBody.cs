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
/// A create shipments response body
/// </summary>
//[DataContract(Name = "create_shipments_response_body")]
public partial class CreateShipmentsResponseBody
{

    /// <summary>
    /// Indicates if errors occured while creating the shipments
    /// </summary>
    /// <value>Indicates if errors occured while creating the shipments</value>
    [JsonPropertyName("has_errors")]
    [JsonRequired]
    public bool HasErrors { get; set; }

    /// <summary>
    /// An array of shipments that were created.
    /// </summary>
    /// <value>An array of shipments that were created.</value>
    [JsonPropertyName("shipments")]
    [JsonRequired]
    public List<CreateAndValidateShipment> Shipments { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class CreateShipmentsResponseBody {\n");
        sb.Append("  HasErrors: ").Append(HasErrors).Append("\n");
        sb.Append("  Shipments: ").Append(Shipments).Append("\n");
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