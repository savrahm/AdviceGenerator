using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Text;

namespace KanyeWest
{
    public class QuoteGenerator
    {
        public HttpClient _client = new HttpClient();

        public QuoteGenerator(HttpClient client)
        {
            client = _client;
        }

        public string GetKanyeQuote()
        {
            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = _client.GetStringAsync(kanyeURL).Result;

            var quote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return $"\"{quote}\"";
            
        }

        public string GetSwansonQuote()
        {
            var swansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var swansonResponse = _client.GetStringAsync(swansonURL).Result;
            
            return JArray.Parse(swansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
        }

        public string GetTSwiftQuote()
        {
            var tSwiftURL = "https://api.taylor.rest";

            var tSwiftResponse = _client.GetStringAsync(tSwiftURL).Result;

            var quote = JObject.Parse(tSwiftResponse).GetValue("quote").ToString();

            return $"\"{quote}\"";

        }

        public string GetGoodAdvice()
        {
            var goodAdviceURL = "https://api.adviceslip.com/advice";

            var goodAdviceResponse = _client.GetStringAsync(goodAdviceURL).Result;


            JToken advice = JObject.Parse(goodAdviceResponse);

            return (string)advice.SelectToken("slip.advice");
        }
    }
}
