using System;

namespace uml_01
{
    public class Program
    {
        static void Main(string[] args)
        {

            Team team1 = new Team("ULHT");
            Team team2 = new Team("Nova");
            Stadium stadium =
                new Stadium("Maracanã", new GrassField(75, 110), 200_000);

            team1.SetPlayer(0, new Player("T. Alves", 1));
            team1.SetPlayer(1, new Player("D. Pires", 3));
            team1.SetPlayer(2, new Player("A. Santos", 4));
            team1.SetPlayer(3, new Player("G. Nunes", 2));
            team1.SetPlayer(4, new Player("I. Gonçalves", 11));
            team1.SetPlayer(5, new Player("J. Batista", 15));
            team1.SetPlayer(6, new Player("R. Martins", 19));
            team1.SetPlayer(7, new Player("L. Sousa", 99));
            team1.SetPlayer(8, new Player("M. Garcia", 9));
            team1.SetPlayer(9, new Player("J. Silva", 14));
            team1.SetPlayer(10, new Player("O. Fernandes", 27));

            team2.SetPlayer(0, new Player("P. Oliveira", 1));
            team2.SetPlayer(1, new Player("E. Abreu", 5));
            team2.SetPlayer(2, new Player("J. Pinto", 7));
            team2.SetPlayer(3, new Player("A. Figueiredo", 21));
            team2.SetPlayer(4, new Player("H. Ferreira", 15));
            team2.SetPlayer(5, new Player("C. Barata", 19));
            team2.SetPlayer(6, new Player("M. Santiago", 29));
            team2.SetPlayer(7, new Player("U. Gaspar", 60));
            team2.SetPlayer(8, new Player("N. Rosa", 35));
            team2.SetPlayer(9, new Player("Q. Leal", 14));
            team2.SetPlayer(10, new Player("X. Carvalho", 2));

            FootballMatch match = new FootballMatch(team1, team2, stadium);

            match.Play();

            Console.WriteLine(match);
        }
    }
}