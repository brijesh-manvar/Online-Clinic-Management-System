using Microsoft.EntityFrameworkCore;
using Online_Clinic_Management_System.Models;

namespace Online_Clinic_Management_System.DBCONTEXT
{
    public class ReceptionistDbContext : DbContext
    {
        public ReceptionistDbContext(DbContextOptions<ReceptionistDbContext> options) : base(options)
        {
        }

        public DbSet<ReceptionistViewModel> Receptionist { get; set; }
    }
}
