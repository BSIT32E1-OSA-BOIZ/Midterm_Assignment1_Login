using Microsoft.AspNetCore.Mvc;
using MVC_Midterm_Activity.Models;
namespace MVC_Midterm_Activity.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public ActionResult Verify(AccountUser acc)
        {
            return View();
        }
    }
}
