using Newtonsoft.Json;
using PayWhirl.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PayWhirlApi.Interface
{
    public class PayWhirlBC
    {
        private string api_key { get; set; }
        private string api_secret { get; set; }
        public string websiteUrl { get; set; }
        private const string PLANS_URL = "https://www.paywhirl.com/api/plans";
        private const string PLAN_URL = "https://www.paywhirl.com/api/plan";
        private const string USER = "https://www.paywhirl.com/api/me";
        private const string SUBCRIBERS_URL = "https://www.paywhirl.com/api/subscribers";
        private const string SUBCRIBER_URL = "https://www.paywhirl.com/api/subscriber";
        private const string CREATE_SUBCRIBERS_URL = "https://www.paywhirl.com/api/subscriber/create";
        private const string UPDATE_SUBCRIBERS_URL = "https://www.paywhirl.com/api/subscriber/update";
        private const string UPDATE_PLAN_URL = "https://www.paywhirl.com/api/plan/update";
        private const string MULTI_AUTH_URL = "https://www.paywhirl.com/api/multiauth";
        private string configurationFile = string.Empty;
        private bool writeLog { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Required</param>
        /// <param name="apiSecret">Required, but do not share outside of the hosted application</param>
        /// <param name="writeLog">optional. Turn on to see responses from payWhirl</param>
        public PayWhirlBC(string apiKey, string apiSecret, bool writeLog = false)
        {
            this.writeLog = writeLog;
            this.api_key = apiKey;
            this.api_secret = apiSecret;
            configurationFile = ConfigurationManager.AppSettings["logs"]?? string.Format(@"{0}\logs.txt",AppDomain.CurrentDomain.BaseDirectory);
        }
        public PayWhirlBC()
        {

        }
        /// <summary>
        /// Get a temporary token for 30 seconds for authentication.
        /// </summary>
        /// <param name="RequestParams"></param>
        /// <returns></returns>
        public TokenInfo GetAuthToken(NameValueCollection RequestParams)
        {
            return MakeCall<TokenInfo>(MULTI_AUTH_URL, RequestParams,true);

        }
        /// <summary>
        /// Returns information about the current logged in user
        /// </summary>
        /// <returns></returns>
        public User CurrentUser()
        {
            return MakeCall<User>(USER);
        }
        /// <summary>
        /// Get the plans for all users
        /// </summary>
        /// <returns></returns>
        public List<Plan> GetPlans()
        {
            return MakeCall<List<Plan>>(PLANS_URL);
        }
        /// <summary>
        ///  id is required
        /// </summary>
        /// <param name="RequestParams"></param>
        /// <returns></returns>
        public Plan GetPlan(NameValueCollection RequestParams)
        {
            return MakeCall<Plan>(PLAN_URL, RequestParams);

        }
        /// <summary>
        ///  An existing plans should exist before updating
        /// </summary>
        /// <param name="RequestParams"></param>
        /// <returns></returns>
        public Plan UpdatePlan(NameValueCollection RequestParams)
        {
            return MakeCall<Plan>(UPDATE_PLAN_URL, RequestParams,true);
        }
        /// <summary>
        ///  Create subcriber email address is required.
        /// </summary>
        /// <param name="RequestParams"></param>
        /// <returns></returns>
        public Subscriber CreateSubcriber(NameValueCollection RequestParams)
        {
            return MakeCall<Subscriber>(CREATE_SUBCRIBERS_URL, RequestParams, true);
        }
        /// <summary>
        ///  Update subcriber information
        ///  id is requied
        /// </summary>
        /// <param name="RequestParams"></param>
        /// <returns></returns>
        public Subscriber UpdateSubcriber(NameValueCollection RequestParams)
        {
            return MakeCall<Subscriber>(UPDATE_SUBCRIBERS_URL, RequestParams, true);
        }
        /// <summary>
        /// Provides a list of all subcribers
        /// </summary>
        /// <returns></returns>
        public List<Subscriber> GetSubcribers()
        {
            return MakeCall<List<Subscriber>>(SUBCRIBERS_URL);

        }
        /// <summary>
        /// id and email are required
        /// </summary>
        /// <param name="RequestParams"></param>
        /// <returns>a subcriber</returns>
        public Subscriber GetSubcriber(NameValueCollection RequestParams)
        {
            return MakeCall<Subscriber>(SUBCRIBER_URL, RequestParams);

        }
        private T MakeCall<T>(string apiUrl, NameValueCollection payload = null, bool post = false) where T : class, new()
        {
            T retval = default(T);
            using (WebClient client = new WebClient())
            {
                client.Headers["api_key"] = this.api_key;
                client.Headers["api_secret"] = this.api_secret;
                if (post)
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    byte[] responsebytes = client.UploadValues(apiUrl, "POST", payload);
                    var response = WriteLog(Encoding.UTF8.GetString(responsebytes));
                    retval = JsonConvert.DeserializeObject<T>(response);
                }
                else
                {
                    var url = payload != null ? AddParameters(new Uri(apiUrl), payload) : new Uri(apiUrl);
                    var response = WriteLog(client.DownloadString(url));
                    retval = JsonConvert.DeserializeObject<T>(response);
                }
            }
            return retval;
        }

        private string WriteLog(string message)
        {
            if (this.writeLog)
            {
                using (StreamWriter sw = new StreamWriter(configurationFile, true))
                {
                    sw.Write(message);
                }
            }
           return message;
        }
 
        private Uri AddParameters(Uri url, NameValueCollection parameters)
        {
            var uriBuilder = new UriBuilder(url);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);

            foreach (string param in parameters)
            {
                query[param] = parameters[param];
            }
            uriBuilder.Query = query.ToString();
            return new Uri(uriBuilder.ToString());
        }

    }
}
