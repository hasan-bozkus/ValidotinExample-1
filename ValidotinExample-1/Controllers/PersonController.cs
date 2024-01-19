using Microsoft.AspNetCore.Mvc;
using ValidotinExample_1.Models;

namespace ValidotinExample_1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (!ModelState.IsValid)
            {
                return View(person);
            }
            return RedirectToAction("Index", person);
        }
    }
}
