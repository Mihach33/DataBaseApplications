using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace s20511Kolos1.Models
{
    public class Team
    {
        [Key]
        public int IdTeam { get; set; }

        [MaxLength(30)]
        [Required]
        public string TeamName { get; set; }
        [Required]
        public int MaxAge { get; set; }
    }
}
