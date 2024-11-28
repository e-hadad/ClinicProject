using Clinic.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace clinic
{
    public class DataContext : DbContext
    {
        public DbSet<RoutesClass> ListRoutes { get; set; }
        public DbSet<DoctorClass> ListDoctors { get; set; }

        public DbSet<PatientClass> ListPatient { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Clinic");
        }
    }
};