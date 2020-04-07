using BackOfTheNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackOfTheNet.Data
{
    public class TeamRepository
    {
        private static Team[] _teams = new Team[]
        {
            new Team()
            {
                ID = 1,
                TeamName = "Liverpool FC",
                ShortTeamName = "LFC",
                League = "Premier League",
                LeaguePos = 1,
                IsFavourite = true,
                Stadium = "Anfield"
            },
            new Team()
            {
                ID = 2,
                TeamName = "Manchester City",
                ShortTeamName = "MCI",
                League = "Premier League",
                LeaguePos = 1,
                IsFavourite = false,
                Stadium = "Ethihad"
            }
        };

        public Team[] GetTeams()
        {
            return _teams;
        }

        public Team GetTeam(int ID)
        {
            Team teamToReturn = null;

            foreach (var team in _teams)
            {
                if (team.ID == ID)
                {
                    teamToReturn = team;
                    break;
                }
            }

            return teamToReturn;
        }
    }
}
