using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCare.Models;

namespace HealthCare.DbContexts
{
    internal class HealthCareDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=HealthCareDB; Trusted_Connection=True; TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(D =>
            {
                D.HasKey(A => new { A.DoctorId, A.PatientId });

                D.HasOne(A => A.Doctor)
                 .WithMany(d => d.Appointments)
                 .HasForeignKey(A => A.DoctorId);

                D.HasOne(A => A.Patient)
                 .WithMany(P => P.Appointments)
                 .HasForeignKey(A => A.PatientId);
            });
        }
    }
}
