using Microsoft.AspNetCore.Mvc;
using ASP.NetBMI.Services;

namespace ASP.NetBMI.Controllers
{
    public class HomeController : Controller
    {

        private readonly IBmiService _bmiService;

        public HomeController(IBmiService bmiService)
        {
            _bmiService = bmiService;
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Bmi(Models.Bmi data)
        {
            ViewBag.Value = _bmiService.Calculcate(data);
            return View("Bmi");
        }

    }
}
