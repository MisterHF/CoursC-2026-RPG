
namespace CoursC_2026_RPG
{
    public class Item
    {
        public string Name { get;  set; }
        public IStats Stats { get; private set; }

        public Item(string name, IStats stats)
        {
            Name = name;
            Stats = stats;
        }
        public bool IsWeapon => Stats.Get(StatType.Damage) > 0;

        public int GetDamage() => IsWeapon ? Stats.Get(StatType.Damage) : 0;
    }
}
