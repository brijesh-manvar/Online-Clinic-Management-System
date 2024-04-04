using Microsoft.AspNetCore.Mvc;

namespace Online_Clinic_Management_System.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Add more actions for other routes as needed
        public IActionResult Precription()
        {
            return View();
        }

        public IActionResult Patient()
        {
            return View();
        }

        public IActionResult LabTest()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
