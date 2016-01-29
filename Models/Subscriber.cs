


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PayWhirl.Models
{

    public class Subscriber
    {

        [JsonProperty("profile")]
        public string Profile { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("admin")]
        public string Admin { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("stripe_id")]
        public string StripeId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }

}
