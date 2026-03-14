using System.ComponentModel.DataAnnotations;

namespace Lesson6.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = "";

        public int Age { get; set; }

        public string Class { get; set; } = "";

        
    }
}
