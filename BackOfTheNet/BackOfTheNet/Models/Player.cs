using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackOfTheNet.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string Position { get; set; }
        public int NumGoals { get; set; }
        public int NumAssists { get; set; }
        public int NumAppearences { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }

        public string DisplayText
        {
            get
            {
                return Name + " - " + TeamName;
            }
        }
    }
}
