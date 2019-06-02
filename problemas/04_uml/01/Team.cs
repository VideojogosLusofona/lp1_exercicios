namespace uml_01
{

    public class Team
    {
        private Player[] players;
        public string Name { get;  }
        public const int numPlayers = 11;

        public Team(string name)
        {
            Name = name;
            players = new Player[numPlayers];
        }

        public void SetPlayer(int i, Player player)
        {
            if ((i >= 0) && (i < numPlayers))
                players[i] = player;
        }

        public Player GetPlayer(int i)
        {
            if ((i >= 0) && (i < numPlayers))
                return players[i];
            else
                return null;
        }
    }
}
