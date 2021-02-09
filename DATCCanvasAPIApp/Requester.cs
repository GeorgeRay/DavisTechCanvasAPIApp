using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CanvasAPIApp
{
    class Requester
    {
        public string Url { get; set; }

        HttpClient client;

        public Requester()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


        }

        public async Task<string> MakeRequestAsync(string url, string accessToken, string parameters = "")
        {
            string finalUrl = url + $"access_token={accessToken}" + parameters;


            HttpResponseMessage response = await client.GetAsync(finalUrl);

            
            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();

            return responseString;

        }
    }
}
