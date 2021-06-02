using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.IO;    // For StreamReader

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

            //sets maximum connections at once, .NET default apparently is 2. Seems to improve performance speed somewhat.
            //I didn't want to increase it too much without knowing what might happen but I read people who set it to 20 or 50 with no problems.
            ServicePointManager.DefaultConnectionLimit = 6;

        }//end Requester()

        public async Task<string> MakeRequestAsync(string url, string accessToken, string parameters = "")
        {
            string finalUrl = url + $"access_token={accessToken}" + parameters;

            //debug output:
            //Console.WriteLine(finalUrl);            

            HttpResponseMessage response = await client.GetAsync(finalUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();

            return responseString;

        }//end MakeRequestAsync

        //Delete request created originally for concluding courses for students in Courseform
        public async Task<string> MakeDeleteRequestAsync(string url, string accessToken, string parameters = "")
        {
            string finalUrl = url + $"access_token={accessToken}" + parameters;

            //debug output:
            //Console.WriteLine(finalUrl);            

            HttpResponseMessage response = await client.DeleteAsync(finalUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();

            return responseString;

        }//end MakeDeleteRequestAsync

        //POST method, This method requires a dictionary object in the body of the POST to send the information, but also has URL post functionality
        public async Task<string> MakePOSTRequestAsync(string url, string accessToken, Dictionary<string, string> values, string parameters = "")
        {
            string finalUrl = url + $"access_token={accessToken}" + parameters;

            var content = new FormUrlEncodedContent(values);

            //debug output:
            //Console.WriteLine(finalUrl);            

            HttpResponseMessage response = await client.PostAsync(finalUrl, content);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();

            return responseString;

        }//end MakePostRequestAsync

        //POST method overload, adapted to focus on only URL Post requests, allows for the exclusion of the dictionary object while keeping the async functionality
        public async Task<string> MakePOSTRequestAsync(string url, string accessToken, string parameters = "")
        {
            string finalUrl = url + $"access_token={accessToken}" + parameters;

            //debug output:
            //Console.WriteLine(finalUrl);            

            HttpResponseMessage response = await client.PostAsync(finalUrl, new FormUrlEncodedContent(new Dictionary<string, string> { }));

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }//end MakePostRequestAsync
    }
}
