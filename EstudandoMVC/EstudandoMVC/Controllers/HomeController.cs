using EstudandoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EstudandoMVC.Controllers
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
            HomeModel home = new HomeModel();
            home.Id = 1;
            home.Nome = "João Victor";
            home.Email = "example@gmail.com";
            home.ValorPago = 99;
            home.ValorFinal = home.ValorPago + 33;
            return View(home);
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