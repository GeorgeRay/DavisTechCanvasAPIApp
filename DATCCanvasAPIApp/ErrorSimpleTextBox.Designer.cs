namespace CanvasAPIApp
{
    partial class ErrorSimpleTextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpSimpleTextBox));
            this.rtbHelpOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbHelpOutput
            // 
            this.rtbHelpOutput.Location = new System.Drawing.Point(4, 5);
            this.rtbHelpOutput.Name = "rtbHelpOutput";
            this.rtbHelpOutput.ReadOnly = true;
            this.rtbHelpOutput.Size = new System.Drawing.Size(334, 316);
            this.rtbHelpOutput.TabIndex = 0;
            this.rtbHelpOutput.Text = "";
            // 
            // HelpSimpleTextBox
            // 
            this.ClientSize = new System.Drawing.Size(339, 320);
            this.Controls.Add(this.rtbHelpOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HelpSimpleTextBox";
            this.Load += new System.EventHandler(this.HelpSimpleTextBox_Load_1);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.RichTextBox rtbHelpOutput;
    }
}