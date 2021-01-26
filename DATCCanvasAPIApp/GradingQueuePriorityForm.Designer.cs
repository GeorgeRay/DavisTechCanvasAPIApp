
namespace CanvasAPIApp
{
    partial class GradingQueuePriorityForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvPriority = new System.Windows.Forms.DataGridView();
            this.keywordsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.priorityMenuStrip = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultPriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDefaultPriority = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriority)).BeginInit();
            this.priorityMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(434, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Priorities will be set by identifying keywords, with the lowest numbers being the" +
    " most urgent.";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(257, 334);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(86, 31);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(349, 334);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 31);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvPriority
            // 
            this.dgvPriority.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPriority.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPriority.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keywordsColumn,
            this.priorityColumn});
            this.dgvPriority.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPriority.Location = new System.Drawing.Point(12, 27);
            this.dgvPriority.Name = "dgvPriority";
            this.dgvPriority.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPriority.Size = new System.Drawing.Size(664, 253);
            this.dgvPriority.TabIndex = 11;
            this.dgvPriority.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPriority_CellClick);
            // 
            // keywordsColumn
            // 
            this.keywordsColumn.FillWeight = 85F;
            this.keywordsColumn.HeaderText = "Keywords";
            this.keywordsColumn.Name = "keywordsColumn";
            // 
            // priorityColumn
            // 
            this.priorityColumn.FillWeight = 15F;
            this.priorityColumn.HeaderText = "Priority";
            this.priorityColumn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.priorityColumn.Name = "priorityColumn";
            this.priorityColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(585, 286);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(91, 23);
            this.btnDeleteSelected.TabIndex = 12;
            this.btnDeleteSelected.Text = "Delete selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // priorityMenuStrip
            // 
            this.priorityMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.priorityMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.priorityMenuStrip.Name = "priorityMenuStrip";
            this.priorityMenuStrip.Size = new System.Drawing.Size(688, 24);
            this.priorityMenuStrip.TabIndex = 13;
            this.priorityMenuStrip.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDefaultPriorityToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // setDefaultPriorityToolStripMenuItem
            // 
            this.setDefaultPriorityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDefaultPriority});
            this.setDefaultPriorityToolStripMenuItem.Name = "setDefaultPriorityToolStripMenuItem";
            this.setDefaultPriorityToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.setDefaultPriorityToolStripMenuItem.Text = "Unset/default priority";
            // 
            // menuItemDefaultPriority
            // 
            this.menuItemDefaultPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuItemDefaultPriority.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.menuItemDefaultPriority.Name = "menuItemDefaultPriority";
            this.menuItemDefaultPriority.Size = new System.Drawing.Size(121, 23);
            this.menuItemDefaultPriority.SelectedIndexChanged += new System.EventHandler(this.menuItemDefaultPriority_SelectedIndexChanged);
            // 
            // GradingQueuePriorityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 377);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.dgvPriority);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priorityMenuStrip);
            this.MainMenuStrip = this.priorityMenuStrip;
            this.Name = "GradingQueuePriorityForm";
            this.Text = "Grading queue priority settings";
            this.Load += new System.EventHandler(this.GradingQueuePriorityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriority)).EndInit();
            this.priorityMenuStrip.ResumeLayout(false);
            this.priorityMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvPriority;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn keywordsColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn priorityColumn;
        private System.Windows.Forms.MenuStrip priorityMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDefaultPriorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox menuItemDefaultPriority;
    }
}