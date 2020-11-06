namespace CanvasAPIApp
{
    partial class GradingQueue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gradingDataGrid = new System.Windows.Forms.DataGridView();
            this.btnRefreshQueue = new System.Windows.Forms.Button();
            this.cbxAutoRefresh = new System.Windows.Forms.CheckBox();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.timerRefreshQueue = new System.Windows.Forms.Timer(this.components);
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.marked_done = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignmentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Submit_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Workflow_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speedgrader_url = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gradingDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // gradingDataGrid
            // 
            this.gradingDataGrid.AllowUserToAddRows = false;
            this.gradingDataGrid.AllowUserToDeleteRows = false;
            this.gradingDataGrid.AllowUserToOrderColumns = true;
            this.gradingDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradingDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marked_done,
            this.Priority,
            this.CourseNumber,
            this.AssignmentNameColumn,
            this.Submit_at,
            this.Workflow_state,
            this.Speedgrader_url});
            this.gradingDataGrid.Location = new System.Drawing.Point(12, 97);
            this.gradingDataGrid.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.gradingDataGrid.Name = "gradingDataGrid";
            this.gradingDataGrid.ReadOnly = true;
            this.gradingDataGrid.RowTemplate.Height = 33;
            this.gradingDataGrid.ShowEditingIcon = false;
            this.gradingDataGrid.Size = new System.Drawing.Size(1688, 903);
            this.gradingDataGrid.TabIndex = 0;
            this.gradingDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradingDataGrid_CellContentClick);
            // 
            // btnRefreshQueue
            // 
            this.btnRefreshQueue.Location = new System.Drawing.Point(12, 47);
            this.btnRefreshQueue.Name = "btnRefreshQueue";
            this.btnRefreshQueue.Size = new System.Drawing.Size(305, 44);
            this.btnRefreshQueue.TabIndex = 1;
            this.btnRefreshQueue.Text = "Refresh Grading Queue";
            this.btnRefreshQueue.UseVisualStyleBackColor = true;
            this.btnRefreshQueue.Click += new System.EventHandler(this.btnRefreshQueue_Click);
            // 
            // cbxAutoRefresh
            // 
            this.cbxAutoRefresh.AutoSize = true;
            this.cbxAutoRefresh.Location = new System.Drawing.Point(12, 12);
            this.cbxAutoRefresh.Name = "cbxAutoRefresh";
            this.cbxAutoRefresh.Size = new System.Drawing.Size(169, 29);
            this.cbxAutoRefresh.TabIndex = 2;
            this.cbxAutoRefresh.Text = "Auto Refresh";
            this.cbxAutoRefresh.UseVisualStyleBackColor = true;
            this.cbxAutoRefresh.CheckedChanged += new System.EventHandler(this.cbxAutoRefresh_CheckedChanged);
            // 
            // nudSeconds
            // 
            this.nudSeconds.Enabled = false;
            this.nudSeconds.Location = new System.Drawing.Point(197, 10);
            this.nudSeconds.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudSeconds.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(120, 31);
            this.nudSeconds.TabIndex = 3;
            this.nudSeconds.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // timerRefreshQueue
            // 
            this.timerRefreshQueue.Tick += new System.EventHandler(this.timerRefreshQueue_Tick);
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.AutoSize = true;
            this.lblMessageBox.Location = new System.Drawing.Point(347, 16);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(0, 25);
            this.lblMessageBox.TabIndex = 4;
            // 
            // marked_done
            // 
            this.marked_done.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.marked_done.HeaderText = "Done";
            this.marked_done.Name = "marked_done";
            this.marked_done.ReadOnly = true;
            this.marked_done.Width = 69;
            // 
            // Priority
            // 
            this.Priority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            this.Priority.ToolTipText = "1 = Instructor Meeting\\n2 = Pacific Trails, 3 = Final Projects, 4 = Everything el" +
    "se";
            this.Priority.Width = 124;
            // 
            // CourseNumber
            // 
            this.CourseNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CourseNumber.HeaderText = "Course";
            this.CourseNumber.Name = "CourseNumber";
            this.CourseNumber.ReadOnly = true;
            // 
            // AssignmentNameColumn
            // 
            this.AssignmentNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AssignmentNameColumn.HeaderText = "Assignment";
            this.AssignmentNameColumn.Name = "AssignmentNameColumn";
            this.AssignmentNameColumn.ReadOnly = true;
            this.AssignmentNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Submit_at
            // 
            this.Submit_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Submit_at.HeaderText = "Submited At";
            this.Submit_at.Name = "Submit_at";
            this.Submit_at.ReadOnly = true;
            this.Submit_at.Width = 173;
            // 
            // Workflow_state
            // 
            this.Workflow_state.HeaderText = "State";
            this.Workflow_state.Name = "Workflow_state";
            this.Workflow_state.ReadOnly = true;
            // 
            // Speedgrader_url
            // 
            this.Speedgrader_url.HeaderText = "URL";
            this.Speedgrader_url.Name = "Speedgrader_url";
            this.Speedgrader_url.ReadOnly = true;
            // 
            // GradingQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 1012);
            this.Controls.Add(this.lblMessageBox);
            this.Controls.Add(this.nudSeconds);
            this.Controls.Add(this.cbxAutoRefresh);
            this.Controls.Add(this.btnRefreshQueue);
            this.Controls.Add(this.gradingDataGrid);
            this.Name = "GradingQueue";
            this.Text = "GradingQueue";
            this.Load += new System.EventHandler(this.GradingQueue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradingDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gradingDataGrid;
        private System.Windows.Forms.Button btnRefreshQueue;
        private System.Windows.Forms.CheckBox cbxAutoRefresh;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.Timer timerRefreshQueue;
        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn marked_done;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Submit_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn Workflow_state;
        private System.Windows.Forms.DataGridViewLinkColumn Speedgrader_url;
    }
}