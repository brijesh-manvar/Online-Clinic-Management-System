using System.ComponentModel.DataAnnotations;

namespace Online_Clinic_Management_System.Models
{
    public class LabtestViewModel
    {
        [Key]
        public int LabTest { get; set; }
        public string TestCost { get; set; }
    }
}
