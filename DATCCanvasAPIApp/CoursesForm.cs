using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CanvasAPIApp
{
    public partial class CoursesForm : Form
    {
        //Set access token
        string coursesAccessToken = "access_token=" + Properties.Settings.Default.CurrentAccessToken;
        //Give Class access to Get Call
        GeneralAPIGets getProfile = new GeneralAPIGets();

        Requester requester = new Requester();

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
            foreach (DataGridViewRow row in courseDataGridView.Rows)
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

        public async void loadCourseLists()
        {
            addToCourse.Enabled = false;
            coursesAccessToken = Properties.Settings.Default.CurrentAccessToken;
            CanvasAPIMainForm.GlobalCourseID = 1;

            //async webcalls vars
            List<Tuple<string, string, string>> studentList = new List<Tuple<string, string, string>>();
            List<Task> tasks = new List<Task>();

            //Setting wait cursor
            Cursor.Current = Cursors.WaitCursor;

            //Make Call to get user name
            if (Properties.Settings.Default.CurrentAccessToken != "No Access Token" && Properties.Settings.Default.CurrentAccessToken != "")
            {
                string profileObject = "name";
                string userName = await getProfile.GetProfile(profileObject);

                //Print message
                labelLoggedIn.Text = "Showing courses for " + userName;
            }
            else
            {
                labelLoggedIn.Text = "Not logged in";
            }

            //clear all datagridviews
            courseStudentsGrid.Columns.Clear();
            allStudentsGrid.Columns.Clear();
            courseDataGridView.Columns.Clear();

            // get jsonObj file
            string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses?per_page=1000&include[]=total_students&";//Get endpoint

            var json = await requester.MakeRequestAsync(endPoint);
            dynamic jsonObj = JsonConvert.DeserializeObject(json);

            //create columns and set width
            courseDataGridView.Columns.Add("courseName", "Course Name");
            courseDataGridView.Columns.Add("courseID", "Course ID");
            courseDataGridView.Columns.Add("courseState", "Workflow State");
            courseDataGridView.Columns.Add("courseStudents", "Student Count");
            courseDataGridView.Columns.Add("courseRoles", "Roles");
            courseDataGridView.Columns[0].Width = 290;
            courseDataGridView.Columns[2].Width = 90;
            courseDataGridView.Columns[3].Width = 50;

            //create student grid columns
            allStudentsGrid.Columns.Add("studentName", "Name");
            allStudentsGrid.Columns.Add("studentID", "ID");
            allStudentsGrid.Columns.Add("user_ID", "user_ID");
            allStudentsGrid.Columns["user_ID"].Visible = false; //We don't need to show the user ID but will use it to work with students, one example being POST.

            string studentsAdded = "";

            //async gets students in each course
            foreach (var course in jsonObj)
            {
                //get and format course roles
                string rolesString = "";
                foreach (dynamic v in course.enrollments)
                {
                    rolesString += v.type + ", ";
                }
                rolesString = rolesString.Trim().Trim(',');

                //populate course list
                courseDataGridView.Rows.Add(String.Format(Convert.ToString(course.name)), (Convert.ToString(course.id)), (Convert.ToString(course.workflow_state)), Convert.ToInt32(course.total_students), Convert.ToString(rolesString));

                //set up each call in a task list
                tasks.Add(Task.Run(async () =>
                {
                    endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + course.id + "/users?per_page=1000&"; //Get endpoint

                    json = await requester.MakeRequestAsync(endPoint);
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
                                studentList.Add(new Tuple<string, string, string>(Convert.ToString(student.name), Convert.ToString(student.sis_user_id), Convert.ToString(student.id)));

                                //allStudentsGrid.Rows.Add(String.Format(Convert.ToString(student.name)), (Convert.ToString(student.sis_user_id)));

                                //add to list
                                studentsAdded += Convert.ToString(student.sis_user_id);
                            }
                        }
                    }//end for
                }));//end task
            }

            //lets tasks complete
            await Task.WhenAll(tasks.ToArray());

            //when tasks are complete, fill out UI
            for (int i = 0; i < studentList.Count; i++)
            {
                allStudentsGrid.Rows.Add(studentList[i].Item1, studentList[i].Item2, studentList[i].Item3);
            }

            //clear selections and sort columns
            allStudentsGrid.Sort(allStudentsGrid.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            allStudentsGrid.ClearSelection();
            courseStudentsGrid.ClearSelection();
            removeFromCourse.Enabled = false;
            courseDataGridView.Sort(courseDataGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            courseDataGridView.ClearSelection();
        }

        private async void populateCourseStudents()
        {
            //Clear columns
            courseStudentsGrid.Columns.Clear();
            try
            {
                //Get list of students for course selected:
                string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + CanvasAPIMainForm.GlobalCourseID + "/enrollments?per_page=1000&";//Get endpoint

                string json = await requester.MakeRequestAsync(endPoint);
                dynamic jsonObj = JsonConvert.DeserializeObject(json);
                courseStudentsGrid.Columns.Add("studentName", "Name");
                courseStudentsGrid.Columns.Add("studentID", "ID");
                var lastActivityIndex = courseStudentsGrid.Columns.Add("last_activity_at", "Last Activity");
                courseStudentsGrid.Columns[lastActivityIndex].ValueType = typeof(DateTime);
                courseStudentsGrid.Columns[lastActivityIndex].DefaultCellStyle.Format = "d";
                courseStudentsGrid.Columns.Add("EnrollmentID", "EnrollmentID");
                courseStudentsGrid.Columns["EnrollmentID"].Visible = false; //We don't need to show the canvas ID but will use it to work with students.


                foreach (var student in jsonObj)
                {
                    String enrollemntTypeString = Convert.ToString(student.type);
                    enrollemntTypeString = enrollemntTypeString.Substring(0, enrollemntTypeString.Length - 10);
                    var displayName = $"{Convert.ToString(student.user.name)} ({enrollemntTypeString})";
                    var displayDate = Convert.ToDateTime(student.last_activity_at == null ? "1/1/1900" : student.last_activity_at);
                    courseStudentsGrid.Rows.Add(displayName, (Convert.ToString(student.user.sis_user_id)), displayDate, Convert.ToString(student.id));
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
            // loadCourseLists();
        }

        private void enrolledStudentsSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in courseStudentsGrid.Rows)
                {
                    //mash name, ID and state together to search via substring
                    string search = row.Cells["studentName"].Value.ToString();

                    if (row.Cells["studentID"].Value != null)
                        search += row.Cells["studentID"].Value.ToString();

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
            catch (Exception exc)
            {
                MessageBox.Show("Error - " + exc.Message);
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

        private async void removeFromCourse_Click(object sender, EventArgs e)
        {

            //get course name from list
            string courseName = (courseDataGridView.Rows[courseDataGridView.CurrentCell.RowIndex].Cells["courseName"].Value.ToString());
            //Get selected student
            string studentName = courseStudentsGrid.Rows[courseStudentsGrid.CurrentCell.RowIndex].Cells["studentName"].Value.ToString();
            string studentID = courseStudentsGrid.Rows[courseStudentsGrid.CurrentCell.RowIndex].Cells["studentID"].Value.ToString();
            string enrollmentID = courseStudentsGrid.Rows[courseStudentsGrid.CurrentCell.RowIndex].Cells["enrollmentID"].Value.ToString();

            //verify that selected student is to be removed
            DialogResult removeStudent = MessageBox.Show($"Are you sure you want to conclude {courseName} for {studentName}?", "Remove Student", MessageBoxButtons.YesNo);
            if (removeStudent == DialogResult.Yes)
            {
                string restResult = "No Call Made";//this will be over written by results from web call
                var tokenParameter = coursesAccessToken;//Create
                string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + CanvasAPIMainForm.GlobalCourseID + "/enrollments/" + enrollmentID + "?";
                try
                {
                    //Make api call
                    restResult = await requester.MakeDeleteRequestAsync(endPoint);

                    MessageBox.Show(courseName + " has been concluded for " + studentName);
                    populateCourseStudents();
                }
                catch (Exception apiException)
                {
                    MessageBox.Show("Error during API call.\n" + apiException.Message);
                }

            }

        }

        private async void addToCourse_Click(object sender, EventArgs e)
        {
            try
            {
                //get course name from list
                string courseName = (courseDataGridView.Rows[courseDataGridView.CurrentCell.RowIndex].Cells["courseName"].Value.ToString());
                string studentName = allStudentsGrid.Rows[allStudentsGrid.CurrentCell.RowIndex].Cells["studentName"].Value.ToString();
                //verify that selected student is to be added
                DialogResult addStudent = MessageBox.Show("Are you sure you want to invite " + studentName + " to " + courseName + "?", "Add Student", MessageBoxButtons.YesNo);
                if (addStudent == DialogResult.Yes)
                {
                    string restResult = "No Call Made";//this will be over written by results from web call
                    var tokenParameter = coursesAccessToken;//Create 

                    //get student ID from list
                    Int64 studentID = Int64.Parse(allStudentsGrid.Rows[allStudentsGrid.CurrentCell.RowIndex].Cells["studentID"].Value.ToString());
                    string endPoint = Properties.Settings.Default.InstructureSite + "/api/v1/courses/" + CanvasAPIMainForm.GlobalCourseID + "/enrollments?";//Get base endpoint from setting
                    var userId = allStudentsGrid.Rows[allStudentsGrid.CurrentCell.RowIndex].Cells["user_ID"].Value.ToString();
                    var jasonObject = $"{{\"enrollment\": {{\"user_id\": \"{userId}\"}}}}";


                    //Make api call
                    try
                    {
                        //add student and repopulate list
                        restResult = await requester.MakePOSTRequestAsync(endPoint, jasonObject);
                        MessageBox.Show(studentName + " has been invited to " + courseName);
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
