using System.Collections.Generic;

namespace CoursC_2026_RPG
{
    public interface IStats
    {
        int Get(StatType stat);
        void Set(StatType stat, int value);
        void Add(StatType stat, int value);
    }

    public class Stats : IStats
    {
        private Dictionary<StatType, int> values = new Dictionary<StatType,int>();

        public int Get(StatType stat)
        {
            return values.TryGetValue(stat, out int value) ? value : 0;
        }

        public void Set(StatType stat, int value)
        {
            values[stat] = value;
        }

        public void Add(StatType stat, int value)
        {
            Set(stat, Get(stat) + value);
        }
    }
}
