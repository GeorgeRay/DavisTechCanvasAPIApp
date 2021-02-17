using System;

namespace CanvasAPIApp
{
    class AssignmentParameters
    {
        //Get Access Token Parameter
        public string AccessToken()
        {
            return Properties.Settings.Default.CurrentAccessToken;
        }//End Get Access Token Parameter

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
                    return "&assignment[grading_type]=pass_fail";
                case "Percentage":
                    return "&assignment[grading_type]=percent";
                case "Letter Grade":
                    return "&assignment[grading_type]=letter_grade";
                case "GPA Scale":
                    return "&assignment[grading_type]=gpa_scale";
                case "Points":
                    return "&assignment[grading_type]=points";
                default:
                    return "&assignment[grading_type]=points";
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
                return "&assignment[due_at]=" + dueDate;
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
                string result = "";
                string fileExt = types.Trim().Replace(" ", "");
                string[] ext = fileExt.Split(',');
                foreach (string extension in ext)
                {
                    result += "&assignment[allowed_extensions][]=" + extension;
                }
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
