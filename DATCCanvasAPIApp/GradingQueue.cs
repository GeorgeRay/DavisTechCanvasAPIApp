using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using System.Globalization;

namespace CanvasAPIApp
{
    public partial class GradingQueue : Form
    {
        // declarations
        List<Assignment> ungradedAssignmentList;
        private bool isChanging = false;
        private bool connectedToMongoDB = false;
        MongoClient mongoClient;
        IMongoDatabase mongoDatabase;

        public static List<Course> CourseList { get; set; } = new List<Course>();

        public static PrioritySettings prioritySettings = new PrioritySettings();
        public static int defaultPriority { get; set; }

        private bool mongoWarningshown = false;

        Requester requester = new Requester();

        public GradingQueue()
        {
            InitializeComponent();
            //Checking MongoDB has been set up
            if (Properties.Settings.Default.MongoDBDefaultDB != "")
            {
                ConnectToMongoDB();
            }
            RefreshQueue();
        }

        public void ConnectToMongoDB()
        {
            if (Properties.Settings.Default.MongoDBGradingCollection != "")
            {
                try
                {
                    mongoClient = new MongoClient(Properties.Settings.Default.MongoDBConnectionString);
                    mongoDatabase = mongoClient.GetDatabase(Properties.Settings.Default.MongoDBDefaultDB);
                    lblMessageBox.Text = "Connected to MongoDB";
                    connectedToMongoDB = true;
                }
                catch
                {
                    MessageBox.Show("Connection Failed");
                    lblMessageBox.Text = "Not connect to database";
                }
            }
            else
            {
                lblMessageBox.Text = "Credentials Not Stored";
            }
        }

        private void GradingQueue_Load(object sender, EventArgs e)
        {
            prioritySettings = new PrioritySettings();
            defaultPriority = Properties.Settings.Default.DefaultPriority;

        }

        private async void btnLoadCourses_Click(object sender, EventArgs e)
        {
            //forces a reload of courses then continues to load assignments
            lblMessageBox.Text = "Getting Courses";
            CourseList = await populateListOfCourses();
            await RefreshQueue();
        }

        private async Task RefreshQueue()
        {
            //reload the data
            cbxAutoRefresh.Enabled = false;
            btnRefreshQueue.Enabled = false;
            btnLoadCourses.Enabled = false;
            lblMessageBox.Text = "Getting Courses";

            //saves sorting for after refresh
            var sortColumn = gradingDataGrid.SortedColumn;

            System.ComponentModel.ListSortDirection sortDirection = new System.ComponentModel.ListSortDirection();
            if (gradingDataGrid.SortOrder == SortOrder.Ascending)
                sortDirection = System.ComponentModel.ListSortDirection.Ascending;
            else if(gradingDataGrid.SortOrder == SortOrder.Descending)
                sortDirection = System.ComponentModel.ListSortDirection.Descending;

            //gets courses if they aren't already set
            if (CourseList.Count == 0)
            {
                CourseList = await populateListOfCourses();
            }

            lblMessageBox.Text = "Getting Reserved Assignments";
            List<ReservedAssignment> gradingReservedList = new List<ReservedAssignment>();
            if (connectedToMongoDB == true)
            {
                gradingReservedList = await PopulateListOfReservedAssignments();
            }
            if (CourseList.Count > 0)
            {
                lblMessageBox.Text = "Getting Assignments";
                ungradedAssignmentList = await populateGradingEventHistory(CourseList, gradingReservedList);
                if (ungradedAssignmentList.Count == 0)
                {
                    DateTime date = new DateTime();
                    date = DateTime.Now;
                    lblMessageBox.Text = $"Grading Queue is Empty. Last refresh: {date.ToString("t")}";
                    clearDataGridView();
                }
                else
                {
                    lblMessageBox.Text = "Populating List";
                    LoadDataGridView(courseFilter(ungradedAssignmentList, courseFilterTxt.Text));
                    DateTime date = new DateTime();
                    date = DateTime.Now;
                    lblMessageBox.Text = $"Last refresh: {date.ToString("t")}";
                }
            }
            else
            {
                lblMessageBox.Text = "No Courses";
                clearDataGridView();
            }
            //turn back on the buttons
            btnRefreshQueue.Enabled = true;
            cbxAutoRefresh.Enabled = true;
            btnLoadCourses.Enabled = true;
            //Clean up data remove anything in the database reserved by user that is no longer in the queue
            foreach (ReservedAssignment assignment in gradingReservedList)
            {
                if (assignment.grader == Properties.Settings.Default.AppUserName)
                {
                    var mongoCollection = mongoDatabase.GetCollection<BsonDocument>(Properties.Settings.Default.MongoDBGradingCollection);
                    var filter = Builders<BsonDocument>.Filter.Eq("_id", assignment._id);
                    mongoCollection.DeleteOne(filter);
                }
            }

            //resets sort direction
            if (sortColumn != null)
            {
                gradingDataGrid.Sort(sortColumn, sortDirection);
            }
            // using this method as hook to enable courseFilterTxt
            enableCourseFilter();

        }

        private Task<List<ReservedAssignment>> PopulateListOfReservedAssignments()
        {
            return Task.Run(() =>
            {
                try
                {
                    return mongoDatabase.GetCollection<ReservedAssignment>(Properties.Settings.Default.MongoDBGradingCollection).AsQueryable<ReservedAssignment>().ToList();
                }
                catch (Exception)
                {                    
                    return new List<ReservedAssignment>();
                }
               
            });
        }

        private void clearDataGridView()
        {
            gradingDataGrid.Rows.Clear();
        }

        private void LoadDataGridView(List<Assignment> assignmentList)
        {
            //bool sortByPriority = false;
            clearDataGridView();

            if (assignmentList.Count > 0)
            {
                foreach (Assignment assignment in assignmentList)
                {

                    gradingDataGrid.Rows.Add(assignment.graded, assignment.priority, assignment.courseName,
                        assignment.assignment_name, assignment.submitted_at, assignment.workflow_state,
                        assignment.speed_grader_url, assignment.grades_url);
                }
                //default sorting on priority column

                //sort by priority
                gradingDataGrid.Sort(gradingDataGrid.Columns[1], System.ComponentModel.ListSortDirection.Ascending);

            }
        }

        private void enableCourseFilter()
        {
            if (!courseFilterTxt.Enabled)
                courseFilterTxt.Enabled = true;
        }

        private async void btnRefreshQueue_Click(object sender, EventArgs e)
        {
            await RefreshQueue();


        }

        // return priority based on assignment name
        private int assignPriority(string assignmentName)
        {
            // check if name contains any flag and return priority
            for (int i = 0; i < prioritySettings.priorityFlags.Count; i++)
            {

                KeyValuePair<int, string> flag = GradingQueue.prioritySettings.priorityFlags[i];

                if (assignmentName.ToLower().Contains(flag.Value.ToLower()))
                {

                    return flag.Key;
                }

            }

            //otherwise return the set default 
            return defaultPriority;
        }

        private async Task<List<Assignment>> populateGradingEventHistory(List<Course> courseList, List<ReservedAssignment> gradingReservedList)
        {
            Requester requester = new Requester();


            List<Assignment> ungradedAssignmentList = new List<Assignment>();
            string urlParameters;
            urlParameters = "student_ids[]=all";
            urlParameters += "&include[]=assignment";
            urlParameters += "&workflow_state[]=submitted";
            urlParameters += "&workflow_state[]=pending_review";
            urlParameters += "&enrollment_state=active";

            //async webcalls vars
            List<Task> tasks = new List<Task>();

            // gets grading event history
            // adds each call to task
            foreach (Course course in courseList)
            {

                tasks.Add(Task.Run(async () =>
                {
                    string endPoint = Properties.Settings.Default.InstructureSite + $"/api/v1/courses/{course.CourseID}/students/submissions?{urlParameters}&";

                    string json = await requester.MakeRequestAsync(endPoint, Properties.Settings.Default.CurrentAccessToken);
                    if (json != "")
                    {
                        dynamic jsonObj = JsonConvert.DeserializeObject(json);
                        if (jsonObj.Count > 0)
                        {
                            foreach (var submission in jsonObj)
                            {
                                var temp_submitted_at = Convert.ToString(submission.submitted_at);

                                var assignment = submission.assignment;
                                //There is data that came back without a submission date and crashed the program.
                                if (DateTime.TryParse(temp_submitted_at, out DateTime submitted_at))
                                {
                                    submitted_at = submitted_at.ToLocalTime();

                                    //var url = Convert.ToString(submission.url);
                                    //var submitted_at = Convert.ToDateTime(submission.submitted_at).ToLocalTime();
                                    //var submitted_at = Convert.ToString(submission.submitted_at);
                                    var workflow_state = Convert.ToString(submission.workflow_state);
                                    var assignment_id = Convert.ToString(submission.assignment_id);
                                    var user_id = Convert.ToString(submission.user_id);
                                    var priority = -1;
                                    var graded_at = Convert.ToString(submission.graded_at);
                                    var posted_at = Convert.ToString(submission.posted_at);
                                    var preview_url = Convert.ToString(submission.preview_url);
                                    var grader = Convert.ToString(submission.grader);
                                    var assignment_name = Convert.ToString(assignment.name);
                                    var current_graded_at = Convert.ToString(submission.current_graded_at);
                                    var current_grader = Convert.ToString(submission.current_grader);
                                    var speed_grader_url = $"{Properties.Settings.Default.InstructureSite}/courses/{course.CourseID}/gradebook/speed_grader?assignment_id={assignment_id}&student_id={user_id}";
                                    var grades_url = $"{Properties.Settings.Default.InstructureSite}/courses/{course.CourseID}/grades/{user_id}";
                                    var reserved = false;
                                    //assigning priority for sorting
                                    priority = assignPriority($"{assignment_name} {course.CourseName}");
                                    //see if assignment is reserved                                
                                    var results = gradingReservedList.Where(reservedAssignment => reservedAssignment._id == speed_grader_url);
                                    if (results.Count() > 0)
                                    {
                                        var theReservation = results.ElementAt(0);
                                        reserved = true;
                                        workflow_state = $"Reserved by {theReservation.grader} at {theReservation.reserved_at}";
                                        //remove the item from the grading reserve list, the list will be used to trim up the grading database
                                        gradingReservedList.Remove(theReservation);
                                    }

                                    ungradedAssignmentList.Add(new Assignment(reserved, priority, course.CourseName, assignment_name, submitted_at, workflow_state, speed_grader_url, grades_url));
                                }
                            }
                        }
                    }
                }));//end task

            }//end foreach

            //waits for all tasks
            await Task.WhenAll(tasks.ToArray());

            return ungradedAssignmentList;

        }

        private async Task<List<Course>> populateListOfCourses()
        {

            return await Task.Run( async () =>
            {

                List<Course> tempCourseList = new List<Course>();

                // get jsonObj file
                string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses?enrollment_type=teacher&per_page=1000&include[]=needs_grading_count&";//Get endpoint
                
                var json = await requester.MakeRequestAsync(endPoint, Properties.Settings.Default.CurrentAccessToken);
                //if request fails a empty string will be returned, resulting in a null object
                if (json != "")
                {
                    dynamic jsonObj = JsonConvert.DeserializeObject(json);

                    foreach (var course in jsonObj)
                    {

                        tempCourseList.Add(new Course(Convert.ToString(course.id), Convert.ToString(course.name)));
                    }
                }
                return tempCourseList;
            });
        }

        private async void cbxAutoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAutoRefresh.Checked)
            {
                await RefreshQueue();
                nudSeconds.Enabled = true;
                timerRefreshQueue.Interval = Convert.ToInt32(nudSeconds.Value) * 1000;
                timerRefreshQueue.Start();

            }
            else
            {
                nudSeconds.Enabled = false;
                timerRefreshQueue.Stop();
            }
            // using this method as hook to enable courseFilterTxt
            enableCourseFilter();
        }

        private async void timerRefreshQueue_Tick(object sender, EventArgs e)
        {
            await RefreshQueue();
        }

        private void gradingDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gradingDataGrid.CurrentCell != null)
            {
                if (gradingDataGrid.Columns[e.ColumnIndex].HeaderText.Contains("URL") && gradingDataGrid.CurrentCell.EditedFormattedValue.ToString().Contains("https"))
                {
                    var url = gradingDataGrid.CurrentCell.EditedFormattedValue.ToString();
                    Process.Start(url);
                }
                //Reserved Column gets clicked 
                else if (gradingDataGrid.Columns[e.ColumnIndex].HeaderText.Contains("Reserved"))
                {
                    //If there is no database connected let the user know.
                    if (Properties.Settings.Default.MongoDBGradingCollection == "" && mongoWarningshown == false)
                    {
                        mongoWarningshown = true;
                        var result = MessageBox.Show("To Reserve assignment you must add a MongoDB Connection.\nWould you like to connect to a database?", "Create Database", MessageBoxButtons.YesNo);

                        switch (result)
                        {
                            case DialogResult.Yes:
                                Cursor.Current = Cursors.WaitCursor;
                                Form dataSources = new MongoDBForm();
                                dataSources.StartPosition = FormStartPosition.CenterParent;
                                dataSources.ShowDialog();
                                Cursor.Current = Cursors.Default;
                                ConnectToMongoDB();
                                break;
                            case DialogResult.No:
                                break;
                        }
                    }
                    else //database
                    {
                        //Reserved is checked
                        if (Convert.ToBoolean(gradingDataGrid.CurrentCell.Value) == true)
                        {
                            DialogResult dialogResult = MessageBox.Show("This assignment is currently reserved. Do you want to unassign it?", "Unreserve?", MessageBoxButtons.YesNo);

                            if (dialogResult == DialogResult.Yes)
                            {
                                gradingDataGrid.CurrentCell.Value = false;
                                //Remove the data from the database
                                if (connectedToMongoDB == true)
                                {
                                    var mongoCollection = mongoDatabase.GetCollection<BsonDocument>(Properties.Settings.Default.MongoDBGradingCollection);
                                    string url = gradingDataGrid.Rows[e.RowIndex].Cells[6].EditedFormattedValue.ToString();
                                    //Make call for URL
                                    var filter = Builders<BsonDocument>.Filter.Eq("_id", url);
                                    mongoCollection.DeleteOne(filter);
                                }
                            }
                        }
                        else //Reserved is not checked
                        {
                            
                            string url = gradingDataGrid.Rows[e.RowIndex].Cells[6].EditedFormattedValue.ToString();

                            //Add the data to the database
                            if (connectedToMongoDB == true)
                            {
                                var mongoCollection = mongoDatabase.GetCollection<BsonDocument>(Properties.Settings.Default.MongoDBGradingCollection);

                                BsonDocument documentToWrite = new BsonDocument { { "_id", url }, { "grader", Properties.Settings.Default.AppUserName }, { "reserved_at", DateTime.Now.ToString() } };
                                try
                                { 
                                    Process browserTab = Process.Start(url); //grading url in new tab
                                    mongoCollection.InsertOne(documentToWrite); //try to write to database
                                    //continue if successful:
                                    gradingDataGrid.CurrentCell.Value = true;
                                }
                                catch (MongoDB.Driver.MongoWriteException writeException)
                                {
                                    //Make call for URL
                                    if (writeException.WriteError.Category == ServerErrorCategory.DuplicateKey) // if this entry has already been made (assignment already reserved)
                                    {
                                        var filter = Builders<BsonDocument>.Filter.Eq("_id", url);
                                        var conflictDocument = mongoCollection.Find(filter).FirstOrDefault();
                                        var grader = conflictDocument.GetElement("grader");

                                        gradingDataGrid.CurrentCell.Value = true;
                                        this.Activate(); //pulls the form into focus to display message
                                       
                                        MessageBox.Show($"This assignment was reserved by {grader.Value}");

                                        RefreshQueue(); //refresh queue to update reserved checkbox

                                    }
                                    else
                                    {
                                        MessageBox.Show($"There was a MongoDB write error {writeException.Message}");
                                    }
                                }
                            }//end if(connectedToMongo)
                        }
                    }

                }
                //Course column gets clicked
                else if (gradingDataGrid.Columns[e.ColumnIndex].HeaderText.Contains("Course"))
                {
                    var url = gradingDataGrid.Rows[e.RowIndex].Cells[7].EditedFormattedValue.ToString();
                    Process.Start(url);
                }
                else if (gradingDataGrid.Columns[e.ColumnIndex].HeaderText.Contains("Assignment"))
                {
                    var url = gradingDataGrid.Rows[e.RowIndex].Cells[6].EditedFormattedValue.ToString();
                    Process.Start(url);
                }
            }

        }

        // filters ungradedAssignmentList by courseName property
        private List<Assignment> courseFilter(List<Assignment> assignments, string filterFor)
        {
            if (!filterFor.Equals(string.Empty)) // argument is not empty
            {
                lblMessageBox.Text = "Filtering by course";
                // get assignments where courseName contains argument
                var result = from assignment in assignments
                             where assignment.courseName.ToLower().Contains(filterFor.ToLower())
                             select assignment;

                // return filtered assignments
                return result.ToList();
            }
            else // argument is empty
            {
                lblMessageBox.Text = "";
                // return all assignments
                return assignments;
            }
        }

        // filter courses on courseFilterTxt TextChanged event
        private async void courseFilterTxt_TextChanged(object sender, EventArgs e)
        {
            // set delay amount to prevent filtering on each key press
            int delayEvent = 750;

            // if delaying, do nothing
            if (isChanging)
                return;

            // indicate delay then delay
            isChanging = true;
            await Task.Delay(delayEvent);

            // delay over, filter input and reload ui then reset flag
            LoadDataGridView(courseFilter(ungradedAssignmentList, courseFilterTxt.Text));
            isChanging = false;
        }

        private class ReservedAssignment
        {
            public ReservedAssignment(string url, string grader, string reserved_at)
            {
                this._id = url;
                this.grader = grader;
                this.reserved_at = reserved_at;
            }

            public string _id { get; set; }
            public string grader { get; set; }
            public string reserved_at { get; set; }
        }

        private async void btnPrioritySettings_Click(object sender, EventArgs e)
        {
            GradingQueuePriorityForm gradingQueuePriorityForm = new GradingQueuePriorityForm();
            gradingQueuePriorityForm.StartPosition = FormStartPosition.CenterScreen;
            gradingQueuePriorityForm.ShowDialog();


            await RefreshQueue();
        }


        public class PrioritySettings
        {

            public List<KeyValuePair<int, string>> priorityFlags { get; set; }

            //constructor, initialized flag list / loads settings
            public PrioritySettings()
            {
                priorityFlags = new List<KeyValuePair<int, string>>();
                LoadSettings();
            }

            //clears lists
            public void ClearPriorityList()
            {
                priorityFlags.Clear();
            }

            //sets priority list with a string, separated by commas
            public void SetPrioritiesJson(string json)
            {
                ClearPriorityList();

                priorityFlags = JsonConvert.DeserializeObject<List<KeyValuePair<int, string>>>(json);

                SortPriorities();
            }

            //sorts by priority
            public void SortPriorities()
            {
                priorityFlags = priorityFlags.OrderBy(sort => sort.Key).ToList<KeyValuePair<int, string>>();

            }

            //loads settings from properties
            public void LoadSettings()
            {
                string json = Properties.Settings.Default.PriorityFlags;

                if (!String.IsNullOrEmpty(json))
                    SetPrioritiesJson(json);
            }

            //saves settings to properties
            public void SaveSettings()
            {
                string json = JsonConvert.SerializeObject(priorityFlags);

                Properties.Settings.Default.PriorityFlags = json;

                Properties.Settings.Default.Save();
            }
        }

        
    }
}
