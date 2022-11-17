using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login()
        {
            return View();
        }
    }
}
