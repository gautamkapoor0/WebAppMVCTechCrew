using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
        [SetSessionGlobally]
        [HttpGet]
        public IActionResult AddUsers()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult AddUsers(UsersModel data)
        {
            // inserted to db --> ef core 

            if (ModelState.IsValid)  // false when any of the property is null or empty or not valid based on the data annotations
            {
                _db.Users.Add(data);
                _db.SaveChanges();
                return RedirectToAction("Login");
            }
            else
            {
                ModelState.AddModelError("err", "Invalid Email or Password");
                return View();
            }
        }

        [SetSessionGlobally]
        [HttpGet]
        public IActionResult DisplayUsers()
        {
           
            var res = _db.Users.ToList();
            return View(res);
        }

        [SetSessionGlobally]
        [HttpGet]
        public IActionResult EditUsers(int id)
        {
            var res = _db.Users.Where(x => x.ID == id).FirstOrDefault();
            return View(res);
        }

        [HttpPost]
        public IActionResult EditUsers(UsersModel data)
        {
            _db.Users.Update(data);  // all the records based on pk (ID)
            _db.SaveChanges();
            return RedirectToAction("DisplayUsers");
        }
        [SetSessionGlobally]
        [HttpGet]
        public IActionResult DeleteUsers(int id)
        {
            var res = _db.Users.Where(x => x.ID == id).FirstOrDefault();
            return View(res);
        }

        [HttpPost]
        public IActionResult DeleteUsers(UsersModel data)
        {
            var find = _db.Users.Find(data.ID);
            if (find != null)
            {
                _db.Users.Remove(find);
                _db.SaveChanges();
                return RedirectToAction("DisplayUsers");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel data)
        {
            var res = _db.Users.Any(x => x.Email == data.Email && x.Password == data.Password);
            if (res)
            {
                HttpContext.Session.SetString("MyLoginkey",data.Email);
                return RedirectToAction("Homepage");
            }
            else
            {
                TempData["error"] = "Invalid credentials";
                return View();
            }
        }
        [SetSessionGlobally]
        public IActionResult HomePage()
        {
           
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

    }
}
