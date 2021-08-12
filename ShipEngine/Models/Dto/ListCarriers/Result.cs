using ShipEngineSDK.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace ShipEngineSDK.ListCarriers.Result
{
    public class CarrierResponse
    {
        [JsonPropertyName("carriers")]
        public List<Carrier>? Carriers { get; set; }

        [JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        [JsonPropertyName("errors")]
        public List<Error>? Errors { get; set; }
    }


    public class Carrier
    {
        /**
         * The carrier ID
         */
        [JsonPropertyName("carrier_id")]
        public string? CarrierId { get; set; }

        /**
         * The code associated with the carrier
         */
        [JsonPropertyName("carrier_code")]
        public string? CarrierCode { get; set; }

        /**
         * The ShipEngine account number connected to this carrier
         */
        [JsonPropertyName("account_number")]
        public string? AccountNumber { get; set; }

        /**
         * Flag indicating if carrier requires funding
         */
        [JsonPropertyName("requires_funded_amount")]
        public bool? RequiresFundedAmount { get; set; }

        /**
         * The carrier account balance
         */
        [JsonPropertyName("balance")]
        public double? Balance { get; set; }

        /**
         * The carrier account nickname
         */
        [JsonPropertyName("nickname")]
        public string? Nickname { get; set; }

        /**
         * The carrier account friendly name
         */
        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; set; }

        /**
         * Flag indicating if this is the primary account
         */
        [JsonPropertyName("primary")]
        public bool? Primary { get; set; }

        /**
         * Flag indicating if the carrier supports multi package shipments
         */
        [JsonPropertyName("has_multi_package_supporting_services")]
        public bool? HasMultiPackageSupportingServices { get; set; }

        /**
         * Flag indicating if the carrier supports label messages
         */
        [JsonPropertyName("supports_label_messages")]
        public bool? SupportsLabelMessages { get; set; }

        /**
         * Array of supported carrier services
         */
        [JsonPropertyName("services")]
        public List<Service>? Services { get; set; }

        /**
         * Array of supported package types
         */
        [JsonPropertyName("packages")]
        public List<PackageType>? Packages { get; set; }

        /**
         * Array of supported advanced options
         */
        [JsonPropertyName("options")]
        public List<AdvancedOption>? Options { get; set; }
    }

    public class Service
    {
        /**
         * The carrier ID
         */
        [JsonPropertyName("carrier_id")]
        public string? CarrierId { get; set; }
        /**
         * The code associated with the carrier for this service
         */
        [JsonPropertyName("carrier_code")]

        public string? CarrierCode { get; set; }

        /**
         * The code associated with the service
         */
        [JsonPropertyName("service_code")]
        public string? ServiceCode { get; set; }

        /**
         * The name of the service
         */
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /**
         * Flag indicating if the service is domestic
         */
        [JsonPropertyName("domestic")]
        public bool? Domestic { get; set; }

        /**
         * Flag indicating if the service is international
         */
        [JsonPropertyName("international")]
        public bool? International { get; set; }

        /**
         * Flag indicating if the service supports multi package shipments
         */
        [JsonPropertyName("is_multi_package_supported")]
        public bool? IsMultiPackageSupported { get; set; }
    }

    public class PackageType
    {
        /**
         * The package type ID
         */

        [JsonPropertyName("package_id")]
        public string? PackageId { get; set; }

        /**
         * The package type code
         */

        [JsonPropertyName("package_code")]
        public string? PackageCode { get; set; }

        /**
         * The package type name
         */
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /**
         * The package type dimensions
         */
        [JsonPropertyName("dimensions")]
        public Dimensions? Dimensions { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }


    public class Dimensions
    {
        // TODO: Add enum
        [JsonPropertyName("unit")]
        public string? Unit { get; set; }

        [JsonPropertyName("length")]
        public double? Length { get; set; }

        [JsonPropertyName("width")]
        public double? Width { get; set; }

        [JsonPropertyName("height")]
        public double? Height { get; set; }
    }

    public class AdvancedOption
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("default_value")]
        public string? DefaultValue { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}