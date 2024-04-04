using System.ComponentModel.DataAnnotations;

namespace Online_Clinic_Management_System.Models
{
    public class LaboratorianViewModel
    {
        [Key]
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Experience { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
       
    }
}
