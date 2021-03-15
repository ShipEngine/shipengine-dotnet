using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ShipEngine.Models.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace ShipEngine.Models
{
    public class Messages
    {
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Errors { get; set; }

        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Info { get; set; }

        [JsonProperty("warnings", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Warnings { get; set; }

    }
}