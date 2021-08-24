using System.Collections.Generic;

namespace ShipEngineSDK.ValidateAddresses.Result
{
    public class ValidateAddressResult
    {
        public string? Status { get; set; }

        public AddressResult? OriginalAddress { get; set; }

        public AddressResult? MatchedAddress { get; set; }

        public List<Messages>? Messages { get; set; }
    }

    public class Messages
    {

        //TODO: add enum
        public string? Code { get; set; }

        public string? Message { get; set; }

        //TODO: Add enum
        public string? Type { get; set; }
        //TODO: add enum

        public string? DetailCode { get; set; }
    }

    public class AddressResult
    {
        public string? Name { get; set; }

        public string? Phone { get; set; }

        public string? CompanyName { get; set; }

        public string? AddressLine1 { get; set; }

        public string? AddressLine2 { get; set; }

        public string? AddressLine3 { get; set; }

        public string? StateProvince { get; set; }

        public string? PostalCode { get; set; }

        public string? CountryCode { get; set; }

        public string? AddressResidentialIndicator { get; set; }
    }
}