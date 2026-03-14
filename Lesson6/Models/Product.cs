using System.ComponentModel.DataAnnotations;

namespace Lesson6.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public double Price { get; set; }

        public double Class { get; set; }


    }
}