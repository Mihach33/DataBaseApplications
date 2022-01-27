using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using s20511Kolos1.DTOs;
using s20511Kolos1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s20511Kolos1.Controllers
{
    [Route("api/teams")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private MainDbContext context = new MainDbContext();

        [HttpGet("{ChampionshipId}")]
        public IActionResult GetTeams(int ChampionshipId)
        {
            var result = context.Championship_Teams.Where(c => c.IdChampionship == ChampionshipId).Select(c => new {
                Score = c.Score,
                IdChampionShipTeam = c.IdChampionshipTeam,
                Team = c.Team.Where().Select(testc => new Team{ TeamName =  })


            });

            return Ok();
        }
    }
}
