using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CanvasAPIApp
{
    public partial class PagesForm : Form
    {

        //Give the whole class access to parameters
        Page currentPage = new Page();
        //Give Class access to Get Call
        GeneralAPIGets getProfile = new GeneralAPIGets();

        //Initialize form
        public PagesForm()
        {
            InitializeComponent();
        }

        //Load course and user
        private async void btnLoadCourse_Click(object sender, EventArgs e)
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
                            buttonSubmitPage.Enabled = true;
                        else
                            buttonSubmitPage.Enabled = false;
                        //allow user to input course name
                        txbBaseName.Enabled = true;

                        //Setting wait curser
                        Cursor.Current = Cursors.WaitCursor;

                        //Make Call to get user name
                        if (Properties.Settings.Default.CurrentAccessToken != "No Access Token" && Properties.Settings.Default.CurrentAccessToken != "")
                        {
                            string profileObject = "name";
                            string userName = await getProfile.GetProfile(profileObject);

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
                            Requester requester = new Requester();
                            var json = await requester.MakeRequestAsync(endPoint);
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
                buttonSubmitPage.Enabled = true;
            else
                buttonSubmitPage.Enabled = false;
        }

        private void txbPageName_TextChanged(object sender, EventArgs e)
        {
            if (txbPageName.TextLength > 0 & nudCourseID.Value > 1)
                buttonSubmitPage.Enabled = true;
            else
                buttonSubmitPage.Enabled = false;
        }

        private async void buttonSubmitPage_Click(object sender, EventArgs e)
        {
            string restResult = "No Call Made";//this will be over written by results from web call

            string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + Convert.ToString(nudCourseID.Value) + "/pages?";//Get base endpoint from setting
            Requester requester = new Requester();
            int pageToMake = Convert.ToInt32(nudNumberOfAssign.Value);
            int pageNumber = 0;

            //Setting parameters
            currentPage.editing_roles = currentPage.EditRoles(radioButtonTeachers.Checked, radioButtonTeachandStu.Checked, radioButtonAnyone.Checked);
            currentPage.notify_of_update = checkBoxContentChange.Checked;
            currentPage.published = checkBoxPagePublish.Checked;
            //combining all parameters

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
                            for (int i = 1; i <= pageToMake; i++)
                            {
                                //Incrementing page number
                                currentPage.title = Regex.Replace(txbBaseName.Text, @"\[([^\]]*)\]", Convert.ToString(pageNumber));                        
                               
                                currentPage.body = Regex.Replace(rtbPageBody.Text, @"\[([^\]]*)\]", currentPage.title);                                

                                //REST Call
                                var jsonString = $"{{\"wiki_page\":{JsonConvert.SerializeObject(currentPage)}}}";
                                restResult = await requester.MakePOSTRequestAsync(endPoint, jsonString);
                                //Write Results to Text box
                                rtbResults.AppendText(String.Format("{0,-50} {1,-10}\n", currentPage.title, "Created"));
                                pageNumber++;

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
                    currentPage.title = txbPageName.Text;
                    currentPage.body = Regex.Replace(rtbPageBody.Text, @"\[([^\]]*)\]", txbPageName.Text);
                    
                    var jsonString = $"{{\"wiki_page\":{JsonConvert.SerializeObject(currentPage)}}}";
                    restResult = await requester.MakePOSTRequestAsync(endPoint, jsonString);
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
