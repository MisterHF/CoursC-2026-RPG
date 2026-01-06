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
        public abstract char Symbol { get; }
        
        public IStats Stats => stats;

        private IStats stats;

        public int X { get; private set; }
        public int Y { get; private set; }

        public Entity()
        {
            stats = new Stats();
            X = 0;
            Y = 0;
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

        public void SetPosition(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine($"{this.GetType().Name} positionnée en ({X}, {Y})");
        }
    }
}
