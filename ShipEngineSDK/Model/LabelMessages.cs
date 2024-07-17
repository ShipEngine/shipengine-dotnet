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
/// Custom messages to print on the shipping label for the package.  These are typically used to print invoice numbers, product numbers, or other internal reference numbers.  Not all carriers support label messages. The number of lines and the maximum length of each line also varies by carrier.  |Carrier            |Max lines |Max line length |- -- -- -- -- -- -- -- -- --|- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- - |USPS (Stamps.com)  |3         |60 |FedEx              |3         |35 for the first line. 30 for additional lines. |UPS                |2         |35 |OnTrac             |2         |25 
/// </summary>
public partial class LabelMessages
{

    /// <summary>
    /// The first line of the custom label message.  Some carriers may prefix this line with something like \&quot;REF\&quot;, \&quot;Reference\&quot;, \&quot;Trx Ref No.\&quot;, etc. 
    /// </summary>
    /// <value>The first line of the custom label message.  Some carriers may prefix this line with something like \&quot;REF\&quot;, \&quot;Reference\&quot;, \&quot;Trx Ref No.\&quot;, etc. </value>
    [JsonPropertyName("reference1"), JsonPropertyOrder(1)]
    public required string Reference1 { get; set; }

    /// <summary>
    /// The second line of the custom label message.  Some carriers may prefix this line with something like \&quot;INV\&quot;, \&quot;Reference 2\&quot;, \&quot;Trx Ref No.\&quot;, etc. 
    /// </summary>
    /// <value>The second line of the custom label message.  Some carriers may prefix this line with something like \&quot;INV\&quot;, \&quot;Reference 2\&quot;, \&quot;Trx Ref No.\&quot;, etc. </value>
    [JsonPropertyName("reference2"), JsonPropertyOrder(2)]
    public required string Reference2 { get; set; }

    /// <summary>
    /// The third line of the custom label message.  Some carriers may prefix this line with something like \&quot;PO\&quot;, \&quot;Reference 3\&quot;, etc. 
    /// </summary>
    /// <value>The third line of the custom label message.  Some carriers may prefix this line with something like \&quot;PO\&quot;, \&quot;Reference 3\&quot;, etc. </value>
    [JsonPropertyName("reference3"), JsonPropertyOrder(3)]
    public required string Reference3 { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LabelMessages {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Reference1: ").Append(Reference1).Append("\n");
        sb.Append("  Reference2: ").Append(Reference2).Append("\n");
        sb.Append("  Reference3: ").Append(Reference3).Append("\n");
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