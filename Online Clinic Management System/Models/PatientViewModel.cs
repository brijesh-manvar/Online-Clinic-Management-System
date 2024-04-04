using System.ComponentModel.DataAnnotations;

namespace Online_Clinic_Management_System.Models
{
    public class PatientViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [Key]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNo { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        public string Allergies { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public string DateOfBirth { get; set; }
    }
}
