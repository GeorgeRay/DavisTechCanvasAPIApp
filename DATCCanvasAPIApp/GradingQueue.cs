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

        // priority flags
        List<string> priority1Flags = new List<string>()
        {
            "instructor meeting",
            "completion",
            "cisco networking academy account setup",
        };
        List<string> priority2Flags = new List<string>()
        {
            "pacific trails",
        };
        List<string> priority3Flags = new List<string>()
        {
            "final",
        };

        private bool mongoWarningshown = false;

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

        }

        private async Task RefreshQueue()
        {
            //reload the data
            btnRefreshQueue.Enabled = false;
            lblMessageBox.Text = "Getting Courses";
            var courseList = await populateListOfCourses();
            lblMessageBox.Text = "Getting Reserved Assignments";
            List<ReservedAssignment> gradingReservedList = new List<ReservedAssignment>();
            if (connectedToMongoDB == true)
            {
                gradingReservedList = await PopulateListOfReservedAssignments();
            }
            if (courseList.Count > 0)
            {
                lblMessageBox.Text = "Loading Assignments";
                ungradedAssignmentList = await populateGradingEventHistory(courseList, gradingReservedList);
                LoadDataGridView(courseFilter(ungradedAssignmentList, courseFilterTxt.Text));
            }
            else
            {
                lblMessageBox.Text = "Grading Queue is empty";
                clearDataGridView();
            }
            btnRefreshQueue.Enabled = true;
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

        }

        private Task<List<ReservedAssignment>> PopulateListOfReservedAssignments()
        {
            return Task.Run(() =>
            {
                return mongoDatabase.GetCollection<ReservedAssignment>(Properties.Settings.Default.MongoDBGradingCollection).AsQueryable<ReservedAssignment>().ToList();
            });
        }

        private void clearDataGridView()
        {
            gradingDataGrid.Rows.Clear();
        }

        private void LoadDataGridView(List<Assignment> assignmentList)
        {
            bool sortByPriority = false;
            clearDataGridView();

            if (assignmentList.Count > 0)
            {
                foreach (Assignment assignment in assignmentList)
                {
                    if (assignment.priority < 4 && sortByPriority == false)
                        sortByPriority = true;

                    gradingDataGrid.Rows.Add(assignment.graded, assignment.priority, assignment.courseName,
                        assignment.assignment_name, assignment.submitted_at, assignment.workflow_state,
                        assignment.speed_grader_url, assignment.grades_url);
                }
                //default sorting on priority column 
                if (sortByPriority == true)
                {
                    gradingDataGrid.Sort(gradingDataGrid.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
                }
                else
                {
                    gradingDataGrid.Sort(gradingDataGrid.Columns[4], System.ComponentModel.ListSortDirection.Ascending);
                }
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

            // using this method as hook to enable courseFilterTxt
            enableCourseFilter();
        }

        // return priority based on assignment name
        private int assignPriority(string assignmentName)
        {
            // check if name contains any flag and return priority
            if (priority1Flags.Any(flag => assignmentName.ToLower().Contains(flag.ToLower())))
                return 1;
            else if (priority2Flags.Any(flag => assignmentName.ToLower().Contains(flag.ToLower())))
                return 2;
            else if (priority3Flags.Any(flag => assignmentName.ToLower().Contains(flag.ToLower())))
                return 3;
            else
                return 4;
        }

        private Task<List<Assignment>> populateGradingEventHistory(List<Course> courseList, List<ReservedAssignment> gradingReservedList)
        {
            return Task.Run(() =>
            {
                List<Assignment> ungradedAssignmentList = new List<Assignment>();
                string urlParameters;
                urlParameters = "student_ids[]=all";
                urlParameters += "&include[]=assignment";
                urlParameters += "&workflow_state[]=submitted";
                urlParameters += "&workflow_state[]=pending_review";
                urlParameters += "&enrollment_state=active";

                // get grading history
                foreach (Course course in courseList)
                {
                    string endPoint = Properties.Settings.Default.InstructureSite + $"/api/v1/courses/{course.CourseID}/students/submissions?{urlParameters}&";
                    var client = new RestClient(endPoint);
                    var json = client.MakeRequest("access_token=" + Properties.Settings.Default.CurrentAccessToken);
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
                                    priority = assignPriority(assignment_name);
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



                }
                return ungradedAssignmentList;
            });
        }


        private Task<List<Course>> populateListOfCourses()
        {

            return Task.Run(() =>
            {

                List<Course> tempCourseList = new List<Course>();

                // get jsonObj file
                string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses?enrollment_type=teacher&per_page=1000&include[]=needs_grading_count&";//Get endpoint
                var client = new RestClient(endPoint);
                var json = client.MakeRequest("access_token=" + Properties.Settings.Default.CurrentAccessToken);
                //if request fails a empty string will be returned, resulting in a null object
                if (json != "")
                {
                    dynamic jsonObj = JsonConvert.DeserializeObject(json);

                    foreach (var course in jsonObj)
                    {
                        var enrollments = course.enrollments;
                        foreach (var enrollment in enrollments)
                        {

                            var needs_grading_count = Convert.ToInt32(course.needs_grading_count);
                            if (needs_grading_count > 0)
                            {
                                tempCourseList.Add(new Course(Convert.ToString(course.id), Convert.ToString(course.name)));
                            }

                        }

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
                    else
                    {
                        //Reserved is checked
                        if (Convert.ToBoolean(gradingDataGrid.CurrentCell.Value) == true)
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
                        else
                        {
                            gradingDataGrid.CurrentCell.Value = true;

                            string url = gradingDataGrid.Rows[e.RowIndex].Cells[6].EditedFormattedValue.ToString();
                            Process.Start(url);

                            //Add the data to the database
                            if (connectedToMongoDB == true)
                            {
                                var mongoCollection = mongoDatabase.GetCollection<BsonDocument>(Properties.Settings.Default.MongoDBGradingCollection);

                                BsonDocument documentToWrite = new BsonDocument { { "_id", url }, { "grader", Properties.Settings.Default.AppUserName }, { "reserved_at", DateTime.Now.ToString() } };
                                try
                                {
                                    mongoCollection.InsertOne(documentToWrite);
                                }
                                catch (MongoDB.Driver.MongoWriteException writeException)
                                {
                                    //Make call for URL
                                    if (writeException.WriteError.Category == ServerErrorCategory.DuplicateKey)
                                    {
                                        var filter = Builders<BsonDocument>.Filter.Eq("_id", url);
                                        var conflictDocument = mongoCollection.Find(filter).FirstOrDefault();
                                        var grader = conflictDocument.GetElement("grader");
                                        MessageBox.Show($"This assignment was reserved by {grader.Value}");
                                    }
                                    else
                                    {
                                        MessageBox.Show($"There was a MongoDB write error {writeException.Message}");
                                    }
                                }
                            }
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
    }
}
