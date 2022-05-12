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
        //public IActionResult Nav()
        //{
        //    CompanyModel company = new CompanyModel();
        //    company.Id = 1;
        //    company.Nome = "Code.Teste";
        //    company.Cnpj = 12414114;
        //    return View(company);
        //}
        public IActionResult Index()
        {
            HomeModel home = new HomeModel();
            home.Id = 1;
            home.Nome = "João Victor";
            home.Email = "example@gmail.com";
            home.Funcao = "Programador";
            home.Salario = 3000;
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