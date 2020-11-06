using System;

namespace CanvasAPIApp
{
    internal class Assignment
    {
        public bool graded { get; set; }
        public int priority { get; set; }
        public string courseName { get; set; }
        public string assignment_name { get; set; }
        public DateTime submitted_at { get; set; }
        public string workflow_state { get; set; }
        public string speed_grader_url { get; set; }

        public Assignment(bool graded, int priority, string courseName, string assignment_name, DateTime submitted_at, string workflow_state, string speed_grader_url)
        {
            this.graded = graded;
            this.priority = priority;
            this.courseName = courseName;
            this.assignment_name = assignment_name;
            this.submitted_at = submitted_at;
            this.workflow_state = workflow_state;
            this.speed_grader_url = speed_grader_url;
        }
    }
}