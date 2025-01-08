namespace swimming_pool.Entities
{
    public class Client
    {
        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }

        public Client()
        {
        }

        public Client(int clientID, string firstName, string lastName, string email, string phoneNumber, int age)
        {
            ClientID = clientID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Age = age;
        }
    }
}
