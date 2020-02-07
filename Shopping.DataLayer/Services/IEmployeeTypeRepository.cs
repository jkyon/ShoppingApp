namespace Shopping.BusinessLayer.Services
{
    using System.Collections.Generic;
    using DAL.Models;

    public interface IEmployeeTypeRepository
    {
        IEnumerable<EmployeeType> GetEmployeeTypes { get; }

        void AddType(EmployeeType employee);

        EmployeeType GetEmployeeType(int id);


        void DeleteEmployeeType(int id);

    }
}