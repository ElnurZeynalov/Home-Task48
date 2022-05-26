using Microsoft.EntityFrameworkCore;
using ProniaWeb.Models;

namespace ProniaWeb.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<ProductColor> ProductColor { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
    }
}
