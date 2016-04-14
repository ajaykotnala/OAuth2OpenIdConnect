using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MVCClient.Helpers
{
    public class HttpClientHelper
    {
        public static HttpClient GetClient()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(Application.Constants.Constants.API);

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}