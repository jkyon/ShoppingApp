namespace Shopping.BusinessLayer.Services
{
    using System.Collections.Generic;
    using DAL.Models;

    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees { get; }

        void AddEmployee(Employee employee);


        Employee GetEmployee(int id);


        void DeleteEmployee(int id);
    }
}