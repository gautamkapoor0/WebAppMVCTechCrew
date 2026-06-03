using Microsoft.AspNetCore.Mvc;
using WebAppMVCTechCrew.Models;

namespace WebAppMVCTechCrew.Controllers
{
    public class OpsController : Controller
    {
        public readonly AppDb _db;
        public OpsController(AppDb db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult AddBooks()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBooks(BooksModel data)
        {

            // data --> db
            // data -->ef core -->  db
            //1.packages
            _db.Books.Add(data);
            _db.SaveChanges();
            return View();
        }
    }
}
