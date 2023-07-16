using Microsoft.AspNetCore.Mvc;
using MyApp.Models;
using System.Diagnostics;

namespace MyApp.Controllers
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
            var ExampleUsers = new List<ExampleUser>()
            {
                new ExampleUser {Id = 1, Name = "Max", Email = "max@mail.com"},
                new ExampleUser {Id = 2, Name = "Max 1", Email = "max1@mail.com"},
                new ExampleUser {Id = 3, Name = "Max 2", Email = "max2@mail.com"},
                new ExampleUser {Id = 4, Name = "Max 3", Email = "max3@mail.com"},
                new ExampleUser {Id = 5, Name = "Max 4", Email = "max4@mail.com"},
            };
            // ViewBag.ExampleUsers = ExampleUsers;
            // ViewData["ExampleUsers"] = ExampleUsers;
            return View(ExampleUsers);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contact formData)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            // return Json(formData);
            TempData["Message"] = "Thank you for your request. We will contact you shortly.";
            return RedirectToAction("Contact");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class ExampleUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}