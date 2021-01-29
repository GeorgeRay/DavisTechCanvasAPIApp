namespace CanvasAPIApp
{
    public partial class GradingQueue
    {
        public class Course
        {
            public string CourseID { get; set; }
            public string CourseName { get; set; }

            public Course(string newCourseID, string newCourseName)
            {
                CourseID = newCourseID;
                CourseName = newCourseName;
            }
        }
    }
}
