// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Models;
//
//    var addressValidationResult = AddressValidationResult.FromJson(jsonString);

using ShipEngine.Models;
using System.Collections.Generic;
using ShipEngine.Models.JsonRpc;
using Newtonsoft.Json;
namespace ShipEngine.Models.Address.Dto
{

    /// <summary>
    /// The result of validating an address.
    /// </summary>
    public class AddressValidationResult
    {
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public AddressClass Address { get; set; }

        [JsonProperty("messages")]
        public Messages Messages { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }
    }

    public class AddressClass
    {
        [JsonProperty("city_locality", NullValueHandling = NullValueHandling.Ignore)]
        public string CityLocality { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("postal_code", NullValueHandling = NullValueHandling.Ignore)]
        public string PostalCode { get; set; }

        [JsonProperty("residential", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Residential { get; set; }

        [JsonProperty("state_province", NullValueHandling = NullValueHandling.Ignore)]
        public string StateProvince { get; set; }

        [JsonProperty("street")]
        public List<string> Street { get; set; }
    }



}
