using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCTechCrew.Controllers
{
    public class StateManagementController : Controller
    {
        public IActionResult Page1()
        {
            ViewBag.vbmessage = "Viewbag data ex:" + System.DateTime.Now.ToString();
            ViewData["vdmessage"] = "ViewData data ex:" + System.DateTime.Now.ToString();
            TempData["tdmessage"] = "TempData data ex:" + System.DateTime.Now.ToString();
            HttpContext.Session.SetString("mysessionval", System.DateTime.Now.ToString());

            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddYears(7),
                HttpOnly = true,
                Secure = true, // Use HTTPS
                IsEssential = true
            };

            Response.Cookies.Append("techCrewkey", "Moin", options);
            // return View();
            return RedirectToAction("Page2");    // td destination ends here
        }
        public IActionResult Page2()
        {

            return View();
        }
        public IActionResult Page3()
        {
            return View();
        }
        public IActionResult Page4()
        {
            return View();
        }
        public IActionResult Page5()
        {
            return View();
        }
    }
}
