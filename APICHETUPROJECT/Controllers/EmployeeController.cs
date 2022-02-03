using APICHETUPROJECT.Models;
using APICHETUPROJECT.Respository.Contract;
using APICHETUPROJECT.Respository.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICHETUPROJECT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployee employeeService;
        
        public EmployeeController(IEmployee employee)
        {
            employeeService = employee;
        }

        [HttpGet]
        [Route("GetAllEmployees")]
        public IActionResult GetAllEmployees()
        {
            var results = employeeService.GetEmployees();
            if (results.Count > 0)
            {
                return Ok(results);
            }
            else
            { 
                return NotFound("Employee not found");
            }
        }

        [HttpGet]
        [Route("GetEmployeeById/{Id}")]
        public IActionResult GetEmployeeById(int Id)
        {
            var results = employeeService.GetEmployeeById(Id);
            if (results != null)
            {
                return Ok(results);
            }
            else
            {
                return NotFound("Employee not found");
            }
        }


        [HttpPost]
        [Route("CreateEmployee")]
        public IActionResult Post(Employee employee)
        {
            var result = employeeService.PostEmployee(employee);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return Ok();
            }
        }
        [HttpDelete]
        [Route("DeleteEmployee/{Id}")]
        public IActionResult Delete(int Id)
        {
            if (Id == 0)
            {
                return BadRequest();
            }
            else
            {
                var result = employeeService.DeleteEmployee(Id);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
        }
        [HttpPut]
        [Route("UpdateEmployee")]
        public IActionResult Update(Employee emp)
        {
            if (emp == null)
            {
                return BadRequest();
            }
            else
            {
                var result = employeeService.UpdateEmployee(emp);
                if(result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                  }
            }
        }
    }
}



//Now more method impliment so we goes to EmployeeService
