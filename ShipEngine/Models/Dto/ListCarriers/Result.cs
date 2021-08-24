using ShipEngineSDK.Common;
using System.Collections.Generic;

namespace ShipEngineSDK.ListCarriers.Result
{
    public class CarrierResponse
    {
        public List<Carrier>? Carriers { get; set; }

        public string? RequestId { get; set; }

        public List<Error>? Errors { get; set; }
    }


    public class Carrier
    {
        /**
         * The carrier ID
         */
        public string? CarrierId { get; set; }

        /**
         * The code associated with the carrier
         */
        public string? CarrierCode { get; set; }

        /**
         * The ShipEngine account number connected to this carrier
         */
        public string? AccountNumber { get; set; }

        /**
         * Flag indicating if carrier requires funding
         */
        public bool? RequiresFundedAmount { get; set; }

        /**
         * The carrier account balance
         */
        public double? Balance { get; set; }

        /**
         * The carrier account nickname
         */
        public string? Nickname { get; set; }

        /**
         * The carrier account friendly name
         */
        public string? FriendlyName { get; set; }

        /**
         * Flag indicating if this is the primary account
         */
        public bool? Primary { get; set; }

        /**
         * Flag indicating if the carrier supports multi package shipments
         */
        public bool? HasMultiPackageSupportingServices { get; set; }

        /**
         * Flag indicating if the carrier supports label messages
         */
        public bool? SupportsLabelMessages { get; set; }

        /**
         * Array of supported carrier services
         */
        public List<Service>? Services { get; set; }

        /**
         * Array of supported package types
         */
        public List<PackageType>? Packages { get; set; }

        /**
         * Array of supported advanced options
         */
        public List<AdvancedOption>? Options { get; set; }
    }

    public class Service
    {
        /**
         * The carrier ID
         */
        public string? CarrierId { get; set; }
        /**
         * The code associated with the carrier for this service
         */

        public string? CarrierCode { get; set; }

        /**
         * The code associated with the service
         */
        public string? ServiceCode { get; set; }

        /**
         * The name of the service
         */
        public string? Name { get; set; }

        /**
         * Flag indicating if the service is domestic
         */
        public bool? Domestic { get; set; }

        /**
         * Flag indicating if the service is international
         */
        public bool? International { get; set; }

        /**
         * Flag indicating if the service supports multi package shipments
         */
        public bool? IsMultiPackageSupported { get; set; }
    }

    public class PackageType
    {
        /**
         * The package type ID
         */

        public string? PackageId { get; set; }

        /**
         * The package type code
         */

        public string? PackageCode { get; set; }

        /**
         * The package type name
         */
        public string? Name { get; set; }

        /**
         * The package type dimensions
         */
        public Dimensions? Dimensions { get; set; }

        public string? Description { get; set; }
    }


    public class Dimensions
    {
        // TODO: Add enum
        public string? Unit { get; set; }

        public double? Length { get; set; }

        public double? Width { get; set; }

        public double? Height { get; set; }
    }

    public class AdvancedOption
    {
        public string? Name { get; set; }

        public string? DefaultValue { get; set; }

        public string? Description { get; set; }
    }
}