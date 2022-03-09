using BlazorWebApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebApp.Client.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> Search(string name, Gender? gender);
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<EmployeeDataResult> GetEmployees(int skip,int take,string orderBy);
        Task<Employee> GetEmployee(int employeeId);
        Task<Employee> GetEmployeeByEmail(string email);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task DeleteEmployee(int employeeId);
    }
}
