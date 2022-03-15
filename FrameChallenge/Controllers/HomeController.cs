using FrameChallenge.Models;
using FrameChallenge.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FrameChallenge.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDividersService _dividerService;

        public HomeController(ILogger<HomeController> logger, IDividersService dividerService)
        {
            _logger = logger;
            _dividerService = dividerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult getDividers(int number)
        {
            NumberDivider numberDivider = _dividerService.GetDividers(number);
            return View("Index", numberDivider);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
