namespace CanvasAPIApp
{
    partial class CalendarForm
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
            this.rtbEventDescription = new System.Windows.Forms.RichTextBox();
            this.lblEventDescription = new System.Windows.Forms.Label();
            this.dtpLockDateTime = new System.Windows.Forms.DateTimePicker();
            this.dtpLockDate = new System.Windows.Forms.DateTimePicker();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.txbEventName = new System.Windows.Forms.TextBox();
            this.btnResetCalendar = new System.Windows.Forms.Button();
            this.btnSubmitCalendar = new System.Windows.Forms.Button();
            this.btnLoadCourse = new System.Windows.Forms.Button();
            this.nudCourseID = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseID)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbEventDescription
            // 
            this.rtbEventDescription.Location = new System.Drawing.Point(25, 154);
            this.rtbEventDescription.Name = "rtbEventDescription";
            this.rtbEventDescription.Size = new System.Drawing.Size(313, 140);
            this.rtbEventDescription.TabIndex = 70;
            this.rtbEventDescription.TabStop = false;
            this.rtbEventDescription.Text = "";
            // 
            // lblEventDescription
            // 
            this.lblEventDescription.Location = new System.Drawing.Point(22, 137);
            this.lblEventDescription.Name = "lblEventDescription";
            this.lblEventDescription.Size = new System.Drawing.Size(441, 23);
            this.lblEventDescription.TabIndex = 71;
            this.lblEventDescription.Text = "Event Description";
            this.lblEventDescription.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpLockDateTime
            // 
            this.dtpLockDateTime.Enabled = false;
            this.dtpLockDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpLockDateTime.Location = new System.Drawing.Point(240, 71);
            this.dtpLockDateTime.Name = "dtpLockDateTime";
            this.dtpLockDateTime.ShowUpDown = true;
            this.dtpLockDateTime.Size = new System.Drawing.Size(98, 20);
            this.dtpLockDateTime.TabIndex = 74;
            this.dtpLockDateTime.TabStop = false;
            this.dtpLockDateTime.Value = new System.DateTime(2016, 10, 2, 23, 59, 0, 0);
            // 
            // dtpLockDate
            // 
            this.dtpLockDate.Checked = false;
            this.dtpLockDate.Location = new System.Drawing.Point(25, 71);
            this.dtpLockDate.Name = "dtpLockDate";
            this.dtpLockDate.ShowCheckBox = true;
            this.dtpLockDate.Size = new System.Drawing.Size(205, 20);
            this.dtpLockDate.TabIndex = 73;
            this.dtpLockDate.TabStop = false;
            this.dtpLockDate.Value = new System.DateTime(2016, 10, 11, 15, 20, 56, 0);
            // 
            // lblEventDate
            // 
            this.lblEventDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEventDate.Location = new System.Drawing.Point(22, 55);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(251, 18);
            this.lblEventDate.TabIndex = 72;
            this.lblEventDate.Text = "Event Date";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEventName.Location = new System.Drawing.Point(22, 94);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(66, 13);
            this.lblEventName.TabIndex = 76;
            this.lblEventName.Text = "Event Name";
            // 
            // txbEventName
            // 
            this.txbEventName.Enabled = false;
            this.txbEventName.Location = new System.Drawing.Point(25, 110);
            this.txbEventName.Name = "txbEventName";
            this.txbEventName.Size = new System.Drawing.Size(262, 20);
            this.txbEventName.TabIndex = 75;
            // 
            // btnResetCalendar
            // 
            this.btnResetCalendar.Location = new System.Drawing.Point(226, 300);
            this.btnResetCalendar.Name = "btnResetCalendar";
            this.btnResetCalendar.Size = new System.Drawing.Size(112, 25);
            this.btnResetCalendar.TabIndex = 78;
            this.btnResetCalendar.Text = "Reset";
            this.btnResetCalendar.UseVisualStyleBackColor = true;
            // 
            // btnSubmitCalendar
            // 
            this.btnSubmitCalendar.Enabled = false;
            this.btnSubmitCalendar.Location = new System.Drawing.Point(25, 300);
            this.btnSubmitCalendar.Name = "btnSubmitCalendar";
            this.btnSubmitCalendar.Size = new System.Drawing.Size(104, 25);
            this.btnSubmitCalendar.TabIndex = 77;
            this.btnSubmitCalendar.Text = "Submit";
            this.btnSubmitCalendar.UseVisualStyleBackColor = true;
            // 
            // btnLoadCourse
            // 
            this.btnLoadCourse.Location = new System.Drawing.Point(204, 2);
            this.btnLoadCourse.Name = "btnLoadCourse";
            this.btnLoadCourse.Size = new System.Drawing.Size(144, 23);
            this.btnLoadCourse.TabIndex = 80;
            this.btnLoadCourse.Text = "Load Course Information";
            this.btnLoadCourse.UseVisualStyleBackColor = true;
            // 
            // nudCourseID
            // 
            this.nudCourseID.Location = new System.Drawing.Point(85, 5);
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
            this.nudCourseID.TabIndex = 79;
            this.nudCourseID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Course ID";
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(379, 29);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.ReadOnly = true;
            this.rtbResults.Size = new System.Drawing.Size(271, 296);
            this.rtbResults.TabIndex = 82;
            this.rtbResults.TabStop = false;
            this.rtbResults.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(376, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 15);
            this.label1.TabIndex = 83;
            this.label1.Text = "Activity Log";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.btnLoadCourse);
            this.Controls.Add(this.nudCourseID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnResetCalendar);
            this.Controls.Add(this.btnSubmitCalendar);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.txbEventName);
            this.Controls.Add(this.dtpLockDateTime);
            this.Controls.Add(this.dtpLockDate);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.rtbEventDescription);
            this.Controls.Add(this.lblEventDescription);
            this.Name = "CalendarForm";
            this.Text = "CalendarForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbEventDescription;
        private System.Windows.Forms.Label lblEventDescription;
        private System.Windows.Forms.DateTimePicker dtpLockDateTime;
        private System.Windows.Forms.DateTimePicker dtpLockDate;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.TextBox txbEventName;
        private System.Windows.Forms.Button btnResetCalendar;
        private System.Windows.Forms.Button btnSubmitCalendar;
        private System.Windows.Forms.Button btnLoadCourse;
        public System.Windows.Forms.NumericUpDown nudCourseID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Label label1;
    }
}