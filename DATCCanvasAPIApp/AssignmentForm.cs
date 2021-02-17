using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CanvasAPIApp
{
    public partial class AssignmentForm : Form
    {
        //Give the whole class access to parameters
        AssignmentParameters parameters = new AssignmentParameters();
        //Dictionary items to POST
        Dictionary<string, string> assignmentGroupvaluesAssign = new Dictionary<string, string>();
        //Student Group Dictionary
        Dictionary<string, string> assignmentStudentGroupvalues = new Dictionary<string, string>();
        //Give Class access to Get Call
        GeneralAPIGets getProfile = new GeneralAPIGets();


        //Initialize form
        public AssignmentForm(string title)
        {
            InitializeComponent();
            Text = title;
        }

        //Load course and user
        private async void btnLoadCourse_Click(object sender, EventArgs e)
        {
            try
            {  //Ensure if there is active token
                if (Properties.Settings.Default.CurrentAccessToken != "No Access Token" && Properties.Settings.Default.CurrentAccessToken != "")
                {
                    if (nudCourseID.Value == 1)
                    {
                        MessageBox.Show("Please Enter a Course ID");
                    }
                    else
                    {
                        if (txbAssignName.TextLength > 0 & nudCourseID.Value > 1)
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
                            string userName = await getProfile.GetProfile(profileObject);

                            //Print message
                            labelLoggedIn.Text = "Logged in as " + userName;
                        }
                        else
                        {
                            labelLoggedIn.Text = "Not logged in";
                        }
                        //Get Assignment Groups and course name
                        try
                        {
                            string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + Convert.ToString(nudCourseID.Value) + "/assignment_groups?";//Get base endpoint from setting
                            Requester requester = new Requester();
                            var json = await requester.MakeRequestAsync(endPoint, parameters.AccessToken());
                            dynamic jsonObj = JsonConvert.DeserializeObject(json);

                            foreach (var obj in jsonObj)
                            {
                                assignmentGroupvaluesAssign.Add(Convert.ToString(obj.id), Convert.ToString(obj.name));
                                cbxAssignmentGroup.Items.Add(Convert.ToString(obj.name));
                            }
                            //Get student Groups
                            endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + Convert.ToString(nudCourseID.Value) + "/group_categories?";
                            Requester stuGroupclient = new Requester();
                            json = await stuGroupclient.MakeRequestAsync(endPoint, parameters.AccessToken());
                            jsonObj = JsonConvert.DeserializeObject(json);

                            foreach (var obj in jsonObj)
                            {
                                assignmentStudentGroupvalues.Add(Convert.ToString(obj.id), Convert.ToString(obj.name));
                                cbxStudentAssignmentGroup.Items.Add(Convert.ToString(obj.name));
                            }
                            if (cbxStudentAssignmentGroup.Items.Count != 0)
                            {
                                groupBoxGroupAssign.Visible = true;
                            }
                            else
                            {
                                groupBoxGroupAssign.Visible = false;
                            }

                            //Get Course Name
                            endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + nudCourseID.Value + "?";
                            Requester courseRequester = new Requester();
                            json = await courseRequester.MakeRequestAsync(endPoint, parameters.AccessToken());
                            //deserialize the JSON object
                            jsonObj = JsonConvert.DeserializeObject(json);
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
                        //enable form selectors
                        cbxAssignmentGroup.Enabled = true;
                        comboBoxGradeType.Enabled = true;
                        comboBoxSubTypes.Enabled = true;
                        cbxStudentAssignmentGroup.Enabled = true;
                    }
                }//end token check if
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
        }//End Load Course Click

        private async void buttonSubmitAssign_Click(object sender, EventArgs e)
        {
            //create variables

            string restResult = "No Call Made";//this will be over written by results from web call
            var tokenParameter = parameters.AccessToken();//Create 
            string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + Convert.ToString(nudCourseID.Value) + "/assignments?";//Get base endpoint from setting
            Requester requester = new Requester();
            int assignToMake = Convert.ToInt32(nudNumberOfAssign.Value);
            int assignNumber = 0;

            //Getting assignment group key back
            var assignmentGroupKey = (from kvp in assignmentGroupvaluesAssign where kvp.Value == Convert.ToString(cbxAssignmentGroup.SelectedItem) select kvp.Key).FirstOrDefault();
            //Obtain student group assignment key  back
            var studentGroupAssignKey = (from kvp in assignmentStudentGroupvalues where kvp.Value == Convert.ToString(cbxStudentAssignmentGroup.SelectedItem) select kvp.Key).FirstOrDefault();
            //Setting parameters
            var assignmentTypeParameter = parameters.AssignmentGroup(assignmentGroupKey);
            var groupAssignParameter = parameters.GroupAssignment(checkBoxGroupAssign.Checked, studentGroupAssignKey);
            var assignGradingType = parameters.GradingType(Convert.ToString(comboBoxGradeType.SelectedItem));
            var assignPointsPossible = parameters.PointsPossible(Convert.ToInt32(textBoxPoints.Text));
            var omitGrade = parameters.OmitGrade(checkBoxOmit.Checked);
            var dueDate = parameters.DueDate(checkBoxDueDate.Checked, dtpDueDate.Value, dtpDueTime.Value);
            var fileTypes = parameters.FileTypes(checkBoxFileTypes.Checked, textBoxFileTypes.Text);
            var unlock = parameters.UnlockAt(checkBoxUnlock.Checked, dtpUnlockDate.Value, dtpUnlockTime.Value);
            var lockDate = parameters.LockAt(checkBoxLock.Checked, dtpLockDate.Value, dtpLockTime.Value);
            var peerReview = parameters.PeerReview(checkBoxPeer.Checked);
            var peerReviewAuto = parameters.PeerReviewAuto(checkBoxPeer.Checked, radioButtonPeerManual.Checked);
            var assignPublish = parameters.AssignPublish(checkBoxPublish.Checked);

            //Set submission type variable
            string assignSubmType = "";
            if (comboBoxSubTypes.SelectedItem != null)
            {
                if (comboBoxSubTypes.SelectedItem.ToString() == "Online")
                {
                    assignSubmType = parameters.AssignOnlineSubmissionTypes(checkBoxFileUpload.Checked, checkBoxTextEntry.Checked, checkBoxWebsite.Checked, checkBoxMedia.Checked);
                }
                else
                {
                    assignSubmType = parameters.AssignSubmissionTypesNotOnline(comboBoxSubTypes.SelectedItem.ToString());
                }
            }


            //combining all parameters
            var allParameters = assignGradingType + assignSubmType + assignPointsPossible + omitGrade + dueDate + fileTypes +
               unlock + lockDate + peerReview + peerReviewAuto + groupAssignParameter + assignPublish + assignmentTypeParameter;

            //Make API Call
            try
            {
                //Validate fields

                //Write out submit header
                rtbResults.AppendText(String.Format("{0,-50} {1,-10}\n", "Assign Name", "Status"));
                //Write Repeating submit       
                if (xbxUseBase.Checked == true)
                {
                    try
                    {
                        //Validate Number in text
                        var pattern = @"\[([^\]]*)\]";
                        var inputNumber = Regex.Match(txbBaseName.Text, pattern).Value.Replace("[", "").Replace("]", "");
                        assignNumber = Convert.ToInt32(inputNumber);
                        //While loop to run until Quizes to make is zero

                        try
                        {
                            while (assignToMake > 0)
                            {
                                //Incrementing assignment number
                                var incrementedAssignName = Regex.Replace(txbBaseName.Text, @"\[([^\]]*)\]", Convert.ToString(assignNumber));
                                var htmlSafeIncrementedAssignName = Uri.EscapeDataString(incrementedAssignName);
                                var assignTitleParameter = "&assignment[name]=" + htmlSafeIncrementedAssignName;
                                //Formating Quiz Description for HTML
                                var incrementedAssignInstruction = Regex.Replace(rtbAssignInstructions.Text, @"\[([^\]]*)\]", incrementedAssignName);
                                var htmlSafeIncrementedAssignInstruction = Uri.EscapeDataString(incrementedAssignInstruction);
                                var assignDescriptionParameter = parameters.AssignDescription(htmlSafeIncrementedAssignInstruction);

                                //REST Call
                                restResult = await requester.MakeRequestAsync(endPoint, tokenParameter, assignTitleParameter + allParameters + assignDescriptionParameter);
                                //Write Results to Text box
                                rtbResults.AppendText(String.Format("{0,-50} {1,-10}\n", incrementedAssignName, "Created"));
                                assignNumber++;
                                assignToMake--;
                            }//End Repeating submit while statement

                            //Clear Assign Names
                            txbBaseName.Text = "";
                            txbAssignName.Text = "";
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
                    var assignTitleParameter = "&assignment[name]=" + Uri.EscapeDataString(txbAssignName.Text);
                    //Formating Assignment Description for HTML
                    var incrementedAssignInstruction = Regex.Replace(rtbAssignInstructions.Text, @"\[([^\]]*)\]", txbAssignName.Text);
                    //Makeing Assignment instruction HTML Safe
                    var htmlSafeIncrementedAssignInstruction = Uri.EscapeDataString(incrementedAssignInstruction);
                    //Setting Assignment description parameter
                    var assignDescriptionParameter = parameters.AssignDescription(htmlSafeIncrementedAssignInstruction);
                    restResult = await requester.MakeRequestAsync(endPoint, tokenParameter, assignTitleParameter + allParameters + assignDescriptionParameter);
                    //Reset form for next submit
                    nudCourseID.TabStop = false;
                    txbBaseName.TabStop = false;
                    //Write Results to Text box
                    rtbResults.AppendText(String.Format("{0,-50} {1,-10}\n", txbAssignName.Text, "Created"));
                }// end else
            }//End Single Submit

            catch (Exception apiException)
            {
                rtbResults.AppendText("Submit Failed: " + apiException.Message + "\n");
            }
        }//End Submit


        private void AssignmentForm_Load(object sender, EventArgs e)
        {

        }// end load method

        //Use base name method
        private void xbxUseBase_CheckedChanged(object sender, EventArgs e)
        {
            if (xbxUseBase.Checked == true)
            {
                txbBaseName.Enabled = true;
                nudNumberOfAssign.Enabled = true;
                txbAssignName.ReadOnly = true;
            }
            else
            {
                txbBaseName.Enabled = false;
                nudNumberOfAssign.Enabled = false;
                txbAssignName.ReadOnly = false;
                txbAssignName.Enabled = true;
            }
        } //end base name method

        private void txbAssignName_TextChanged(object sender, EventArgs e)
        {
            if (txbAssignName.TextLength > 0 & nudCourseID.Value > 1)
                buttonSubmitAssign.Enabled = true;
            else
                buttonSubmitAssign.Enabled = false;
        }

        private void txbBaseName_TextChanged_1(object sender, EventArgs e)
        {
            if (txbBaseName.TextLength > 0 & nudCourseID.Value > 1)
                buttonSubmitAssign.Enabled = true;
            else
                buttonSubmitAssign.Enabled = false;
        }

        //Enable Due date and time
        private void checkBoxDueDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDueDate.Checked == true)
            {
                dtpDueDate.Enabled = true;
                dtpDueTime.Enabled = true;
            }
            if (checkBoxDueDate.Checked == false)
            {
                dtpDueTime.Enabled = false;
                dtpDueDate.Enabled = false;
            }
        }//end due date

        private void comboBoxSubTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSubTypes.SelectedItem.ToString() == "Online")
            {
                checkBoxFileUpload.Enabled = true;
                checkBoxTextEntry.Enabled = true;
                checkBoxWebsite.Enabled = true;
                checkBoxMedia.Enabled = true;
            }
            if (comboBoxSubTypes.SelectedItem.ToString() != "Online")
            {
                checkBoxFileUpload.Enabled = false;
                checkBoxTextEntry.Enabled = false;
                checkBoxWebsite.Enabled = false;
                checkBoxMedia.Enabled = false;
                checkBoxFileUpload.Checked = false;
                checkBoxTextEntry.Checked = false;
                checkBoxWebsite.Checked = false;
                checkBoxMedia.Checked = false;

            }
        }// end submission type combobox
         //Reset form
        private void buttonReset_Click(object sender, EventArgs e)
        {
            assignmentGroupvaluesAssign.Clear();
            assignmentStudentGroupvalues.Clear();
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void checkBoxFileUpload_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFileUpload.Checked == true)
            {
                checkBoxFileTypes.Visible = true;
            }
            else
            {
                checkBoxFileTypes.Visible = false;
                checkBoxFileTypes.Checked = false;

            }

        }//end checkboxfileupload method

        private void checkBoxFileTypes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFileTypes.Checked == true)
            {
                groupBoxAllowedExtensions.Visible = true;
            }
            else
            {
                groupBoxAllowedExtensions.Visible = false;
            }
        }//end fileextension group box method


        private void checkBoxUnlock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUnlock.Checked == true)
            {
                dtpUnlockDate.Enabled = true;
                dtpUnlockTime.Enabled = true;
            }
            else
            {
                dtpUnlockDate.Enabled = false;
                dtpUnlockTime.Enabled = false;
            }
        }//end unlock method

        private void checkBoxLock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLock.Checked == true)
            {
                dtpLockDate.Enabled = true;
                dtpLockTime.Enabled = true;
            }
            else
            {
                dtpLockDate.Enabled = false;
                dtpLockTime.Enabled = false;
            }
        }//end lock method

        private void checkBoxPeer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPeer.Checked == true)
            {
                radioButtonPeerAuto.Visible = true;
                radioButtonPeerManual.Visible = true;
                radioButtonPeerManual.Checked = true;
            }
            else
            {
                radioButtonPeerAuto.Visible = false;
                radioButtonPeerManual.Visible = false;
                radioButtonPeerManual.Checked = false;
                radioButtonPeerAuto.Checked = false;
            }
        }//end peer checkbox method
        //
        /*private void saveTemplate_Click(object sender, EventArgs e)
        {
            Template template = new Template(this);
            template.SaveTemplate();
        }

        private void loadTemplate_Click(object sender, EventArgs e)
        {
            Template template = new Template(this);
            template.LoadTemplate();
        }*/
    } //end form
} //end class


