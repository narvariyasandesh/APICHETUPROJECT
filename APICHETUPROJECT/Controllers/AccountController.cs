using APICHETUPROJECT.Contracts.Request;
using APICHETUPROJECT.Contracts.Response;
using APICHETUPROJECT.Respository.Contract;
using APICHETUPROJECT.Respository.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICHETUPROJECT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IUsers UserService;
        public AccountController(IUsers user)
        {
            UserService = user;
        }

        [HttpPost]
        [Route("SignIn")]
        public ActionResult SignIn(SignInModel model)
        {
            if (model != null)
            {
                var user = UserService.SignIn(model);
                var apiResponse = new ApiResponse();
                if(user != null)
                { 
                    //not Found Failure
                    apiResponse.Ok = false;
                    apiResponse.Status = 404;
                    apiResponse.Message = "Invalid login";
                    return Ok(apiResponse);
                }
                else
                {
                    //success login
                    apiResponse.Ok = true;
                    apiResponse.Status = 200;
                    apiResponse.Message = "Login success";
                    apiResponse.Data = user;
                    apiResponse.Token = "?";
                    return Ok(apiResponse);
                }
            }
            else
            {
                return BadRequest(); 
            }
        }
        [HttpPost]
        [Route("SignUp")]
        public ActionResult SignUp(SignUpModel model)
        {
            if (model != null)
            {
                var user = userService.SignUp(model);
                var apiResponse = new ApiResponse();

                apiResponse.Ok = true;
                apiResponse.Status = 200;
                apiResponse.Message = "Create Successfully";
                apiResponse.Data = user;
           
                return Ok(apiResponse);
            }
            else
            {
                return BadRequest();
            }
            
        }
    }
}
