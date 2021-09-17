using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            
            
            nmbPriority.Value = Properties.Settings.Default.DefaultPriority;

            List<PriorityFlag> flags = JsonConvert.DeserializeObject<List <PriorityFlag>>(Properties.Settings.Default.PriorityFlags);
            
            //fills data grid with each priority
            foreach (PriorityFlag flag in flags)
            {               
                DataGridViewRow row = new DataGridViewRow();
                dgvPriority.Rows.Add(new object[] { flag.PriorityText, flag.PriorityLevel.ToString(), flag.Alert });
            }
        }//end on load

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
                List<PriorityFlag> flags = new List<PriorityFlag>();

                for (int i = 0; i < dgvPriority.Rows.Count - 1; i++)
                {                    
                    DataGridViewRow row = dgvPriority.Rows[i];

                    if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[0].Value.ToString() == "" || row.Cells[1].Value.ToString() == "")
                    {
                        
                        throw new Exception("Values and priorites must be set.");
                    }
                    PriorityFlag flag = new PriorityFlag(int.Parse(row.Cells[1].Value.ToString()), row.Cells[0].Value.ToString(), Convert.ToBoolean(row.Cells[2].Value));
                    
                    flags.Add(flag);
                }

                Properties.Settings.Default.PriorityFlags = JsonConvert.SerializeObject(flags);
                Properties.Settings.Default.Save();
                //Update flags default priority on the grading queue form.
                GradingQueue.priorityFlags = flags;
                GradingQueue.defaultPriority = (int)nmbPriority.Value;
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
        }//end accept button

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
        
       
        //on new row
        private void dgvPriority_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //helps set default on the added row
            dgvPriority.Rows[dgvPriority.Rows.Count - 1].Cells[1].Value = GradingQueue.defaultPriority.ToString();
        }

        private void nmbPriority_ValueChanged(object sender, EventArgs e)
        {
            GradingQueue.defaultPriority = (int)nmbPriority.Value;

            Properties.Settings.Default.DefaultPriority = GradingQueue.defaultPriority;
            Properties.Settings.Default.Save();
        }

    }

    public class PriorityFlag
    {
   
        public int PriorityLevel { get; set; }
        public string PriorityText { get; set ; } 
        public bool Alert { get; set; }

        public PriorityFlag(int newPriorityLevel, string newValue, bool newAlert = false)
        {
            if (newPriorityLevel != 0)
            {
                PriorityLevel = newPriorityLevel;
            }
            else
            {
                PriorityLevel = Properties.Settings.Default.DefaultPriority;
            }
            PriorityLevel = newPriorityLevel;
            if (newValue is null)
            {
                PriorityText = "Failed to load";
            }
            else
            {
                PriorityText = newValue;
            }          
            Alert = newAlert;
        }

    }
}
