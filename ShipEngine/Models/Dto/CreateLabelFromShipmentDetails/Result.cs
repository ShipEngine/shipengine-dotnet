


using System.Collections.Generic;
using System.Text.Json.Serialization;
/**
* The Tracking information and events associated with a label
* @see https://www.shipengine.com/docs/tracking/track-by-label-id/
*/
namespace ShipEngineSDK.CreateLabelFromShipmentDetails.Result
{
    public class LabelResult
    {
        [JsonPropertyName("label_id")]
        public string? LabelId { get; set; }
        //TODO: enum?

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("shipment_id")]
        public string? ShipmentId { get; set; }

        [JsonPropertyName("ship_date")]
        public string? ShipDate { get; set; }

        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        [JsonPropertyName("shipment_cost")]
        public MonetaryValue? ShipmentCost { get; set; }

        [JsonPropertyName("insurance_cost")]
        public MonetaryValue? InsuranceCost { get; set; }

        [JsonPropertyName("tracking_number")]
        public string? TrackingNumber { get; set; }

        [JsonPropertyName("is_return_label")]
        public bool? IsReturnLabel { get; set; }

        [JsonPropertyName("rma_number")]
        public string? RmaNumber { get; set; }

        [JsonPropertyName("is_international")]
        public bool? IsInternational { get; set; }

        [JsonPropertyName("batch_id")]
        public string? BatchId { get; set; }

        [JsonPropertyName("carrier_id")]
        public string? CarrierId { get; set; }

        //TODO: enum?
        [JsonPropertyName("charge_event")]
        public string? ChargeEvent { get; set; }

        [JsonPropertyName("service_code")]
        public string? ServiceCode { get; set; }

        [JsonPropertyName("package_code")]
        public string? PackageCode { get; set; }

        [JsonPropertyName("voided")]
        public bool? Voided { get; set; }

        [JsonPropertyName("voided_at")]
        public string? VoidedAt { get; set; }

        //TODO: enum?
        [JsonPropertyName("label_format")]
        public string? LabelFormat { get; set; }

        //TODO: enum?
        [JsonPropertyName("display_scheme")]
        public string? DisplayScheme { get; set; }

        // TODO: enum?
        [JsonPropertyName("label_layout")]
        public string? LabelLayout { get; set; }

        [JsonPropertyName("trackable")]
        public bool? Trackable { get; set; }

        [JsonPropertyName("label_image_id")]
        public string? LabelImageId { get; set; }

        [JsonPropertyName("carrier_code")]
        public string? CarrierCode { get; set; }

        [JsonPropertyName("label_download")]
        public LabelDownload? LabelDownload { get; set; }

        //TODO: enum?
        [JsonPropertyName("tracking_status")]
        public string? TrackingStatus { get; set; }

        [JsonPropertyName("form_download")]
        public Link? FormDownload { get; set; }

        [JsonPropertyName("insurance_claim")]
        public Link? InsuranceClaim { get; set; }

        [JsonPropertyName("packages")]
        public List<Package> Packages { get; set; }
    }

    public class MonetaryValue
    {
        //TODO: enum?
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("amount")]
        public double? Amount { get; set; }
    }

    public class LabelDownload
    {
        [JsonPropertyName("href")]
        public string? Href { get; set; }

        [JsonPropertyName("pdf")]
        public string? Pdf { get; set; }

        [JsonPropertyName("png")]
        public string? Png { get; set; }

        [JsonPropertyName("zpl")]
        public string? Zpl { get; set; }
    }

    public class Link
    {
        [JsonPropertyName("href")]
        public string? Href { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class Package
    {
        [JsonPropertyName("package_id")]
        public int? PackageId { get; set; }

        [JsonPropertyName("package_code")]
        public string? PackageCode { get; set; }

        [JsonPropertyName("weight")]
        public Weight? Weight { get; set; }

        [JsonPropertyName("dimensions")]
        public Dimensions? Dimensions { get; set; }

        [JsonPropertyName("insured_value")]
        public MonetaryValue? InsuredValue { get; set; }

        [JsonPropertyName("tracking_number")]
        public string? TrackingNumber { get; set; }

        [JsonPropertyName("label_messages")]
        public LabelMessages? LabelMessages { get; set; }

        [JsonPropertyName("external_package_id")]
        public string? ExternalPackageId { get; set; }

        [JsonPropertyName("sequence")]
        public int? Sequence { get; set; }
    }

    public class Weight
    {
        [JsonPropertyName("value")]
        public double? Value { get; set; }

        //TODO: Enum?
        [JsonPropertyName("unit")]
        public string? Unit { get; set; }
    }

    public class Dimensions
    {
        // TODO: Enum?
        [JsonPropertyName("unit")]
        public string? Unit { get; set; }

        [JsonPropertyName("length")]
        public double? Length { get; set; }

        [JsonPropertyName("width")]
        public double? Width { get; set; }

        [JsonPropertyName("height")]
        public double? Height { get; set; }
    }

    public class LabelMessages
    {
        [JsonPropertyName("reference1")]
        public string? Reference1 { get; set; }

        [JsonPropertyName("reference2")]
        public string? Reference2 { get; set; }

        [JsonPropertyName("reference3")]
        public string? Reference3 { get; set; }
    }
}