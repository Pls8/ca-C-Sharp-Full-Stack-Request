using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assigments.project_4
{
    public class MatchClass
    {
        public MatchClass(TeamClass team1, TeamClass team2, int score1, int score2)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.score1 = score1;
            this.score2 = score2;

            this.winner = score1 > score2 ? team1 // if score1 > score2 then team1 winner
                : score2 > score1 ? team2 : null; // else if score2 > score1 then team2 winner
                                                 // else null
        }

        public TeamClass team1 { get; set; }
        public TeamClass team2 { get; set; }
        public int score1 { get; set; }
        public int score2 { get; set; }
        public TeamClass winner { get; set; }
    }
}
