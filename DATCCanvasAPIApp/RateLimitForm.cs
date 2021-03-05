using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanvasAPIApp
{
    public partial class RateLimitForm : Form
    {
        public RateLimitForm()
        {
            InitializeComponent();
        }

        private void RateLimitForm_Load(object sender, EventArgs e)
        {
            rateLimitChart.Series.FirstOrDefault().Points.Clear();


            foreach (RateLimitTracker.LimitCheck check in CanvasAPIMainForm.RateLimitTracker.LimitChecks)
            {
                rateLimitChart.Series.FirstOrDefault().Points.AddXY(check.Timestamp, check.LimitRemaining);
            }
        }
    }
}
