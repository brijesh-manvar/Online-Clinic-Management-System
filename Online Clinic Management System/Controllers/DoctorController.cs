using Microsoft.AspNetCore.Mvc;
using Online_Clinic_Management_System.DBCONTEXT;
using Online_Clinic_Management_System.Models;
using System.Numerics;

namespace Online_Clinic_Management_System.Controllers
{
    public class DoctorController : Controller
    {
        private DoctorDbContext s;

        public DoctorController(DoctorDbContext s)
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
        public IActionResult Add(DoctorViewModel DoctorViewModel)
        {
            s.Doctors.Add(DoctorViewModel);
            s.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
