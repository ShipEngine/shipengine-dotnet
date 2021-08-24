


using ShipEngineSDK.Common.Enums;
using System.Collections.Generic;
/**
* The Tracking information and events associated with a label
* @see https://www.shipengine.com/docs/tracking/track-by-label-id/
*/
namespace ShipEngineSDK.CreateLabelFromShipmentDetails.Result
{
    public class LabelResult
    {
        public string? LabelId { get; set; }

        public LabelStatus? Status { get; set; }

        public string? ShipmentId { get; set; }

        public string? ShipDate { get; set; }

        public string? CreatedAt { get; set; }

        public MonetaryValue? ShipmentCost { get; set; }

        public MonetaryValue? InsuranceCost { get; set; }

        public string? TrackingNumber { get; set; }

        public bool? IsReturnLabel { get; set; }

        public string? RmaNumber { get; set; }

        public bool? IsInternational { get; set; }

        public string? BatchId { get; set; }

        public string? CarrierId { get; set; }

        public ChargeEvent? ChargeEvent { get; set; }

        public string? ServiceCode { get; set; }

        public string? PackageCode { get; set; }

        public bool? Voided { get; set; }

        public string? VoidedAt { get; set; }

        public LabelFormat? LabelFormat { get; set; }

        public DisplayScheme? DisplayScheme { get; set; }

        public LabelLayout? LabelLayout { get; set; }

        public bool? Trackable { get; set; }

        public string? LabelImageId { get; set; }

        public string? CarrierCode { get; set; }

        public LabelDownload? LabelDownload { get; set; }

        public TrackingStatus? TrackingStatus { get; set; }

        public Link? FormDownload { get; set; }

        public Link? InsuranceClaim { get; set; }

        public List<Package> Packages { get; set; }
    }

    public class MonetaryValue
    {
        public Currency? Currency { get; set; }

        public double? Amount { get; set; }
    }

    public class LabelDownload
    {
        public string? Href { get; set; }

        public string? Pdf { get; set; }

        public string? Png { get; set; }

        public string? Zpl { get; set; }
    }

    public class Link
    {
        public string? Href { get; set; }

        public string? Type { get; set; }
    }

    public class Package
    {
        public int? PackageId { get; set; }

        public string? PackageCode { get; set; }

        public Weight? Weight { get; set; }

        public Dimensions? Dimensions { get; set; }

        public MonetaryValue? InsuredValue { get; set; }

        public string? TrackingNumber { get; set; }

        public LabelMessages? LabelMessages { get; set; }

        public string? ExternalPackageId { get; set; }

        public int? Sequence { get; set; }
    }

    public class Weight
    {
        public double? Value { get; set; }

        public WeightUnit? Unit { get; set; }
    }

    public class Dimensions
    {
        public DimensionUnit? Unit { get; set; }

        public double? Length { get; set; }

        public double? Width { get; set; }

        public double? Height { get; set; }
    }

    public class LabelMessages
    {
        public string? Reference1 { get; set; }

        public string? Reference2 { get; set; }

        public string? Reference3 { get; set; }
    }
}