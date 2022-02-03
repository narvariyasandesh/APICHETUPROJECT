namespace APICHETUPROJECT.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public string  Email { get; set; }
        public string  Address { get; set; }
        public string  Mobile { get; set; }
    }
}


// Here We created variable and go to in ApplictionDbContext.cs for conncet DB setUp