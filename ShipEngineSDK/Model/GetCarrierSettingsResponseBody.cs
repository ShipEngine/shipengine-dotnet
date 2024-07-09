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
/// GetCarrierSettingsResponseBody
/// </summary>
[JsonConverter(typeof(GetCarrierSettingsResponseBodyJsonConverter))]
//[DataContract(Name = "get_carrier_settings_response_body")]
public partial class GetCarrierSettingsResponseBody : AbstractOpenAPISchema
{

    /// <summary>
    /// Initializes a new instance of the <see cref="GetCarrierSettingsResponseBody" /> class
    /// with the <see cref="DhlExpressSettingsResponseBody" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of DhlExpressSettingsResponseBody.</param>
    public GetCarrierSettingsResponseBody(DhlExpressSettingsResponseBody actualInstance)
    {
        this.IsNullable = false;
        this.SchemaType = "oneOf";
        this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GetCarrierSettingsResponseBody" /> class
    /// with the <see cref="FedexSettingsResponseBody" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of FedexSettingsResponseBody.</param>
    public GetCarrierSettingsResponseBody(FedexSettingsResponseBody actualInstance)
    {
        this.IsNullable = false;
        this.SchemaType = "oneOf";
        this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GetCarrierSettingsResponseBody" /> class
    /// with the <see cref="UpsSettingsResponseBody" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of UpsSettingsResponseBody.</param>
    public GetCarrierSettingsResponseBody(UpsSettingsResponseBody actualInstance)
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
            if (value.GetType() == typeof(DhlExpressSettingsResponseBody))
            {
                this._actualInstance = value;
            }
            else if (value.GetType() == typeof(FedexSettingsResponseBody))
            {
                this._actualInstance = value;
            }
            else if (value.GetType() == typeof(UpsSettingsResponseBody))
            {
                this._actualInstance = value;
            }
            else
            {
                throw new ArgumentException("Invalid instance found. Must be the following types: DhlExpressSettingsResponseBody, FedexSettingsResponseBody, UpsSettingsResponseBody");
            }
        }
    }

    /// <summary>
    /// Get the actual instance of `DhlExpressSettingsResponseBody`. If the actual instance is not `DhlExpressSettingsResponseBody`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of DhlExpressSettingsResponseBody</returns>
    public DhlExpressSettingsResponseBody GetDhlExpressSettingsResponseBody()
    {
        return (DhlExpressSettingsResponseBody)this.ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `FedexSettingsResponseBody`. If the actual instance is not `FedexSettingsResponseBody`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of FedexSettingsResponseBody</returns>
    public FedexSettingsResponseBody GetFedexSettingsResponseBody()
    {
        return (FedexSettingsResponseBody)this.ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `UpsSettingsResponseBody`. If the actual instance is not `UpsSettingsResponseBody`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of UpsSettingsResponseBody</returns>
    public UpsSettingsResponseBody GetUpsSettingsResponseBody()
    {
        return (UpsSettingsResponseBody)this.ActualInstance;
    }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GetCarrierSettingsResponseBody {\n");
        sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");

        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public override string ToJson()
    {
        return JsonSerializer.Serialize(this.ActualInstance, GetCarrierSettingsResponseBody.SerializerSettings);
    }

}

/// <summary>
/// Custom JSON converter for GetCarrierSettingsResponseBody
/// </summary>
public class GetCarrierSettingsResponseBodyJsonConverter : JsonConverter<GetCarrierSettingsResponseBody>
{
    private static HashSet<Type> OneOfTypes = [typeof(DhlExpressSettingsResponseBody), typeof(FedexSettingsResponseBody), typeof(UpsSettingsResponseBody)];
    private static HashSet<string> MandatoryFields = [];
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
    public override void Write(Utf8JsonWriter writer, GetCarrierSettingsResponseBody value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();


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
    public override GetCarrierSettingsResponseBody Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        var jsonDoc = JsonDocument.ParseValue(ref reader);
        GetCarrierSettingsResponseBody newGetCarrierSettingsResponseBody = null;

        int match = 0;
        var matchedTypes = new List<string>();

        try
        {
            newGetCarrierSettingsResponseBody = new GetCarrierSettingsResponseBody(JsonSerializer.Deserialize<DhlExpressSettingsResponseBody>(jsonDoc, DeserializingOptions));

            matchedTypes.Add("DhlExpressSettingsResponseBody");
            match++;
        }
        catch (Exception exception)
        {
            // deserialization failed, try the next one
            System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DhlExpressSettingsResponseBody: {1}", jsonDoc, exception.ToString()));
        }

        try
        {
            newGetCarrierSettingsResponseBody = new GetCarrierSettingsResponseBody(JsonSerializer.Deserialize<FedexSettingsResponseBody>(jsonDoc, DeserializingOptions));

            matchedTypes.Add("FedexSettingsResponseBody");
            match++;
        }
        catch (Exception exception)
        {
            // deserialization failed, try the next one
            System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into FedexSettingsResponseBody: {1}", jsonDoc, exception.ToString()));
        }

        try
        {
            newGetCarrierSettingsResponseBody = new GetCarrierSettingsResponseBody(JsonSerializer.Deserialize<UpsSettingsResponseBody>(jsonDoc, DeserializingOptions));

            matchedTypes.Add("UpsSettingsResponseBody");
            match++;
        }
        catch (Exception exception)
        {
            // deserialization failed, try the next one
            System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UpsSettingsResponseBody: {1}", jsonDoc, exception.ToString()));
        }

        if (match == 0)
        {
            throw new InvalidDataException("The JSON string `" + jsonDoc + "` cannot be deserialized into any schema defined.");
        }

        if (match > 1)
        {
            throw new InvalidDataException("The JSON string `" + jsonDoc + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
        }


        // deserialization is considered successful at this point if no exception has been thrown.
        return newGetCarrierSettingsResponseBody;
    }

    /// <summary>
    /// Check if the object can be converted
    /// </summary>
    /// <param name="objectType">Object type</param>
    /// <returns>True if the object can be converted</returns>
    public override bool CanConvert(Type objectType)
    {
        return typeof(GetCarrierSettingsResponseBody).IsAssignableFrom(objectType);
    }
}