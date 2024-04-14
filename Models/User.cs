namespace woofr.Models
{
    public class User
    {
        private int userId; 
        private string username;
        private string firstName;
        private string lastName;
        private string email;
        private string password; 
        private string gender; 
        //private string profilePictureUrl; 
        //private string bio; 
        private DateTime birthDate;

        public int UserId { get => userId;}
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Gender { get => gender; set => gender = value; }
        //public string ProfilePictureUrl { get => profilePictureUrl; set => profilePictureUrl = value; }
        //public string Bio { get => bio; set => bio = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public int RegisterUser()
        {
            DBservices dbs = new DBservices();
            int u_id = dbs.RegisterUser(this);
            if (u_id > 0) return u_id;
            return -1;
        }

        //public DateTime RegistrationDate { get; set; }
        //public DateTime LastLoginDate { get; set; }
        //public AccountStatus Status { get; set; } // Enum: Active, Suspended, Deleted
    }
}
