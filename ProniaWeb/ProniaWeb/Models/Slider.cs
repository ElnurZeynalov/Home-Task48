using System.ComponentModel.DataAnnotations;
namespace ProniaWeb.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required,MaxLength(25)]
        public string Title { get; set; }
        [Required,MaxLength (50)]
        public string Description { get; set; }
        [Required]
        public int DiscountPercent {get; set; }
        [Required]
        public string Image { get; set; }
    }
}
