


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace PayWhirl.Models
{

    public class Body
    {

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("pending_webhooks")]
        public int PendingWebhooks { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("request")]
        public string Request { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

}
