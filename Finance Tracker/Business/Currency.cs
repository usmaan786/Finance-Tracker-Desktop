using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Finance_Tracker
{
    public class Currency
    {
        private static string apiKey = "0df2041ae1afede31d4a1e06";
        private static string baseUrl = "https://v6.exchangerate-api.com/v6/";
        public static async Task<decimal> ConvertCurrency(string initialCurrency,string targetCurrency, decimal amount)
        {
            string url = $"{baseUrl}{apiKey}/pair/{initialCurrency}/{targetCurrency}/{amount}";

            var client = new RestClient();
            var request = new RestRequest(url, Method.Get);
            
            var response = await client.ExecuteAsync(request);

            if(response.IsSuccessful)
            {
                var jsonResponse = JObject.Parse(response.Content);
                decimal conversionRate = jsonResponse["conversion_result"].Value<decimal>();
                
                return conversionRate;
            }
            else
            {
                throw new Exception("API Request Failed." + response.ErrorMessage);
            }
           
        }
    }
}
