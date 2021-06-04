using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace CanvasAPIApp
{
    class GeneralAPIGets 
    {
        //Getting name from Profile
        public async Task<dynamic> GetProfile(string name)
        {
            //Make Call to get user name
            string accessToken = Properties.Settings.Default.CurrentAccessToken;
            //Get Profile
            string endPoint = Properties.Settings.Default.InstructureSite;
            Requester requester = new Requester();
            //Get Profile
            var json = await requester.MakeRequestAsync(endPoint + "/api/v1/users/self/profile?");
            //Deserialize json object onlif if data was returned
            if (json != "")
            {
                dynamic jsonObj = JsonConvert.DeserializeObject(json);
                //Parse json object
                dynamic jsonData = JObject.Parse(json);
                //Send back Name         
                return jsonData.name;
            }
            return "Not Logged In";
        }

    }//End Class
}//End Name Space
