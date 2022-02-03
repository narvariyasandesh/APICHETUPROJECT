namespace APICHETUPROJECT.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public string gender { get; set; }
    }
}
// now complete variable then go to in ApplicationDbContext.cs