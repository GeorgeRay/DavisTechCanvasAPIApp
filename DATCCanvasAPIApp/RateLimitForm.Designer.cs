
namespace CanvasAPIApp
{
    partial class RateLimitForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.rateLimitChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.rateLimitChart)).BeginInit();
            this.SuspendLayout();
            // 
            // rateLimitChart
            // 
            chartArea1.Name = "ChartArea1";
            this.rateLimitChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.rateLimitChart.Legends.Add(legend1);
            this.rateLimitChart.Location = new System.Drawing.Point(104, 57);
            this.rateLimitChart.Name = "rateLimitChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.rateLimitChart.Series.Add(series1);
            this.rateLimitChart.Size = new System.Drawing.Size(440, 349);
            this.rateLimitChart.TabIndex = 0;
            this.rateLimitChart.Text = "chart1";
            // 
            // RateLimitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rateLimitChart);
            this.Name = "RateLimitForm";
            this.Text = "RateLimitForm";
            this.Load += new System.EventHandler(this.RateLimitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rateLimitChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart rateLimitChart;
    }
}