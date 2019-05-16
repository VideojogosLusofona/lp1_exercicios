using System;

namespace uml_01
{
    public class FootballMatch
    {

        private Goal[] goals;

        public bool Played { get; private set; }
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set;  }
        public Stadium MatchStadium { get; private set; }

        public FootballMatch(Team team1, Team team2, Stadium stadium)
        {
            Played = false;
            Team1 = team1;
            Team2 = team2;
            MatchStadium = stadium;
        }

        public void Play()
        {
            Random rnd = new Random();
            int numGoals = rnd.Next(0, 8);
            goals = new Goal[numGoals];
            Played = true;
            MatchStadium.Occupancy = rnd.Next(250_000);

            for (int i = 0; i < numGoals; i++)
            {
                Team goalTeam = rnd.Next(2) == 0 ? Team1 : Team2;

                goals[i] = new Goal(
                    goalTeam,
                    goalTeam.GetPlayer(rnd.Next(Team.numPlayers)),
                    rnd.Next(91));
            }
        }

        public override string ToString()
        {
            int scoreTeam1 = 0, scoreTeam2 = 0;

            string gameDetails = $"{Team1.Name} vs {Team2.Name}\n" +
                $"Location: {MatchStadium.Name} (capacity {MatchStadium.Capacity})\n" +
                $"Attendance: {MatchStadium.Occupancy} " +
                (MatchStadium.Occupancy == MatchStadium.Capacity ? "(It's full!)" : "") +
                "\n";
            for (int i = 0; i < goals.Length; i++)
            {
                if (goals[i].Team == Team1) scoreTeam1++;
                else scoreTeam2++;
            }

            gameDetails += $"Result: {scoreTeam1} - {scoreTeam2}\n";

            for (int i = 0; i < goals.Length; i++)
            {
                gameDetails += goals[i].Player.Number + " " +
                    goals[i].Player.Name + $" ({goals[i].TimeScored}') " +
                    goals[i].Team.Name + "\n";
            }

            return gameDetails;
        }
    }
}
