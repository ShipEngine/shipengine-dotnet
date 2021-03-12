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
        public List<string> Errors { get; set; }

        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Info { get; set; }

        [JsonProperty("warnings", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Warnings { get; set; }


        public void AssertNoErrorMessages()
        {
            if (Errors.Count > 0)
            {
                throw new ShipEngineException(Errors.Aggregate((a, b) => a + ", " + b));
            }
        }
    }
}