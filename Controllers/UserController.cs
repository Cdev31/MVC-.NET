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

        [HttpGet("detail/{id}")]
        public async Task<IActionResult> Detail( Guid Id )
        {
            FindUserOuputDTOs user = await _userBL.findUserById( Id );
            return View(user);
        }

        [HttpGet("user/create")]
        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create( CreateUserDTOs data ){
            
            if( !ModelState.IsValid) return View(data);
            else {
                try
                {
                    bool newUser = await _userBL.createUser( data );
                    if( newUser == false ){
                        ViewBag.ErrorMessage = "No se pudo agregar el servicio";
                        return View(data);
                    }
                    else {
                        return RedirectToAction(nameof(Index));
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = ex.Message;
                    return View();
                }
            }
        }

        [HttpGet("/update/{id}")]
        public async Task<IActionResult> Update(Guid Id ){

            FindUserOuputDTOs user = await _userBL.findUserById( Id );
            return View(user);
        }

    }
}