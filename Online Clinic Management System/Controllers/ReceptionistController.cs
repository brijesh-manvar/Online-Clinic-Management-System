using Microsoft.AspNetCore.Mvc;
using Online_Clinic_Management_System.DBCONTEXT;
using Online_Clinic_Management_System.Models;

namespace Online_Clinic_Management_System.Controllers
{
    public class ReceptionistController : Controller
    {
        private ReceptionistDbContext s;

        public ReceptionistController(ReceptionistDbContext s)
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
        public IActionResult Add(ReceptionistViewModel ReceptionistViewModel)
        {
            s.Receptionist.Add(ReceptionistViewModel);
            s.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
