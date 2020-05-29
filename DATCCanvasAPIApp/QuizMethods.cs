using System;
using System.Collections.Generic;

namespace CanvasAPIApp
{
    public class QuizMethods
    {
        //Get Access Token Method
        public string AccessToken()
        {
            return "access_token=" + Properties.Settings.Default.CurrentAccessToken;
        }//End Get Access Token Parameter

        public string QuizDescription(string quizDescription)
        {
            return "&quiz[description]=" + quizDescription;
        }//End Quiz Description

        public string QuizType(string quizType)
        {
            switch (quizType)
            {
                case "Practice Quiz":
                    return "&quiz[quiz_type]=practice_quiz";
                case "Graded Quiz":
                    return "&quiz[quiz_type]=assignment";
                case "Graded Survey":
                    return "&quiz[quiz_type]=graded_survey";
                case "Ungraded Survey":
                    return "&quiz[quiz_type]=survey";
                default:
                    return "default";
            }//End swtich
        }//End QuizType

        //Assignment group
        public string AssignmentGroup(string assignmentGroupid)
        {
            return "&quiz[assignment_group_id]=" + assignmentGroupid;
        }//End Assignment group

        //Quiz Time limit
        public string QuizTimeLimit(bool timeLimit, int quizTimeLimit)
        {
            if (timeLimit == true)
                return "&quiz[time_limit]=" + quizTimeLimit;
            else
                return "&quiz[time_limit]=";
        }//Quiz Time limit

        //Shuffle Questions
        public string ShuffleAnswers(bool shuffleAnswers)
        {
            if (shuffleAnswers == true)
                return "&quiz[shuffle_answers]=true";
            else
                return "";
        }//End Shuffle Questions

        //Hide Results
        public string HideResults(bool seeQuizResponses, bool afterLastAttempt)
        {
            if (seeQuizResponses == false)
            {
                return "&quiz[hide_results]=always";
            }
            if (seeQuizResponses == true && afterLastAttempt == true)
            {
                return "&quiz[hide_results]=until_after_last_attempt";
            }
            else
                return "";
        }//end hide Results

        //Show Correct Answers
        public string ShowCorrectAnswer(bool showCorrectAnswer)
        {
            if (showCorrectAnswer == true)
                return "&quiz[show_correct_answers]=true";
            else
                return "";
        }//End show Correct Answers

        //Show Correct Answers only after last attempt
        public string ShowCorrectAnswerLastAttempt(bool showCorrectAnswerLastAttempt)
        {
            if (showCorrectAnswerLastAttempt == true)
                return "&quiz[show_correct_answers_last_attempt]=true";
            else
                return "";
        }//End Show Correct Answer only after last attempt

        //Show Correct answer at
        public string ShowCorrectAnswerAt(bool showCorrectAnswer, bool showChecked, DateTime showCorrectAnswerAtDate, DateTime showCorrectAnswerAtTime)
        {
            string showDate = showCorrectAnswerAtDate.ToString("yyyy-MM-dd") + "T" + showCorrectAnswerAtTime.ToString("HH:mm:ss");
            if (showCorrectAnswer == true && showChecked == true && showCorrectAnswerAtDate.ToShortDateString() != DateTime.Now.ToShortDateString())
                return "&quiz[show_correct_answers_at]=" + showDate;
            else
                return "";
        }//End Show Correct Answer at


        //Hide Correct answer at
        public string HideCorrectAnswerAt(bool showCorrectAnswer, bool hideChecked, DateTime hideCorrectAnswerAtDate, DateTime hideCorrectAnswerAtTime)
        {
            string hideDate = hideCorrectAnswerAtDate.ToString("yyyy-MM-dd") + "T" + hideCorrectAnswerAtTime.ToString("HH:mm:ss");
            if (showCorrectAnswer == true && hideChecked == true && hideCorrectAnswerAtDate.ToShortDateString() != DateTime.Now.ToShortDateString())
                return "&quiz[hide_correct_answers_at]=" + hideDate;
            else
                return "";
        }//End Show Correct Answer at

        //Due Date
        public string DueDate(bool dueDateChecked, DateTime dueDateChosen, DateTime dueTimeChosen)
        {
            string strDueDate = dueDateChosen.ToString("yyyy-MM-dd") + "T" + dueTimeChosen.ToString("HH:mm:ss");
            if (dueDateChecked == true && dueDateChosen.ToShortDateString() != DateTime.Now.ToShortDateString())
                return "&quiz[due_at]=" + strDueDate;
            else
                return "";
        }//End Due Date
        //Unlock Date
        public string UnlockDate(bool unlockDateChecked, DateTime unlockDateChosen, DateTime unlockTimeChosen)
        {
            string strDueDate = unlockDateChosen.ToString("yyyy-MM-dd") + "T" + unlockTimeChosen.ToString("HH:mm:ss");
            if (unlockDateChecked == true && unlockDateChosen.ToShortDateString() != DateTime.Now.ToShortDateString())
                return "&quiz[unlock_at]=" + strDueDate;
            else
                return "";
        }//End Unlock Date
        //Lock Date
        public string LockDate(bool lockDateChecked, DateTime lockDateChosen, DateTime lockTimeChosen)
        {
            string strDueDate = lockDateChosen.ToString("yyyy-MM-dd") + "T" + lockTimeChosen.ToString("HH:mm:ss");
            if (lockDateChecked == true && lockDateChosen.ToShortDateString() != DateTime.Now.ToShortDateString())
                return "&quiz[lock_at]=" + strDueDate;
            else
                return "";
        }//End Lock Date

        //Number of times to take quiz
        public string AllowedAttempts(bool allowMultiAttempts, bool maxAttempt, int maxNumAttempts)
        {
            if (allowMultiAttempts == true && maxAttempt == true)
                return "&quiz[allowed_attempts]=" + maxNumAttempts;
            if (allowMultiAttempts == true && maxAttempt == false)
                return "&quiz[allowed_attempts]=-1";
            else
                return "";
        }//End Numer of time to take quiz

        //Scoring Policy
        public string ScoringPolicy(string scoringPolicy)
        {
            switch (scoringPolicy)
            {
                case "Highest":
                    return "&quiz[scoring_policy]=keep_highest";
                case "Latest":
                    return "&quiz[scoring_policy]=keep_latest";
                case "Average":
                    return "&quiz[scoring_policy]=keep_average";
                default:
                    return "";
            }
        }//End Scoring Policy

        //One Question at a time
        public string OneQuestionAtATime(bool oneQuestionAtATime)
        {
            if (oneQuestionAtATime == true)
                return "&quiz[one_question_at_a_time]=true";
            else
                return "";
        }//End One Question at at Time

        //Can't go back
        public string CantGoBack(bool oneQuestionAtATime, bool cantGoBack)
        {
            if (oneQuestionAtATime == true && cantGoBack == true)
                return "&quiz[cant_go_back]=true";
            else
                return "";
        }//End Cant Go Back

        //Access Code
        public string AccessCode(bool requireAccessCode, string accessCode)
        {
            if (requireAccessCode == true && accessCode.Length > 0)
                return "&quiz[access_code]=" + Uri.EscapeDataString(accessCode);
            else
                return "";
        }//End Access Code

        //IP address filtering
        public string IpAddressFiltering(bool filterAddresses, string ipAddresses)
        {
            if (filterAddresses == true && ipAddresses.Length > 0)
                return "&quiz[ip_filter]=" + Uri.EscapeDataString(ipAddresses);
            else
                return "";
        }//End IP Address filtering

        public string OneTimeResults(bool seeQuizResponses, bool oneTimeResults)
        {
            if (seeQuizResponses == true && oneTimeResults == true)
                return "&quiz[one_time_results]=true";
            else
                return "";
        }

        public string RequireLockdownBrowser(bool requireLockdownBrowser)
        {
            if (requireLockdownBrowser == true)
            {
                return "&quiz[require_lockdown_browser]=true";
            }
            else
                return "";
        }// End Require Lock Down Browser

        public string RequireLockdownBrowsertoVeiwResults(bool requireLockDownBrowser, bool requireLockdownBrowsertoViewResults)
        {
            if (requireLockDownBrowser == true && requireLockdownBrowsertoViewResults == true)
                return "&quiz[require_lockdown_browser_for_results]=true";
            if (requireLockDownBrowser == true && requireLockdownBrowsertoViewResults == false)
                return "&quiz[require_lockdown_browser_for_results]=false";
            else
                return "";

        }

        public string PublishQuiz(bool publishQuiz)
        {
            if (publishQuiz == true)
                return "&quiz[published]=true";
            else
                return "";
        }//End Publish Quiz

    }//End Parameter Class

} //end name space
