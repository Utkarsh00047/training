using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace company_website.Controllers
{
    public class Company : Controller
    {
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
    }
}
