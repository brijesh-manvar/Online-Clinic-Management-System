using Microsoft.AspNetCore.Mvc;
using Online_Clinic_Management_System.DBCONTEXT;
using Online_Clinic_Management_System.Models;

namespace Online_Clinic_Management_System.Controllers
{
    public class LabtestController : Controller
    {
        private LabtestDbContext s;

        public LabtestController(LabtestDbContext s)
        {
            this.s = s;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(LabtestViewModel LabtestViewModel)
        {
            s.Labtest.Add(LabtestViewModel);
            s.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
