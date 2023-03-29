using Microsoft.AspNetCore.Mvc;

namespace FederalWayOptometryRevamp.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
