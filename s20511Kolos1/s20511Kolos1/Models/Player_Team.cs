using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace s20511Kolos1.Models
{
    public class Player_Team
    {
        [Key]
        public int IdPlayerTeam { get; set; }
        public int IdPlayer { get; set; }
        public int IdTeam { get; set; }
        [Required]
        public int NumOnShirt { get; set; }

        [MaxLength(300)]
        public string Comment { get; set; }

        [ForeignKey(nameof(IdPlayer))]
        public virtual Player Player { get; set; }

        [ForeignKey(nameof(IdTeam))]
        public virtual Team Team { get; set; }


    }
}
