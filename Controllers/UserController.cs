using Microsoft.AspNetCore.Mvc;
using mvc_practice.Clinic.BL.Interfaces;

namespace mvc_practice.Controllers
{
   public class UserController : Controller
    {
        readonly IUserBL userBL;

        public UserController( IUserBL _userBL ){
            userBL = _userBL;
        }
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