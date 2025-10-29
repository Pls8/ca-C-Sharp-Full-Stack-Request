using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assigments.project_4
{
    public class LeagueClass
    {
        List<TeamClass> teams;
        List<MatchClass> matches;

        public LeagueClass()
        {
            this.teams = new List<TeamClass>();
            this.matches = new List<MatchClass>();
        }


        //indexer team by name
        public TeamClass this[string teamName] {
            get {
                foreach (TeamClass tem in teams) {
                    if (tem.namE.ToLower() == teamName.ToLower())
                    {
                        return tem;
                    }
                } return null;
            }
        }



        //add team
        public void addTeam(string name, string coach) {
            TeamClass team = new TeamClass(name, coach);
            teams.Add(team);
        }


        //add players to team
        public void addPlayers(string teamName, string playerName)
        {
            TeamClass team = this[teamName];
            if (team != null)
            {
                team.playeR.Add(playerName);
            }
        }


        //match result
        public void recordMatch(string teamName1, string teamName2, int score1, int score2) {
            TeamClass team1 = this[teamName1];
            TeamClass team2 = this[teamName2];

            if (team1 != null && team2 != null) { 
                MatchClass match = new MatchClass(team1, team2, score1, score2);
                matches.Add(match);
            }
        }


        //show result
        public void showResult() {
            foreach (TeamClass team in teams) {
                int wins = 0, MatcheS = 0;
                foreach (MatchClass match in matches)
                {
                    if (match.team1 == team || match.team2 == team)
                    {
                        MatcheS++;
                        if (match.winner == team)
                        {
                            wins++;
                        }
                    }
                }
                Console.WriteLine($"team: {team.namE} | win: [{wins}] | matches: [{MatcheS}]");
            }
        }


        public void displayTeamDetails(string teamName) {
            TeamClass team = this[teamName];
            if (team != null) {
                Console.WriteLine($"Team: {team.namE} | Coach {team.coacH}" +
                    $" | players: [{team.playeR.Count}]");
                foreach (string player in team.playeR)
                {
                    Console.Write($" - {player}");
                }
            }
        }






    }
}
