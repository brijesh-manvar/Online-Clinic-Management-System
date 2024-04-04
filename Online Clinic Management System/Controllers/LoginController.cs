using Microsoft.AspNetCore.Mvc;
using Online_Clinic_Management_System.DBCONTEXT;
using Online_Clinic_Management_System.Models;

namespace Online_Clinic_Management_System.Controllers
{
    public class LoginController : Controller
    {
        private LoginDbContext s;

        public LoginController(LoginDbContext s)
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
        public IActionResult Add(LoginModel LoginModel)
        {
            s.Users.Add(LoginModel);
            s.SaveChanges();

            return RedirectToAction("Index", "Admin");
        }

    }
}
