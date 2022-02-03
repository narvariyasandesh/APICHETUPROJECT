namespace APICHETUPROJECT.Contracts.Request
{
    public class SignUpModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; } 
        public string gender { get; set; }
    }
}
 