using System;

namespace CoursC_2026_RPG
{
    public interface IEntity //, IStats
    {
        Entity CreateEntity();

    }
    public class Entity : IEntity
    {
        public Entity CreateEntity()
        {
            Console.WriteLine("Entity created");
            return this;
        }

        public void SetStatsEntity()// Argument. (StateType statType, int value)
        {
            //Stats.Set(statType, value);
            Console.WriteLine("Set values finished");
        }
    }
}
