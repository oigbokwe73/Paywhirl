


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PayWhirl.Models
{

    public class Refunds
    {

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("data")]
        public object[] Data { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

}
