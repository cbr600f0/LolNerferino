using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LolApi
{
    public static class ApiCore
    {
        public static string ApiKey { get; set; }
        public static int RateLimit { get; set; } = 10;
        public static string Region { get; set; } = "euw";
        public static string PlatformId { get; set; } = "EUW1";
        private static HttpClient HttpClient { get; set; }

        public static void Initialize(string apiKey)
        {
            ApiKey = apiKey;
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri($"https://{Region}.api.pvp.net/");
        }

        public static async Task<T> HttpGetAsync<T>(string url)
        {
            var requestUrl = $"{url}?api_key={ApiKey}";
            var response = await HttpClient.GetStringAsync(requestUrl);
            var obj = JsonConvert.DeserializeObject<T>(response);
            return obj;
        }
    }
}