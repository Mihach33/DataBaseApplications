using Microsoft.EntityFrameworkCore;
using s20511Kolos1.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s20511Kolos1.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext()
        {

        }

        public MainDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Championship> Championships { get; set; }
        public DbSet<Championship_Team> Championship_Teams { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player_Team> Player_Teams { get; set; }
        
        public DbSet<ChampionshipDTO> ChampionshipDTOs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=db-mssql16.pjwstk.edu.pl;Initial Catalog=s20511;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Prescription_Medicament>().HasKey(pm => new { pm.IdMedicament, pm.IdPrescription });

            modelBuilder.Entity<Player>(p =>
            { p.HasData(
                        new Player {IdPlayer = 1, FirstName = "Wayne", LastName = "Rooney", DateOfBirth = new DateTime(2000, 12, 12)},
                        new Player {IdPlayer = 2, FirstName = "Cristiano", LastName = "Ronaldo", DateOfBirth = new DateTime(1995, 01, 10)},
                        new Player {IdPlayer = 3, FirstName = "Messi", LastName = "Lionel", DateOfBirth = new DateTime(1991, 02, 09)}
                
                ); 
            });

            modelBuilder.Entity<Team>(t =>
            {
                t.HasData(
                          new Team {IdTeam = 1, TeamName = "Barcelona", MaxAge = 45 },
                          new Team { IdTeam = 2, TeamName = "Chelsea", MaxAge = 34 },
                          new Team { IdTeam = 3, TeamName = "Liverpool", MaxAge = 36 }

                  );
            });

            modelBuilder.Entity<Player_Team>(pt =>
            {
                pt.HasData(
                          new Player_Team { IdPlayerTeam = 1, IdPlayer = 2, IdTeam = 3, Comment = "qwertyui" , NumOnShirt = 9 },
                          new Player_Team { IdPlayerTeam = 2, IdPlayer = 1, IdTeam = 2, Comment = "kalsjdhfg", NumOnShirt = 7 },
                          new Player_Team { IdPlayerTeam = 3, IdPlayer = 3, IdTeam = 1, Comment = "oqiwueyrt", NumOnShirt = 10 }

                  );
            });

            modelBuilder.Entity<Championship>(c =>
            {
                c.HasData(
                          new Championship { IdChampionship = 1, OfficialName = "Champions League", Year = 2015 },
                          new Championship { IdChampionship = 2, OfficialName = "Europe League", Year = 2017 },
                          new Championship { IdChampionship = 3, OfficialName = "Super League", Year = 2020 }

                  );
            });

            modelBuilder.Entity<Championship_Team>(ct =>
            {
                ct.HasData(
                          new Championship_Team { IdChampionshipTeam = 1, IdChampionship = 1, IdTeam = 2, Score = 2.0f},
                          new Championship_Team { IdChampionshipTeam = 2, IdChampionship = 3, IdTeam = 1, Score = 2.2f },
                          new Championship_Team { IdChampionshipTeam = 3, IdChampionship = 2, IdTeam = 3, Score = 3.1f }

                  );
            });

        }
    }
}
