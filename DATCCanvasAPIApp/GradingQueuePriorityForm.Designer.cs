
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
            this.alert = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmbPriority = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(495, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Priorities will be set by identifying keywords or course ID, with the lowest numb" +
    "ers being the most urgent.";
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(261, 385);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(86, 31);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(353, 385);
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
            this.priorityColumn,
            this.alert});
            this.dgvPriority.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPriority.Location = new System.Drawing.Point(12, 27);
            this.dgvPriority.Name = "dgvPriority";
            this.dgvPriority.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPriority.Size = new System.Drawing.Size(664, 253);
            this.dgvPriority.TabIndex = 11;
            this.dgvPriority.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPriority_CellClick);
            this.dgvPriority.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPriority_RowsAdded);
            // 
            // keywordsColumn
            // 
            this.keywordsColumn.FillWeight = 124.2674F;
            this.keywordsColumn.HeaderText = "Keywords";
            this.keywordsColumn.Name = "keywordsColumn";
            // 
            // priorityColumn
            // 
            this.priorityColumn.FillWeight = 21.92955F;
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
            // alert
            // 
            this.alert.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.alert.FillWeight = 1F;
            this.alert.HeaderText = "Alert";
            this.alert.Name = "alert";
            this.alert.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.alert.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.alert.Width = 53;
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelected.Location = new System.Drawing.Point(12, 286);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(91, 41);
            this.btnDeleteSelected.TabIndex = 12;
            this.btnDeleteSelected.Text = "Delete selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Default priority:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Will be applied to all assignments not specified here.";
            // 
            // nmbPriority
            // 
            this.nmbPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbPriority.Location = new System.Drawing.Point(614, 298);
            this.nmbPriority.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nmbPriority.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmbPriority.Name = "nmbPriority";
            this.nmbPriority.Size = new System.Drawing.Size(62, 21);
            this.nmbPriority.TabIndex = 15;
            this.nmbPriority.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmbPriority.ValueChanged += new System.EventHandler(this.nmbPriority_ValueChanged);
            // 
            // GradingQueuePriorityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 428);
            this.Controls.Add(this.nmbPriority);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.dgvPriority);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label4);
            this.Name = "GradingQueuePriorityForm";
            this.Text = "Grading queue priority settings";
            this.Load += new System.EventHandler(this.GradingQueuePriorityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbPriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvPriority;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmbPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn keywordsColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn priorityColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn alert;
    }
}