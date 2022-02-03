This is DempApi

* Setup and add packages
before start project add some pake go to in NuGet package tool
and add Microsoft.Entityframeworkcore, Microsoft.Entityframeworkcore.tool,Microsoft.Entityframeworkcore.sqlserver
1. Create Models file and create Employee.cs and ApplicationDbContext.cs (go to Employee file and See next step)


2.Create Respository folder and Two more folder create in that folder,these folder are Contract and Service,
3.Create IEmployee in Contract, and EmployeeService in Service folder and now go to in IEmployee.cs 

4. Create API EmployeeController.cs in Controller (Add => Api => APIController.cs Empty)
----------------------------------***----------------------------

User Athuntication Create 
1. create Models User.cs in Models,
2. Create folder Contract and in create two more folder Request and Response
   1. Create Models SignInModel.cs and SignUpModel  in Request
3. Create UserService in Respository/service
4. When done the Request model then create response file Whose name is ApiResponse.cs
5. Create Api AccountController, as well as do inject intrance service in StartUP.cs