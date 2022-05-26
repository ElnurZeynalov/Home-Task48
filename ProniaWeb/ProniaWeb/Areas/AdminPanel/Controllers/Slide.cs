using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaWeb.DAL;
using ProniaWeb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProniaWeb.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class Slide : Controller
    {
        private AppDbContext _context { get; }
        public Slide(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> slider = await _context.Slider.ToListAsync();
            return View(slider);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return View();
            bool isExist = _context.Slider.Any(x => x.Title.ToLower().Trim() == slider.Title.ToLower().Trim());
            if (isExist) return View();
            await _context.Slider.AddAsync(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            Slider slider = _context.Slider.Find(id);
            if (slider == null) return NotFound();
                _context.Slider.Remove(slider);
                _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int id)
        {
            Slider slider = _context.Slider.Find(id);
            if (slider == null) return NotFound();

            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id,Slider slider)
        {
            if(slider.Id != id) return BadRequest();
            Slider sliderItem = _context.Slider.Find(id);
            if (sliderItem == null) return NotFound();
            sliderItem.Title = slider.Title;
            sliderItem.Description = slider.Description;
            sliderItem.DiscountPercent = slider.DiscountPercent;
            sliderItem.Image = slider.Image;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
