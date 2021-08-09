using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace ShipEngineSDK.ValidateAddresses.Result
{
    public class ValidateAddressResult
    {
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("original_address")]
        public AddressResult? OriginalAddress { get; set; }

        [JsonPropertyName("matched_address")]
        public AddressResult? MatchedAddress { get; set; }

        [JsonPropertyName("messages")]
        public List<Messages>? Messages { get; set; }
    }

    public class Messages
    {

        //TODO: add enum
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }

        //TODO: Add enum
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        //TODO: add enum

        [JsonPropertyName("detail_code")]
        public string? DetailCode { get; set; }
    }

    public class AddressResult
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("phone")]
        public string? Phone { get; set; }

        [JsonPropertyName("company_name")]
        public string? CompanyName { get; set; }

        [JsonPropertyName("address_line1")]
        public string? AddressLine1 { get; set; }

        [JsonPropertyName("address_line2")]
        public string? AddressLine2 { get; set; }

        [JsonPropertyName("address_line3")]
        public string? AddressLine3 { get; set; }

        [JsonPropertyName("state_province")]
        public string? StateProvince { get; set; }

        [JsonPropertyName("postal_code")]
        public string? PostalCode { get; set; }

        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        [JsonPropertyName("address_residential_indicator")]
        public string? AddressResidentialIndicator { get; set; }
    }
}