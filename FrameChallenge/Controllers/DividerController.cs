using FrameChallenge.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameChallenge.Controllers
{
    [Route("api/[controller]")]
    public class DividerController : Controller
    {
        private readonly IDividersService _dividerService;

        public DividerController(IDividersService dividerService)
        {
            _dividerService = dividerService;
        }

        [HttpGet]
        public IActionResult getDividers(int number)
        {
            return Json(this._dividerService.GetDividers(number));
        }
    }
}
