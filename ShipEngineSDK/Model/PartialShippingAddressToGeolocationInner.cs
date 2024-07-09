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
/// PartialShippingAddressToGeolocationInner
/// </summary>
//[DataContract(Name = "partial_shipping_address_to_geolocation_inner")]
public partial class PartialShippingAddressToGeolocationInner
{
    //    
    //    /// <summary>
    //    /// Enum of available type of geolocation items:   - &#39;what3words&#39; functionality allows to specify a location by providing 3 words that have been assign to the specific location see [link](https://what3words.com/business) for more details. 
    //    /// </summary>
    //    
    //    /// <value>Enum of available type of geolocation items:   - &#39;what3words&#39; functionality allows to specify a location by providing 3 words that have been assign to the specific location see [link](https://what3words.com/business) for more details. </value>
    //    
    //    public static class TypeEnum
    //    {
    //        private static readonly HashSet<string> _values = new()
    //        {
    //            
    //            
    //            "what3words",
    //            
    //            
    //        };
    //
    //        
    //        
    //        
    //        public static string DefaultValue => What3words;
    //        
    //        
    //        /// <summary>
    //        /// Enum What3words for value: what3words
    //        /// </summary>
    //        public static string What3words { get; } = "what3words";
    //        
    //        
    //        
    //
    //        /// <summary>
    //        /// Is the given value a valid TypeEnum?
    //        /// </summary>
    //        public static bool IsValid(string value)
    //        {
    //            return _values.Contains(value);
    //        }
    //    }
    //    




    /// <summary>
    /// Enum of available type of geolocation items:   - &#39;what3words&#39; functionality allows to specify a location by providing 3 words that have been assign to the specific location see [link](https://what3words.com/business) for more details. 
    /// </summary>
    /// <value>Enum of available type of geolocation items:   - &#39;what3words&#39; functionality allows to specify a location by providing 3 words that have been assign to the specific location see [link](https://what3words.com/business) for more details. </value>
    [JsonConverter(typeof(TypeEnumJsonConverter))]
    public class TypeEnum
    {
        private string _value;

        internal TypeEnum()
        {
            _value = "what3words";
        }

        public TypeEnum(string value)
        {

        }

        /// <summary>
        /// Enum What3words for value: what3words
        /// </summary>
        public static TypeEnum What3words { get; } = new("what3words");


        public override string ToString() => _value;
    }

    internal class TypeEnumJsonConverter : JsonConverter<TypeEnum>
    {
        public override TypeEnum? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            reader.TokenType == JsonTokenType.String ? new TypeEnum(reader.GetString()) : null;

        public override void Write(Utf8JsonWriter writer, TypeEnum value, JsonSerializerOptions options) =>
            writer.WriteStringValue(value.ToString());

        public override bool CanConvert(Type typeToConvert) =>
            typeToConvert == typeof(TypeEnum);
    }


    /// <summary>
    /// Enum of available type of geolocation items:   - &#39;what3words&#39; functionality allows to specify a location by providing 3 words that have been assign to the specific location see [link](https://what3words.com/business) for more details.   CLOVUS
    /// </summary>
    /// <value>Enum of available type of geolocation items:   - &#39;what3words&#39; functionality allows to specify a location by providing 3 words that have been assign to the specific location see [link](https://what3words.com/business) for more details. </value>
    /// <example>
    /// what3words
    /// </example>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// value of the geolocation item
    /// </summary>
    /// <value>value of the geolocation item</value>
    /// <example>
    /// cats.with.thumbs
    /// </example>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class PartialShippingAddressToGeolocationInner {\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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