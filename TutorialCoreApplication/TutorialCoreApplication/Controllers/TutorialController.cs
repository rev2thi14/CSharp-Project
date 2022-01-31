using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorialCoreApplication.Models;

namespace TutorialCoreApplication.Controllers
{
    public class TutorialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TutorialEntry()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TutorialEntry(Tutorial tutorial)
         {
            return View();
        }
    }
}
