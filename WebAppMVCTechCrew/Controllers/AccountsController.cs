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
            return RedirectToAction("DisplayUsers");
        }


        [HttpGet]
        public IActionResult DisplayUsers()
        {
            var res = _db.Users.ToList();
            return View(res);
        }


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

    }
}
