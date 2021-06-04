﻿namespace CanvasAPIApp
{
    partial class PagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagesForm));
            this.rtbPageBody = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.xbxUseBase = new System.Windows.Forms.CheckBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.buttonSubmitPage = new System.Windows.Forms.Button();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.btnLoadCourse = new System.Windows.Forms.Button();
            this.nudCourseID = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txbBaseName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPageName = new System.Windows.Forms.TextBox();
            this.nudNumberOfAssign = new System.Windows.Forms.NumericUpDown();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.radioButtonAnyone = new System.Windows.Forms.RadioButton();
            this.radioButtonTeachandStu = new System.Windows.Forms.RadioButton();
            this.radioButtonTeachers = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxContentChange = new System.Windows.Forms.CheckBox();
            this.checkBoxPagePublish = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfAssign)).BeginInit();
            this.groupBoxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbPageBody
            // 
            this.rtbPageBody.Location = new System.Drawing.Point(6, 217);
            this.rtbPageBody.Margin = new System.Windows.Forms.Padding(6);
            this.rtbPageBody.Name = "rtbPageBody";
            this.rtbPageBody.Size = new System.Drawing.Size(1080, 391);
            this.rtbPageBody.TabIndex = 69;
            this.rtbPageBody.TabStop = false;
            this.rtbPageBody.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(882, 44);
            this.label1.TabIndex = 68;
            this.label1.Text = "Page body (anything in [  ] will be replaced by Page Name at submit)";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(562, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(408, 37);
            this.label6.TabIndex = 67;
            this.label6.Text = "Select Number of Pages to Make";
            // 
            // xbxUseBase
            // 
            this.xbxUseBase.AutoSize = true;
            this.xbxUseBase.Checked = true;
            this.xbxUseBase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xbxUseBase.Location = new System.Drawing.Point(12, 129);
            this.xbxUseBase.Margin = new System.Windows.Forms.Padding(6);
            this.xbxUseBase.Name = "xbxUseBase";
            this.xbxUseBase.Size = new System.Drawing.Size(486, 29);
            this.xbxUseBase.TabIndex = 66;
            this.xbxUseBase.TabStop = false;
            this.xbxUseBase.Text = "Use Base Name and Increment Numbers in [  ]";
            this.xbxUseBase.UseVisualStyleBackColor = true;
            this.xbxUseBase.CheckedChanged += new System.EventHandler(this.xbxUseBase_CheckedChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(288, 1044);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(6);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(236, 69);
            this.buttonReset.TabIndex = 65;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelLoggedIn
            // 
            this.labelLoggedIn.Location = new System.Drawing.Point(1118, 12);
            this.labelLoggedIn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLoggedIn.Name = "labelLoggedIn";
            this.labelLoggedIn.Size = new System.Drawing.Size(536, 44);
            this.labelLoggedIn.TabIndex = 64;
            this.labelLoggedIn.Text = "Enter course ID and press load to begin";
            // 
            // buttonSubmitPage
            // 
            this.buttonSubmitPage.Enabled = false;
            this.buttonSubmitPage.Location = new System.Drawing.Point(20, 1044);
            this.buttonSubmitPage.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSubmitPage.Name = "buttonSubmitPage";
            this.buttonSubmitPage.Size = new System.Drawing.Size(236, 69);
            this.buttonSubmitPage.TabIndex = 63;
            this.buttonSubmitPage.Text = "Submit";
            this.buttonSubmitPage.UseVisualStyleBackColor = true;
            this.buttonSubmitPage.Click += new System.EventHandler(this.buttonSubmitPage_Click);
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(1124, 67);
            this.rtbResults.Margin = new System.Windows.Forms.Padding(6);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.ReadOnly = true;
            this.rtbResults.Size = new System.Drawing.Size(532, 989);
            this.rtbResults.TabIndex = 62;
            this.rtbResults.TabStop = false;
            this.rtbResults.Text = "";
            // 
            // btnLoadCourse
            // 
            this.btnLoadCourse.Location = new System.Drawing.Point(6, 50);
            this.btnLoadCourse.Margin = new System.Windows.Forms.Padding(6);
            this.btnLoadCourse.Name = "btnLoadCourse";
            this.btnLoadCourse.Size = new System.Drawing.Size(346, 44);
            this.btnLoadCourse.TabIndex = 56;
            this.btnLoadCourse.Text = "Load Course Information";
            this.btnLoadCourse.UseVisualStyleBackColor = true;
            this.btnLoadCourse.Click += new System.EventHandler(this.btnLoadCourse_Click);
            // 
            // nudCourseID
            // 
            this.nudCourseID.Location = new System.Drawing.Point(126, 4);
            this.nudCourseID.Margin = new System.Windows.Forms.Padding(6);
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
            this.nudCourseID.TabIndex = 55;
            this.nudCourseID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCourseID.ValueChanged += new System.EventHandler(this.nudCourseID_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 25);
            this.label10.TabIndex = 61;
            this.label10.Text = "Page Base Name";
            // 
            // txbBaseName
            // 
            this.txbBaseName.Enabled = false;
            this.txbBaseName.Location = new System.Drawing.Point(568, 12);
            this.txbBaseName.Margin = new System.Windows.Forms.Padding(6);
            this.txbBaseName.Name = "txbBaseName";
            this.txbBaseName.Size = new System.Drawing.Size(520, 31);
            this.txbBaseName.TabIndex = 57;
            this.txbBaseName.TextChanged += new System.EventHandler(this.txbBaseName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(418, 67);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 25);
            this.label9.TabIndex = 60;
            this.label9.Text = "Page Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 59;
            this.label4.Text = "Course ID";
            // 
            // txbPageName
            // 
            this.txbPageName.Enabled = false;
            this.txbPageName.Location = new System.Drawing.Point(568, 62);
            this.txbPageName.Margin = new System.Windows.Forms.Padding(6);
            this.txbPageName.Name = "txbPageName";
            this.txbPageName.Size = new System.Drawing.Size(520, 31);
            this.txbPageName.TabIndex = 58;
            this.txbPageName.TextChanged += new System.EventHandler(this.txbPageName_TextChanged);
            // 
            // nudNumberOfAssign
            // 
            this.nudNumberOfAssign.Location = new System.Drawing.Point(922, 123);
            this.nudNumberOfAssign.Margin = new System.Windows.Forms.Padding(6);
            this.nudNumberOfAssign.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfAssign.Name = "nudNumberOfAssign";
            this.nudNumberOfAssign.Size = new System.Drawing.Size(92, 31);
            this.nudNumberOfAssign.TabIndex = 70;
            this.nudNumberOfAssign.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.radioButtonAnyone);
            this.groupBoxEdit.Controls.Add(this.radioButtonTeachandStu);
            this.groupBoxEdit.Controls.Add(this.radioButtonTeachers);
            this.groupBoxEdit.Controls.Add(this.label2);
            this.groupBoxEdit.Location = new System.Drawing.Point(6, 625);
            this.groupBoxEdit.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxEdit.Size = new System.Drawing.Size(400, 192);
            this.groupBoxEdit.TabIndex = 71;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit Page";
            // 
            // radioButtonAnyone
            // 
            this.radioButtonAnyone.AutoSize = true;
            this.radioButtonAnyone.Location = new System.Drawing.Point(18, 150);
            this.radioButtonAnyone.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonAnyone.Name = "radioButtonAnyone";
            this.radioButtonAnyone.Size = new System.Drawing.Size(116, 29);
            this.radioButtonAnyone.TabIndex = 3;
            this.radioButtonAnyone.TabStop = true;
            this.radioButtonAnyone.Text = "Anyone";
            this.radioButtonAnyone.UseVisualStyleBackColor = true;
            // 
            // radioButtonTeachandStu
            // 
            this.radioButtonTeachandStu.AutoSize = true;
            this.radioButtonTeachandStu.Location = new System.Drawing.Point(18, 106);
            this.radioButtonTeachandStu.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonTeachandStu.Name = "radioButtonTeachandStu";
            this.radioButtonTeachandStu.Size = new System.Drawing.Size(266, 29);
            this.radioButtonTeachandStu.TabIndex = 2;
            this.radioButtonTeachandStu.TabStop = true;
            this.radioButtonTeachandStu.Text = "Teachers and Students";
            this.radioButtonTeachandStu.UseVisualStyleBackColor = true;
            // 
            // radioButtonTeachers
            // 
            this.radioButtonTeachers.AutoSize = true;
            this.radioButtonTeachers.Location = new System.Drawing.Point(18, 62);
            this.radioButtonTeachers.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonTeachers.Name = "radioButtonTeachers";
            this.radioButtonTeachers.Size = new System.Drawing.Size(183, 29);
            this.radioButtonTeachers.TabIndex = 1;
            this.radioButtonTeachers.TabStop = true;
            this.radioButtonTeachers.Text = "Only Teachers";
            this.radioButtonTeachers.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Who can edit this page?";
            // 
            // checkBoxContentChange
            // 
            this.checkBoxContentChange.AutoSize = true;
            this.checkBoxContentChange.Location = new System.Drawing.Point(568, 648);
            this.checkBoxContentChange.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxContentChange.Name = "checkBoxContentChange";
            this.checkBoxContentChange.Size = new System.Drawing.Size(447, 29);
            this.checkBoxContentChange.TabIndex = 72;
            this.checkBoxContentChange.Text = "Notify users that this content has changed";
            this.checkBoxContentChange.UseVisualStyleBackColor = true;
            // 
            // checkBoxPagePublish
            // 
            this.checkBoxPagePublish.AutoSize = true;
            this.checkBoxPagePublish.Location = new System.Drawing.Point(12, 829);
            this.checkBoxPagePublish.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxPagePublish.Name = "checkBoxPagePublish";
            this.checkBoxPagePublish.Size = new System.Drawing.Size(288, 29);
            this.checkBoxPagePublish.TabIndex = 73;
            this.checkBoxPagePublish.Text = "Publish Page on Creation";
            this.checkBoxPagePublish.UseVisualStyleBackColor = true;
            // 
            // PagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1271);
            this.Controls.Add(this.checkBoxPagePublish);
            this.Controls.Add(this.checkBoxContentChange);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.nudNumberOfAssign);
            this.Controls.Add(this.rtbPageBody);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.xbxUseBase);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelLoggedIn);
            this.Controls.Add(this.buttonSubmitPage);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.btnLoadCourse);
            this.Controls.Add(this.nudCourseID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbBaseName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbPageName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PagesForm";
            this.Text = "Pages";
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfAssign)).EndInit();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPageBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox xbxUseBase;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelLoggedIn;
        private System.Windows.Forms.Button buttonSubmitPage;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Button btnLoadCourse;
        public System.Windows.Forms.NumericUpDown nudCourseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbBaseName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPageName;
        private System.Windows.Forms.NumericUpDown nudNumberOfAssign;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.RadioButton radioButtonAnyone;
        private System.Windows.Forms.RadioButton radioButtonTeachandStu;
        private System.Windows.Forms.RadioButton radioButtonTeachers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxContentChange;
        private System.Windows.Forms.CheckBox checkBoxPagePublish;
    }
}