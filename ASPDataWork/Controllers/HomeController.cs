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

        #region Print Values #1

        [HttpGet]
        public IActionResult PrintValue()
        {
            int age = 16;
            string name = "Andrey";
            var user = new User { Name = name, Age = age };
            
            return View(user);
        }

        #endregion

        #region Collection #2

        [HttpGet]
        public IActionResult PrintValueCollection()
        {
            #region Print Collection
            var numbersList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var numbersArray = new string[] { "1", "2", "3", };
            var users = new List<User>
            {
                new User {Name = "Matvey", Age = 22},
                new User {Name = "Sasha", Age = 42},
                new User {Name = "Oleg", Age = 19},
                new User {Name = "Maxim", Age = 35},
            };

            #endregion

            return View(users);
        }


        #endregion


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
