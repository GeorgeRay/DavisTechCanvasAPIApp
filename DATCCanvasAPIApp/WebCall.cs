using System;
using System.IO;
using System.Net;
using System.Text;

//Declare Enumeration
public enum HttpVerb
{
    GET,
    POST,
    PUT,
    DELETE
}

namespace CanvasAPIApp
{
    public class RestClient
    {

        public string EndPoint { get; set; } //Endpoint method
        public HttpVerb Method { get; set; }// I am lost on what this one does
        public string ContentType { get; set; }//Content Type method
        public string PostData { get; set; }// Post Data method

        public RestClient()
        {
            EndPoint = "";
            Method = HttpVerb.GET;
            ContentType = "text/xml";
            PostData = "";
        }// End Simple Get

        public RestClient(string endpoint)
        {
            EndPoint = endpoint;
            Method = HttpVerb.GET;
            ContentType = "text/xml";
            PostData = "";
        }//End Get with endpoint

        public RestClient(string endpoint, HttpVerb method)
        {
            EndPoint = endpoint;
            Method = method;
            ContentType = "text/xml";
            PostData = "";
        }//End REST with Method

        public RestClient(string endpoint, HttpVerb method, string postData)
        {
            EndPoint = endpoint;
            Method = method;
            ContentType = "text/xml";
            PostData = postData;
        }// End with Call with method and data for POST or PUT


        public string MakeRequest()
        {
            return MakeRequest("");
        }//End Simple make Request

        public string MakeRequest(string parameters)
        {
            
            
                var request = (HttpWebRequest)WebRequest.Create(EndPoint + parameters);
                request.Method = Method.ToString();
                request.ContentLength = 0;
                request.ContentType = ContentType;


                if (!string.IsNullOrEmpty(PostData) && Method == HttpVerb.POST)
                {
                    var encoding = new UTF8Encoding();
                    var bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(PostData);
                    request.ContentLength = bytes.Length;

                    using (var writeStream = request.GetRequestStream())
                    {
                        writeStream.Write(bytes, 0, bytes.Length);
                    }
                }

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    var responseValue = string.Empty;

                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        var message = String.Format("Request failed. Received HTTP {0}", response.StatusCode);
                        throw new ApplicationException(message);
                    }

                    // grab the response
                    using (var responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                            using (var reader = new StreamReader(responseStream))
                            {
                                responseValue = reader.ReadToEnd();
                            }
                    

                    return responseValue;
                }
            }
            
        }//End Make Request.  Code was used http://www.codeproject.com/Tips/497123/How-to-make-REST-requests-with-Csharp

        //Method for assignment call due to different status parameters
        public string MakeRequestAssignment(string parameters)
        {
            var request = (HttpWebRequest)WebRequest.Create(EndPoint + parameters);

            request.Method = Method.ToString();
            request.ContentLength = 0;
            request.ContentType = ContentType;
         

            if (!string.IsNullOrEmpty(PostData) && Method == HttpVerb.POST)
            {
                var encoding = new UTF8Encoding();
                var bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(PostData);
                request.ContentLength = bytes.Length;

                using (var writeStream = request.GetRequestStream())
                {
                    writeStream.Write(bytes, 0, bytes.Length);
                }
            }

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                var responseValue = string.Empty;

                if (response.StatusCode != HttpStatusCode.Created)
                {
                    var message = String.Format("Request failed. Received HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                // grab the response
                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                        using (var reader = new StreamReader(responseStream))
                        {
                            responseValue = reader.ReadToEnd();
                        }
                }

                return responseValue;
            }
        }//End Make Request.  Code was used http://www.codeproject.com/Tips/497123/How-to-make-REST-requests-with-Csharp

    } // class

}//End name Space