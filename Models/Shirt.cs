usnig System.ComponentModel.DataAnnotations;

namespace WebAPIDemo.Models
{
    public class Shirt
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string? Color { get; set; } // it means it is optional while passing the data

        public string? Size { get; set; }

        public string Material { get; set; }
    }
}