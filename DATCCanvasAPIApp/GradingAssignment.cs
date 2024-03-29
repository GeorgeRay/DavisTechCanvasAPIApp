﻿using System;

namespace CanvasAPIApp
{
    internal class GradingAssignment
    {
        public bool reserved { get; set; }
        public string[] user_name { get; set; }
        public int priority { get; set; }
        public bool alert { get; set; }
        public string courseName { get; set; }
        public string assignment_name { get; set; }
        public DateTime submitted_at { get; set; }
        public string workflow_state { get; set; }
        public string speed_grader_url { get; set; }
        public string grades_url { get; private set; }

        public GradingAssignment(bool reserved, string user_name, int priority, bool alert, string courseName, string assignment_name, DateTime submitted_at, string workflow_state, string speed_grader_url, string grades_url)
        {
            this.reserved = reserved;
            this.user_name = user_name.Trim().Split(' ');
            this.priority = priority;
            this.alert = alert;
            this.courseName = courseName;
            this.assignment_name = assignment_name;
            this.submitted_at = submitted_at;
            this.workflow_state = workflow_state;
            this.speed_grader_url = speed_grader_url;
            this.grades_url = grades_url;



        }
    }
}