using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Web.Configuration;


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
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.CurrentAccessToken);

            //sets maximum connections at once, .NET default apparently is 2. Seems to improve performance speed somewhat.
            //I didn't want to increase it too much without knowing what might happen but I read people who set it to 20 or 50 with no problems.
            ServicePointManager.DefaultConnectionLimit = 6;

        }

        public async Task<string> MakeRequestAsync(string url, string parameters = "")
        {
            HttpResponseMessage response = new HttpResponseMessage();
            string finalUrl = url + parameters;
            string responseString = "";

            //debug output:
            //Console.WriteLine(finalUrl);            
            try
            {
                response = await client.GetAsync(finalUrl);
                response.EnsureSuccessStatusCode();
                responseString = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
#if DEBUG
                Console.WriteLine(finalUrl);
                Console.WriteLine(ex.Message);
                Console.WriteLine(response);
#endif
                Properties.Settings.Default.LastErrorThrownOnRequest = 
                    $"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()} {ex.Message}" +
                    $"\n{finalUrl}";
                //2024-03-21 This is not helpful. Writing out the variable above.
                //write out to log file
                //var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                //path = path + "\\CanvasAPIApp\\log.txt";
                //StreamWriter file = new StreamWriter(path, true);
                //file.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()} {ex.Message} {finalUrl}");
                //file.Close();
            }
            return responseString;

        }
        //Delete request created originally for concluding courses for students in Courseform
        public async Task<string> MakeDeleteRequestAsync(string url, string parameters = "")
        {
            string finalUrl = url + parameters;

            //debug output:
            //Console.WriteLine(finalUrl);            

            HttpResponseMessage response = await client.DeleteAsync(finalUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();

            return responseString;

        }
        //POST 
        public async Task<string> MakePOSTRequestAsync(string url, string jsonString)
        {
            //when calling canvas you need to have the object first in the string
            //var payload = "{\"quiz\":{\"title\":\"test2\"}}";
            HttpContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(url, content);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();

            return responseString;

        }
    }
}
