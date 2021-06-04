namespace CanvasAPIApp
{
   partial class QuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.txbQuizName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQuiz2Keep = new System.Windows.Forms.Label();
            this.lblShowCorrectAnswer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHideCorrectAnswers = new System.Windows.Forms.Label();
            this.rtbQuizInstructions = new System.Windows.Forms.RichTextBox();
            this.cbxQuizType = new System.Windows.Forms.ComboBox();
            this.xbxShuffle = new System.Windows.Forms.CheckBox();
            this.xbxTimeLimit = new System.Windows.Forms.CheckBox();
            this.gbxAttemps = new System.Windows.Forms.GroupBox();
            this.nudAttempts = new System.Windows.Forms.NumericUpDown();
            this.xbxLimitAttempts = new System.Windows.Forms.CheckBox();
            this.cbxScoreToKeep = new System.Windows.Forms.ComboBox();
            this.xbxAttempts = new System.Windows.Forms.CheckBox();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.gbxResponses = new System.Windows.Forms.GroupBox();
            this.dtpHideTime = new System.Windows.Forms.DateTimePicker();
            this.dtpShowTime = new System.Windows.Forms.DateTimePicker();
            this.dtpHide = new System.Windows.Forms.DateTimePicker();
            this.dtpShow = new System.Windows.Forms.DateTimePicker();
            this.xbxCorrectAnswersAfterLastAttempt = new System.Windows.Forms.CheckBox();
            this.xbxSeeCorrectAnswers = new System.Windows.Forms.CheckBox();
            this.xbxOnlyOnce = new System.Windows.Forms.CheckBox();
            this.xbxOnlyAfterLastAttempt = new System.Windows.Forms.CheckBox();
            this.xbxQuizResponses = new System.Windows.Forms.CheckBox();
            this.xbxIPAddresses = new System.Windows.Forms.CheckBox();
            this.xbxAccessCode = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.xbxRequireLockDownBrowsertoViewResuts = new System.Windows.Forms.CheckBox();
            this.xbxRequireLockDownBowser = new System.Windows.Forms.CheckBox();
            this.txbIPAddresses = new System.Windows.Forms.TextBox();
            this.txbAccessCode = new System.Windows.Forms.TextBox();
            this.lblIpAddresses = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xbxOneQuestionTime = new System.Windows.Forms.CheckBox();
            this.xbxLockQuestion = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmitQuiz = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ttCourseID = new System.Windows.Forms.ToolTip(this.components);
            this.xbxUseBase = new System.Windows.Forms.CheckBox();
            this.txbBaseName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.nudCourseID = new System.Windows.Forms.NumericUpDown();
            this.nudNumberOfQuiz = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAssignmentGroup = new System.Windows.Forms.Label();
            this.cbxAssignmentGroup = new System.Windows.Forms.ComboBox();
            this.xbxAnonymous = new System.Windows.Forms.CheckBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.nudScore = new System.Windows.Forms.NumericUpDown();
            this.btnLoadCourse = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.xbxPublish = new System.Windows.Forms.CheckBox();
            this.dtpDueDateTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpLockDateTime = new System.Windows.Forms.DateTimePicker();
            this.dtpLockDate = new System.Windows.Forms.DateTimePicker();
            this.lblLockDate = new System.Windows.Forms.Label();
            this.dtpUnlockDateTime = new System.Windows.Forms.DateTimePicker();
            this.dtpUnlockDate = new System.Windows.Forms.DateTimePicker();
            this.lblQuizUnlockDate = new System.Windows.Forms.Label();
            this.gbxAttemps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttempts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            this.gbxResponses.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfQuiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).BeginInit();
            this.SuspendLayout();
            // 
            // txbQuizName
            // 
            this.txbQuizName.Enabled = false;
            this.txbQuizName.Location = new System.Drawing.Point(568, 62);
            this.txbQuizName.Margin = new System.Windows.Forms.Padding(6);
            this.txbQuizName.Name = "txbQuizName";
            this.txbQuizName.Size = new System.Drawing.Size(520, 31);
            this.txbQuizName.TabIndex = 5;
            this.txbQuizName.TextChanged += new System.EventHandler(this.txbQuizName_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quiz Instructions (anything in [  ] will be replaced by Quiz Name at submit)";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quiz Type";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(312, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "Options";
            // 
            // lblQuiz2Keep
            // 
            this.lblQuiz2Keep.Location = new System.Drawing.Point(12, 90);
            this.lblQuiz2Keep.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblQuiz2Keep.Name = "lblQuiz2Keep";
            this.lblQuiz2Keep.Size = new System.Drawing.Size(150, 60);
            this.lblQuiz2Keep.TabIndex = 5;
            this.lblQuiz2Keep.Text = "Quiz Score to Keep";
            this.lblQuiz2Keep.Visible = false;
            // 
            // lblShowCorrectAnswer
            // 
            this.lblShowCorrectAnswer.Location = new System.Drawing.Point(32, 200);
            this.lblShowCorrectAnswer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShowCorrectAnswer.Name = "lblShowCorrectAnswer";
            this.lblShowCorrectAnswer.Size = new System.Drawing.Size(244, 35);
            this.lblShowCorrectAnswer.TabIndex = 4;
            this.lblShowCorrectAnswer.Text = "Show Correct Answers at";
            this.lblShowCorrectAnswer.Visible = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 494);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 38);
            this.label7.TabIndex = 7;
            this.label7.Text = "Responses";
            // 
            // lblHideCorrectAnswers
            // 
            this.lblHideCorrectAnswers.Location = new System.Drawing.Point(32, 277);
            this.lblHideCorrectAnswers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHideCorrectAnswers.Name = "lblHideCorrectAnswers";
            this.lblHideCorrectAnswers.Size = new System.Drawing.Size(244, 23);
            this.lblHideCorrectAnswers.TabIndex = 8;
            this.lblHideCorrectAnswers.Text = "Hide Correct Answers  at";
            this.lblHideCorrectAnswers.Visible = false;
            // 
            // rtbQuizInstructions
            // 
            this.rtbQuizInstructions.Location = new System.Drawing.Point(12, 200);
            this.rtbQuizInstructions.Margin = new System.Windows.Forms.Padding(6);
            this.rtbQuizInstructions.Name = "rtbQuizInstructions";
            this.rtbQuizInstructions.Size = new System.Drawing.Size(1080, 87);
            this.rtbQuizInstructions.TabIndex = 16;
            this.rtbQuizInstructions.TabStop = false;
            this.rtbQuizInstructions.Text = "";
            // 
            // cbxQuizType
            // 
            this.cbxQuizType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuizType.FormattingEnabled = true;
            this.cbxQuizType.Items.AddRange(new object[] {
            "Practice Quiz",
            "Graded Quiz",
            "Graded Survey",
            "Ungraded Survey"});
            this.cbxQuizType.Location = new System.Drawing.Point(6, 331);
            this.cbxQuizType.Margin = new System.Windows.Forms.Padding(6);
            this.cbxQuizType.Name = "cbxQuizType";
            this.cbxQuizType.Size = new System.Drawing.Size(238, 33);
            this.cbxQuizType.TabIndex = 6;
            this.cbxQuizType.TabStop = false;
            this.cbxQuizType.SelectedIndexChanged += new System.EventHandler(this.cbxQuizType_SelectedIndexChanged);
            // 
            // xbxShuffle
            // 
            this.xbxShuffle.AutoSize = true;
            this.xbxShuffle.Location = new System.Drawing.Point(308, 338);
            this.xbxShuffle.Margin = new System.Windows.Forms.Padding(6);
            this.xbxShuffle.Name = "xbxShuffle";
            this.xbxShuffle.Size = new System.Drawing.Size(199, 29);
            this.xbxShuffle.TabIndex = 9;
            this.xbxShuffle.TabStop = false;
            this.xbxShuffle.Text = "Shuffle Answers";
            this.xbxShuffle.UseVisualStyleBackColor = true;
            // 
            // xbxTimeLimit
            // 
            this.xbxTimeLimit.AutoSize = true;
            this.xbxTimeLimit.Location = new System.Drawing.Point(308, 387);
            this.xbxTimeLimit.Margin = new System.Windows.Forms.Padding(6);
            this.xbxTimeLimit.Name = "xbxTimeLimit";
            this.xbxTimeLimit.Size = new System.Drawing.Size(238, 29);
            this.xbxTimeLimit.TabIndex = 10;
            this.xbxTimeLimit.TabStop = false;
            this.xbxTimeLimit.Text = "Time Limit (Minutes)";
            this.xbxTimeLimit.UseVisualStyleBackColor = true;
            this.xbxTimeLimit.CheckedChanged += new System.EventHandler(this.xbxTimeLimit_CheckedChanged);
            // 
            // gbxAttemps
            // 
            this.gbxAttemps.Controls.Add(this.nudAttempts);
            this.gbxAttemps.Controls.Add(this.xbxLimitAttempts);
            this.gbxAttemps.Controls.Add(this.lblQuiz2Keep);
            this.gbxAttemps.Controls.Add(this.cbxScoreToKeep);
            this.gbxAttemps.Controls.Add(this.xbxAttempts);
            this.gbxAttemps.Location = new System.Drawing.Point(674, 302);
            this.gbxAttemps.Margin = new System.Windows.Forms.Padding(6);
            this.gbxAttemps.Name = "gbxAttemps";
            this.gbxAttemps.Padding = new System.Windows.Forms.Padding(6);
            this.gbxAttemps.Size = new System.Drawing.Size(440, 231);
            this.gbxAttemps.TabIndex = 21;
            this.gbxAttemps.TabStop = false;
            this.gbxAttemps.Text = "Attemps";
            // 
            // nudAttempts
            // 
            this.nudAttempts.Enabled = false;
            this.nudAttempts.Location = new System.Drawing.Point(318, 156);
            this.nudAttempts.Margin = new System.Windows.Forms.Padding(6);
            this.nudAttempts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAttempts.Name = "nudAttempts";
            this.nudAttempts.Size = new System.Drawing.Size(70, 31);
            this.nudAttempts.TabIndex = 2;
            this.nudAttempts.TabStop = false;
            this.nudAttempts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAttempts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAttempts.Visible = false;
            // 
            // xbxLimitAttempts
            // 
            this.xbxLimitAttempts.AutoSize = true;
            this.xbxLimitAttempts.Location = new System.Drawing.Point(120, 158);
            this.xbxLimitAttempts.Margin = new System.Windows.Forms.Padding(6);
            this.xbxLimitAttempts.Name = "xbxLimitAttempts";
            this.xbxLimitAttempts.Size = new System.Drawing.Size(179, 29);
            this.xbxLimitAttempts.TabIndex = 25;
            this.xbxLimitAttempts.TabStop = false;
            this.xbxLimitAttempts.Text = "Limit Attempts";
            this.xbxLimitAttempts.UseVisualStyleBackColor = true;
            this.xbxLimitAttempts.Visible = false;
            this.xbxLimitAttempts.CheckedChanged += new System.EventHandler(this.xbxAllowAttempts_CheckedChanged);
            // 
            // cbxScoreToKeep
            // 
            this.cbxScoreToKeep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxScoreToKeep.FormattingEnabled = true;
            this.cbxScoreToKeep.Items.AddRange(new object[] {
            "Highest",
            "Latest",
            "Average"});
            this.cbxScoreToKeep.Location = new System.Drawing.Point(174, 85);
            this.cbxScoreToKeep.Margin = new System.Windows.Forms.Padding(6);
            this.cbxScoreToKeep.Name = "cbxScoreToKeep";
            this.cbxScoreToKeep.Size = new System.Drawing.Size(210, 33);
            this.cbxScoreToKeep.TabIndex = 1;
            this.cbxScoreToKeep.TabStop = false;
            this.cbxScoreToKeep.Visible = false;
            // 
            // xbxAttempts
            // 
            this.xbxAttempts.AutoSize = true;
            this.xbxAttempts.Location = new System.Drawing.Point(34, 52);
            this.xbxAttempts.Margin = new System.Windows.Forms.Padding(6);
            this.xbxAttempts.Name = "xbxAttempts";
            this.xbxAttempts.Size = new System.Drawing.Size(266, 29);
            this.xbxAttempts.TabIndex = 0;
            this.xbxAttempts.TabStop = false;
            this.xbxAttempts.Text = "Allow Multiple Attempts";
            this.xbxAttempts.UseVisualStyleBackColor = true;
            this.xbxAttempts.CheckedChanged += new System.EventHandler(this.xbxAttempts_CheckedChanged);
            // 
            // nudMinutes
            // 
            this.nudMinutes.Enabled = false;
            this.nudMinutes.Location = new System.Drawing.Point(558, 387);
            this.nudMinutes.Margin = new System.Windows.Forms.Padding(6);
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(72, 31);
            this.nudMinutes.TabIndex = 22;
            this.nudMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbxResponses
            // 
            this.gbxResponses.Controls.Add(this.dtpHideTime);
            this.gbxResponses.Controls.Add(this.dtpShowTime);
            this.gbxResponses.Controls.Add(this.dtpHide);
            this.gbxResponses.Controls.Add(this.dtpShow);
            this.gbxResponses.Controls.Add(this.xbxCorrectAnswersAfterLastAttempt);
            this.gbxResponses.Controls.Add(this.xbxSeeCorrectAnswers);
            this.gbxResponses.Controls.Add(this.xbxOnlyOnce);
            this.gbxResponses.Controls.Add(this.xbxOnlyAfterLastAttempt);
            this.gbxResponses.Controls.Add(this.lblShowCorrectAnswer);
            this.gbxResponses.Controls.Add(this.lblHideCorrectAnswers);
            this.gbxResponses.Location = new System.Drawing.Point(12, 552);
            this.gbxResponses.Margin = new System.Windows.Forms.Padding(6);
            this.gbxResponses.Name = "gbxResponses";
            this.gbxResponses.Padding = new System.Windows.Forms.Padding(6);
            this.gbxResponses.Size = new System.Drawing.Size(650, 350);
            this.gbxResponses.TabIndex = 26;
            this.gbxResponses.TabStop = false;
            // 
            // dtpHideTime
            // 
            this.dtpHideTime.Enabled = false;
            this.dtpHideTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHideTime.Location = new System.Drawing.Point(442, 306);
            this.dtpHideTime.Margin = new System.Windows.Forms.Padding(6);
            this.dtpHideTime.Name = "dtpHideTime";
            this.dtpHideTime.ShowUpDown = true;
            this.dtpHideTime.Size = new System.Drawing.Size(192, 31);
            this.dtpHideTime.TabIndex = 8;
            this.dtpHideTime.TabStop = false;
            this.dtpHideTime.Value = new System.DateTime(2016, 10, 2, 23, 59, 0, 0);
            this.dtpHideTime.Visible = false;
            // 
            // dtpShowTime
            // 
            this.dtpShowTime.Enabled = false;
            this.dtpShowTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpShowTime.Location = new System.Drawing.Point(442, 231);
            this.dtpShowTime.Margin = new System.Windows.Forms.Padding(6);
            this.dtpShowTime.Name = "dtpShowTime";
            this.dtpShowTime.ShowUpDown = true;
            this.dtpShowTime.Size = new System.Drawing.Size(192, 31);
            this.dtpShowTime.TabIndex = 6;
            this.dtpShowTime.TabStop = false;
            this.dtpShowTime.Value = new System.DateTime(2016, 10, 2, 0, 0, 0, 0);
            this.dtpShowTime.Visible = false;
            // 
            // dtpHide
            // 
            this.dtpHide.Checked = false;
            this.dtpHide.Location = new System.Drawing.Point(12, 306);
            this.dtpHide.Margin = new System.Windows.Forms.Padding(6);
            this.dtpHide.Name = "dtpHide";
            this.dtpHide.ShowCheckBox = true;
            this.dtpHide.Size = new System.Drawing.Size(406, 31);
            this.dtpHide.TabIndex = 7;
            this.dtpHide.Visible = false;
            this.dtpHide.ValueChanged += new System.EventHandler(this.dtpHide_ValueChanged);
            // 
            // dtpShow
            // 
            this.dtpShow.Checked = false;
            this.dtpShow.Location = new System.Drawing.Point(12, 231);
            this.dtpShow.Margin = new System.Windows.Forms.Padding(6);
            this.dtpShow.Name = "dtpShow";
            this.dtpShow.ShowCheckBox = true;
            this.dtpShow.Size = new System.Drawing.Size(406, 31);
            this.dtpShow.TabIndex = 5;
            this.dtpShow.TabStop = false;
            this.dtpShow.Value = new System.DateTime(2016, 10, 11, 15, 20, 56, 0);
            this.dtpShow.Visible = false;
            this.dtpShow.ValueChanged += new System.EventHandler(this.dtpShow_ValueChanged);
            // 
            // xbxCorrectAnswersAfterLastAttempt
            // 
            this.xbxCorrectAnswersAfterLastAttempt.AutoSize = true;
            this.xbxCorrectAnswersAfterLastAttempt.Location = new System.Drawing.Point(32, 158);
            this.xbxCorrectAnswersAfterLastAttempt.Margin = new System.Windows.Forms.Padding(6);
            this.xbxCorrectAnswersAfterLastAttempt.Name = "xbxCorrectAnswersAfterLastAttempt";
            this.xbxCorrectAnswersAfterLastAttempt.Size = new System.Drawing.Size(488, 29);
            this.xbxCorrectAnswersAfterLastAttempt.TabIndex = 3;
            this.xbxCorrectAnswersAfterLastAttempt.TabStop = false;
            this.xbxCorrectAnswersAfterLastAttempt.Text = "Show Correct Answers Only After Last Attempt";
            this.xbxCorrectAnswersAfterLastAttempt.UseVisualStyleBackColor = true;
            this.xbxCorrectAnswersAfterLastAttempt.Visible = false;
            // 
            // xbxSeeCorrectAnswers
            // 
            this.xbxSeeCorrectAnswers.AutoSize = true;
            this.xbxSeeCorrectAnswers.Location = new System.Drawing.Point(12, 113);
            this.xbxSeeCorrectAnswers.Margin = new System.Windows.Forms.Padding(6);
            this.xbxSeeCorrectAnswers.Name = "xbxSeeCorrectAnswers";
            this.xbxSeeCorrectAnswers.Size = new System.Drawing.Size(405, 29);
            this.xbxSeeCorrectAnswers.TabIndex = 2;
            this.xbxSeeCorrectAnswers.TabStop = false;
            this.xbxSeeCorrectAnswers.Text = "Let Student See The Correct Answers";
            this.xbxSeeCorrectAnswers.UseVisualStyleBackColor = true;
            this.xbxSeeCorrectAnswers.Visible = false;
            this.xbxSeeCorrectAnswers.CheckedChanged += new System.EventHandler(this.xbxSeeCorrectAnswers_CheckedChanged);
            // 
            // xbxOnlyOnce
            // 
            this.xbxOnlyOnce.AutoSize = true;
            this.xbxOnlyOnce.Location = new System.Drawing.Point(12, 65);
            this.xbxOnlyOnce.Margin = new System.Windows.Forms.Padding(6);
            this.xbxOnlyOnce.Name = "xbxOnlyOnce";
            this.xbxOnlyOnce.Size = new System.Drawing.Size(330, 29);
            this.xbxOnlyOnce.TabIndex = 1;
            this.xbxOnlyOnce.TabStop = false;
            this.xbxOnlyOnce.Text = "Only Once After Each Attempt\r\n";
            this.xbxOnlyOnce.UseVisualStyleBackColor = true;
            this.xbxOnlyOnce.Visible = false;
            // 
            // xbxOnlyAfterLastAttempt
            // 
            this.xbxOnlyAfterLastAttempt.AutoSize = true;
            this.xbxOnlyAfterLastAttempt.Location = new System.Drawing.Point(12, 17);
            this.xbxOnlyAfterLastAttempt.Margin = new System.Windows.Forms.Padding(6);
            this.xbxOnlyAfterLastAttempt.Name = "xbxOnlyAfterLastAttempt";
            this.xbxOnlyAfterLastAttempt.Size = new System.Drawing.Size(438, 29);
            this.xbxOnlyAfterLastAttempt.TabIndex = 0;
            this.xbxOnlyAfterLastAttempt.TabStop = false;
            this.xbxOnlyAfterLastAttempt.Text = "Show Responses Only After Last Attempt";
            this.xbxOnlyAfterLastAttempt.UseVisualStyleBackColor = true;
            this.xbxOnlyAfterLastAttempt.Visible = false;
            // 
            // xbxQuizResponses
            // 
            this.xbxQuizResponses.AutoSize = true;
            this.xbxQuizResponses.Location = new System.Drawing.Point(24, 525);
            this.xbxQuizResponses.Margin = new System.Windows.Forms.Padding(6);
            this.xbxQuizResponses.Name = "xbxQuizResponses";
            this.xbxQuizResponses.Size = new System.Drawing.Size(428, 29);
            this.xbxQuizResponses.TabIndex = 14;
            this.xbxQuizResponses.TabStop = false;
            this.xbxQuizResponses.Text = "Let Students See Their Quiz Responses";
            this.xbxQuizResponses.UseVisualStyleBackColor = true;
            this.xbxQuizResponses.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // xbxIPAddresses
            // 
            this.xbxIPAddresses.AutoSize = true;
            this.xbxIPAddresses.Location = new System.Drawing.Point(12, 229);
            this.xbxIPAddresses.Margin = new System.Windows.Forms.Padding(6);
            this.xbxIPAddresses.Name = "xbxIPAddresses";
            this.xbxIPAddresses.Size = new System.Drawing.Size(225, 29);
            this.xbxIPAddresses.TabIndex = 2;
            this.xbxIPAddresses.TabStop = false;
            this.xbxIPAddresses.Text = "Filter IP Addresses";
            this.xbxIPAddresses.UseVisualStyleBackColor = true;
            this.xbxIPAddresses.CheckedChanged += new System.EventHandler(this.xbxIPAddresses_CheckedChanged);
            // 
            // xbxAccessCode
            // 
            this.xbxAccessCode.AutoSize = true;
            this.xbxAccessCode.Location = new System.Drawing.Point(12, 131);
            this.xbxAccessCode.Margin = new System.Windows.Forms.Padding(6);
            this.xbxAccessCode.Name = "xbxAccessCode";
            this.xbxAccessCode.Size = new System.Drawing.Size(276, 29);
            this.xbxAccessCode.TabIndex = 0;
            this.xbxAccessCode.TabStop = false;
            this.xbxAccessCode.Text = "Require an access code";
            this.xbxAccessCode.UseVisualStyleBackColor = true;
            this.xbxAccessCode.CheckedChanged += new System.EventHandler(this.xbxAccessCode_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.xbxRequireLockDownBrowsertoViewResuts);
            this.groupBox1.Controls.Add(this.xbxRequireLockDownBowser);
            this.groupBox1.Controls.Add(this.txbIPAddresses);
            this.groupBox1.Controls.Add(this.txbAccessCode);
            this.groupBox1.Controls.Add(this.xbxAccessCode);
            this.groupBox1.Controls.Add(this.xbxIPAddresses);
            this.groupBox1.Controls.Add(this.lblIpAddresses);
            this.groupBox1.Location = new System.Drawing.Point(674, 704);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(440, 448);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // xbxRequireLockDownBrowsertoViewResuts
            // 
            this.xbxRequireLockDownBrowsertoViewResuts.AutoSize = true;
            this.xbxRequireLockDownBrowsertoViewResuts.Checked = true;
            this.xbxRequireLockDownBrowsertoViewResuts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xbxRequireLockDownBrowsertoViewResuts.Location = new System.Drawing.Point(38, 69);
            this.xbxRequireLockDownBrowsertoViewResuts.Margin = new System.Windows.Forms.Padding(6);
            this.xbxRequireLockDownBrowsertoViewResuts.Name = "xbxRequireLockDownBrowsertoViewResuts";
            this.xbxRequireLockDownBrowsertoViewResuts.Size = new System.Drawing.Size(320, 29);
            this.xbxRequireLockDownBrowsertoViewResuts.TabIndex = 2;
            this.xbxRequireLockDownBrowsertoViewResuts.TabStop = false;
            this.xbxRequireLockDownBrowsertoViewResuts.Text = "Required to view quiz results";
            this.xbxRequireLockDownBrowsertoViewResuts.UseVisualStyleBackColor = true;
            this.xbxRequireLockDownBrowsertoViewResuts.Visible = false;
            // 
            // xbxRequireLockDownBowser
            // 
            this.xbxRequireLockDownBowser.AutoSize = true;
            this.xbxRequireLockDownBowser.Location = new System.Drawing.Point(12, 25);
            this.xbxRequireLockDownBowser.Margin = new System.Windows.Forms.Padding(6);
            this.xbxRequireLockDownBowser.Name = "xbxRequireLockDownBowser";
            this.xbxRequireLockDownBowser.Size = new System.Drawing.Size(424, 29);
            this.xbxRequireLockDownBowser.TabIndex = 2;
            this.xbxRequireLockDownBowser.TabStop = false;
            this.xbxRequireLockDownBowser.Text = "Require Respondus LockDown Browser";
            this.xbxRequireLockDownBowser.UseVisualStyleBackColor = true;
            this.xbxRequireLockDownBowser.CheckedChanged += new System.EventHandler(this.cbxRequireLockDownBowser_CheckedChanged);
            // 
            // txbIPAddresses
            // 
            this.txbIPAddresses.Location = new System.Drawing.Point(30, 277);
            this.txbIPAddresses.Margin = new System.Windows.Forms.Padding(6);
            this.txbIPAddresses.Name = "txbIPAddresses";
            this.txbIPAddresses.Size = new System.Drawing.Size(350, 31);
            this.txbIPAddresses.TabIndex = 3;
            this.txbIPAddresses.TabStop = false;
            this.txbIPAddresses.Visible = false;
            // 
            // txbAccessCode
            // 
            this.txbAccessCode.Location = new System.Drawing.Point(30, 179);
            this.txbAccessCode.Margin = new System.Windows.Forms.Padding(6);
            this.txbAccessCode.Name = "txbAccessCode";
            this.txbAccessCode.Size = new System.Drawing.Size(350, 31);
            this.txbAccessCode.TabIndex = 1;
            this.txbAccessCode.TabStop = false;
            this.txbAccessCode.Visible = false;
            // 
            // lblIpAddresses
            // 
            this.lblIpAddresses.Location = new System.Drawing.Point(14, 327);
            this.lblIpAddresses.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIpAddresses.Name = "lblIpAddresses";
            this.lblIpAddresses.Size = new System.Drawing.Size(372, 88);
            this.lblIpAddresses.TabIndex = 33;
            this.lblIpAddresses.Text = "Separate Addresses by commas.  Invalid IP adresses will return \"Bad Request\"";
            this.lblIpAddresses.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblIpAddresses.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.xbxOneQuestionTime);
            this.groupBox2.Controls.Add(this.xbxLockQuestion);
            this.groupBox2.Location = new System.Drawing.Point(674, 552);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(440, 140);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // xbxOneQuestionTime
            // 
            this.xbxOneQuestionTime.AutoSize = true;
            this.xbxOneQuestionTime.Location = new System.Drawing.Point(12, 37);
            this.xbxOneQuestionTime.Margin = new System.Windows.Forms.Padding(6);
            this.xbxOneQuestionTime.Name = "xbxOneQuestionTime";
            this.xbxOneQuestionTime.Size = new System.Drawing.Size(315, 29);
            this.xbxOneQuestionTime.TabIndex = 0;
            this.xbxOneQuestionTime.TabStop = false;
            this.xbxOneQuestionTime.Text = "Show one question at a time";
            this.xbxOneQuestionTime.UseVisualStyleBackColor = true;
            this.xbxOneQuestionTime.CheckedChanged += new System.EventHandler(this.xbxOneQuestionTime_CheckedChanged);
            // 
            // xbxLockQuestion
            // 
            this.xbxLockQuestion.AutoSize = true;
            this.xbxLockQuestion.Location = new System.Drawing.Point(42, 81);
            this.xbxLockQuestion.Margin = new System.Windows.Forms.Padding(6);
            this.xbxLockQuestion.Name = "xbxLockQuestion";
            this.xbxLockQuestion.Size = new System.Drawing.Size(342, 29);
            this.xbxLockQuestion.TabIndex = 1;
            this.xbxLockQuestion.TabStop = false;
            this.xbxLockQuestion.Text = "Lock questions after answering";
            this.xbxLockQuestion.UseVisualStyleBackColor = true;
            this.xbxLockQuestion.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(702, 698);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Quiz restrictions";
            // 
            // btnSubmitQuiz
            // 
            this.btnSubmitQuiz.Enabled = false;
            this.btnSubmitQuiz.Location = new System.Drawing.Point(24, 1175);
            this.btnSubmitQuiz.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmitQuiz.Name = "btnSubmitQuiz";
            this.btnSubmitQuiz.Size = new System.Drawing.Size(188, 50);
            this.btnSubmitQuiz.TabIndex = 15;
            this.btnSubmitQuiz.Text = "Submit";
            this.btnSubmitQuiz.UseVisualStyleBackColor = true;
            this.btnSubmitQuiz.Click += new System.EventHandler(this.btnSubmitQuiz_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(930, 1175);
            this.btnResetForm.Margin = new System.Windows.Forms.Padding(6);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(184, 50);
            this.btnResetForm.TabIndex = 16;
            this.btnResetForm.TabStop = false;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Course ID";
            this.ttCourseID.SetToolTip(this.label4, "Find course ID on URL when you are on the course page.  Course ID is a number.\r\n");
            // 
            // ttCourseID
            // 
            this.ttCourseID.ToolTipTitle = "Find Course ID";
            // 
            // xbxUseBase
            // 
            this.xbxUseBase.AutoSize = true;
            this.xbxUseBase.Checked = true;
            this.xbxUseBase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xbxUseBase.Location = new System.Drawing.Point(12, 123);
            this.xbxUseBase.Margin = new System.Windows.Forms.Padding(6);
            this.xbxUseBase.Name = "xbxUseBase";
            this.xbxUseBase.Size = new System.Drawing.Size(486, 29);
            this.xbxUseBase.TabIndex = 2;
            this.xbxUseBase.TabStop = false;
            this.xbxUseBase.Text = "Use Base Name and Increment Numbers in [  ]";
            this.ttCourseID.SetToolTip(this.xbxUseBase, "Check Use Base Name if after each submit you want the Quiz name to be the base na" +
        "me.");
            this.xbxUseBase.UseVisualStyleBackColor = true;
            this.xbxUseBase.CheckedChanged += new System.EventHandler(this.xbxUseBase_CheckedChanged);
            // 
            // txbBaseName
            // 
            this.txbBaseName.Enabled = false;
            this.txbBaseName.Location = new System.Drawing.Point(568, 12);
            this.txbBaseName.Margin = new System.Windows.Forms.Padding(6);
            this.txbBaseName.Name = "txbBaseName";
            this.txbBaseName.Size = new System.Drawing.Size(520, 31);
            this.txbBaseName.TabIndex = 3;
            this.ttCourseID.SetToolTip(this.txbBaseName, "Use []  to include number to increment");
            this.txbBaseName.TextChanged += new System.EventHandler(this.txbBaseName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.helpProvider1.SetHelpString(this.label10, "Help Me []");
            this.label10.Location = new System.Drawing.Point(386, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.helpProvider1.SetShowHelp(this.label10, true);
            this.label10.Size = new System.Drawing.Size(173, 25);
            this.label10.TabIndex = 38;
            this.label10.Text = "Quiz Base Name";
            this.ttCourseID.SetToolTip(this.label10, "Use []  to include number to increment");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(438, 67);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 36;
            this.label9.Text = "Quiz Name";
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(1126, 67);
            this.rtbResults.Margin = new System.Windows.Forms.Padding(6);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.ReadOnly = true;
            this.rtbResults.Size = new System.Drawing.Size(524, 929);
            this.rtbResults.TabIndex = 40;
            this.rtbResults.TabStop = false;
            this.rtbResults.Text = "";
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
            this.nudCourseID.TabIndex = 0;
            this.nudCourseID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCourseID.ValueChanged += new System.EventHandler(this.nudCourseID_ValueChanged);
            // 
            // nudNumberOfQuiz
            // 
            this.nudNumberOfQuiz.Location = new System.Drawing.Point(858, 121);
            this.nudNumberOfQuiz.Margin = new System.Windows.Forms.Padding(6);
            this.nudNumberOfQuiz.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfQuiz.Name = "nudNumberOfQuiz";
            this.nudNumberOfQuiz.Size = new System.Drawing.Size(92, 31);
            this.nudNumberOfQuiz.TabIndex = 4;
            this.nudNumberOfQuiz.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(514, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 37);
            this.label6.TabIndex = 42;
            this.label6.Text = "Select Number of Quizes to Make";
            // 
            // lblAssignmentGroup
            // 
            this.lblAssignmentGroup.Location = new System.Drawing.Point(0, 377);
            this.lblAssignmentGroup.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAssignmentGroup.Name = "lblAssignmentGroup";
            this.lblAssignmentGroup.Size = new System.Drawing.Size(248, 33);
            this.lblAssignmentGroup.TabIndex = 43;
            this.lblAssignmentGroup.Text = "Assignment groups";
            // 
            // cbxAssignmentGroup
            // 
            this.cbxAssignmentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAssignmentGroup.FormattingEnabled = true;
            this.cbxAssignmentGroup.Location = new System.Drawing.Point(6, 408);
            this.cbxAssignmentGroup.Margin = new System.Windows.Forms.Padding(6);
            this.cbxAssignmentGroup.Name = "cbxAssignmentGroup";
            this.cbxAssignmentGroup.Size = new System.Drawing.Size(238, 33);
            this.cbxAssignmentGroup.TabIndex = 7;
            this.cbxAssignmentGroup.TabStop = false;
            // 
            // xbxAnonymous
            // 
            this.xbxAnonymous.AutoSize = true;
            this.xbxAnonymous.Location = new System.Drawing.Point(308, 431);
            this.xbxAnonymous.Margin = new System.Windows.Forms.Padding(6);
            this.xbxAnonymous.Name = "xbxAnonymous";
            this.xbxAnonymous.Size = new System.Drawing.Size(347, 29);
            this.xbxAnonymous.TabIndex = 11;
            this.xbxAnonymous.TabStop = false;
            this.xbxAnonymous.Text = "Keep Submissions Anonymous ";
            this.xbxAnonymous.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(318, 485);
            this.lblScore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(160, 33);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "Score (Points)";
            this.lblScore.Visible = false;
            // 
            // nudScore
            // 
            this.nudScore.DecimalPlaces = 1;
            this.nudScore.InterceptArrowKeys = false;
            this.nudScore.Location = new System.Drawing.Point(494, 481);
            this.nudScore.Margin = new System.Windows.Forms.Padding(6);
            this.nudScore.Name = "nudScore";
            this.nudScore.Size = new System.Drawing.Size(136, 31);
            this.nudScore.TabIndex = 13;
            this.nudScore.TabStop = false;
            this.nudScore.Visible = false;
            // 
            // btnLoadCourse
            // 
            this.btnLoadCourse.Location = new System.Drawing.Point(6, 50);
            this.btnLoadCourse.Margin = new System.Windows.Forms.Padding(6);
            this.btnLoadCourse.Name = "btnLoadCourse";
            this.btnLoadCourse.Size = new System.Drawing.Size(346, 44);
            this.btnLoadCourse.TabIndex = 1;
            this.btnLoadCourse.Text = "Load Course Information";
            this.btnLoadCourse.UseVisualStyleBackColor = true;
            this.btnLoadCourse.Click += new System.EventHandler(this.btnLoadCourse_Click);
            // 
            // labelLoggedIn
            // 
            this.labelLoggedIn.Location = new System.Drawing.Point(1120, 12);
            this.labelLoggedIn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLoggedIn.Name = "labelLoggedIn";
            this.labelLoggedIn.Size = new System.Drawing.Size(582, 44);
            this.labelLoggedIn.TabIndex = 44;
            this.labelLoggedIn.Text = "Enter course ID and press load to begin";
            // 
            // xbxPublish
            // 
            this.xbxPublish.AutoSize = true;
            this.xbxPublish.Location = new System.Drawing.Point(24, 1131);
            this.xbxPublish.Margin = new System.Windows.Forms.Padding(6);
            this.xbxPublish.Name = "xbxPublish";
            this.xbxPublish.Size = new System.Drawing.Size(282, 29);
            this.xbxPublish.TabIndex = 45;
            this.xbxPublish.TabStop = false;
            this.xbxPublish.Text = "Publish Quiz on Creation";
            this.xbxPublish.UseVisualStyleBackColor = true;
            this.xbxPublish.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dtpDueDateTime
            // 
            this.dtpDueDateTime.Enabled = false;
            this.dtpDueDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDueDateTime.Location = new System.Drawing.Point(454, 938);
            this.dtpDueDateTime.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDueDateTime.Name = "dtpDueDateTime";
            this.dtpDueDateTime.ShowUpDown = true;
            this.dtpDueDateTime.Size = new System.Drawing.Size(192, 31);
            this.dtpDueDateTime.TabIndex = 48;
            this.dtpDueDateTime.TabStop = false;
            this.dtpDueDateTime.Value = new System.DateTime(2016, 10, 2, 23, 59, 0, 0);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Checked = false;
            this.dtpDueDate.Location = new System.Drawing.Point(24, 938);
            this.dtpDueDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.ShowCheckBox = true;
            this.dtpDueDate.Size = new System.Drawing.Size(406, 31);
            this.dtpDueDate.TabIndex = 47;
            this.dtpDueDate.TabStop = false;
            this.dtpDueDate.Value = new System.DateTime(2016, 10, 11, 15, 20, 56, 0);
            this.dtpDueDate.ValueChanged += new System.EventHandler(this.dtpDueDate_ValueChanged);
            // 
            // lblDueDate
            // 
            this.lblDueDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDueDate.Location = new System.Drawing.Point(18, 908);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(244, 35);
            this.lblDueDate.TabIndex = 46;
            this.lblDueDate.Text = "Due Date";
            // 
            // dtpLockDateTime
            // 
            this.dtpLockDateTime.Enabled = false;
            this.dtpLockDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpLockDateTime.Location = new System.Drawing.Point(454, 1081);
            this.dtpLockDateTime.Margin = new System.Windows.Forms.Padding(6);
            this.dtpLockDateTime.Name = "dtpLockDateTime";
            this.dtpLockDateTime.ShowUpDown = true;
            this.dtpLockDateTime.Size = new System.Drawing.Size(192, 31);
            this.dtpLockDateTime.TabIndex = 51;
            this.dtpLockDateTime.TabStop = false;
            this.dtpLockDateTime.Value = new System.DateTime(2016, 10, 2, 23, 59, 0, 0);
            // 
            // dtpLockDate
            // 
            this.dtpLockDate.Checked = false;
            this.dtpLockDate.Location = new System.Drawing.Point(24, 1081);
            this.dtpLockDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpLockDate.Name = "dtpLockDate";
            this.dtpLockDate.ShowCheckBox = true;
            this.dtpLockDate.Size = new System.Drawing.Size(406, 31);
            this.dtpLockDate.TabIndex = 50;
            this.dtpLockDate.TabStop = false;
            this.dtpLockDate.Value = new System.DateTime(2016, 10, 11, 15, 20, 56, 0);
            this.dtpLockDate.ValueChanged += new System.EventHandler(this.dtpLockDate_ValueChanged);
            // 
            // lblLockDate
            // 
            this.lblLockDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLockDate.Location = new System.Drawing.Point(18, 1050);
            this.lblLockDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLockDate.Name = "lblLockDate";
            this.lblLockDate.Size = new System.Drawing.Size(502, 35);
            this.lblLockDate.TabIndex = 49;
            this.lblLockDate.Text = "Lock Date";
            // 
            // dtpUnlockDateTime
            // 
            this.dtpUnlockDateTime.Enabled = false;
            this.dtpUnlockDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpUnlockDateTime.Location = new System.Drawing.Point(454, 1012);
            this.dtpUnlockDateTime.Margin = new System.Windows.Forms.Padding(6);
            this.dtpUnlockDateTime.Name = "dtpUnlockDateTime";
            this.dtpUnlockDateTime.ShowUpDown = true;
            this.dtpUnlockDateTime.Size = new System.Drawing.Size(192, 31);
            this.dtpUnlockDateTime.TabIndex = 54;
            this.dtpUnlockDateTime.TabStop = false;
            this.dtpUnlockDateTime.Value = new System.DateTime(2016, 10, 2, 23, 59, 0, 0);
            // 
            // dtpUnlockDate
            // 
            this.dtpUnlockDate.Checked = false;
            this.dtpUnlockDate.Location = new System.Drawing.Point(24, 1012);
            this.dtpUnlockDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpUnlockDate.Name = "dtpUnlockDate";
            this.dtpUnlockDate.ShowCheckBox = true;
            this.dtpUnlockDate.Size = new System.Drawing.Size(406, 31);
            this.dtpUnlockDate.TabIndex = 53;
            this.dtpUnlockDate.TabStop = false;
            this.dtpUnlockDate.Value = new System.DateTime(2016, 10, 11, 15, 20, 56, 0);
            this.dtpUnlockDate.ValueChanged += new System.EventHandler(this.dtpUnlockDate_ValueChanged);
            // 
            // lblQuizUnlockDate
            // 
            this.lblQuizUnlockDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblQuizUnlockDate.Location = new System.Drawing.Point(18, 981);
            this.lblQuizUnlockDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblQuizUnlockDate.Name = "lblQuizUnlockDate";
            this.lblQuizUnlockDate.Size = new System.Drawing.Size(502, 35);
            this.lblQuizUnlockDate.TabIndex = 52;
            this.lblQuizUnlockDate.Text = "Unlock Date";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1301);
            this.Controls.Add(this.dtpUnlockDateTime);
            this.Controls.Add(this.dtpUnlockDate);
            this.Controls.Add(this.lblQuizUnlockDate);
            this.Controls.Add(this.dtpLockDateTime);
            this.Controls.Add(this.dtpLockDate);
            this.Controls.Add(this.lblLockDate);
            this.Controls.Add(this.dtpDueDateTime);
            this.Controls.Add(this.labelLoggedIn);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.btnLoadCourse);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.nudScore);
            this.Controls.Add(this.xbxPublish);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.xbxAnonymous);
            this.Controls.Add(this.cbxAssignmentGroup);
            this.Controls.Add(this.lblAssignmentGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudNumberOfQuiz);
            this.Controls.Add(this.nudCourseID);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.xbxUseBase);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbBaseName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnSubmitQuiz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxResponses);
            this.Controls.Add(this.xbxQuizResponses);
            this.Controls.Add(this.nudMinutes);
            this.Controls.Add(this.gbxAttemps);
            this.Controls.Add(this.xbxTimeLimit);
            this.Controls.Add(this.xbxShuffle);
            this.Controls.Add(this.cbxQuizType);
            this.Controls.Add(this.rtbQuizInstructions);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbQuizName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "QuizForm";
            this.Text = "Create Quiz";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.gbxAttemps.ResumeLayout(false);
            this.gbxAttemps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttempts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            this.gbxResponses.ResumeLayout(false);
            this.gbxResponses.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfQuiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txbQuizName;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label lblQuiz2Keep;
      private System.Windows.Forms.Label lblShowCorrectAnswer;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label lblHideCorrectAnswers;
      private System.Windows.Forms.RichTextBox rtbQuizInstructions;
      private System.Windows.Forms.ComboBox cbxQuizType;
      private System.Windows.Forms.CheckBox xbxShuffle;
      private System.Windows.Forms.CheckBox xbxTimeLimit;
      private System.Windows.Forms.GroupBox gbxAttemps;
      private System.Windows.Forms.NumericUpDown nudMinutes;
      private System.Windows.Forms.CheckBox xbxAttempts;
      private System.Windows.Forms.NumericUpDown nudAttempts;
      private System.Windows.Forms.CheckBox xbxLimitAttempts;
      private System.Windows.Forms.ComboBox cbxScoreToKeep;
      private System.Windows.Forms.GroupBox gbxResponses;
      private System.Windows.Forms.CheckBox xbxOnlyAfterLastAttempt;
      private System.Windows.Forms.CheckBox xbxQuizResponses;
      private System.Windows.Forms.DateTimePicker dtpHide;
      private System.Windows.Forms.DateTimePicker dtpShow;
      private System.Windows.Forms.CheckBox xbxCorrectAnswersAfterLastAttempt;
      private System.Windows.Forms.CheckBox xbxSeeCorrectAnswers;
      private System.Windows.Forms.CheckBox xbxOnlyOnce;
      private System.Windows.Forms.CheckBox xbxIPAddresses;
      private System.Windows.Forms.CheckBox xbxAccessCode;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.CheckBox xbxOneQuestionTime;
      private System.Windows.Forms.CheckBox xbxLockQuestion;
      private System.Windows.Forms.TextBox txbAccessCode;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox txbIPAddresses;
      private System.Windows.Forms.Button btnSubmitQuiz;
      private System.Windows.Forms.Button btnResetForm;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ToolTip ttCourseID;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.TextBox txbBaseName;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.CheckBox xbxUseBase;
      private System.Windows.Forms.DateTimePicker dtpHideTime;
      private System.Windows.Forms.DateTimePicker dtpShowTime;
      private System.Windows.Forms.RichTextBox rtbResults;
      public System.Windows.Forms.NumericUpDown nudCourseID;
      private System.Windows.Forms.NumericUpDown nudNumberOfQuiz;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label lblAssignmentGroup;
      private System.Windows.Forms.ComboBox cbxAssignmentGroup;
      private System.Windows.Forms.CheckBox xbxAnonymous;
      private System.Windows.Forms.Label lblScore;
      private System.Windows.Forms.NumericUpDown nudScore;
      private System.Windows.Forms.Button btnLoadCourse;
      private System.Windows.Forms.Label lblIpAddresses;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.CheckBox xbxRequireLockDownBrowsertoViewResuts;
        private System.Windows.Forms.CheckBox xbxRequireLockDownBowser;
        private System.Windows.Forms.Label labelLoggedIn;
        private System.Windows.Forms.CheckBox xbxPublish;
        private System.Windows.Forms.DateTimePicker dtpDueDateTime;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpLockDateTime;
        private System.Windows.Forms.DateTimePicker dtpLockDate;
        private System.Windows.Forms.Label lblLockDate;
        private System.Windows.Forms.DateTimePicker dtpUnlockDateTime;
        private System.Windows.Forms.DateTimePicker dtpUnlockDate;
        private System.Windows.Forms.Label lblQuizUnlockDate;
    }
}