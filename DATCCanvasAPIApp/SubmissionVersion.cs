using System;

namespace CanvasAPIApp
{
    class SubmissionVersion
    {
        public DateTime Submitted_at { get; set; }
        public dynamic Assignment_id { get; set; }
        public dynamic Workflow_state { get; set; }
        public dynamic Graded_at { get; set; }
        public dynamic Posted_at { get; set; }
        public dynamic Preview_url { get; set; }
        public dynamic Grader { get; set; }
        public dynamic Assignment_name { get; set; }
        public dynamic Current_graded_at { get; set; }
        public dynamic Current_grader { get; set; }

        public SubmissionVersion(DateTime submitted_at, dynamic assignment_id, dynamic workflow_state, dynamic graded_at, dynamic posted_at, dynamic preview_url, dynamic grader, dynamic assignment_name, dynamic current_graded_at, dynamic current_grader)
        {
            this.Submitted_at = submitted_at;
            this.Assignment_id = assignment_id;
            this.Workflow_state = workflow_state;
            this.Graded_at = graded_at;
            this.Posted_at = posted_at;
            this.Preview_url = preview_url;
            this.Grader = grader;
            this.Assignment_name = assignment_name;
            this.Current_graded_at = current_graded_at;
            this.Current_grader = current_grader;
        }
    }
}
