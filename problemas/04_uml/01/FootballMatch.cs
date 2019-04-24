using System;

namespace uml_01
{
    public class FootballMatch
    {

        private Goal[] goals;

        public bool Played { get; private set; } = false;
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set;  }
        public Stadium MatchStadium { get; private set; }

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

        static void Main(string[] args)
        {
            FootballMatch match = new FootballMatch()
            {
                Team1 = new Team("ULHT"),
                Team2 = new Team("Nova"),
                MatchStadium =
                    new Stadium("Maracanã", new GrassField(75, 110), 200_000)
            };

            match.Team1.SetPlayer(0, new Player("T. Alves", 1));
            match.Team1.SetPlayer(1, new Player("D. Pires", 3));
            match.Team1.SetPlayer(2, new Player("A. Santos", 4));
            match.Team1.SetPlayer(3, new Player("G. Nunes", 2));
            match.Team1.SetPlayer(4, new Player("I. Gonçalves", 11));
            match.Team1.SetPlayer(5, new Player("J. Batista", 15));
            match.Team1.SetPlayer(6, new Player("R. Martins", 19));
            match.Team1.SetPlayer(7, new Player("L. Sousa", 99));
            match.Team1.SetPlayer(8, new Player("M. Garcia", 9));
            match.Team1.SetPlayer(9, new Player("J. Silva", 14));
            match.Team1.SetPlayer(10, new Player("O. Fernandes", 27));

            match.Team2.SetPlayer(0, new Player("P. Oliveira", 1));
            match.Team2.SetPlayer(1, new Player("E. Abreu", 5));
            match.Team2.SetPlayer(2, new Player("J. Pinto", 7));
            match.Team2.SetPlayer(3, new Player("A. Figueiredo", 21));
            match.Team2.SetPlayer(4, new Player("H. Ferreira", 15));
            match.Team2.SetPlayer(5, new Player("C. Barata", 19));
            match.Team2.SetPlayer(6, new Player("M. Santiago", 29));
            match.Team2.SetPlayer(7, new Player("U. Gaspar", 60));
            match.Team2.SetPlayer(8, new Player("N. Rosa", 35));
            match.Team2.SetPlayer(9, new Player("Q. Leal", 14));
            match.Team2.SetPlayer(10, new Player("X. Carvalho", 2));

            match.Play();

            Console.WriteLine(match);
        }
    }
}
