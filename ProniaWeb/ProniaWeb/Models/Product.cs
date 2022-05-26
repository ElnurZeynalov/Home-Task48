using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProniaWeb.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public float Raiting { get; set; }
        [Required]
        public int StockCount { get; set; }
        [Required]
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<ProductColor> ProductColors { get; set; }
    }
}
