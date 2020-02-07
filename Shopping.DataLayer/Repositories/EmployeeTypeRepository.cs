namespace Shopping.BusinessLayer.Repositories
{
    using System.Collections.Generic;
    using DAL.DbContext;
    using DAL.Models;
    using Services;

    public class EmployeeTypeRepository : IEmployeeTypeRepository
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ShoppingContext dbContext;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        public EmployeeTypeRepository(ShoppingContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<EmployeeType> GetEmployeeTypes => this.dbContext.EmployeeType;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        public void AddType(EmployeeType employee)
        {
            this.dbContext.EmployeeType.Add(employee);
            this.dbContext.SaveChanges();
        }


        public EmployeeType GetEmployeeType(int id)
        {
            return this.dbContext.EmployeeType.Find(id);
        }

        public void DeleteEmployeeType(int id)
        {
            var entity = this.dbContext.EmployeeType.Find(id);
            this.dbContext.EmployeeType.Remove(entity);
            this.dbContext.SaveChanges();
        }
    }
}