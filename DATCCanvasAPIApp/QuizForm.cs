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
    public partial class QuizForm : Form
    {
        //Give the whole class access to parameters
        QuizMethods methods = new QuizMethods();
        //Dictionary items to POST
        Dictionary<string, string> assignmentGroupvalues = new Dictionary<string, string>();
        //Give Class access to Get Call
        GeneralAPIGets getProfile = new GeneralAPIGets();

        //Declaring varables
        string userName;

        //Initialize Form
        public QuizForm(string title, string resourceName)
        {
            InitializeComponent();
            Text = title; //set title text3
        }//End Initialization

        //Load Quiz Form
        private void QuizForm_Load(object sender, EventArgs e)
        {

            //setting default values
            cbxQuizType.SelectedItem = "Graded Quiz";

        }//End Load Quiz Form

        //Time Limit Check box change
        private void xbxTimeLimit_CheckedChanged(object sender, EventArgs e)
        {
            if (xbxTimeLimit.Checked == true)
            {
                nudMinutes.Enabled = true;
            }
            else
            {
                nudMinutes.Enabled = false;
            }
        }//End Time Limit Check box change

        //Attempts Check box changed
        private void xbxAttempts_CheckedChanged(object sender, EventArgs e)
        {
            if (xbxAttempts.Checked)
            {
                lblQuiz2Keep.Visible = true;
                cbxScoreToKeep.Visible = true;
                xbxLimitAttempts.Visible = true;
                nudAttempts.Visible = true;
            }
            else
            {
                lblQuiz2Keep.Visible = false;
                cbxScoreToKeep.Visible = false;
                xbxLimitAttempts.Visible = false;
                xbxLimitAttempts.Checked = false;
                nudAttempts.Visible = false;
                nudAttempts.Value = 1;

            }
        }//End Attempts Check box changed

        //One Question at a time Changed
        private void xbxOneQuestionTime_CheckedChanged(object sender, EventArgs e)
        {
            if (xbxOneQuestionTime.Checked == true)
            {
                xbxLockQuestion.Visible = true;
            }
            else
            {
                xbxLockQuestion.Visible = false;
                xbxLockQuestion.Checked = false;
            }
        }//End One Question at a time changed

        //IP Address Changed
        private void xbxIPAddresses_CheckedChanged(object sender, EventArgs e)
        {
            if (xbxIPAddresses.Checked == true)
            {
                txbIPAddresses.Visible = true;
                lblIpAddresses.Visible = true;
            }
            else
            {
                txbIPAddresses.Visible = false;
                lblIpAddresses.Visible = false;
            }
        }//End IP Address Check Box Changed

        //Access Code Check Box Changed
        private void xbxAccessCode_CheckedChanged(object sender, EventArgs e)
        {
            if (xbxAccessCode.Checked == true)
            {
                txbAccessCode.Visible = true;
            }
            else
            {
                txbAccessCode.Visible = false;
            }
        }//Access Code Check Box Changed

        //Base Name Check Box Changed
        private void txbBaseName_TextChanged(object sender, EventArgs e)
        {

            txbQuizName.Text = txbBaseName.Text.Replace("[", "").Replace("]", "");
        }//End Base Name Check Box Changed

        private void xbxAllowAttempts_CheckedChanged(object sender, EventArgs e)
        {
            if (xbxLimitAttempts.Checked)
            {
                nudAttempts.Enabled = true;
                if (xbxQuizResponses.Checked == true)
                {
                    xbxOnlyAfterLastAttempt.Visible = true;
                    //Only show correct Answers After last Attempt of See correct Answers is already checked
                    if (xbxSeeCorrectAnswers.Checked == true)
                    {
                        xbxCorrectAnswersAfterLastAttempt.Visible = true;
                    }
                }

            }
            else
            {
                nudAttempts.Enabled = false;
                xbxOnlyAfterLastAttempt.Visible = false;
                xbxOnlyAfterLastAttempt.Checked = false;
                xbxCorrectAnswersAfterLastAttempt.Checked = false;
                xbxCorrectAnswersAfterLastAttempt.Visible = false;
            }
        }//End Allowed Attemps

        //Control items in response combo box
        private void cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (xbxQuizResponses.Checked) //if the Quiz responeses is check
            {
                if (xbxLimitAttempts.Checked == true)//if the allowed attempts is check
                {
                    //show the items that pertain to the number of times the quiz is taken
                    xbxOnlyAfterLastAttempt.Visible = true;
                    xbxCorrectAnswersAfterLastAttempt.Visible = true;
                    lblShowCorrectAnswer.Visible = true;
                    lblHideCorrectAnswers.Visible = true;
                    dtpShow.Visible = true;
                    dtpShowTime.Visible = true;
                    dtpHide.Visible = true;
                    dtpHideTime.Visible = true;
                }
                xbxOnlyOnce.Visible = true;
                xbxSeeCorrectAnswers.Visible = true;
            }
            else
            {
                xbxOnlyAfterLastAttempt.Visible = false;
                xbxCorrectAnswersAfterLastAttempt.Visible = false;
                lblShowCorrectAnswer.Visible = false;
                lblHideCorrectAnswers.Visible = false;
                dtpShow.Visible = false;
                dtpShowTime.Visible = false;
                dtpHide.Visible = false;
                dtpHideTime.Visible = false;
                xbxOnlyOnce.Visible = false;
                xbxSeeCorrectAnswers.Visible = false;


            }
        }//End Control items in response combo box

        //submit Button
        private async void btnSubmitQuiz_Click(object sender, EventArgs e)
        {
            //create variables

            string restResult = "No Call Made";//this will be over written by results from web call
            var tokenParameter = methods.AccessToken();//Create 
            string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + Convert.ToString(nudCourseID.Value) + "/quizzes?";//Get base endpoint from setting
            Requester requester = new Requester();
            int quizesToMake = Convert.ToInt32(nudNumberOfQuiz.Value);
            int quizNumber = 0;
            //Setting methods

            var quizTypeParameter = methods.QuizType(Convert.ToString(cbxQuizType.SelectedItem));
            //Getting key back
            var assignmentGroupKey = (from kvp in assignmentGroupvalues where kvp.Value == Convert.ToString(cbxAssignmentGroup.SelectedItem) select kvp.Key).FirstOrDefault();
            var assignmentTypeParameter = methods.AssignmentGroup(assignmentGroupKey);
            var quizTimeLimitParameter = methods.QuizTimeLimit(xbxTimeLimit.Checked, Convert.ToInt32(nudMinutes.Value));
            var shuffleAnswersParameter = methods.ShuffleAnswers(xbxShuffle.Checked);
            var hideResultsParameter = methods.HideResults(xbxQuizResponses.Checked, xbxOnlyAfterLastAttempt.Checked);
            var showCorrectAnswer = methods.ShowCorrectAnswer(xbxSeeCorrectAnswers.Checked);
            var showCorrectAnswerLastAttempt = methods.ShowCorrectAnswerLastAttempt(xbxCorrectAnswersAfterLastAttempt.Checked);
            var showCorrectAnswersAt = methods.ShowCorrectAnswerAt(xbxSeeCorrectAnswers.Checked, dtpShow.Checked, dtpShow.Value, dtpShowTime.Value);
            var hideCorrectAnswersAt = methods.HideCorrectAnswerAt(xbxSeeCorrectAnswers.Checked, dtpHide.Checked, dtpHide.Value, dtpHideTime.Value);
            var allowedAttempts = methods.AllowedAttempts(xbxAttempts.Checked, xbxLimitAttempts.Checked, Convert.ToInt32(nudAttempts.Value));
            var scoringPolicy = methods.ScoringPolicy(Convert.ToString(cbxScoreToKeep.SelectedItem));
            var oneQuestionAtATime = methods.OneQuestionAtATime(xbxOneQuestionTime.Checked);
            var cantGoBack = methods.CantGoBack(xbxOneQuestionTime.Checked, xbxLockQuestion.Checked);
            var accessCode = methods.AccessCode(xbxAccessCode.Checked, txbAccessCode.Text);
            var ipAddressFilter = methods.IpAddressFiltering(xbxIPAddresses.Checked, txbIPAddresses.Text);
            var oneTimeResults = methods.OneTimeResults(xbxQuizResponses.Checked, xbxOnlyOnce.Checked);
            var requireLockdownBrowser = methods.RequireLockdownBrowser(xbxRequireLockDownBowser.Checked);
            var requireLockdownBrowsertoView = methods.RequireLockdownBrowsertoVeiwResults(xbxRequireLockDownBowser.Checked, xbxRequireLockDownBrowsertoViewResuts.Checked);
            var dueDate = methods.DueDate(dtpDueDate.Checked, dtpDueDate.Value, dtpDueDateTime.Value);
            var unlockDate = methods.UnlockDate(dtpUnlockDate.Checked, dtpUnlockDate.Value, dtpUnlockDateTime.Value);
            var lockDate = methods.LockDate(dtpLockDate.Checked, dtpLockDate.Value, dtpLockDateTime.Value);
            var publishQuiz = methods.PublishQuiz(xbxPublish.Checked);
            //combining all parameters
            var allParameters = quizTypeParameter + assignmentTypeParameter
                  + shuffleAnswersParameter + quizTimeLimitParameter + hideResultsParameter + showCorrectAnswer + showCorrectAnswerLastAttempt
                  + showCorrectAnswersAt + hideCorrectAnswersAt + dueDate + unlockDate + lockDate + allowedAttempts + scoringPolicy + oneQuestionAtATime
                  + cantGoBack + accessCode + ipAddressFilter + oneTimeResults + requireLockdownBrowser + publishQuiz + requireLockdownBrowsertoView;

            //rtbResults.AppendText(allParameters);

            //Make API Call

            try
            {
                //Validate fields

                //Write out submit header
                rtbResults.AppendText(String.Format("{0,-50} {1,-10}\n", "Quiz Name", "Status"));
                //Write Repeating submit       
                if (xbxUseBase.Checked == true)
                {
                    try
                    {
                        //Validate Number in text
                        var pattern = @"\[([^\]]*)\]";
                        var inputNumber = Regex.Match(txbBaseName.Text, pattern).Value.Replace("[", "").Replace("]", "");
                        quizNumber = Convert.ToInt32(inputNumber);
                        //While loop to run until Quizes to make is zero

                        try
                        {
                            while (quizesToMake > 0)
                            {
                                //Incrementing quiz number
                                var incrementedQuizName = Regex.Replace(txbBaseName.Text, @"\[([^\]]*)\]", Convert.ToString(quizNumber));
                                var htmlSafeIncrementedQuizName = Uri.EscapeDataString(incrementedQuizName);
                                var quizTitleParameter = "&quiz[title]=" + htmlSafeIncrementedQuizName;
                                //Formating Quiz Description for HTML
                                var incrementedQuizInstruction = Regex.Replace(rtbQuizInstructions.Text, @"\[([^\]]*)\]", incrementedQuizName);
                                var htmlSafeIncrementedQuizInstruction = Uri.EscapeDataString(incrementedQuizInstruction);
                                var quizDescriptionParameter = methods.QuizDescription(htmlSafeIncrementedQuizInstruction);
                                //REST Call
                                restResult = await requester.MakeRequestAsync(endPoint, tokenParameter, quizTitleParameter + allParameters + quizDescriptionParameter);
                                //Write Results to Text box
                                rtbResults.AppendText(String.Format("{0,-50} {1,-10}\n", incrementedQuizName, "Created"));
                                quizNumber++;
                                quizesToMake--;
                            }//End Repeating submit while statement

                            //Clear QuizNames
                            txbBaseName.Text = "";
                            txbQuizName.Text = "";
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
                    //Creating Quiz Title and making it HTML safe
                    var quizTitleParameter = "&quiz[title]=" + Uri.EscapeDataString(txbQuizName.Text);
                    //Formating Quiz Description for HTML
                    var incrementedQuizInstruction = Regex.Replace(rtbQuizInstructions.Text, @"\[([^\]]*)\]", txbQuizName.Text);
                    //Makeing Quiz instruction HTML Safe
                    var htmlSafeIncrementedQuizInstruction = Uri.EscapeDataString(incrementedQuizInstruction);
                    //Setting quiz description parameter
                    var quizDescriptionParameter = methods.QuizDescription(htmlSafeIncrementedQuizInstruction);
                    restResult = await requester.MakeRequestAsync(endPoint, tokenParameter, quizTitleParameter + allParameters + quizDescriptionParameter);
                    //Reset form for next submit
                    nudCourseID.TabStop = false;
                    txbBaseName.TabStop = false;
                    //Write Results to Text box
                    rtbResults.AppendText(String.Format("{0,-50} {1,-10}\n", txbQuizName.Text, "Created"));
                }//End Single Submit
            }
            catch (Exception apiException)
            {
                rtbResults.AppendText("Submit Failed: " + apiException.Message + "\n");
            }
        }//End Submit

        private void xbxUseBase_CheckedChanged(object sender, EventArgs e)
        {
            if (xbxUseBase.Checked == true)
            {
                txbBaseName.Enabled = true;
                nudNumberOfQuiz.Enabled = true;
                txbQuizName.ReadOnly = true;
            }
            else
            {
                txbBaseName.Enabled = false;
                nudNumberOfQuiz.Enabled = false;
                txbQuizName.ReadOnly = false;
                txbQuizName.Enabled = true;
            }
        }//End Use Base check box changed

        private void xbxSeeCorrectAnswers_CheckedChanged(object sender, EventArgs e)
        {
            if (xbxSeeCorrectAnswers.Checked == true)
            {
                if (xbxLimitAttempts.Checked == true)
                {
                    xbxCorrectAnswersAfterLastAttempt.Visible = true;
                }
                lblHideCorrectAnswers.Visible = true;
                lblShowCorrectAnswer.Visible = true;
                dtpShow.Visible = true;
                dtpShowTime.Visible = true;
                dtpHide.Visible = true;
                dtpHideTime.Visible = true;
            }
            else
            {
                xbxCorrectAnswersAfterLastAttempt.Visible = false;
                lblHideCorrectAnswers.Visible = false;
                lblShowCorrectAnswer.Visible = false;
                dtpShow.Visible = false;
                dtpShowTime.Visible = false;
                dtpHide.Visible = false;
                dtpHideTime.Visible = false;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {

            //Clear the controls 
            this.Controls.Clear();
            //Initialize Components
            this.InitializeComponent();
            //resetting form
            cbxQuizType.SelectedItem = "Graded Quiz";
            assignmentGroupvalues.Clear();
        }//End Button Reset form

        private void txbQuizName_TextChanged(object sender, EventArgs e)
        {
            if (txbQuizName.TextLength > 0 & nudCourseID.Value > 1)
                btnSubmitQuiz.Enabled = true;
            else
                btnSubmitQuiz.Enabled = false;
        }//End Quiz Name Text Changed

        private void nudCourseID_ValueChanged(object sender, EventArgs e)
        {
            //Code was moved to course load button but method left in for future use.
        }//End Course ID number Change

        private void cbxQuizType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxQuizType.Text == "Practice Quiz" || cbxQuizType.Text == "Ungraded Survey")
            {
                cbxAssignmentGroup.Visible = false;
                lblAssignmentGroup.Visible = false;
            }
            else
            {
                cbxAssignmentGroup.Visible = true;
                lblAssignmentGroup.Visible = true;
            }
            if (cbxQuizType.Text == "Ungraded Survey" || cbxQuizType.Text == "Graded Survey")
            {
                xbxAnonymous.Visible = true;
                if (cbxQuizType.Text == "Graded Survey")
                {
                    lblScore.Visible = true;
                    nudScore.Visible = true;
                }
            }
            else
            {
                xbxAnonymous.Visible = false;
                lblScore.Visible = false;
                nudScore.Visible = false;
            }
        }//End Quiz Type selected change

        private async void btnLoadCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.CurrentAccessToken != "No Access Token" && Properties.Settings.Default.CurrentAccessToken != "")
                {
                    if (nudCourseID.Value == 1)
                    {
                        MessageBox.Show("Please Enter a Course ID");
                    }
                    else
                    {
                        if (txbQuizName.TextLength > 0 & nudCourseID.Value > 1)
                            btnSubmitQuiz.Enabled = true;
                        else
                            btnSubmitQuiz.Enabled = false;
                        //allow user to input course name
                        txbBaseName.Enabled = true;

                        //Setting wait curser
                        Cursor.Current = Cursors.WaitCursor;
                        //Make Call to get user name
                        if (Properties.Settings.Default.CurrentAccessToken != "No Access Token" && Properties.Settings.Default.CurrentAccessToken != "")
                        {
                            string profileObject = "name";
                            userName = await getProfile.GetProfile(profileObject);

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
                            var json = await requester.MakeRequestAsync(endPoint, methods.AccessToken());
                            dynamic jsonObj = JsonConvert.DeserializeObject(json);

                            foreach (var obj in jsonObj)
                            {
                                assignmentGroupvalues.Add(Convert.ToString(obj.id), Convert.ToString(obj.name));
                                cbxAssignmentGroup.Items.Add(Convert.ToString(obj.name));
                            }
                            //Get Course Name
                            endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + nudCourseID.Value + "?";
                            Requester courseRequester = new Requester();
                            json = await courseRequester.MakeRequestAsync(endPoint, methods.AccessToken());
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
        }//End Load Course Click

        private void dtpShow_ValueChanged(object sender, EventArgs e)
        {
            if (dtpShow.Checked == true)
                dtpShowTime.Enabled = true;
            else
                dtpShowTime.Enabled = false;
        }//End show date Value Change

        private void dtpHide_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHide.Checked == true)
                dtpHideTime.Enabled = true;
            else
                dtpHideTime.Enabled = false;
        }//End Hide Date Value Change

        private void cbxRequireLockDownBowser_CheckedChanged(object sender, EventArgs e)
        {
            if (xbxRequireLockDownBowser.Checked == true)
            {
                xbxRequireLockDownBrowsertoViewResuts.Checked = true;
                xbxRequireLockDownBrowsertoViewResuts.Visible = true;
            }
            else
            {
                xbxRequireLockDownBrowsertoViewResuts.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (userName == "AJ Hepler" || userName == "George Ray")
            {
                MessageBox.Show("For the Unicorn AJ here is your publish button!");
                rtbResults.AppendText("Task: Let AJ know we love him.\nCheck.");
            }
        }

        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDueDate.Checked == true)
                dtpDueDateTime.Enabled = true;
            else
                dtpDueDateTime.Enabled = false;
        }

        private void dtpLockDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpLockDate.Checked == true)
                dtpLockDateTime.Enabled = true;
            else
                dtpLockDateTime.Enabled = false;
        }

        private void dtpUnlockDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpUnlockDate.Checked == true)
                dtpUnlockDateTime.Enabled = true;
            else
                dtpUnlockDateTime.Enabled = false;
        }

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
    }//End class
}//End method
