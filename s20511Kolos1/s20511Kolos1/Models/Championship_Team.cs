using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace s20511Kolos1.Models
{
    public class Championship_Team
    {
        [Key]
        public int IdChampionshipTeam { get; set; }
        [Required]
        public int IdTeam { get; set; }
        [Required]
        public int IdChampionship { get; set; }
        [Required]
       
        public float Score { get; set; }

        [ForeignKey(nameof(IdChampionship))]
        public Championship Championship { get; set; }
        
        [ForeignKey(nameof(IdTeam))]
        public Team Team { get; set; }

    }
}
