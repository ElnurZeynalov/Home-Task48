using Microsoft.AspNetCore.Mvc;

namespace ProniaWeb.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class DashBoard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
