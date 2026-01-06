namespace CoursC_2026_RPG
{
    public abstract class Item
    {
        public string Name { get; protected set; }
        public IStats Stats { get; protected set; }

        protected Item(string name, IStats stats)
        {
            Name = name;
            Stats = stats;
        }
    }
}
