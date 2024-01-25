using Microsoft.AspNetCore.Mvc;
using ValidotinExample_1.Models;

namespace ValidotinExample_1.Controllers
{
    public class ComplaintController : Controller
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
        public IActionResult Create(Complaint complaint)
        {
            if(!ModelState.IsValid)
            {
                return View(complaint);
            }

            return RedirectToAction("Index", "Complaint", complaint);
        }
    }
}
