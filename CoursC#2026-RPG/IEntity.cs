using System;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace CoursC_2026_RPG
{
    public interface IEntity
    {
        IStats Stats { get; }
    }

    public abstract class Entity : IEntity
    {
        public IStats Stats => stats;

        private IStats stats;

        public Entity()
        {
            stats = new Stats();
        }

        public Entity CreateEntity()
        {
            Console.WriteLine("Entity created");
            return this;
        }

        public void SetStatsEntity(StatType statType, int value)
        {
            Stats.Set(statType, value);
            Console.WriteLine($"Stat {statType} définie à {value}");
        }

        //public void TakeDamage(int damageAmount)
        //{
        //    int finalDamage = Math.Max(0, damageAmount - Stats.Get(StatType.Defense));
        //    int currentHealth = Stats.Get(StatType.Health);
        //    Stats.Set(StatType.Health, currentHealth - finalDamage);
        //    Console.WriteLine("Je prends des dégâts");
        //}
    }
}
