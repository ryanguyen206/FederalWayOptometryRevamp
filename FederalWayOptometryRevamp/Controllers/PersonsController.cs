using Microsoft.AspNetCore.Mvc;

namespace FederalWayOptometryRevamp.Controllers
{
    public class PersonsController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}
