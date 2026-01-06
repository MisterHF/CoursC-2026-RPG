using System;
using System.Configuration;

namespace CoursC_2026_RPG
{
    public interface IEntity
    {
        Entity CreateEntity();
    }

    public class Entity : IEntity
    {
        public IStats Stats { get; private set; }
        public EntityType Type { get; private set; }

        public Entity()
        {
            Stats = new Stats();
        }

        public Entity CreateEntity()
        {
            Console.WriteLine("Entity created");
            return this;
        }

        public void SetType(EntityType type)
        {
            Type = type;
        }


        public void SetStatsEntity(StatType statType, int value)
        {
            Stats.Set(statType, value);
            Console.WriteLine($"Stat {statType} définie à {value}");
        }
    }
}
