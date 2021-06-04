using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CanvasAPIApp
{
   public partial class SimpleTextBox : Form
   {
      public SimpleTextBox(string title, string resourceName)
      {
         InitializeComponent();
         Text = title; //set title text
      }//End Initialization

      private async void SimpleTextBox_Load(object sender, EventArgs e)
      {         
         string accessToken = Properties.Settings.Default.CurrentAccessToken;
         var token = accessToken;
         //Get Profile
         string endPoint = Properties.Settings.Default.InstructureSite;
         Requester requester = new Requester();

            try
            {
                if (Properties.Settings.Default.CurrentAccessToken != "No Access Token" && Properties.Settings.Default.CurrentAccessToken != "")
                {
                    //Get Profile
                    var json = await requester.MakeRequestAsync(endPoint + "/api/v1/users/self/profile?");
                    //Dederialize json
                    dynamic jsonObj = JsonConvert.DeserializeObject(json);
                    //dispaly each json object
                    foreach (var obj in jsonObj)
                    {
                        rtbProfileOutput.AppendText(obj + "\n"); 
                    }
                    var url = jsonObj["avatar_url"];
                    string sUrl = url;
                    pictureBox1.Load(sUrl);
                }
                else
                {
                    MessageBox.Show("Not logged in", "Authentication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           }//endtry
            catch (Exception apiException)
            {
                MessageBox.Show("Token not authorized.  Input valid token.\n" + apiException.Message,"Authentication error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
                
      }//End Text box load

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }//End Class
}//End Name Space
