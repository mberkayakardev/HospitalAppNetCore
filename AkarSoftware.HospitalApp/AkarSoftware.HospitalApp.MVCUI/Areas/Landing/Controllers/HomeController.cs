using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.HospitalApp.MVCUI.Areas.Landing.Controllers
{
    [Area("Landing")]
    public class HomeController  : Controller
    {
        // / url 
        public IActionResult Index()
        {
            return View();
        }
    }
}
