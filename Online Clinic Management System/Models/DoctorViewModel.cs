using System.ComponentModel.DataAnnotations;

namespace Online_Clinic_Management_System.Models
{
    public class DoctorViewModel
    {
        [Key]
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Experience { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
