using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD8.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext()
        {

        }

        public MainDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Prescription_Medicament> Prescription_Medicaments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=db-mssql16.pjwstk.edu.pl;Initial Catalog=s20511;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Prescription_Medicament>().HasKey(pm => new { pm.IdMedicament, pm.IdPrescription });


            modelBuilder.Entity<Doctor>(d => 
            {
                d.HasData(
                            new Doctor {IdDoctor = 1, FirstName = "Johny", LastName = "Syns", Email = "gdfjsfj@gmail.com" },
                            new Doctor {IdDoctor = 2, FirstName = "Josh", LastName = "Bush", Email = "qwerty@yahooo.com" },
                            new Doctor {IdDoctor = 3, FirstName = "Kappa", LastName = "Pride", Email = "kekw@twitch.com" }
                         );
            });

            modelBuilder.Entity<Patient>(p =>
            {
                p.HasData(
                            new Patient {IdPatient = 1, FirstName = "Mikey", LastName = "Hikey", Birthdate = new DateTime(2000, 12, 12) },
                            new Patient {IdPatient = 2, FirstName = "Will", LastName = "Smith", Birthdate = new DateTime(1968, 9, 25) },
                            new Patient {IdPatient = 3, FirstName = "Garik", LastName = "Harlamov", Birthdate = new DateTime(1981, 2, 28) }
                         );

            });

            modelBuilder.Entity<Prescription>(p =>
            {
                p.HasData(
                            new Prescription {IdPrescription = 1, Date = new DateTime(2019, 10, 20), DueDate = new DateTime(2019, 11, 20), IdDoctor = 1, IdPatient = 2 },
                            new Prescription {IdPrescription = 2, Date = new DateTime(2020, 1, 1), DueDate = new DateTime(2020, 1, 22), IdDoctor = 2, IdPatient = 3 },
                            new Prescription {IdPrescription = 3, Date = new DateTime(2021, 2, 3), DueDate = new DateTime(2021, 3, 6), IdDoctor = 3, IdPatient = 1 }
                         );

            });

            modelBuilder.Entity<Medicament>(m =>
            {
                m.HasData(
                           new Medicament {IdMedicament = 1, Name = "Enterasgel", Description = "dgfwqgkjsbchjewvbs,vfeuwsb fgewhmv", Type = "Pills" },
                           new Medicament {IdMedicament = 2, Name = "IbupromMax", Description = "wqgjdheywvdgcdvsbmvnbcxvnbzmn", Type = "Syrop" },
                           new Medicament {IdMedicament = 3, Name = "FizRastvor", Description = "vwqskhfhewvMVDUHDSKVBFANC", Type = "Injection" }
                         );


            });

            modelBuilder.Entity<Prescription_Medicament>(p =>
            {
                p.HasData(
                            new Prescription_Medicament {IdMedicament = 2, IdPrescription = 3, Dose = 25, Details = "jqfgdagcjqvajq,jc" },
                            new Prescription_Medicament {IdMedicament = 1, IdPrescription = 1, Dose = 10 , Details = "fhekhsjsbkadn" },
                            new Prescription_Medicament {IdMedicament = 3, IdPrescription = 2, Dose = 15, Details = "jrgewlanbwkgrbqediackbvwgkuredab,sv" }
                         );

            });
        }
    }
}
