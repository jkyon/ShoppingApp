namespace Shopping.DAL.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Shop
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Telephone { get; set; }

        public string Address { get; set; }


    }
}