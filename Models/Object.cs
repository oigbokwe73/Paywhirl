using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace PayWhirl.Models
{

    public class Object
    {

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("invoice")]
        public string Invoice { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("captured")]
        public bool Captured { get; set; }

        [JsonProperty("card")]
        public Card Card { get; set; }

        [JsonProperty("balance_transaction")]
        public string BalanceTransaction { get; set; }

        [JsonProperty("receipt_email")]
        public object ReceiptEmail { get; set; }

        [JsonProperty("dispute")]
        public object Dispute { get; set; }

        [JsonProperty("amount_refunded")]
        public int AmountRefunded { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("refunded")]
        public bool Refunded { get; set; }

        [JsonProperty("object")]
        public string ObjectDetail { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }

        [JsonProperty("statement_description")]
        public object StatementDescription { get; set; }

        [JsonProperty("failure_code")]
        public object FailureCode { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("refunds")]
        public Refunds Refunds { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("failure_message")]
        public object FailureMessage { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }

}
