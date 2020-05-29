namespace CanvasAPIApp
{
    partial class CoursesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoursesForm));
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.courseDataGridView = new System.Windows.Forms.DataGridView();
            this.selectedCourse = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.courseStudentsGrid = new System.Windows.Forms.DataGridView();
            this.enrolledStudentsSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.removeFromCourse = new System.Windows.Forms.Button();
            this.addToCourse = new System.Windows.Forms.Button();
            this.allStudentsGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.accountStudentsSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoadCourses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseStudentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allStudentsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLoggedIn
            // 
            this.labelLoggedIn.AutoSize = true;
            this.labelLoggedIn.Location = new System.Drawing.Point(12, 9);
            this.labelLoggedIn.Name = "labelLoggedIn";
            this.labelLoggedIn.Size = new System.Drawing.Size(103, 13);
            this.labelLoggedIn.TabIndex = 3;
            this.labelLoggedIn.Text = "Showing courses for";
            // 
            // courseDataGridView
            // 
            this.courseDataGridView.AllowUserToAddRows = false;
            this.courseDataGridView.AllowUserToDeleteRows = false;
            this.courseDataGridView.AllowUserToOrderColumns = true;
            this.courseDataGridView.AllowUserToResizeColumns = false;
            this.courseDataGridView.AllowUserToResizeRows = false;
            this.courseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.courseDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.courseDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.courseDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.courseDataGridView.GridColor = System.Drawing.Color.White;
            this.courseDataGridView.Location = new System.Drawing.Point(15, 35);
            this.courseDataGridView.MultiSelect = false;
            this.courseDataGridView.Name = "courseDataGridView";
            this.courseDataGridView.RowHeadersVisible = false;
            this.courseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseDataGridView.Size = new System.Drawing.Size(615, 614);
            this.courseDataGridView.TabIndex = 4;
            this.courseDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseDataGridView_CellClick);
            // 
            // selectedCourse
            // 
            this.selectedCourse.AutoSize = true;
            this.selectedCourse.Location = new System.Drawing.Point(250, 9);
            this.selectedCourse.Name = "selectedCourse";
            this.selectedCourse.Size = new System.Drawing.Size(88, 13);
            this.selectedCourse.TabIndex = 5;
            this.selectedCourse.Text = "Selected Course ";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(530, 6);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 6;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(483, 9);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(41, 13);
            this.searchLbl.TabIndex = 7;
            this.searchLbl.Text = "Search";
            // 
            // courseStudentsGrid
            // 
            this.courseStudentsGrid.AllowUserToAddRows = false;
            this.courseStudentsGrid.AllowUserToDeleteRows = false;
            this.courseStudentsGrid.AllowUserToOrderColumns = true;
            this.courseStudentsGrid.AllowUserToResizeColumns = false;
            this.courseStudentsGrid.AllowUserToResizeRows = false;
            this.courseStudentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseStudentsGrid.BackgroundColor = System.Drawing.Color.White;
            this.courseStudentsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.courseStudentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.courseStudentsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.courseStudentsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.courseStudentsGrid.GridColor = System.Drawing.Color.White;
            this.courseStudentsGrid.Location = new System.Drawing.Point(636, 64);
            this.courseStudentsGrid.MultiSelect = false;
            this.courseStudentsGrid.Name = "courseStudentsGrid";
            this.courseStudentsGrid.RowHeadersVisible = false;
            this.courseStudentsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseStudentsGrid.Size = new System.Drawing.Size(312, 253);
            this.courseStudentsGrid.TabIndex = 9;
            this.courseStudentsGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.courseStudentsGrid_CellMouseClick);
            // 
            // enrolledStudentsSearch
            // 
            this.enrolledStudentsSearch.Location = new System.Drawing.Point(847, 38);
            this.enrolledStudentsSearch.Name = "enrolledStudentsSearch";
            this.enrolledStudentsSearch.Size = new System.Drawing.Size(100, 20);
            this.enrolledStudentsSearch.TabIndex = 11;
            this.enrolledStudentsSearch.TextChanged += new System.EventHandler(this.enrolledStudentsSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(800, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search";
            // 
            // removeFromCourse
            // 
            this.removeFromCourse.Enabled = false;
            this.removeFromCourse.Location = new System.Drawing.Point(636, 38);
            this.removeFromCourse.Name = "removeFromCourse";
            this.removeFromCourse.Size = new System.Drawing.Size(75, 23);
            this.removeFromCourse.TabIndex = 15;
            this.removeFromCourse.Text = "Conclude";
            this.removeFromCourse.UseVisualStyleBackColor = true;
            this.removeFromCourse.Click += new System.EventHandler(this.removeFromCourse_Click);
            // 
            // addToCourse
            // 
            this.addToCourse.Enabled = false;
            this.addToCourse.Location = new System.Drawing.Point(636, 346);
            this.addToCourse.Name = "addToCourse";
            this.addToCourse.Size = new System.Drawing.Size(75, 23);
            this.addToCourse.TabIndex = 16;
            this.addToCourse.Text = "Invite";
            this.addToCourse.UseVisualStyleBackColor = true;
            this.addToCourse.Click += new System.EventHandler(this.addToCourse_Click);
            // 
            // allStudentsGrid
            // 
            this.allStudentsGrid.AllowUserToAddRows = false;
            this.allStudentsGrid.AllowUserToDeleteRows = false;
            this.allStudentsGrid.AllowUserToOrderColumns = true;
            this.allStudentsGrid.AllowUserToResizeColumns = false;
            this.allStudentsGrid.AllowUserToResizeRows = false;
            this.allStudentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allStudentsGrid.BackgroundColor = System.Drawing.Color.White;
            this.allStudentsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.allStudentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allStudentsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.allStudentsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.allStudentsGrid.GridColor = System.Drawing.Color.White;
            this.allStudentsGrid.Location = new System.Drawing.Point(636, 374);
            this.allStudentsGrid.MultiSelect = false;
            this.allStudentsGrid.Name = "allStudentsGrid";
            this.allStudentsGrid.RowHeadersVisible = false;
            this.allStudentsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allStudentsGrid.Size = new System.Drawing.Size(312, 275);
            this.allStudentsGrid.TabIndex = 10;
            this.allStudentsGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.accountStudentsGrid_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(800, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search";
            // 
            // accountStudentsSearch
            // 
            this.accountStudentsSearch.Location = new System.Drawing.Point(847, 349);
            this.accountStudentsSearch.Name = "accountStudentsSearch";
            this.accountStudentsSearch.Size = new System.Drawing.Size(100, 20);
            this.accountStudentsSearch.TabIndex = 12;
            this.accountStudentsSearch.TextChanged += new System.EventHandler(this.accountStudentsSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(713, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Students in Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(735, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "All Students";
            // 
            // btnLoadCourses
            // 
            this.btnLoadCourses.Location = new System.Drawing.Point(24, 661);
            this.btnLoadCourses.Name = "btnLoadCourses";
            this.btnLoadCourses.Size = new System.Drawing.Size(91, 26);
            this.btnLoadCourses.TabIndex = 19;
            this.btnLoadCourses.Text = "Load Courses";
            this.btnLoadCourses.UseVisualStyleBackColor = true;
            this.btnLoadCourses.Click += new System.EventHandler(this.btnLoadCourses_Click);
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 699);
            this.Controls.Add(this.btnLoadCourses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addToCourse);
            this.Controls.Add(this.removeFromCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountStudentsSearch);
            this.Controls.Add(this.enrolledStudentsSearch);
            this.Controls.Add(this.allStudentsGrid);
            this.Controls.Add(this.courseStudentsGrid);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.selectedCourse);
            this.Controls.Add(this.courseDataGridView);
            this.Controls.Add(this.labelLoggedIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoursesForm";
            this.Text = "Your Courses";
            this.Load += new System.EventHandler(this.CoursesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseStudentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allStudentsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLoggedIn;
        private System.Windows.Forms.DataGridView courseDataGridView;
        private System.Windows.Forms.Label selectedCourse;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.DataGridView courseStudentsGrid;
        private System.Windows.Forms.TextBox enrolledStudentsSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeFromCourse;
        private System.Windows.Forms.Button addToCourse;
        private System.Windows.Forms.DataGridView allStudentsGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accountStudentsSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoadCourses;
    }
}