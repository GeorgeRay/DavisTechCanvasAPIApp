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
    public partial class GradingQueuePriorityForm : Form
    {
        public GradingQueuePriorityForm()
        {
            InitializeComponent();
        }

        private void GradingQueuePriorityForm_Load(object sender, EventArgs e)
        {
            
            txtP1.Text = GradingQueue.prioritySettings.GetPriorityString(1);
            txtP2.Text = GradingQueue.prioritySettings.GetPriorityString(2);
            txtP3.Text = GradingQueue.prioritySettings.GetPriorityString(3);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string p1 = txtP1.Text;
            string p2 = txtP2.Text;
            string p3 = txtP3.Text;

            GradingQueue.prioritySettings.SetPriorityString(p1, 1);
            GradingQueue.prioritySettings.SetPriorityString(p2, 2);
            GradingQueue.prioritySettings.SetPriorityString(p3, 3);

            GradingQueue.prioritySettings.SaveSettings();

            MessageBox.Show("Your priority settings have been updated.");

            this.Close();
            this.Dispose();
        }
    }
}
