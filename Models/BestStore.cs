
using System.ComponentModel.DataAnnotations;

namespace BestStoreMVC.Models
{
    public class Product 
    {
        public int Id { get; set;} 

        [Required]
         public string Name { get; set;}
        [Required]
        public string Brand { get; set;}
        [Required]
        public string Category { get; set;}
        [Required]
        public decimal Price { get; set;}
        [Required]
        public string Description { get; set;}

        public  IFormFile? ImageFile { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}