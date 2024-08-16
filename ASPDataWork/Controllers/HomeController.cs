using ASPDataWork.Models;
using ASPDataWork.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Project;
using System.Diagnostics;

namespace ASPDataWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
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
                new() {Name = "Matvey", Age = 22},
                new() {Name = "Sasha", Age = 42},
                new() {Name = "Oleg", Age = 19},
                new() {Name = "Maxim", Age = 35},
            };

            #endregion

            return View(users);
        }


        #endregion

        #region Calculation #3

        [HttpGet]
        public IActionResult Calculate(int firstNumber, int secondNumber) //рассчёт будет в URL - но так никто не делает
        {
            var result = firstNumber + secondNumber;

            return View(result);
        }


        #endregion

        #region Adding object in DB #4

        [HttpGet]
        public IActionResult CreateUser() => View();

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();
            return View(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _userService.AddUser(model.Name, model.Age);
                return RedirectToAction("GetAllUsers");
            }
            return View();
        }

        #endregion

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
