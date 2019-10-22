using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvc_app.Filters;
using mvc_app.Models;

namespace mvc_app.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ErroresFilter]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.User.Equals("juan"))
                {
                    HttpContext.Session.SetString("Autenticado", "True");
                    HttpContext.Session.SetString("User", model.User);
                    return RedirectToAction("UserSpace");
                }
                else
                {
                    return RedirectToAction("AuthError");
                }
            }
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult UserSpace()
		{
			return View();
		}

        [HttpPost]
		[ValidateAntiForgeryToken]
        [ErroresFilter]
        public IActionResult UserSpace(LoginViewModel model)
		{
			return View(model);
		}

        public IActionResult AuthError()
		{
			return View();
		}
    }
}
