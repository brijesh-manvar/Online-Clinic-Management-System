using Microsoft.AspNetCore.Mvc;
using Online_Clinic_Management_System.DBCONTEXT;
using Online_Clinic_Management_System.Models;

namespace Online_Clinic_Management_System.Controllers
{
    public class PatientController : Controller
    {
        private PatientDbContext s;

        public PatientController(PatientDbContext s)
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
        public IActionResult Add(PatientViewModel PatientViewModel)
        {
            s.Patient.Add(PatientViewModel);
            s.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
