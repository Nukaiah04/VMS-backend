using Microsoft.EntityFrameworkCore;
using VMS.Controllers;
using VMS.Models;

namespace VMS.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<Vitals> Vitals { get; set; }
        public DbSet<Authetication> Authetication { get; set; }
        public DbSet<Pharmacy> Pharmacy { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Hospital> Hospital { get; set; }
        public DbSet<Authorization> Authorization { get; set; }
        public DbSet<Product> Product { get; set; }
          public DbSet<Veterinary> Veterinary { get; set; }

    }
}

