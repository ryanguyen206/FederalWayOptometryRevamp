using Microsoft.AspNetCore.Mvc;

namespace FederalWayOptometryRevamp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
