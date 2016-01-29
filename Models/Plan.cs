


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PayWhirl.Models

{

    public class Plan
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("shipping")]
        public string Shipping { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("enabled")]
        public string Enabled { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        [JsonProperty("trial_days")]
        public string TrialDays { get; set; }

        [JsonProperty("image")]
        public object Image { get; set; }

        [JsonProperty("feature_1")]
        public string Feature1 { get; set; }

        [JsonProperty("feature_2")]
        public string Feature2 { get; set; }

        [JsonProperty("feature_3")]
        public string Feature3 { get; set; }

        [JsonProperty("feature_4")]
        public string Feature4 { get; set; }

        [JsonProperty("feature_5")]
        public string Feature5 { get; set; }

        [JsonProperty("feature_6")]
        public string Feature6 { get; set; }

        [JsonProperty("feature_7")]
        public string Feature7 { get; set; }

        [JsonProperty("feature_8")]
        public string Feature8 { get; set; }

        [JsonProperty("feature_9")]
        public string Feature9 { get; set; }

        [JsonProperty("feature_10")]
        public string Feature10 { get; set; }

        [JsonProperty("billing_interval")]
        public string BillingInterval { get; set; }

        [JsonProperty("setup_fee")]
        public string SetupFee { get; set; }

        [JsonProperty("shopify_product_id")]
        public object ShopifyProductId { get; set; }

        [JsonProperty("shopify_variant_id")]
        public object ShopifyVariantId { get; set; }

        [JsonProperty("shopify_fulfillment")]
        public string ShopifyFulfillment { get; set; }

        [JsonProperty("sku")]
        public object Sku { get; set; }

        [JsonProperty("ordering")]
        public object Ordering { get; set; }

        [JsonProperty("installments")]
        public string Installments { get; set; }

        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        [JsonProperty("order_on_all_installments")]
        public string OrderOnAllInstallments { get; set; }
    }

}
