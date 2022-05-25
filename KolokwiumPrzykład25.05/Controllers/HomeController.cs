using KolokwiumPrzykład25._05.Models;
using KolokwiumPrzykład25._05.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPrzykład25._05.Controllers
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
            var result = new HardwareServicecs().GetHardware();
            return View(result);
        }

        public IActionResult Add()
        {
            var result = new HardwareModel();
            ViewBag.Companies = result.Companies;
            return View(result);
        }

        [HttpPost]
        public IActionResult Add(HardwareModel model)
        {
            new HardwareServicecs().Add(model.Hardware);

            return View();
        }

        public IActionResult Privacy()
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
