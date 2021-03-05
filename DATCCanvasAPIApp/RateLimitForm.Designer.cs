
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RateLimitForm));
            this.rateLimitChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rateLimitChart)).BeginInit();
            this.SuspendLayout();
            // 
            // rateLimitChart
            // 
            chartArea3.Name = "ChartArea1";
            this.rateLimitChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.rateLimitChart.Legends.Add(legend3);
            this.rateLimitChart.Location = new System.Drawing.Point(12, 12);
            this.rateLimitChart.Name = "rateLimitChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Requests remaining";
            series3.Points.Add(dataPoint3);
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.rateLimitChart.Series.Add(series3);
            this.rateLimitChart.Size = new System.Drawing.Size(776, 349);
            this.rateLimitChart.TabIndex = 0;
            this.rateLimitChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(779, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // RateLimitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rateLimitChart);
            this.Name = "RateLimitForm";
            this.Text = "Rate Limits";
            this.Load += new System.EventHandler(this.RateLimitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rateLimitChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart rateLimitChart;
        private System.Windows.Forms.Label label1;
    }
}