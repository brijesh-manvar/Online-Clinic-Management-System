using Microsoft.AspNetCore.Mvc;
using Online_Clinic_Management_System.DBCONTEXT;
using Online_Clinic_Management_System.Models;

namespace Online_Clinic_Management_System.Controllers
{
    public class PrescriptionController : Controller
    {
        
        private PrescriptionDbContext s;

        public PrescriptionController(PrescriptionDbContext s)
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
        public IActionResult Add(PrescriptionViewModel PrescriptionViewModel)
        {
            s.Prescription.Add(PrescriptionViewModel);
            s.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
