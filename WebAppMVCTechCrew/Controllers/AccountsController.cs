using Microsoft.AspNetCore.Mvc;
using WebAppMVCTechCrew.Models;

namespace WebAppMVCTechCrew.Controllers
{
    public class AccountsController : Controller
    {

        public readonly AppDb _db;
        public AccountsController(AppDb db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult AddUsers()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUsers(UsersModel data)
        {
            // inserted to db --> ef core 

            _db.Users.Add(data);
            _db.SaveChanges();
            return View();
        }

        public IActionResult DisplayUsers()
        {
            return View();
        }

        public IActionResult EditUsers()
        {
            return View();
        }
        public IActionResult DeleteUsers()
        {
            return View();
        }
    }
}
