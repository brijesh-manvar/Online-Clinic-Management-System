using Microsoft.EntityFrameworkCore;
using Online_Clinic_Management_System.Models;

namespace Online_Clinic_Management_System.DBCONTEXT
{
    public class RegisterDbContext : DbContext
    {
        public RegisterDbContext(DbContextOptions<RegisterDbContext> options) : base(options)
        {
        }

        public DbSet<RegisterModel> Registers { get; set; }

    }
}
