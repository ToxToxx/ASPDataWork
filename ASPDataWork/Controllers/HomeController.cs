using ASPDataWork.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPDataWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() => View();

        #region Вывод значений #1

        [HttpGet]
        public IActionResult PrintValue()
        {
            int age = 16;
            string name = "Andrey";
            var user = new User { Name = name, Age = age };
            
            return View(user);
        }

        #endregion

        #region Коллекция #2

        #endregion


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
