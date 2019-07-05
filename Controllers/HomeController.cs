using Microsoft.AspNetCore.Mvc;

namespace firstASP
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("projects")]
        public ViewResult Projects(){
            return View();
        }

        [HttpGet("contact")]
        public ViewResult Contact(){
            return View();
        }

        [HttpPost("post")]
        public RedirectToActionResult Data()
        {
            return RedirectToAction("Index");
        }
    }
}