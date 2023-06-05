using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfaasDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [Authorize]
        public IActionResult Profile()
        {
            return View("Profile");
        }


        [HttpPost("/EfaasCallback")]
        public IActionResult EfaasCallBack(string code)
        {
            return RedirectToAction("Profile", "Home");
        }

        [Authorize]
        [HttpGet("/efaas-one-tap-login")]
        public IActionResult EfaasOneTapLogin(string efaas_login_code)
        {
            return RedirectToAction("Profile", "Home");
        }
    }
}
