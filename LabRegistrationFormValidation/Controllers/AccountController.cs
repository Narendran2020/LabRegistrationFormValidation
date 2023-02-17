using LabRegistrationFormValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabRegistrationFormValidation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserViewModel medel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


    }
}
