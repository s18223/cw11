using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace zad11.Models
{
    public class CustomDbContext : DbContext
    {
        public CustomDbContext() : base("CustomDbContext")
        {

        }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Medicament> Medicaments { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }

        public DbSet<PrescriptionMedicament> PrescriptionMedicament { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
