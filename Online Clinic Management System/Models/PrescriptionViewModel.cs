using System.ComponentModel.DataAnnotations;

namespace Online_Clinic_Management_System.Models
{
    public class PrescriptionViewModel
    {
        [Key]
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public string LabTest { get; set; }
        public string Medicines { get; set; }
        public decimal Cost { get; set; }
    }
}
