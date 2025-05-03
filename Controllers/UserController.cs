using Microsoft.AspNetCore.Mvc;

namespace mvc_practice.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet("detail")]
        public IActionResult Detail()
        {
            
            return View();
        }

        [HttpGet("user/create")]
        public IActionResult Create(){
            return View();
        }

        [HttpGet("update")]
        public IActionResult Update(){
            return View();
        }

    }
}