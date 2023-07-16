using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StringOut(int id, ExampleUser exampleUser)
        {
            string msg = "Hello";
            if (id == 2)
            {
                msg = "Goodbye";
            }
            return Content($"{msg}, {exampleUser.FirstName} {exampleUser.LastName}");
        }

        public IActionResult JsonOut(int id, ExampleUser exampleUser)
        {
            var obj = new { Id = id, ExampleUser = exampleUser };
            return Json(obj);
        }

        public class ExampleUser
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
