using Microsoft.AspNetCore.Mvc;

namespace IntroToMVC_W2_Th_Sec_A.Controllers
{
    [Route("products")]
    public class ProductController : Controller
    {
        // localhost:port/products
        [Route("dashboard")]
        [Route("test")]
        public IActionResult Index()
        {
            return View();
        }

        // localhost:port/products/list
        [Route("list/{id}")]
        public IActionResult ProductList(int id)
        {
            return View();
        }
    }
}
