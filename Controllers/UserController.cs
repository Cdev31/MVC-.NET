using Microsoft.AspNetCore.Mvc;
using mvc_practice.Clinic.BL.Interfaces;
using mvc_practice.Clinic.DTOs;

namespace mvc_practice.Controllers
{
   public class UserController : Controller
    {
        readonly IUserBL _userBL;

        public UserController( IUserBL userBL ){
            _userBL = userBL;
        }
        public async Task<IActionResult> Index()
        {
            List<FindUserOuputDTOs> users = await _userBL.findUsers();
        
            return View(users);
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