using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CanvasAPIApp
{
    public partial class GradingQueue : Form
    {
        //Set access token
        string coursesAccessToken = "access_token=" + Properties.Settings.Default.CurrentAccessToken;
        string url = Properties.Settings.Default.InstructureSite;
        //Give Class access to Get Call
        GeneralAPIGets getProfile = new GeneralAPIGets();

        //List<Course> courseList = new List<Course>();
     

        public GradingQueue()
        {
            InitializeComponent();
        }

        private void GradingQueue_Load(object sender, EventArgs e)
        {

        }

        private async Task RefreshQueue()
        { 
            //reload the data
            lblMessageBox.Text = "Getting Courses";
            var courseList = await populateListOfCourses();
            if (courseList.Count > 0)
            {
                lblMessageBox.Text = "Loading Assignments";
                var ungradedAssignmentList = await populateGradingEventHistory(courseList);
                LoadDataGridView(ungradedAssignmentList);
                lblMessageBox.Text = "";
            }
            else
            {
                lblMessageBox.Text = "Grading Queue is empty";
            }

            
        }

        private void LoadDataGridView(List<Assignment> ungradedAssignmentList)
        {
            bool sortByPriority = false;
            gradingDataGrid.Rows.Clear();
            foreach(Assignment assignment in ungradedAssignmentList)
            {
                if (assignment.priority < 4 && sortByPriority == false)
                {
                    sortByPriority = true;
                }

                gradingDataGrid.Rows.Add(assignment.graded, assignment.priority, assignment.courseName, 
                    assignment.assignment_name, assignment.submitted_at, assignment.workflow_state, 
                    assignment.speed_grader_url);
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

        private async void btnRefreshQueue_Click(object sender, EventArgs e)
        {
            await RefreshQueue();
        }

        private Task<List<Assignment>> populateGradingEventHistory(List<Course> courseList)
        {
            DataGridView tempDataGridView = gradingDataGrid;
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
                    string endPoint = url + $"/api/v1/courses/{course.CourseID}/students/submissions?{urlParameters}&";
                    var client = new RestClient(endPoint);
                    var json = client.MakeRequest(coursesAccessToken);
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
                                var speed_grader_url = $"{url}/courses/{course.CourseID}/gradebook/speed_grader?assignment_id={assignment_id}&student_id={user_id}";

                                //assigning priority for sorting
                                if (assignment_name.Contains("Instructor Meeting"))
                                {
                                    priority = 1;
                                }
                                else if (assignment_name.Contains("Pacific Trails"))
                                {
                                    priority = 2;
                                }
                                else if (assignment_name.Contains("Final"))
                                {
                                    priority = 3;
                                }
                                else
                                {
                                    priority = 4;
                                }

                               ungradedAssignmentList.Add(new Assignment(false, priority, course.CourseName, assignment_name, submitted_at, workflow_state, speed_grader_url));

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
               string endPoint = url + "/api/v1/courses?enrollment_type=teacher&per_page=1000&include[]=needs_grading_count&";//Get endpoint
               var client = new RestClient(endPoint);
               var json = client.MakeRequest(coursesAccessToken);
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
               return tempCourseList;
           });
        }

        private async void cbxAutoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAutoRefresh.Checked)
            {
                await RefreshQueue();
                btnRefreshQueue.Enabled = false;
                nudSeconds.Enabled = true;
                timerRefreshQueue.Interval = Convert.ToInt32(nudSeconds.Value) * 1000;
                timerRefreshQueue.Start();

            }
            else
            {
                btnRefreshQueue.Enabled = true;
                nudSeconds.Enabled = false;
                timerRefreshQueue.Stop();
            }

        }

        private async void timerRefreshQueue_Tick(object sender, EventArgs e)
        {
            await this.RefreshQueue();
        }


        private void gradingDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gradingDataGrid.CurrentCell != null)
            {
                if (gradingDataGrid.Columns[e.ColumnIndex].HeaderText.Contains("URL"))
                {
                    var url = gradingDataGrid.CurrentCell.EditedFormattedValue.ToString();
                    Process.Start(url);
                }
                else if (gradingDataGrid.Columns[e.ColumnIndex].HeaderText.Contains("Done"))
                {

                    if (Convert.ToBoolean(gradingDataGrid.CurrentCell.Value) == true)
                    {
                        gradingDataGrid.CurrentCell.Value = false;
                    }
                    else
                    {
                        gradingDataGrid.CurrentCell.Value = true;
                    }

                }
            }

        }
    }
}
