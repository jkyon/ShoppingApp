namespace Shopping.BusinessLayer.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using DAL.DbContext;
    using DAL.Models;
    using Microsoft.EntityFrameworkCore;
    using Services;

    public class EmployeeRepository : IEmployeeRepository
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ShoppingContext dbContext;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        public EmployeeRepository(ShoppingContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Employee> GetEmployees => this.dbContext.Employee.Include(x => x.EmployeeType);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        public void AddEmployee(Employee employee)
        {
            this.dbContext.Employee.Add(employee);
            this.dbContext.SaveChanges();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employee GetEmployee(int id)
        {
            return this.dbContext.Employee.Include(x => x.EmployeeType).FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void DeleteEmployee(int id)
        {
            var entity = this.dbContext.Employee.Find(id);
            this.dbContext.Employee.Remove(entity);
            this.dbContext.SaveChanges();
        }
    }
}