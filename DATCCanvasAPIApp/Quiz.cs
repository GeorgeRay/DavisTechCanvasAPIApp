using System;
using System.Collections.Generic;

namespace CanvasAPIApp
{
    public class Quiz
    {
        public string title { get; set; }
        public string description { get; set; }
        public string quiz_type { get; set; }
        public string assignment_group_id { get; set; }
        public string time_limit { get; set; }
        public bool shuffle_answers { get; set; }
        public string hide_results { get; set; }
        public bool show_correct_answers { get; set; }
        public bool show_correct_answers_last_attempt { get; set; }
        public string show_correct_aswers_at { get; set; }
        public string hide_correct_answers_at { get; set; }
        public int allowed_attempts { get; set; } = 1;
        public string scoring_policy { get; set; }
        public bool one_question_at_a_time { get; set; }
        public bool cant_go_back { get; set; }
        public string access_code { get; set; }
        public string ip_filter { get; set; }
        public string due_at { get; set; }
        public string lock_at { get; set; }
        public string unlock_at { get; set; }
        public bool published { get; set; }
        public bool one_time_results { get; set; }
        public bool only_visible_to_overrides { get; set; }
        public bool require_lockdown_browser { get; set; }
        public bool require_lockdown_browser_for_results { get; set; }


        public string QuizType(string quizType)
        {
            switch (quizType)
            {
                case "Practice Quiz":
                    return "practice_quiz";
                  
                case "Graded Quiz":
                    return "assignment";
                   
                case "Graded Survey":
                    return "graded_survey";
                
                case "Ungraded Survey":
                    return "survey";
                  
                default:
                    return "default";
                 
            }//End swtich
        }//End QuizType

  

        //Quiz Time limit
        public string QuizTimeLimit(bool timeLimit, int quizTimeLimit)
        {
            if (timeLimit == true)
                return quizTimeLimit.ToString();
            else
                return null;
        }//Quiz Time limit

        
        //Hide Results
        public string HideResults(bool seeQuizResponses, bool afterLastAttempt)
        {
            if (seeQuizResponses == false)
            {
                return "always";
            }
            if (seeQuizResponses == true && afterLastAttempt == true)
            {
                return "until_after_last_attempt";
            }
            else
                return "";
        }//end hide Results

        

        
        //Show Correct answer at
        public string ShowCorrectAnswerAt(bool showCorrectAnswer, bool showChecked, DateTime showCorrectAnswerAtDate, DateTime showCorrectAnswerAtTime)
        {
            string showDate = showCorrectAnswerAtDate.ToString("yyyy-MM-dd") + "T" + showCorrectAnswerAtTime.ToString("HH:mm:ss");
            if (showCorrectAnswer == true && showChecked == true && showCorrectAnswerAtDate.ToShortDateString() != DateTime.Now.ToShortDateString())
                return showDate;
            else
                return "";
        }//End Show Correct Answer at


        //Hide Correct answer at
        public string HideCorrectAnswerAt(bool showCorrectAnswer, bool hideChecked, DateTime hideCorrectAnswerAtDate, DateTime hideCorrectAnswerAtTime)
        {
            string hideDate = hideCorrectAnswerAtDate.ToString("yyyy-MM-dd") + "T" + hideCorrectAnswerAtTime.ToString("HH:mm:ss");
            if (showCorrectAnswer == true && hideChecked == true && hideCorrectAnswerAtDate.ToShortDateString() != DateTime.Now.ToShortDateString())
                return hideDate;
            else
                return "";
        }//End Show Correct Answer at

        //Due Date
        public string DueDate(bool dueDateChecked, DateTime dueDateChosen, DateTime dueTimeChosen)
        {
            string strDueDate = dueDateChosen.ToString("yyyy-MM-dd") + "T" + dueTimeChosen.ToString("HH:mm:ss");
            if (dueDateChecked == true && dueDateChosen.ToShortDateString() != DateTime.Now.ToShortDateString())
                return strDueDate;
            else
                return "";
        }//End Due Date
        //Unlock Date
        public string UnlockDate(bool unlockDateChecked, DateTime unlockDateChosen, DateTime unlockTimeChosen)
        {
            string strDueDate = unlockDateChosen.ToString("yyyy-MM-dd") + "T" + unlockTimeChosen.ToString("HH:mm:ss");
            if (unlockDateChecked == true && unlockDateChosen.ToShortDateString() != DateTime.Now.ToShortDateString())
                return strDueDate;
            else
                return "";
        }//End Unlock Date
        //Lock Date
        public string LockDate(bool lockDateChecked, DateTime lockDateChosen, DateTime lockTimeChosen)
        {
            string strDueDate = lockDateChosen.ToString("yyyy-MM-dd") + "T" + lockTimeChosen.ToString("HH:mm:ss");
            if (lockDateChecked == true && lockDateChosen.ToShortDateString() != DateTime.Now.ToShortDateString())
                return strDueDate;
            else
                return "";
        }//End Lock Date

        //Number of times to take quiz
        public int AllowedAttempts(bool allowMultiAttempts, bool maxAttempt, int maxNumAttempts)
        {
            if (allowMultiAttempts == true && maxAttempt == true)
                return maxNumAttempts;
            if (allowMultiAttempts == true && maxAttempt == false)
                return -1;
            else
                return 1;
        }//End Numer of time to take quiz

        //Scoring Policy
        public string ScoringPolicy(string scoringPolicy)
        {
            switch (scoringPolicy)
            {
                case "Highest":
                    return "keep_highest";
                case "Latest":
                    return "keep_latest";
                case "Average":
                    return "keep_average";
                default:
                    return "";
            }
        }//End Scoring Policy

       
        //Can't go back
        public bool CantGoBack(bool oneQuestionAtATime, bool cantGoBack)
        {
            if (oneQuestionAtATime == true && cantGoBack == true)
                return true;
            else
                return false;
        }//End Cant Go Back

        //Access Code
        public string AccessCode(bool requireAccessCode, string accessCode)
        {
            if (requireAccessCode == true && accessCode.Length > 0)
                return accessCode;
            else
                return "";
        }//End Access Code

        //IP address filtering
        public string IpAddressFiltering(bool filterAddresses, string ipAddresses)
        {
            if (filterAddresses == true && ipAddresses.Length > 0)
                return ipAddresses;
            else
                return "";
        }//End IP Address filtering

        public bool OneTimeResults(bool seeQuizResponses, bool oneTimeResults)
        {
            if (seeQuizResponses == true && oneTimeResults == true)
                return true;
            else
                return false;
        }

        public bool RequireLockdownBrowsertoVeiwResults(bool requireLockDownBrowser, bool requireLockdownBrowsertoViewResults)
        {
            if (requireLockDownBrowser == true && requireLockdownBrowsertoViewResults == true)
                return true;
            if (requireLockDownBrowser == true && requireLockdownBrowsertoViewResults == false)
                return false;
            else
                return false;

        }       

    }//End Parameter Class

} //end name space
