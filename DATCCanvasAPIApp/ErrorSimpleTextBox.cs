using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Globalization;

namespace CanvasAPIApp
{
    public partial class ErrorSimpleTextBox : Form
    {
        public ErrorSimpleTextBox(string title, string resourceName)
        {
            InitializeComponent();
            Text = title; //set title text
        }//End Initialization


        private void HelpSimpleTextBox_Load_1(object sender, EventArgs e)
        {
                
                string helpText = $"Last Error Thrown on request: {Properties.Settings.Default.LastErrorThrownOnRequest}";
                rtbHelpOutput.Text = helpText;           

        }//End Text box load
    }//End Class
}//End Name Space
