using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanvasAPIApp
{
    public partial class GradingHistoryForm : Form
    {
        // declarations
        List<GradingHistoryEvent> gradingHistoryList;
        public static List<Course> CourseList { get; set; } = new List<Course>();

        Requester requester = new Requester();

        public GradingHistoryForm()
        {
            InitializeComponent();
        }

        private async void GradingHistoryForm_Load(object sender, EventArgs e)
        {
            //set the day and time to the current day by default
            dtpEarliestDate.Value = System.DateTime.Now;
            lblMessageBox.Text = "Getting Courses";
            CourseList = await populateListOfCourses();
            RefreshGradingHistory();
        }

        void LoadGradingHistory()
        {

        }

        private async Task RefreshGradingHistory()
        {
            //reload the data 
            btnGetHistory.Enabled = false;
            lblMessageBox.Text = "Getting Courses";

            //saves sorting for after refresh defalts to priority if nothing is selected
            var sortColumn = gradingDataGrid.SortedColumn != null ? gradingDataGrid.SortedColumn : gradingDataGrid.Columns[1];
            //the data grid view sort method takes a ComponentModel sort direction.
            System.ComponentModel.ListSortDirection sortDirection = new System.ComponentModel.ListSortDirection();
            if (gradingDataGrid.SortOrder == SortOrder.Ascending)
                sortDirection = System.ComponentModel.ListSortDirection.Ascending;
            else if (gradingDataGrid.SortOrder == SortOrder.Descending)
                sortDirection = System.ComponentModel.ListSortDirection.Descending;



            //gets courses if they aren't already set
            if (CourseList.Count == 0)
            {
                CourseList = await populateListOfCourses();
            }


            if (CourseList.Count > 0)
            {
                lblMessageBox.Text = "Getting Assignments";
                gradingHistoryList = await populateGradingHistory(CourseList);
                if (gradingHistoryList.Count == 0)
                {
                    DateTime date = new DateTime();
                    date = DateTime.Now;
                    lblMessageBox.Text = $"Grading Queue is Empty. Last refresh: {date.ToString("t")}";
                    gradingDataGrid.Rows.Clear();
                }
                else
                {
                    lblMessageBox.Text = "Populating List";
                    LoadDataGridView(gradingHistoryList);
                    DateTime date = new DateTime();
                    date = DateTime.Now;
                    lblMessageBox.Text = $"Last refresh: {date.ToString("t")}";
                }
            }
            else
            {
                lblMessageBox.Text = "No Courses";
                gradingDataGrid.Rows.Clear();
            }
            //turn back on the buttons
            btnGetHistory.Enabled = true;
            //set sorting
            //gradingDataGrid.Sort(gradingDataGrid.Columns["Submit_at"], System.ComponentModel.ListSortDirection.Ascending);

        }

        private async Task<List<GradingHistoryEvent>> populateGradingHistory(List<Course> courseList)
        {
            Requester requester = new Requester();
            List<GradingHistoryEvent> gradingHistoryList = new List<GradingHistoryEvent>();

            //getting the offset hours for the graded since parameter for the api call.
            var offset = TimeZoneInfo.Local.GetUtcOffset(DateTime.Now).Hours;
            var intOffsetHours = offset > 0 ? 24 - offset : 0 - offset;
            string strOffsethours = offset < 12 ? "0" + intOffsetHours.ToString() : intOffsetHours.ToString();
            
            string urlParameters;
            urlParameters = "student_ids[]=all";
            urlParameters += "&include[]=assignment";
            urlParameters += "&include[]=submission_comments";            
            urlParameters += $"&graded_since={dtpEarliestDate.Value.ToString("yyyy-MM-dd")}T{strOffsethours}:00:00Z";
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
                    string json = "";
                    try
                    {
                        json = await requester.MakeRequestAsync(endPoint);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show($"{e.Message}\n{e.StackTrace}");
                    }
                    
                    if (json != "")
                    {
                        dynamic jsonObj = JsonConvert.DeserializeObject(json);
                        if (jsonObj.Count > 0)
                        {
                            foreach (var submission in jsonObj)
                            {
                                var temp_submitted_at = Convert.ToString(submission.submitted_at);
                                var str_graded_at = Convert.ToString(submission.graded_at);


                                //There is data that came back without a submission date and crashed the program.
                                //Changing coordinated time to local time
                                if (DateTime.TryParse(temp_submitted_at, out DateTime submitted_at))
                                {
                                    submitted_at = submitted_at.ToLocalTime();
                                }
                                if (DateTime.TryParse(str_graded_at, out DateTime graded_at))
                                {
                                    graded_at = graded_at.ToLocalTime();
                                }

                                //&& (submission.grader_id > 0
                                //var url = Convert.ToString(submission.url);
                                //var submitted_at = Convert.ToDateTime(submission.submitted_at).ToLocalTime();
                                //var submitted_at = Convert.ToString(submission.submitted_at);
                                var assignment = submission.assignment;
                                var workflow_state = Convert.ToString(submission.workflow_state);
                                var assignment_id = Convert.ToString(submission.assignment_id);
                                var user_id = Convert.ToString(submission.user_id);
                                var posted_at = Convert.ToString(submission.posted_at);
                                var preview_url = Convert.ToString(submission.preview_url);
                                var grader_id = Convert.ToString(submission.grader_id);
                                var grader_name = grader_id;//temporary holder                                
                                var assignment_name = Convert.ToString(assignment.name);
                                var speed_grader_url = $"{Properties.Settings.Default.InstructureSite}/courses/{course.CourseID}/gradebook/speed_grader?assignment_id={assignment_id}&student_id={user_id}";
                                var grades_url = $"{Properties.Settings.Default.InstructureSite}/courses/{course.CourseID}/grades/{user_id}";
                                var gradingEvent = new GradingHistoryEvent(course.CourseName
                                    , assignment_name, submitted_at, workflow_state, speed_grader_url
                                    , grades_url, grader_id, grader_name, graded_at);

                                gradingHistoryList.Add(gradingEvent);



                            }
                        }
                    }
                }));//end task

            }//end foreach

            //waits for all tasks
            await Task.WhenAll(tasks.ToArray());



            return gradingHistoryList;

        }
        private async Task<List<Course>> populateListOfCourses()
        {
            return await Task.Run(async () =>
            {
                List<Course> tempCourseList = new List<Course>();

                // get jsonObj file
                string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses?enrollment_type=teacher&per_page=1000&";//Get endpoint
                try
                {
                    var json = await requester.MakeRequestAsync(endPoint);
                    //if request fails a empty string will be returned, resulting in a null object
                    if (json != "")
                    {
                        dynamic jsonObj = JsonConvert.DeserializeObject(json);

                        foreach (var course in jsonObj)
                        {
                            tempCourseList.Add(new Course(Convert.ToString(course.id), Convert.ToString(course.name)));
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"{ex.Message}\n{ex.StackTrace}");
                }
                
             
                return tempCourseList;
            });
        }
        private void LoadDataGridView(List<GradingHistoryEvent> assignmentList)
        {

            gradingDataGrid.Rows.Clear();       
        
            //filter list
            if (cbxShowAutoGraded.Checked == false)
            {
                assignmentList = assignmentList.Where(result => !result.grader_name.Equals("auto graded")).OrderByDescending(grade_time =>grade_time.graded_at).ToList();
                            
            }

            if (assignmentList.Count > 0)
            {
                foreach (GradingHistoryEvent assignment in assignmentList)
                {
                    gradingDataGrid.Rows.Add(assignment.courseName
                        , assignment.assignment_name, assignment.submitted_at, assignment.graded_at
                        , assignment.hours_to_grade.ToString("0.00"), assignment.grader_name
                        , assignment.speed_grader_url, assignment.grades_url);
                }
                //sorting the DataGrid
                gradingDataGrid.Sort(gradingDataGrid.Columns["graded_at"], System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void btnGetHistory_Click(object sender, EventArgs e)
        {
            RefreshGradingHistory();
        }

        private void gradingDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gradingDataGrid.CurrentCell != null)
            {
                if (gradingDataGrid.Columns[e.ColumnIndex].HeaderText.Contains("Course"))
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

        private void cbxShowAutoGraded_CheckedChanged(object sender, EventArgs e)
        {

            RefreshGradingHistory();

        }
    }//end class

    public class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }

        public Course(string newCourseID, string newCourseName)
        {
            CourseID = newCourseID;
            CourseName = newCourseName;
        }
    }

    class GradingHistoryEvent
    {
        public static Dictionary<Int64, string> graders = new Dictionary<Int64, string> { };
        public string courseName { get; set; }
        public string assignment_name { get; set; }
        public DateTime submitted_at { get; set; }
        public string workflow_state { get; set; }
        public string speed_grader_url { get; set; }
        public string grades_url { get; private set; }
        public string grader_name { get; private set; }
        public Int64 grader_id { get; private set; }
        public DateTime graded_at { get; private set; }
        public double hours_to_grade { get; private set; }




        public GradingHistoryEvent(
            string courseName, string assignment_name, DateTime submitted_at, string workflow_state,
            string speed_grader_url, string grades_url, string grader_id, string grader_name, DateTime graded_at
            )
        {
            this.courseName = courseName;
            this.assignment_name = assignment_name;
            this.submitted_at = submitted_at;
            this.workflow_state = workflow_state;
            this.speed_grader_url = speed_grader_url;
            this.grades_url = grades_url;
            this.grader_id = Convert.ToInt64(grader_id);
            this.grader_name = grader_name;
            this.graded_at = graded_at;
            this.hours_to_grade = graded_at.Subtract(submitted_at).TotalHours;
            UpdateGraderNameAsync();


        }

        public async void UpdateGraderNameAsync()
        {

            if (grader_id <= 0)
            {
                grader_name = "auto graded";
            }
            else if (graders.ContainsKey(grader_id))
            {
                this.grader_name = graders[grader_id];
            }
            else
            {
                //Make API Call
                Requester requester = new Requester();
                string endPoint = Properties.Settings.Default.InstructureSite + $"/api/v1/users/{grader_id}?&";
                string json;
                try
                {
                    json = await requester.MakeRequestAsync(endPoint);                    
                }
                catch (Exception e)
                {                    
                    //on failed request saving the grader id as the grader name.
                    json = $"{{\"id\":{grader_id},\"name\":\"{grader_id} - {e.Message}\"}}";
                }
                if (json != "")
                {
                    dynamic jsonObj = JsonConvert.DeserializeObject(json);
                    this.grader_name = Convert.ToString(jsonObj.name);
                    try
                    {
                        graders.Add(grader_id, this.grader_name);
                    }
                    catch (Exception ex)
                    {
                        //do nothing Because of the async I cannot guarantee that the key has already been written.
                        Debug.WriteLine($"{ex.Message} {ex.StackTrace}");
                    }
                }


            }
        }

    }
}
