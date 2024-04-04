using Microsoft.AspNetCore.Mvc;
using Online_Clinic_Management_System.DBCONTEXT;
using Online_Clinic_Management_System.Models;

namespace Online_Clinic_Management_System.Controllers
{
    public class RegisterController : Controller
    {
        

        private RegisterDbContext s;

        public RegisterController(RegisterDbContext s)
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
        public IActionResult Add(RegisterModel RegisterModel)
        {
            s.Registers.Add(RegisterModel);
            s.SaveChanges();

            return RedirectToAction ("Index");
        }
    }
}
