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

        public IActionResult Bmi()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Bmi(Models.Bmi data)
        {
            if (data.Weight > 0 && data.Weight < 300
                && data.Height > 30 && data.Height < 250)
            {
                ViewBag.Value = _bmiService.Calculcate(data);
                return PartialView("Bmi");
            }
            return Content("<div class=\"alert alert-danger\"><strong>Error!</strong> Curious input data. Please try again!</div>");

        }

        // Use following action without ajax

        //public IActionResult Bmi(Models.Bmi data)
        //{
        //    ViewBag.Value = _bmiService.Calculcate(data);
        //    return View("Bmi");
        //}

    }
}
