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
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Text.RegularExpressions;

namespace ShipEngineSDK.Model;

/// <summary>
/// GetServicePointsRequest
/// </summary>
[JsonConverter(typeof(GetServicePointsRequestJsonConverter))]
//[DataContract(Name = "get_service_points_request")]
public partial class GetServicePointsRequest : AbstractOpenAPISchema
{

    /// <summary>
    /// Initializes a new instance of the <see cref="GetServicePointsRequest" /> class
    /// with the <see cref="GetServicePointsRequestBody" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of GetServicePointsRequestBody.</param>
    public GetServicePointsRequest(GetServicePointsRequestBody actualInstance) : base("oneOf")
    {
        this.IsNullable = false;
        _actualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
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
            if (value.GetType() == typeof(GetServicePointsRequestBody))
            {
                this._actualInstance = value;
            }
            else
            {
                throw new ArgumentException("Invalid instance found. Must be the following types: GetServicePointsRequestBody");
            }
        }
    }

    /// <summary>
    /// Get the actual instance of `GetServicePointsRequestBody`. If the actual instance is not `GetServicePointsRequestBody`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of GetServicePointsRequestBody</returns>
    public GetServicePointsRequestBody GetGetServicePointsRequestBody()
    {
        return (GetServicePointsRequestBody)this.ActualInstance;
    }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GetServicePointsRequest {\n");
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
        return JsonSerializer.Serialize(this.ActualInstance, GetServicePointsRequest.SerializerSettings);
    }

}

/// <summary>
/// Custom JSON converter for GetServicePointsRequest
/// </summary>
public class GetServicePointsRequestJsonConverter : JsonConverter<GetServicePointsRequest>
{
    private static readonly HashSet<Type> OneOfTypes = [typeof(GetServicePointsRequestBody)];
    private static readonly HashSet<string> MandatoryFields = ["Providers"];
    private static readonly JsonSerializerOptions DeserializingOptions = new(AbstractOpenAPISchema.SerializerSettings)
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
    public override void Write(Utf8JsonWriter writer, GetServicePointsRequest value, JsonSerializerOptions options)
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
    public override GetServicePointsRequest? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        var jsonDoc = JsonDocument.ParseValue(ref reader);
        GetServicePointsRequest? newGetServicePointsRequest = null;


        int match = 0;
        var matchedTypes = new List<string>();

        try
        {
            newGetServicePointsRequest = new GetServicePointsRequest(jsonDoc.Deserialize<GetServicePointsRequestBody>(DeserializingOptions)!);

            matchedTypes.Add("GetServicePointsRequestBody");
            match++;
        }
        catch (Exception exception)
        {
            // deserialization failed, try the next one
            System.Diagnostics.Debug.WriteLine("Failed to deserialize `{0}` into GetServicePointsRequestBody: {1}", jsonDoc, exception);
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
        return newGetServicePointsRequest;
    }

    /// <summary>
    /// Check if the object can be converted
    /// </summary>
    /// <param name="objectType">Object type</param>
    /// <returns>True if the object can be converted</returns>
    public override bool CanConvert(Type objectType)
    {
        return typeof(GetServicePointsRequest).IsAssignableFrom(objectType);
    }
}