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
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Text.RegularExpressions;

namespace ShipEngineSDK.Model;

/// <summary>
/// A rate shipment request body
/// </summary>
[JsonConverter(typeof(CalculateRatesRequestBodyJsonConverter))]
//[DataContract(Name = "calculate_rates_request_body")]
public partial class CalculateRatesRequestBody : AbstractOpenAPISchema
{

    /// <summary>
    /// The rate options
    /// </summary>
    /// <value>The rate options</value>
    [JsonPropertyName("rate_options")]
    public RateRequestBody RateOptions { get; set; }


    /// <summary>
    /// Initializes a new instance of the <see cref="CalculateRatesRequestBody" /> class
    /// with the <see cref="ShipmentIdRequest" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of ShipmentIdRequest.</param>
    public CalculateRatesRequestBody(ShipmentIdRequest actualInstance)
    {
        this.IsNullable = false;
        this.SchemaType = "oneOf";
        this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CalculateRatesRequestBody" /> class
    /// with the <see cref="ShipmentRequest" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of ShipmentRequest.</param>
    public CalculateRatesRequestBody(ShipmentRequest actualInstance)
    {
        this.IsNullable = false;
        this.SchemaType = "oneOf";
        this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }


    private Object _actualInstance;

    /// <summary>
    /// Gets or Sets ActualInstance
    /// </summary>
    public override Object ActualInstance
    {
        get
        {
            return _actualInstance;
        }
        set
        {
            if (value.GetType() == typeof(ShipmentIdRequest))
            {
                this._actualInstance = value;
            }
            else if (value.GetType() == typeof(ShipmentRequest))
            {
                this._actualInstance = value;
            }
            else
            {
                throw new ArgumentException("Invalid instance found. Must be the following types: ShipmentIdRequest, ShipmentRequest");
            }
        }
    }

    /// <summary>
    /// Get the actual instance of `ShipmentIdRequest`. If the actual instance is not `ShipmentIdRequest`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of ShipmentIdRequest</returns>
    public ShipmentIdRequest GetShipmentIdRequest()
    {
        return (ShipmentIdRequest)this.ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `ShipmentRequest`. If the actual instance is not `ShipmentRequest`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of ShipmentRequest</returns>
    public ShipmentRequest GetShipmentRequest()
    {
        return (ShipmentRequest)this.ActualInstance;
    }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CalculateRatesRequestBody {\n");
        sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");

        sb.Append("  RateOptions: ").Append(this.RateOptions).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public override string ToJson()
    {
        return JsonSerializer.Serialize(this.ActualInstance, CalculateRatesRequestBody.SerializerSettings);
    }

}

/// <summary>
/// Custom JSON converter for CalculateRatesRequestBody
/// </summary>
public class CalculateRatesRequestBodyJsonConverter : JsonConverter<CalculateRatesRequestBody>
{
    private static HashSet<Type> OneOfTypes = [typeof(ShipmentIdRequest), typeof(ShipmentRequest)];
    private static HashSet<string> MandatoryFields = ["Shipment", "ShipmentId"];
    private static JsonSerializerOptions DeserializingOptions = new(AbstractOpenAPISchema.SerializerSettings)
    {
        TypeInfoResolver = new DefaultJsonTypeInfoResolver
        {
            Modifiers =
            {
                static typeInfo =>
                {
                    if (typeInfo.Kind != JsonTypeInfoKind.Object)
                        return;

                    foreach (JsonPropertyInfo propertyInfo in typeInfo.Properties)
                    {
                        // Strip IsRequired constraint from every property except those which define the underlying type
                        if (OneOfTypes.Contains(typeInfo.Type))
                        {
                            var underlyingPropertyName = (propertyInfo.AttributeProvider as MemberInfo)?.Name;
                            propertyInfo.IsRequired = underlyingPropertyName != null && MandatoryFields.Contains(underlyingPropertyName);
                        }
                        else
                        {
                            propertyInfo.IsRequired = false;
                        }
                    }
                }
            }
        }
    };

    /// <summary>
    /// To write the JSON string
    /// </summary>
    /// <param name="writer">JSON writer</param>
    /// <param name="value">Object to be converted into a JSON string</param>
    /// <param name="options">Serializer options</param>
    public override void Write(Utf8JsonWriter writer, CalculateRatesRequestBody value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WritePropertyName("rate_options");
        JsonSerializer.Serialize(writer, value.RateOptions, options);

        var node = JsonSerializer.SerializeToNode(value.ActualInstance, options);
        foreach (var prop in node?.AsObject() ?? [])
        {
            if (prop.Value != null)
            {
                writer.WritePropertyName(prop.Key);
                prop.Value.WriteTo(writer, options);
            }
        }

        writer.WriteEndObject();
    }

    /// <summary>
    /// To convert a JSON string into an object
    /// </summary>
    /// <param name="reader">JSON reader</param>
    /// <param name="typeToConvert">Object type to convert</param>
    /// <param name="options">Serializer options</param>
    /// <returns>The object converted from the JSON string</returns>
    public override CalculateRatesRequestBody Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        var jsonDoc = JsonDocument.ParseValue(ref reader);
        CalculateRatesRequestBody newCalculateRatesRequestBody = null;

        int match = 0;
        var matchedTypes = new List<string>();

        try
        {
            newCalculateRatesRequestBody = new CalculateRatesRequestBody(JsonSerializer.Deserialize<ShipmentIdRequest>(jsonDoc, DeserializingOptions));

            matchedTypes.Add("ShipmentIdRequest");
            match++;
        }
        catch (Exception exception)
        {
            // deserialization failed, try the next one
            System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ShipmentIdRequest: {1}", jsonDoc, exception.ToString()));
        }

        try
        {
            newCalculateRatesRequestBody = new CalculateRatesRequestBody(JsonSerializer.Deserialize<ShipmentRequest>(jsonDoc, DeserializingOptions));

            matchedTypes.Add("ShipmentRequest");
            match++;
        }
        catch (Exception exception)
        {
            // deserialization failed, try the next one
            System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ShipmentRequest: {1}", jsonDoc, exception.ToString()));
        }

        if (match == 0)
        {
            throw new InvalidDataException("The JSON string `" + jsonDoc + "` cannot be deserialized into any schema defined.");
        }

        if (match > 1)
        {
            throw new InvalidDataException("The JSON string `" + jsonDoc + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
        }

        newCalculateRatesRequestBody.RateOptions = JsonSerializer.Deserialize<RateRequestBody>(jsonDoc.RootElement.GetProperty("rate_options"), DeserializingOptions);

        // deserialization is considered successful at this point if no exception has been thrown.
        return newCalculateRatesRequestBody;
    }

    /// <summary>
    /// Check if the object can be converted
    /// </summary>
    /// <param name="objectType">Object type</param>
    /// <returns>True if the object can be converted</returns>
    public override bool CanConvert(Type objectType)
    {
        return typeof(CalculateRatesRequestBody).IsAssignableFrom(objectType);
    }
}