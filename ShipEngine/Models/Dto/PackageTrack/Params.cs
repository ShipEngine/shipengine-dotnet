using Newtonsoft.Json;
namespace ShipEngine.Models.Package.Dto
{
    public class TrackPackageParams
    {
        [JsonProperty("package_id")]
        public string? PackageId { get; set; }

        [JsonProperty("carrier_code")]
        public string? CarrierCode { get; set; }

        [JsonProperty("tracking_number")]
        public string? TrackingNumber { get; set; }


    }
}