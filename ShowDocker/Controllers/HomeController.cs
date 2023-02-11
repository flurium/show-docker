using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShowDocker.Context;
using ShowDocker.Models;
using System.Diagnostics;

namespace ShowDocker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ShowDockerDbContext db;

        public HomeController(ILogger<HomeController> logger, ShowDockerDbContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public async Task<IActionResult> Index()
        {
            await db.TopGs.AddAsync(new TopG { Name = "The King Roman Koshchei" });
            await db.SaveChangesAsync();

            var res = await db.TopGs.ToListAsync();
            return View(res);
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