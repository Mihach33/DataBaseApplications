using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using s20511Kolos1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s20511Kolos1.Controllers
{
    [Route("api/players")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private MainDbContext context = new MainDbContext();

        [HttpPost]
        public IActionResult AddPlayer(NewPlayer newPlayer)
        {
            var Age = context.Teams.Where(t => t.TeamName == newPlayer.TeamName).Select(t => t.MaxAge);

            var agePlayer = DateTime.Now.Year - newPlayer.DateOfBirth.Year;
            if (agePlayer < 0)
            {
                return BadRequest("This player is too old");
            }

            var teamId = context.Teams.Where(t => t.TeamName == newPlayer.TeamName).Select(t => t.IdTeam).FirstOrDefault();
            var ifDublicatePlayer = context.Players.Where(p => p.LastName == newPlayer.LastName && p.FirstName == newPlayer.FirstName && p.DateOfBirth == newPlayer.DateOfBirth).Any();
            if (ifDublicatePlayer)
            {
                return BadRequest("This player already exists");
            }




            context.Database.OpenConnection();
            try
            {
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Players ON;");
                context.Players.Add(new Player
                {
                    FirstName = newPlayer.FirstName,
                    LastName = newPlayer.LastName,
                    DateOfBirth = newPlayer.DateOfBirth
                });
                
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Players OFF;");

                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Player_Teams ON;");

                context.Player_Teams.Add(new Player_Team
                {
                    IdPlayer = context.Players.Where(p => p.LastName == newPlayer.LastName && p.FirstName == newPlayer.FirstName && p.DateOfBirth == newPlayer.DateOfBirth).Select(p => p.IdPlayer).FirstOrDefault(),
                    IdTeam = teamId,
                    NumOnShirt = newPlayer.NumOnShirt,
                    Comment = newPlayer.Comment
                });

                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Player_Teams OFF;");

                context.SaveChanges();
            }
            finally
            {
                context.Database.CloseConnection();
            }


            return Ok();
        }
    }
}
