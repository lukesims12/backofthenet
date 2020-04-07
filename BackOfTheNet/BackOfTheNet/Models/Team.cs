using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackOfTheNet.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string TeamName { get; set; }
        public string ShortTeamName { get; set; }
        public string League { get; set; }
        public int LeaguePos { get; set; }
        public bool IsFavourite { get; set; }
        public string Stadium { get; set; }
    }
}
