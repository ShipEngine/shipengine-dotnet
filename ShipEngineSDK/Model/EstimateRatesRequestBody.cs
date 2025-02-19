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
/// A rate estimate request body
/// </summary>
[JsonConverter(typeof(EstimateRatesRequestBodyJsonConverter))]
//[DataContract(Name = "estimate_rates_request_body")]
public partial class EstimateRatesRequestBody : AbstractOpenAPISchema
{

    /// <summary>
    /// from postal code
    /// </summary>
    /// <value>from postal code</value>
    /// <example>
    /// Austin
    /// </example>
    [JsonPropertyName("from_city_locality"), JsonPropertyOrder(1)]
    public required string FromCityLocality { get; set; }

    /// <summary>
    /// A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) 
    /// </summary>
    /// <value>A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) </value>
    /// <example>
    /// CA
    /// </example>
    [JsonPropertyName("from_country_code"), JsonPropertyOrder(2)]
    public required string FromCountryCode { get; set; }

    /// <summary>
    /// postal code
    /// </summary>
    /// <value>postal code</value>
    /// <example>
    /// 78756-3717
    /// </example>
    [JsonPropertyName("from_postal_code"), JsonPropertyOrder(3)]
    public required string FromPostalCode { get; set; }

    /// <summary>
    /// From state province
    /// </summary>
    /// <value>From state province</value>
    /// <example>
    /// Austin
    /// </example>
    [JsonPropertyName("from_state_province"), JsonPropertyOrder(4)]
    public required string FromStateProvince { get; set; }

    /// <summary>
    /// ship date
    /// </summary>
    /// <value>ship date</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("ship_date"), JsonPropertyOrder(5)]
    public required DateTimeOffset ShipDate { get; set; }

    /// <summary>
    /// The city locality the package is being shipped to
    /// </summary>
    /// <value>The city locality the package is being shipped to</value>
    /// <example>
    /// Austin
    /// </example>
    [JsonPropertyName("to_city_locality"), JsonPropertyOrder(6)]
    public required string ToCityLocality { get; set; }

    /// <summary>
    /// A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) 
    /// </summary>
    /// <value>A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) </value>
    /// <example>
    /// CA
    /// </example>
    [JsonPropertyName("to_country_code"), JsonPropertyOrder(7)]
    public required string ToCountryCode { get; set; }

    /// <summary>
    /// postal code
    /// </summary>
    /// <value>postal code</value>
    /// <example>
    /// 78756-3717
    /// </example>
    [JsonPropertyName("to_postal_code"), JsonPropertyOrder(8)]
    public required string ToPostalCode { get; set; }

    /// <summary>
    /// To state province
    /// </summary>
    /// <value>To state province</value>
    /// <example>
    /// Houston
    /// </example>
    [JsonPropertyName("to_state_province"), JsonPropertyOrder(9)]
    public required string ToStateProvince { get; set; }

    /// <summary>
    /// The weight of the package
    /// </summary>
    /// <value>The weight of the package</value>
    [JsonPropertyName("weight"), JsonPropertyOrder(10)]
    public required Weight Weight { get; set; }

    /// <summary>
    /// Gets or Sets AddressResidentialIndicator
    /// </summary>
    [JsonPropertyName("address_residential_indicator"), JsonPropertyOrder(11)]
    public AddressResidentialIndicator? AddressResidentialIndicator { get; set; }    /// <summary>
    /// Gets or Sets Confirmation
    /// </summary>
    [JsonPropertyName("confirmation"), JsonPropertyOrder(12)]
    public DeliveryConfirmation? Confirmation { get; set; }    /// <summary>
    /// The dimensions of the package
    /// </summary>
    /// <value>The dimensions of the package</value>
    [JsonPropertyName("dimensions"), JsonPropertyOrder(13)]
    public Dimensions? Dimensions { get; set; }


    /// <summary>
    /// Initializes a new instance of the <see cref="EstimateRatesRequestBody" /> class
    /// with the <see cref="RateEstimateByCarrierId" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of RateEstimateByCarrierId.</param>
    public EstimateRatesRequestBody(RateEstimateByCarrierId actualInstance) : base("oneOf")
    {
        this.IsNullable = false;
        _actualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EstimateRatesRequestBody" /> class
    /// with the <see cref="RateEstimateByCarrierIds" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of RateEstimateByCarrierIds.</param>
    public EstimateRatesRequestBody(RateEstimateByCarrierIds actualInstance) : base("oneOf")
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
            if (value.GetType() == typeof(RateEstimateByCarrierId))
            {
                this._actualInstance = value;
            }
            else if (value.GetType() == typeof(RateEstimateByCarrierIds))
            {
                this._actualInstance = value;
            }
            else
            {
                throw new ArgumentException("Invalid instance found. Must be the following types: RateEstimateByCarrierId, RateEstimateByCarrierIds");
            }
        }
    }

    /// <summary>
    /// Get the actual instance of `RateEstimateByCarrierId`. If the actual instance is not `RateEstimateByCarrierId`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of RateEstimateByCarrierId</returns>
    public RateEstimateByCarrierId GetRateEstimateByCarrierId()
    {
        return (RateEstimateByCarrierId)this.ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `RateEstimateByCarrierIds`. If the actual instance is not `RateEstimateByCarrierIds`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of RateEstimateByCarrierIds</returns>
    public RateEstimateByCarrierIds GetRateEstimateByCarrierIds()
    {
        return (RateEstimateByCarrierIds)this.ActualInstance;
    }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EstimateRatesRequestBody {\n");
        sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
        sb.Append("  FromCityLocality: ").Append(this.FromCityLocality).Append("\n");
        sb.Append("  FromCountryCode: ").Append(this.FromCountryCode).Append("\n");
        sb.Append("  FromPostalCode: ").Append(this.FromPostalCode).Append("\n");
        sb.Append("  FromStateProvince: ").Append(this.FromStateProvince).Append("\n");
        sb.Append("  ShipDate: ").Append(this.ShipDate).Append("\n");
        sb.Append("  ToCityLocality: ").Append(this.ToCityLocality).Append("\n");
        sb.Append("  ToCountryCode: ").Append(this.ToCountryCode).Append("\n");
        sb.Append("  ToPostalCode: ").Append(this.ToPostalCode).Append("\n");
        sb.Append("  ToStateProvince: ").Append(this.ToStateProvince).Append("\n");
        sb.Append("  Weight: ").Append(this.Weight).Append("\n");
        sb.Append("  AddressResidentialIndicator: ").Append(this.AddressResidentialIndicator).Append("\n");
        sb.Append("  Confirmation: ").Append(this.Confirmation).Append("\n");
        sb.Append("  Dimensions: ").Append(this.Dimensions).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public override string ToJson()
    {
        return JsonSerializer.Serialize(this.ActualInstance, EstimateRatesRequestBody.SerializerSettings);
    }

}

/// <summary>
/// Custom JSON converter for EstimateRatesRequestBody
/// </summary>
public class EstimateRatesRequestBodyJsonConverter : JsonConverter<EstimateRatesRequestBody>
{
    private static readonly HashSet<Type> OneOfTypes = [typeof(RateEstimateByCarrierId), typeof(RateEstimateByCarrierIds)];
    private static readonly HashSet<string> MandatoryFields = ["FromCityLocality", "FromCountryCode", "FromPostalCode", "FromStateProvince", "ShipDate", "ToCityLocality", "ToCountryCode", "ToPostalCode", "ToStateProvince", "Weight"];
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
    public override void Write(Utf8JsonWriter writer, EstimateRatesRequestBody value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WritePropertyName("from_city_locality");
        JsonSerializer.Serialize(writer, value.FromCityLocality, options);
        writer.WritePropertyName("from_country_code");
        JsonSerializer.Serialize(writer, value.FromCountryCode, options);
        writer.WritePropertyName("from_postal_code");
        JsonSerializer.Serialize(writer, value.FromPostalCode, options);
        writer.WritePropertyName("from_state_province");
        JsonSerializer.Serialize(writer, value.FromStateProvince, options);
        writer.WritePropertyName("ship_date");
        JsonSerializer.Serialize(writer, value.ShipDate, options);
        writer.WritePropertyName("to_city_locality");
        JsonSerializer.Serialize(writer, value.ToCityLocality, options);
        writer.WritePropertyName("to_country_code");
        JsonSerializer.Serialize(writer, value.ToCountryCode, options);
        writer.WritePropertyName("to_postal_code");
        JsonSerializer.Serialize(writer, value.ToPostalCode, options);
        writer.WritePropertyName("to_state_province");
        JsonSerializer.Serialize(writer, value.ToStateProvince, options);
        writer.WritePropertyName("weight");
        JsonSerializer.Serialize(writer, value.Weight, options);
        writer.WritePropertyName("address_residential_indicator");
        JsonSerializer.Serialize(writer, value.AddressResidentialIndicator, options);
        writer.WritePropertyName("confirmation");
        JsonSerializer.Serialize(writer, value.Confirmation, options);
        writer.WritePropertyName("dimensions");
        JsonSerializer.Serialize(writer, value.Dimensions, options);

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
    public override EstimateRatesRequestBody? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        var jsonDoc = JsonDocument.ParseValue(ref reader);
        EstimateRatesRequestBody? newEstimateRatesRequestBody = null;

        // Deserialize all the common properties of the model so they can be used in object initializers later
        var fromCityLocality = jsonDoc.RootElement.GetProperty("from_city_locality").Deserialize<string>(DeserializingOptions)!;
        var fromCountryCode = jsonDoc.RootElement.GetProperty("from_country_code").Deserialize<string>(DeserializingOptions)!;
        var fromPostalCode = jsonDoc.RootElement.GetProperty("from_postal_code").Deserialize<string>(DeserializingOptions)!;
        var fromStateProvince = jsonDoc.RootElement.GetProperty("from_state_province").Deserialize<string>(DeserializingOptions)!;
        var shipDate = jsonDoc.RootElement.GetProperty("ship_date").Deserialize<DateTimeOffset>(DeserializingOptions)!;
        var toCityLocality = jsonDoc.RootElement.GetProperty("to_city_locality").Deserialize<string>(DeserializingOptions)!;
        var toCountryCode = jsonDoc.RootElement.GetProperty("to_country_code").Deserialize<string>(DeserializingOptions)!;
        var toPostalCode = jsonDoc.RootElement.GetProperty("to_postal_code").Deserialize<string>(DeserializingOptions)!;
        var toStateProvince = jsonDoc.RootElement.GetProperty("to_state_province").Deserialize<string>(DeserializingOptions)!;
        var weight = jsonDoc.RootElement.GetProperty("weight").Deserialize<Weight>(DeserializingOptions)!;
        var addressResidentialIndicator = jsonDoc.RootElement.GetProperty("address_residential_indicator").Deserialize<AddressResidentialIndicator>(DeserializingOptions)!;
        var confirmation = jsonDoc.RootElement.GetProperty("confirmation").Deserialize<DeliveryConfirmation>(DeserializingOptions)!;
        var dimensions = jsonDoc.RootElement.GetProperty("dimensions").Deserialize<Dimensions>(DeserializingOptions)!;

        int match = 0;
        var matchedTypes = new List<string>();

        try
        {
            newEstimateRatesRequestBody = new EstimateRatesRequestBody(jsonDoc.Deserialize<RateEstimateByCarrierId>(DeserializingOptions)!)
            {
                FromCityLocality = fromCityLocality,
                FromCountryCode = fromCountryCode,
                FromPostalCode = fromPostalCode,
                FromStateProvince = fromStateProvince,
                ShipDate = shipDate,
                ToCityLocality = toCityLocality,
                ToCountryCode = toCountryCode,
                ToPostalCode = toPostalCode,
                ToStateProvince = toStateProvince,
                Weight = weight,
                AddressResidentialIndicator = addressResidentialIndicator,
                Confirmation = confirmation,
                Dimensions = dimensions,
            };

            matchedTypes.Add("RateEstimateByCarrierId");
            match++;
        }
        catch (Exception exception)
        {
            // deserialization failed, try the next one
            System.Diagnostics.Debug.WriteLine("Failed to deserialize `{0}` into RateEstimateByCarrierId: {1}", jsonDoc, exception);
        }

        try
        {
            newEstimateRatesRequestBody = new EstimateRatesRequestBody(jsonDoc.Deserialize<RateEstimateByCarrierIds>(DeserializingOptions)!)
            {
                FromCityLocality = fromCityLocality,
                FromCountryCode = fromCountryCode,
                FromPostalCode = fromPostalCode,
                FromStateProvince = fromStateProvince,
                ShipDate = shipDate,
                ToCityLocality = toCityLocality,
                ToCountryCode = toCountryCode,
                ToPostalCode = toPostalCode,
                ToStateProvince = toStateProvince,
                Weight = weight,
                AddressResidentialIndicator = addressResidentialIndicator,
                Confirmation = confirmation,
                Dimensions = dimensions,
            };

            matchedTypes.Add("RateEstimateByCarrierIds");
            match++;
        }
        catch (Exception exception)
        {
            // deserialization failed, try the next one
            System.Diagnostics.Debug.WriteLine("Failed to deserialize `{0}` into RateEstimateByCarrierIds: {1}", jsonDoc, exception);
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
        return newEstimateRatesRequestBody;
    }

    /// <summary>
    /// Check if the object can be converted
    /// </summary>
    /// <param name="objectType">Object type</param>
    /// <returns>True if the object can be converted</returns>
    public override bool CanConvert(Type objectType)
    {
        return typeof(EstimateRatesRequestBody).IsAssignableFrom(objectType);
    }
}