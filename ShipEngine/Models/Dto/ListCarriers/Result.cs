#nullable disable

using ShipEngineSDK.Common;
using ShipEngineSDK.Common.Enums;
using System.Collections.Generic;

namespace ShipEngineSDK.ListCarriers.Result
{
    /// <summary>
    /// List Carrier Results
    /// </summary>
    public class CarrierInfo
    {
        /// <summary>
        /// List of carriers associated with the account
        /// </summary>
        public List<Carrier> Carriers { get; set; }

        /// <summary>
        /// The request id associated with the method call
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// List of errors that occurred while retrieving carriers
        /// </summary>
        public List<Error> Errors { get; set; }
    }

    /// <summary>
    /// Carrier information
    /// </summary>
    public class Carrier
    {
        /// <summary>
        /// The carrier ID
        /// </summary>
        public string CarrierId { get; set; }

        /// <summary>
        /// The code associated with the carrier
        /// </summary>
        public string CarrierCode { get; set; }

        /// <summary>
        /// The ShipEngine account number connected to this carrier
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Flag indicating if carrier requires funding
        /// </summary>
        public bool RequiresFundedAmount { get; set; }

        /// <summary>
        /// The carrier account balance
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// The carrier account nickname
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// The carrier account friendly name
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Flag indicating if this is the primary account
        /// </summary>
        public bool Primary { get; set; }

        /// <summary>
        /// Flag indicating if the carrier supports multi package shipments
        /// </summary>
        public bool HasMultiPackageSupportingServices { get; set; }

        /// <summary>
        /// Flag indicating if the carrier supports label messages
        /// </summary>
        public bool SupportsLabelMessages { get; set; }

        /// <summary>
        /// Array of supported carrier services
        /// </summary>
        public List<Service> Services { get; set; }

        /// <summary>
        /// Array of supported package types
        /// </summary>
        public List<PackageType> Packages { get; set; }

        /// <summary>
        /// Array of supported advanced options
        /// </summary>
        public List<AdvancedOption> Options { get; set; }
    }

    /// <summary>
    /// Carrier Service information
    /// </summary>
    public class Service
    {
        /// <summary>
        /// The carrier ID
        /// </summary>
        public string CarrierId { get; set; }
        /// <summary>
        /// The code associated with the carrier for this service
        /// </summary>

        public string CarrierCode { get; set; }

        /// <summary>
        /// The code associated with the service
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// The name of the service
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Flag indicating if the service is domestic
        /// </summary>
        public bool Domestic { get; set; }

        /// <summary>
        /// Flag indicating if the service is international
        /// </summary>
        public bool International { get; set; }

        /// <summary>
        /// Flag indicating if the service supports multi package shipments
        /// </summary>
        public bool IsMultiPackageSupported { get; set; }
    }

    /// <summary>
    /// Package types supported by the carrier
    /// </summary>
    public class PackageType
    {
        /// <summary>
        /// The package type ID
        /// </summary>
        public string PackageId { get; set; }

        /// <summary>
        /// The package type code
        /// </summary>
        public string PackageCode { get; set; }

        /// <summary>
        /// The package type name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The package type dimensions
        /// </summary>
        public Dimensions Dimensions { get; set; }

        /// <summary>
        /// The package type description
        /// </summary>
        public string Description { get; set; }
    }

    /// <summary>
    /// Advanced options supported by the carrier
    /// </summary>A
    public class AdvancedOption
    {
        /// <summary>
        /// Name of advanced option
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Default value of option
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Description of option
        /// </summary>
        public string Description { get; set; }
    }
}