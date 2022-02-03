using APICHETUPROJECT.Contracts.Request;
using APICHETUPROJECT.Models;

namespace APICHETUPROJECT.Respository.Contract
{
    public interface IUsers
    {
        //bool SignIn(SignInModel model); // both are true
        Users SignIn(SignInModel model);
        Users SignUp(SignUpModel model);
        //object SignUp(SignInModel model);
    }
}

// Completed SignIn and SignUp create folder Contract and go to Readme.txt poin user athontication
