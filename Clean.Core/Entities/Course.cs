namespace swimming_pool.Entities
{
    public class Course
    {
        public int CourseID { get; set; }
        public string type { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public int Price { get; set; }
        public int SessionsCount { get; set; }
        public int SessionDuration { get; set; }
        public int InstructorID { get; set; }
        public Course()
        {
        }

        public Course(int courseID, string courseName, string description, int level, int price, int sessionsCount, int sessionDuration, int instructorID)
        {
            CourseID = courseID;
            type = courseName;
            Description = description;
            Level = level;
            Price = price;
            SessionsCount = sessionsCount;
            SessionDuration = sessionDuration;
            InstructorID = instructorID;
        }
    }
}
