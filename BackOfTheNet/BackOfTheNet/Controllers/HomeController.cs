using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BackOfTheNet.Models;
using BackOfTheNet.Data;

namespace BackOfTheNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private TeamRepository _teamsRepo = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _teamsRepo = new TeamRepository();
        }

        public IActionResult Index()
        {
            var teams = _teamsRepo.GetTeams();
            return View(teams);
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
