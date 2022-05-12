using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanvasAPIApp
{
    public partial class GroupEnrollmentForm : Form
    {
        IList<CourseGroup> groupList { get; set; }
        string studentName { get; set; }
        string courseName { get; set; }
        string userId { get; set; }

        public GroupEnrollmentForm(IList<CourseGroup> groupList, string studentName, string courseName, string userId)
        {
            this.groupList = groupList;
            this.studentName = studentName;
            this.courseName = courseName;
            this.userId = userId;

            InitializeComponent();
            CenterToParent();
            lblMessage.Text = $"{studentName} has been invited to {courseName}.\n\n" +
                $"What groups would you like to add the student to:";

            CheckBox box;
            int boxVertPos = 0;
            foreach (CourseGroup group in groupList)
            {
                box = new CheckBox();
                box.Tag = group.id;
                box.Text = $"{group.name} ({group.members_count} students)";
                box.AutoSize = true;
                box.Location = new Point(5, boxVertPos * 18);
                gbListofGroups.Controls.Add(box);
                boxVertPos++;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;

        }

        private async void btnAdd_ClickAsync(object sender, EventArgs e)
        {
            Requester requester = new Requester();
            //Get the list of group id's
            string restResult = "No Call Made";//this will be over written by results from web call
            string jsonObject = $"{{\"user_id\": \"{userId}\"}}";
            try
            {
                foreach (CheckBox checkBox in gbListofGroups.Controls)
                {
                    if (checkBox.Checked)
                    {
                        string groupEndPoint = Properties.Settings.Default.InstructureSite + "/api/v1/groups/" + checkBox.Tag + "/memberships?";
                        restResult = await requester.MakePOSTRequestAsync(groupEndPoint, jsonObject);
                    }
                }
            }
            catch (Exception apiException)
            {
                MessageBox.Show("Error during API call.\n" + apiException.Message);
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
