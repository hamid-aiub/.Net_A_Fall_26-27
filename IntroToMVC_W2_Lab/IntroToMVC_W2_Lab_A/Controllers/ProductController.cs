using Microsoft.AspNetCore.Mvc;
using IntroToMVC_W2_Lab_A.Models;

namespace IntroToMVC_W2_Lab_A.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product[] products = new Product[5];
            for(int i=0; i<5; i++)
            {
                var product = new Product()
                {
                    id = i + 1,
                    name = "Product " + (i + 1),
                    description = "This is dummy product description",
                    price = 10.0f + i,
                    stock_quantity = 100 + i,
                    image_path = "/images/product" + (i + 1) + ".jpg"
                };
                products[i] = product;
            }
            return View(products);
        }
    }
}
