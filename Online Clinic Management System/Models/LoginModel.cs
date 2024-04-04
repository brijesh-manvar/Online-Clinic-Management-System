using System.ComponentModel.DataAnnotations;

namespace Online_Clinic_Management_System.Models
{
    public class LoginModel
    {
        [Key]
        public string Email { get; set; }
        
        public string Password { get; set; }
    }
}
