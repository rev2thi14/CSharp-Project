using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityBusManagementSystem.UI.Controllers
{
    public class RoutesDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RouteDetailsEntry()
        {
            return View();
        }
    }
}
