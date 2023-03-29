using Microsoft.AspNetCore.Mvc;

namespace FederalWayOptometryRevamp.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
