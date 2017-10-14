using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace githubproj.Controllers
{
    public class firstController : Controller
    {
        public IActionResult hello()
        {
            return View();
        }
    }
}