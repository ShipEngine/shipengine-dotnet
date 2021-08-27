


using ShipEngineSDK.Common;
using ShipEngineSDK.Common.Enums;
using System.Collections.Generic;

namespace ShipEngineSDK.CreateLabelFromShipmentDetails.Result
{
    public class LabelResult
    {
        /// <summary>
        /// A string that uniquely identifies the label. This ID is generated by ShipEngine when the label is created.
        /// </summary>
        public string? LabelId { get; set; }

        /// <summary>
        /// The possible statuses that a shipping label can be in.
        /// </summary>
        public LabelStatus? Status { get; set; }

        /// <summary>
        /// The shipment that this label is for. ShipEngine can create a shipment for you automatically when you create a label,
        /// or you can create your own shipment and then use it to print a label
        /// </summary>
        public string? ShipmentId { get; set; }

        /// <summary>
        /// The date that the package was (or will be) shippped. ShipEngine will take the day of week into consideration.
        /// For example, if the carrier does not operate on Sundays, then a package that would have shipped on Sunday will ship on Monday instead.
        /// </summary>
        public string? ShipDate { get; set; }

        /// <summary>
        /// The date and time that the label was created in ShipEngine.
        /// </summary>
        public string? CreatedAt { get; set; }

        /// <summary>
        /// The cost of shipping, delivery confirmation, and other carrier charges. This amount does not include insurance costs.
        /// </summary>
        public MonetaryValue? ShipmentCost { get; set; }

        /// <summary>
        /// The insurance cost for this package. Add this to the shipment_cost field to get the total cost.
        /// </summary>
        public MonetaryValue? InsuranceCost { get; set; }

        /// <summary>
        /// The tracking number for the package. Tracking number formats vary across carriers.
        /// </summary>
        public string? TrackingNumber { get; set; }

        /// <summary>
        /// Indicates whether this is a return label. You may also want to set the rma_number so you know what is being returned.
        /// </summary>
        public bool? IsReturnLabel { get; set; }

        /// <summary>
        /// An optional Return Merchandise Authorization number. This field is useful for return labels. You can set it to any string value.
        /// </summary>
        public string? RmaNumber { get; set; }

        /// <summary>
        /// Indicates whether this is an international shipment. That is, the originating country and destination country are different.
        /// </summary>
        public bool? IsInternational { get; set; }

        /// <summary>
        /// If this label was created as part of a batch, then this is the unique ID of that batch.
        /// </summary>
        public string? BatchId { get; set; }

        /// <summary>
        /// The unique ID of the carrier account that was used to create this label
        /// </summary>
        public string? CarrierId { get; set; }

        /// <summary>
        /// The label charge event.
        /// </summary>
        public ChargeEvent? ChargeEvent { get; set; }

        /// <summary>
        /// The carrier service used to ship the package, such as fedex_ground, usps_first_class_mail, flat_rate_envelope, etc.
        /// </summary>
        public string? ServiceCode { get; set; }

        /// <summary>
        /// The package type, such as thick_envelope, small_flat_rate_box, large_package, etc. The code package indicates a custom or unknown package type.
        /// </summary>
        public string? PackageCode { get; set; }

        /// <summary>
        /// Indicates whether the label has been voided
        /// </summary>
        public bool? Voided { get; set; }

        /// <summary>
        /// The date and time that the label was voided, or null if the label has not been voided
        /// </summary>
        public string? VoidedAt { get; set; }

        /// <summary>
        /// The file format that you want the label to be in. We recommend pdf format because it is supported by all carriers,
        /// whereas some carriers do not support the png or zpl formats.
        /// </summary>
        public LabelFormat? LabelFormat { get; set; }

        /// <summary>
        /// The display format that the label should be shown in.
        /// </summary>
        public DisplayScheme? DisplayScheme { get; set; }

        /// <summary>
        /// The layout (size) that you want the label to be in. The label_format determines which sizes are allowed.
        /// 4x6 is supported for all label formats, whereas letter (8.5" x 11") is only supported for pdf format.
        /// </summary>
        public LabelLayout? LabelLayout { get; set; }

        /// <summary>
        /// Indicates whether the shipment is trackable, in which case the tracking_status field will reflect the current status and each package will have a tracking_number.
        /// </summary>
        public bool? Trackable { get; set; }

        /// <summary>
        /// The label image resource that was used to create a custom label image.
        /// </summary>
        public string? LabelImageId { get; set; }

        /// <summary>
        /// The shipping carrier who will ship the package, such as fedex, dhl_express, stamps_com, etc.
        /// </summary>
        public string? CarrierCode { get; set; }

        /// <summary>
        /// Reference to the various downloadable file formats for the generated label
        /// </summary>
        public LabelDownload? LabelDownload { get; set; }

        /// <summary>
        /// The current status of the package, such as in_transit or delivered
        /// </summary>
        public TrackingStatus? TrackingStatus { get; set; }

        /// <summary>
        /// The link to download the customs form (a.k.a. commercial invoice) for this shipment, if any.
        /// Forms are in PDF format. This field is null if the shipment does not require a customs form, or if the carrier does not support it.
        /// </summary>
        public Link? FormDownload { get; set; }

        /// <summary>
        /// The link to submit an insurance claim for the shipment.
        /// This field is null if the shipment is not insured or if the insurance provider does not support online claim submission.
        /// </summary>
        public Link? InsuranceClaim { get; set; }

        /// <summary>
        /// The label's package(s).
        /// </summary>
        public List<Package> Packages { get; set; }
    }

    public class LabelDownload
    {
        /// <summary>
        /// The URL of the linked resource, if any
        /// </summary>
        public string? Href { get; set; }

        /// <summary>
        /// The URL for the pdf generated label
        /// </summary>
        public string? Pdf { get; set; }

        /// <summary>
        /// The URL for the png generated label
        /// </summary>
        public string? Png { get; set; }

        /// <summary>
        /// The URL for the zpl generated label
        /// </summary>
        public string? Zpl { get; set; }
    }

    public class Link
    {
        public string? Href { get; set; }

        public string? Type { get; set; }
    }

    public class Package
    {
        /// <summary>
        /// Id supported by the package
        /// </summary>
        public int? PackageId { get; set; }

        /// <summary>
        /// The package type, such as thick_envelope, small_flat_rate_box, large_package, etc.
        /// The code package indicates a custom or unknown package type.
        /// </summary>
        public string? PackageCode { get; set; }

        /// <summary>
        /// The package weight
        /// </summary>
        public Weight? Weight { get; set; }

        /// <summary>
        /// The package dimensions
        /// </summary>
        public Dimensions? Dimensions { get; set; }

        /// <summary>
        /// The insured value of the package. Requires the insurance_provider field of the shipment to be set.
        /// </summary>
        public MonetaryValue? InsuredValue { get; set; }

        /// <summary>
        /// The tracking number for the package. The format depends on the carrier.
        /// </summary>
        public string? TrackingNumber { get; set; }

        /// <summary>
        /// Custom messages to print on the shipping label for the package.
        /// These are typically used to print invoice numbers, product numbers, or other internal reference numbers.
        /// Not all carriers support label messages. The number of lines and the maximum length of each line also varies by carrier.
        /// </summary>
        public LabelMessages? LabelMessages { get; set; }

        /// <summary>
        /// An external package id.
        /// </summary>
        public string? ExternalPackageId { get; set; }

        public int? Sequence { get; set; }
    }
}