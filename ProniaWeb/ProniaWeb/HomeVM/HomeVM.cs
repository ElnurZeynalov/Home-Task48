using ProniaWeb.Models;
using System.Collections.Generic;

namespace ProniaWeb.HomeVM
{
    public class HomeVM
    {
        List<Slider> Sliders { get; set; }
        List<Category> Categories { get; set; }
        List<Product> Products { get; set; }
    }
}
