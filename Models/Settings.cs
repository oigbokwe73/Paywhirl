using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


public class Settings
{

    [JsonProperty("show_login")]
    public string ShowLogin { get; set; }

    [JsonProperty("show_promo")]
    public string ShowPromo { get; set; }

    [JsonProperty("default_country")]
    public string DefaultCountry { get; set; }

    [JsonProperty("show_brand")]
    public string ShowBrand { get; set; }

    [JsonProperty("from_email")]
    public string FromEmail { get; set; }

    [JsonProperty("from_email_name")]
    public string FromEmailName { get; set; }

    [JsonProperty("allow_unsubscribe")]
    public string AllowUnsubscribe { get; set; }

    [JsonProperty("custom_css")]
    public string CustomCss { get; set; }

    [JsonProperty("custom_terms")]
    public string CustomTerms { get; set; }

    [JsonProperty("thank_you_message")]
    public string ThankYouMessage { get; set; }

    [JsonProperty("user_passthrough_url")]
    public string UserPassthroughUrl { get; set; }

    [JsonProperty("user_login_passthrough_url")]
    public string UserLoginPassthroughUrl { get; set; }

    [JsonProperty("user_logout_passthrough_url")]
    public string UserLogoutPassthroughUrl { get; set; }

    [JsonProperty("global_tracking_code")]
    public string GlobalTrackingCode { get; set; }

    [JsonProperty("signup_tracking_code")]
    public string SignupTrackingCode { get; set; }
}
