// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Models;
//
//    var trackShipmentResult = TrackPackageResult.FromJson(jsonString);

using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShipEngine.Models.Package.Dto
{

    public partial class TrackPackageResult
    {
        [JsonProperty("information")]
        public Information Information { get; set; }

        [JsonProperty("messages")]
        public Messages Messages { get; set; }
    }

    public partial class Information
    {
        [JsonProperty("estimated_delivery")]
        public DateTime EstimatedDelivery { get; set; }

        [JsonProperty("events")]
        public List<Event> Events { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }
    }

    public partial class Event
    {
        [JsonProperty("carrier_detail_code")]
        public string CarrierDetailCode { get; set; }

        [JsonProperty("carrier_status_code")]
        public string CarrierStatusCode { get; set; }

        [JsonProperty("date_time")]
        public DateTime DateTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("signer", NullValueHandling = NullValueHandling.Ignore)]
        public string Signer { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("city_locality")]
        public string CityLocality { get; set; }

        [JsonProperty("coordinates", NullValueHandling = NullValueHandling.Ignore)]
        public Coordinates Coordinates { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }
    }

    public partial class Coordinates
    {
        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleMinMaxValueCheckConverter))]
        public double? Latitude { get; set; }

        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyMinMaxValueCheckConverter))]
        public double? Longitude { get; set; }
    }


    public enum Status { Accepted, AttemptedDelivery, Delivered, Exception, InTransit, Unknown };

    public partial class TrackPackageResult
    {
        public static TrackPackageResult FromJson(string json) => JsonConvert.DeserializeObject<TrackPackageResult>(json, Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this TrackPackageResult self) => JsonConvert.SerializeObject(self, Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                StatusConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class PurpleMinMaxValueCheckConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(double) || t == typeof(double?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<double>(reader);
            if (value >= -90 && value <= 90)
            {
                return value;
            }
            throw new Exception("Cannot unmarshal type double");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (double)untypedValue;
            if (value >= -90 && value <= 90)
            {
                serializer.Serialize(writer, value);
                return;
            }
            throw new Exception("Cannot marshal type double");
        }

        public static readonly PurpleMinMaxValueCheckConverter Singleton = new PurpleMinMaxValueCheckConverter();
    }

    internal class FluffyMinMaxValueCheckConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(double) || t == typeof(double?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<double>(reader);
            if (value >= -180 && value <= 180)
            {
                return value;
            }
            throw new Exception("Cannot unmarshal type double");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (double)untypedValue;
            if (value >= -180 && value <= 180)
            {
                serializer.Serialize(writer, value);
                return;
            }
            throw new Exception("Cannot marshal type double");
        }

        public static readonly FluffyMinMaxValueCheckConverter Singleton = new FluffyMinMaxValueCheckConverter();
    }

    internal class StatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ACCEPTED":
                    return Status.Accepted;
                case "ATTEMPTED DELIVERY":
                    return Status.AttemptedDelivery;
                case "DELIVERED":
                    return Status.Delivered;
                case "EXCEPTION":
                    return Status.Exception;
                case "IN TRANSIT":
                    return Status.InTransit;
                case "UNKNOWN":
                    return Status.Unknown;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Status)untypedValue;
            switch (value)
            {
                case Status.Accepted:
                    serializer.Serialize(writer, "ACCEPTED");
                    return;
                case Status.AttemptedDelivery:
                    serializer.Serialize(writer, "ATTEMPTED DELIVERY");
                    return;
                case Status.Delivered:
                    serializer.Serialize(writer, "DELIVERED");
                    return;
                case Status.Exception:
                    serializer.Serialize(writer, "EXCEPTION");
                    return;
                case Status.InTransit:
                    serializer.Serialize(writer, "IN TRANSIT");
                    return;
                case Status.Unknown:
                    serializer.Serialize(writer, "UNKNOWN");
                    return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }
}
