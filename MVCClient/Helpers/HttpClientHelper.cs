using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using IdentityModel.Client;
using Application.Constants;

namespace MVCClient.Helpers
{
    public class HttpClientHelper
    {
        public static HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            var accessToken = RequestAccessTokenClientCredentials();

            client.SetBearerToken(accessToken);
            client.BaseAddress = new Uri(Constants.API);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }

        public static string RequestAccessTokenClientCredentials()
        {
            var cookie = HttpContext.Current.Request.Cookies.Get("TripGalleryCookie");
            // if (cookie != null && cookie["access_token"] != null) both are same
            if (cookie?["access_token"] != null)
            {
                return cookie["access_token"];
            }
            var tokenClient = new TokenClient(Constants.STSTokenEndpoint, "tripgalleryclientcredentials",
                Constants.ClientSecret);

            var tokenResponse = tokenClient.RequestClientCredentialsAsync("gallerymanagement").Result;
            TokenHelper.DecodeAndWrite(tokenResponse.AccessToken);

            HttpContext.Current.Response.Cookies["TripGalleryCookie"]["access_token"] = tokenResponse.AccessToken;
            return tokenResponse.AccessToken;
        }
    }
}