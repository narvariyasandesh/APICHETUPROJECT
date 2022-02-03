using APICHETUPROJECT.Models;  
using System.Collections.Generic;

namespace APICHETUPROJECT.Respository.Contract
{
    public interface IEmployee
    {
        List<Employee> GetEmployees();
        Employee PostEmployee(Employee employee);
        Employee GetEmployeeById(int Id);
        Employee DeleteEmployee(int Id);
        Employee UpdateEmployee(Employee emp);
       
    }
}


// go to in EmployeeService 