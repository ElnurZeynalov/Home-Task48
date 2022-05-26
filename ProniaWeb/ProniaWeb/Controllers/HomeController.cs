using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProniaWeb.DAL;
using ProniaWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProniaWeb.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get;}
        public HomeController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Sliders = await _context.Slider.ToListAsync(),
                Categories = await _context.Category.ToListAsync(),
                Products = await _context.Products.Include(p => p.ProductImages).Include(p => p.Category).Take(8).ToListAsync()
            };
            List<Slider> slider = await _context.Slider.ToListAsync();
            return View(slider);
        }
    }
}
