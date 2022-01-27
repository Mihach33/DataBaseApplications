using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s20511Kolos1.DTOs
{
    public class ChampionshipDTO
    {
        public float Score { get; set; }
        public virtual List<TeamDTO> TeamsInChampionship{ get; set; }

        public class TeamDTO
        {
            public string TeamName { get; set; }
            public int MaxAge { get; set; }
        }
    }
}
