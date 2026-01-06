namespace CoursC_2026_RPG
{
    public class Sword : Weapon
    {
        public Sword(string name, int damage) : base(name, new Stats())
        {
            Stats.Set(StatType.Damage, damage);
        }
    }
}
