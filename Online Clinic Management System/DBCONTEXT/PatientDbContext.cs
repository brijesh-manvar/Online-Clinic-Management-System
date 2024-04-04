using Microsoft.EntityFrameworkCore;
using Online_Clinic_Management_System.Models;

namespace Online_Clinic_Management_System.DBCONTEXT
{
    public class PatientDbContext : DbContext
    {
        public PatientDbContext(DbContextOptions<PatientDbContext> options) : base(options)
        {
        }

        public DbSet<PatientViewModel> Patient { get; set; }
    }
}
