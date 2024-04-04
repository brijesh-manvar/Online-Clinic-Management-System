using Microsoft.AspNetCore.Mvc;
using Online_Clinic_Management_System.DBCONTEXT;
using Online_Clinic_Management_System.Models;

namespace Online_Clinic_Management_System.Controllers
{
    public class LaboratorianController : Controller
    {
        private LaboratorianDbContext s;

        public LaboratorianController(LaboratorianDbContext s)
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
        public IActionResult Add(LaboratorianViewModel LaboratorianViewModel)
        {
            s.Laboratorian.Add(LaboratorianViewModel);
            s.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
