namespace CanvasAPIApp
{
   partial class CanvasAPIMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CanvasAPIMainForm));
            this.apiMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAssignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradingQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getCurrentProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessTokenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mongoDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCanvasAPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCourses = new System.Windows.Forms.TabPage();
            this.tabPageAssign = new System.Windows.Forms.TabPage();
            this.tabPageQuiz = new System.Windows.Forms.TabPage();
            this.tabPagePages = new System.Windows.Forms.TabPage();
            this.tabPageModule = new System.Windows.Forms.TabPage();
            this.tabPageCalendar = new System.Windows.Forms.TabPage();
            this.tabPageGradingQueue = new System.Windows.Forms.TabPage();
            this.apiMenuStrip.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // apiMenuStrip
            // 
            this.apiMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.apiMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.apiMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.apiMenuStrip.Name = "apiMenuStrip";
            this.apiMenuStrip.Size = new System.Drawing.Size(984, 24);
            this.apiMenuStrip.TabIndex = 1;
            this.apiMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exitToolStripMenuItem.Text = "Exit Program";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAssignmentToolStripMenuItem,
            this.createQuizToolStripMenuItem,
            this.createPageToolStripMenuItem,
            this.createModuleToolStripMenuItem,
            this.gradingQueueToolStripMenuItem,
            this.getCurrentProfileToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // createAssignmentToolStripMenuItem
            // 
            this.createAssignmentToolStripMenuItem.Name = "createAssignmentToolStripMenuItem";
            this.createAssignmentToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.createAssignmentToolStripMenuItem.Text = "Create Assignment";
            this.createAssignmentToolStripMenuItem.Click += new System.EventHandler(this.createAssignmentToolStripMenuItem_Click);
            // 
            // createQuizToolStripMenuItem
            // 
            this.createQuizToolStripMenuItem.Name = "createQuizToolStripMenuItem";
            this.createQuizToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.createQuizToolStripMenuItem.ShowShortcutKeys = false;
            this.createQuizToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.createQuizToolStripMenuItem.Text = "Create Quiz";
            this.createQuizToolStripMenuItem.Click += new System.EventHandler(this.createQuizToolStripMenuItem_Click);
            // 
            // createPageToolStripMenuItem
            // 
            this.createPageToolStripMenuItem.Name = "createPageToolStripMenuItem";
            this.createPageToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.createPageToolStripMenuItem.Text = "Create Page";
            this.createPageToolStripMenuItem.Click += new System.EventHandler(this.createPageToolStripMenuItem_Click);
            // 
            // createModuleToolStripMenuItem
            // 
            this.createModuleToolStripMenuItem.Name = "createModuleToolStripMenuItem";
            this.createModuleToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.createModuleToolStripMenuItem.Text = "Create Module";
            this.createModuleToolStripMenuItem.Click += new System.EventHandler(this.createModuleToolStripMenuItem_Click);
            // 
            // gradingQueueToolStripMenuItem
            // 
            this.gradingQueueToolStripMenuItem.Name = "gradingQueueToolStripMenuItem";
            this.gradingQueueToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gradingQueueToolStripMenuItem.Text = "Grading Queue";
            this.gradingQueueToolStripMenuItem.Click += new System.EventHandler(this.gradingQueueToolStripMenuItem_Click);
            // 
            // getCurrentProfileToolStripMenuItem
            // 
            this.getCurrentProfileToolStripMenuItem.Name = "getCurrentProfileToolStripMenuItem";
            this.getCurrentProfileToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.getCurrentProfileToolStripMenuItem.Text = "Get Current Profile";
            this.getCurrentProfileToolStripMenuItem.Click += new System.EventHandler(this.getCurrentProfileToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accessTokenToolStripMenuItem1,
            this.dataSourcesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // accessTokenToolStripMenuItem1
            // 
            this.accessTokenToolStripMenuItem1.Name = "accessTokenToolStripMenuItem1";
            this.accessTokenToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.accessTokenToolStripMenuItem1.Text = "Instructure Access";
            this.accessTokenToolStripMenuItem1.Click += new System.EventHandler(this.accessTokenToolStripMenuItem1_Click);
            // 
            // dataSourcesToolStripMenuItem
            // 
            this.dataSourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mongoDBToolStripMenuItem});
            this.dataSourcesToolStripMenuItem.Name = "dataSourcesToolStripMenuItem";
            this.dataSourcesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.dataSourcesToolStripMenuItem.Text = "Data Sources";
            // 
            // mongoDBToolStripMenuItem
            // 
            this.mongoDBToolStripMenuItem.Name = "mongoDBToolStripMenuItem";
            this.mongoDBToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.mongoDBToolStripMenuItem.Text = "MongoDB";
            this.mongoDBToolStripMenuItem.Click += new System.EventHandler(this.mongoDBToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutCanvasAPIToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutCanvasAPIToolStripMenuItem
            // 
            this.aboutCanvasAPIToolStripMenuItem.Name = "aboutCanvasAPIToolStripMenuItem";
            this.aboutCanvasAPIToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.aboutCanvasAPIToolStripMenuItem.Text = "About Canvas API";
            this.aboutCanvasAPIToolStripMenuItem.Click += new System.EventHandler(this.aboutCanvasAPIToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageCourses);
            this.tabControlMain.Controls.Add(this.tabPageAssign);
            this.tabControlMain.Controls.Add(this.tabPageQuiz);
            this.tabControlMain.Controls.Add(this.tabPagePages);
            this.tabControlMain.Controls.Add(this.tabPageModule);
            this.tabControlMain.Controls.Add(this.tabPageCalendar);
            this.tabControlMain.Controls.Add(this.tabPageGradingQueue);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(984, 687);
            this.tabControlMain.TabIndex = 3;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageCourses
            // 
            this.tabPageCourses.Location = new System.Drawing.Point(4, 22);
            this.tabPageCourses.Name = "tabPageCourses";
            this.tabPageCourses.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageCourses.Size = new System.Drawing.Size(976, 661);
            this.tabPageCourses.TabIndex = 3;
            this.tabPageCourses.Text = "Courses";
            this.tabPageCourses.UseVisualStyleBackColor = true;
            // 
            // tabPageAssign
            // 
            this.tabPageAssign.Location = new System.Drawing.Point(4, 22);
            this.tabPageAssign.Name = "tabPageAssign";
            this.tabPageAssign.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageAssign.Size = new System.Drawing.Size(976, 714);
            this.tabPageAssign.TabIndex = 0;
            this.tabPageAssign.Text = "Assignments";
            this.tabPageAssign.UseVisualStyleBackColor = true;
            // 
            // tabPageQuiz
            // 
            this.tabPageQuiz.Location = new System.Drawing.Point(4, 22);
            this.tabPageQuiz.Name = "tabPageQuiz";
            this.tabPageQuiz.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageQuiz.Size = new System.Drawing.Size(976, 714);
            this.tabPageQuiz.TabIndex = 1;
            this.tabPageQuiz.Text = "Quizzes";
            this.tabPageQuiz.UseVisualStyleBackColor = true;
            // 
            // tabPagePages
            // 
            this.tabPagePages.Location = new System.Drawing.Point(4, 22);
            this.tabPagePages.Name = "tabPagePages";
            this.tabPagePages.Size = new System.Drawing.Size(976, 714);
            this.tabPagePages.TabIndex = 2;
            this.tabPagePages.Text = "Pages";
            this.tabPagePages.UseVisualStyleBackColor = true;
            // 
            // tabPageModule
            // 
            this.tabPageModule.Location = new System.Drawing.Point(4, 22);
            this.tabPageModule.Name = "tabPageModule";
            this.tabPageModule.Size = new System.Drawing.Size(976, 714);
            this.tabPageModule.TabIndex = 4;
            this.tabPageModule.Text = "Modules";
            this.tabPageModule.UseVisualStyleBackColor = true;
            // 
            // tabPageCalendar
            // 
            this.tabPageCalendar.Location = new System.Drawing.Point(4, 22);
            this.tabPageCalendar.Name = "tabPageCalendar";
            this.tabPageCalendar.Size = new System.Drawing.Size(976, 714);
            this.tabPageCalendar.TabIndex = 5;
            this.tabPageCalendar.Text = "Calendar";
            this.tabPageCalendar.UseVisualStyleBackColor = true;
            // 
            // tabPageGradingQueue
            // 
            this.tabPageGradingQueue.Location = new System.Drawing.Point(4, 22);
            this.tabPageGradingQueue.Name = "tabPageGradingQueue";
            this.tabPageGradingQueue.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageGradingQueue.Size = new System.Drawing.Size(976, 714);
            this.tabPageGradingQueue.TabIndex = 6;
            this.tabPageGradingQueue.Text = "Grading Queue";
            this.tabPageGradingQueue.UseVisualStyleBackColor = true;
            // 
            // CanvasAPIMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.apiMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.apiMenuStrip;
            this.Name = "CanvasAPIMainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Canvas API Form";
            this.Load += new System.EventHandler(this.CanvasAPIMainForm_Load);
            this.apiMenuStrip.ResumeLayout(false);
            this.apiMenuStrip.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip apiMenuStrip;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem createQuizToolStripMenuItem;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem accessTokenToolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem getCurrentProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutCanvasAPIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAssignmentToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageAssign;
        private System.Windows.Forms.TabPage tabPageQuiz;
        private System.Windows.Forms.TabPage tabPagePages;
        private System.Windows.Forms.ToolStripMenuItem createPageToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageCourses;
        private System.Windows.Forms.TabPage tabPageModule;
        private System.Windows.Forms.ToolStripMenuItem createModuleToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageCalendar;
        private System.Windows.Forms.TabPage tabPageGradingQueue;
        private System.Windows.Forms.ToolStripMenuItem gradingQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataSourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mongoDBToolStripMenuItem;
    }
}

