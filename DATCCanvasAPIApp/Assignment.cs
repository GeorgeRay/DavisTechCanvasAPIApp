using System;

namespace CanvasAPIApp
{
    class Assignment
    {
        public string name { get; set; }
        public string position { get; set; }
        public string[] submission_types { get; set; }
        public string[] allowed_extensions { get; set; }
        public bool turnitin_enabled { get; set; }
        public bool vericite_enabled { get; set; }
        public string turinitin_settings { get; set; }
        public string integration_data { get; set; }
        public string integration_id { get; set; }
        public bool peer_review { get; set; }
        public bool automatci_peer_review { get; set; }
        public bool notify_of_update { get; set; }
        public string group_category_id { get; set; }
        public string grade_group_students_individually { get; set; }
        public string external_tool_tag_attributes { get; set; }
        public string points_possible { get; set; }
        public string grading_type { get; set; }
        public string due_at { get; set; }
        public string lock_at { get; set; }
        public string unlock_at { get; set; }
        public string description { get; set; }
        public string assignment_group_id { get; set; }
        public string[] assignment_overrides { get; set; }
        public bool only_visible_to_overrides { get; set; }
        public bool published { get; set; }
        public string grading_standard_id { get; set; }
        public bool omit_from_final_grade { get; set; }
        public bool quiz_lti { get; set; }
        public bool moderated_grading { get; set; }
        public string grader_count { get; set; }
        public string final_grader_id { get; set; }
        public bool grader_comments_visible_to_graders { get; set; }
        public bool graders_anonymous_to_graders { get; set; }
        public bool graders_names_visible_to_final_grader { get; set; }
        public bool anonymous_grading { get; set; }
        public string allowed_attempts { get; set; }
        public string annotatable_attachment_id { get; set; }


        public string AssigPosition(string position)
        {
            return "&assignment[position]=" + position;
        } //End assignment position parameter

        public string AssignSubmissionTypesNotOnline(string submissionType)
        {
            switch (submissionType)
            {
                case "No submission":
                    return "&assignment[submission_types][]=none";
                case "On paper":
                    return "&assignment[submisison_types][]=on_paper";
                case "External Tool":
                    return "&assignment[submission_types][]=external_tool";
                default:
                    return "&assignment[submission_types][]=none";
            }//End swtich
        }//End SubmissionType

        public string AssignOnlineSubmissionTypes(bool upload, bool text, bool url, bool media)
        {
            string result = "";

            if (upload == true)
            {
                result += "&assignment[submission_types][]=online_upload";
            }
            if (text == true)
            {
                result += "&assignment[submission_types][]=online_text_entry";
            }
            if (url == true)
            {
                result += "&assignment[submission_types][]=online_url";
            }
            if (media == true)
            {
                result += "&assignment[submission_types][]=media_recording";
            }
            return result;
        }//End online submission types

        public string AssignDescription(string description)
        {
            return "&assignment[description]=" + description;
        }//End description parameter

        public string GradingType(string gradingType)
        {
            switch (gradingType)
            {
                case "Complete/Incomplete":
                    return "pass_fail";
                case "Percentage":
                    return "percent";
                case "Letter Grade":
                    return "letter_grade";
                case "GPA Scale":
                    return "gpa_scale";
                case "Points":
                    return "points";
                default:
                    return "points";
            }//end switch
        }//End grading type

        public string PointsPossible(int pointPossible)
        {
            return "&assignment[points_possible=" + pointPossible;
        }// End points possible parameter

        //Assignment group
        public string AssignmentGroup(string assignmentGroupid)
        {
            return "&assignment[assignment_group_id]=" + assignmentGroupid;
        }//End Assignment group

        //Omit from final grade
        public string OmitGrade(bool omit)
        {

            return "&assignment[omit_from_final_grade=" + omit.ToString().ToLower();

        }
        public string DueDate(bool dateChecked, DateTime date, DateTime time)
        {
            if (dateChecked == true)
            {
                string dueDate = date.ToString("yyyy-MM-dd" + "T" + time.ToString("HH:mm:ss"));
                return dueDate;
            }
            else
            {
                return "";
            }
        }// end due date method

        public string FileTypes(bool typechecked, string types)
        {
            if (typechecked == true)
            {
                string result = "[";
                string fileExt = types.Trim().Replace(" ", "");
                string[] ext = fileExt.Split(',');
                foreach (string extension in ext)
                {
                    result += $"\"{extension}\",";
                }
                result += "]";
                return result;
            }
            else
                return "";
        }//end file types method

        public string UnlockAt(bool unlock, DateTime date, DateTime time)
        {
            if (unlock == true)
            {
                string unlockDate = date.ToString("yyyy-MM-dd" + "T" + time.ToString("HH:mm:ss"));
                return "&assignment[unlock_at]=" + unlockDate;
            }
            else
            {
                return "";
            }
        }//end unlock date method

        public string LockAt(bool lockDateTime, DateTime date, DateTime time)
        {
            if (lockDateTime == true)
            {
                string lockDate = date.ToString("yyyy-MM-dd" + "T" + time.ToString("HH:mm:ss"));
                return "&assignment[lock_at]=" + lockDate;
            }
            else
            {
                return "";
            }
        }//end lock date method

        public string PeerReview(bool peer)
        {
            return "&assignment[peer_reviews]=" + peer.ToString().ToLower();
        }//end peer review method

        public string PeerReviewAuto(bool peer, bool manual)
        {
            if (peer == true && manual == false)
            {
                return "&assignment[automatic_peer_reviews]=true";
            }
            else
            {
                return "";
            }
        }//end auto peer review method

        public string GroupAssignment(bool groupAssign, string group)
        {
            if (groupAssign == true)
            {
                return "&assignment[group_category_id]=" + group;
            }
            else
            {
                return "";
            }
        }//end group assignment parameter

        public string AssignPublish(bool publishAssign)
        {
            if (publishAssign == true)
                return "&assignment[published]=true";
            else
                return "";
        }//End Publish Assignment

    }// end class
}
