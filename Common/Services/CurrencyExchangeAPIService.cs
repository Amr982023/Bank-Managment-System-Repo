using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Common
{
    
        public static class CurrencyExchangeApiService
        {
            private static readonly HttpClient client = new HttpClient();

            public class ExchangeRateResponse
            {
                public bool success { get; set; }
                public string terms { get; set; }
                public string privacy { get; set; }
                public long timestamp { get; set; }
                public string source { get; set; }
                public Dictionary<string, double> quotes { get; set; }
            }

            public static async Task<ExchangeRateResponse> GetExchangeRatesAsync()
            {
                string accessKey = ConfigurationManager.AppSettings["CurrencyExchangeAccessKey"];
                string url = $"https://api.exchangerate.host/live?access_key={accessKey}";

                try
                {
                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<ExchangeRateResponse>(json);
                    }
                }
                catch (Exception ex)
                {
                    Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "API");
                    clsErrorEvents.onError(ex.Message);
                }

                return null;
            }
        }
    
}
