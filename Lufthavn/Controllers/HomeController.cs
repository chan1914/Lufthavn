using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lufthavn.Models;
using Lufthavn.Models.FlightDescription;
using Microsoft.EntityFrameworkCore;



namespace Lufthavn.Controllers
{
    public class HomeController : Controller
    {
        private readonly FlightContext _context;

        public HomeController(FlightContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> FlightRute(string FlightFrom = "", string FlightTo = "")
        {
			
            return View((await _context.Flight.ToListAsync()).Where(x => x.FromLocation.ToUpper().Contains(FlightFrom.ToUpper())));
            
        }

        public IActionResult CreateNewFlightRute()
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
