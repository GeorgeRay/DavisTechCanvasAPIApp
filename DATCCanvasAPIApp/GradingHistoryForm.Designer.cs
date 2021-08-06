namespace CanvasAPIApp
{
    partial class GradingHistoryForm
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
            this.gradingDataGrid = new System.Windows.Forms.DataGridView();
            this.CourseNumber = new System.Windows.Forms.DataGridViewLinkColumn();
            this.AssignmentNameColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Submit_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graded_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours_to_grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graded_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speedgrader_url = new System.Windows.Forms.DataGridViewLinkColumn();
            this.grades_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpEarliestDate = new System.Windows.Forms.DateTimePicker();
            this.btnGetHistory = new System.Windows.Forms.Button();
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.cbxShowAutoGraded = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gradingDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.CourseNumber,
            this.AssignmentNameColumn,
            this.Submit_at,
            this.graded_at,
            this.hours_to_grade,
            this.graded_by,
            this.Speedgrader_url,
            this.grades_url});
            this.gradingDataGrid.Location = new System.Drawing.Point(2, 98);
            this.gradingDataGrid.Margin = new System.Windows.Forms.Padding(4, 31, 4, 4);
            this.gradingDataGrid.Name = "gradingDataGrid";
            this.gradingDataGrid.ReadOnly = true;
            this.gradingDataGrid.RowTemplate.Height = 33;
            this.gradingDataGrid.ShowEditingIcon = false;
            this.gradingDataGrid.Size = new System.Drawing.Size(1409, 777);
            this.gradingDataGrid.TabIndex = 1;
            this.gradingDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradingDataGrid_CellContentClick);
            // 
            // CourseNumber
            // 
            this.CourseNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CourseNumber.HeaderText = "Course";
            this.CourseNumber.Name = "CourseNumber";
            this.CourseNumber.ReadOnly = true;
            this.CourseNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CourseNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CourseNumber.ToolTipText = "Links to students grades in course.";
            // 
            // AssignmentNameColumn
            // 
            this.AssignmentNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AssignmentNameColumn.HeaderText = "Assignment";
            this.AssignmentNameColumn.Name = "AssignmentNameColumn";
            this.AssignmentNameColumn.ReadOnly = true;
            this.AssignmentNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AssignmentNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Submit_at
            // 
            this.Submit_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Submit_at.HeaderText = "Submitted At";
            this.Submit_at.Name = "Submit_at";
            this.Submit_at.ReadOnly = true;
            this.Submit_at.Width = 165;
            // 
            // graded_at
            // 
            this.graded_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.graded_at.HeaderText = "Graded At";
            this.graded_at.Name = "graded_at";
            this.graded_at.ReadOnly = true;
            this.graded_at.Width = 143;
            // 
            // hours_to_grade
            // 
            this.hours_to_grade.HeaderText = "Hours to Grade";
            this.hours_to_grade.Name = "hours_to_grade";
            this.hours_to_grade.ReadOnly = true;
            // 
            // graded_by
            // 
            this.graded_by.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.graded_by.HeaderText = "Grader";
            this.graded_by.Name = "graded_by";
            this.graded_by.ReadOnly = true;
            // 
            // Speedgrader_url
            // 
            this.Speedgrader_url.HeaderText = "URL";
            this.Speedgrader_url.Name = "Speedgrader_url";
            this.Speedgrader_url.ReadOnly = true;
            this.Speedgrader_url.Visible = false;
            this.Speedgrader_url.Width = 245;
            // 
            // grades_url
            // 
            this.grades_url.HeaderText = "Grades URL";
            this.grades_url.Name = "grades_url";
            this.grades_url.ReadOnly = true;
            this.grades_url.Visible = false;
            // 
            // dtpEarliestDate
            // 
            this.dtpEarliestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEarliestDate.Location = new System.Drawing.Point(24, 23);
            this.dtpEarliestDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpEarliestDate.Name = "dtpEarliestDate";
            this.dtpEarliestDate.Size = new System.Drawing.Size(180, 31);
            this.dtpEarliestDate.TabIndex = 2;
            this.dtpEarliestDate.Value = new System.DateTime(2021, 7, 13, 0, 0, 0, 0);
            // 
            // btnGetHistory
            // 
            this.btnGetHistory.Location = new System.Drawing.Point(246, 23);
            this.btnGetHistory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGetHistory.Name = "btnGetHistory";
            this.btnGetHistory.Size = new System.Drawing.Size(208, 44);
            this.btnGetHistory.TabIndex = 3;
            this.btnGetHistory.Text = "Refresh History";
            this.btnGetHistory.UseVisualStyleBackColor = true;
            this.btnGetHistory.Click += new System.EventHandler(this.btnGetHistory_Click);
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.AutoSize = true;
            this.lblMessageBox.Location = new System.Drawing.Point(508, 42);
            this.lblMessageBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(266, 25);
            this.lblMessageBox.TabIndex = 4;
            this.lblMessageBox.Text = "Lable for output messages";
            // 
            // cbxShowAutoGraded
            // 
            this.cbxShowAutoGraded.AutoSize = true;
            this.cbxShowAutoGraded.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxShowAutoGraded.Location = new System.Drawing.Point(26, 19);
            this.cbxShowAutoGraded.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxShowAutoGraded.Name = "cbxShowAutoGraded";
            this.cbxShowAutoGraded.Size = new System.Drawing.Size(216, 29);
            this.cbxShowAutoGraded.TabIndex = 6;
            this.cbxShowAutoGraded.Text = "show auto-graded";
            this.cbxShowAutoGraded.UseVisualStyleBackColor = true;
            this.cbxShowAutoGraded.CheckedChanged += new System.EventHandler(this.cbxShowAutoGraded_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbxShowAutoGraded);
            this.panel1.Location = new System.Drawing.Point(1156, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 61);
            this.panel1.TabIndex = 7;
            // 
            // GradingHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 865);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMessageBox);
            this.Controls.Add(this.btnGetHistory);
            this.Controls.Add(this.dtpEarliestDate);
            this.Controls.Add(this.gradingDataGrid);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "GradingHistoryForm";
            this.Text = "GradingHistoryForm";
            this.Load += new System.EventHandler(this.GradingHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradingDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gradingDataGrid;
        private System.Windows.Forms.DateTimePicker dtpEarliestDate;
        private System.Windows.Forms.Button btnGetHistory;
        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.CheckBox cbxShowAutoGraded;
        private System.Windows.Forms.DataGridViewLinkColumn CourseNumber;
        private System.Windows.Forms.DataGridViewLinkColumn AssignmentNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Submit_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn graded_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours_to_grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn graded_by;
        private System.Windows.Forms.DataGridViewLinkColumn Speedgrader_url;
        private System.Windows.Forms.DataGridViewTextBoxColumn grades_url;
        private System.Windows.Forms.Panel panel1;
    }
}