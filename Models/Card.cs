


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PayWhirl.Models
{

    public class Card
    {

        [JsonProperty("address_line2")]
        public object AddressLine2 { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("address_city")]
        public object AddressCity { get; set; }

        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        [JsonProperty("funding")]
        public string Funding { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address_line1_check")]
        public object AddressLine1Check { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("cvc_check")]
        public object CvcCheck { get; set; }

        [JsonProperty("address_zip")]
        public object AddressZip { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("address_line1")]
        public object AddressLine1 { get; set; }

        [JsonProperty("address_state")]
        public object AddressState { get; set; }

        [JsonProperty("address_zip_check")]
        public object AddressZipCheck { get; set; }

        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        [JsonProperty("address_country")]
        public object AddressCountry { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }
    }

}
