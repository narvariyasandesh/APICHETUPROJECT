using APICHETUPROJECT.Models;
using APICHETUPROJECT.Respository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APICHETUPROJECT.Respository.Service
{
    public class EmployeeService : IEmployee    //inhertence IEmployee  and Impliment Interface
    {
        private readonly ApplicationDbContext dbContext;  // initialize DbContext  
        public EmployeeService(ApplicationDbContext _dbContext) // make Constrator
        {
            dbContext = _dbContext;
        }

        public Employee DeleteEmployee(int Id)
        {
            var emp = dbContext.Employees.SingleOrDefault(e => e.Id == Id);
            if (emp != null)
            {
                dbContext.Employees.Remove(emp);
                dbContext.SaveChanges();
                return emp;
            }
            return null;
        }

        public Employee GetEmployeeById(int Id)        
        {
            var emp = dbContext.Employees.SingleOrDefault(e => e.Id == Id);
            return emp;
        }
        
        public List<Employee> GetEmployees()
        {
            return dbContext.Employees.ToList();
        }

        public Employee PostEmployee(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
            return employee;
        }

        public Employee UpdateEmployee(Employee emp)
        {
            var eee = dbContext.Employees.SingleOrDefault(e => e.Id == emp.Id);
            if (eee != null)
            {
                eee.FirstName = emp.FirstName;
                eee.LastName = emp.LastName;
                eee.Email = emp.Email;
                eee.Address = emp.Address; 
                eee.Mobile = emp.Mobile;
                dbContext.Employees.Update(emp);
                dbContext.SaveChanges();
                return emp;           
            }
            return null; 
        }

          


        //1. Note : Now go to Startup.cs and AddTransient service
        //2. Employee Controller
    }
}
