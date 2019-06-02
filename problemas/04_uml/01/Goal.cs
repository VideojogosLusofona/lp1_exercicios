namespace uml_01
{
    public class Goal
    {
        public Team Team { get; }
        public Player Player { get; }
        public int TimeScored { get; }

        public Goal(Team team, Player player, int timeScored)
        {
            Team = team;
            Player = player;
            TimeScored = timeScored;
        }
    }
}
