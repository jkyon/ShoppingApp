namespace Shopping.DAL.Models
{
    using System.ComponentModel.DataAnnotations;

    public class EmployeeType
    {
        [Key]
        public int EmployeeTypeId { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }
    }
}