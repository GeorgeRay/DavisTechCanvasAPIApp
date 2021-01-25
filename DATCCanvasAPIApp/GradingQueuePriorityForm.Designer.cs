
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Priorities will be set by identifying keywords.";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(312, 339);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(86, 31);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(404, 339);
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
            this.dgvPriority.Location = new System.Drawing.Point(12, 12);
            this.dgvPriority.Name = "dgvPriority";
            this.dgvPriority.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPriority.Size = new System.Drawing.Size(664, 253);
            this.dgvPriority.TabIndex = 11;
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
            // GradingQueuePriorityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 377);
            this.Controls.Add(this.dgvPriority);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label4);
            this.Name = "GradingQueuePriorityForm";
            this.Text = "Grading queue priority settings";
            this.Load += new System.EventHandler(this.GradingQueuePriorityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn keywordsColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn priorityColumn;
    }
}