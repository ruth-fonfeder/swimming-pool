//using swimming_pool.Controllers;
//using swimming_pool.Entities;
using System.Diagnostics.Metrics;
using System.Collections.Generic;
using swimming_pool.Entities;


namespace swimming_pool
{
    public class DataContext
    {
        public List<Course> courses { get; set; }
        public List<Instructor> instructors { get; set; }
        public List<Client> Clients { get; set; }
        public DataContext()
        {
            Clients = new List<swimming_pool.Entities.Client>
            {
                new Client(1, "John", "Doe", "john.doe@example.com", "123-456-7890", 25),
                new Client(2, "Jane", "Smith", "jane.smith@example.com", "098-765-4321", 30),
                new Client(3, "Mike", "Johnson", "mike.johnson@example.com", "555-123-4567", 22)
            };
            courses = new List<Course>
            {
                new Course(1, "Beginner Swimming", "Introduction to swimming basics", 1, 100, 10, 60, 1),
                new Course(2, "Intermediate Swimming", "Intermediate level techniques", 2, 150, 8, 75, 2),
                new Course(3, "Advanced Swimming", "Advanced skills and techniques", 3, 200, 6, 90, 3)
            };
            instructors = new List<Instructor>
            {
                new Instructor(1, "Alice", "Brown", "444-555-6666", 3, true, 5),
                new Instructor(2, "Bob", "Davis", "777-888-9999", 4, true, 3),
                new Instructor(3, "Carol", "Wilson", "333-222-1111", 5, false, 4)
            };

        }
    }
    
}
