using Microsoft.EntityFrameworkCore;
using Online_Clinic_Management_System.Models;

namespace Online_Clinic_Management_System.DBCONTEXT
{
    public class LaboratorianDbContext : DbContext
    {
        public LaboratorianDbContext(DbContextOptions<LaboratorianDbContext> options) : base(options)
        {
        }

        public DbSet<LaboratorianViewModel> Laboratorian { get; set; }
    }
}
