namespace Shopping.DAL.DbContext
{
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class ShoppingContext : DbContext
    {
        public ShoppingContext(DbContextOptions<ShoppingContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<EmployeeType> EmployeeType { get; set; }

        public DbSet<Shop> Shop { get; set; }
    }
}