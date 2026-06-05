using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebAppMVCTechCrew.Models
{
    public class SetSessionGlobally : ActionFilterAttribute
    {
       
    public override void OnActionExecuting(ActionExecutingContext context)
        {
            

            // Check if user is logged in
            var loginKey = context.HttpContext.Session.GetString("MyLoginkey");

            if (string.IsNullOrEmpty(loginKey))
            {
                context.Result = new RedirectToActionResult(
                    "Login",      // Action
                    "Accounts",    // Controller
                    null);
            }

            base.OnActionExecuting(context);
        }
    }
}
