using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CanvasAPIApp
{
   public partial class PagesForm : Form
   {

      //Give the whole class access to parameters
      PageParameters parameters = new PageParameters();
      //Give Class access to Get Call
      GeneralAPIGets getProfile = new GeneralAPIGets();

        //Initialize form
        public PagesForm()
        {
            InitializeComponent();
        }

         //Load course and user
        private void btnLoadCourse_Click(object sender, EventArgs e)
        {
         try
         {  //Ensure active token
            if (Properties.Settings.Default.CurrentAccessToken != "No Access Token" && Properties.Settings.Default.CurrentAccessToken != "")
            {
               if (nudCourseID.Value == 1)
               {
                  MessageBox.Show("Please Enter a Course ID");
               }
               else
               {
                  if (txbPageName.TextLength > 0 & nudCourseID.Value > 1)
                     buttonSubmitAssign.Enabled = true;
                  else
                     buttonSubmitAssign.Enabled = false;
                  //allow user to input course name
                  txbBaseName.Enabled = true;

                  //Setting wait curser
                  Cursor.Current = Cursors.WaitCursor;

                  //Make Call to get user name
                  if (Properties.Settings.Default.CurrentAccessToken != "No Access Token" && Properties.Settings.Default.CurrentAccessToken != "")
                  {
                     string profileObject = "name";
                     string userName = getProfile.GetProfile(profileObject);

                     //Print message
                     labelLoggedIn.Text = "Logged in as " + userName;
                  }
                  else
                  {
                     labelLoggedIn.Text = "Not logged in";
                  }
                  //Get course name
                  try
                  {

                     //Get Course Name
                     String endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + nudCourseID.Value + "?";
                     var courseClient = new RestClient(endPoint);
                     courseClient.Method = HttpVerb.PUT;
                     var json = courseClient.MakeRequest(parameters.AccessToken());
                     //deserialize the JSON object
                     dynamic jsonObj = JsonConvert.DeserializeObject(json);
                     //parse the JSON object
                     dynamic data = JObject.Parse(json);
                     //Printing out results
                     rtbResults.AppendText("Course " + Convert.ToString(data.name) + " has been selected!\n");
                  }
                  catch (Exception courseIDChangeException)
                  {
                     rtbResults.AppendText(courseIDChangeException.Message + "\n");
                  }

                  //End Wait Cursor
                  Cursor.Current = Cursors.Default;
               }
            }//end login if
            else
            {

               MessageBox.Show("Not logged in. Enter valid token", "Authentication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }//end try
         catch (Exception apiException)
         {
            MessageBox.Show("Token not authorized.  Input valid token.\n" + apiException.Message, "Authentication error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }// end load course

      private void xbxUseBase_CheckedChanged(object sender, EventArgs e)
      {
         if (xbxUseBase.Checked == true)
         {
            txbBaseName.Enabled = true;
            nudNumberOfAssign.Enabled = true;
            txbPageName.ReadOnly = true;
         }
         else
         {
            txbBaseName.Enabled = false;
            nudNumberOfAssign.Enabled = false;
            txbPageName.ReadOnly = false;
            txbPageName.Enabled = true;
         }
      } //end base name method

      private void txbBaseName_TextChanged(object sender, EventArgs e)
      {
         if (txbBaseName.TextLength > 0 & nudCourseID.Value > 1)
            buttonSubmitAssign.Enabled = true;
         else
            buttonSubmitAssign.Enabled = false;
      }

      private void txbPageName_TextChanged(object sender, EventArgs e)
      {
         if (txbPageName.TextLength > 0 & nudCourseID.Value > 1)
            buttonSubmitAssign.Enabled = true;
         else
            buttonSubmitAssign.Enabled = false;
      }

      private void buttonSubmitAssign_Click(object sender, EventArgs e)
      {
         string restResult = "No Call Made";//this will be over written by results from web call
         var tokenParameter = parameters.AccessToken();//Create 
         string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + Convert.ToString(nudCourseID.Value) + "/pages?";//Get base endpoint from setting
         var client = new RestClient(endPoint);
         client.Method = HttpVerb.POST;//setting call to post
         int pageToMake = Convert.ToInt32(nudNumberOfAssign.Value);
         int pageNumber = 0;

         //Setting parameters
         var editRoles = parameters.EditRoles(radioButtonTeachers.Checked, radioButtonTeachandStu.Checked, radioButtonAnyone.Checked);
         var contentUpdate = parameters.ContentUpdate(checkBoxContentChange.Checked);
         var pagePublish = parameters.PagePublish(checkBoxPagePublish.Checked);
         //combining all parameters
         var allParameters = editRoles + contentUpdate + pagePublish;
         //Make API Call
         try
         {
            //Validate fields

            //Write out submit header
            rtbResults.AppendText(String.Format("{0,-50} {1,-10}\n", "Page Name", "Status"));
            //Write Repeating submit       
            if (xbxUseBase.Checked == true)
            {
               try
               {
                  //Validate Number in text
                  var pattern = @"\[([^\]]*)\]";
                  var inputNumber = Regex.Match(txbBaseName.Text, pattern).Value.Replace("[", "").Replace("]", "");
                  pageNumber = Convert.ToInt32(inputNumber);
                  //While loop to run until Quizes to make is zero

                  try
                  {
                     while (pageToMake > 0)
                     {
                        //Incrementing page number
                        var incrementedAssignName = Regex.Replace(txbBaseName.Text, @"\[([^\]]*)\]", Convert.ToString(pageNumber));
                        var htmlSafeIncrementedAssignName = Uri.EscapeDataString(incrementedAssignName);
                        var assignTitleParameter = "&wiki_page[title]=" + htmlSafeIncrementedAssignName;
                        //Formating Quiz Description for HTML
                        var incrementedAssignInstruction = Regex.Replace(rtbAssignInstructions.Text, @"\[([^\]]*)\]", incrementedAssignName);
                        var htmlSafeIncrementedAssignInstruction = Uri.EscapeDataString(incrementedAssignInstruction);
                        var pageDescriptionParameter = parameters.PageDescription(htmlSafeIncrementedAssignInstruction);

                        //REST Call
                        restResult = client.MakeRequest(tokenParameter + assignTitleParameter + allParameters + pageDescriptionParameter);
                        //Write Results to Text box
                        rtbResults.AppendText(String.Format("{0,-50} {1,-10}\n", incrementedAssignName, "Created"));
                        pageNumber++;
                        pageToMake--;
                     }//End Repeating submit while statement

                     //Clear Page names
                     txbBaseName.Text = "";
                     txbPageName.Text = "";
                  }//End try
                  catch (Exception apiException)
                  {
                     MessageBox.Show(apiException.Message);
                  }
               }//End try On validating text in bracket
               catch (FormatException bracketNumberException)
               {
                  MessageBox.Show("Please enter a number in brackets or uncheck \"Use base Name and Increment\"\n\n" + bracketNumberException.Message);
               }//End Catch on validating text in bracket
            }
            //Write single submit
            else
            {

               //Creating Assign Title and making it HTML safe
               var pageTitleParameter = "&wiki_page[title]=" + Uri.EscapeDataString(txbPageName.Text);
               //Formating Assignment Description for HTML
               var incrementedPageInstruction = Regex.Replace(rtbAssignInstructions.Text, @"\[([^\]]*)\]", txbPageName.Text);
               //Makeing Assignment instruction HTML Safe
               var htmlSafeIncrementedAssignInstruction = Uri.EscapeDataString(incrementedPageInstruction);
               //Setting Assignment description parameter
               var pageDescriptionParameter = parameters.PageDescription(htmlSafeIncrementedAssignInstruction);
               restResult = client.MakeRequest(tokenParameter + pageTitleParameter + allParameters + pageDescriptionParameter);
               //Reset form for next submit
               nudCourseID.TabStop = false;
               txbBaseName.TabStop = false;
               //Write Results to Text box
               rtbResults.AppendText(String.Format("{0,-50} {1,-10}\n", txbPageName.Text, "Created"));
            }// end else
         }//End Single Submit

         catch (Exception apiException)
         {
            rtbResults.AppendText("Submit Failed: " + apiException.Message + "\n");
         }
      }//End Submit
      //Reset form
      private void buttonReset_Click(object sender, EventArgs e)
      {
         this.Controls.Clear();
         this.InitializeComponent();
      }// end reset form

        private void nudCourseID_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
