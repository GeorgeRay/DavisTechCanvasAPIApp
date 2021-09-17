using System;
using System.Windows.Forms;

namespace CanvasAPIApp
{
    public partial class CanvasAPIMainForm : Form
    {
        private AccessTokenForm accessTokenForm = new AccessTokenForm(); //Variable for Access Token Form to see if it is open already

        //Global course ID
        static public int GlobalCourseID = 1;

        //Initializing Form
        public CanvasAPIMainForm()
        {
            InitializeComponent();
        }//End Initializing Form

        public int ActiveWindows()
        {
            return this.MdiChildren.Length;
        }
        //Loading Main form
        private void CanvasAPIMainForm_Load(object sender, EventArgs e)
        {

          
            //If there is no canvas token automatically open settings, this will generally only happen on the first opening. This is just a first time user check.
            if (Properties.Settings.Default.CurrentAccessToken == "No Access Token" || Properties.Settings.Default.CurrentAccessToken == "")
            {
                accessTokenForm.StartPosition = FormStartPosition.CenterScreen;
                accessTokenForm.ShowDialog();

            }


            //loads main form components

            //Load assignment tab
            AssignmentForm assignForm = new AssignmentForm("Create Assignment");
            //tab setup
            assignForm.TopLevel = false;
            assignForm.FormBorderStyle = FormBorderStyle.None;
            assignForm.Dock = DockStyle.Fill;
            tabPageAssign.Controls.Add(assignForm);
            assignForm.Visible = true;

            //Load quiz form
            QuizForm quizForm = new QuizForm("Create Quiz", "Create Quiz");
            //tab setup
            quizForm.TopLevel = false;
            quizForm.FormBorderStyle = FormBorderStyle.None;
            quizForm.Dock = DockStyle.Fill;
            tabPageQuiz.Controls.Add(quizForm);
            quizForm.Visible = true;

            //Load pages form
            PagesForm pageForm = new PagesForm();
            //tab setup
            pageForm.TopLevel = false;
            pageForm.FormBorderStyle = FormBorderStyle.None;
            pageForm.Dock = DockStyle.Fill;
            tabPagePages.Controls.Add(pageForm);
            pageForm.Visible = true;

            //Load courses form
            CoursesForm coursesForm = new CoursesForm();
            //tab setup
            coursesForm.TopLevel = false;
            coursesForm.FormBorderStyle = FormBorderStyle.None;
            coursesForm.Dock = DockStyle.Fill;
            tabPageCourses.Controls.Add(coursesForm);
            coursesForm.Visible = true;

            //Load Module form
            ModuleForm moduleForm = new ModuleForm();
            //tab setup
            moduleForm.TopLevel = false;
            moduleForm.FormBorderStyle = FormBorderStyle.None;
            moduleForm.Dock = DockStyle.Fill;
            tabPageModule.Controls.Add(moduleForm);
            moduleForm.Visible = true;

            //Load Grading Queue
            GradingQueue gradingQueue = new GradingQueue(this);

            //tab setup
            gradingQueue.TopLevel = false;
            gradingQueue.FormBorderStyle = FormBorderStyle.None;
            gradingQueue.Dock = DockStyle.Fill;
            tabPageGradingQueue.Controls.Add(gradingQueue);
            gradingQueue.Visible = true;

            //Load Grading History
            GradingHistoryForm gradingHistory = new GradingHistoryForm();

            //tab setup
            gradingHistory.TopLevel = false;
            gradingHistory.FormBorderStyle = FormBorderStyle.None;
            gradingHistory.Dock = DockStyle.Fill;
            tabGradingHistory.Controls.Add(gradingHistory);     
            gradingHistory.Visible = true;

        }//End Main Form Loading

        //Close Main Form/Application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }//End Closing Main Application

        //Open Create Quiz Form
        private void createQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageQuiz;

        }//End Open Create Quiz Form


        //Open Settings form
        private void accessTokenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            accessTokenForm.StartPosition = FormStartPosition.CenterScreen;
            accessTokenForm.ShowDialog();
            Cursor.Current = Cursors.Default;
            //Load Grading Queue
            GradingQueue gradingQueue = new GradingQueue(this);

            //tab setup
            gradingQueue.TopLevel = false;
            gradingQueue.FormBorderStyle = FormBorderStyle.None;
            gradingQueue.Dock = DockStyle.Fill;
            tabPageGradingQueue.Controls.Add(gradingQueue);
            gradingQueue.Visible = true;


        }

        //Open Current Profile form
        private void getCurrentProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Cursor.Current = Cursors.WaitCursor;
                SimpleTextBox simpleTxbForm = new SimpleTextBox("Current Profile", "Current Profile");
                simpleTxbForm.StartPosition = FormStartPosition.CenterScreen;
                simpleTxbForm.ShowDialog();
                Cursor.Current = Cursors.Default;           

        }//End Open Current Profile Form

        private void aboutCanvasAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpSimpleTextBox helpSimpleTxbForm = new HelpSimpleTextBox("About", "About");

            helpSimpleTxbForm.StartPosition = FormStartPosition.CenterScreen;
            helpSimpleTxbForm.ShowDialog();
        }
        //Assigns active tab to Assignment tab 
        private void createAssignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageAssign;
        }
        //Assigns active tab as Pages Tab
        private void createPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPagePages;
        }
        //Assigns Active tab as Grading queue tab
        private void gradingQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageGradingQueue;
        }


        // When different tabs are selected update the course ID listed in the numericUpDown box
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int currentTab = tabControlMain.SelectedIndex;
                Control courseId;
                //Get the Form (which is technically a control)
                foreach (Control c in tabControlMain.TabPages[currentTab].Controls)
                {
                    if (c is Form && c.Controls["nudCourseID"] != null)
                    {
                        //Get the numericUpDown control
                        courseId = c.Controls["nudCourseID"];
                        //Update value to GlobalCourseID
                        (courseId as NumericUpDown).Value = GlobalCourseID;
                    }
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Unable to update course id.\n" + m.Message);
            }
        }

        private void createModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageModule;
        }

        private void mongoDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Form dataSources = new MongoDBForm();
            dataSources.StartPosition = FormStartPosition.CenterParent;
            dataSources.ShowDialog();
            Cursor.Current = Cursors.Default;

        }
    }
}
