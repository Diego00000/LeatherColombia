using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeatherColombia.Models;

namespace LeatherColombia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ecologicos()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contactenos()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Italcur()
        {
            return View();
        }
        public IActionResult CueroAzul()
        {
            return View();
        }
        public IActionResult CueroPelo()
        {
            return View();
        }
        public IActionResult CueroCrosta()
        {
            return View();
        }
        public IActionResult CueroTerminado()
        {
            return View();
        }
        public IActionResult CueroTerminado1()
        {
            return View();
        }
        public IActionResult CueroAuto()
        {
            return View();
        }
        public IActionResult CueroCalzado()
        {
            return View();
        }
        public IActionResult CueroMarroquineria()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
