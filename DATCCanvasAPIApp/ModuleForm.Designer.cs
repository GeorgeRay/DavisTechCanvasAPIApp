namespace CanvasAPIApp
{
    partial class ModuleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleForm));
            this.btnLoadCourse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nudNumberOfModule = new System.Windows.Forms.NumericUpDown();
            this.nudCourseID = new System.Windows.Forms.NumericUpDown();
            this.xbxUseBase = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbBaseName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbModuleName = new System.Windows.Forms.TextBox();
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnSubmitModule = new System.Windows.Forms.Button();
            this.seqProgress = new System.Windows.Forms.CheckBox();
            this.unlockOnDate = new System.Windows.Forms.CheckBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.setModulePos = new System.Windows.Forms.CheckBox();
            this.courseModulesGrid = new System.Windows.Forms.DataGridView();
            this.nudModulePos = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseModulesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModulePos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadCourse
            // 
            this.btnLoadCourse.Location = new System.Drawing.Point(7, 29);
            this.btnLoadCourse.Name = "btnLoadCourse";
            this.btnLoadCourse.Size = new System.Drawing.Size(173, 23);
            this.btnLoadCourse.TabIndex = 44;
            this.btnLoadCourse.Text = "Load Course Information";
            this.btnLoadCourse.UseVisualStyleBackColor = true;
            this.btnLoadCourse.Click += new System.EventHandler(this.btnLoadCourse_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(258, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 19);
            this.label6.TabIndex = 54;
            this.label6.Text = "Select Number of Modules to Make";
            // 
            // nudNumberOfModule
            // 
            this.nudNumberOfModule.Location = new System.Drawing.Point(440, 65);
            this.nudNumberOfModule.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfModule.Name = "nudNumberOfModule";
            this.nudNumberOfModule.Size = new System.Drawing.Size(46, 20);
            this.nudNumberOfModule.TabIndex = 48;
            this.nudNumberOfModule.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCourseID
            // 
            this.nudCourseID.Location = new System.Drawing.Point(64, 3);
            this.nudCourseID.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.nudCourseID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCourseID.Name = "nudCourseID";
            this.nudCourseID.Size = new System.Drawing.Size(113, 20);
            this.nudCourseID.TabIndex = 43;
            this.nudCourseID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // xbxUseBase
            // 
            this.xbxUseBase.AutoSize = true;
            this.xbxUseBase.Checked = true;
            this.xbxUseBase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xbxUseBase.Location = new System.Drawing.Point(7, 65);
            this.xbxUseBase.Name = "xbxUseBase";
            this.xbxUseBase.Size = new System.Drawing.Size(245, 17);
            this.xbxUseBase.TabIndex = 46;
            this.xbxUseBase.TabStop = false;
            this.xbxUseBase.Text = "Use Base Name and Increment Numbers in [  ]";
            this.xbxUseBase.UseVisualStyleBackColor = true;
            this.xbxUseBase.CheckedChanged += new System.EventHandler(this.xbxUseBase_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Module Base Name";
            // 
            // txbBaseName
            // 
            this.txbBaseName.Enabled = false;
            this.txbBaseName.Location = new System.Drawing.Point(288, 6);
            this.txbBaseName.Name = "txbBaseName";
            this.txbBaseName.Size = new System.Drawing.Size(262, 20);
            this.txbBaseName.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Module Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Course ID";
            // 
            // txbModuleName
            // 
            this.txbModuleName.Enabled = false;
            this.txbModuleName.Location = new System.Drawing.Point(288, 32);
            this.txbModuleName.Name = "txbModuleName";
            this.txbModuleName.Size = new System.Drawing.Size(262, 20);
            this.txbModuleName.TabIndex = 49;
            // 
            // labelLoggedIn
            // 
            this.labelLoggedIn.Location = new System.Drawing.Point(578, 7);
            this.labelLoggedIn.Name = "labelLoggedIn";
            this.labelLoggedIn.Size = new System.Drawing.Size(291, 23);
            this.labelLoggedIn.TabIndex = 56;
            this.labelLoggedIn.Text = "Enter course ID and press load to begin";
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(581, 36);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.ReadOnly = true;
            this.rtbResults.Size = new System.Drawing.Size(264, 485);
            this.rtbResults.TabIndex = 55;
            this.rtbResults.TabStop = false;
            this.rtbResults.Text = "";
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(157, 245);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(118, 36);
            this.btnResetForm.TabIndex = 58;
            this.btnResetForm.TabStop = false;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnSubmitModule
            // 
            this.btnSubmitModule.Location = new System.Drawing.Point(7, 245);
            this.btnSubmitModule.Name = "btnSubmitModule";
            this.btnSubmitModule.Size = new System.Drawing.Size(118, 36);
            this.btnSubmitModule.TabIndex = 57;
            this.btnSubmitModule.Text = "Submit";
            this.btnSubmitModule.UseVisualStyleBackColor = true;
            this.btnSubmitModule.Click += new System.EventHandler(this.btnSubmitModule_Click);
            // 
            // seqProgress
            // 
            this.seqProgress.AutoSize = true;
            this.seqProgress.Checked = true;
            this.seqProgress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.seqProgress.Location = new System.Drawing.Point(7, 102);
            this.seqProgress.Name = "seqProgress";
            this.seqProgress.Size = new System.Drawing.Size(213, 17);
            this.seqProgress.TabIndex = 66;
            this.seqProgress.Text = "Require sequential assignment progress";
            this.seqProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.seqProgress.UseVisualStyleBackColor = true;
            // 
            // unlockOnDate
            // 
            this.unlockOnDate.AutoSize = true;
            this.unlockOnDate.Location = new System.Drawing.Point(5, 3);
            this.unlockOnDate.Name = "unlockOnDate";
            this.unlockOnDate.Size = new System.Drawing.Size(138, 17);
            this.unlockOnDate.TabIndex = 67;
            this.unlockOnDate.Text = "Unlock on specific date";
            this.unlockOnDate.UseVisualStyleBackColor = true;
            this.unlockOnDate.CheckedChanged += new System.EventHandler(this.unlockOnDate_CheckedChanged);
            // 
            // datePicker
            // 
            this.datePicker.Enabled = false;
            this.datePicker.Location = new System.Drawing.Point(5, 26);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 68;
            // 
            // setModulePos
            // 
            this.setModulePos.AutoSize = true;
            this.setModulePos.Location = new System.Drawing.Point(6, 3);
            this.setModulePos.Name = "setModulePos";
            this.setModulePos.Size = new System.Drawing.Size(119, 17);
            this.setModulePos.TabIndex = 69;
            this.setModulePos.Text = "Set module Position";
            this.setModulePos.UseVisualStyleBackColor = true;
            this.setModulePos.CheckedChanged += new System.EventHandler(this.setModulePos_CheckedChanged);
            // 
            // courseModulesGrid
            // 
            this.courseModulesGrid.AllowUserToAddRows = false;
            this.courseModulesGrid.AllowUserToDeleteRows = false;
            this.courseModulesGrid.AllowUserToResizeColumns = false;
            this.courseModulesGrid.AllowUserToResizeRows = false;
            this.courseModulesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseModulesGrid.BackgroundColor = System.Drawing.Color.White;
            this.courseModulesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.courseModulesGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.courseModulesGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.courseModulesGrid.Enabled = false;
            this.courseModulesGrid.GridColor = System.Drawing.Color.White;
            this.courseModulesGrid.Location = new System.Drawing.Point(6, 26);
            this.courseModulesGrid.MultiSelect = false;
            this.courseModulesGrid.Name = "courseModulesGrid";
            this.courseModulesGrid.ReadOnly = true;
            this.courseModulesGrid.RowHeadersVisible = false;
            this.courseModulesGrid.Size = new System.Drawing.Size(240, 95);
            this.courseModulesGrid.TabIndex = 70;
            // 
            // nudModulePos
            // 
            this.nudModulePos.Enabled = false;
            this.nudModulePos.Location = new System.Drawing.Point(131, 3);
            this.nudModulePos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudModulePos.Name = "nudModulePos";
            this.nudModulePos.Size = new System.Drawing.Size(44, 20);
            this.nudModulePos.TabIndex = 71;
            this.nudModulePos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.setModulePos);
            this.panel2.Controls.Add(this.courseModulesGrid);
            this.panel2.Controls.Add(this.nudModulePos);
            this.panel2.Location = new System.Drawing.Point(261, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 127);
            this.panel2.TabIndex = 73;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.unlockOnDate);
            this.panel3.Controls.Add(this.datePicker);
            this.panel3.Location = new System.Drawing.Point(7, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 52);
            this.panel3.TabIndex = 74;
            // 
            // ModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.seqProgress);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnSubmitModule);
            this.Controls.Add(this.labelLoggedIn);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.btnLoadCourse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudNumberOfModule);
            this.Controls.Add(this.nudCourseID);
            this.Controls.Add(this.xbxUseBase);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbBaseName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbModuleName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModuleForm";
            this.Text = "ModuleForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseModulesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModulePos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadCourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudNumberOfModule;
        public System.Windows.Forms.NumericUpDown nudCourseID;
        private System.Windows.Forms.CheckBox xbxUseBase;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbBaseName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbModuleName;
        private System.Windows.Forms.Label labelLoggedIn;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnSubmitModule;
        private System.Windows.Forms.CheckBox seqProgress;
        private System.Windows.Forms.CheckBox unlockOnDate;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.CheckBox setModulePos;
        private System.Windows.Forms.DataGridView courseModulesGrid;
        private System.Windows.Forms.NumericUpDown nudModulePos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}