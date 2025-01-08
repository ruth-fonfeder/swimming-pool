namespace swimming_pool.Entities
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int Level { get; set; }
        public bool Certifications { get; set; }
        public int Availability { get; set; }

        public Instructor()
        {
        }

        public Instructor(int instructorID, string firstName, string lastName, string phoneNumber, int level, bool certifications, int availability)
        {
            InstructorID = instructorID;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Level = level;
            Certifications = certifications;
            Availability = availability;
        }
    }
}
