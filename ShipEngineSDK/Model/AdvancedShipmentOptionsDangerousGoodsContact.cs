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
/// Contact information for Dangerous goods
/// </summary>
public partial class AdvancedShipmentOptionsDangerousGoodsContact
{

    /// <summary>
    /// Name of the contact
    /// </summary>
    /// <value>Name of the contact</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Phone number of the contact
    /// </summary>
    /// <value>Phone number of the contact</value>
    [JsonPropertyName("phone")]
    public string Phone { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class AdvancedShipmentOptionsDangerousGoodsContact {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Phone: ").Append(Phone).Append("\n");
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