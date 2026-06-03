using Microsoft.AspNetCore.Mvc;
using WebAppMVCTechCrew.Models;

namespace WebAppMVCTechCrew.Controllers
{
    public class UsersController : Controller
    {

        //code behing
        public IActionResult Test()
        {
            TempData["message"] = "Hello from the Test action!";  // storing a message in TempData       
            return View();  // generating a view 
        }

        public IActionResult Add()
        {

            int x = 45, y = 34, z;
            z = x + y;
            TempData["res"] = z;
            return View();
        }


        // two events get and post

        [HttpGet]
        public IActionResult Sub() {
            return View();
        }
        [HttpPost]
        public IActionResult Sub(Myvalues obj)
        {
            TempData["res"] = obj.x - obj.y;
            return View();
        }

    }
}
