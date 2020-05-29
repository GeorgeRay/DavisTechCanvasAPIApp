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
            this.getCurrentProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessTokenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabGradingQueue = new System.Windows.Forms.TabPage();
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
            this.apiMenuStrip.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.apiMenuStrip.Size = new System.Drawing.Size(1968, 44);
            this.apiMenuStrip.TabIndex = 1;
            this.apiMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(248, 38);
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
            this.getCurrentProfileToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(92, 36);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // createAssignmentToolStripMenuItem
            // 
            this.createAssignmentToolStripMenuItem.Name = "createAssignmentToolStripMenuItem";
            this.createAssignmentToolStripMenuItem.Size = new System.Drawing.Size(315, 38);
            this.createAssignmentToolStripMenuItem.Text = "Create Assignment";
            this.createAssignmentToolStripMenuItem.Click += new System.EventHandler(this.createAssignmentToolStripMenuItem_Click);
            // 
            // createQuizToolStripMenuItem
            // 
            this.createQuizToolStripMenuItem.Name = "createQuizToolStripMenuItem";
            this.createQuizToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.createQuizToolStripMenuItem.ShowShortcutKeys = false;
            this.createQuizToolStripMenuItem.Size = new System.Drawing.Size(315, 38);
            this.createQuizToolStripMenuItem.Text = "Create Quiz";
            this.createQuizToolStripMenuItem.Click += new System.EventHandler(this.createQuizToolStripMenuItem_Click);
            // 
            // createPageToolStripMenuItem
            // 
            this.createPageToolStripMenuItem.Name = "createPageToolStripMenuItem";
            this.createPageToolStripMenuItem.Size = new System.Drawing.Size(315, 38);
            this.createPageToolStripMenuItem.Text = "Create Page";
            this.createPageToolStripMenuItem.Click += new System.EventHandler(this.createPageToolStripMenuItem_Click);
            // 
            // createModuleToolStripMenuItem
            // 
            this.createModuleToolStripMenuItem.Name = "createModuleToolStripMenuItem";
            this.createModuleToolStripMenuItem.Size = new System.Drawing.Size(315, 38);
            this.createModuleToolStripMenuItem.Text = "Create Module";
            this.createModuleToolStripMenuItem.Click += new System.EventHandler(this.createModuleToolStripMenuItem_Click);
            // 
            // getCurrentProfileToolStripMenuItem
            // 
            this.getCurrentProfileToolStripMenuItem.Name = "getCurrentProfileToolStripMenuItem";
            this.getCurrentProfileToolStripMenuItem.Size = new System.Drawing.Size(315, 38);
            this.getCurrentProfileToolStripMenuItem.Text = "Get Current Profile";
            this.getCurrentProfileToolStripMenuItem.Click += new System.EventHandler(this.getCurrentProfileToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accessTokenToolStripMenuItem1});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // accessTokenToolStripMenuItem1
            // 
            this.accessTokenToolStripMenuItem1.Name = "accessTokenToolStripMenuItem1";
            this.accessTokenToolStripMenuItem1.Size = new System.Drawing.Size(305, 38);
            this.accessTokenToolStripMenuItem1.Text = "Instructure Access";
            this.accessTokenToolStripMenuItem1.Click += new System.EventHandler(this.accessTokenToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutCanvasAPIToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutCanvasAPIToolStripMenuItem
            // 
            this.aboutCanvasAPIToolStripMenuItem.Name = "aboutCanvasAPIToolStripMenuItem";
            this.aboutCanvasAPIToolStripMenuItem.Size = new System.Drawing.Size(302, 38);
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
            this.tabControlMain.Controls.Add(this.tabGradingQueue);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 44);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1968, 1398);
            this.tabControlMain.TabIndex = 3;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageCourses
            // 
            this.tabPageCourses.Location = new System.Drawing.Point(8, 39);
            this.tabPageCourses.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageCourses.Name = "tabPageCourses";
            this.tabPageCourses.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageCourses.Size = new System.Drawing.Size(1952, 1351);
            this.tabPageCourses.TabIndex = 3;
            this.tabPageCourses.Text = "Courses";
            this.tabPageCourses.UseVisualStyleBackColor = true;
            // 
            // tabPageAssign
            // 
            this.tabPageAssign.Location = new System.Drawing.Point(8, 39);
            this.tabPageAssign.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageAssign.Name = "tabPageAssign";
            this.tabPageAssign.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageAssign.Size = new System.Drawing.Size(1952, 1351);
            this.tabPageAssign.TabIndex = 0;
            this.tabPageAssign.Text = "Assignments";
            this.tabPageAssign.UseVisualStyleBackColor = true;
            // 
            // tabPageQuiz
            // 
            this.tabPageQuiz.Location = new System.Drawing.Point(8, 39);
            this.tabPageQuiz.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageQuiz.Name = "tabPageQuiz";
            this.tabPageQuiz.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageQuiz.Size = new System.Drawing.Size(1952, 1351);
            this.tabPageQuiz.TabIndex = 1;
            this.tabPageQuiz.Text = "Quizzes";
            this.tabPageQuiz.UseVisualStyleBackColor = true;
            // 
            // tabPagePages
            // 
            this.tabPagePages.Location = new System.Drawing.Point(8, 39);
            this.tabPagePages.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPagePages.Name = "tabPagePages";
            this.tabPagePages.Size = new System.Drawing.Size(1952, 1351);
            this.tabPagePages.TabIndex = 2;
            this.tabPagePages.Text = "Pages";
            this.tabPagePages.UseVisualStyleBackColor = true;
            // 
            // tabPageModule
            // 
            this.tabPageModule.Location = new System.Drawing.Point(8, 39);
            this.tabPageModule.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageModule.Name = "tabPageModule";
            this.tabPageModule.Size = new System.Drawing.Size(1952, 1351);
            this.tabPageModule.TabIndex = 4;
            this.tabPageModule.Text = "Modules";
            this.tabPageModule.UseVisualStyleBackColor = true;
            // 
            // tabPageCalendar
            // 
            this.tabPageCalendar.Location = new System.Drawing.Point(8, 39);
            this.tabPageCalendar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageCalendar.Name = "tabPageCalendar";
            this.tabPageCalendar.Size = new System.Drawing.Size(1952, 1351);
            this.tabPageCalendar.TabIndex = 5;
            this.tabPageCalendar.Text = "Calendar";
            this.tabPageCalendar.UseVisualStyleBackColor = true;
            // 
            // tabGradingQueue
            // 
            this.tabGradingQueue.Location = new System.Drawing.Point(8, 39);
            this.tabGradingQueue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabGradingQueue.Name = "tabGradingQueue";
            this.tabGradingQueue.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabGradingQueue.Size = new System.Drawing.Size(1952, 1351);
            this.tabGradingQueue.TabIndex = 6;
            this.tabGradingQueue.Text = "Grading Queue";
            this.tabGradingQueue.UseVisualStyleBackColor = true;
            // 
            // CanvasAPIMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1968, 1442);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.apiMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.apiMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CanvasAPIMainForm";
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
        private System.Windows.Forms.TabPage tabGradingQueue;
    }
}

