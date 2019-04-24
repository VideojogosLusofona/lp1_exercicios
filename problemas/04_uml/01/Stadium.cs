namespace uml_01
{
    public class Stadium
    {
        private int occupancy;

        public string Name { get; }
        public GrassField Field { get; }
        public int Capacity { get; }
        public int Occupancy {
            get
            {
                return occupancy;
            }
            set
            {
                if (value > Capacity)
                    occupancy = Capacity;
                else
                    occupancy = value;
            }
        }

        public Stadium(string name, GrassField field, int capacity)
        {
            Name = name;
            Field = field;
            Capacity = capacity;
        }
    }
}
