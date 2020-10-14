using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CorePalinDrone.Models;

namespace CorePalinDrone.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Palindrome()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Palindrome(string userWord)
        {
            ViewData["Result"] = string.Join("", userWord.Reverse().ToArray());
            return View();
        }

        [HttpGet]
        public IActionResult Solve()
        {
            return View();
        }

        

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
