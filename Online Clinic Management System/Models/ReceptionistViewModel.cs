using System.ComponentModel.DataAnnotations;

namespace Online_Clinic_Management_System.Models
{
    public class ReceptionistViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [Key]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }
    }
}
