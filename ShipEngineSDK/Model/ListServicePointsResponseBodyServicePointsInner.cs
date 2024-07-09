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
/// ListServicePointsResponseBodyServicePointsInner
/// </summary>
public partial class ListServicePointsResponseBodyServicePointsInner
{
    //    
    //    /// <summary>
    //    /// Defines Features
    //    /// </summary>
    //    
    //    public static class FeaturesEnum
    //    {
    //        private static readonly HashSet<string> _values = new()
    //        {
    //            
    //            
    //            "drop_off_point",
    //            
    //            "pickup_point",
    //            
    //            "print_services",
    //            
    //            "after_hours_locker",
    //            
    //            "after_hours_dropbox",
    //            
    //            
    //        };
    //
    //        
    //        
    //        
    //        public static string DefaultValue => DropOffPoint;
    //        
    //        
    //        /// <summary>
    //        /// Enum DropOffPoint for value: drop_off_point
    //        /// </summary>
    //        public static string DropOffPoint { get; } = "drop_off_point";
    //        
    //
    //        
    //        
    //        
    //        
    //        /// <summary>
    //        /// Enum PickupPoint for value: pickup_point
    //        /// </summary>
    //        public static string PickupPoint { get; } = "pickup_point";
    //        
    //
    //        
    //        
    //        
    //        
    //        /// <summary>
    //        /// Enum PrintServices for value: print_services
    //        /// </summary>
    //        public static string PrintServices { get; } = "print_services";
    //        
    //
    //        
    //        
    //        
    //        
    //        /// <summary>
    //        /// Enum AfterHoursLocker for value: after_hours_locker
    //        /// </summary>
    //        public static string AfterHoursLocker { get; } = "after_hours_locker";
    //        
    //
    //        
    //        
    //        
    //        
    //        /// <summary>
    //        /// Enum AfterHoursDropbox for value: after_hours_dropbox
    //        /// </summary>
    //        public static string AfterHoursDropbox { get; } = "after_hours_dropbox";
    //        
    //        
    //        
    //
    //        /// <summary>
    //        /// Is the given value a valid FeaturesEnum?
    //        /// </summary>
    //        public static bool IsValid(string value)
    //        {
    //            return _values.Contains(value);
    //        }
    //    }
    //    




    /// <summary>
    /// Defines Features
    /// </summary>
    [JsonConverter(typeof(FeaturesEnumJsonConverter))]
    public class FeaturesEnum
    {
        private string _value;

        internal FeaturesEnum()
        {
            _value = "drop_off_point";
        }

        public FeaturesEnum(string value)
        {

        }

        /// <summary>
        /// Enum DropOffPoint for value: drop_off_point
        /// </summary>
        public static FeaturesEnum DropOffPoint { get; } = new("drop_off_point");


        /// <summary>
        /// Enum PickupPoint for value: pickup_point
        /// </summary>
        public static FeaturesEnum PickupPoint { get; } = new("pickup_point");


        /// <summary>
        /// Enum PrintServices for value: print_services
        /// </summary>
        public static FeaturesEnum PrintServices { get; } = new("print_services");


        /// <summary>
        /// Enum AfterHoursLocker for value: after_hours_locker
        /// </summary>
        public static FeaturesEnum AfterHoursLocker { get; } = new("after_hours_locker");


        /// <summary>
        /// Enum AfterHoursDropbox for value: after_hours_dropbox
        /// </summary>
        public static FeaturesEnum AfterHoursDropbox { get; } = new("after_hours_dropbox");


        public override string ToString() => _value;
    }

    internal class FeaturesEnumJsonConverter : JsonConverter<FeaturesEnum>
    {
        public override FeaturesEnum? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            reader.TokenType == JsonTokenType.String ? new FeaturesEnum(reader.GetString()) : null;

        public override void Write(Utf8JsonWriter writer, FeaturesEnum value, JsonSerializerOptions options) =>
            writer.WriteStringValue(value.ToString());

        public override bool CanConvert(Type typeToConvert) =>
            typeToConvert == typeof(FeaturesEnum);
    }

    //    
    //    /// <summary>
    //    /// Service point type
    //    /// </summary>
    //    
    //    /// <value>Service point type</value>
    //    
    //    public static class TypeEnum
    //    {
    //        private static readonly HashSet<string> _values = new()
    //        {
    //            
    //            
    //            "pudo",
    //            
    //            "locker",
    //            
    //            
    //        };
    //
    //        
    //        
    //        
    //        public static string DefaultValue => Pudo;
    //        
    //        
    //        /// <summary>
    //        /// Enum Pudo for value: pudo
    //        /// </summary>
    //        public static string Pudo { get; } = "pudo";
    //        
    //
    //        
    //        
    //        
    //        
    //        /// <summary>
    //        /// Enum Locker for value: locker
    //        /// </summary>
    //        public static string Locker { get; } = "locker";
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
    /// Service point type
    /// </summary>
    /// <value>Service point type</value>
    [JsonConverter(typeof(TypeEnumJsonConverter))]
    public class TypeEnum
    {
        private string _value;

        internal TypeEnum()
        {
            _value = "pudo";
        }

        public TypeEnum(string value)
        {

        }

        /// <summary>
        /// Enum Pudo for value: pudo
        /// </summary>
        public static TypeEnum Pudo { get; } = new("pudo");


        /// <summary>
        /// Enum Locker for value: locker
        /// </summary>
        public static TypeEnum Locker { get; } = new("locker");


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
    /// Service point type  CLOVUS
    /// </summary>
    /// <value>Service point type</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc. 
    /// </summary>
    /// <value>A [shipping carrier](https://www.shipengine.com/docs/carriers/setup/), such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc. </value>
    /// <example>
    /// dhl_express
    /// </example>
    [JsonPropertyName("carrier_code")]
    public string CarrierCode { get; set; }

    /// <summary>
    /// Gets or Sets ServiceCodes
    /// </summary>
    [JsonPropertyName("service_codes")]
    public List<string> ServiceCodes { get; set; }

    /// <summary>
    /// A unique identifier for a carrier drop off point.
    /// </summary>
    /// <value>A unique identifier for a carrier drop off point.</value>
    /// <example>
    /// 614940
    /// </example>
    [JsonPropertyName("service_point_id")]
    public string ServicePointId { get; set; }

    /// <summary>
    /// If this is a business address, then the company name should be specified here.
    /// </summary>
    /// <value>If this is a business address, then the company name should be specified here.</value>
    /// <example>
    /// My fancy company name
    /// </example>
    [JsonPropertyName("company_name")]
    public string CompanyName { get; set; }

    /// <summary>
    /// The first line of the street address.  For some addresses, this may be the only line.  Other addresses may require 2 or 3 lines.
    /// </summary>
    /// <value>The first line of the street address.  For some addresses, this may be the only line.  Other addresses may require 2 or 3 lines.</value>
    /// <example>
    /// PLACE DU CANADA
    /// </example>
    [JsonPropertyName("address_line1")]
    public string AddressLine1 { get; set; }

    /// <summary>
    /// The name of the city or locality
    /// </summary>
    /// <value>The name of the city or locality</value>
    /// <example>
    /// TRUN
    /// </example>
    [JsonPropertyName("city_locality")]
    public string CityLocality { get; set; }

    /// <summary>
    /// The state or province. For some countries (including the U.S.) only abbreviations are allowed. Other countries allow the full name or abbreviation.
    /// </summary>
    /// <value>The state or province. For some countries (including the U.S.) only abbreviations are allowed. Other countries allow the full name or abbreviation.</value>
    /// <example>
    /// TRUN
    /// </example>
    [JsonPropertyName("state_province")]
    public string StateProvince { get; set; }

    /// <summary>
    /// postal code
    /// </summary>
    /// <value>postal code</value>
    /// <example>
    /// 78756-3717
    /// </example>
    [JsonPropertyName("postal_code")]
    public string PostalCode { get; set; }

    /// <summary>
    /// A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) 
    /// </summary>
    /// <value>A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) </value>
    /// <example>
    /// CA
    /// </example>
    [JsonPropertyName("country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Phone number associated
    /// </summary>
    /// <value>Phone number associated</value>
    /// <example>
    /// 555-555-5555
    /// </example>
    [JsonPropertyName("phone_number")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// The latitude of the point. Represented as signed degrees. Required if long is provided. http://www.geomidpoint.com/latlon.html
    /// </summary>
    /// <value>The latitude of the point. Represented as signed degrees. Required if long is provided. http://www.geomidpoint.com/latlon.html</value>
    /// <example>
    /// 48.842608
    /// </example>
    [JsonPropertyName("lat")]
    public double Lat { get; set; }

    /// <summary>
    /// The longitude of the point. Represented as signed degrees. Required if lat is provided. http://www.geomidpoint.com/latlon.html
    /// </summary>
    /// <value>The longitude of the point. Represented as signed degrees. Required if lat is provided. http://www.geomidpoint.com/latlon.html</value>
    /// <example>
    /// 0.032875
    /// </example>
    [JsonPropertyName("long")]
    public double Long { get; set; }

    /// <summary>
    /// Distance in meters
    /// </summary>
    /// <value>Distance in meters</value>
    /// <example>
    /// 728.9959308847579
    /// </example>
    [JsonPropertyName("distance_in_meters")]
    public double DistanceInMeters { get; set; }

    /// <summary>
    /// Gets or Sets HoursOfOperation
    /// </summary>
    [JsonPropertyName("hours_of_operation")]
    public ListServicePointsResponseBodyServicePointsInnerHoursOfOperation HoursOfOperation { get; set; }

    /// <summary>
    /// Service features
    /// </summary>
    /// <value>Service features</value>
    [JsonPropertyName("features")]
    public List<ListServicePointsResponseBodyServicePointsInner.FeaturesEnum> Features { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ListServicePointsResponseBodyServicePointsInner {\n");
        sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
        sb.Append("  ServiceCodes: ").Append(ServiceCodes).Append("\n");
        sb.Append("  ServicePointId: ").Append(ServicePointId).Append("\n");
        sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
        sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
        sb.Append("  CityLocality: ").Append(CityLocality).Append("\n");
        sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
        sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
        sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
        sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
        sb.Append("  Lat: ").Append(Lat).Append("\n");
        sb.Append("  Long: ").Append(Long).Append("\n");
        sb.Append("  DistanceInMeters: ").Append(DistanceInMeters).Append("\n");
        sb.Append("  HoursOfOperation: ").Append(HoursOfOperation).Append("\n");
        sb.Append("  Features: ").Append(Features).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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