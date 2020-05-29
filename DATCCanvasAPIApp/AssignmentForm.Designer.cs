namespace CanvasAPIApp
{
    partial class AssignmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignmentForm));
            this.btnLoadCourse = new System.Windows.Forms.Button();
            this.nudCourseID = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txbBaseName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbAssignName = new System.Windows.Forms.TextBox();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.buttonSubmitAssign = new System.Windows.Forms.Button();
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.xbxUseBase = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudNumberOfAssign = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbAssignInstructions = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGradeType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.groupBoxSubType = new System.Windows.Forms.GroupBox();
            this.checkBoxFileTypes = new System.Windows.Forms.CheckBox();
            this.checkBoxFileUpload = new System.Windows.Forms.CheckBox();
            this.checkBoxMedia = new System.Windows.Forms.CheckBox();
            this.checkBoxWebsite = new System.Windows.Forms.CheckBox();
            this.checkBoxTextEntry = new System.Windows.Forms.CheckBox();
            this.comboBoxSubTypes = new System.Windows.Forms.ComboBox();
            this.groupBoxOmit = new System.Windows.Forms.GroupBox();
            this.checkBoxOmit = new System.Windows.Forms.CheckBox();
            this.groupBoxDueDate = new System.Windows.Forms.GroupBox();
            this.dtpDueTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDueDate = new System.Windows.Forms.CheckBox();
            this.cbxAssignmentGroup = new System.Windows.Forms.ComboBox();
            this.lblAssignmentGroup = new System.Windows.Forms.Label();
            this.groupBoxAllowedExtensions = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFileTypes = new System.Windows.Forms.TextBox();
            this.groupBoxLock = new System.Windows.Forms.GroupBox();
            this.dtpUnlockTime = new System.Windows.Forms.DateTimePicker();
            this.dtpUnlockDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxUnlock = new System.Windows.Forms.CheckBox();
            this.dtpLockTime = new System.Windows.Forms.DateTimePicker();
            this.dtpLockDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxLock = new System.Windows.Forms.CheckBox();
            this.groupBoxPeer = new System.Windows.Forms.GroupBox();
            this.radioButtonPeerAuto = new System.Windows.Forms.RadioButton();
            this.radioButtonPeerManual = new System.Windows.Forms.RadioButton();
            this.checkBoxPeer = new System.Windows.Forms.CheckBox();
            this.groupBoxGroupAssign = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxGroupAssign = new System.Windows.Forms.CheckBox();
            this.cbxStudentAssignmentGroup = new System.Windows.Forms.ComboBox();
            this.checkBoxPublish = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfAssign)).BeginInit();
            this.groupBoxSubType.SuspendLayout();
            this.groupBoxOmit.SuspendLayout();
            this.groupBoxDueDate.SuspendLayout();
            this.groupBoxAllowedExtensions.SuspendLayout();
            this.groupBoxLock.SuspendLayout();
            this.groupBoxPeer.SuspendLayout();
            this.groupBoxGroupAssign.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadCourse
            // 
            this.btnLoadCourse.Location = new System.Drawing.Point(6, 50);
            this.btnLoadCourse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLoadCourse.Name = "btnLoadCourse";
            this.btnLoadCourse.Size = new System.Drawing.Size(346, 44);
            this.btnLoadCourse.TabIndex = 40;
            this.btnLoadCourse.Text = "Load Course Information";
            this.btnLoadCourse.UseVisualStyleBackColor = true;
            this.btnLoadCourse.Click += new System.EventHandler(this.btnLoadCourse_Click);
            // 
            // nudCourseID
            // 
            this.nudCourseID.Location = new System.Drawing.Point(126, 4);
            this.nudCourseID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.nudCourseID.Size = new System.Drawing.Size(226, 31);
            this.nudCourseID.TabIndex = 39;
            this.nudCourseID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 25);
            this.label10.TabIndex = 45;
            this.label10.Text = "Assign Base Name";
            // 
            // txbBaseName
            // 
            this.txbBaseName.Enabled = false;
            this.txbBaseName.Location = new System.Drawing.Point(568, 12);
            this.txbBaseName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbBaseName.Name = "txbBaseName";
            this.txbBaseName.Size = new System.Drawing.Size(520, 31);
            this.txbBaseName.TabIndex = 41;
            this.txbBaseName.TextChanged += new System.EventHandler(this.txbBaseName_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(418, 67);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 25);
            this.label9.TabIndex = 44;
            this.label9.Text = "Assign Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Course ID";
            // 
            // txbAssignName
            // 
            this.txbAssignName.Enabled = false;
            this.txbAssignName.Location = new System.Drawing.Point(568, 62);
            this.txbAssignName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbAssignName.Name = "txbAssignName";
            this.txbAssignName.Size = new System.Drawing.Size(520, 31);
            this.txbAssignName.TabIndex = 42;
            this.txbAssignName.TextChanged += new System.EventHandler(this.txbAssignName_TextChanged);
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(1126, 67);
            this.rtbResults.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.ReadOnly = true;
            this.rtbResults.Size = new System.Drawing.Size(532, 989);
            this.rtbResults.TabIndex = 46;
            this.rtbResults.TabStop = false;
            this.rtbResults.Text = "";
            // 
            // buttonSubmitAssign
            // 
            this.buttonSubmitAssign.Enabled = false;
            this.buttonSubmitAssign.Location = new System.Drawing.Point(20, 1044);
            this.buttonSubmitAssign.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSubmitAssign.Name = "buttonSubmitAssign";
            this.buttonSubmitAssign.Size = new System.Drawing.Size(236, 69);
            this.buttonSubmitAssign.TabIndex = 47;
            this.buttonSubmitAssign.Text = "Submit";
            this.buttonSubmitAssign.UseVisualStyleBackColor = true;
            this.buttonSubmitAssign.Click += new System.EventHandler(this.buttonSubmitAssign_Click);
            // 
            // labelLoggedIn
            // 
            this.labelLoggedIn.Location = new System.Drawing.Point(1120, 12);
            this.labelLoggedIn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLoggedIn.Name = "labelLoggedIn";
            this.labelLoggedIn.Size = new System.Drawing.Size(536, 44);
            this.labelLoggedIn.TabIndex = 48;
            this.labelLoggedIn.Text = "Enter course ID and press load to begin";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(288, 1044);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(236, 69);
            this.buttonReset.TabIndex = 49;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // xbxUseBase
            // 
            this.xbxUseBase.AutoSize = true;
            this.xbxUseBase.Checked = true;
            this.xbxUseBase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xbxUseBase.Location = new System.Drawing.Point(12, 129);
            this.xbxUseBase.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.xbxUseBase.Name = "xbxUseBase";
            this.xbxUseBase.Size = new System.Drawing.Size(486, 29);
            this.xbxUseBase.TabIndex = 50;
            this.xbxUseBase.TabStop = false;
            this.xbxUseBase.Text = "Use Base Name and Increment Numbers in [  ]";
            this.xbxUseBase.UseVisualStyleBackColor = true;
            this.xbxUseBase.CheckedChanged += new System.EventHandler(this.xbxUseBase_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(562, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(408, 37);
            this.label6.TabIndex = 52;
            this.label6.Text = "Select Number of Assignments to Make";
            // 
            // nudNumberOfAssign
            // 
            this.nudNumberOfAssign.Location = new System.Drawing.Point(982, 123);
            this.nudNumberOfAssign.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudNumberOfAssign.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfAssign.Name = "nudNumberOfAssign";
            this.nudNumberOfAssign.Size = new System.Drawing.Size(92, 31);
            this.nudNumberOfAssign.TabIndex = 51;
            this.nudNumberOfAssign.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(882, 44);
            this.label1.TabIndex = 53;
            this.label1.Text = "Assignment Instructions (anything in [  ] will be replaced by Assignment Name at " +
    "submit)";
            // 
            // rtbAssignInstructions
            // 
            this.rtbAssignInstructions.Location = new System.Drawing.Point(6, 217);
            this.rtbAssignInstructions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rtbAssignInstructions.Name = "rtbAssignInstructions";
            this.rtbAssignInstructions.Size = new System.Drawing.Size(1080, 87);
            this.rtbAssignInstructions.TabIndex = 54;
            this.rtbAssignInstructions.TabStop = false;
            this.rtbAssignInstructions.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 321);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "Display Grade as:";
            // 
            // comboBoxGradeType
            // 
            this.comboBoxGradeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGradeType.Enabled = false;
            this.comboBoxGradeType.FormattingEnabled = true;
            this.comboBoxGradeType.Items.AddRange(new object[] {
            "Points",
            "Percentage",
            "Complete/Incomplete",
            "Letter Grade",
            "GPA Scale"});
            this.comboBoxGradeType.Location = new System.Drawing.Point(6, 354);
            this.comboBoxGradeType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxGradeType.Name = "comboBoxGradeType";
            this.comboBoxGradeType.Size = new System.Drawing.Size(238, 33);
            this.comboBoxGradeType.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 498);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "Points Possible:";
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.Location = new System.Drawing.Point(6, 529);
            this.textBoxPoints.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.Size = new System.Drawing.Size(60, 31);
            this.textBoxPoints.TabIndex = 58;
            this.textBoxPoints.Text = "0";
            // 
            // groupBoxSubType
            // 
            this.groupBoxSubType.Controls.Add(this.checkBoxFileTypes);
            this.groupBoxSubType.Controls.Add(this.checkBoxFileUpload);
            this.groupBoxSubType.Controls.Add(this.checkBoxMedia);
            this.groupBoxSubType.Controls.Add(this.checkBoxWebsite);
            this.groupBoxSubType.Controls.Add(this.checkBoxTextEntry);
            this.groupBoxSubType.Controls.Add(this.comboBoxSubTypes);
            this.groupBoxSubType.Location = new System.Drawing.Point(674, 321);
            this.groupBoxSubType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxSubType.Name = "groupBoxSubType";
            this.groupBoxSubType.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxSubType.Size = new System.Drawing.Size(400, 325);
            this.groupBoxSubType.TabIndex = 59;
            this.groupBoxSubType.TabStop = false;
            this.groupBoxSubType.Text = "Submission Types";
            // 
            // checkBoxFileTypes
            // 
            this.checkBoxFileTypes.AutoSize = true;
            this.checkBoxFileTypes.Location = new System.Drawing.Point(58, 258);
            this.checkBoxFileTypes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxFileTypes.Name = "checkBoxFileTypes";
            this.checkBoxFileTypes.Size = new System.Drawing.Size(309, 29);
            this.checkBoxFileTypes.TabIndex = 5;
            this.checkBoxFileTypes.Text = "Restrict Upload File Types?";
            this.checkBoxFileTypes.UseVisualStyleBackColor = true;
            this.checkBoxFileTypes.Visible = false;
            this.checkBoxFileTypes.CheckedChanged += new System.EventHandler(this.checkBoxFileTypes_CheckedChanged);
            // 
            // checkBoxFileUpload
            // 
            this.checkBoxFileUpload.AutoSize = true;
            this.checkBoxFileUpload.Enabled = false;
            this.checkBoxFileUpload.Location = new System.Drawing.Point(14, 212);
            this.checkBoxFileUpload.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxFileUpload.Name = "checkBoxFileUpload";
            this.checkBoxFileUpload.Size = new System.Drawing.Size(164, 29);
            this.checkBoxFileUpload.TabIndex = 4;
            this.checkBoxFileUpload.Text = "File Uploads";
            this.checkBoxFileUpload.UseVisualStyleBackColor = true;
            this.checkBoxFileUpload.CheckedChanged += new System.EventHandler(this.checkBoxFileUpload_CheckedChanged);
            // 
            // checkBoxMedia
            // 
            this.checkBoxMedia.AutoSize = true;
            this.checkBoxMedia.Enabled = false;
            this.checkBoxMedia.Location = new System.Drawing.Point(14, 169);
            this.checkBoxMedia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxMedia.Name = "checkBoxMedia";
            this.checkBoxMedia.Size = new System.Drawing.Size(218, 29);
            this.checkBoxMedia.TabIndex = 3;
            this.checkBoxMedia.Text = "Media Recordings";
            this.checkBoxMedia.UseVisualStyleBackColor = true;
            // 
            // checkBoxWebsite
            // 
            this.checkBoxWebsite.AutoSize = true;
            this.checkBoxWebsite.Enabled = false;
            this.checkBoxWebsite.Location = new System.Drawing.Point(14, 127);
            this.checkBoxWebsite.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxWebsite.Name = "checkBoxWebsite";
            this.checkBoxWebsite.Size = new System.Drawing.Size(170, 29);
            this.checkBoxWebsite.TabIndex = 2;
            this.checkBoxWebsite.Text = "Website URL";
            this.checkBoxWebsite.UseVisualStyleBackColor = true;
            // 
            // checkBoxTextEntry
            // 
            this.checkBoxTextEntry.AutoSize = true;
            this.checkBoxTextEntry.Enabled = false;
            this.checkBoxTextEntry.Location = new System.Drawing.Point(14, 85);
            this.checkBoxTextEntry.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxTextEntry.Name = "checkBoxTextEntry";
            this.checkBoxTextEntry.Size = new System.Drawing.Size(142, 29);
            this.checkBoxTextEntry.TabIndex = 1;
            this.checkBoxTextEntry.Text = "Text Entry";
            this.checkBoxTextEntry.UseVisualStyleBackColor = true;
            // 
            // comboBoxSubTypes
            // 
            this.comboBoxSubTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubTypes.Enabled = false;
            this.comboBoxSubTypes.FormattingEnabled = true;
            this.comboBoxSubTypes.Items.AddRange(new object[] {
            "No submission",
            "Online",
            "On paper",
            "External Tool"});
            this.comboBoxSubTypes.Location = new System.Drawing.Point(14, 31);
            this.comboBoxSubTypes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxSubTypes.Name = "comboBoxSubTypes";
            this.comboBoxSubTypes.Size = new System.Drawing.Size(238, 33);
            this.comboBoxSubTypes.TabIndex = 0;
            this.comboBoxSubTypes.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubTypes_SelectedIndexChanged);
            // 
            // groupBoxOmit
            // 
            this.groupBoxOmit.Controls.Add(this.checkBoxOmit);
            this.groupBoxOmit.Location = new System.Drawing.Point(266, 321);
            this.groupBoxOmit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxOmit.Name = "groupBoxOmit";
            this.groupBoxOmit.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxOmit.Size = new System.Drawing.Size(400, 129);
            this.groupBoxOmit.TabIndex = 61;
            this.groupBoxOmit.TabStop = false;
            this.groupBoxOmit.Text = "Omit Grade";
            // 
            // checkBoxOmit
            // 
            this.checkBoxOmit.Location = new System.Drawing.Point(12, 37);
            this.checkBoxOmit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxOmit.Name = "checkBoxOmit";
            this.checkBoxOmit.Size = new System.Drawing.Size(332, 71);
            this.checkBoxOmit.TabIndex = 0;
            this.checkBoxOmit.Text = "Do not count this assignment toward final grade";
            this.checkBoxOmit.UseVisualStyleBackColor = true;
            // 
            // groupBoxDueDate
            // 
            this.groupBoxDueDate.Controls.Add(this.dtpDueTime);
            this.groupBoxDueDate.Controls.Add(this.dtpDueDate);
            this.groupBoxDueDate.Controls.Add(this.checkBoxDueDate);
            this.groupBoxDueDate.Location = new System.Drawing.Point(16, 631);
            this.groupBoxDueDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxDueDate.Name = "groupBoxDueDate";
            this.groupBoxDueDate.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxDueDate.Size = new System.Drawing.Size(650, 158);
            this.groupBoxDueDate.TabIndex = 62;
            this.groupBoxDueDate.TabStop = false;
            this.groupBoxDueDate.Text = "Due Date";
            // 
            // dtpDueTime
            // 
            this.dtpDueTime.Enabled = false;
            this.dtpDueTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDueTime.Location = new System.Drawing.Point(442, 83);
            this.dtpDueTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpDueTime.Name = "dtpDueTime";
            this.dtpDueTime.ShowUpDown = true;
            this.dtpDueTime.Size = new System.Drawing.Size(192, 31);
            this.dtpDueTime.TabIndex = 8;
            this.dtpDueTime.TabStop = false;
            this.dtpDueTime.Value = new System.DateTime(2016, 10, 2, 0, 0, 0, 0);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Checked = false;
            this.dtpDueDate.Enabled = false;
            this.dtpDueDate.Location = new System.Drawing.Point(12, 83);
            this.dtpDueDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(406, 31);
            this.dtpDueDate.TabIndex = 7;
            this.dtpDueDate.TabStop = false;
            this.dtpDueDate.Value = new System.DateTime(2016, 10, 11, 15, 20, 56, 0);
            // 
            // checkBoxDueDate
            // 
            this.checkBoxDueDate.AutoSize = true;
            this.checkBoxDueDate.Location = new System.Drawing.Point(12, 38);
            this.checkBoxDueDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxDueDate.Name = "checkBoxDueDate";
            this.checkBoxDueDate.Size = new System.Drawing.Size(184, 29);
            this.checkBoxDueDate.TabIndex = 0;
            this.checkBoxDueDate.Text = "Set a due date";
            this.checkBoxDueDate.UseVisualStyleBackColor = true;
            this.checkBoxDueDate.CheckedChanged += new System.EventHandler(this.checkBoxDueDate_CheckedChanged);
            // 
            // cbxAssignmentGroup
            // 
            this.cbxAssignmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAssignmentGroup.Enabled = false;
            this.cbxAssignmentGroup.FormattingEnabled = true;
            this.cbxAssignmentGroup.Location = new System.Drawing.Point(6, 437);
            this.cbxAssignmentGroup.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxAssignmentGroup.Name = "cbxAssignmentGroup";
            this.cbxAssignmentGroup.Size = new System.Drawing.Size(238, 33);
            this.cbxAssignmentGroup.TabIndex = 63;
            this.cbxAssignmentGroup.TabStop = false;
            // 
            // lblAssignmentGroup
            // 
            this.lblAssignmentGroup.Location = new System.Drawing.Point(6, 406);
            this.lblAssignmentGroup.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAssignmentGroup.Name = "lblAssignmentGroup";
            this.lblAssignmentGroup.Size = new System.Drawing.Size(248, 33);
            this.lblAssignmentGroup.TabIndex = 64;
            this.lblAssignmentGroup.Text = "Assignment groups";
            // 
            // groupBoxAllowedExtensions
            // 
            this.groupBoxAllowedExtensions.Controls.Add(this.label5);
            this.groupBoxAllowedExtensions.Controls.Add(this.textBoxFileTypes);
            this.groupBoxAllowedExtensions.Location = new System.Drawing.Point(674, 658);
            this.groupBoxAllowedExtensions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxAllowedExtensions.Name = "groupBoxAllowedExtensions";
            this.groupBoxAllowedExtensions.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxAllowedExtensions.Size = new System.Drawing.Size(400, 165);
            this.groupBoxAllowedExtensions.TabIndex = 65;
            this.groupBoxAllowedExtensions.TabStop = false;
            this.groupBoxAllowedExtensions.Text = "Allowed File Types";
            this.groupBoxAllowedExtensions.Visible = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(376, 65);
            this.label5.TabIndex = 1;
            this.label5.Text = "Enter extensions separated by commas. Ex: doc, ppt, pdf";
            // 
            // textBoxFileTypes
            // 
            this.textBoxFileTypes.Location = new System.Drawing.Point(18, 113);
            this.textBoxFileTypes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxFileTypes.Name = "textBoxFileTypes";
            this.textBoxFileTypes.Size = new System.Drawing.Size(372, 31);
            this.textBoxFileTypes.TabIndex = 0;
            // 
            // groupBoxLock
            // 
            this.groupBoxLock.Controls.Add(this.dtpUnlockTime);
            this.groupBoxLock.Controls.Add(this.dtpUnlockDate);
            this.groupBoxLock.Controls.Add(this.checkBoxUnlock);
            this.groupBoxLock.Controls.Add(this.dtpLockTime);
            this.groupBoxLock.Controls.Add(this.dtpLockDate);
            this.groupBoxLock.Controls.Add(this.checkBoxLock);
            this.groupBoxLock.Location = new System.Drawing.Point(16, 800);
            this.groupBoxLock.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxLock.Name = "groupBoxLock";
            this.groupBoxLock.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxLock.Size = new System.Drawing.Size(650, 233);
            this.groupBoxLock.TabIndex = 66;
            this.groupBoxLock.TabStop = false;
            this.groupBoxLock.Text = "Lock/Unlock Assignment";
            // 
            // dtpUnlockTime
            // 
            this.dtpUnlockTime.Enabled = false;
            this.dtpUnlockTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpUnlockTime.Location = new System.Drawing.Point(442, 81);
            this.dtpUnlockTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpUnlockTime.Name = "dtpUnlockTime";
            this.dtpUnlockTime.ShowUpDown = true;
            this.dtpUnlockTime.Size = new System.Drawing.Size(192, 31);
            this.dtpUnlockTime.TabIndex = 11;
            this.dtpUnlockTime.TabStop = false;
            this.dtpUnlockTime.Value = new System.DateTime(2016, 10, 2, 0, 0, 0, 0);
            // 
            // dtpUnlockDate
            // 
            this.dtpUnlockDate.Checked = false;
            this.dtpUnlockDate.Enabled = false;
            this.dtpUnlockDate.Location = new System.Drawing.Point(12, 81);
            this.dtpUnlockDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpUnlockDate.Name = "dtpUnlockDate";
            this.dtpUnlockDate.Size = new System.Drawing.Size(406, 31);
            this.dtpUnlockDate.TabIndex = 10;
            this.dtpUnlockDate.TabStop = false;
            this.dtpUnlockDate.Value = new System.DateTime(2016, 10, 11, 15, 20, 56, 0);
            // 
            // checkBoxUnlock
            // 
            this.checkBoxUnlock.AutoSize = true;
            this.checkBoxUnlock.Location = new System.Drawing.Point(12, 37);
            this.checkBoxUnlock.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxUnlock.Name = "checkBoxUnlock";
            this.checkBoxUnlock.Size = new System.Drawing.Size(226, 29);
            this.checkBoxUnlock.TabIndex = 9;
            this.checkBoxUnlock.Text = "Set an Unlock date";
            this.checkBoxUnlock.UseVisualStyleBackColor = true;
            this.checkBoxUnlock.CheckedChanged += new System.EventHandler(this.checkBoxUnlock_CheckedChanged);
            // 
            // dtpLockTime
            // 
            this.dtpLockTime.Enabled = false;
            this.dtpLockTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpLockTime.Location = new System.Drawing.Point(442, 175);
            this.dtpLockTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpLockTime.Name = "dtpLockTime";
            this.dtpLockTime.ShowUpDown = true;
            this.dtpLockTime.Size = new System.Drawing.Size(192, 31);
            this.dtpLockTime.TabIndex = 8;
            this.dtpLockTime.TabStop = false;
            this.dtpLockTime.Value = new System.DateTime(2016, 10, 2, 0, 0, 0, 0);
            // 
            // dtpLockDate
            // 
            this.dtpLockDate.Checked = false;
            this.dtpLockDate.Enabled = false;
            this.dtpLockDate.Location = new System.Drawing.Point(12, 175);
            this.dtpLockDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpLockDate.Name = "dtpLockDate";
            this.dtpLockDate.Size = new System.Drawing.Size(406, 31);
            this.dtpLockDate.TabIndex = 7;
            this.dtpLockDate.TabStop = false;
            this.dtpLockDate.Value = new System.DateTime(2016, 10, 11, 15, 20, 56, 0);
            // 
            // checkBoxLock
            // 
            this.checkBoxLock.AutoSize = true;
            this.checkBoxLock.Location = new System.Drawing.Point(12, 131);
            this.checkBoxLock.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxLock.Name = "checkBoxLock";
            this.checkBoxLock.Size = new System.Drawing.Size(187, 29);
            this.checkBoxLock.TabIndex = 0;
            this.checkBoxLock.Text = "Set a lock date";
            this.checkBoxLock.UseVisualStyleBackColor = true;
            this.checkBoxLock.CheckedChanged += new System.EventHandler(this.checkBoxLock_CheckedChanged);
            // 
            // groupBoxPeer
            // 
            this.groupBoxPeer.Controls.Add(this.radioButtonPeerAuto);
            this.groupBoxPeer.Controls.Add(this.radioButtonPeerManual);
            this.groupBoxPeer.Controls.Add(this.checkBoxPeer);
            this.groupBoxPeer.Location = new System.Drawing.Point(674, 840);
            this.groupBoxPeer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxPeer.Name = "groupBoxPeer";
            this.groupBoxPeer.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxPeer.Size = new System.Drawing.Size(400, 192);
            this.groupBoxPeer.TabIndex = 67;
            this.groupBoxPeer.TabStop = false;
            this.groupBoxPeer.Text = "Peer Reviews";
            // 
            // radioButtonPeerAuto
            // 
            this.radioButtonPeerAuto.AutoSize = true;
            this.radioButtonPeerAuto.Location = new System.Drawing.Point(58, 131);
            this.radioButtonPeerAuto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButtonPeerAuto.Name = "radioButtonPeerAuto";
            this.radioButtonPeerAuto.Size = new System.Drawing.Size(158, 29);
            this.radioButtonPeerAuto.TabIndex = 2;
            this.radioButtonPeerAuto.Text = "Auto Assign";
            this.radioButtonPeerAuto.UseVisualStyleBackColor = true;
            this.radioButtonPeerAuto.Visible = false;
            // 
            // radioButtonPeerManual
            // 
            this.radioButtonPeerManual.AutoSize = true;
            this.radioButtonPeerManual.Location = new System.Drawing.Point(58, 85);
            this.radioButtonPeerManual.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButtonPeerManual.Name = "radioButtonPeerManual";
            this.radioButtonPeerManual.Size = new System.Drawing.Size(213, 29);
            this.radioButtonPeerManual.TabIndex = 1;
            this.radioButtonPeerManual.Text = "Mannually Assign";
            this.radioButtonPeerManual.UseVisualStyleBackColor = true;
            this.radioButtonPeerManual.Visible = false;
            // 
            // checkBoxPeer
            // 
            this.checkBoxPeer.AutoSize = true;
            this.checkBoxPeer.Location = new System.Drawing.Point(14, 38);
            this.checkBoxPeer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxPeer.Name = "checkBoxPeer";
            this.checkBoxPeer.Size = new System.Drawing.Size(269, 29);
            this.checkBoxPeer.TabIndex = 0;
            this.checkBoxPeer.Text = "Require Peer Reviews?";
            this.checkBoxPeer.UseVisualStyleBackColor = true;
            this.checkBoxPeer.CheckedChanged += new System.EventHandler(this.checkBoxPeer_CheckedChanged);
            // 
            // groupBoxGroupAssign
            // 
            this.groupBoxGroupAssign.Controls.Add(this.label7);
            this.groupBoxGroupAssign.Controls.Add(this.checkBoxGroupAssign);
            this.groupBoxGroupAssign.Controls.Add(this.cbxStudentAssignmentGroup);
            this.groupBoxGroupAssign.Location = new System.Drawing.Point(266, 462);
            this.groupBoxGroupAssign.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxGroupAssign.Name = "groupBoxGroupAssign";
            this.groupBoxGroupAssign.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxGroupAssign.Size = new System.Drawing.Size(400, 171);
            this.groupBoxGroupAssign.TabIndex = 68;
            this.groupBoxGroupAssign.TabStop = false;
            this.groupBoxGroupAssign.Text = "Group Assignment";
            this.groupBoxGroupAssign.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 76;
            this.label7.Text = "Select Group";
            // 
            // checkBoxGroupAssign
            // 
            this.checkBoxGroupAssign.AutoSize = true;
            this.checkBoxGroupAssign.Location = new System.Drawing.Point(12, 37);
            this.checkBoxGroupAssign.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxGroupAssign.Name = "checkBoxGroupAssign";
            this.checkBoxGroupAssign.Size = new System.Drawing.Size(233, 29);
            this.checkBoxGroupAssign.TabIndex = 75;
            this.checkBoxGroupAssign.Text = "Group Assignment?";
            this.checkBoxGroupAssign.UseVisualStyleBackColor = true;
            // 
            // cbxStudentAssignmentGroup
            // 
            this.cbxStudentAssignmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStudentAssignmentGroup.Enabled = false;
            this.cbxStudentAssignmentGroup.FormattingEnabled = true;
            this.cbxStudentAssignmentGroup.Location = new System.Drawing.Point(6, 121);
            this.cbxStudentAssignmentGroup.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxStudentAssignmentGroup.Name = "cbxStudentAssignmentGroup";
            this.cbxStudentAssignmentGroup.Size = new System.Drawing.Size(238, 33);
            this.cbxStudentAssignmentGroup.TabIndex = 74;
            this.cbxStudentAssignmentGroup.TabStop = false;
            // 
            // checkBoxPublish
            // 
            this.checkBoxPublish.AutoSize = true;
            this.checkBoxPublish.Location = new System.Drawing.Point(674, 1046);
            this.checkBoxPublish.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxPublish.Name = "checkBoxPublish";
            this.checkBoxPublish.Size = new System.Drawing.Size(350, 29);
            this.checkBoxPublish.TabIndex = 69;
            this.checkBoxPublish.Text = "Publish Assignment on Creation";
            this.checkBoxPublish.UseVisualStyleBackColor = true;
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1271);
            this.Controls.Add(this.checkBoxPublish);
            this.Controls.Add(this.groupBoxGroupAssign);
            this.Controls.Add(this.groupBoxPeer);
            this.Controls.Add(this.groupBoxLock);
            this.Controls.Add(this.groupBoxAllowedExtensions);
            this.Controls.Add(this.cbxAssignmentGroup);
            this.Controls.Add(this.lblAssignmentGroup);
            this.Controls.Add(this.groupBoxDueDate);
            this.Controls.Add(this.groupBoxOmit);
            this.Controls.Add(this.groupBoxSubType);
            this.Controls.Add(this.textBoxPoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxGradeType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbAssignInstructions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudNumberOfAssign);
            this.Controls.Add(this.xbxUseBase);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelLoggedIn);
            this.Controls.Add(this.buttonSubmitAssign);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.btnLoadCourse);
            this.Controls.Add(this.nudCourseID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbBaseName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbAssignName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AssignmentForm";
            this.Text = "Create Assignment";
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfAssign)).EndInit();
            this.groupBoxSubType.ResumeLayout(false);
            this.groupBoxSubType.PerformLayout();
            this.groupBoxOmit.ResumeLayout(false);
            this.groupBoxDueDate.ResumeLayout(false);
            this.groupBoxDueDate.PerformLayout();
            this.groupBoxAllowedExtensions.ResumeLayout(false);
            this.groupBoxAllowedExtensions.PerformLayout();
            this.groupBoxLock.ResumeLayout(false);
            this.groupBoxLock.PerformLayout();
            this.groupBoxPeer.ResumeLayout(false);
            this.groupBoxPeer.PerformLayout();
            this.groupBoxGroupAssign.ResumeLayout(false);
            this.groupBoxGroupAssign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadCourse;
        public System.Windows.Forms.NumericUpDown nudCourseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbBaseName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbAssignName;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Button buttonSubmitAssign;
        private System.Windows.Forms.Label labelLoggedIn;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.CheckBox xbxUseBase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudNumberOfAssign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbAssignInstructions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGradeType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPoints;
        private System.Windows.Forms.GroupBox groupBoxSubType;
        private System.Windows.Forms.CheckBox checkBoxFileUpload;
        private System.Windows.Forms.CheckBox checkBoxMedia;
        private System.Windows.Forms.CheckBox checkBoxWebsite;
        private System.Windows.Forms.CheckBox checkBoxTextEntry;
        private System.Windows.Forms.ComboBox comboBoxSubTypes;
        private System.Windows.Forms.GroupBox groupBoxOmit;
        private System.Windows.Forms.CheckBox checkBoxOmit;
        private System.Windows.Forms.GroupBox groupBoxDueDate;
        private System.Windows.Forms.CheckBox checkBoxDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueTime;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.ComboBox cbxAssignmentGroup;
        private System.Windows.Forms.Label lblAssignmentGroup;
      private System.Windows.Forms.CheckBox checkBoxFileTypes;
      private System.Windows.Forms.GroupBox groupBoxAllowedExtensions;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox textBoxFileTypes;
      private System.Windows.Forms.GroupBox groupBoxLock;
      private System.Windows.Forms.DateTimePicker dtpUnlockTime;
      private System.Windows.Forms.DateTimePicker dtpUnlockDate;
      private System.Windows.Forms.CheckBox checkBoxUnlock;
      private System.Windows.Forms.DateTimePicker dtpLockTime;
      private System.Windows.Forms.DateTimePicker dtpLockDate;
      private System.Windows.Forms.CheckBox checkBoxLock;
      private System.Windows.Forms.GroupBox groupBoxPeer;
      private System.Windows.Forms.RadioButton radioButtonPeerAuto;
      private System.Windows.Forms.RadioButton radioButtonPeerManual;
      private System.Windows.Forms.CheckBox checkBoxPeer;
      private System.Windows.Forms.GroupBox groupBoxGroupAssign;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.CheckBox checkBoxGroupAssign;
      private System.Windows.Forms.ComboBox cbxStudentAssignmentGroup;
        private System.Windows.Forms.CheckBox checkBoxPublish;
    }
}