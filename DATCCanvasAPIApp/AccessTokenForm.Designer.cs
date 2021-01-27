namespace CanvasAPIApp
{
   partial class AccessTokenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessTokenForm));
            this.saveAccessToken = new System.Windows.Forms.Button();
            this.txbCurrentAccessToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbWebsite = new System.Windows.Forms.TextBox();
            this.btnSaveWebsite = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lbxCurrentUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkGetAccessTokenLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // saveAccessToken
            // 
            this.saveAccessToken.Location = new System.Drawing.Point(18, 242);
            this.saveAccessToken.Name = "saveAccessToken";
            this.saveAccessToken.Size = new System.Drawing.Size(136, 32);
            this.saveAccessToken.TabIndex = 1;
            this.saveAccessToken.Text = "Save Access Token";
            this.saveAccessToken.UseVisualStyleBackColor = true;
            this.saveAccessToken.Click += new System.EventHandler(this.saveAccessToken_Click);
            // 
            // txbCurrentAccessToken
            // 
            this.txbCurrentAccessToken.Location = new System.Drawing.Point(18, 212);
            this.txbCurrentAccessToken.Name = "txbCurrentAccessToken";
            this.txbCurrentAccessToken.Size = new System.Drawing.Size(532, 20);
            this.txbCurrentAccessToken.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Access Token";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Instructure Website";
            // 
            // txbWebsite
            // 
            this.txbWebsite.Location = new System.Drawing.Point(18, 103);
            this.txbWebsite.Name = "txbWebsite";
            this.txbWebsite.Size = new System.Drawing.Size(532, 20);
            this.txbWebsite.TabIndex = 6;
            // 
            // btnSaveWebsite
            // 
            this.btnSaveWebsite.Location = new System.Drawing.Point(18, 125);
            this.btnSaveWebsite.Name = "btnSaveWebsite";
            this.btnSaveWebsite.Size = new System.Drawing.Size(136, 34);
            this.btnSaveWebsite.TabIndex = 7;
            this.btnSaveWebsite.Text = "Save Website";
            this.btnSaveWebsite.UseVisualStyleBackColor = true;
            this.btnSaveWebsite.Click += new System.EventHandler(this.btnSaveWebsite_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(184, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 34);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.Location = new System.Drawing.Point(16, 30);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(104, 20);
            this.lblCurrentUser.TabIndex = 9;
            this.lblCurrentUser.Text = "Current User:";
            // 
            // lbxCurrentUser
            // 
            this.lbxCurrentUser.AutoSize = true;
            this.lbxCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCurrentUser.Location = new System.Drawing.Point(126, 30);
            this.lbxCurrentUser.Name = "lbxCurrentUser";
            this.lbxCurrentUser.Size = new System.Drawing.Size(125, 20);
            this.lbxCurrentUser.TabIndex = 11;
            this.lbxCurrentUser.Text = "No User Loaded";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(16, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "(example: https://your_domain.instructure.com)";
            // 
            // lnkGetAccessTokenLink
            // 
            this.lnkGetAccessTokenLink.AutoSize = true;
            this.lnkGetAccessTokenLink.Enabled = false;
            this.lnkGetAccessTokenLink.Location = new System.Drawing.Point(127, 187);
            this.lnkGetAccessTokenLink.Name = "lnkGetAccessTokenLink";
            this.lnkGetAccessTokenLink.Size = new System.Drawing.Size(0, 13);
            this.lnkGetAccessTokenLink.TabIndex = 12;
            this.lnkGetAccessTokenLink.Click += new System.EventHandler(this.lnkGetAccessTokenLink_Click);
            // 
            // AccessTokenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 295);
            this.Controls.Add(this.lnkGetAccessTokenLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxCurrentUser);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveWebsite);
            this.Controls.Add(this.txbWebsite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbCurrentAccessToken);
            this.Controls.Add(this.saveAccessToken);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccessTokenForm";
            this.Text = "Access Token";
            this.Shown += new System.EventHandler(this.AccessTokenForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Button saveAccessToken;
      private System.Windows.Forms.TextBox txbCurrentAccessToken;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txbWebsite;
        private System.Windows.Forms.Button btnSaveWebsite;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lbxCurrentUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkGetAccessTokenLink;
    }
}