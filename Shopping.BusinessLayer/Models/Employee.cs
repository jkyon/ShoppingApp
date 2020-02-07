namespace Shopping.DAL.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public String Name { get; set; }

        public String Telephone { get; set; }

        public int EmployeeTypeId { get; set; }

        [DataType(DataType.Date)]
        public DateTime EmploymentDate { get; set; }

        public EmployeeType EmployeeType { get; set; }
    }
}