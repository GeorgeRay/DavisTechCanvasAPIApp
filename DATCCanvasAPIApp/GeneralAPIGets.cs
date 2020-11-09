using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace CanvasAPIApp
{
    class GeneralAPIGets
    {
        //Getting name from Profile
        public dynamic GetProfile(string name)
        {
            //Make Call to get user name
            string accessToken = Properties.Settings.Default.CurrentAccessToken;
            var token = "&access_token=" + accessToken;
            //Get Profile
            string endPoint = Properties.Settings.Default.InstructureSite;
            var client = new RestClient(endPoint);
            //Get Profile
            var json = client.MakeRequest("/api/v1/users/self/profile?" + token);
            //Deserialize json object
            dynamic jsonObj = JsonConvert.DeserializeObject(json);
            //Parse json object
            dynamic jsonData = JObject.Parse(json);
            //Send back Name         
            return jsonData.name;
        }

    }//End Class
}//End Name Space
