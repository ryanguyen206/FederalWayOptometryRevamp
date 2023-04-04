using FederalWayOptometryRevamp.Data;
using FederalWayOptometryRevamp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FederalWayOptometryRevamp.Controllers
{
    public class PersonsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PersonsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Person person)
        {

           List<Person> swag = _db.Persons.Where(x => x.FirstName == person.FirstName).ToList();


            if (swag.Count > 0)
            {
                ModelState.AddModelError("FirstName", "This user already exists");

            }

            if (ModelState.IsValid)
            {
                IEnumerable<Person> allPeople = _db.Persons;
                _db.Persons.Add(person);
                _db.SaveChanges();
                return RedirectToAction("ThankYou");
            } 
            
           return View();
        }

        public IActionResult ThankYou()
        {
            IEnumerable<Person> people= _db.Persons;
            return View(people);
        }
       
     }
}
