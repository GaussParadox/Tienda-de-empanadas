using System.ComponentModel.DataAnnotations;

namespace _20240813v.DTOs
{
    public class CreateProductDto
    {
        [Required]
        public string Name { get; set; }
        
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int Stock { get; set; }

        
    }
}
