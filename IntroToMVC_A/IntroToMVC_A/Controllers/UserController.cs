using Microsoft.AspNetCore.Mvc;

namespace IntroToMVC_A.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            var user = new Models.UserModel()
            {
                id= id,
                username = "JohnDoe",
                email = "john@example.com",
                password = ""
            };
            return View(user);
        }
    }
}
