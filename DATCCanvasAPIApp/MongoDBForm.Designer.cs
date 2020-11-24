namespace CanvasAPIApp
{
    partial class MongoDBForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MongoDBForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.TxbUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.TxbPassword = new System.Windows.Forms.TextBox();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbGradingCollecion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbConnection = new System.Windows.Forms.TextBox();
            this.btnParseConnection = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDefaultDatabase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(27, 352);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TxbUserName
            // 
            this.TxbUserName.Location = new System.Drawing.Point(146, 25);
            this.TxbUserName.Name = "TxbUserName";
            this.TxbUserName.Size = new System.Drawing.Size(214, 20);
            this.TxbUserName.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(83, 28);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "UserName";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(83, 54);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // TxbPassword
            // 
            this.TxbPassword.Location = new System.Drawing.Point(146, 54);
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.PasswordChar = '*';
            this.TxbPassword.Size = new System.Drawing.Size(214, 20);
            this.TxbPassword.TabIndex = 6;
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(12, 185);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(118, 13);
            this.lblConnectionString.TabIndex = 7;
            this.lblConnectionString.Text = "Collections in Database";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(27, 201);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(534, 81);
            this.rtbOutput.TabIndex = 8;
            this.rtbOutput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Grading Queue Collection";
            // 
            // TxbGradingCollecion
            // 
            this.TxbGradingCollecion.Location = new System.Drawing.Point(146, 303);
            this.TxbGradingCollecion.Name = "TxbGradingCollecion";
            this.TxbGradingCollecion.Size = new System.Drawing.Size(214, 20);
            this.TxbGradingCollecion.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Connection String";
            // 
            // txbConnection
            // 
            this.txbConnection.Location = new System.Drawing.Point(146, 114);
            this.txbConnection.Name = "txbConnection";
            this.txbConnection.Size = new System.Drawing.Size(419, 20);
            this.txbConnection.TabIndex = 12;
            // 
            // btnParseConnection
            // 
            this.btnParseConnection.Location = new System.Drawing.Point(15, 159);
            this.btnParseConnection.Name = "btnParseConnection";
            this.btnParseConnection.Size = new System.Drawing.Size(158, 23);
            this.btnParseConnection.TabIndex = 13;
            this.btnParseConnection.Text = "Parse Connecton String";
            this.btnParseConnection.UseVisualStyleBackColor = true;
            this.btnParseConnection.Click += new System.EventHandler(this.btnParseConnection_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Default Database";
            // 
            // txbDefaultDatabase
            // 
            this.txbDefaultDatabase.Location = new System.Drawing.Point(146, 84);
            this.txbDefaultDatabase.Name = "txbDefaultDatabase";
            this.txbDefaultDatabase.Size = new System.Drawing.Size(214, 20);
            this.txbDefaultDatabase.TabIndex = 15;
            // 
            // MongoDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 397);
            this.Controls.Add(this.txbDefaultDatabase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnParseConnection);
            this.Controls.Add(this.txbConnection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxbGradingCollecion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.lblConnectionString);
            this.Controls.Add(this.TxbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.TxbUserName);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MongoDBForm";
            this.Text = "MongoDB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckSaved);
            this.Load += new System.EventHandler(this.MongoDBForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox TxbUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox TxbPassword;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbGradingCollecion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbConnection;
        private System.Windows.Forms.Button btnParseConnection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDefaultDatabase;
    }
}