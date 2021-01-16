using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CanvasAPIApp
{
    public partial class CoursesForm : Form
    {
        //Set access token
        string coursesAccessToken = "access_token=" + Properties.Settings.Default.CurrentAccessToken;
        //Give Class access to Get Call
        GeneralAPIGets getProfile = new GeneralAPIGets();

        public CoursesForm()
        {
            InitializeComponent();
        }

        //on row click, change the global course ID to the selected row
        private void courseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = courseDataGridView.CurrentCell.RowIndex;

            DataGridViewRow selectedRow = courseDataGridView.Rows[rowIndex];

            CanvasAPIMainForm.GlobalCourseID = Convert.ToInt32(selectedRow.Cells["courseID"].Value);

            selectedCourse.Text = ("Selected course " + CanvasAPIMainForm.GlobalCourseID);

            populateCourseStudents();
            addToCourse.Enabled = false;
            allStudentsGrid.ClearSelection();
        }

        // search box on text change
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in courseDataGridView.Rows)
            {
                // search by name or ID

                //mash name, ID and state together to search via substring
                string search = row.Cells["courseName"].Value.ToString() + row.Cells["courseID"].Value.ToString() + row.Cells["courseState"].Value.ToString();

                if (!search.ToLower().Contains(searchBox.Text.ToLower()))
                {
                    row.Visible = false;
                }
                else if ((search.ToLower().Contains(searchBox.Text.ToLower())))
                {
                    row.Visible = true;
                }
            }
        }
        public void loadCourseLists()
        {
            addToCourse.Enabled = false;
            coursesAccessToken = "access_token=" + Properties.Settings.Default.CurrentAccessToken;
            CanvasAPIMainForm.GlobalCourseID = 1;
            try
            {  
                    //Setting wait cursor
                    Cursor.Current = Cursors.WaitCursor;

                    //Make Call to get user name
                    if (Properties.Settings.Default.CurrentAccessToken != "No Access Token" && Properties.Settings.Default.CurrentAccessToken != "")
                    {
                        string profileObject = "name";
                        string userName = getProfile.GetProfile(profileObject);

                        //Print message
                        labelLoggedIn.Text = "Showing courses for " + userName;
                    }
                    else
                    {
                        labelLoggedIn.Text = "Not logged in";
                    }
                    //Get list of courses
                    try
                    {
                        //clear all datagridviews
                        courseStudentsGrid.Columns.Clear();
                        allStudentsGrid.Columns.Clear();
                        courseDataGridView.Columns.Clear();

                        // get jsonObj file
                        string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses?per_page=1000&";//Get endpoint
                        var client = new RestClient(endPoint);
                        var json = client.MakeRequest(coursesAccessToken);
                        dynamic jsonObj = JsonConvert.DeserializeObject(json);

                        //create columns and set width
                        courseDataGridView.Columns.Add("courseName", "Course Name");
                        courseDataGridView.Columns.Add("courseID", "Course ID");
                        courseDataGridView.Columns.Add("courseState", "Workflow State");
                        courseDataGridView.Columns.Add("courseStudents", "Student Count");
                        courseDataGridView.Columns[0].Width = 350;
                        courseDataGridView.Columns[2].Width = 130;
                        courseDataGridView.Columns[3].Width = 100;

                        //create student grid columns
                        allStudentsGrid.Columns.Add("studentName", "Name");
                        allStudentsGrid.Columns.Add("studentID", "ID");

                        string studentsAdded = "";

                        foreach (var course in jsonObj)
                        {
                            //populate course list
                            courseDataGridView.Rows.Add(String.Format(Convert.ToString(course.name)), (Convert.ToString(course.id)), (Convert.ToString(course.workflow_state)), (Convert.ToString(course.total_students)));

                            //Get list of students from each course
                            try
                            {
                                {
                                    endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + course.id + "/users?per_page=1000&"; //Get endpoint
                                    client = new RestClient(endPoint);
                                    json = client.MakeRequest(coursesAccessToken);
                                    jsonObj = JsonConvert.DeserializeObject(json);

                                    //list to add student id's to after they have been added to the all students list
                                    string currentCourseID = Convert.ToString(course.id);

                                    foreach (var student in jsonObj)
                                    {
                                        if (student.sis_user_id != null && student.name != null)
                                        {
                                            //add student if the id is not found in students added
                                            if (!studentsAdded.Contains(Convert.ToString(student.sis_user_id)))
                                            {
                                                allStudentsGrid.Rows.Add(String.Format(Convert.ToString(student.name)), (Convert.ToString(student.sis_user_id)));
                                                //add to list
                                                studentsAdded += Convert.ToString(student.sis_user_id);
                                            }
                                        }
                                    }
                                }
                            } //end try
                            catch (Exception populateCourseStudentsException)
                            {
                                MessageBox.Show("An error has occurred populating course students. " + populateCourseStudentsException.Message + "\n");
                            }
                        }
                    } //end try
                    catch (Exception populateCoursesException)
                    {
                        MessageBox.Show(populateCoursesException.Message + "\n");
                    }
                    //clear selections and sort columns
                    allStudentsGrid.Sort(allStudentsGrid.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
                    allStudentsGrid.ClearSelection();
                    courseStudentsGrid.ClearSelection();
                    removeFromCourse.Enabled = false;
                    courseDataGridView.Sort(courseDataGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
                    courseDataGridView.ClearSelection();
                
            } //end try
            catch (Exception apiException)
            {
                MessageBox.Show("Token not authorized.  Input valid token.\n" + apiException.Message, "Authentication error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void populateCourseStudents()
        {
            //Clear columns
            courseStudentsGrid.Columns.Clear();

            //local function to determine current user's role in a specific course
            bool amITeacher(string courseId)
            {
                string roleEndPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + courseId + "/?";//Get endpoint for role
                var roleClient = new RestClient(roleEndPoint);
                Console.Out.WriteLine(roleEndPoint);
                var roleJson = roleClient.MakeRequest(coursesAccessToken);
                dynamic roleJsonObj = JsonConvert.DeserializeObject(roleJson);

                foreach (var v in roleJsonObj.enrollments)
                {
                    if (v.type == "teacher")
                        return true;
                }

                //else return false
                return false;
            }

            //Get list of students for course selected
            try
            {
                //sets role
                bool isTeacher = amITeacher(CanvasAPIMainForm.GlobalCourseID.ToString());
                if (isTeacher)
                    courseRole.Text = "Role: Teacher";
                else
                    courseRole.Text = "Role: Student";
                //




                string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + CanvasAPIMainForm.GlobalCourseID + "/users?per_page=1000&";//Get endpoint
                var client = new RestClient(endPoint);
                var json = client.MakeRequest(coursesAccessToken);
                dynamic jsonObj = JsonConvert.DeserializeObject(json);
                courseStudentsGrid.Columns.Add("studentName", "Name");
                courseStudentsGrid.Columns.Add("studentID", "ID");

                foreach (var student in jsonObj)
                {
                    courseStudentsGrid.Rows.Add(String.Format(Convert.ToString(student.name)), (Convert.ToString(student.sis_user_id)));
                }
                courseStudentsGrid.Sort(courseStudentsGrid.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            } //end try
            catch (Exception populateCourseStudentsException)
            {
                MessageBox.Show("Error populating students.\n" + populateCourseStudentsException.Message + "\n");
            }
            courseStudentsGrid.ClearSelection();
            removeFromCourse.Enabled = false;
        }

        private void CoursesForm_Load(object sender, EventArgs e)
        {
            //loadCourseLists();
        }

        private void enrolledStudentsSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in courseStudentsGrid.Rows)
            {
                //mash name, ID and state together to search via substring
                string search = row.Cells["studentName"].Value.ToString() + row.Cells["studentID"].Value.ToString();

                if (!search.ToLower().Contains(enrolledStudentsSearch.Text.ToLower()))
                {
                    row.Visible = false;
                }
                else if ((search.ToLower().Contains(enrolledStudentsSearch.Text.ToLower())))
                {
                    row.Visible = true;
                }
            }
        }

        private void accountStudentsSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in allStudentsGrid.Rows)
            {
                // search by name or ID

                //mash name, ID and state together to search via substring
                string search = row.Cells["studentName"].Value.ToString() + row.Cells["studentID"].Value.ToString();

                if (!search.ToLower().Contains(accountStudentsSearch.Text.ToLower()))
                {
                    row.Visible = false;
                }
                else if ((search.ToLower().Contains(accountStudentsSearch.Text.ToLower())))
                {
                    row.Visible = true;
                }
            }
        }

        private void removeFromCourse_Click(object sender, EventArgs e)
        {
            try
            {

                //get course name from list
                string courseName = (courseDataGridView.Rows[courseDataGridView.CurrentCell.RowIndex].Cells["courseName"].Value.ToString());
                //verify that selected student is to be removed
                DialogResult removeStudent = MessageBox.Show("Are you sure you want to conclude " + courseName + " for this student?", "Remove Student", MessageBoxButtons.YesNo);
                if (removeStudent == DialogResult.Yes)
                {
                    string restResult = "No Call Made";//this will be over written by results from web call
                    var tokenParameter = coursesAccessToken;//Create

                    //get student id from list
                    Int64 studentID = Int64.Parse(allStudentsGrid.Rows[allStudentsGrid.CurrentCell.RowIndex].Cells["studentID"].Value.ToString());
                    MessageBox.Show(studentID.ToString());
                    string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + CanvasAPIMainForm.GlobalCourseID + "/enrollments?";
                    var client = new RestClient(endPoint);
                    var json = client.MakeRequest(tokenParameter + "&sis_user_id=" + studentID);
                    dynamic jsonObj = JsonConvert.DeserializeObject(json);


                    //int objCount = 0;

                    //check for duplicates
                    foreach (var obj in jsonObj)
                    {
                        if (obj.type != "TeacherEnrollment")
                        {
                            int enrollmentID = obj.id;

                            endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + CanvasAPIMainForm.GlobalCourseID + "/enrollments/" + enrollmentID + "?";//Get base endpoint from setting
                            client = new RestClient(endPoint);
                            client.Method = HttpVerb.DELETE;//setting call to delete
                            string task = "&task=conclude";


                            //Make api call
                            try
                            {
                                restResult = client.MakeRequest(coursesAccessToken + task);
                                MessageBox.Show(courseName + " has been concluded for " + (courseStudentsGrid.Rows[courseStudentsGrid.CurrentCell.RowIndex].Cells["studentName"].Value.ToString()));
                                populateCourseStudents();
                            }
                            catch (Exception apiException)
                            {
                                MessageBox.Show("Error during API call.\n" + apiException.Message);
                            }
                        }
                        else
                            MessageBox.Show(Convert.ToString(obj.sis_user_id) + " could not conclude the course.\nYou must conclude teachers from datc.canvas.com");
                    }
                }
            } //end try
            catch (Exception apiException)
            {
                MessageBox.Show("Error removing student.\n\n" + apiException.Message, "Authentication error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    private void addToCourse_Click(object sender, EventArgs e)
        {
            try
            {
                //get course name from list
                string courseName = (courseDataGridView.Rows[courseDataGridView.CurrentCell.RowIndex].Cells["courseName"].Value.ToString());
                //verify that selected student is to be added
                DialogResult addStudent = MessageBox.Show("Are you sure you want to invite this student to " + courseName + "?", "Add Student", MessageBoxButtons.YesNo);
                if (addStudent == DialogResult.Yes)
                {
                    string restResult = "No Call Made";//this will be over written by results from web call
                    var tokenParameter = coursesAccessToken;//Create 

                    //get student ID from list
                    Int64 studentID = Int64.Parse(allStudentsGrid.Rows[allStudentsGrid.CurrentCell.RowIndex].Cells["studentID"].Value.ToString());

                    string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + CanvasAPIMainForm.GlobalCourseID + "/enrollments?";//Get base endpoint from setting
                    var client = new RestClient(endPoint);
                    client.Method = HttpVerb.POST;//setting call to post
                    string parameters = "&enrollment[sis_user_id]=" + studentID + "&enrollment[type]=StudentEnrollment" + "&enrollment[enrollment_state] = active";

                    //Make api call
                    try
                    {
                        //add student and repopulate list
                        restResult = client.MakeRequest(tokenParameter + parameters);
                        MessageBox.Show((courseStudentsGrid.Rows[courseStudentsGrid.CurrentCell.RowIndex].Cells["studentName"].Value.ToString()) + " has been invited to " + courseName);
                        populateCourseStudents();
                    }
                    catch (Exception apiException)
                    {
                        MessageBox.Show("Error during API call.\n" + apiException.Message);
                    }
                }
            } //end try
            catch (Exception apiException)
            {
                MessageBox.Show("Error adding student to course.\n" + apiException.Message, "Authentication error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //when the courseStudentGrid is selected disable adding and clear the allStudentsGrid selection
        private void courseStudentsGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            allStudentsGrid.ClearSelection();
            removeFromCourse.Enabled = true;
            addToCourse.Enabled = false;
        }
        //visa versa
        private void accountStudentsGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            courseStudentsGrid.ClearSelection();
            removeFromCourse.Enabled = false;
            addToCourse.Enabled = true;
        }

        private void btnLoadCourses_Click(object sender, EventArgs e)
        { 
            loadCourseLists();           
        }
    }
}
