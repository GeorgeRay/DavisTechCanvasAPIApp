using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Globalization;

namespace CanvasAPIApp
{
    public partial class HelpSimpleTextBox : Form
    {
        public HelpSimpleTextBox(string title, string resourseName)
        {
            InitializeComponent();
            Text = title; //set title text
        }//End Initialization


        private void HelpSimpleTextBox_Load_1(object sender, EventArgs e)
        {
            string version;

            try
            {
                version = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
            catch
            {
                version = "Version number not available during debugging";
            }
                
                string helpText = "Version: " + version;
                rtbHelpOutput.Text = helpText;
           

        }//End Text box load
    }//End Class
}//End Name Space
