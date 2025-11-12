using Microsoft.EntityFrameworkCore;
using VMS.Controllers;
using VMS.Models;

namespace VMS.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {

        // Tables in your database
        public DbSet<Users> Users { get; set; }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<Vitals> Vitals { get; set; }


        // public object Pharmacy { get; internal set; }
    }


}

