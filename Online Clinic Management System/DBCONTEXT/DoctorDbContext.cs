using Microsoft.EntityFrameworkCore;
using Online_Clinic_Management_System.Models;
using Online_Clinic_Management_System.DBCONTEXT;


namespace Online_Clinic_Management_System.DBCONTEXT
{
    public class DoctorDbContext : DbContext
    {
        public DoctorDbContext(DbContextOptions<DoctorDbContext> options) : base(options)
        {
        }

        public DbSet<DoctorViewModel> Doctors { get; set; }

    }
}
