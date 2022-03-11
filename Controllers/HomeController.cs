using BookingAudience.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAudience.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //todo отладка
            return RedirectToAction("Login", "Auth");
        }

        public IActionResult Success()
        {
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
