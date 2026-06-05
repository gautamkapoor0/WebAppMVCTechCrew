using Microsoft.AspNetCore.Mvc;
using WebAppMVCTechCrew.Models;

namespace WebAppMVCTechCrew.Controllers
{
    [SetSessionGlobally]
    public class ProductsController : Controller
    {

        public readonly AppDb _db;
        public ProductsController(AppDb db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult AddProducts()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProducts(ProductsModel data)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Add(data);
                _db.SaveChanges();
                return RedirectToAction("DisplayProducts");
            }
            else
            {
                return View();
            }
        }


        [HttpGet]
        public IActionResult DisplayProducts()
        {
            var data = _db.Products.ToList();
            return View(data);
        }

    }
}
