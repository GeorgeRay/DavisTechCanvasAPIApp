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
            

            menuItemDefaultPriority.Text = Properties.Settings.Default.DefaultPriority.ToString();

            List<KeyValuePair<int, string>> flags = GradingQueue.prioritySettings.priorityFlags;


            
            //fills data grid with each priority
            foreach (KeyValuePair<int, string> flag in flags)
            {
                DataGridViewRow row = new DataGridViewRow();
                dgvPriority.Rows.Add(new object[] {flag.Value, flag.Key.ToString() });
            }

        }

        //cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        //accept button
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                List<KeyValuePair<int, string>> flags = new List<KeyValuePair<int, string>>();

                for (int i = 0; i < dgvPriority.Rows.Count - 1; i++)
                {

                    DataGridViewRow row = dgvPriority.Rows[i];

                    if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[0].Value.ToString() == "" || row.Cells[1].Value.ToString() == "")
                    {
                        
                        throw new Exception("Values and priorites must be set.");
                    }
                    
                    KeyValuePair<int, string> flag = new KeyValuePair<int, string>(int.Parse(row.Cells[1].Value.ToString()), row.Cells[0].Value.ToString());

                    flags.Add(flag);
                }

                GradingQueue.prioritySettings.priorityFlags = flags;

                GradingQueue.prioritySettings.SaveSettings();
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Error - {exc.Message}");
            }
            finally
            {
                this.Close();
                this.Dispose();
            }
        }

        //delete button
        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvPriority.Rows)
            {

                if ((row.Selected || row.Cells[0].Selected) && row.Index < dgvPriority.Rows.Count - 1)
                    dgvPriority.Rows.Remove(row);
            }
        }

        //on cell click
        private void dgvPriority_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //makes combobox cells more responsive
            DataGridViewComboBoxEditingControl control = dgvPriority.EditingControl as DataGridViewComboBoxEditingControl;
            if (control != null)
                control.DroppedDown = true;
        }

        

        private void menuItemDefaultPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            GradingQueue.defaultPriority = int.Parse( menuItemDefaultPriority.Text.ToString());

            Properties.Settings.Default.DefaultPriority = GradingQueue.defaultPriority;

        }

        //on new row
        private void dgvPriority_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //helps set default on the added row
            dgvPriority.Rows[dgvPriority.Rows.Count - 1].Cells[1].Value = GradingQueue.defaultPriority.ToString();
        }
    }
}
