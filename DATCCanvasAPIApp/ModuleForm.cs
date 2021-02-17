using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CanvasAPIApp
{
    public partial class ModuleForm : Form
    {
        //Give the whole class access to parameters
        ModuleParameters parameters = new ModuleParameters();
        //Give Class access to Get Call
        GeneralAPIGets getProfile = new GeneralAPIGets();

        public ModuleForm()
        {
            InitializeComponent();
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
                            string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + nudCourseID.Value + "?";
                            Requester courseRequester = new Requester();
                            var json = await courseRequester.MakeRequestAsync(endPoint, parameters.AccessToken());
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

                        //Get list of modules for module position grid
                        try
                        {
                            //reset modules listed
                            courseModulesGrid.Columns.Clear();
                            courseModulesGrid.Refresh();
                            string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + nudCourseID.Value + "/modules?";//Get endpoint
                            Requester requester = new Requester();
                            var json = await requester.MakeRequestAsync(endPoint, parameters.AccessToken());
                            dynamic jsonObj = JsonConvert.DeserializeObject(json);
                            courseModulesGrid.Columns.Add("moduleName", "Module Name");
                            courseModulesGrid.Columns.Add("modulePos", "Position");
                            courseModulesGrid.Columns[0].Width = 50;
                            courseModulesGrid.Columns[1].Width = 50;

                            foreach (var obj in jsonObj)
                            {
                                courseModulesGrid.Rows.Add(String.Format(Convert.ToString(obj.name)), (Convert.ToString(obj.position)));
                            }
                            courseModulesGrid.ClearSelection();
                        } //end try
                        catch (Exception populateModulesGridException)
                        {
                            MessageBox.Show(populateModulesGridException.Message + "\n");
                        }
                        //End Wait Cursor
                        Cursor.Current = Cursors.Default;
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

        private void xbxUseBase_CheckedChanged(object sender, EventArgs e)
        {
            if (xbxUseBase.Checked == true)
            {
                txbBaseName.Enabled = true;
                nudNumberOfModule.Enabled = true;
                txbModuleName.ReadOnly = true;
            }
            else
            {
                txbBaseName.Enabled = false;
                nudNumberOfModule.Enabled = false;
                txbModuleName.ReadOnly = false;
                txbModuleName.Enabled = true;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private async void btnSubmitModule_Click(object sender, EventArgs e)
        {
            try
            {

                string restResult = "No Call Made";//this will be over written by results from web call
                var tokenParameter = parameters.AccessToken();//Create 
                string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + nudCourseID.Value + "/modules?";//Get endpoint
                Requester requester = new Requester();
                int moduleToMake = Convert.ToInt32(nudNumberOfModule.Value);
                int moduleNumber = 0;

                var requireSequentialProgress = parameters.SequentialProgress(seqProgress.Checked);
                var dateToUnlock = parameters.UnlockDate(unlockOnDate.Checked, datePicker.Value);
                var modulePostion = parameters.ModulePosition(setModulePos.Checked, nudModulePos.Value);




                //combining all parameters
                var allParameters = requireSequentialProgress + dateToUnlock + modulePostion;

                //Make API Call
                try
                {
                    //Validate fields

                    //Write out submit header
                    rtbResults.AppendText(String.Format("{0,-50} {1,-10}\n", "Module Name", "Status"));
                    //Write Repeating submit       
                    if (xbxUseBase.Checked == true)
                    {
                        try
                        {
                            //Validate Number in text
                            var pattern = @"\[([^\]]*)\]";
                            var inputNumber = Regex.Match(txbBaseName.Text, pattern).Value.Replace("[", "").Replace("]", "");
                            moduleNumber = Convert.ToInt32(inputNumber);

                            //While loop to run until modules to make is zero
                            try
                            {
                                while (moduleToMake > 0)
                                {
                                    //Incrementing assignment number
                                    var incrementedModuleName = Regex.Replace(txbBaseName.Text, @"\[([^\]]*)\]", Convert.ToString(moduleNumber));
                                    var htmlSafeIncrementedModuleName = Uri.EscapeDataString(incrementedModuleName);
                                    var moduleTitleParameter = "&module[name]=" + htmlSafeIncrementedModuleName;

                                    restResult = await requester.MakeRequestAsync(endPoint, tokenParameter, moduleTitleParameter + allParameters);

                                    //Write Results to Text box
                                    rtbResults.AppendText(String.Format("{0,-50} {1,-10}\n", incrementedModuleName, "Created"));
                                    moduleNumber++;
                                    moduleToMake--;
                                }//End Repeating submit while statement

                                //Clear Module Names
                                txbBaseName.Text = "";
                                txbModuleName.Text = "";
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

                        //Creating Module Name and making it HTML safe
                        var moduleNameParameter = "&module[name]=" + Uri.EscapeDataString(txbModuleName.Text);
                        MessageBox.Show(tokenParameter + moduleNameParameter + allParameters);
                        restResult = await requester.MakeRequestAsync(endPoint, tokenParameter, moduleNameParameter + allParameters);
                        //Reset form for next submit
                        nudCourseID.TabStop = false;
                        txbBaseName.TabStop = false;
                        //Write Results to Text box
                        rtbResults.AppendText(String.Format("{0,-50} {1,-10}\n", txbModuleName.Text, "Created"));
                    }// end else
                }//End Single Submit

                catch (Exception apiException)
                {
                    rtbResults.AppendText("Submit Failed: " + apiException.Message + "\n");
                }
            } //end try
            catch (Exception apiException)
            {
                MessageBox.Show("Token not authorized.  Input valid token.\n" + apiException.Message, "Authentication error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void unlockOnDate_CheckedChanged(object sender, EventArgs e)
        {
            if (unlockOnDate.Checked == true)
                datePicker.Enabled = true;
            else
                datePicker.Enabled = false;
        }

        private void setModulePos_CheckedChanged(object sender, EventArgs e)
        {
            if (setModulePos.Checked == true)
            {
                nudModulePos.Enabled = true;
                courseModulesGrid.Enabled = true;
            }
            else
            {
                nudModulePos.Enabled = false;
                courseModulesGrid.Enabled = false;
            }
        }
    }
}
