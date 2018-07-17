using System.Collections.Generic;
using Newtonsoft.Json;

namespace npvWebAPI.Models
{
    public class NpvResponse
    {
        [JsonProperty("labels")]
        public ICollection<string> Labels { get; set; }

        [JsonProperty("data")]
        public ICollection<double> Data { get; set; }
    }
}