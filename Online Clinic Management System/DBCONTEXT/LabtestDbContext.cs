using Microsoft.EntityFrameworkCore;
using Online_Clinic_Management_System.Models;

namespace Online_Clinic_Management_System.DBCONTEXT
{
    public class LabtestDbContext : DbContext
    {
        public LabtestDbContext(DbContextOptions<LabtestDbContext> options) : base(options)
        {
        }

        public DbSet<LabtestViewModel> Labtest { get; set; }
    }
}
