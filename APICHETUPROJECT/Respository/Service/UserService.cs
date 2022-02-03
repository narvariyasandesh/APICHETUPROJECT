using APICHETUPROJECT.Contracts.Request;
using APICHETUPROJECT.Models;
using APICHETUPROJECT.Respository.Contract;
using System.Linq;

namespace APICHETUPROJECT.Respository.Service
{
    public class UserService : IUsers
    {
        private readonly ApplicationDbContext dbContext;

        public UserService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        public Users SignIn(SignInModel model)
        {
            var user = dbContext.Users.SingleOrDefault(e => e.Email == model.Email && e.Password == model.Password);
            if(user!=null)
            {
                return user;
            }
            else
            {
                return null;
             }
        }

        public Users SignUp(SignUpModel model)
        {
            var user = new Users()
            {
                Name = model.Name,
                Email = model.Email,
                Password = model.Password,
                gender = model.gender
            };
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return user;
        }
    }
}
// complete SignIn and SignUp page go to ReadMe.txt