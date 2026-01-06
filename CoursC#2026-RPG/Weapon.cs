
namespace CoursC_2026_RPG
{
    public abstract class Weapon : Item
    {
        protected Weapon(string name, IStats stats) : base(name, stats) { }

        public int GetDamage()
        {
            return Stats.Get(StatType.Damage);
        }
    }
}
